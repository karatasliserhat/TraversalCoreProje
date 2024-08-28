using AutoMapper;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class NewsLetterReadService : GenericReadService<ResultNewsLetterDto, NewsLetter>, INewsLetterReadService
    {
        public NewsLetterReadService(IGenericReadRepository<NewsLetter> genericReadRepository, IMapper mapper) : base(genericReadRepository, mapper)
        {
        }
    }
}
