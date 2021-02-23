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
    public partial class allomasHozzaadForm : Form {
        private Gep _gep;
        Database database;
        public allomasHozzaadForm(Gep gep) {
            this._gep = gep;
            InitializeComponent();
        }

        private void allomasHozzaad_Load(object sender, EventArgs e) {
            if (_gep != null) {
                kivalasztottGepIdTextbox.Text = _gep.Id.ToString();
                kivalasztottGepTextbox.Text = _gep.GepNev;
                this.Text = "Állomás hozzáadása - " + _gep.Id.ToString() + " | " + _gep.GepNev;
                database = new Database();
            }
        }

        private void allomasHozzaadBtn_Click(object sender, EventArgs e) {
            try {
                if (GepAllomas.findByAllomasSzam(Convert.ToInt32(allomasSzamTextbox.Text),Convert.ToInt32(kivalasztottGepIdTextbox.Text)).Count > 0) {
                    MessageBox.Show("Ez az állomás szám már foglalt");
                } else {
                    GepAllomas.Hozzaad(_gep.Id, Convert.ToInt32(allomasSzamTextbox.Text), allomasNevTextbox.Text);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Állomás hozzáadása hiba!");
            }
        }
    }
}
