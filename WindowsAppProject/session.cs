using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace WindowsAppProject
{
    internal class session
    {
        
        private static string _username;
        private static string _arfullname; 
        private static string _aremail; 
        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public static bool IsAr
        {
            get { return !string.IsNullOrEmpty(_username); }
        }

        public static void Logout()
        {
            _username = null;
        }
    }
}
