using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model.RaktarModel {
   public class RaktarLokacio {
        private int rlID;
        private int rID;
        private string lokacioNev;

        public int RlID { get => rlID; set => rlID = value; }
        public int RID { get => rID; set => rID = value; }
        public string LokacioNev { get => lokacioNev; set => lokacioNev = value; }

        public RaktarLokacio(int id, int rid, string nev) {
            this.rlID = id;
            this.rID = rid;
            this.LokacioNev = nev;
        }
    }
}
