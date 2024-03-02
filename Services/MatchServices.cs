using RepartitionTournoi.Models;
using RepartitionTournoi.Models.Tournoi;
using RepartitionTournoi.Presentation.Web.Pages.Tournois;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;
using RestSharp;

namespace RepartitionTournoi.Presentation.Web.Services
{
    public class MatchServices : IMatchServices
    {
        private readonly RestClient _restClient;
        public MatchServices(IConfiguration configuration)
        {
            _restClient = new RestClient(configuration["AppSettings:ServicesURL"]);
        }

        public async Task<List<BurndownChartLine>> GetBurndownChartLines(long tournoiId, long? joueurId)
        {
            var request = new RestRequest($"Matchs/BurndownChartLines/{tournoiId}?joueurId={joueurId}");
            var response = await _restClient.ExecuteGetAsync<List<BurndownChartLine>>(request);
            return response.Data;
        }

        public async Task<MatchDTO> GetById(long? matchId)
        {
            var request = new RestRequest($"Matchs/{matchId}");
            var response = await _restClient.ExecuteGetAsync<MatchDTO>(request);
            return response.Data;
        }
        public async Task Update(MatchDTO matchDTO)
        {
            var request = new RestRequest($"Matchs", Method.Put);
            request.AddBody(matchDTO);
            await _restClient.ExecutePutAsync(request);
        }
        public async Task<TournoiDTO> GetByMatchId(long matchId)
        {
            var request = new RestRequest($"Matchs/{matchId}/Tournoi");
            var response = await _restClient.ExecuteAsync<TournoiDTO>(request);
            return response.Data;
        }
    }
}
