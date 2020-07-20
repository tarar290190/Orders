using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
            //users = new List<User>();
            //users.Add(new User { age = 30, id = 1, name = "abhi", email = "abc@gmail.com" });
        }

        public DbSet<user> users { get; set; }


    }
}
