using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Joueurs
{
    public class CreateModel : PageModel
    {
        private readonly IJoueurServices _joueurServices;

        public CreateModel(IJoueurServices joueurServices)
        {
            _joueurServices = joueurServices;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JoueurDTO JoueurDTO { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || /*_context.JoueurDTO == null ||*/ JoueurDTO == null)
            {
                return Page();
            }


            return RedirectToPage("./Index");
        }
    }
}
