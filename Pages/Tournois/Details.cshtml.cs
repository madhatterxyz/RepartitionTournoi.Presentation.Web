using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Tournois
{
    public class DetailsModel : PageModel
    {
        private readonly ITournoiServices _services;

        public DetailsModel(ITournoiServices services)
        {
            _services = services;
        }

        public TournoiDTO TournoiDTO { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var tournoidto = await _services.GetById((long)id);
            if (tournoidto == null)
            {
                return NotFound();
            }
            else 
            {
                TournoiDTO = tournoidto;
            }
            return Page();
        }
    }
}
