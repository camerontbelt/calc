public class Token
{
    public TokenTypes Type {get;}
    public string Value {get;}
    public Token(TokenTypes type, string value)
    {
        Type = type;
        Value = value;
    }

    public override string ToString()
    {
        var result = $"<'{Value}',{Type}>";
        return result;
    }
}