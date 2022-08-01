using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Joueurs
{
    public class DeleteModel : PageModel
    {
        private readonly IJoueurServices _joueurServices;

        public DeleteModel(IJoueurServices joueurServices)
        {
            _joueurServices = joueurServices;
        }

        [BindProperty]
        public JoueurDTO JoueurDTO { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null /*|| _context.JoueurDTO == null*/)
            {
                return NotFound();
            }
            /*
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

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            /*
            if (id == null || _context.JoueurDTO == null)
            {
                return NotFound();
            }
            var joueurdto = await _context.JoueurDTO.FindAsync(id);

            if (joueurdto != null)
            {
                JoueurDTO = joueurdto;
                _context.JoueurDTO.Remove(JoueurDTO);
                await _context.SaveChangesAsync();
            }
            */
            return RedirectToPage("./Index");
        }
    }
}
