using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Tournois
{
    public class EditModel : PageModel
    {
        private readonly ITournoiServices _services;

        public EditModel(ITournoiServices services)
        {
            _services = services;
        }

        [BindProperty]
        public TournoiDTO TournoiDTO { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            /*if (id == null || _context.TournoiDTO == null)
            {
                return NotFound();
            }

            var tournoidto =  await _context.TournoiDTO.FirstOrDefaultAsync(m => m.Id == id);
            if (tournoidto == null)
            {
                return NotFound();
            }
            TournoiDTO = tournoidto;*/
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

            _context.Attach(TournoiDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TournoiDTOExists(TournoiDTO.Id))
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

        private bool TournoiDTOExists(long id)
        {
            return true;// (_context.TournoiDTO?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
