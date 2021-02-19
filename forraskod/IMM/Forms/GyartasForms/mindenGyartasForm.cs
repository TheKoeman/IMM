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
    public partial class mindenGyartasForm : Form {
        Database database = new Database();
        string oldalSzoveg;
        TabControl frmControl;
        public mindenGyartasForm(TabControl tbc) {
            InitializeComponent();
            oldalSzoveg = this.Text;
            frmControl = tbc;
        }

        private void mindenGyartasForm_Load(object sender, EventArgs e) {
            dataGridFeltolt();
            timer1.Start();
        }

        void dataGridFeltolt() {
            List<MunkarendTermekek> gyartasLista = database.getAllMunkarendTermekek().OrderBy(x => x.MrID).ToList();
            mindenGyartasGridView.DataSource = gyartasLista;
            mindenGyartasGridView.Columns["MrtID"].Visible = false;
            mindenGyartasGridView.Columns["MrID"].Visible = false;
            mindenGyartasGridView.Columns["TermekID"].Visible = false;
            mindenGyartasGridView.Columns["SzuksegesDarabszam"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mindenGyartasGridView.Columns["TermekNev"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mindenGyartasGridView.Columns["MunkarendMegnevezes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mindenGyartasGridView.Columns["Statusz"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mindenGyartasGridView.Columns["SzuksegesDarabszam"].HeaderText = "Megrendelt mennyiség";
            mindenGyartasGridView.Columns["TermekNev"].HeaderText = "Termék név";
            mindenGyartasGridView.Columns["MunkarendMegnevezes"].HeaderText = "Munkarend megnevezés";
            mindenGyartasGridView.Columns["Statusz"].HeaderText = "Státusz";
            mindenGyartasGridView.Columns["MunkarendMegnevezes"].DisplayIndex = 3;
        }
        void sorokSzinez() {
            foreach (DataGridViewRow dgvr in mindenGyartasGridView.Rows) {
                if (dgvr.Cells["Statusz"].Value.ToString().Length > 1) {
                    MunkarendStatusz mrs = (from x in database.getAllMunkarendStatuszok()
                                            where x.Megnevezes == dgvr.Cells["Statusz"].Value.ToString()
                                            select x).First();
                    if (dgvr.Cells["Statusz"].Value.ToString() == mrs.Megnevezes) {
                        dgvr.DefaultCellStyle.BackColor = Color.FromName(mrs.Szin);
                    }
                }
            }
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

        private void timer1_Tick(object sender, EventArgs e) {
            sorokSzinez();
        }

        private void mindenGyartasGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (mindenGyartasGridView.Columns[e.ColumnIndex] == munkarendOldalBtn) {
                munkarendKivalasztForm frm = new munkarendKivalasztForm(Convert.ToInt32(mindenGyartasGridView.Rows[e.RowIndex].Cells["MrID"].Value));
                frm.ShowDialog();
            }
        }

        private void szuresBtn_Click(object sender, EventArgs e) {
            gyartasSzuresForm frm = new gyartasSzuresForm(mindenGyartasGridView);
            frm.ShowDialog();

        }
    }
}
