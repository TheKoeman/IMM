using IMM.Classes;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model.RaktarModel {
   public class RaktarLokacio {
        private int rlID;
        private int rID;
        private string lokacioNev;

        public int RlID { get => rlID; set => rlID = value; }
        public int RID { get => rID; set => rID = value; }
        public string LokacioNev { get => lokacioNev; set => lokacioNev = value; }

        public RaktarLokacio(int id, int rid, string nev) {
            this.rlID = id;
            this.rID = rid;
            this.LokacioNev = nev;
        }
        public static List<RaktarLokacio> getAll() {
            List<RaktarLokacio> raktarLokaciok = new List<RaktarLokacio>();
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            SQLiteDataReader dr;
            try {
                sqlc.Open();
                sqlcommand.CommandText = "SELECT * FROM RaktarLokaciok";
                dr = sqlcommand.ExecuteReader();
                while (dr.Read()) {
                    RaktarLokacio jelenlegiLokacio = new RaktarLokacio(Convert.ToInt32(dr.GetValue(0)), Convert.ToInt32(dr.GetValue(1)), dr.GetValue(2).ToString());
                    raktarLokaciok.Add(jelenlegiLokacio);
                }
                dr.Close();
            } catch (Exception ex) {
                Logger.Log("Database", ex.Message);
            }
            if (sqlc.State == System.Data.ConnectionState.Open) {
                sqlc.Close();
            }
            return raktarLokaciok;
        }
        public static List<RaktarLokacio> findByRaktarID(int id) {
            List<RaktarLokacio> rLokacio = (from x in getAll()
                                      where x.RID == id
                                      select x).ToList();
            return rLokacio;
        }
    }
}
