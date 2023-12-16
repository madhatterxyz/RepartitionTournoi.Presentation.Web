using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Models.Mappers;
using RepartitionTournoi.Presentation.Web.Services;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Matchs
{
    public class EditModel : PageModel
    {
        private readonly IMatchServices _services;

        public EditModel(IMatchServices services)
        {
            _services = services;
        }

        [BindProperty]
        public MatchDTO Match { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {

            Match = await _services.GetById((long)id);
            if (Match == null)
            {
                return NotFound();
            }
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
            await _services.Update(Match);

            return RedirectToPage("/Tournois/Index");
        }

        private bool TournoiDTOExists(long id)
        {
            return true;// (_context.TournoiDTO?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
