using RepartitionTournoi.Models.Tournoi;

namespace RepartitionTournoi.Presentation.Web.Services.Interfaces
{
    public interface ITournoiServices
    {
        Task<List<TournoiDTO>> GetAll();
        Task<TournoiDTO> GetById(long id);
        Task<TournoiDTO> Create(string nom);
        Task Update(EditTournoiDTO tournoiDTO);
    }
}
