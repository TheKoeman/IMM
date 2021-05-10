using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using IMM.Properties;
using System.Collections;
using System.Data.SqlClient;
using IMM.Model;
using IMM.Model.GyartasModel;
using IMM.Model.RaktarModel;

namespace IMM.Classes
{
    public class Database {
        public static string Connection = Properties.Settings.Default.dbConn;

        public static void checkConnectionState(SQLiteConnection con) {
            if (con.State == System.Data.ConnectionState.Open) {
                con.Close();
            }
        }
    }
}
