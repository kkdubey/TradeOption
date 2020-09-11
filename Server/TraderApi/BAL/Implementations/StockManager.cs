using BLL.Interfaces;
using DAL;
using DAL.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class StockManager : IStockManager
    {
        private IUnitOfWork _unitOfWork;
        public StockManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<StockDetail> GetStockByIdAsync(int stockId)
        {
            return await _unitOfWork.StockDetails.Get(stockId);
        }

        public async Task<IEnumerable<StockDetail>> GetStocksAsync()
        {
            return await _unitOfWork.StockDetails.GetAll();
        }

    }
}
