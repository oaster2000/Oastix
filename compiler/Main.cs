using compiler.codeAnalysis;

namespace compiler
{

    class Program
    {
        static void Main(string[] args)
        {
            bool showTree = false;
            while (true)
            {
                Console.Write(">");

                var line = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(line))
                    return;
                if (line == "#showTree")
                {
                    showTree = !showTree;
                    Console.WriteLine(showTree ? "Showing parse trees." : "Not showing parse trees.");
                    continue;
                }
                else if (line == "#cls")
                {
                    Console.Clear();
                    continue;
                }
                else if (line == "#exit")
                {
                    return;
                }

                var syntaxTree = SyntaxTree.Parse(line);

                if (showTree)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    PrettyPrint(syntaxTree._root);
                    Console.ResetColor();
                }

                if (!syntaxTree._diagnostics.Any())
                {
                    var e = new Evaluator(syntaxTree._root);
                    var result = e.Evaluate();
                    Console.WriteLine(result);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    foreach (var diagnostic in syntaxTree._diagnostics)
                        Console.WriteLine(diagnostic);
                    Console.ResetColor();
                }
            }

            static async void PrettyPrint(SyntaxNode node, string indent = "", bool isLast = true)
            {
                var marker = isLast ? "└── " : "├── ";

                Console.Write(indent);
                Console.Write(marker);
                Console.Write(node._kind);

                if (node is SyntaxToken t && t._value != null)
                {
                    Console.Write(" ");
                    Console.Write(t._value);
                }

                Console.WriteLine();

                indent += isLast ? "    " : "│   ";

                var lastChild = node.GetChildren().LastOrDefault();

                foreach (var child in node.GetChildren())
                {
                    PrettyPrint(child, indent, child == lastChild);
                }
            }

        }
    }
}