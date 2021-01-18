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

namespace IMM.Forms.GyartasForms {
    public partial class munkarendekForm : Form {

        string oldalSzoveg;
        TabControl frmControl;
        Database database = new Database();
        public munkarendekForm(TabControl tc) {
            InitializeComponent();
            oldalSzoveg = this.Text;
            frmControl = tc;
        }

        private void megrendelesekForm_Load(object sender, EventArgs e) {
            gridFeltolt();
        }


        private void ujMunkarendBtn_Click(object sender, EventArgs e) {
            munkarendHozzaadForm frm = new munkarendHozzaadForm();
            frm.ShowDialog();
        }

        void gridFeltolt() {
            munkarendekGridView.DataSource = database.getAllMunkarend();
            munkarendekGridView.Columns["MrID"].Visible = false;
            munkarendekGridView.Columns["MrAzonosito"].HeaderText = "Munkarend azonosító";
            munkarendekGridView.Columns["MrMegnevezes"].HeaderText = "Munkarend megnevezés";
            munkarendekGridView.Columns["MrDatum"].HeaderText = "Munkarend dátuma(felvétel)";
            munkarendekGridView.Columns["ElkeszultDatum"].HeaderText = "Munkarend dátuma(elkészült)";
            munkarendekGridView.Columns["Letrehozta"].HeaderText = "Létrehozta";
            munkarendekGridView.Columns["MrAzonosito"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            munkarendekGridView.Columns["MrMegnevezes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            munkarendekGridView.Columns["MrDatum"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            munkarendekGridView.Columns["ElkeszultDatum"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            munkarendekGridView.Columns["Letrehozta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }
        #region BEZÁRÁS GOMB
        private void close_MouseLeave(object sender, EventArgs e) {
            close.BackColor = Color.LightBlue;
        }

        private void close_MouseEnter(object sender, EventArgs e) {
            close.BackColor = Color.CadetBlue;
        }

        private void close_Click(object sender, EventArgs e) {
            for (int i = 0; i < frmControl.TabCount; i++) {
                if (frmControl.TabPages[i].Text == oldalSzoveg) {
                    frmControl.TabPages.RemoveAt(i);
                }
            }
        }
        #endregion

        private void munkarendekGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (munkarendekGridView.Columns[e.ColumnIndex] == selectBtn) {
                munkarendKivalasztForm frm = new munkarendKivalasztForm(Convert.ToInt32(munkarendekGridView.Rows[e.RowIndex].Cells["MrID"].Value));
                frm.ShowDialog();
            }
        }
    }
}
