using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using IMM.Model;
using IMM.Classes;

namespace IMM.Model.GyartasModel {
    public class MunkarendCsomagolas {
        private int mcsID;
        private int mcsTID;
        private int mcsDobozSzam;
        private string csomagolta;
        private string datum;
        public int McsID { get => mcsID; set => mcsID = value; }
        public int McsTID { get => mcsTID; set => mcsTID = value; }
        public int McsDobozSzam { get => mcsDobozSzam; set => mcsDobozSzam = value; }
        public string Csomagolta { get => csomagolta; set => csomagolta = value; }
        public string Datum { get => datum; set => datum = value; }

        public MunkarendCsomagolas(int id, int tid, int szam, string csomagol, string date) {
            this.McsID = id;
            this.McsTID = tid;
            this.McsDobozSzam = szam;
            this.Csomagolta = csomagol;
            this.Datum = date;
        }


        public static List<MunkarendCsomagolas> getAll() {
            List<MunkarendCsomagolas> csomagolasLista = new List<MunkarendCsomagolas>();
            SQLiteConnection sqlc = new SQLiteConnection(Database.Connection1);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            SQLiteDataReader dr;
            try {
                sqlc.Open();
                sqlcommand.CommandText = "SELECT * FROM MunkarendCsomagolas";
                dr = sqlcommand.ExecuteReader();
                while (dr.Read()) {
                    MunkarendCsomagolas csomagolas = new MunkarendCsomagolas(Convert.ToInt32(dr.GetValue(0)), Convert.ToInt32(dr.GetValue(1)), Convert.ToInt32(dr.GetValue(2)), dr.GetValue(3).ToString(), dr.GetValue(4).ToString());
                    csomagolasLista.Add(csomagolas);
                }
                sqlc.Close();
            } catch (Exception ex) {
                Logger.Log("MunkarendCsomagolás osztály getAll", ex.Message);
            }
            if (sqlc.State == System.Data.ConnectionState.Open) {
                sqlc.Close();
            }
            return csomagolasLista;
        
        }
        public static List<MunkarendCsomagolas> findByMunkarendTermekID(int id) {
            List<MunkarendCsomagolas> csomagolasLista = (from x in getAll()
                                                         where x.McsTID == id
                                                         select x).ToList();
            return csomagolasLista;
        }
    }
}
