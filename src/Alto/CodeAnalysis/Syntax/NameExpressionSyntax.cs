using System.Collections.Immutable;

namespace Alto.CodeAnalysis.Syntax
{
    public sealed class NameExpressionSyntax : ExpressionSyntax
    {
        internal NameExpressionSyntax(SyntaxTree syntaxTree, SyntaxToken identifierToken, ImmutableArray<SyntaxToken>? followingIdentifiers = null)
            : base(syntaxTree)
        {
            IdentifierToken = identifierToken;
            FollowingIdentifiers = followingIdentifiers;
        }

        public override SyntaxKind Kind => SyntaxKind.NameExpression;
        public SyntaxToken IdentifierToken { get; }
        public ImmutableArray<SyntaxToken>? FollowingIdentifiers { get; }
    }
}