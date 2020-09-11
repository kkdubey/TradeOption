using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IStockTransactionRepository : IRepository<StockTransaction>
    {
        Task<IEnumerable<StockTransaction>> GetStockTransactionsByUserIdAsync(int userId);
    }
}
