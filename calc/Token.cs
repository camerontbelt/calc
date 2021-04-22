public class Token
{
    public TokenTypes Type {get;}
    public string Value {get;}
    public int LineNumber { get; set; }
    public Token(TokenTypes type, string value)
    {
        Type = type;
        Value = value;
    }

    public Token(TokenTypes type, string value, int lineNumber)
    {
        Type = type;
        Value = value;
        LineNumber = lineNumber;
    }

    public override string ToString()
    {
        var result = $"<'{Value}',{Type},{LineNumber}>";
        return result;
    }
}