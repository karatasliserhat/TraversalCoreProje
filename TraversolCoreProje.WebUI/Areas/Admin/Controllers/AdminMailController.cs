using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Shared.Interfaces;
using TraversalCoreProje.ViewModels;

namespace TraversolCoreProje.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminMailController : Controller
    {
        private readonly IMailSendApiService _mailSendApiService;

        public AdminMailController(IMailSendApiService mailSendApiService)
        {
            _mailSendApiService = mailSendApiService;
        }

        [HttpGet]
        public IActionResult SendMail()
        {
            return View(new MailRequestViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> SendMail(MailRequestViewModel mailRequestViewModel)
        {
            if (!ModelState.IsValid)
                return View(mailRequestViewModel);

            var response = await _mailSendApiService.SendMailAsync(mailRequestViewModel);
            if (response.StatusCode == StatusCodes.Status200OK)
            {
                return RedirectToAction(nameof(SendMail));
            }

            response.Errors.ForEach(x => ModelState.AddModelError("", x));
            return View(mailRequestViewModel);
        }
    }
}
