using IMM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model {
    public class GepKategoria {
        Database database = new Database();
        private int id;
        private int gepId;
        private int kategoriaId;

        public int Id { get => id; set => id = value; }
        public int GepId { get => gepId; set => gepId = value; }
        public int KategoriaId { get => kategoriaId; set => kategoriaId = value; }
        public string GepNev {
            get {
                List<Gep> gList = database.getAllGep();
                string eredmeny = (from x in gList
                                   where x.Id == GepId
                                   select x.GepNev).First().ToString();
                return eredmeny;
            }
        }
        public string KategoriaNev {
            get {
                List<Kategoria> katList = Kategoria.getAll();
                string eredmeny = (from x in katList
                                   where x.Id == KategoriaId
                                   select x.KategoriaNev).First().ToString();
                return eredmeny;
            }
        }

        public GepKategoria(int id, int gid, int kid) {
            this.Id = id;
            this.GepId = gid;
            this.KategoriaId = kid;
        }



    }
}
