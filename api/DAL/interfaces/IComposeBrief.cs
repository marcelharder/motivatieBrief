using System.Threading.Tasks;

namespace api.DAL.Interfaces
{
    public interface IComposeBrief
    {
        Task composeAsync(int id);
    }
}