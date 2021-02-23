using IMM.Classes;
using IMM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMM.Forms {

    public partial class allomasModositasForm : Form {

        private GepAllomas _allomas;
        Database database;
        string gepNev;
        public allomasModositasForm(GepAllomas allomas) {
            this._allomas = allomas;
            InitializeComponent();
        }

        private void allomasModositasForm_Load(object sender, EventArgs e) {
            if (_allomas != null) {
                database = new Database();
                gepNev = Gep.findByID(_allomas.GepId).GepNev;
                this.Text = "Állomás módosítása - " + gepNev + " | " + _allomas.AllomasSzam;
                kivalasztottGepIdTextbox.Text = _allomas.GepId.ToString();
                kivalasztottGepTextbox.Text = gepNev;
                allomasSzamTextbox.Text = _allomas.AllomasSzam.ToString();
                allomasNevTextbox.Text = _allomas.AllomasNev;
               
            }
        }

        private void modositasBtn_Click(object sender, EventArgs e) {
            modositas();
        }

        void modositas() {
            if (mentesBtn.Visible) {
                allomasNevTextbox.ReadOnly = true;
                allomasSzamTextbox.ReadOnly = true;
                mentesBtn.Visible = false;
                mentesBtn.Enabled = false;
            } else {
                allomasNevTextbox.ReadOnly = false;
                allomasSzamTextbox.ReadOnly = false;
                mentesBtn.Visible = true;
                mentesBtn.Enabled = true;
            }
        }

        int gombnyomva = 0;
        private void torlesBtn_Click(object sender, EventArgs e) {
            if (gombnyomva == 0) {
                MessageBox.Show("Minden paramétert ami ez alá tartozik törölni fogod! \n Ha törölni szeretnéd nyomj rá még 5*!", "Állomás törlése!");
                gombnyomva++;
                torlesBtn.Text = "Állomás törlése " + gombnyomva.ToString();
            } else if (gombnyomva < 5) {
                gombnyomva++;
                torlesBtn.Text = "Állomás törlése " + gombnyomva.ToString();
            } else if (gombnyomva == 5) {
                GepAllomas.Torol(_allomas);
                torlesBtn.Text = "Állomás törlése";
                this.Close();
            }
        }

        private void mentesBtn_Click(object sender, EventArgs e) {
            //ide megint egy mentés funkció adatbázisba!
            GepAllomas allomas = new GepAllomas(_allomas.GaId, _allomas.GepId, Convert.ToInt32(allomasSzamTextbox.Text), allomasNevTextbox.Text);
            GepAllomas.Modosit(allomas);
            allomasSzamTextbox.Text = "";
            allomasNevTextbox.Text = "";
            modositas();
        }
    }
}
