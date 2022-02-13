namespace compiler.codeAnalysis
{
    public sealed class Evaluator
    {

        private readonly ExpressionSyntax _root;

        public Evaluator(ExpressionSyntax root)
        {
            this._root = root;
        }

        public int Evaluate()
        {
            return EvaluateExpression(_root);
        }

        private int EvaluateExpression(ExpressionSyntax node)
        {
            if (node is LiteralExpressionSyntax n)
                return (int)n._literalToken._value;

            if (node is BinaryExpressionSyntax b)
            {
                var left = EvaluateExpression(b._left);
                var right = EvaluateExpression(b._right);

                if (b._operatorToken._kind == SyntaxKind.PlusToken)
                    return left + right;
                else if (b._operatorToken._kind == SyntaxKind.MinusToken)
                    return left - right;
                else if (b._operatorToken._kind == SyntaxKind.StarToken)
                    return left * right;
                else if (b._operatorToken._kind == SyntaxKind.SlashToken)
                    return left / right;
                else
                    throw new Exception($"Unexpected binary operator {b._operatorToken._kind}");
            }

            if (node is ParenthesisedExpressionSyntax p)
            {
                return EvaluateExpression(p._expression);
            }

            throw new Exception($"Unexpected node {node._kind}");
        }
    }
}