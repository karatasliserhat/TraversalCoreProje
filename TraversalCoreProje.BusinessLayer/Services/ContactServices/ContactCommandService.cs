using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class ContactCommandService : GenericCommandService<UpdateContactDto, CreateContactDto, Contact>, IContactCommandService
    {
        public ContactCommandService(IGenericCommandRepository<Contact> genericCommandRepository, IMapper mapper) : base(genericCommandRepository, mapper)
        {
        }
    }
}
