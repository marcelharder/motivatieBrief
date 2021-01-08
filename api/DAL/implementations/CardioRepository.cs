using System.IO;
using System.Linq;
using System.Threading.Tasks;
using api.DAL;
using api.DAL.code;
using api.DAL.data;
using api.DAL.helpers;
using api.DAL.Interfaces;
using Cardiohelp.data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cardiohelp.data.Implementations
{
    public class CardioRepository : ICardioRepository
    {
        private dataContext _context;
        private IUser _user;
        private SpecialMaps _special;
        public CardioRepository(dataContext context, SpecialMaps special, IUser user)
        {
            _context = context;
            _special = special;
            _user = user;
        }
        public async Task<string> findCardio(string cassette_id)
        {
            Cardio result;
            result = await _context.Cardios.FirstOrDefaultAsync(m => m.cassette_id == cassette_id);

            if (result == null) {return "This cassete_id is not in the database";}
            else {return "Found";}
            
             
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<Cardio> getCardioDetails(int id)
        {
            return await _context.Cardios.FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<PagedList<Cardio>> GetCardios(CardioParams p)
        { // get the center_id from the currentUser
            var currentUserId = _special.getCurrentUserId();
            User currentUser = await _user.getUserDetails(currentUserId);

            var messages = _context.Cardios.AsQueryable();
            messages = messages.Where(m => m.center_id == currentUser.center_id);

            return await PagedList<Cardio>.CreateAsync(messages, p.PageNumber, p.PageSize);
        }

        public async Task<Cardio> getCardioDetailsFromCassette(string cassetteid)
        {
            return await _context.Cardios.FirstOrDefaultAsync(m => m.cassette_id == cassetteid);
        }

        public async Task<string> updateHemodynamicsFile(int cardioId, byte[] file)
        {
            var selectedRecord = await _context.Cardios.FirstOrDefaultAsync(x => x.Id == cardioId);
            selectedRecord.hemodynamics = file;
            _context.Update(selectedRecord);
            if( await _context.SaveChangesAsync() > 0) {
                return("Updated ...");
            } else {return("");}
        }

        public async Task<bool> isHemoFilePresent(int cardioId)
        {
            Cardio c = await getCardioDetails(cardioId);
            _context.Entry(c).State = EntityState.Detached;
            if (c.hemodynamics != null && c.hemodynamics.Count() > 0) {return true;} else {return false;}
        }

        public async Task<byte[]> getHemodynamics(int cardioId)
        {
             Cardio c = await getCardioDetails(cardioId);
             _context.Entry(c).State = EntityState.Detached;
             return c.hemodynamics;
        }
    }
}