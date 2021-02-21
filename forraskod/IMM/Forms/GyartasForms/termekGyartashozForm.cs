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
    public partial class termekGyartashozForm : Form {
        private Database database;
        private int MunkarendID;
        public termekGyartashozForm(int munkarendid) {
            this.MunkarendID = munkarendid;
            database = new Database();
            InitializeComponent();
        }


        private void termekGyartashozForm_Load(object sender, EventArgs e) {
            gridFeltolt();
        }

        void gridFeltolt() {
            termekekGridView.DataSource = null;
            termekekGridView.DataSource = (from x in Model.Termek.getAll()
                                           where x.Aktiv == 1
                                           select x).ToList();
            termekekGridView.Columns["ID"].Visible = false;
            termekekGridView.Columns["TermekNev"].Visible = true;
            termekekGridView.Columns["TermekNev2"].Visible = true;
            termekekGridView.Columns["Cikkszam"].Visible = true;
            termekekGridView.Columns["TermekNev"].HeaderText = "Termék név";
            termekekGridView.Columns["TermekNev2"].HeaderText = "Termék név 2";
            termekekGridView.Columns["Cikkszam"].HeaderText = "Cikkszám";
            termekekGridView.Columns["TermekNev"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            termekekGridView.Columns["TermekNev2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            termekekGridView.Columns["Cikkszam"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            termekekGridView.Columns["Kategoria"].Visible = false;
            termekekGridView.Columns["CsomagolasiDarabszam"].Visible = false;
            termekekGridView.Columns["MinimumGyarthato"].Visible = false;
            termekekGridView.Columns["Felkesztermek"].Visible = false;
            termekekGridView.Columns["BeepuloAnyag"].Visible = false;
            termekekGridView.Columns["Aktiv"].Visible = false;
        }

        private void jovahagyBtn_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow dgvr in termekekGridView.Rows) {
                if (Convert.ToBoolean(dgvr.Cells[0].Value)) {
                    Model.Termek _termek = Model.Termek.findByID(Convert.ToInt32(dgvr.Cells["ID"].Value));
                    MunkarendTermekek _mrT = new MunkarendTermekek(0, MunkarendID, _termek.ID, _termek.MinimumGyarthato, (from x in MunkarendStatusz.getAll() where x.Sorszam==1 select x).First().Megnevezes);
                    // database.munkarendTermekAdd(MunkarendID, Convert.ToInt32(dgvr.Cells["ID"].Value), _termek.MinimumGyarthato, "Felvéve");
                    database.munkarendTermekAdd(_mrT);
                }
            }
            this.Close();
        }
    }
}
