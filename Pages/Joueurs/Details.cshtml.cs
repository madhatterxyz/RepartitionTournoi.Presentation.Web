using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Joueurs
{
    public class DetailsModel : PageModel
    {
        private readonly IJoueurServices _services;

        public DetailsModel(IJoueurServices services)
        {
            _services = services;
        }

        public JoueurDTO JoueurDTO { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            /*if (id == null || _context.JoueurDTO == null)
            {
                return NotFound();
            }

            var joueurdto = await _context.JoueurDTO.FirstOrDefaultAsync(m => m.Id == id);
            if (joueurdto == null)
            {
                return NotFound();
            }
            else 
            {
                JoueurDTO = joueurdto;
            }*/
            return Page();
        }
    }
}
