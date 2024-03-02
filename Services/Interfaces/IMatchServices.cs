using RepartitionTournoi.Models;
using RepartitionTournoi.Models.Tournoi;
using RepartitionTournoi.Presentation.Web.Pages.Tournois;

namespace RepartitionTournoi.Presentation.Web.Services.Interfaces
{
    public interface IMatchServices
    {
        Task<List<BurndownChartLine>> GetBurndownChartLines(long tournoiId, long? joueurId);
        Task<MatchDTO> GetById(long? matchId);
        Task Update(MatchDTO matchDTO);
        Task<TournoiDTO> GetByMatchId(long matchId);
    }
}