using RepartitionTournoi.Models;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;
using RestSharp;

namespace RepartitionTournoi.Presentation.Web.Services
{
    public class JoueurServices : IJoueurServices
    {
        public JoueurServices()
        {

        }
        public async Task<List<JoueurDTO>> GetAll()
        {
            RestClient client = new RestClient("https://localhost:7192");
            RestRequest request = new RestRequest("Joueur", Method.Get);
            var response = await client.ExecuteAsync<List<JoueurDTO>>(request);

            return response.Data;
        }
    }
}
