using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IStockTransactionManager
    {
        Task<IEnumerable<StockTransaction>> GetStockTransactionsAsync();
        Task<StockTransaction> GetStockTransactionByIdAsync(int transactionId);
        Task<IEnumerable<StockTransaction>> GetStockTransactionsByUserIdAsync(int userId);
    }
}
