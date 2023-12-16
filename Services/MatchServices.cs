using RepartitionTournoi.Models;
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

        public async Task<List<BurndownChartLine>> GetBurndownChartLines(int tournoiId)
        {
            var request = new RestRequest($"Matchs/BurndownChartLines/{tournoiId}");
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
            var response = await _restClient.ExecutePutAsync(request);
        }
    }
}
