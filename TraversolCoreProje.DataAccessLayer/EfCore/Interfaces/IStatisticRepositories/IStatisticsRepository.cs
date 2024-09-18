namespace TraversolCoreProje.DataAccessLayer.EfCore.Interfaces
{
    public interface IStatisticsRepository
    {
        Task<int> DestinationCount();
        Task<int> GuideCount();
        Task<int> TestimonialCount();
    }
}
