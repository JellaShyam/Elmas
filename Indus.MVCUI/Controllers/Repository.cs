using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elmas.MVCUI.Controllers
{
    public static class Repository
    {
        static List<User> users = new List<User>() {

            new User() {UserName="admin",Roles="Admin,Editor",Password="admin" },
            new User() {UserName="shyam",Roles="Admin",Password="shyam" }
        };

        public static User GetUserDetails(User user)
        {
            return users.FirstOrDefault(u => u.UserName.ToLower() == user.UserName.ToLower() &&
                                    u.Password == user.Password);
        }
    }
    public class User
    {
        public string UserName { get; set; }
        public string Roles { get; set; }
        public string Password { get; set; }
    }
}