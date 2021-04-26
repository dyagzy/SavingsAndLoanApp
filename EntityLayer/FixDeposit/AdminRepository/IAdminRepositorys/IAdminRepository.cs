using EntityLayer.AdminDetails;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntityLayer.IAdminRepositorys
{
    public interface IAdminRepository
    {
        Task Add<T>(T entity) where T : class;
        Task<Admin> GetOneAdmin(int id);
        Task<List<Admin>> GetAllAdmin();
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAllChangesAsync();
        void Update<T>(T entity) where T : class;



    }
}