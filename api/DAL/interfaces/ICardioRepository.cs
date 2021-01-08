using System.IO;
using System.Threading.Tasks;
using api.DAL.data;
using api.DAL.helpers;
using Microsoft.AspNetCore.Mvc;

namespace api.DAL.Interfaces
{
    public interface ICardioRepository
    {
        Task<Cardio> getCardioDetails(int registry_id);
        Task<string> findCardio(string cassette_id);
        Task<PagedList<Cardio>> GetCardios(CardioParams cardioParams);
        Task<bool> SaveAll();
        
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Add<T>(T entity) where T : class;
        Task<Cardio> getCardioDetailsFromCassette(string cassetteid);
        Task<string> updateHemodynamicsFile(int cardioId, byte[] file);
        Task<bool> isHemoFilePresent(int cardioId);
        Task<byte[]> getHemodynamics(int cardioId);
    }
}