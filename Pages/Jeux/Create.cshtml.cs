using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Jeux
{
    public class CreateModel : PageModel
    {

        private readonly IJeuServices _services;

        public CreateModel(IJeuServices services)
        {
            _services = services;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JeuDTO JeuDTO { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid || _context.JeuDTO == null || JeuDTO == null)
            //  {
            //      return Page();
            //  }

            //  _context.JeuDTO.Add(JeuDTO);
            //  await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
