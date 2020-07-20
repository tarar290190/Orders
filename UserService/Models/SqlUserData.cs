using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Models
{
    public class SqlUserData : IUserData
    {
        private readonly UserDbContext db;

        public SqlUserData(UserDbContext db)
        {
            this.db = db;
        }
        public Dictionary<string, string> GetById(int id)
        {

            try
            {
                user u = db.users.FirstOrDefault(x => x.id == id);
                Dictionary<string, string> return_value = new Dictionary<string, string>();

                return_value.Add("name", u.name);
                return_value.Add("age", u.age.ToString());
                return_value.Add("email", u.email);
                return return_value;
            }
            catch (Exception e)
            {
                Dictionary<string, string> return_value = new Dictionary<string, string>();

                return_value.Add("error", e.Message);
                return return_value;
            }

        }
        public IEnumerable<user> GetUsers()
        {
            return db.users;
        }
    }
}
