using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Core.Contracts
{
    public interface IUserService
    {
        Task<bool> UserByEmailExists(string email);
    }
}
