using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;
using RestSharp;

namespace RepartitionTournoi.Presentation.Web.Services
{
    public class JoueurServices : IJoueurServices
    {
        private readonly IConfiguration _configuration;
        public JoueurServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<List<JoueurDTO>> GetAll()
        {            
            RestClient client = new RestClient(_configuration["AppSettings:ServicesURL"]);
            var request = new RestRequest("Joueurs");
            var response = await client.ExecuteGetAsync<List<JoueurDTO>>(request);
            return response.Data;
        }
    }
}
