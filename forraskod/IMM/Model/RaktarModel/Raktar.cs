using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model.RaktarModel {
    public class Raktar {
        private int raktarID;
        private string raktarMegnevezes;
        public int RaktarID { get => raktarID; set => raktarID = value; }
        public string RaktarMegnevezes { get => raktarMegnevezes; set => raktarMegnevezes = value; }
        public Raktar(int id, string nev) {
            this.RaktarID = id;
            this.RaktarMegnevezes = nev;
        }

       
    }
}
