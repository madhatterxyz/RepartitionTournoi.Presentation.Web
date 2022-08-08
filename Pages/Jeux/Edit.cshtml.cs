using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Jeux
{
    public class EditModel : PageModel
    {
        private readonly IJeuServices _services;

        public EditModel(IJeuServices services)
        {
            _services = services;
        }

        [BindProperty]
        public JeuDTO JeuDTO { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            /*if (id == null || _context.JeuDTO == null)
            {
                return NotFound();
            }

            var jeudto =  await _context.JeuDTO.FirstOrDefaultAsync(m => m.Id == id);
            if (jeudto == null)
            {
                return NotFound();
            }
            JeuDTO = jeudto;*/
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            /*_context.Attach(JeuDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JeuDTOExists(JeuDTO.Id))
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

        private bool JeuDTOExists(long id)
        {
            return true;// (_context.JeuDTO?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
