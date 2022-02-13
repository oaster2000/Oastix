namespace compiler.codeAnalysis{
sealed class NumberExpressionSyntax : ExpressionSyntax
    {

        public NumberExpressionSyntax(SyntaxToken numberToken)
        {

            _numberToken = numberToken;

        }

        public override SyntaxKind _kind => SyntaxKind.NumberExpression;
        public SyntaxToken _numberToken { get; }

        public override IEnumerable<SyntaxNode> GetChildren()
        {
            yield return _numberToken;
        }
    }
}