using System;
using System.Linq;
using Oastix.CodeAnalysis.Binding;
using Oastix.CodeAnalysis.Syntax;

namespace Oastix.CodeAnalysis {
    public class Compilation {

        public Compilation(SyntaxTree syntax) {
            Syntax = syntax;
        }

        public SyntaxTree Syntax { get; }

        public EvaluationResult Evaluate() {
            var binder = new Binder();
            var boundExpression = binder.BindExpression(Syntax.Root);

            var diagnsotics = Syntax.Diagnostics.Concat(binder.Diagnostics);
            if (diagnsotics.Any()) {

                return new EvaluationResult(diagnsotics, null);
            }

            var evaluator = new Evaluator(boundExpression);
            var value = evaluator.Evaluate();

            return new EvaluationResult(Array.Empty<string>(), value);
        }
    }
}