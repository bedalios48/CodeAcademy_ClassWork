namespace App1121.Interfaces
{
    public interface IOpenRouteProxyService
    {
        Task<string> GetCityInfo(string city);
    }
}