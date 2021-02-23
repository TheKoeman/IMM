using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMM.Classes;
using System.Data.SQLite;
namespace IMM.Model.GyartasModel {
   public class Munkarend {

        private int mrId;
        private string mrAzonosito;
        private string mrMegnevezes;
        private string mrDatum;
        private string elkeszultDatum;
        private string letrehozta;

        public Munkarend(int id, string azon, string megnev, string datum, string letrehoz,string elkeszult) {
            this.MrId = id;
            this.MrAzonosito = azon;
            this.MrMegnevezes = megnev;
            this.MrDatum = datum;
            this.Letrehozta = letrehoz;
            this.ElkeszultDatum = elkeszult;
        }

        public int MrId { get => mrId; set => mrId = value; }
        public string MrAzonosito { get => mrAzonosito; set => mrAzonosito = value; }
        public string MrMegnevezes { get => mrMegnevezes; set => mrMegnevezes = value; }
        public string MrDatum { get => mrDatum; set => mrDatum = value; }
        public string Letrehozta { get => letrehozta; set => letrehozta = value; }
        public string ElkeszultDatum { get => elkeszultDatum; set => elkeszultDatum = value; }

        public static List<Munkarend> getAll() {
            List<Munkarend> _munkarendek = new List<Munkarend>();
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            SQLiteDataReader dr;
            try {
                sqlc.Open();
                sqlcommand.CommandText = "SELECT * FROM Munkarendek";
                dr = sqlcommand.ExecuteReader();
                while (dr.Read()) {
                    Munkarend jelenlegiMunkarend = new Munkarend(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString());
                    _munkarendek.Add(jelenlegiMunkarend);
                }
                dr.Close();
            } catch (Exception ex) {
                Logger.Log("Munkarend osztály", ex.Message);
            }
            return _munkarendek;
        }
        public static Munkarend findByID(int id) {
            Munkarend munkarend = (from x in getAll()
                                   where x.MrId == id
                                   select x).First();
            return munkarend;
        }
        public static Munkarend findByAzonosito(string azon) {
            Munkarend munkarend = (from x in getAll()
                                   where x.MrAzonosito == azon
                                   select x).First();
            return munkarend;
        }
        public static void Hozzaad(Munkarend _mr) {
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                sqlcommand.CommandText = "INSERT INTO Munkarendek (mrazonosito,mrmegnevezes,mrdatum,letrehozta)VALUES('" + _mr.MrAzonosito + "','" + _mr.MrMegnevezes + "','" + _mr.MrDatum + "','" + _mr.Letrehozta + "')";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                Logger.Log("Munkarend hozzáadás", ex.Message);
            }
            if (sqlc.State == System.Data.ConnectionState.Open) {
                sqlc.Close();
            }
        }
    }
}
