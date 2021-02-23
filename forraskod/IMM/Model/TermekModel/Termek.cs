using IMM.Classes;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using IMM.Model;
using System.Data;

namespace IMM.Model
{
    public class Termek
    {
        Database database = new Database();
        private string termekNev;
        private string termekNev2;
        private string cikkszam;
        private int kategoriaID;
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
            this.KategoriaID = kat;
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
        public int KategoriaID { get => kategoriaID; set => kategoriaID = value; }
        public int CsomagolasiDarabszam { get => csomagolasiDarabszam; set => csomagolasiDarabszam = value; }
        public int MinimumGyarthato { get => minimumGyarthato; set => minimumGyarthato = value; }
        public int Felkesztermek { get => felkesztermek; set => felkesztermek = value; }
        public int BeepuloAnyag { get => beepuloAnyag; set => beepuloAnyag = value; }
        public int Aktiv { get => aktiv; set => aktiv = value; }
        public int Raktar { get => raktar; set => raktar = value; }
        public string RaktarNev {
            get {
                if ((from x in Model.RaktarModel.Raktar.getAll() where x.RaktarID == Raktar select x.RaktarMegnevezes).Count() > 0) {
                    return (from x in Model.RaktarModel.Raktar.getAll() where x.RaktarID == Raktar select x.RaktarMegnevezes).First().ToString();
                } else {
                    return "Nincs ilyen raktár!";
                }
            }
        }
        public string KategoriaNev {
            get {
                return (from x in Kategoria.getAll() where x.Id == kategoriaID select x.KategoriaNev).First().ToString();
            }
        }
        public override string ToString()
        {
            return ID + " | " + termekNev + " | " + termekNev2;
        }


        public static List<Termek> getAll() {
            List<Termek> _termekek = new List<Termek>();
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            sqlc.Open();
            SQLiteDataReader dr;
            try {
                sqlcommand.CommandText = "SELECT * FROM Termekek";
                dr = sqlcommand.ExecuteReader();
                while (dr.Read()) {
                    Termek jelenlegiTermek = new Termek(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), Convert.ToInt32(dr.GetValue(4)), Convert.ToInt32(dr.GetValue(5)), Convert.ToInt32(dr.GetValue(6)), Convert.ToInt32(dr.GetValue(7)), Convert.ToInt32(dr.GetValue(8)), Convert.ToInt32(dr.GetValue(9)), Convert.ToInt32(dr.GetValue(10)));

                    _termekek.Add(jelenlegiTermek);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Termékek kiolvasása SQL hiba!");
                Logger.Log("Termek getAll", ex.Message);
            }
            if (sqlc.State == ConnectionState.Open) {
                sqlc.Close();
            }
            return _termekek;
        }
        public static Termek findByID(int id) {
            Termek _termek = (from x in getAll()
                              where x.id == id
                              select x).First();
            return _termek;
        }
        public static void Modosit(Termek _termek) {
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            sqlc.Open();
            try {
                sqlcommand.CommandText = "UPDATE Termekek SET termekNev='" + _termek.TermekNev + "',termekNev2='" + _termek.TermekNev2 + "',cikkszam='" + _termek.Cikkszam + "',kategoria='" + _termek.KategoriaID + "',csomagolasidarabszam='" + _termek.CsomagolasiDarabszam + "',minimumgyarthato='" + _termek.MinimumGyarthato + "',felkesztermek='" + _termek.Felkesztermek + "',beepuloanyag='" + _termek.BeepuloAnyag + "',aktiv='" + _termek.Aktiv + "',raktar='" + _termek.Raktar + "' where id='" + _termek.ID + "'";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Termek módosítása SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
            if (sqlc.State == ConnectionState.Open) {
                sqlc.Close();
            }
        }
        public static void Hozzaad(Termek _termek) {
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            sqlc.Open();
            try {
                sqlcommand.CommandText = "INSERT INTO Termekek (termekNev,termekNev2,cikkszam,kategoria,raktar) VALUES('" + _termek.TermekNev + "','" + _termek.TermekNev2 + "','" + _termek.Cikkszam + "','" + _termek.KategoriaID + "','" + _termek.Raktar + "')";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                Logger.Log("Terméh hozzáadás hiba", ex.Message);
            }
            if (sqlc.State == ConnectionState.Open) {
                sqlc.Close();
            }
        }
    }
}
