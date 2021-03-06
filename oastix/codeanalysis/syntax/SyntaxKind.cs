namespace Oastix.CodeAnalysis.Syntax {

    public enum SyntaxKind {

        //Tokens
        BadToken,
        EndOfFileToken,
        WhitespaceToken,
        NumberToken,
        PlusToken,
        MinusToken,
        StarToken,
        SlashToken,
        BangToken,
        AmpersandAmpersandToken,
        PipePipeToken,
        BangEqualsToken,
        EqualsEqualsToken,
        OpenParenthesisToken,
        CloseParenthesisToken,
        IdentifierToken,

        // Keywords
        FalseKeyword,
        TrueKeyword,

        //Expressions
        LiteralExpression,
        BinaryExpression,
        ParenthesisedExpression,
        UnaryExpression
    }
}