using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Joueurs
{
    public class EditModel : PageModel
    {
<<<<<<< HEAD
        private readonly IJoueurServices _services;

        public EditModel(IJoueurServices services)
        {
            _services = services;
=======
        private readonly IJoueurServices _joueurServices;

        public EditModel(IJoueurServices joueurServices)
        {
            _joueurServices = joueurServices;
>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5
        }

        [BindProperty]
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
            var joueurdto =  await _context.JoueurDTO.FirstOrDefaultAsync(m => m.Id == id);
            if (joueurdto == null)
            {
                return NotFound();
            }
            JoueurDTO = joueurdto;*/
=======
            //var joueurdto =  await _context.JoueurDTO.FirstOrDefaultAsync(m => m.Id == id);
            //if (joueurdto == null)
            //{
            //    return NotFound();
            //}
            //JoueurDTO = joueurdto;
>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
<<<<<<< HEAD
            /*if (!ModelState.IsValid)
=======
            if (!ModelState.IsValid)
>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5
            {
                return Page();
            }

<<<<<<< HEAD
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
=======
            //_context.Attach(JoueurDTO).State = EntityState.Modified;

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!JoueurDTOExists(JoueurDTO.Id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}
>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5

            return RedirectToPage("./Index");
        }

        private bool JoueurDTOExists(long id)
        {
<<<<<<< HEAD
            return true;//(_context.JoueurDTO?.Any(e => e.Id == id)).GetValueOrDefault();
=======
            return true;// (_context.JoueurDTO?.Any(e => e.Id == id)).GetValueOrDefault();
>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5
        }
    }
}
