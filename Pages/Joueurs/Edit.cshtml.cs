using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Joueurs
{
    public class EditModel : PageModel
    {
        private readonly IJoueurServices _services;

        public EditModel(IJoueurServices services)
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

            var joueurdto =  await _context.JoueurDTO.FirstOrDefaultAsync(m => m.Id == id);
            if (joueurdto == null)
            {
                return NotFound();
            }
            JoueurDTO = joueurdto;*/
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            /*if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(JoueurDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JoueurDTOExists(JoueurDTO.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }*/

            return RedirectToPage("./Index");
        }

        private bool JoueurDTOExists(long id)
        {
            return true;//(_context.JoueurDTO?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
