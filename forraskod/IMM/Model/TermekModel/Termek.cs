using IMM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IMM.Model
{
    public class Termek
    {
        Database database = new Database();
        private string termekNev;
        private string termekNev2;
        private string cikkszam;
        private int kategoria;
        private int raktar;
        private int csomagolasiDarabszam;
        private int minimumGyarthato;
        private int felkesztermek;
        private int beepuloAnyag;
        private int aktiv;
        private int id;
        public Termek(int id, string tnev, string tnev2, string cszam,int kat,int csomagdb, int mingyarth, int felkesz, int beepulo, int raktar, int aktiv)
        {
            this.id = id;
            this.TermekNev = tnev;
            this.TermekNev2 = tnev2;
            this.Cikkszam = cszam;
            this.Kategoria = kat;
            this.Raktar = raktar;
            this.CsomagolasiDarabszam = csomagdb;
            this.MinimumGyarthato = mingyarth;
            this.Felkesztermek = felkesz;
            this.BeepuloAnyag = beepulo;
            this.Aktiv = aktiv;
        }
        public int ID { get => id; } 
        public string TermekNev { get => termekNev; set => termekNev = value; }
        public string TermekNev2 { get => termekNev2; set => termekNev2 = value; }
        public string Cikkszam { get => cikkszam; set => cikkszam = value; }
        public int Kategoria { get => kategoria; set => kategoria = value; }
        public int CsomagolasiDarabszam { get => csomagolasiDarabszam; set => csomagolasiDarabszam = value; }
        public int MinimumGyarthato { get => minimumGyarthato; set => minimumGyarthato = value; }
        public int Felkesztermek { get => felkesztermek; set => felkesztermek = value; }
        public int BeepuloAnyag { get => beepuloAnyag; set => beepuloAnyag = value; }
        public int Aktiv { get => aktiv; set => aktiv = value; }
        public int Raktar { get => raktar; set => raktar = value; }
        public string RaktarNev {
            get {
                if ((from x in database.getAllRaktar() where x.RaktarID == Raktar select x.RaktarMegnevezes).Count() > 0) {
                    return (from x in database.getAllRaktar() where x.RaktarID == Raktar select x.RaktarMegnevezes).First().ToString();
                } else {
                    return "Nincs ilyen raktár!";
                }
            }
        }
        public string KategoriaNev {
            get {
                return (from x in database.getAllKategoria() where x.Id == kategoria select x.KategoriaNev).First().ToString();
            }
        }
        public override string ToString()
        {
            return ID + " | " + termekNev + " | " + termekNev2;
        }

    }
}
