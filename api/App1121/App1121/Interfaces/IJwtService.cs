namespace App1121.Interfaces
{
    public interface IJwtService
    {
        string GetJwtToken(int userId, string role);
    }
}