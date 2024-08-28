using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface INewsLetterCommandService:IGenericCommandService<UpdateNewsLetterDto, CreateNewsLetterDto, NewsLetter>
    {
    }
}
