using IMM.Classes;
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
using IMM.Model.RaktarModel;

namespace IMM.Forms.Termek {
    public partial class termekSzureseForm : Form {
        private DataGridView dgv;
        Database database = new Database();
        public termekSzureseForm(DataGridView _dgv) {
            this.dgv = _dgv;
            InitializeComponent();
        }

        private void termekSzureseForm_Load(object sender, EventArgs e) {
            kategoriaFeltoltes();
            raktarFeltoltes();
        }

        void kategoriaFeltoltes() {
            kategoriaCombobox.DataSource = database.getAllKategoria();
            kategoriaCombobox.ValueMember = "Id";
            kategoriaCombobox.DisplayMember = "KategoriaNev";
        }
        void raktarFeltoltes() {
            raktarCombobox.DataSource = database.getAllRaktar();
            raktarCombobox.ValueMember = "RaktarID";
            raktarCombobox.DisplayMember = "RaktarMegnevezes";
        }

        private void szuresBtn_Click(object sender, EventArgs e) {
            List<Model.Termek> szurtLista = new List<Model.Termek>();

            if (cikkCheck.Checked) {
                szurtLista = (from x in database.getAllTermek()
                              where x.Cikkszam.Contains(cikkszamTextbox.Text)
                              select x).ToList();
            } else if (termekNevCheck.Checked) {
                szurtLista = (from x in database.getAllTermek()
                              where x.TermekNev.Contains(termeknevTextbox.Text)
                              select x).ToList();
            } else if (termekNev2Check.Checked) {
                szurtLista = (from x in database.getAllTermek()
                              where x.TermekNev2.Contains(termeknev2Textbox.Text)
                              select x).ToList();
            } else if (kategoriaCheck.Checked) {
                szurtLista = (from x in database.getAllTermek()
                              where x.Kategoria == Convert.ToInt32(kategoriaCombobox.SelectedValue)
                              select x).ToList();
            } else if (raktarCheck.Checked) {
                szurtLista = (from x in database.getAllTermek()
                              where x.Raktar == Convert.ToInt32(raktarCombobox.SelectedValue)
                              select x).ToList();
            }
            dgv.DataSource = szurtLista;
        }

        private void cikkCheck_CheckedChanged(object sender, EventArgs e) {
            if (cikkCheck.Checked) { cikkszamTextbox.Enabled = true; } else { cikkszamTextbox.Enabled = false; }
        }

        private void termekNevCheck_CheckedChanged(object sender, EventArgs e) {
            if (termekNevCheck.Checked) { termeknevTextbox.Enabled = true; } else { termeknevTextbox.Enabled = false; }
        }

        private void termekNev2Check_CheckedChanged(object sender, EventArgs e) {
            if (termekNev2Check.Checked) { termeknev2Textbox.Enabled = true; } else { termeknev2Textbox.Enabled = false; }
        }

        private void kategoriaCheck_CheckedChanged(object sender, EventArgs e) {
            if (kategoriaCheck.Checked) { kategoriaCombobox.Enabled = true; } else { kategoriaCombobox.Enabled = false; }
        }

        private void szuresTorlesBtn_Click(object sender, EventArgs e) {
            dgv.DataSource = database.getAllTermek();
        }

        private void raktarCheck_CheckedChanged(object sender, EventArgs e) {
            if (raktarCheck.Checked) { raktarCombobox.Enabled = true; } else { raktarCombobox.Enabled = false; }
        }
    }
}
