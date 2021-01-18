using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model.GyartasModel {
   public class MunkarendStatusz {

        private int msID;
        private string megnevezes;
        private string szin;
        private int sorszam;

        public MunkarendStatusz(int id, string megnev, string szi, int szam) {
            this.MsID = id;
            this.Megnevezes = megnev;
            this.Szin = szi;
            this.Sorszam = szam;
        }

        public int MsID { get => msID; set => msID = value; }
        public string Megnevezes { get => megnevezes; set => megnevezes = value; }
        public string Szin { get => szin; set => szin = value; }
        public int Sorszam { get => sorszam; set => sorszam = value; }
    }
}
