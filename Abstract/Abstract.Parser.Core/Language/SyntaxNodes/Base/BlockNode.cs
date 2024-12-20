using System.Text;
using Abstract.Parser.Core.Language.SyntaxNodes.Base;

namespace Abstract.Parser.Core.Language.SyntaxNodes.Control;

public class BlockNode : SyntaxNode
{
    public IEnumerable<SyntaxNode> Content => _children.Count > 2 ? _children[1..^1] : [];
    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(_children[0].ToString());

        if (_children.Count > 2)
        {
            foreach (var i in _children[1..^1])
            {
                var lines = i.ToString().Split("\n", StringSplitOptions.RemoveEmptyEntries);
                foreach (var j in lines) sb.AppendLine($"\t{j}");
            }
        }

        sb.AppendLine(_children[^1].ToString());

        return sb.ToString();
    }
}