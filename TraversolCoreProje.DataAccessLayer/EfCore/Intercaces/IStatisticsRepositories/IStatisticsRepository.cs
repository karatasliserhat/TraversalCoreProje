namespace TraversolCoreProje.DataAccessLayer.EfCore.Intercaces
{
    public interface IStatisticsRepository
    {
        Task<int> DestinationCount();
        Task<int> GuideCount();
        Task<int> TestimonialCount();
    }
}
