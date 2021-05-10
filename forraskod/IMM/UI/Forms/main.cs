using System;
using System.Drawing;
using System.Windows.Forms;
using IMM.Classes;
using IMM.Forms;
using IMM.Forms.GyartasForms;
using IMM.Forms.NyelvForms;
using IMM.Forms.RaktarForms;

namespace IMM
{
    public partial class main : Form
    {
        private Model.User LoggedUser;
        private static TabControl staticControl2;
        public main(Model.User loggedUser)
        {
            InitializeComponent();
            LoggedUser = loggedUser;
            staticControl2 = tabControl2;
        }

        private void main_Load(object sender, EventArgs e)
        {
            bottomMenuUNBox.Text = string.Format("{0} {1}", LoggedUser.VezetekNev, LoggedUser.KeresztNev);
        }


        #region GOMB EVENTEK
        private void bottomMenuLoggerTextbox_Click(object sender, EventArgs e) {
            Logger.mappaMegnyit();
        }

        private void nyelvBtn_Click(object sender, EventArgs e) {
            NyelvForm frm = new NyelvForm(tabControl2);
            mdiMutat(frm);
        }
        private void raktarBtn_Click(object sender, EventArgs e) {
            mindenRaktarForm frm = new mindenRaktarForm(tabControl2);
            mdiMutat(frm);
        }
        private void mindenGyartasBtn_Click(object sender, EventArgs e) {
            mindenGyartasForm frm = new mindenGyartasForm(tabControl2);
            mdiMutat(frm);
        }
        private void mindenTermekBtn_Click(object sender, EventArgs e) {
            mindenTermekForm frm = new mindenTermekForm();
            mdiMutat(frm);
        }
        private void termekKategoriakBtn_Click(object sender, EventArgs e) {
            termekKategoriakForm frm = new termekKategoriakForm(tabControl2);
            mdiMutat(frm);
        }
        private void gepekBtn_Click(object sender, EventArgs e) {
            GepForm frm = new GepForm(tabControl2);
            mdiMutat(frm);
        }

        private void munkarendekBtn_Click(object sender, EventArgs e) {
            munkarendekForm frm = new munkarendekForm(tabControl2);
            mdiMutat(frm);
        }
        private void statuszokBtn_Click(object sender, EventArgs e) {
            statuszokForm frm = new statuszokForm(tabControl2);
            mdiMutat(frm);
        }
        private void azonGeneralBtn_Click(object sender, EventArgs e) {
            azonositoBeallitasokForm frm = new azonositoBeallitasokForm();
            frm.ShowDialog();
        }
        #endregion

        #region TABPAGE
        public static void closeTabpage(string szoveg) {
            foreach (TabPage tp in staticControl2.TabPages) {
                if (tp.Text == szoveg) {
                    staticControl2.TabPages.Remove(tp);
                }
            }
        }

        private bool formActive(Form _frm) {
            if (tabControl2.TabCount > 0) {
                foreach (TabPage item in tabControl2.TabPages) {
                    if (_frm.Text == item.Text) {
                        tabControl2.SelectedTab = item;
                        return true;
                    }
                }
            }
            return false;
        }
        void mdiMutat(Form _frm) {
            TabPage tp = new TabPage();
            if (!formActive(_frm)) {
                tp.Size = this.Size;
                _frm.Dock = DockStyle.Fill;
                _frm.TopLevel = false;
                tp.Text = _frm.Text;
                tabControl2.TabPages.Add(tp);
                tp.Controls.Add(_frm);
                _frm.Show();
                tabControl2.SelectedTab = tp;
            }
        }

        //ki kell olvasni a LangManager string értékét ami kér egy string kompnev értéket és visszadja annak a kiválasztott nyelv értékét
        //ezt az mdiMutat metódusba rakni amikor hozzáadásra kerül a TabPage, hogy mindig az legyen az oldal neve amelyik nyelv éppen ki van választva
        //minden formon a bezárás ikont átcserélni bezárás gombra, így egyszerűbb lesz kezelni
        //NyelvForm felépítése és kezelése, új üzenetek,komponensNyelvek felvétele, jelenlegiek módosítása
        //nyelv változtatás a login oldalra, illetve connectionString a login oldalra, illetve DatabaseManager class létrehozása a if(con.State == -> ez miatt
        //nyelv elmentése User Propertiesbe
        //Bejelentkezett User loginból átadni a mainFormnak.
        //bejelentkezéshez felhnév és jelszó ellenőrzés külön-külön!






        #endregion

    }
}
