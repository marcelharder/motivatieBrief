using System.Threading.Tasks;
using api.DAL.models;

namespace api.DAL.Interfaces
{
    public interface IBrief
    {
        Task<Brief> getBrief(int id);
        Task<bool> saveBrief(Brief br);
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Add<T>(T entity) where T : class; 
        Task<bool> SaveAll();
        int deletePDF(int id);





    }
}