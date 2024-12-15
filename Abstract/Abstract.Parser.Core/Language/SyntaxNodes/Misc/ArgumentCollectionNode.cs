using Abstract.Parser.Core.Language.SyntaxNodes.Base;

namespace Abstract.Parser.Core.Language.SyntaxNodes.Misc;

public class ArgumentCollectionNode : SyntaxNode
{
    public override string ToString() => $"({string.Join(", ", _children[1..^1])})";
}
