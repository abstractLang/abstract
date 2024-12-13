﻿namespace Abstract.Parser.Core.Language.AbstractSyntaxTree.CodeInstructions;

// General statements
public class WhileStatementNode : InstructionalNode
{
    public ExpressionNode condition = null!;
    public SyntaxNode statement = null!;

    public override string ToString() => $"while {condition} => {statement}";
}

public class ForStatementNode : InstructionalNode
{
    public ValueExpressionNode Symbol { get; set; } = null!;
    public RangeLiteralValueNode ConditionRange { get; set; } = null!;
    public SyntaxNode statement = null!;

    public override string ToString() => $"for {Symbol} in {ConditionRange} => {statement}";
}

public class IfStatementNode : InstructionalNode
{
    public ExpressionNode condition = null!;
    public SyntaxNode statement = null!;

    public override string ToString() => $"if {condition} => {statement}";
}
public class ElifStatementNode : InstructionalNode
{
    public ExpressionNode condition = null!;
    public SyntaxNode statement = null!;

    public override string ToString() => $"elif {condition} => {statement}";
}
public class ElseStatementNode : InstructionalNode
{
    public SyntaxNode statement = null!;

    public override string ToString() => $"else => {statement}";
}

public class ReturnInstructionNode : InstructionalNode
{
    public ExpressionNode? expression = null;

    public override string ToString() => "return" + (expression != null ? $" {expression}" : "");
}

