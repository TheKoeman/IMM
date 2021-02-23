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
        public static List<GepAllomas> findByGepID(int gepid) {
            List<GepAllomas> allomasok = (from x in getAll()
                                          where x.GepId == gepid
                                          select x).ToList();
            return allomasok;
        }
        public static List<GepAllomas> findByAllomasSzam(int allomas, int gepid) {
            List<GepAllomas> allomasLista = (from x in getAll()
                                             where x.AllomasSzam == allomas && x.GepId == gepid
                                             select x).ToList();
            return allomasLista;
        }
        public static List<GepAllomas> findByGepIdAllomasNev(int gepid, string allomasnev) {
            List<GepAllomas> allomas = (from x in findByGepID(gepid)
                                        where x.AllomasNev == allomasnev
                                        select x).ToList();
            return allomas;
        }
        public static List<GepAllomas> findByID(int gaid) {
            List<GepAllomas> allomas = (from x in getAll()
                                        where x.GaId == gaid
                                        select x).ToList();
            return allomas;
        }

        public static void Hozzaad(int gepid, int allomas, string nev) {
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                sqlcommand.CommandText = "INSERT INTO GepAllomasok (gepid,allomasszam,allomasnev) VALUES('" + gepid + "','" + allomas + "','" + nev + "')";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                Logger.Log("Gép Állomás hozzáadás osztály hiba", ex.Message);
            }
            if (sqlc.State == System.Data.ConnectionState.Open) {
                sqlc.Close();
            }
        }
        public static void Torol(GepAllomas _allomas) {
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                sqlcommand.CommandText = "DELETE FROM GepAllomasok WHERE allomasszam='" + _allomas.AllomasSzam + "' AND gepid='" + _allomas.GepId + "'";
                sqlcommand.ExecuteNonQuery();
                sqlcommand.CommandText = "DELETE FROM GepAllomasParameterek WHERE gepallomasid='" + _allomas.GaId + "'";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                Logger.Log("Gép Állomás törlés osztály hiba", ex.Message);
            }
            if (sqlc.State == System.Data.ConnectionState.Open) {
                sqlc.Close();
            }
        }
        public static void Modosit(GepAllomas _allomas) {
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                sqlcommand.CommandText = "UPDATE GepAllomasok SET allomasszam='" + _allomas.AllomasSzam + "',allomasnev='" + _allomas.AllomasNev + "' WHERE gaid ='" + _allomas.GaId + "'";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                Logger.Log("Gép Állomás módosítás osztály hiba", ex.Message);
            }
            if (sqlc.State == System.Data.ConnectionState.Open) {
                sqlc.Close();
            }
        }


    }
}
