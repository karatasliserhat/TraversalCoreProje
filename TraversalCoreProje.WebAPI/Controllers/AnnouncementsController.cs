using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{
    public class AnnouncementsController : BaseController
    {
        private readonly IAnnouncementReadService _AnnouncementReadService;
        private readonly IAnnouncementCommandService _AnnouncementCommandService;

        public AnnouncementsController(IAnnouncementReadService AnnouncementReadService, IAnnouncementCommandService AnnouncementCommandService)
        {
            _AnnouncementReadService = AnnouncementReadService;
            _AnnouncementCommandService = AnnouncementCommandService;
        }

        [HttpGet]
        public async Task<IActionResult> AnnouncementList()
        {
            return CreateAction(await _AnnouncementReadService.GetListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAnnouncement(int id)
        {
            return CreateAction(await _AnnouncementReadService.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> AnnouncementCreate(CreateAnnouncementDto createAnnouncementDto)
        {
            createAnnouncementDto.Date = DateTime.Now;
            createAnnouncementDto.Status = true;
            return CreateAction(await _AnnouncementCommandService.CreateAsync(createAnnouncementDto));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAnnouncement(UpdateAnnouncementDto updateAnnouncementDto)
        {
            return CreateAction(await _AnnouncementCommandService.UpdateAsync(updateAnnouncementDto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnnouncement(int id)
        {
            return CreateAction(await _AnnouncementCommandService.DeleteAsync(id));
        }
    }
}
