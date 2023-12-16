using RepartitionTournoi.Models;
using RepartitionTournoi.Models.Scores;
using RepartitionTournoi.Models.Tournoi;

namespace RepartitionTournoi.Presentation.Web.Services.Interfaces;

public interface IScoreServices
{
    Task<ScoreDTO> GetById(long matchId, long joueurId);
    Task Update(ScoreDTO scoreDTO);
}
