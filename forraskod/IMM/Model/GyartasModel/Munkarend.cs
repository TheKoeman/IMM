using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model.GyartasModel {
   public class Munkarend {

        private int mrId;
        private string mrAzonosito;
        private string mrMegnevezes;
        private string mrDatum;
        private string elkeszultDatum;
        private string letrehozta;

        public Munkarend(int id, string azon, string megnev, string datum, string letrehoz,string elkeszult) {
            this.MrId = id;
            this.MrAzonosito = azon;
            this.MrMegnevezes = megnev;
            this.MrDatum = datum;
            this.Letrehozta = letrehoz;
            this.ElkeszultDatum = elkeszult;
        }

        public int MrId { get => mrId; set => mrId = value; }
        public string MrAzonosito { get => mrAzonosito; set => mrAzonosito = value; }
        public string MrMegnevezes { get => mrMegnevezes; set => mrMegnevezes = value; }
        public string MrDatum { get => mrDatum; set => mrDatum = value; }
        public string Letrehozta { get => letrehozta; set => letrehozta = value; }
        public string ElkeszultDatum { get => elkeszultDatum; set => elkeszultDatum = value; }
    }
}
