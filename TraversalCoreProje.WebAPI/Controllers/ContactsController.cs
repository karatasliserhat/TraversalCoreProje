using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{

    public class ContactsController : BaseController
    {
        private readonly IContactReadService _ContactReadService;
        private readonly IContactCommandService _ContactCommandService;

        public ContactsController(IContactReadService ContactReadService, IContactCommandService ContactCommandService)
        {
            _ContactReadService = ContactReadService;
            _ContactCommandService = ContactCommandService;
        }

        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            return CreateAction(await _ContactReadService.GetListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {
            return CreateAction(await _ContactReadService.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> ContactCreate(CreateContactDto createContactDto)
        {
            return CreateAction(await _ContactCommandService.CreateAsync(createContactDto));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactDto updateContactDto)
        {
            return CreateAction(await _ContactCommandService.UpdateAsync(updateContactDto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            return CreateAction(await _ContactCommandService.DeleteAsync(id));
        }
    }
}
