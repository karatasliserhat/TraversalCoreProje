using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface ICommentCommandService:IGenericCommandService<UpdateCommentDto,CreateCommentDto,Comment>
    {
    }
}
