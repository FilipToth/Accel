using System.Collections.Immutable;
using Alto.CodeAnalysis.Syntax;
using Alto.CodeAnalysis.Binding;

namespace Alto.CodeAnalysis.Symbols
{

    public sealed class ClassSymbol : Symbol
    {
        internal ClassSymbol(string name, ClassDeclarationSyntax declaration, SyntaxTree tree = null)
            : base(name)
        {
            Declaration = declaration;
            Tree = tree;
        }

        public override SymbolKind Kind => SymbolKind.Class;
        public ClassDeclarationSyntax Declaration { get; }
        public SyntaxTree Tree;

        public override string ToString() => Name;
    }
}