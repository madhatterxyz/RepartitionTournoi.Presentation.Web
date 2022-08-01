using RepartitionTournoi.Models;

namespace RepartitionTournoi.Presentation.Web.Services.Interfaces
{
    public interface IJoueurServices
    {
        Task<List<JoueurDTO>> GetAll();
    }
}
