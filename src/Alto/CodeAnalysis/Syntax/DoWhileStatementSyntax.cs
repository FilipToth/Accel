namespace Alto.CodeAnalysis.Syntax
{
    internal class DoWhileStatementSyntax : StatementSyntax
    {
        public DoWhileStatementSyntax(SyntaxTree syntaxTree, SyntaxToken doKeyword, StatementSyntax body, 
            SyntaxToken whileKeyword, ExpressionSyntax condition)
            : base(syntaxTree)
        {
            DoKeyword = doKeyword;
            Body = body;
            WhileKeyword = whileKeyword;
            Condition = condition;
        }

        public SyntaxToken DoKeyword { get; }
        public StatementSyntax Body { get; }
        public SyntaxToken WhileKeyword { get; }
        public ExpressionSyntax Condition { get; }

        public override SyntaxKind Kind => SyntaxKind.DoWhileStatement;
    }
} 

