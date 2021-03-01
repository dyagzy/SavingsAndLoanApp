using EntityLayer.DataAccess;
using EntityLayer.SavingsRepository.ISavingsRepositorys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.SavingsRepository
{

    public class SavingsRepositoryImplementation : ISavingsRepository
    {

        private readonly ApplicationDbContext _appDbContext;
        public SavingsRepositoryImplementation(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task Add<T>(T entity) where T : class
        {
            await _appDbContext.AddAsync(entity);
        }
        
        public void Delete<T>(T entity) where T : class
        {
            _appDbContext.Entry(entity).State = EntityState.Deleted;
        }

        public async Task<SavingsAccount> GetOne(int id)
        {
            return await _appDbContext.SavingsAccounts.FirstOrDefaultAsync(x=>x.Id == id);
        }

        public async Task<List<SavingsAccount>> GetAll()
        {
            var result = await _appDbContext.SavingsAccounts.ToListAsync();
            return result;
        }

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

    }
}
