using System.Collections.Immutable;
using System.Linq;

namespace Alto.CodeAnalysis.Syntax
{
    public sealed class CallExpressionSyntax : ExpressionSyntax
    {
        public CallExpressionSyntax(SyntaxTree syntaxTree, ImmutableArray<SyntaxToken> identifiers, SyntaxToken openParenthesisToken, SeparatedSyntaxList<ExpressionSyntax> arguments, SyntaxToken closedParenthesisToken)
            : base(syntaxTree)
        {
            Identifiers = identifiers;
            OpenParenthesisToken = openParenthesisToken;
            Arguments = arguments;
            ClosedParenthesisToken = closedParenthesisToken;
        }

        public override SyntaxKind Kind => SyntaxKind.CallExpression;
        public ImmutableArray<SyntaxToken> Identifiers { get; }
        public SyntaxToken Identifier { 
            get { 
                return Identifiers.FirstOrDefault(); 
            }
        }
        public SyntaxToken OpenParenthesisToken { get; }
        public SeparatedSyntaxList<ExpressionSyntax> Arguments { get; }
        public SyntaxToken ClosedParenthesisToken { get; }
    }
}