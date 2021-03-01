using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.SavingsRepository.ISavingsRepositorys
{
    public interface ISavingsRepository
    {
        Task Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAllChangesAsync();
        void Update<T>(T entity) where T : class;
    }
}
