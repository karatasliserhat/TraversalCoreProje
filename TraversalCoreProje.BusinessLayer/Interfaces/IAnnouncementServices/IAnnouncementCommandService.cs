using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IAnnouncementCommandService:IGenericCommandService<UpdateAnnouncementDto,CreateAnnouncementDto,Announcement>
    {
    }
}
