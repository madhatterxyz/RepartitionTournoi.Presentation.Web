using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Joueurs
{
    public class DetailsModel : PageModel
    {
<<<<<<< HEAD
        private readonly IJoueurServices _services;

        public DetailsModel(IJoueurServices services)
        {
            _services = services;
=======
        private readonly IJoueurServices _joueurServices;

        public DetailsModel(IJoueurServices joueurServices)
        {
            _joueurServices = joueurServices;
>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5
        }

        public JoueurDTO JoueurDTO { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(long? id)
        {
<<<<<<< HEAD
            /*if (id == null || _context.JoueurDTO == null)
=======
            if (id == null /*|| _context.JoueurDTO == null*/)
>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5
            {
                return NotFound();
            }

<<<<<<< HEAD
            var joueurdto = await _context.JoueurDTO.FirstOrDefaultAsync(m => m.Id == id);
            if (joueurdto == null)
            {
                return NotFound();
            }
            else 
            {
                JoueurDTO = joueurdto;
            }*/
=======
            //var joueurdto = await _context.JoueurDTO.FirstOrDefaultAsync(m => m.Id == id);
            //if (joueurdto == null)
            //{
            //    return NotFound();
            //}
            //else 
            //{
            //    JoueurDTO = joueurdto;
            //}
>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5
            return Page();
        }
    }
}
