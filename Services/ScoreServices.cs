using RepartitionTournoi.Models.Scores;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;
using RestSharp;

namespace RepartitionTournoi.Presentation.Web.Services
{
    public class ScoreServices : IScoreServices
    {
        private readonly RestClient _restClient;
        public ScoreServices(IConfiguration configuration)
        {
            _restClient = new RestClient(configuration["AppSettings:ServicesURL"]);
        }

        public async Task<ScoreDTO> GetById(long matchId,long joueurId)
        {
            var request = new RestRequest($"Scores/{matchId}?joueurId={joueurId}");
            var response = await _restClient.ExecuteGetAsync<ScoreDTO>(request);
            return response.Data;
        }

        public async Task Update(ScoreDTO scoreDTO)
        {
            var request = new RestRequest($"Scores", Method.Put);
            request.AddBody(scoreDTO);
            var response = await _restClient.ExecutePutAsync(request);
        }
    }
}
