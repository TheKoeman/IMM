using IMM.Classes;
using IMM.UControl;
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
    public partial class GepForm : Form {
        private TabControl frmControl;
        private string oldalSzoveg;
        GepKezelesUC gkuc;
        Database database = new Database();
        public GepForm(TabControl _tc) {
           
            this.frmControl = _tc;
            InitializeComponent();
        }
        private void GepForm_Load(object sender, EventArgs e) {
            oldalSzoveg = this.Text;
            gridFeltolt();
        }




        void gridFeltolt() {
            gepekGridView.DataSource = database.getAllGep();
            gepekGridView.Columns[1].HeaderText = "Gép ID";
            gepekGridView.Columns[2].HeaderText = "Gép neve";
            gepekGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gepekGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gepekGridView.Rows[1].Selected = true;
        }


        private void close_Click(object sender, EventArgs e) {
            for (int i = 0; i < frmControl.TabCount; i++) {
                if (frmControl.TabPages[i].Text == oldalSzoveg) {
                    frmControl.TabPages.RemoveAt(i);
                }
            }
        }

        private void gepekGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && gepekGridView.Columns[e.ColumnIndex] == selectBtn) {
                Form frm = new Form();
                frm.ShowIcon = false;
                frm.StartPosition = FormStartPosition.CenterParent;
                gkuc = new GepKezelesUC(gepekGridView,Convert.ToInt32(gepekGridView.Rows[e.RowIndex].Cells["id"].Value), database.gepAdatokByGepId(Convert.ToInt32(gepekGridView.Rows[e.RowIndex].Cells["id"].Value)).FirstOrDefault());
                gkuc.Parent = frm;
                frm.Size = gkuc.Size;
                gkuc.Dock = DockStyle.Fill;
                frm.Text = gepekGridView.Rows[e.RowIndex].Cells["gepnev"].Value.ToString() + " gép adatai";
                frm.ShowDialog();
               
            }
        }

        private void ujGepBtn_Click(object sender, EventArgs e) {
            Form frm = new Form();
            frm.ShowIcon = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            gkuc = new GepKezelesUC(gepekGridView, database.getAllGep().LastOrDefault().Id+1 , null);
            gkuc.Parent = frm;
            frm.Size = gkuc.Size;
            gkuc.Dock = DockStyle.Fill;
            frm.Text = "Új gép hozzáadása";
            frm.ShowDialog();
        }

        private void frissitesBtn_Click(object sender, EventArgs e) {
            gepekGridView.DataSource = database.getAllGep();
        }
    }
}
