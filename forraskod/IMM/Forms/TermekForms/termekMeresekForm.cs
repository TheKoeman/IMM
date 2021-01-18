using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMM.Model;

namespace IMM.Forms.TermekForms {
    public partial class termekMeresekForm : Form {
        private Model.Termek termek;
        public termekMeresekForm(Model.Termek _termek) {
            this.termek = _termek;
            InitializeComponent();
        }

        private void termekMeresekForm_Load(object sender, EventArgs e) {
            termekIdTextbox.Text = termek.ID.ToString();
            TermekNevTextbox.Text = termek.TermekNev;
        }

        private void meresSorszamTextbox_Click(object sender, EventArgs e) {

        }

        private void meresMegnevezesTextbox_Click(object sender, EventArgs e) {

        }

        private void szuksegesMeresTextbox_Click(object sender, EventArgs e) {

        }

        private void elvegezniCombobox_Click(object sender, EventArgs e) {

        }

        private void hozzaadBtn_Click(object sender, EventArgs e) {
            if (elvegezniCombobox.Text == "" || szuksegesMeresTextbox.Text == "" || meresSorszamTextbox.Text == "" || szuksegesMeresTextbox.Text == "") {
                MessageBox.Show("Kérlek tölts ki minden adatot!");
            } else {
                //mérés hozzáadása a TermekMeresek táblához.
            }
        }
    }
}
