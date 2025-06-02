using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Utilities
{
    using System;
    using System.Security;

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
    }
}
