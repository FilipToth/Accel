using System.Collections.Immutable;
using Alto.CodeAnalysis.Syntax;
using Alto.CodeAnalysis.Binding;

namespace Alto.CodeAnalysis.Symbols
{

    public sealed class ClassSymbol : Symbol
    {
        internal ClassSymbol(string name, ImmutableArray<FunctionSymbol> functions, 
                           ImmutableArray<BoundBlockStatement> functionBodies, SyntaxTree tree = null)
            : base(name)
        {
            Functions = functions;
            FunctionBodies = functionBodies;
            Tree = tree;
        }

        public override SymbolKind Kind => SymbolKind.Class;
        public ImmutableArray<FunctionSymbol> Functions;
        internal ImmutableArray<BoundBlockStatement> FunctionBodies;
        public SyntaxTree Tree;

        public override string ToString() => Name;
    }
}