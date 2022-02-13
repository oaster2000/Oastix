namespace compiler.codeAnalysis{
 class SyntaxToken : SyntaxNode
    {
        public SyntaxToken(SyntaxKind kind, int position, string text, object value)
        {

            _kind = kind;
            _position = position;
            _text = text;
            _value = value;

        }

        public override SyntaxKind _kind { get; }
        public int _position { get; }
        public string _text { get; }
        public object _value { get; }


        public override IEnumerable<SyntaxNode> GetChildren()
        {
            return Enumerable.Empty<SyntaxToken>();
        }
    }
}