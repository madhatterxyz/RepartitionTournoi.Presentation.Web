using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Pages.Tournois;

namespace RepartitionTournoi.Presentation.Web.Services.Interfaces
{
    public interface IMatchServices
    {
        Task<List<BurndownChartLine>> GetBurndownChartLines(int tournoiId);
        Task<MatchDTO> GetById(long? matchId);
        Task Update(MatchDTO matchDTO);
    }
}