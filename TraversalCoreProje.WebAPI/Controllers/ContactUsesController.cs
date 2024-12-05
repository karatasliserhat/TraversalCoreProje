using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{

    public class ContactUsesController : BaseController
    {
        private readonly IContactUsReadServices _ContactUsReadService;
        private readonly IContactUsCommandServices _ContactUsCommandService;

        public ContactUsesController(IContactUsReadServices ContactUsReadService, IContactUsCommandServices ContactUsCommandService)
        {
            _ContactUsReadService = ContactUsReadService;
            _ContactUsCommandService = ContactUsCommandService;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> ContactUsListTrue()
        {
            return CreateAction(await _ContactUsReadService.GetListContactUsByStatusTrueAsync());
        }
        [HttpGet("[Action]")]
        public async Task<IActionResult> ContactUsListFalse()
        {
            return CreateAction(await _ContactUsReadService.GetListContactUsByStatusFalseAsync());
        }
        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> ContactUsChangeStatusFalse(int id)
        {
            return CreateAction(await _ContactUsReadService.GetContactUsChangeStatusFalse(id));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactUs(int id)
        {
            return CreateAction(await _ContactUsReadService.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> ContactUsCreate(CreateContactUsDto createContactUsDto)
        {
            createContactUsDto.MessageDate = DateTime.Now;
            return CreateAction(await _ContactUsCommandService.CreateAsync(createContactUsDto));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateContactUs(UpdateContactUsDto updateContactUsDto)
        {
            return CreateAction(await _ContactUsCommandService.UpdateAsync(updateContactUsDto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactUs(int id)
        {
            return CreateAction(await _ContactUsCommandService.DeleteAsync(id));
        }
    }
}
