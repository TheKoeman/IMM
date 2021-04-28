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
        private string conString = Properties.Settings.Default.dbConn;
        public static string connection = Properties.Settings.Default.dbConn;
        private SQLiteConnection con;
        private SQLiteCommand sqlc;
        public Database() {
            if (conString != null) {
                con = new SQLiteConnection(conString);
                sqlc = new SQLiteCommand(con);
                con.Open();
            }
        }

        public static void checkConnectionState(SqlConnection con) {
            if (con.State == System.Data.ConnectionState.Open) {
                con.Close();
            }
        }





    }
}
