using System;
using System.Drawing;
using System.Windows.Forms;
using IMM.Classes;
using IMM.Forms;
using IMM.Forms.GyartasForms;
using IMM.Forms.RaktarForms;

namespace IMM
{
    public partial class main : Form
    {
        public string loggedUser;
        public main(string uname,string veznev, string kernev)
        {
            InitializeComponent();
            this.loggedUser = uname;
            bottomMenuUNBox.Text = veznev + " " + kernev;
        }

        private void main_Load(object sender, EventArgs e)
        {
        
        }


        #region GOMB EVENTEK
        private void raktarBtn_Click(object sender, EventArgs e) {
            mindenRaktarForm frm = new mindenRaktarForm(tabControl2);
            mdiMutat(frm);
        }
        private void mindenGyartasBtn_Click(object sender, EventArgs e) {
            mindenGyartasForm frm = new mindenGyartasForm(tabControl2);
            mdiMutat(frm);
        }
        private void mindenTermekBtn_Click(object sender, EventArgs e) {
            mindenTermekForm frm = new mindenTermekForm(tabControl2);
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
        public void tabPageBezar(string szoveg) {
            if (tabControl2.TabCount > 0) {
                for (int i = 0; i < tabControl2.TabCount; i++) {
                    if (tabControl2.TabPages[i].Text == szoveg) {
                        MessageBox.Show(szoveg + " | " + tabControl2.TabPages[i].Text);
                        tabControl2.TabPages.RemoveAt(i);
                    }
                }
            }
        }

        private bool formActive(Form _frm) {

            if (tabControl2.TabCount > 0) {
                foreach (TabPage item in tabControl2.TabPages) {
                    if (_frm.Text == item.Text) {
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







        #endregion

        private void bottomMenuLoggerTextbox_Click(object sender, EventArgs e) {
            Logger.mappaMegnyit();
        }


    }
}
