using IMM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model {
    public class GepAdatok {
        private int gaid;
        private int gepid;
        private string gepmarka;
        private int lokacio;
        private string ciklusido;
        private string karbidatum;
        private string ismetlodes;


        public int GaId { get => gaid; set => gaid = value; }
        public int Gepid { get => gepid; set => gepid = value; }
        public string Gepmarka { get => gepmarka; set => gepmarka = value; }
        public int Lokacio { get => lokacio; set => lokacio = value; }
        public string Ciklusido { get => ciklusido; set => ciklusido = value; }
        public string Karbidatum { get => karbidatum; set => karbidatum = value; }
        public string Ismetlodes { get => ismetlodes; set => ismetlodes = value; }


        public GepAdatok(int id, int gid, int lok, string marka, string cikido, string karbi, string ismetles) {
            this.GaId = id;
            this.Gepid = gid;
            this.Gepmarka = marka;
            this.Lokacio = lok;
            this.Ciklusido = cikido;
            this.Karbidatum = karbi;
            this.Ismetlodes = ismetles;
        }

        

        
    }
}
