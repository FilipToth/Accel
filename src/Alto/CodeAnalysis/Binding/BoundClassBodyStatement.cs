using System.Collections.Immutable;
using Alto.CodeAnalysis.Symbols;

namespace Alto.CodeAnalysis.Binding
{
    internal sealed class BoundClassBodyStatement : BoundStatement
    {
        public BoundClassBodyStatement(ImmutableList<FunctionSymbol> functions, ImmutableDictionary<FunctionSymbol, BoundBlockStatement> immutableDictionary)
        {
            Functions = functions;
            ImmutableDictionary = immutableDictionary;
        }
        
        public override BoundNodeKind Kind => BoundNodeKind.ClassBodyStatement;
        public ImmutableList<FunctionSymbol> Functions { get; }
        public ImmutableDictionary<FunctionSymbol, BoundBlockStatement> ImmutableDictionary { get; }
    }
}