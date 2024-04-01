using Lab4_tbsphu_7883.Models;

namespace Lab4_tbsphu_7883.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>>
        GetAllAsync(); Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product); Task UpdateAsync(Product product); Task DeleteAsync(int id);

    }
}
