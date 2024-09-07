namespace TraversalCoreProje.BusinessLayer.Tools
{
    public interface IJwtTokenModel
    {
        string Audience { get; set; }
        string Issuer { get; set; }
        string Key { get; set; }
        int ExpireDate { get; set; }
    }
}
