using DAL.Repositories.Implementations;
using DAL.Repositories.Interfaces;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext _context;

        public IStockDetailRepository _stockDetails;

        public IStockTransactionRepository _stockTransactions;

        public IUserDetailRepository _userDetails;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IStockDetailRepository StockDetails
        {
            get
            {
                if (_stockDetails == null)
                    _stockDetails = new StockDetailRepository(_context);

                return _stockDetails;
            }
        }

        public IStockTransactionRepository StockTransactions
        {
            get
            {
                if (_stockTransactions == null)
                    _stockTransactions = new StockTransactionRepository(_context);

                return _stockTransactions;
            }
        }

        public IUserDetailRepository UserDetails
        {
            get
            {
                if (_userDetails == null)
                    _userDetails = new UserDetailRepository(_context);

                return _userDetails;
            }
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
