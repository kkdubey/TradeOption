using DAL.Repositories.Interfaces;

namespace DAL
{
    public interface IUnitOfWork
    {
        IStockDetailRepository StockDetails { get; }
        IStockTransactionRepository StockTransactions { get; }
        IUserDetailRepository UserDetails { get; }
        int SaveChanges();
    }
}
