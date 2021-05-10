using IMM.Classes;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model.RaktarModel {
    public class Raktar {
        private static SQLiteConnection sqlc = new SQLiteConnection(Database.Connection);
        private int raktarID;
        private string raktarMegnevezes;
        public int RaktarID { get => raktarID; set => raktarID = value; }
        public string RaktarMegnevezes { get => raktarMegnevezes; set => raktarMegnevezes = value; }
        public Raktar(int id, string nev) {
            this.RaktarID = id;
            this.RaktarMegnevezes = nev;
        }
        public static List<Raktar> getAll() {
            List<Raktar> raktarak = new List<Raktar>();
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);

            SQLiteDataReader dr;
            try {
                sqlc.Open();
                sqlcommand.CommandText = "SELECT * FROM Raktarak";
                dr = sqlcommand.ExecuteReader();
                while (dr.Read()) {
                    Raktar jelenlegiRaktar = new Raktar(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString());
                    raktarak.Add(jelenlegiRaktar);
                }
                dr.Close();
            } catch (Exception ex) {
                Logger.Log("Raktár osztály", ex.Message);
            }
            Database.checkConnectionState(sqlc);
            return raktarak;
        }
        public static Raktar findByID(int id) {
            Raktar raktar = (from x in getAll()
                             where x.RaktarID == id
                             select x).FirstOrDefault();
            return raktar;
        }
        public static void Hozzaad(Raktar _rak) {
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                sqlcommand.CommandText = "INSERT INTO Raktarak (rmegnevezes) VALUES ('" + _rak.RaktarMegnevezes + "')";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                Logger.Log("Raktár hozzáad osztály hiba", ex.Message);
            }
            Database.checkConnectionState(sqlc);
        }
    }
}
