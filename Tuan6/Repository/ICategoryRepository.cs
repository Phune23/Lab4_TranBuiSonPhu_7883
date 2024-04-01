using Tuan6.Models;

namespace Tuan6.Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync(); 
        Task<Category> GetByIdAsync(int id); 
        Task AddAsync(Category category);
        Task UpdateAsync(Category category); 
        Task DeleteAsync(int id);
    }
}
