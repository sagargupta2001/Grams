namespace Grams.Code_Analysis
{
    public sealed class LiteralExpressionSyntax : ExpressionSyntax
    {
        public LiteralExpressionSyntax(SyntaxToken literalToken)
        {
            this.literalToken = literalToken;
        }

        public override SyntaxKind Kind => SyntaxKind.LiteralExpression;
        public SyntaxToken literalToken { get; }

        public override IEnumerable<SyntaxNode> GetChildren()
        {
            yield return literalToken;
        }
    }
}
