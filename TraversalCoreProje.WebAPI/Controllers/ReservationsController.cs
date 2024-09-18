using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.WebAPI.Controllers
{

    public class ReservationsController : BaseController
    {
        private readonly IReservationReadService _reservationReadService;
        private readonly IReservationCommandService _reservationCommandService;

        public ReservationsController(IReservationReadService reservationReadService, IReservationCommandService reservationCommandService)
        {
            _reservationReadService = reservationReadService;
            _reservationCommandService = reservationCommandService;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetAllReservation()
        {
            return CreateAction(await _reservationReadService.GetListAsync());
        }
        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> GetMyCurrentReservation(int id)
        {
            return CreateAction(await _reservationReadService.CurrentReservation(id));
        }
        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> GetMyApprovedReservation(int id)
        {
            return CreateAction(await _reservationReadService.ApprovalReservation(id));
        }
        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> GetMyOldReservation(int id)
        {
            return CreateAction(await _reservationReadService.OldReservation(id));
        }
        [HttpPost]
        public async Task<IActionResult> CreateReservation(CreateReservationDto createReservationDto)
        {
            createReservationDto.Status = true;
            createReservationDto.StatusL = "Onay Bekliyor";
            return CreateAction(await _reservationCommandService.CreateAsync(createReservationDto));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateReservation(UpdateReservationDto updateReservationDto)
        {
            return CreateAction(await _reservationCommandService.UpdateAsync(updateReservationDto));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            return CreateAction(await _reservationCommandService.DeleteAsync(id));
        }
    }
}
