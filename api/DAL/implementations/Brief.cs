using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DAL;
using api.DAL.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace Cardiohelp.DAL.Implementations
{
    public class Brief : IBrief
    {

        private dataContext _context;
          private readonly IWebHostEnvironment _env;

        public Brief(dataContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public void Add<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public async Task<api.DAL.models.Brief> getBrief(int id)
        {
            var us = await _context.Users.Include(a => a.briefs).FirstOrDefaultAsync(x => x.Id == id);
            if (us != null)
            {
                var test = new List<api.DAL.models.Brief>();
                test = us.briefs.ToList();
                if (test.Count > 0) { return test[0]; }
                else
                {
                    // generate empty brief
                    var newBrief = new api.DAL.models.Brief();
                    newBrief.PhotoUrl = "https://res.cloudinary.com/marcelcloud/image/upload/v1574199666/sibput7sssqzfenyozlv.jpg";
                    us.briefs.Add(newBrief);
                    Update(us);
                    if (await SaveAll()) { 
                        var updatedUser = await _context.Users.Include(a => a.briefs).FirstOrDefaultAsync(x => x.Id == id);
                        var newBriefs = new List<api.DAL.models.Brief>();
                        test = updatedUser.briefs.ToList();
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

        public async Task<bool> saveBrief(api.DAL.models.Brief br)
        {
            Update(br);
            if(await SaveAll()){
                return true;
            }
            return false;
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

          public int deletePDF(int id)
        {
            var id_string = id.ToString();
            var pathToFile = _env.ContentRootPath + "/assets/pdf/";
            var file_name = pathToFile + id_string + ".pdf";

            if (System.IO.File.Exists(file_name))
            {
                System.IO.File.Delete(file_name);
                System.Threading.Thread.Sleep(20);
            }
            return 1;
        }
    }
}