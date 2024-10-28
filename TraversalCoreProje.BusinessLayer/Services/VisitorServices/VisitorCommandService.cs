using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class VisitorCommandService : GenericCommandService<UpdateVisitorDto, CreateVisitorDto, Visitor>, IVisitorCommandService
    {
        public VisitorCommandService(IGenericCommandRepository<Visitor> genericCommandRepository, IMapper mapper) : base(genericCommandRepository, mapper)
        {
        }
    }
}
