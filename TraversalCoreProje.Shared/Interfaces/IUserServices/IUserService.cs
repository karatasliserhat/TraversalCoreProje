namespace TraversalCoreProje.Shared.Interfaces
{
    public interface IUserService
    {
        string GetUser { get; }
        string AccessToken { get; }
        string Role { get; }
        void TokenHeaderAuthorization(HttpClient httpClient, string Token);
    }
}
