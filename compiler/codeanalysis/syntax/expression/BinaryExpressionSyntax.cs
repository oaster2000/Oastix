namespace compiler.codeAnalysis
{
    public sealed class BinaryExpressionSyntax : ExpressionSyntax
    {

        public BinaryExpressionSyntax(ExpressionSyntax left, SyntaxToken operatorToken, ExpressionSyntax right)
        {

            _left = left;
            _operatorToken = operatorToken;
            _right = right;

        }

        public override SyntaxKind _kind => SyntaxKind.BinaryExpression;
        public ExpressionSyntax _left { get; }
        public SyntaxToken _operatorToken { get; }
        public ExpressionSyntax _right { get; }

        public override IEnumerable<SyntaxNode> GetChildren()
        {
            yield return _left;
            yield return _operatorToken;
            yield return _right;
        }
    }
}