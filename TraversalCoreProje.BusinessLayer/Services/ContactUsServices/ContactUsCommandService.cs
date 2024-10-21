using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class ContactUsCommandService : GenericCommandService<UpdateContactUsDto, CreateContactUsDto, ContactUs>, IContactUsCommandServices
    {
        public ContactUsCommandService(IGenericCommandRepository<ContactUs> genericCommandRepository, IMapper mapper) : base(genericCommandRepository, mapper)
        {
        }
    }
}
