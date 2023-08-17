namespace JWTAPI.Services.Interface
{
    public interface IToken
    {
        string GenerateToken(string username, string role);
    }
}
