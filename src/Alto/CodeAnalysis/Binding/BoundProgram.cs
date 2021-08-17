using System.Collections.Immutable;
using Alto.CodeAnalysis.Symbols;

namespace Alto.CodeAnalysis.Binding
{
    internal sealed class BoundProgram
    {
        public BoundProgram(DiagnosticBag diagnostics, 
                            ImmutableDictionary<FunctionSymbol, BoundBlockStatement> functionBodies,
                            ImmutableDictionary<ClassSymbol, BoundBlockStatement> classBodies,
                            BoundBlockStatement statement)
        {
            Statement = statement;
            Diagnostics = diagnostics;
            FunctionBodies = functionBodies;
            ClassBodies = classBodies;
        }

        public BoundBlockStatement Statement { get; }
        public DiagnosticBag Diagnostics { get; }
        public ImmutableDictionary<FunctionSymbol, BoundBlockStatement> FunctionBodies { get; }
        public ImmutableDictionary<ClassSymbol, BoundBlockStatement> ClassBodies { get; }
    }
}