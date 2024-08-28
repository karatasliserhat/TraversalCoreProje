namespace TraversolCoreProje.DataAccessLayer.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task SaveChangeAsync();
        void SaveChange();
    }
}
