namespace Grams.Code_Analysis
{
    public enum SyntaxKind
    {
        // Tokens
        BadToken,
        EndOfFileToken,
        WhiteSpaceToken,
        NumberToken,       
        PlusToken,
        MinusToken,
        StarToken,
        SlashToken,
        OpenParenthesisToken,
        CloseParenthesisToken,
        
        // Expressions
        NumberExpression,
        BinaryExpression,
        ParenthesizedExpression
    }
}
