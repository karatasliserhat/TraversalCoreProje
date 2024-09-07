namespace TraversalCoreProje.BusinessLayer.Tools
{
    public class JwtTokenModel : IJwtTokenModel
    {
        public string Audience { get; set ; }
        public string Issuer { get; set; }
        public string Key { get; set; }
        public int ExpireDate { get; set; }
    }
}
