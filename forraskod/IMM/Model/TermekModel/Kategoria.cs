using IMM.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static List<Kategoria> getAll() {
            List<Kategoria> _kategoriak = new List<Kategoria>();
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            SQLiteDataReader dr;
            sqlc.Open();
            try {
                sqlcommand.CommandText = "SELECT * FROM kategoriak";
                dr = sqlcommand.ExecuteReader();
                while (dr.Read()) {
                    Kategoria jelenlegiKategoria = new Kategoria(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString());
                    _kategoriak.Add(jelenlegiKategoria);
                }
                dr.Close();
            } catch (Exception ex) {
                MessageBox.Show("Kategóriák kiolvasása hiba!", ex.Message);
                Logger.Log("Kategoria getAll", ex.Message);
            }
            if (sqlc.State == ConnectionState.Open) {
                sqlc.Close();
            }
            return _kategoriak;
        }
        public static Kategoria findByName(string name) {
            Kategoria _kategoria = (from x in getAll()
                                    where x.kategoriaNev == name
                                    select x).FirstOrDefault();
            return _kategoria;
        }
        public static void Modosit(Kategoria _kategoria) {
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            try {
                sqlc.Open();
                sqlcommand.CommandText = "UPDATE Kategoriak SET kategoriaNev='" + _kategoria.KategoriaNev + "' WHERE id='" + _kategoria.Id + "'";
                sqlcommand.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Kategória módosítás SQL hiba!");
                Logger.Log("Database", ex.Message);
            }
            if (sqlc.State == ConnectionState.Open) {
                sqlc.Close();
            }
        }

    }
}
