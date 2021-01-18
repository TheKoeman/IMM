using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMM.Model
{
    public class Kategoria
    {
        private int id;
        private string kategoriaNev;
        private int aktiv;
        
        public Kategoria(int id, string katnev)
        {
            this.Id = id;
            this.KategoriaNev = katnev;
        }

        public int Id { get => id; set => id = value; }
        public string KategoriaNev { get => kategoriaNev; set => kategoriaNev = value; }
        public int Aktiv { get => aktiv; set => aktiv = value; }




    }
}
