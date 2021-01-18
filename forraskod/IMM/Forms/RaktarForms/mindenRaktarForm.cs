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

namespace IMM.Forms.RaktarForms {
    public partial class mindenRaktarForm : Form {
        Database database = new Database();
        string oldalSzoveg;
        TabControl frmControl;
        public mindenRaktarForm(TabControl tbc) {    
            InitializeComponent();
            oldalSzoveg = this.Text;
            frmControl = tbc;
        }

        private void mindenRaktarForm_Load(object sender, EventArgs e) {
            gridFeltolt();
        }

        void gridFeltolt() {
            mindenRaktarGridView.DataSource = database.getAllRaktar();
            mindenRaktarGridView.Columns["RaktarID"].HeaderText = "Raktár ID";
            mindenRaktarGridView.Columns["RaktarMegnevezes"].HeaderText = "Raktár megnevezés";
            mindenRaktarGridView.Columns["RaktarID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mindenRaktarGridView.Columns["RaktarMegnevezes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        #region BEZÁRÁS GOMB
        private void close_Click(object sender, EventArgs e) {
            for (int i = 0; i < frmControl.TabCount; i++) {
                if (frmControl.TabPages[i].Text == oldalSzoveg) {
                    frmControl.TabPages.RemoveAt(i);
                }
            }
        }
        #endregion

        private void ujRaktarBtn_Click(object sender, EventArgs e) {
            raktarHozzaadForm frm = new raktarHozzaadForm();
            frm.ShowDialog();
            gridFeltolt();
        }
    }
}
