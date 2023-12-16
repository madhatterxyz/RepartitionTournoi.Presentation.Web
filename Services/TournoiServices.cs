using RepartitionTournoi.Models.Tournoi;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;
using RestSharp;

namespace RepartitionTournoi.Presentation.Web.Services
{
    public class TournoiServices : ITournoiServices
    {
        private readonly RestClient _restClient;
        public TournoiServices(IConfiguration configuration)
        {
            _restClient = new RestClient(configuration["AppSettings:ServicesURL"]);
        }

        public async Task<TournoiDTO> Create(string nom)
        {
            var request = new RestRequest($"Tournois",Method.Post);
            request.AddBody(new { nom = nom });
            var response = await _restClient.ExecuteAsync<TournoiDTO>(request);
            return response.Data;
        }

        public async Task<List<TournoiDTO>> GetAll()
        {
            var request = new RestRequest($"Tournois");
            var response = await _restClient.ExecuteGetAsync<List<TournoiDTO>>(request);
            return response.Data;
        }
        public async Task<TournoiDTO> GetById(long id)
        {
            var request = new RestRequest($"Tournois/{id}");
            var response = await _restClient.ExecuteGetAsync<TournoiDTO>(request);
            return response.Data;
        }
        public async Task Update(EditTournoiDTO tournoi)
        {
            var request = new RestRequest($"Tournois",Method.Put);
            request.AddBody(tournoi);
            var response = await _restClient.ExecutePutAsync(request);
        }
    }
}
