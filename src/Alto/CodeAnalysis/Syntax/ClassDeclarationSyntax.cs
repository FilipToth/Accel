namespace Alto.CodeAnalysis.Syntax
{
    public class ClassDeclarationSyntax : MemberSyntax
    {
        public ClassDeclarationSyntax(SyntaxTree syntaxTree, SyntaxToken keyword, SyntaxToken identifier, ClassBodyStatementSyntax body)
            : base(syntaxTree)
        {
            Keyword = keyword;
            Identifier = identifier;
            Body = body;
        }

        public SyntaxToken Keyword { get; }
        public SyntaxToken Identifier { get; }
        public ClassBodyStatementSyntax Body { get; }

        public override SyntaxKind Kind => SyntaxKind.ClassDeclaration;
    }
}