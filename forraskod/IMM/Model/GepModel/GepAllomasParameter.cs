using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model {
    public class GepAllomasParameter {

        private int gapId;
        private int allomasId;
        private string parameterNev;
        private string parameterErtek;
        private string modositasDatuma;
        private string modositotta;

        public int GapId { get => gapId; set => gapId = value; }
        public int AllomasId { get => allomasId; set => allomasId = value; }
        public string ParameterNev { get => parameterNev; set => parameterNev = value; }
        public string ParameterErtek { get => parameterErtek; set => parameterErtek = value; }
        public string ModositasDatuma { get => modositasDatuma; set => modositasDatuma = value; }
        public string Modositotta { get => modositotta; set => modositotta = value; }
        
        public GepAllomasParameter(int id, int aid, string paramnev, string paramertek, string modositasdatum, string modositott) {
            this.GapId = id;
            this.AllomasId = aid;
            this.ParameterNev = paramnev;
            this.ParameterErtek = paramertek;
            this.modositasDatuma = modositasdatum;
            this.Modositotta = modositott;
        }

       
    }
}
