using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMM.Classes;
using System.Data.SQLite;
namespace IMM.Model.GyartasModel {
   public class MunkarendStatusz {

        private int msID;
        private string megnevezes;
        private string szin;
        private int sorszam;
        private static SQLiteConnection sqlc = new SQLiteConnection(Database.Connection);
        public MunkarendStatusz(int id, string megnev, string szi, int szam) {
            this.MsID = id;
            this.Megnevezes = megnev;
            this.Szin = szi;
            this.Sorszam = szam;
        }

        public int MsID { get => msID; set => msID = value; }
        public string Megnevezes { get => megnevezes; set => megnevezes = value; }
        public string Szin { get => szin; set => szin = value; }
        public int Sorszam { get => sorszam; set => sorszam = value; }

        public static List<MunkarendStatusz> getAll() {
            List<MunkarendStatusz> _munkarendStatuszLista = new List<MunkarendStatusz>();
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            SQLiteDataReader dr;
            try {
                sqlc.Open();
                sqlcommand.CommandText = "SELECT * FROM MunkarendStatuszok";
                dr = sqlcommand.ExecuteReader();
                while (dr.Read()) {
                    MunkarendStatusz jelenlegiMunkarendStatusz = new MunkarendStatusz(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), Convert.ToInt32(dr.GetValue(3)));
                    _munkarendStatuszLista.Add(jelenlegiMunkarendStatusz);
                }
                dr.Close();
            } catch (Exception ex) {
                Logger.Log("MunkarendStátusz osztály", ex.Message);
            }
            Database.checkConnectionState(sqlc);
            return _munkarendStatuszLista;
        }

    }
}
