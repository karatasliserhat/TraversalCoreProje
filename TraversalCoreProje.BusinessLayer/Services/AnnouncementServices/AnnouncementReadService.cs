using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class AnnouncementReadService : GenericReadService<ResultAnnouncementDto, Announcement>, IAnnouncementReadService
    {
        public AnnouncementReadService(IGenericReadRepository<Announcement> genericReadRepository, IMapper mapper) : base(genericReadRepository, mapper)
        {
        }
    }
}
