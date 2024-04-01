using Lab4_tbsphu_7883.Models;

namespace Lab4_tbsphu_7883.Repository
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
