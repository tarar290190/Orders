using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Models
{
    public interface IUserData
    {
        IEnumerable<user> GetUsers();

        Dictionary<string, string> GetById(int id);
    }
}
