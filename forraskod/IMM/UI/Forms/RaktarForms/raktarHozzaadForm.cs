using IMM.Classes;
using IMM.Model.RaktarModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IMM.Forms.RaktarForms {
    public partial class raktarHozzaadForm : Form {
        Database database = new Database();
        List<Raktar> raktarLista;
        public raktarHozzaadForm() {
            InitializeComponent();
            raktarLista = Raktar.getAll();
        }

        private void raktarMegnevezesTextbox_TextChanged(object sender, EventArgs e) {
            ellenoriz(raktarMegnevezesTextbox.Text.ToString());
        }
        void ellenoriz(string ertek) {
            if ((from x in raktarLista where x.RaktarMegnevezes == ertek select x).Count() > 0) {
                ellenorzoLabel.Text = "Foglalt!";
                ellenorzoLabel.ForeColor = Color.DarkRed;
                mentesBtn.Enabled = false;
            } else {
                ellenorzoLabel.Text = "Szabad!";
                ellenorzoLabel.ForeColor = Color.DarkGreen;
                mentesBtn.Enabled = true;
            }
        }

        private void mentesBtn_Click(object sender, EventArgs e) {
            Raktar raktar = new Raktar(0, raktarMegnevezesTextbox.Text.ToString());
            Raktar.Hozzaad(raktar);
            this.Close();
        }
    }
}
