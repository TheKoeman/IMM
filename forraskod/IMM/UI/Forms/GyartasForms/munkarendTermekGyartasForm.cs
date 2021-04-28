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
    public partial class munkarendTermekGyartasForm : Form {
        private MunkarendTermekek munkarendTermek;
        public munkarendTermekGyartasForm(MunkarendTermekek _termek) {
            this.munkarendTermek = _termek;
            InitializeComponent();
        }

        private void munkarendTermekGyartasForm_Load(object sender, EventArgs e) {
            adatokFeltolt();
            this.Text = string.Format("Gyártás :{0} | GyártásTermék:{1}", munkarendTermek.MrID, munkarendTermek.MrtID);
        }
        void adatokFeltolt() {
            termekNevTextbox.Text = munkarendTermek.TermekNev;
            dobozbaKerulTextbox.Text = Model.Termek.findByID(munkarendTermek.TermekID).CsomagolasiDarabszam.ToString();
            megrendeltDarabszamTextbox.Text = munkarendTermek.SzuksegesDarabszam.ToString();
            elkeszultDobozTextbox.Text = MunkarendCsomagolas.findByMunkarendTermekID(munkarendTermek.MrtID).Count().ToString();
            hatralevoDobozTextbox.Text = ((munkarendTermek.SzuksegesDarabszam / Model.Termek.findByID(munkarendTermek.TermekID).CsomagolasiDarabszam) - MunkarendCsomagolas.findByMunkarendTermekID(munkarendTermek.MrtID).Count()).ToString();
        }
    }
}
