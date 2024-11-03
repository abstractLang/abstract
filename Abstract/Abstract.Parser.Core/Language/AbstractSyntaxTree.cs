﻿using Abstract.Build.Core.Sources;
using System.Collections;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace Abstract.Parser.Core.Language.AbstractSyntaxTree;

public abstract class SyntaxNode
{
    public (uint start, uint end) Range = (0, 0);

    public virtual Script SourceScript => Parent?.SourceScript ?? null!;
    public SyntaxNode? Parent { get; set; }
    public List<AttributeNode> Attributes { get; set; } = [];

    public bool HasAttribute(string name) => Attributes.Any(e => e.Symbol.ToString() == name);
    public AttributeNode GetAttribute(string name) => Attributes.First(e => e.Symbol.ToString() == name);
    public bool TryGetAttribute(string name, out AttributeNode attribute)
    {
        attribute = Attributes.FirstOrDefault(e => e.Symbol.ToString() == name)!;
        return attribute != null;
    }

    public string AttributesToString() => string.Join(" ", Attributes) + '\n';
    public override string ToString() => $"{GetType().Name}SyntaxNode";
}
public abstract class ScopeNode<T> : SyntaxNode, IEnumerable<T> where T : SyntaxNode
{
    protected readonly List<T> children = [];
    public T[] Children => [.. children];

    public void AppendChild(T node)
    {
        children.Add(node);
        node.Parent = this;
    }
    public void AppendChildren(params T[] nodes)
    {
        foreach (var i in nodes)
        {
            children.Add(i);
            i.Parent = this;
        }
    }

    public void RemoveChild(T node) => children.Remove(node);

    public IEnumerator<T> GetEnumerator() => children.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public override string ToString()
    {
        if (children.Count == 0) return "{}";

        StringBuilder str = new();

        str.AppendLine("{");

        foreach (var i in children)
        {
            var l = (i.AttributesToString() + i.ToString())
                .Replace("\r\n", "\n")
                .Split('\n', StringSplitOptions.RemoveEmptyEntries);

            foreach (var j in l) str.AppendLine($"\t{j}");
        }

        str.AppendLine("}");

        return str.ToString();
    }
}
public interface IReferenceable
{
    public IReferenceable? Parent { get; set; }
    public MasterSymbol Symbol { get; set; }
    public TypeNode ReturnType { get; set; }

    public ReferenceSymbol GetGlobalSymbol();
}

// Scope
public class ProgramRoot(string programName) : ScopeNode<ScriptRoot>, IReferenceable
{
    public MasterSymbol Symbol { get; set; } = new([programName], null!);
    public TypeNode ReturnType { get => null!; set { } }
    public new IReferenceable? Parent { get => null!; set { } }

    public readonly Guid ProgramId = Guid.NewGuid();

    public ReferenceSymbol GetGlobalSymbol() => new(Symbol.Tokens, Symbol);
    public override string ToString()
    {
        var str = new StringBuilder();

        str.AppendLine($"Program: {Symbol}");
        str.AppendLine($"GUID: {ProgramId}");

        str.Append(base.ToString());

        return str.ToString();
    }
}
public class ScriptRoot(Script src) : ScopeNode<SyntaxNode>, IReferenceable
{
    private Script _sourceScript = src;

    public override Script SourceScript => _sourceScript;
    public string ScriptName => _sourceScript.Name;

    public new IReferenceable? Parent { get => base.Parent as IReferenceable; set => base.Parent = (SyntaxNode)value!; }
    public MasterSymbol Symbol { get => Parent?.Symbol!; set { } }
    public TypeNode ReturnType { get => Parent!.ReturnType; set => Parent!.ReturnType = value; }

    public override string ToString() => $"{SourceScript.GetType().Name} \"{ScriptName}\" {base.ToString()}";

    ReferenceSymbol IReferenceable.GetGlobalSymbol() => Parent!.GetGlobalSymbol();
}
public class NamespaceNode : ScopeNode<SyntaxNode>, IReferenceable
{
    public new IReferenceable? Parent { get => base.Parent as IReferenceable; set => base.Parent = (SyntaxNode)value!; }
    public MasterSymbol Symbol { get; set; } = null!;
    public TypeNode ReturnType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


    public ReferenceSymbol GetGlobalSymbol() => new((string[])[.. Parent?.GetGlobalSymbol().Tokens ?? [], ..Symbol.Tokens], Symbol);
    public override string ToString() => $"namespace {Symbol} {base.ToString()}";
}
public class FunctionNode : ScopeNode<SyntaxNode>, IReferenceable
{
    public new IReferenceable? Parent { get => base.Parent as IReferenceable; set => base.Parent = (SyntaxNode)value!; }
    public MasterSymbol Symbol { get; set; } = null!;
    public ParameterCollectionNode Parameters { get; set; } = null!;
    public TypeNode ReturnType { get; set; } = null!;


    public ReferenceSymbol GetGlobalSymbol() => new((string[])[.. Parent?.GetGlobalSymbol().Tokens ?? [], .. Symbol.Tokens], Symbol);
    public override string ToString() => $"func {ReturnType} {Symbol} {Parameters} {base.ToString()}";
}
public class StructureNode : ScopeNode<SyntaxNode>, IReferenceable
{
    public new IReferenceable? Parent { get => base.Parent as IReferenceable; set => base.Parent = (SyntaxNode)value!; }
    public MasterSymbol Symbol { get; set; } = null!;
    public ParameterCollectionNode? GenericParameters { get; set; } = null;
    public TypeNode ReturnType { get; set; } = null!;
    public TypeNode? ExtendsType { get; set; } = null;

    public ReferenceSymbol GetGlobalSymbol() => new((string[])[.. Parent?.GetGlobalSymbol().Tokens ?? [], .. Symbol.Tokens], Symbol);
    public override string ToString() => $"struct {Symbol} "
        + (ExtendsType != null ? $"extends {ExtendsType}" : "") + $" {base.ToString()}";
}

public class CodeBlockNode : ScopeNode<StatementNode>
{
}

public class AttributeNode : SyntaxNode
{
    public ISymbol Symbol { get; set; } = null!;
    public ArgumentCollectionNode Arguments { get; set; } = null!;

    public override string ToString() => $"@{Symbol}{Arguments}";
}

public abstract class StatementNode : SyntaxNode
{

}

// Data
public class VariableDeclarationNode(bool constant) : StatementNode, IReferenceable
{
    public new IReferenceable? Parent { get => base.Parent as IReferenceable; set => base.Parent = (SyntaxNode)value!; }

    public readonly bool constant = constant;
    public MasterSymbol Symbol { get; set; } = null!;
    public TypeNode ReturnType { get; set; } = null!;

    public ExpressionNode? Value { get; set; } = null;

    public ReferenceSymbol GetGlobalSymbol() => new((string[])[.. Parent?.GetGlobalSymbol().Tokens ?? [], .. Symbol.Tokens], Symbol);
    public override string ToString() => (!constant ? "let " : "const ") + $"{ReturnType} {Symbol}"
        + (Value != null ? $" = {Value}" : "");
}

// Some controll collections (nothing to do with abstract's collections)
public class ParameterCollectionNode : ScopeNode<ParameterNode>
{
        public override string ToString() => $"({string.Join(", ", children)})";
}
public class ArgumentCollectionNode : ScopeNode<ExpressionNode>
{
    public override string ToString() => $"({string.Join(", ", children)})";
}

public class ParameterNode : SyntaxNode, IReferenceable
{
    public new IReferenceable? Parent { get; set; }
    public MasterSymbol Symbol { get; set; } = null!;
    public TypeNode ReturnType { get; set; } = null!;

    public ReferenceSymbol GetGlobalSymbol() => new((string[])[.. Parent?.GetGlobalSymbol().Tokens ?? [], .. Symbol.Tokens], Symbol);

    public override string ToString() => $"{ReturnType} {Symbol}";
}

public abstract class ExpressionNode : StatementNode
{
    public ISymbol ExpressionType { get; set; } = null!;
}

public abstract class ValueExpressionNode : ExpressionNode
{

}
public abstract class ValueCollectionNode<T> : ValueExpressionNode, IEnumerable<T> where T : ExpressionNode
{
    protected readonly List<T> children = [];
    public T[] Children => [.. children];

    public void AppendChild(T node)
    {
        children.Add(node);
        node.Parent = this;
    }
    public void AppendChildren(params T[] nodes)
    {
        foreach (var i in nodes)
        {
            children.Add(i);
            i.Parent = this;
        }
    }

    public IEnumerator<T> GetEnumerator() => children.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

// Type nodes
public abstract class TypeNode : SyntaxNode { }

public class ReferenceTypeNode(ISymbol symbol) : TypeNode
{
    public ISymbol symbol = symbol;
    public override string ToString() => $"{symbol}";
}
public class GenericTypeNode : TypeNode { }

public abstract class TypeModifier(TypeNode baseType) : TypeNode
{
    public readonly TypeNode baseType = baseType;
}

public class ArrayType(TypeNode baseType) : TypeModifier(baseType)
{
    public override string ToString() => $"[]{baseType}";
}
public class ReferenceType(TypeNode baseType) : TypeModifier(baseType)
{
    public override string ToString() => $"*{baseType}";
}

// General statements
public class WhileStatementNode : ExpressionNode
{
    public ExpressionNode condition = null!;
    public SyntaxNode statement = null!;

    public override string ToString() => $"while {condition} => {statement}";
}

public class ForStatementNode : StatementNode
{
    public ValueExpressionNode Symbol { get; set; } = null!;
    public RangeLiteralValueNode ConditionRange { get; set; } = null!;
    public SyntaxNode statement = null!;

    public override string ToString() => $"for {Symbol} in {ConditionRange} => {statement}";
}

public class IfStatementNode : ExpressionNode
{
    public ExpressionNode condition = null!;
    public SyntaxNode statement = null!;

    public override string ToString() => $"if {condition} => {statement}";
}
public class ElifStatementNode : ExpressionNode
{
    public ExpressionNode condition = null!;
    public SyntaxNode statement = null!;

    public override string ToString() => $"elif {condition} => {statement}";
}
public class ElseStatementNode : ExpressionNode
{
    public SyntaxNode statement = null!;

    public override string ToString() => $"else => {statement}";
}

public class ReturnStatementNode : StatementNode
{
    public ExpressionNode? expression = null;

    public override string ToString() => "return" + (expression != null ? $" {expression}" : "");
}

// Operation expressions
public class AssignmentExpressionNode(ExpressionNode l, string op, ExpressionNode r) : ExpressionNode
{
    public ExpressionNode Left { get; private set; } = l;
    public ExpressionNode Right { get; private set; } = r;
    public string Operator { get; private set; } = op;

    public override string ToString() => $"{Left} {Operator} {Right}";
}

public class BinaryOperationExpressionNode(ExpressionNode l, string op, ExpressionNode r) : ExpressionNode
{
    public ExpressionNode Left { get; private set; } = l;
    public ExpressionNode Right { get; private set; } = r;
    public string Op { get; private set; } = op;

    public override string ToString() => $"{Left} {Op} "
        + (Right is BinaryOperationExpressionNode ? $"({Right})" : $"{Right}");
}

public class UnaryOperationExpressionNode(string op, ExpressionNode ex) : ExpressionNode
{
    public ExpressionNode Expression { get; private set; } = ex;
    public string Op { get; private set; } = op;

    public override string ToString() => $"{Op}{Expression}";
}

// Collections
public class CollectionExpressionNode : ValueCollectionNode<ExpressionNode>
{
    public override string ToString() => $"[{string.Join(", ", children)}]";
}

// Dynamic Values
public class MethodCallNode : ValueExpressionNode
{
    public ISymbol Symbol { get; set; } = null!;
    public ArgumentCollectionNode args = null!;

    public override string ToString() => $"{Symbol}{args}";
}
public class IdentifierNode(ISymbol symbol) : ValueExpressionNode
{
    public ISymbol symbol = symbol;
    public override string ToString() => $"{symbol}";
}

// Literal values
public class NumericLiteralNode(BigInteger value) : ValueExpressionNode
{
    public BigInteger value = value;
    public override string ToString() => $"{value}";
}
public class FloatingLiteralNode(double value) : ValueExpressionNode
{
    public double value = value;
    public override string ToString() => value.ToString(CultureInfo.InvariantCulture);
}
public class StringLiteralValueNode(string value) : ValueExpressionNode
{
    public string value = value;
    public override string ToString() => $"\"{value}\"";
}
public class BooleanLiteralValueNode(bool value) : ValueExpressionNode
{
    public bool value = value;
    public override string ToString() => $"{value}";
}
public class RangeLiteralValueNode : ValueExpressionNode
{
    public ValueExpressionNode? start = null;
    public ValueExpressionNode? end = null;
    public ValueExpressionNode? step = null;

    public override string ToString() => $"{start}..{end}" + (step != null ? $" by {step}" : "");
}
