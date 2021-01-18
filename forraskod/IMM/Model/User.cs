using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMM.Classes;

namespace IMM.Model
{
    class User
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
                List<User> mindenUser = Database.getAllUser();
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


    }
}
