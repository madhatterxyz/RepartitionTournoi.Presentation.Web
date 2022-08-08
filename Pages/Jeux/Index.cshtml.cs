using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Jeux
{
    public class IndexModel : PageModel
    {
        private readonly IJeuServices _services;

        public IndexModel(IJeuServices services)
        {
            _services = services;
        }

        public IList<JeuDTO> Jeux { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Jeux = await _services.GetAll();
        }
    }
}
