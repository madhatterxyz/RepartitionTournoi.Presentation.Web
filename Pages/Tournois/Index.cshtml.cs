using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Tournois
{
    public class IndexModel : PageModel
    {
        private readonly ITournoiServices _services;

        public IndexModel(ITournoiServices services)
        {
            _services = services;
        }

        public IList<TournoiDTO> Tournois { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Tournois = await _services.GetAll();
        }
    }
}
