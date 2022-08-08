using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;
using RestSharp;

namespace RepartitionTournoi.Presentation.Web.Services
{
    public class JeuServices : IJeuServices
    {
        private readonly IConfiguration _configuration;
        public JeuServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<List<JeuDTO>> GetAll()
        {            
            RestClient client = new RestClient(_configuration["AppSettings:ServicesURL"]);
            var request = new RestRequest("Jeux");
            var response = await client.ExecuteGetAsync<List<JeuDTO>>(request);
            return response.Data;
        }
    }
}
