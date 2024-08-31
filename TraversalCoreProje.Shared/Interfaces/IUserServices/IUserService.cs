namespace TraversalCoreProje.Shared.Interfaces
{
    public interface IUserService
    {
        string GetUser { get; }
        string AccessToken { get; }
        void TokenHeaderAuthorization(HttpClient httpClient, string Token);
    }
}
