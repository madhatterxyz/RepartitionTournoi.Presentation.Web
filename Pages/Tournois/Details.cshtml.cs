using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

namespace RepartitionTournoi.Presentation.Web.Pages.Tournois
{
    public class DetailsModel : PageModel
    {
        private readonly ITournoiServices _services;

        public DetailsModel(ITournoiServices services)
        {
            _services = services;
            Classements = new Dictionary<string, int>();
        }

        public TournoiDTO TournoiDTO { get; set; } = default!;
        public Dictionary<string, int> Classements { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id, long? joueurId)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournoidto = await _services.GetById((long)id);
            if (tournoidto == null)
            {
                return NotFound();
            }
            else
            {
                TournoiDTO = tournoidto;
                if (joueurId != null)
                {
                    TournoiDTO.Compositions = tournoidto.Compositions.Where(x => x.Match.Scores.Any(y => y.Joueur.Id == joueurId)).ToList();
                }
            }
            foreach (var compo in tournoidto.Compositions)
            {
                foreach (var score in compo.Match.Scores)
                {
                    string key = $"{score.Joueur.Nom} {score.Joueur.Prénom}";
                    if (Classements.ContainsKey(key))
                        Classements[key] += (int)score.Points;
                    else
                        Classements.Add(key, (int)score.Points);
                }
            }
            Classements = Classements.OrderByDescending(x => x.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            return Page();
        }
    }
}
