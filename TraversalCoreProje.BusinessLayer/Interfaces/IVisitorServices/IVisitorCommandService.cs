using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IVisitorCommandService:IGenericCommandService<UpdateVisitorDto,CreateVisitorDto,Visitor>
    {
    }
}
