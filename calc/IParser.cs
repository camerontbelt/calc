public interface IParser
{
    
    void Match(TokenTypes tokenType);

    void Devour();

    TokenTypes LookAhead(int index);

    Token LookAheadToken(int index);
}