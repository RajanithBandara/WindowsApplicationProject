using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace WindowsAppProject
{
    internal class session
    {
        
        private static string _username;
        private static string _arfullname; // Added backing field for arfullname
        private static string _aremail; // Added backing field for aremail
        //private static void ArDataGetter()
        //{
        //    string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDB.accdb";
        //    using (OleDbConnection conn = new OleDbConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        OleDbCommand cmd = new OleDbCommand("SELECT * FROM aruserdata WHERE username = @username", conn);
        //        cmd.Parameters.AddWithValue("@username", _username);
        //        OleDbDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            _arfullname = reader["Fullname"].ToString(); // Assign to backing field
        //            _aremail = reader["email"].ToString(); // Assign to backing field
        //        }
        //        conn.Close();
        //    }
        //}
        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        //public static string arfullname
        //{
        //    get { return _arfullname; }
        //    set { _arfullname = value; }
        //}

        //public static string aremail
        //{
        //    get { return _aremail; }
        //    set { _aremail = value; }
        //}

        public static bool IsAr
        {
            get { return !string.IsNullOrEmpty(_username); }
        }

        public static void Logout()
        {
            _username = null;
            //_arfullname = null;
           // _aremail = null;
        }
    }
}
