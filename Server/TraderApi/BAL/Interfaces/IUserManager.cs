using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserManager
    {
        Task<IEnumerable<UserDetail>> GetUsersAsync();
        Task<UserDetail> GetUserByIdAsync(int userId);
    }
}
