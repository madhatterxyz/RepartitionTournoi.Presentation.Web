using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Jeux
{
    public class DetailsModel : PageModel
    {
        private readonly IJeuServices _services;

        public DetailsModel(IJeuServices services)
        {
            _services = services;
        }

        public JeuDTO JeuDTO { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            /*if (id == null || _context.JeuDTO == null)
            {
                return NotFound();
            }

            var jeudto = await _context.JeuDTO.FirstOrDefaultAsync(m => m.Id == id);
            if (jeudto == null)
            {
                return NotFound();
            }
            else 
            {
                JeuDTO = jeudto;
            }*/
            return Page();
        }
    }
}
