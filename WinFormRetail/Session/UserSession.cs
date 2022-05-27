using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormRetail.Session
{
    static class UserSession
    {
        public static string? Email { get; set; }
        public static string? Password { get; set; }
        public static void SetUser(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
