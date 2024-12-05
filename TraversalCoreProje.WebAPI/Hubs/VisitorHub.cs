using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces;

namespace TraversalCoreProje.WebAPI.Hubs
{
    public class VisitorHub : Hub
    {
        private readonly IVisitorReadService _visitorReadService;

        public VisitorHub(IVisitorReadService visitorReadService)
        {
            _visitorReadService = visitorReadService;
        }

        public async Task GetVisitorChart()
        {
            await Clients.All.SendAsync("ReceiveVisitorChart", _visitorReadService.GetVisitorChart());
        }

    }
}
