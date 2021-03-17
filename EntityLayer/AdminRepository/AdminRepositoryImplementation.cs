using EntityLayer.AdminDetails;
using EntityLayer.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.AdminRepository
{
    public class AdminRepositoryImplementation
    {

        private readonly ApplicationDbContext _appDbContext;
        public AdminRepositoryImplementation(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // CREATE
        public async Task Add<T>(T entity) where T : class
        {
            await _appDbContext.AddAsync(entity);
        }

        //READING A SINGLE DATA FROM THE DB
        public async Task<Admin> GetOneAdmin(int id)
        {
            return await _appDbContext.Admins.FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task<List<Admin>> GetAllAdmin()
        {
            List<Admin> result = new List<Admin>();
            try
            {
                result = await _appDbContext.Admins.ToListAsync();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        // UPDATE DB
        public void Update<T>(T entity) where T : class
        {
            _appDbContext.Entry(entity).State = EntityState.Modified;
        }

        public async Task<bool> SaveAllChangesAsync()
        {
            if (await _appDbContext.SaveChangesAsync() > 0)
                return true;
            return false;
        }

        //DELETE
        public void Delete<T>(T entity) where T : class
        {
            _appDbContext.Entry(entity).State = EntityState.Deleted;

        }
    }
}
