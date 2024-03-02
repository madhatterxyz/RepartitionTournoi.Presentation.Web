using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models.Scores;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Scores;

public class EditModel : PageModel
{
    private readonly IScoreServices _services;
    private readonly ITournoiServices _tournoiServices;
    private readonly IMatchServices _matchServices;

    public EditModel(IScoreServices services, ITournoiServices tournoiServices, IMatchServices matchServices)
    {
        _services = services;
        _tournoiServices = tournoiServices;
        _matchServices = matchServices;
    }

    [BindProperty]
    public ScoreDTO Score { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(long? matchId, long? joueurId)
    {
        Score = await _services.GetById((long)matchId, (long)joueurId);
        if (Score == null)
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
        var tournoi = await _matchServices.GetByMatchId(Score.MatchId);

        await _services.Update(Score);

        return RedirectToPage($"/Tournois/Details", new {id = tournoi.Id});
    }
}
