using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface ISendMailService
    {
        Task<ResponseDto<MailRequestDto>> SendMail(MailRequestDto mailRequestDto);
    }
}
