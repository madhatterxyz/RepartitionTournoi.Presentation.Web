using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Joueurs
{
    public class IndexModel : PageModel
    {
        private readonly IJoueurServices _services;

        public IndexModel(IJoueurServices services)
        {
            _services = services;
        }

        public IList<JoueurDTO> Joueurs { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Joueurs = await _services.GetAll();
        }
    }
}
