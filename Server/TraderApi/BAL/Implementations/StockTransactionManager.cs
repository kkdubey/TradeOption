using BLL.Interfaces;
using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class StockTransactionManager : IStockTransactionManager
    {
        private IUnitOfWork _unitOfWork;
        public StockTransactionManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<StockTransaction> GetStockTransactionByIdAsync(int transactionId)
        {
            return await _unitOfWork.StockTransactions.Get(transactionId);
        }

        public async Task<IEnumerable<StockTransaction>> GetStockTransactionsAsync()
        {
            return await _unitOfWork.StockTransactions.GetAll();
        }

        public async Task<IEnumerable<StockTransaction>> GetStockTransactionsByUserIdAsync(int userId)
        {
            return await _unitOfWork.StockTransactions.GetStockTransactionsByUserIdAsync(userId);
        }
    }
}
