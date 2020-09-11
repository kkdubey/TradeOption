using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories.Implementations
{
    public class StockTransactionRepository : Repository<StockTransaction>, IStockTransactionRepository
    {
        public StockTransactionRepository(DbContext context) : base(context) { }

        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;

        public async Task<IEnumerable<StockTransaction>> GetStockTransactionsByUserIdAsync(int userId)
        {
            return await _appContext.StockTransactions.Where(x => x.UserDetailID == userId).ToListAsync();
        }
    }
}
