﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMM.Classes;

namespace IMM.Model
{
    public class User
    {
        #region init
        private int id;
        private string felhasznaloNev;
        private string jelszo;
        private string email;
        private string vezetekNev;
        private string keresztNev;
        private int jogkor;
        private Database database;
        public int Id { get => id; set => id = value; }
        public string FelhasznaloNev { get => felhasznaloNev; set => felhasznaloNev = value; }
        public string Jelszo { get => jelszo; set => jelszo = value; }
        public string Email { get => email; set => email = value; }
        public string VezetekNev { get => vezetekNev; set => vezetekNev = value; }
        public string KeresztNev { get => keresztNev; set => keresztNev = value; }
        public int Jogkor { get => jogkor; set => jogkor = value; }
        internal Database Database { get => database; set => database = value; }
        #endregion
        public User(int id,string user, string pass, string mail, string veznev, string kernev, int jog)
        {
            this.Id = id;
            this.FelhasznaloNev = user;
            this.Jelszo = pass;
            this.Email = mail;
            this.VezetekNev = veznev;
            this.KeresztNev = kernev;
            this.Jogkor = jog;
        }

        public bool Login
        {
            get
            {
                Database = new Database();
                List<User> mindenUser = getAll();
                var szurtUser = from x in mindenUser
                            where x.FelhasznaloNev == FelhasznaloNev
                            && x.Jelszo == Jelszo
                            select x;
                if (szurtUser.Any())
                {
                    foreach (var adat in szurtUser)
                    {
                        Id = adat.Id;
                        Email = adat.Email;
                        VezetekNev = adat.VezetekNev;
                        KeresztNev = adat.KeresztNev;
                        Jogkor = adat.Jogkor;
                        MessageBox.Show(VezetekNev);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public static bool CheckUser(List<User> mindenUser, string uname, string pass)
        {
            var szurtUser = from x in mindenUser
                            where x.FelhasznaloNev == uname
                            && x.Jelszo == pass
                            select x;
            if (szurtUser.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<User> getAll() {
            List<User> _userek = new List<User>();
            SQLiteConnection sqlc = new SQLiteConnection(Database.connection);
            SQLiteCommand sqlcommand = new SQLiteCommand(sqlc);
            SQLiteDataReader dr;
            sqlc.Open();
            try {
                sqlcommand.CommandText = "SELECT * FROM Felhasznalok";
                dr = sqlcommand.ExecuteReader();
                while (dr.Read()) {
                    User _user = new User(Convert.ToInt32(dr.GetValue(0)), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString(), Convert.ToInt32(dr.GetValue(6)));
                    _userek.Add(_user);
                }
            } catch (Exception ex) {
                MessageBox.Show("Felhasználók kiolvasása hiba!", ex.Message);
                Logger.Log("users getAll", ex.Message);
            }
            if (sqlc.State == ConnectionState.Open) {
                sqlc.Close();
            }
            return _userek;
        }

    }
}
