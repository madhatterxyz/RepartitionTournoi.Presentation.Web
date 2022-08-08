using RepartitionTournoi.Models;

namespace RepartitionTournoi.Presentation.Web.Services.Interfaces
{
    public interface ITournoiServices
    {
        Task<List<TournoiDTO>> GetAll();
        Task<TournoiDTO> GetById(long id);
        Task<TournoiDTO> Create(TournoiDTO tournoiDTO);
    }
}
