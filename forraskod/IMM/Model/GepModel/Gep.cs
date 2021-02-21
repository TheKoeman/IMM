using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMM.Classes;

namespace IMM.Model {
   public class Gep {
        private int id;
        private string gepNev;


        public int Id { get => id; set => id = value; }
        public string GepNev { get => gepNev; set => gepNev = value; }

        public Gep(int id, string nev) {
            this.Id = id;
            this.GepNev = nev;
        }

        public static List<Gep> getAll() {
            List<Gep> _gepLista = new List<Gep>();
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            SQLiteDataReader dr;
            try {
                sqlcommand.CommandText = "SELECT * FROM gepek";
                sqlc.Open();
                dr = sqlcommand.ExecuteReader();
                while (dr.Read()) {
                    Gep _gep = new Gep(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString());
                    _gepLista.Add(_gep);
                }
                dr.Close();
            } catch (Exception ex) {
                Logger.Log("Gép osztály, getAll", ex.Message);
            }
            if (sqlc.State == ConnectionState.Open) {
                sqlc.Close();
            }
            return _gepLista;
        }
        
    }
}
