using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Joueurs
{
    public class DeleteModel : PageModel
    {
<<<<<<< HEAD
        private readonly IJoueurServices _services;

        public DeleteModel(IJoueurServices services)
        {
            _services = services;
        }

        [BindProperty]
      public JoueurDTO JoueurDTO { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            /*if (id == null || _context.JoueurDTO == null)
            {
                return NotFound();
            }

=======
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
>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5
            var joueurdto = await _context.JoueurDTO.FirstOrDefaultAsync(m => m.Id == id);

            if (joueurdto == null)
            {
                return NotFound();
            }
<<<<<<< HEAD
            else 
=======
            else
>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5
            {
                JoueurDTO = joueurdto;
            }*/
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
<<<<<<< HEAD
            /*if (id == null || _context.JoueurDTO == null)
=======
            /*
            if (id == null || _context.JoueurDTO == null)
>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5
            {
                return NotFound();
            }
            var joueurdto = await _context.JoueurDTO.FindAsync(id);

            if (joueurdto != null)
            {
                JoueurDTO = joueurdto;
                _context.JoueurDTO.Remove(JoueurDTO);
                await _context.SaveChangesAsync();
<<<<<<< HEAD
            }*/

=======
            }
            */
>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5
            return RedirectToPage("./Index");
        }
    }
}
