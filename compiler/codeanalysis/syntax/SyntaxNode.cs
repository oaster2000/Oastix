namespace compiler.codeAnalysis
{
    public abstract class SyntaxNode
    {

        public abstract SyntaxKind _kind { get; }

        public abstract IEnumerable<SyntaxNode> GetChildren();

    }
}