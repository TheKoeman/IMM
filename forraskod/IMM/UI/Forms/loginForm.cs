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
        private void loginForm_Load(object sender, EventArgs e)
        {
            adatbazisCheck();
            usernameText.Text = IMM.Properties.Settings.Default.lastUser;
        }
        void adatbazisCheck() {
            if (Settings.Default.dbConn == "") {
                Properties.Settings.Default.dbConn = "URI = file:imm.db";
                Properties.Settings.Default.Save();
                MessageBox.Show("Nem volt adatbázis kapcsolat mentve, így alapértelmezett lett a kapcsolat!");
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
        void parseLogin(string uname, string pass)
        {
            if (User.CheckUser(uname,pass)){
                User kiolvasott = (from x in User.getAll()
                                 where x.FelhasznaloNev == uname
                                 && x.Jelszo == pass
                                 select x).FirstOrDefault();
                main frm = new main(kiolvasott);
                Settings.Default.lastUser = uname;
                Settings.Default.Save();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void loginBtn_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                textboxCheck();
            }
        }

        private void passText_KeyDown(object sender, KeyEventArgs e) {
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
