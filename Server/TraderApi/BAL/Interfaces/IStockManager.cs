using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IStockManager
    {
        Task<IEnumerable<StockDetail>> GetStocksAsync();
        Task<StockDetail> GetStockByIdAsync(int stockId);
    }
}
