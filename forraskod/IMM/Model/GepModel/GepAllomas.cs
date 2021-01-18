using System;
using System.Collections.Generic;
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

       
    }
}
