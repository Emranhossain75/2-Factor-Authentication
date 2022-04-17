using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Google2factorAuthentication.ViewModel
{
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class LoginModelDBContext : DbContext
    {
        public DbSet<LoginModel> LoginModels { get; set; }
    }
}