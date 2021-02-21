using IMM.Classes;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model {
   public class GepAllomas {

        private int gaId;
        private int allomasSzam;
        private int gepId;
        private string allomasNev;
 

        public int GaId { get => gaId; set => gaId = value; }
        public int AllomasSzam { get => allomasSzam; set => allomasSzam = value; }
        public int GepId { get => gepId; set => gepId = value; }
        public string AllomasNev { get => allomasNev; set => allomasNev = value; }

        public string AllomasMegnevezes {
            get {
                return AllomasSzam + " - " + AllomasNev;
            }
        }

        public GepAllomas(int id, int gepid, int allomasszam, string allnev) {
            this.GaId = id;
            this.AllomasSzam = allomasszam;
            this.GepId = gepid;
            this.AllomasNev = allnev;
        }

        public static List<GepAllomas> getAll() {
            List<GepAllomas> _gepAllomasLista = new List<GepAllomas>();
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            SQLiteDataReader dr;
            try {
                sqlc.Open();
                sqlcommand.CommandText = "SELECT * FROM GepAllomasok";
                dr = sqlcommand.ExecuteReader();
                while (dr.Read()) {
                    GepAllomas _gepAllomas = new GepAllomas(Convert.ToInt32(dr.GetValue(0)), Convert.ToInt32(dr.GetValue(1)), Convert.ToInt32(dr.GetValue(2)), dr.GetValue(3).ToString());
                    _gepAllomasLista.Add(_gepAllomas);
                }
                dr.Close();
            } catch (Exception ex) {
                Logger.Log("GepÁllomás osztály", ex.Message);
            }
            if (sqlc.State == System.Data.ConnectionState.Open) {
                sqlc.Close();
            }
            return _gepAllomasLista;
        }

       
    }
}
