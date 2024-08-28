using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class NewsLetterCommandService : GenericCommandService<UpdateNewsLetterDto, CreateNewsLetterDto, NewsLetter>, INewsLetterCommandService
    {
        public NewsLetterCommandService(IGenericCommandRepository<NewsLetter> genericCommandRepository, IMapper mapper) : base(genericCommandRepository, mapper)
        {
        }
    }
}
