using System.Threading.Tasks;
using api.DAL.data;

namespace api.DAL.Interfaces
{
    public interface IBrief
    {
        Task<Brief> getBrief(int id);
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Add<T>(T entity) where T : class; 
        Task<bool> SaveAll();





    }
}