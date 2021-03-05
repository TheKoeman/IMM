using IMM.Classes;
using IMM.Model.GyartasModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMM.Forms.GyartasForms {
    public partial class munkarendHozzaadForm : Form {
        public munkarendHozzaadForm() {
            InitializeComponent();
        }
        Database database = new Database();
        public List<Model.Termek> termekek = new List<Model.Termek>();

        bool megfelelo() {
            if (munAzonTextbox.Text.Length >= 5) {
                if (Munkarend.findByAzonosito(munAzonTextbox.Text.ToString()) == null) {
                    ellenorzoLabel.Text = "Megfelelő!";
                    ellenorzoLabel.ForeColor = Color.Green;
                    return true;
                } else {
                    ellenorzoLabel.Text = "Foglalt!";
                    ellenorzoLabel.ForeColor = Color.Red;
                    return false;
                }
            } else {
                ellenorzoLabel.Text = "Nem megfelelő!";
                ellenorzoLabel.ForeColor = Color.Red;
                return false;
            }
        }

        private void munAzonTextbox_TextChanged(object sender, EventArgs e) {
            if (megfelelo()) {
                megnevezesTextbox.Enabled = true;
                letrehozasBtn.Visible = true;
            } else {
                megnevezesTextbox.Enabled = false;
                letrehozasBtn.Visible = false;
            }
        }

        private void termekGyartasbaBtn_Click(object sender, EventArgs e) {
            termekGyartashozForm frm = new termekGyartashozForm(Munkarend.findByAzonosito(munAzonTextbox.Text).MrId,munkarendGyartasGridView);
            frm.ShowDialog();
            termekGridFeltolt();
        }

        void termekGridFeltolt() {
            munkarendGyartasGridView.DataSource = (from x in MunkarendTermekek.getAll()
                                                   where x.MrID == Convert.ToInt32(munAzonTextbox.Text)
                                                   select x).ToList();
            munkarendGyartasGridView.Columns["MrtID"].Visible = false;
            munkarendGyartasGridView.Columns["MrID"].HeaderText = "Munkarend ID";
            munkarendGyartasGridView.Columns["TermekID"].HeaderText = "Termék ID";
            munkarendGyartasGridView.Columns["SzuksegesDarabszam"].HeaderText = "Szükséges darabszám";
            munkarendGyartasGridView.Columns["TermekNev"].HeaderText = "Termék név";
            munkarendGyartasGridView.Columns["MunkarendMegnevezes"].Visible = false;
            munkarendGyartasGridView.Columns["MrID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            munkarendGyartasGridView.Columns["TermekID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            munkarendGyartasGridView.Columns["SzuksegesDarabszam"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            munkarendGyartasGridView.Columns["TermekNev"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            munkarendGyartasGridView.Columns["MunkarendMegnevezes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void letrehozasBtn_Click(object sender, EventArgs e) {
            Munkarend mr;
            if (Munkarend.getAll().Count==0 ) {
                mr = new Munkarend(1, munAzonTextbox.Text, megnevezesTextbox.Text, DateTime.Now.ToShortDateString(), "", "");
            } else {
                mr = new Munkarend(Munkarend.getAll().LastOrDefault().MrId + 1, munAzonTextbox.Text, megnevezesTextbox.Text, DateTime.Now.ToShortDateString(), "", "");
            }
            try {
                Munkarend.Hozzaad(mr);
                checkSucc();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } 
        }
        void checkSucc() {
            if (Munkarend.findByAzonosito(munAzonTextbox.Text) != null) {
                termekGyartasbaBtn.Enabled = true;
            }
        }
    }
}
