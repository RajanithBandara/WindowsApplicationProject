using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppProject
{
    internal class session
    {
        private static string _username;

        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public static bool IsAr {
            get { return !string.IsNullOrEmpty(_username); }
        }

        public static void Logout()
        {
            _username = null;
        }
    }
}
