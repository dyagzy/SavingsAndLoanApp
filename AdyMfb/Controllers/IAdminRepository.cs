using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdyMfb.Controllers
{
    public interface IAdminRepository
    {
            Task Add<T>(T entity) where T : class;
            Task<AdminController> GetOneAdmin(int id);
            Task<List<AdminController>> GetAllAdmin();
            void Delete<T>(T entity) where T : class;
            Task<bool> SaveAllChangesAsync();
            void Update<T>(T entity) where T : class;

            
        }
    }