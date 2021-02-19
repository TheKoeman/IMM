using IMM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model.GyartasModel {
    public class MunkarendTermekek {
        Database database = new Database();
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
                return database.munkarendFindByID(MrID).First().MrMegnevezes;
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
    }
}
