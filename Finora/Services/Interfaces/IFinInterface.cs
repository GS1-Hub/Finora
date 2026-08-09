using Finora.Models;

namespace Finora.Services.Interfaces
{
    public interface IFinService
    {
        Task<List<Fin>> GetAllFinsAsync();
        Task DeleteFin(int id);
    }
}