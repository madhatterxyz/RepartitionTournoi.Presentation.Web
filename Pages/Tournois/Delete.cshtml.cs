using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Tournois
{
    public class DeleteModel : PageModel
    {
        private readonly ITournoiServices _services;

        public DeleteModel(ITournoiServices services)
        {
            _services = services;
        }

        [BindProperty]
      public TournoiDTO TournoiDTO { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null )
            {
                return NotFound();
            }
            /*
            var tournoidto = await _context.TournoiDTO.FirstOrDefaultAsync(m => m.Id == id);

            if (tournoidto == null)
            {
                return NotFound();
            }
            else 
            {
                TournoiDTO = tournoidto;
            }*/
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            /*if (id == null || _context.TournoiDTO == null)
            {
                return NotFound();
            }
            var tournoidto = await _context.TournoiDTO.FindAsync(id);

            if (tournoidto != null)
            {
                TournoiDTO = tournoidto;
                _context.TournoiDTO.Remove(TournoiDTO);
                await _context.SaveChangesAsync();
            }*/

            return RedirectToPage("./Index");
        }
    }
}
