using System.Collections.Immutable;

namespace Alto.CodeAnalysis.Syntax
{
    public class ClassBodyStatementSyntax : StatementSyntax
    {
        public ClassBodyStatementSyntax(SyntaxTree syntaxTree, SyntaxToken OpenBraceToken, 
                               ImmutableArray<MemberSyntax> memebers, ImmutableArray<StatementSyntax> statements,
                               SyntaxToken ClosedBraceSyntax)
            : base(syntaxTree)
        {
            this.OpenBraceToken = OpenBraceToken;
            Memebers = memebers;
            Statements = statements;
            this.ClosedBraceSyntax = ClosedBraceSyntax;
        }

        public SyntaxToken OpenBraceToken { get; }
        public ImmutableArray<MemberSyntax> Memebers { get; }
        public ImmutableArray<StatementSyntax> Statements { get; }
        public SyntaxToken ClosedBraceSyntax { get; }

        public override SyntaxKind Kind => SyntaxKind.ClassBodyStatementSyntax;
    }
}