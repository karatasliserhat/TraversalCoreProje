using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{

    public class MailsController : BaseController
    {
        private readonly ISendMailService _mailService;

        public MailsController(ISendMailService mailService)
        {
            _mailService = mailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendMail(MailRequestDto mailRequestDto)
        {
            return CreateAction(await _mailService.SendMail(mailRequestDto));
        }
    }
}
