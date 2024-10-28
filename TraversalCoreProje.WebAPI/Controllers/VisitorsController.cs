using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{

    public class VisitorsController : BaseController
    {
        private readonly IVisitorReadService _VisitorReadService;
        private readonly IVisitorCommandService _VisitorCommandService;

        public VisitorsController(IVisitorReadService VisitorReadService, IVisitorCommandService VisitorCommandService)
        {
            _VisitorReadService = VisitorReadService;
            _VisitorCommandService = VisitorCommandService;
        }

        [HttpGet]
        public async Task<IActionResult> VisitorList()
        {
            return CreateAction(await _VisitorReadService.GetListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVisitor(int id)
        {
            return CreateAction(await _VisitorReadService.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> VisitorCreate(CreateVisitorDto createVisitorDto)
        {
            createVisitorDto.Status = true;
            return CreateAction(await _VisitorCommandService.CreateAsync(createVisitorDto));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateVisitor(UpdateVisitorDto updateVisitorDto)
        {
            return CreateAction(await _VisitorCommandService.UpdateAsync(updateVisitorDto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVisitor(int id)
        {
            return CreateAction(await _VisitorCommandService.DeleteAsync(id));
        }
    }
}
