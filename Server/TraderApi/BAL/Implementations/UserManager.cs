using BLL.Interfaces;
using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class UserManager : IUserManager
    {
        private IUnitOfWork _unitOfWork;
        public UserManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<UserDetail> GetUserByIdAsync(int userId)
        {
            return await _unitOfWork.UserDetails.Get(userId);
        }

        public async Task<IEnumerable<UserDetail>> GetUsersAsync()
        {
            return await _unitOfWork.UserDetails.GetAll();
        }
    }
}
