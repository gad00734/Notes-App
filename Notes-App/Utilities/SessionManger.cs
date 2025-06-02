using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace Digital_Notes_Manager.Utilities
{
    public static class SessionManager
    {
        public static string UserName { get; set; }
        private static SecureString _password = new SecureString();

        public static void SetPassword(string password)
        {
            _password.Clear();
            foreach (char c in password)
            {
                _password.AppendChar(c);
            }
            _password.MakeReadOnly();
        }

        public static SecureString GetPassword()
        {
            return _password;
        }

        public static void ClearSession()
        {
            UserName = string.Empty;
            _password.Dispose();
            _password = new SecureString();
        }

        public static bool IsLoggedIn()
        {
            return !string.IsNullOrEmpty(UserName) && _password.Length > 0;
        }
    }
}
