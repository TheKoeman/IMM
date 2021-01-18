using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        
    }
}
