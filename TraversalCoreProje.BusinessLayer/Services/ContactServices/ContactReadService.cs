using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class ContactReadService : GenericReadService<ResultContactDto, Contact>, IContactReadService
    {
        public ContactReadService(IGenericReadRepository<Contact> genericReadRepository, IMapper mapper) : base(genericReadRepository, mapper)
        {
        }
    }
}
