namespace compiler.codeAnalysis{
sealed class ParenthesisedExpressionSyntax : ExpressionSyntax
    {
        public ParenthesisedExpressionSyntax(SyntaxToken openParenthesisToken, ExpressionSyntax expression, SyntaxToken closedParenthesisToken)
        {
            _openParenthesisToken = openParenthesisToken;
            _expression = expression;
            _closedParenthesisToken = closedParenthesisToken;
        }


        public override SyntaxKind _kind => SyntaxKind.ParenthesisedExpression;
        public SyntaxToken _openParenthesisToken { get; }
        public ExpressionSyntax _expression { get; }
        public SyntaxToken _closedParenthesisToken { get; }

        public override IEnumerable<SyntaxNode> GetChildren()
        {
            yield return _openParenthesisToken;
            yield return _expression;
            yield return _closedParenthesisToken;
        }
    }
}