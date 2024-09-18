using AutoMapper;
using Microsoft.AspNetCore.Http;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class CommentReadService : GenericReadService<ResultCommentDto, Comment>, ICommentReadService
    {
        private readonly IGenericReadRepository<Comment> _commentReadRepository;
        private readonly IMapper _mapper;
        public CommentReadService(IGenericReadRepository<Comment> genericReadRepository, IMapper mapper, IGenericReadRepository<Comment> commentReadRepository) : base(genericReadRepository, mapper)
        {
            _commentReadRepository = commentReadRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<ResultCommentDto>>> GetListByDestinationIdAsync(int id)
        {
            var result = _mapper.Map<List<ResultCommentDto>>(await _commentReadRepository.GetListByFilter(x => x.DestinationId == id));
            if (result is { Count: > 0 })
                return ResponseDto<List<ResultCommentDto>>.Success(result, StatusCodes.Status200OK);
            return ResponseDto<List<ResultCommentDto>>.Fail("Data Yok", StatusCodes.Status404NotFound);

        }
    }
}
