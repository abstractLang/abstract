using Abstract.Parser.Core.Language.SyntaxNodes.Control;
using Abstract.Parser.Core.ProgData;

namespace Abstract.Parser.Core.ProgMembers;

public class Function(
    ProgramMember? parent,
    MemberIdentifier identifier,
    FunctionDeclarationNode node
) : ProgramMember(parent, identifier)
{
    public readonly FunctionDeclarationNode functionNode = node;
    public BlockNode FunctionBody => functionNode.Body;

    public TypeReference returnType = null!;
    public TypeReference[] parameterTypes = null!;

    public bool IsGeneric => _generics.Count > 0;

    protected Dictionary<MemberIdentifier, TypeReference> _generics = [];

    public void AppendGeneric(MemberIdentifier identifier, int idx)
    {
        _generics.Add(identifier, new GenericTypeReference(this, idx));
    }
    public override ProgramMember? SearchForChild(MemberIdentifier identifier)
    {
        /*
        * Functions does not owns nothing
        * other than some generic type
        * references, so we throw the search
        * call for the parent.  
        */
        return parent!.SearchForChild(identifier);
    }
    public TypeReference? SearchForGeneric(MemberIdentifier identifier)
    {
        if (_generics.TryGetValue(identifier, out var r)) return r;
        return null;
    }

    public override string ToString()
        => $"{GlobalReference}({string.Join(", ", (object?[])parameterTypes)}) -> {returnType}";
}