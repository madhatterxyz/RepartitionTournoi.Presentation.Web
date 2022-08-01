using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Joueurs
{
    public class IndexModel : PageModel
    {
        private readonly IJoueurServices _joueurServices;

        public IndexModel(IJoueurServices joueurServices)
        {
            _joueurServices = joueurServices;
        }

        public IList<JoueurDTO> Joueurs { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Joueurs = await _joueurServices.GetAll();

        }
    }
}
