using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;
using RestSharp;

namespace RepartitionTournoi.Presentation.Web.Services
{
    public class TournoiServices : ITournoiServices
    {
        private readonly IConfiguration _configuration;
        public TournoiServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<TournoiDTO> Create(TournoiDTO tournoiDTO)
        {
            RestClient client = new RestClient(_configuration["AppSettings:ServicesURL"]);
            var request = new RestRequest("Tournois");
            request.AddBody(tournoiDTO);
            var response = await client.ExecutePostAsync<TournoiDTO>(request);
            return response.Data;
        }

        public async Task<List<TournoiDTO>> GetAll()
        {
            RestClient client = new RestClient(_configuration["AppSettings:ServicesURL"]);
            var request = new RestRequest($"Tournois");
            var response = await client.ExecuteGetAsync<List<TournoiDTO>>(request);
            return response.Data;
        }
        public async Task<TournoiDTO> GetById(long id)
        {
            RestClient client = new RestClient(_configuration["AppSettings:ServicesURL"]);
            var request = new RestRequest($"Tournois/{id}");
            var response = await client.ExecuteGetAsync<TournoiDTO>(request);
            return response.Data;
        }
    }
}
