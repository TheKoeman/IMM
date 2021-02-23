using IMM.Classes;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model {
    public class GepKategoria {
        Database database = new Database();
        private int id;
        private int gepId;
        private int kategoriaId;

        public int Id { get => id; set => id = value; }
        public int GepId { get => gepId; set => gepId = value; }
        public int KategoriaId { get => kategoriaId; set => kategoriaId = value; }
        public string GepNev {
            get {
                List<Gep> gList = Gep.getAll();
                string eredmeny = (from x in gList
                                   where x.Id == GepId
                                   select x.GepNev).First().ToString();
                return eredmeny;
            }
        }
        public string KategoriaNev {
            get {
                List<Kategoria> katList = Kategoria.getAll();
                string eredmeny = (from x in katList
                                   where x.Id == KategoriaId
                                   select x.KategoriaNev).First().ToString();
                return eredmeny;
            }
        }

        public GepKategoria(int id, int gid, int kid) {
            this.Id = id;
            this.GepId = gid;
            this.KategoriaId = kid;
        }

        public static List<GepKategoria> getAll() {
            List<GepKategoria> _gepKategoriaLista = new List<GepKategoria>();
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            SQLiteDataReader dr;
            try {
                sqlcommand.CommandText = "SELECT * FROM GepKategoriak";
                dr = sqlcommand.ExecuteReader();
                while (dr.Read()) {
                    GepKategoria jelenlegiGKat = new GepKategoria(Convert.ToInt32(dr.GetValue(0)), Convert.ToInt32(dr.GetValue(1)), Convert.ToInt32(dr.GetValue(2)));
                    _gepKategoriaLista.Add(jelenlegiGKat);
                }
                dr.Close();
            } catch (Exception ex) {
                Logger.Log("GépKategória osztály", ex.Message);
            }
            if (sqlc.State == System.Data.ConnectionState.Open) {
                sqlc.Close();
            }
            return _gepKategoriaLista;
        }
        public static GepKategoria findByID(int gepid, int katid) {
            GepKategoria gepKategoria = (from x in getAll()
                                         where x.GepId == gepid & x.KategoriaId == katid
                                         select x).First();
            return gepKategoria;
        }

        public static void Hozzaad(int gepid, int katid) {
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                sqlcommand.CommandText = "INSERT INTO GepKategoriak (gepid,kategoriaid) VALUES('" + gepid + "','" + katid + "')";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                Logger.Log("Gépkategória hozzáad osztály hiba", ex.Message);
            }
            if (sqlc.State == System.Data.ConnectionState.Open) {
                sqlc.Close();
            }
        }
        public static void Torol(int gepid, int katid) {
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                sqlcommand.CommandText = "DELETE FROM GepKategoriak WHERE gepid='" + gepid + "' and kategoriaid='" + katid + "'";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                Logger.Log("Gépkategória törlése osztály hiba", ex.Message);
            }
            if (sqlc.State == System.Data.ConnectionState.Open) {
                sqlc.Close();
            }
        }
    }
}
