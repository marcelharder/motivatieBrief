using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DAL.code;
using api.DAL.dtos;
using api.DAL.Interfaces;
using api.DAL.models;
using Microsoft.EntityFrameworkCore;

namespace api.DAL.implementations
{
    public class Persona : IPersonalia
    {
         private dataContext _context;
         private SpecialMaps _special;

        public Persona(dataContext context, SpecialMaps special)
        {
            _context = context;
            _special = special;
        }
        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public async Task<Personalia> getPer(int id)
        {
           
            var us = await _context.Users.Include(a => a.pers).FirstOrDefaultAsync(x => x.Id == id);
            if (us != null)
            {
                var test = new List<Personalia>();
                test = us.pers.ToList();
                if (test.Count > 0) { return test[0]; }
                else
                {
                    // generate empty personalia
                    var newP = new Personalia();

                    newP.email = us.email;

                    us.pers.Add(newP);
                    Update(us);
                    if (await SaveAll()) { 
                        var updatedUser = await _context.Users.Include(a => a.pers).FirstOrDefaultAsync(x => x.Id == id);
                        var help = new List<Personalia>();
                        test = updatedUser.pers.ToList();
                        return test[0]; }
                    return null;
                }
            }
            return null;

        }

        public async Task<bool> SaveAll()
        {
             return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> savePer(personaliaForReturnDto br)
        {

            Personalia per = await _context.Personas.FirstOrDefaultAsync(x => x.Id == br.Id);
            Personalia updated_personalia = _special.mapToPersonalia(br,per);
            Update(updated_personalia);
            if(await SaveAll()){
                return true;
            }
            return false;
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
    }
}