using IMM.Classes;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model {
    public class GepAdatok {
        private static SQLiteConnection sqlc = new SQLiteConnection(Database.Connection);
        private int gaid;
        private int gepid;
        private string gepmarka;
        private int lokacio;
        private string ciklusido;
        private string karbidatum;
        private string ismetlodes;


        public int GaId { get => gaid; set => gaid = value; }
        public int Gepid { get => gepid; set => gepid = value; }
        public string Gepmarka { get => gepmarka; set => gepmarka = value; }
        public int Lokacio { get => lokacio; set => lokacio = value; }
        public string Ciklusido { get => ciklusido; set => ciklusido = value; }
        public string Karbidatum { get => karbidatum; set => karbidatum = value; }
        public string Ismetlodes { get => ismetlodes; set => ismetlodes = value; }


        public GepAdatok(int id, int gid, int lok, string marka, string cikido, string karbi, string ismetles) {
            this.GaId = id;
            this.Gepid = gid;
            this.Gepmarka = marka;
            this.Lokacio = lok;
            this.Ciklusido = cikido;
            this.Karbidatum = karbi;
            this.Ismetlodes = ismetles;
        }


        public static List<GepAdatok> getAll() {
            List<GepAdatok> _gepAdatLista = new List<GepAdatok>();
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            SQLiteDataReader dr;
            try {
                sqlc.Open();
                sqlcommand.CommandText = "SELECT * FROM GepAdatok";
                dr = sqlcommand.ExecuteReader();
                while (dr.Read()) {
                    GepAdatok _gepAdat = new GepAdatok(Convert.ToInt32(dr.GetValue(0)), Convert.ToInt32(dr.GetValue(1)), Convert.ToInt32(dr.GetValue(2)), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString(), dr.GetValue(6).ToString());
                    _gepAdatLista.Add(_gepAdat);
                }
                dr.Close();
            } catch (Exception ex) {
                Logger.Log("GepAdatok osztály", ex.Message);
            }
            Database.checkConnectionState(sqlc);
            return _gepAdatLista;
        }
        public static List<GepAdatok> findByGepID(int gepid) {
            List<GepAdatok> adatok = (from x in getAll()
                                      where x.Gepid == gepid
                                      select x).ToList();
            return adatok;
        }

        public static void Modosit(GepAdatok _gepAdatok) {
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                sqlcommand.CommandText = "UPDATE GepAdatok SET geplokacio='" + _gepAdatok.Lokacio + "',gepmarka='" + _gepAdatok.Gepmarka + "',ciklusido='" + _gepAdatok.Ciklusido + "',karbantartaskezdes='" + _gepAdatok.Karbidatum + "',karbantartasismetlodes='" + _gepAdatok.Ismetlodes + "' WHERE id='" + _gepAdatok.GaId + "'";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                Logger.Log("Gép Adatok módosítás osztály hiba", ex.Message);
            }
            Database.checkConnectionState(sqlc);
        }
        public static void Hozzaad(GepAdatok _gepAdatok) {
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                sqlcommand.CommandText = "INSERT INTO GepAdatok (gepid,geplokacio,gepmarka,ciklusido,karbantartaskezdes,karbantartasismetlodes) VALUES('" + _gepAdatok.Gepid + "','" + _gepAdatok.Lokacio + "','" + _gepAdatok.Gepmarka + "','" + _gepAdatok.Ciklusido + "','" + _gepAdatok.Karbidatum + "','" + _gepAdatok.Ismetlodes + "')";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                Logger.Log("Gép Adatok hozzáadása osztály hiba", ex.Message);
            }
            Database.checkConnectionState(sqlc);
        }
    }
}
