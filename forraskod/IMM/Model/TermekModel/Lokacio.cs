using IMM.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMM.Model {
    public class Lokacio {

        private int lokId;
        private string lokNev;
        public int LokId { get => lokId; set => lokId = value; }
        public string LokNev { get => lokNev; set => lokNev = value; }
        public Lokacio(int id, string nev) {
            this.lokId = id;
            this.LokNev = nev;
        }

        public static List<Lokacio> getAll() {
            List<Lokacio> _lokaciok = new List<Lokacio>();
            SQLiteConnection sqlc = new SQLiteConnection(Database.Connection1);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            SQLiteDataReader dr;
            sqlc.Open();
            try {
                sqlcommand.CommandText = "SELECT * FROM lokaciok";
                dr = sqlcommand.ExecuteReader();
                while (dr.Read()) {
                    Lokacio jelenlegiLokacio = new Lokacio(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString());
                    _lokaciok.Add(jelenlegiLokacio);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show("Lokációk kiolvasása hiba!", ex.Message);
                Logger.Log("Lokaciok getAll", ex.Message);
            }
            if (sqlc.State == ConnectionState.Open) {
                sqlc.Close();
            }
            return _lokaciok;
        }
    }
}
