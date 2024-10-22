using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class AnnouncementCommandService : GenericCommandService<UpdateAnnouncementDto, CreateAnnouncementDto, Announcement>, IAnnouncementCommandService
    {
        public AnnouncementCommandService(IGenericCommandRepository<Announcement> genericCommandRepository, IMapper mapper) : base(genericCommandRepository, mapper)
        {
        }
    }
}
