using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace BusinesLog
{
    class DataBase
    {
        private static DataBase _DataBase;
        private OracleConnection con;
        private OracleCommand cmd = new OracleCommand();

        private string UserID = "";
        private string UserPW = "";

        //OracleDataReader reader;

        private DataBase()
        {
            Init();
        }

        public static DataBase GetInstance()
        {
            if (_DataBase == null) _DataBase = new DataBase();
            return _DataBase;
        }

        private void Init()
        {
            string conString = "User Id=unitech;Password=unitech;Data Source=localhost:1521/orcl;";
            con = new OracleConnection(conString);
            con.Open();
            cmd = con.CreateCommand();
        }

        public OracleCommand GetCommand()
        {
            return cmd;
        }

        public bool Login(string id, string passwd)
        {

            return false;
        }
    }
}
