using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using IMM.Classes;
using IMM.Properties;
using IMM.Model;
namespace IMM.Install
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        Database database;
        private void loginForm_Load(object sender, EventArgs e)
        {
            usernameText.Text = IMM.Properties.Settings.Default.lastUser;
            adatbazisCheck();
        }
        void adatbazisCheck() {
            if (Settings.Default.dbConn == "") {
                Properties.Settings.Default.dbConn = "URI = file:imm.db";
                Properties.Settings.Default.Save();
                MessageBox.Show("Alapértelmezett lett az adatbázis kapcsolat!");
                loginBtn.Enabled = false;
            } else {
                database = new Database();
                loginBtn.Enabled = true;
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            textboxCheck();
        }
        void textboxCheck() {
            if (usernameText.Text == "" & passText.Text == "") {
                MessageBox.Show("Üres adatokkal nem tudsz bejelentkezni!");
            } else if (usernameText.Text == "" & passText != null) {
                MessageBox.Show("A Felhasználónév nem lehet üres!");
            } else if (passText.Text == "" & usernameText.Text != null) {
                MessageBox.Show("A Jelszó nem lehet üres!");
            } else {
                parseLogin(usernameText.Text, passText.Text);
            }
        }
        private void showPassBtn_Click(object sender, EventArgs e)
        {
            if (passText.PasswordChar == '*')
                passText.PasswordChar = '\0';
            else
                passText.PasswordChar = '*';
        }
        string vez, ker;
        void parseLogin(string uname, string pass)
        {
            List<User> ur = User.getAll();
            if (User.CheckUser(ur, uname,pass)){
                var kiolvasott = from x in ur
                                 where x.FelhasznaloNev == uname
                                 && x.Jelszo == pass
                                 select x;
                foreach (var sor in kiolvasott){
                    vez = sor.VezetekNev;
                    ker = sor.KeresztNev;
                }
                main frm = new main(uname, vez, ker);
                Settings.Default.lastUser = uname;
                Settings.Default.Save();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }else{
                MessageBox.Show("Kérlek ellenőrizd a felhasználónevet vagy a jelszót!");
            }
        }

        private void loginBtn_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                textboxCheck();
            }
        }

        private void dbSet_Click(object sender, EventArgs e)
        {
            DBBeallitasForm frm = new DBBeallitasForm();
            frm.ShowDialog();
            adatbazisCheck();
        }
    }
}
