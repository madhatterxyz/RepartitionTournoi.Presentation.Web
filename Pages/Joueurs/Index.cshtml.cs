using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Joueurs
{
    public class IndexModel : PageModel
    {
<<<<<<< HEAD
        private readonly IJoueurServices _services;

        public IndexModel(IJoueurServices services)
        {
            _services = services;
=======
        private readonly IJoueurServices _joueurServices;

        public IndexModel(IJoueurServices joueurServices)
        {
            _joueurServices = joueurServices;
>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5
        }

        public IList<JoueurDTO> Joueurs { get; set; } = default!;

        public async Task OnGetAsync()
        {
<<<<<<< HEAD
            Joueurs = await _services.GetAll();
=======
            Joueurs = await _joueurServices.GetAll();

>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5
        }
    }
}
