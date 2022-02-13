namespace compiler.codeAnalysis
{
    public sealed class LiteralExpressionSyntax : ExpressionSyntax
    {

        public LiteralExpressionSyntax(SyntaxToken literalToken)
        {

            _literalToken = literalToken;

        }

        public override SyntaxKind _kind => SyntaxKind.LiteralExpression;
        public SyntaxToken _literalToken { get; }

        public override IEnumerable<SyntaxNode> GetChildren()
        {
            yield return _literalToken;
        }
    }
}