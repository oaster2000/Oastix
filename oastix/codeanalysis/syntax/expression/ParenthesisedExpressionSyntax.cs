using System.Collections.Generic;

namespace Oastix.CodeAnalysis.Syntax {

    public sealed class ParenthesisedExpressionSyntax : ExpressionSyntax {

        public ParenthesisedExpressionSyntax(SyntaxToken openParenthesisToken, ExpressionSyntax expression, SyntaxToken closedParenthesisToken) {

            OpenParenthesisToken = openParenthesisToken;
            Expression = expression;
            ClosedParenthesisToken = closedParenthesisToken;
        }


        public override SyntaxKind Kind => SyntaxKind.ParenthesisedExpression;
        public SyntaxToken OpenParenthesisToken { get; }
        public ExpressionSyntax Expression { get; }
        public SyntaxToken ClosedParenthesisToken { get; }

        public override IEnumerable<SyntaxNode> GetChildren() {
            yield return OpenParenthesisToken;
            yield return Expression;
            yield return ClosedParenthesisToken;
        }
    }
}