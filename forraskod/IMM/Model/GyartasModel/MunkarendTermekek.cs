using IMM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace IMM.Model.GyartasModel {
    public class MunkarendTermekek {
        private static SQLiteConnection sqlc = new SQLiteConnection(Database.Connection);
        private int mrtID;
        private int mrID;
        private int termekID;
        private int szuksegesDarabszam;
        private string statusz;
        public int MrtID { get => mrtID; set => mrtID = value; }
        public int MrID { get => mrID; set => mrID = value; }
        public int TermekID { get => termekID; set => termekID = value; }
        public int SzuksegesDarabszam { get => szuksegesDarabszam; set => szuksegesDarabszam = value; }
        public string TermekNev {
            get {
                return Model.Termek.findByID(TermekID).TermekNev;
            }
        }
        public string MunkarendMegnevezes {
            get {
                return Munkarend.findByID(MrID).MrMegnevezes;
            }
        }

        public string Statusz { get => statusz; set => statusz = value; }

        public MunkarendTermekek(int id, int mrid, int tid, int db, string stat) {
            this.MrtID = id;
            this.MrID = mrid;
            this.TermekID = tid;
            this.SzuksegesDarabszam = db;
            this.Statusz = stat;
        }

        public static List<MunkarendTermekek> getAll() {
            List<MunkarendTermekek> _mTermekLista = new List<MunkarendTermekek>();
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            SQLiteDataReader dr;
            try {
                sqlc.Open();
                sqlcommand.CommandText = "SELECT * FROM MunkarendTermekek";
                dr = sqlcommand.ExecuteReader();
                while (dr.Read()) {
                    MunkarendTermekek jelenlegiMunkarendTermekek = new MunkarendTermekek(Convert.ToInt32(dr.GetValue(0)), Convert.ToInt32(dr.GetValue(1)), Convert.ToInt32(dr.GetValue(2)), Convert.ToInt32(dr.GetValue(3)), dr.GetValue(4).ToString());
                    _mTermekLista.Add(jelenlegiMunkarendTermekek);
                }
                dr.Close();
            } catch (Exception ex) {
                Logger.Log("MunkarendTermékek osztály", ex.Message);
            }
            Database.checkConnectionState(sqlc);
            return _mTermekLista;
        }
        public static MunkarendTermekek findByMRTID(int id) {
            MunkarendTermekek termek = (from x in getAll()
                                        where x.MrtID == id
                                        select x).FirstOrDefault();
            return termek;
        }
        public static void Hozzaad(MunkarendTermekek _mt) {
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                sqlcommand.CommandText = "INSERT INTO MunkarendTermekek (mrid,termekid,szuksegesdarabszam,statusz)VALUES('" + _mt.MrID + "','" + _mt.TermekID + "','" + Termek.findByID(_mt.TermekID).MinimumGyarthato + "','" + _mt.Statusz + "')";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                Logger.Log("Database", ex.Message);
            }
            Database.checkConnectionState(sqlc);
        }
        public static void Torol(MunkarendTermekek _mt) {
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                if (statuszCheck(_mt)) {
                    sqlcommand.CommandText = "DELETE FROM MunkarendTermekek WHERE mrtid='" + _mt.MrtID + "'";
                    sqlcommand.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                Logger.Log("Database", ex.Message);
            }
            Database.checkConnectionState(sqlc);
        }
        static bool statuszCheck(MunkarendTermekek _mt) {
            if (_mt.Statusz == (from x in MunkarendStatusz.getAll() where x.Sorszam == 1 select x).First().Megnevezes) {
                return true;
            } else {
                return false;
            }
        }
        public static void Modosit(MunkarendTermekek _mt) {
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                if (statuszCheck(_mt)) {
                    sqlcommand.CommandText = "UPDATE MunkarendTermekek SET szuksegesdarabszam='" + _mt.SzuksegesDarabszam + "' WHERE mrtid='" + _mt.MrtID + "'";
                    sqlcommand.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                Logger.Log("Database", ex.Message);
            }
            Database.checkConnectionState(sqlc);
        }
    }
}
