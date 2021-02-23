using IMM.Classes;
using IMM.Model;
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
    public partial class munkarendTermekModositasForm : Form {
        Database database = new Database();
        Model.Termek termek;
        MunkarendTermekek mrT;
        public munkarendTermekModositasForm(MunkarendTermekek mt) {
            this.mrT = mt;
            InitializeComponent();
            this.Text = "Módosítás : " + mrT.MunkarendMegnevezes + " | " + mrT.TermekNev;
            this.munkarendMegnevezesTextbox.Text = mrT.MunkarendMegnevezes;
            this.termekNevTextbox.Text = mrT.TermekNev;
            this.megrendeltMennyisegTextbox.Text = mrT.SzuksegesDarabszam.ToString();
            
        }

        private void munkarendTermekModositasForm_Load(object sender, EventArgs e) {
            termek = Model.Termek.findByID(mrT.TermekID);
            egyDobozLabel.Text = "Egy dobozba : "+termek.CsomagolasiDarabszam.ToString() + " termék megy!";
        }

        void dobozSzamol() {
            if (termek != null) {
                int szam = Convert.ToInt32(megrendeltMennyisegTextbox.Text) / termek.CsomagolasiDarabszam;
                dobozMennyisegTextbox.Text = szam.ToString();
            }
        }

        private void megrendeltMennyisegTextbox_TextChanged(object sender, EventArgs e) {
            dobozSzamol();
        }

        private void mentesBtn_Click(object sender, EventArgs e) {
            if (mrT.Statusz != (from x in MunkarendStatusz.getAll() where x.Sorszam == 1 select x).First().Megnevezes) {
                string a = (from x in MunkarendStatusz.getAll() where x.Sorszam == 1 select x).First().Megnevezes;
                MessageBox.Show("Nem módosítható a gyártás ha a státusza megváltozott!\nNem [" + a + "]!", "Módosítás hiba");
            } else {
                MunkarendTermekek _uj = new MunkarendTermekek(mrT.MrtID, mrT.MrID, mrT.TermekID, Convert.ToInt32(megrendeltMennyisegTextbox.Text), mrT.Statusz);
                MunkarendTermekek.Modosit(_uj);
                this.Close();
            }
        }
    }
}
