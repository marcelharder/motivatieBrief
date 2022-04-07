using System.Threading.Tasks;
using api.DAL.dtos;
using api.DAL.models;

namespace api.DAL.Interfaces
{
    public interface IPersonalia
    {
        Task<Personalia> getPer(int id);
        Task<bool> savePer(personaliaForReturnDto br);
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Add<T>(T entity) where T : class; 
        Task<bool> SaveAll();
       





    }
}