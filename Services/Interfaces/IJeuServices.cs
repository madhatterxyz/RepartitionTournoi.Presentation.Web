using RepartitionTournoi.Models;

namespace RepartitionTournoi.Presentation.Web.Services.Interfaces
{
    public interface IJeuServices
    {
        Task<List<JeuDTO>> GetAll();
    }
}
