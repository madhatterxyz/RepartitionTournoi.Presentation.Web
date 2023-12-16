using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using RepartitionTournoi.Models;
using RepartitionTournoi.Models.Tournoi;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;
using System.Web;

namespace RepartitionTournoi.Presentation.Web.Pages.Tournois
{
    public class DetailsModel : PageModel
    {
        private readonly ITournoiServices _services;
        private readonly IMatchServices _matchServices;

        public DetailsModel(ITournoiServices tournoiServices, IMatchServices matchServices)
        {
            _services = tournoiServices;
            _matchServices = matchServices;
            Classements = new List<Statistics>();
        }
        public int TournoiProgress { get; set; }
        public TournoiDTO TournoiDTO { get; set; } = default!;
        public List<Statistics> Classements { get; set; }
        public string BurndownChartLines { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id, long? joueurId)
        {
            if (id == null)
            {
                return NotFound();
            }

            TournoiDTO tournoidto = await _services.GetById((long)id);
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
                    string key = $"{score.Joueur.Nom} {score.Joueur.Prenom}";
                    var classement = Classements.FirstOrDefault(x => x.Joueur == key);
                    if (classement != null)
                    {
                        classement.Points += (int)score.Points;
                        int nbMatchFinis = tournoidto.Compositions.Count(x => x.Match.Scores.Any(y => y.Joueur.Id == score.Joueur.Id) && x.Match.DateFin != null);
                        int nbMatchTotal = tournoidto.Compositions.Count(x => x.Match.Scores.Any(y => y.Joueur.Id == score.Joueur.Id));
                        classement.Progression = nbMatchFinis * 100 / nbMatchTotal;
                    if (score.Points == 3)
                        classement.NbVictoires++;

                    }
                    else
                        Classements.Add(new Statistics() { Joueur = key, Points = (int)score.Points, Progression = 100 / tournoidto.Compositions.Count(x => x.Match.Scores.Any(y => y.Joueur.Id == score.Joueur.Id)), NbVictoires = score.Points == 3 ? 1 : 0 });

                }
            }
            Classements = Classements.OrderByDescending(x => x.Points).ToList();
            var burndownChartLines = await _matchServices.GetBurndownChartLines((int)id);
            BurndownChartLines = JsonConvert.SerializeObject(burndownChartLines);
            return Page();
        }
    }
    public class Statistics
    {
        public string Joueur { get; set; }
        public int Points { get; set; } = 0;
        public int Progression { get; set; } = 0;
        public int NbVictoires { get; set; } = 0;
    }
    public class BurndownChartLine
    {
        public string period { get; set; }
        public int expected { get; set; }
        public int? actual { get; set; }
    }
}
