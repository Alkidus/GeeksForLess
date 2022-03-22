using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TechnicalTask.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DBConnect")
        {
        }

        public DbSet<User> Users { get; set; }
    }

    //public class User
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public string Password { get; set; }
    //}
}