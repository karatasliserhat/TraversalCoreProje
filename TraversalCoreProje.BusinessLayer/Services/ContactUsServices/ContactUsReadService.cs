using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.EfCore.Interfaces.IContactUsRepositories;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class ContactUsReadService : GenericReadService<ResultContactUsDto, ContactUs>, IContactUsReadServices
    {
        private readonly IContactUsReadRepositories _contactUsReadRepository;
        private readonly IMapper _mapper;
        public ContactUsReadService(IGenericReadRepository<ContactUs> genericReadRepository, IMapper mapper, IContactUsReadRepositories contactUsReadRepository) : base(genericReadRepository, mapper)
        {
            _contactUsReadRepository = contactUsReadRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<NoContent>> GetContactUsChangeStatusFalse(int id)
        {
            await _contactUsReadRepository.GetlistContactUsChangeFalse(id);
            return ResponseDto<NoContent>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<ResponseDto<List<ResultContactUsDto>>> GetListContactUsByStatusFalseAsync()
        {
            var data = _mapper.Map<List<ResultContactUsDto>>(await _contactUsReadRepository.GetlistContactUsByStatusFalse());
            return ResponseDto<List<ResultContactUsDto>>.Success(data, StatusCodes.Status200OK);

        }

        public async Task<ResponseDto<List<ResultContactUsDto>>> GetListContactUsByStatusTrueAsync()
        {
            var data = _mapper.Map<List<ResultContactUsDto>>(await _contactUsReadRepository.GetlistContactUsByStatusTrue());
            return ResponseDto<List<ResultContactUsDto>>.Success(data, StatusCodes.Status200OK);
        }
    }
}
