namespace TraversalCoreProje.BusinessLayer.Tools
{
    public interface IJwtTokenGenerator
    {
        TokenResponseModel GenerateToken(GetCheckUserModel model);
    }
}
