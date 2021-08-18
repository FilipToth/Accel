using System.Collections.Immutable;
using System.Linq;

namespace Alto.CodeAnalysis.Syntax
{
    public sealed class NameExpressionSyntax : ExpressionSyntax
    {
        internal NameExpressionSyntax(SyntaxTree syntaxTree, ImmutableArray<SyntaxToken> identifiers)
            : base(syntaxTree)
        {
            Identifiers = identifiers;
        }

        public override SyntaxKind Kind => SyntaxKind.NameExpression;
        public ImmutableArray<SyntaxToken> Identifiers { get; }
        public SyntaxToken IdentifierToken { 
            get {
                return Identifiers.FirstOrDefault();
            } 
        }
    }
}