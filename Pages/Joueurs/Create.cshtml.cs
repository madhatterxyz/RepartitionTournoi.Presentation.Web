using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Joueurs
{
    public class CreateModel : PageModel
    {
<<<<<<< HEAD
        private readonly IJoueurServices _services;

        public CreateModel(IJoueurServices services)
        {
            _services = services;
=======
        private readonly IJoueurServices _joueurServices;

        public CreateModel(IJoueurServices joueurServices)
        {
            _joueurServices = joueurServices;
>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5
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
<<<<<<< HEAD
            /*if (!ModelState.IsValid || _context.JoueurDTO == null || JoueurDTO == null)
              {
                  return Page();
              }

              _context.JoueurDTO.Add(JoueurDTO);
              await _context.SaveChangesAsync();*/
=======
            if (!ModelState.IsValid || /*_context.JoueurDTO == null ||*/ JoueurDTO == null)
            {
                return Page();
            }

>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5

            return RedirectToPage("./Index");
        }
    }
}
