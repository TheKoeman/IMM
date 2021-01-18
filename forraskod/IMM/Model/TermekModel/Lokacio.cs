using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model {
    public class Lokacio {

        private int lokId;
        private string lokNev;
        public int LokId { get => lokId; set => lokId = value; }
        public string LokNev { get => lokNev; set => lokNev = value; }
        public Lokacio(int id, string nev) {
            this.lokId = id;
            this.LokNev = nev;
        }

    }
}
