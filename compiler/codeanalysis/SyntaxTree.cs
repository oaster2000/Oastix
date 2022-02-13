namespace compiler.codeAnalysis
{
    public sealed class SyntaxTree
    {
        public SyntaxTree(IEnumerable<string> diagnostics, ExpressionSyntax root, SyntaxToken endOfFileToken)
        {
            _diagnostics = diagnostics.ToArray();
            _root = root;
            _endOfFileToken = endOfFileToken;
        }

        public IReadOnlyList<string> _diagnostics { get; }
        public ExpressionSyntax _root { get; }
        public SyntaxToken _endOfFileToken { get; }

        public static SyntaxTree Parse(string text)
        {
            var parser = new Parser(text);
            return parser.Parse();
        }
    }
}