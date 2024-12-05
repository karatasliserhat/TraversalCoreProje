using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.Enums;

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
        [HttpGet("[Action]")]
        public IActionResult CreateVisitor()
        {
            Random random = new Random();
            Enumerable.Range(1, 10).ToList().ForEach(x =>
            {
                foreach (ECity item in Enum.GetValues(typeof(ECity)))
                {
                    var createVisitorDto = new CreateVisitorDto
                    {
                        City = item,
                        VisitorDate = DateTime.Now.AddDays(x).Date,
                        Count = random.Next(1000, 2000),
                        Status = true
                    };
                    _VisitorCommandService.CreateAsync(createVisitorDto).Wait();
                    System.Threading.Thread.Sleep(1000);
                }

            });
            return Ok("Ziyaretçiler başarılı bir şekilde eklendi");
        }
        [HttpPost]
        public async Task<IActionResult> VisitorCreate(CreateVisitorDto createVisitorDto)
        {

            createVisitorDto.VisitorDate = DateTime.Now;
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
