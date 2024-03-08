using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace WindowsAppProject.Apps
{
    internal class dbconnection
    {
        private static readonly Lazy<dbconnection> instance = new Lazy<dbconnection>(() => new dbconnection());
        public static dbconnection Instance => instance.Value;
        
        public string ConnectionString { get; private set; }
        private dbconnection()
        {
            ConnectionString = "Host=165.232.167.179;Port=5432;Username=postgres;Password=rajanith2003;Database=usersdb";
        }
    }

}
