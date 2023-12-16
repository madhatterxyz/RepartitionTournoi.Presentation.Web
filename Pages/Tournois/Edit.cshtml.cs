using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models.Mappers;
using RepartitionTournoi.Models.Tournoi;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Tournois
{
    public class EditModel : PageModel
    {
        private readonly ITournoiServices _tournoiServices;

        public EditModel(ITournoiServices tournoiServices)
        {
            _tournoiServices = tournoiServices;
        }

        [BindProperty]
        public EditTournoiDTO Tournoi { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            Tournoi = TournoiDTOMapper.Map( await _tournoiServices.GetById((long)id));
            if (Tournoi == null)
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
            await _tournoiServices.Update(Tournoi);

            return RedirectToPage("./Index");
        }
    }
}
