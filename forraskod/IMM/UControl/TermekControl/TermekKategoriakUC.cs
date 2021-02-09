using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMM.Classes;
using IMM.Model;

namespace IMM.UControl {
    public partial class TermekKategoriakUC : UserControl {
        public TermekKategoriakUC() {
            InitializeComponent();
        }

        public void populateGridView() {
            katGepData.DataSource = null;
            List<GepKategoria> szurt = (from x in database.getAllGepKategoria()
                                   where x.KategoriaId == Convert.ToInt32(idTextbox.Text.ToString())
                                   orderby x.GepId //sorba kell rendezni, nem pedig össze-vissza
                                   select x).ToList();
            katGepData.DataSource = szurt;
            
            katGepData.Columns["id"].Visible = false;
            katGepData.Columns["gepid"].Visible = false;
            katGepData.Columns["kategoriaid"].Visible = false;
            katGepData.Columns["Gepnev"].HeaderText = "Gép név";
            katGepData.Columns["Kategorianev"].Visible = false;
            katGepData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            katGepData.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        #region INTERFACE 
        public string kategoriaNev { get { return kategoriaNevTextbox.Text; } set { kategoriaNevTextbox.Text = value; } }
        public int ID { get { return Convert.ToInt32(idTextbox.Text); } set { idTextbox.Text = value.ToString(); } }
        Database database = new Database();
        List<Kategoria> kategoriak = new List<Kategoria>();
        private Kategoria _kategoria;
        public Kategoria Kategoria {
            get {
                _kategoria.KategoriaNev = kategoriaNevTextbox.Text;
                return _kategoria;
            }
            set {
                _kategoria = value;
                idTextbox.Text = _kategoria.Id.ToString();
                kategoriaNevTextbox.Text = _kategoria.KategoriaNev;
            }
        }
        #endregion

        #region events
        private void TermekKategoriakUC_Load(object sender, EventArgs e) {
            AutoScroll = false;
            HorizontalScroll.Enabled = false;
            HorizontalScroll.Visible = false;
            HorizontalScroll.Maximum = 0;
            AutoScroll = true;
        }

        private void listaFrissitesBtn_Click(object sender, EventArgs e) {
            populateGridView();
        }

        private void katGepData_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                if (katGepData.Columns[e.ColumnIndex] == selectBtn) {
                    Form _frm = new Form();
                    
                    GepAdatok gepAdat = database.gepAdatokByGepId(Convert.ToInt32(katGepData.Rows[e.RowIndex].Cells["gepid"].Value)).FirstOrDefault();
                    GepKezelesUC gkuc = new GepKezelesUC(null, Convert.ToInt32(Convert.ToInt32(katGepData.Rows[e.RowIndex].Cells["gepid"].Value)),gepAdat);
                    _frm.StartPosition = FormStartPosition.CenterParent;
                    _frm.Size = gkuc.Size;
                    _frm.Text = katGepData.Rows[e.RowIndex].Cells["gepnev"].Value.ToString();
                    gkuc.Parent = _frm;
                    gkuc.Dock = DockStyle.Fill;
                    _frm.ShowDialog();
                }
            }
        }

        private void gepHozzaadBtn_Click(object sender, EventArgs e) {
            Form frm = new Form();
            frm.StartPosition = FormStartPosition.CenterScreen;
            GepHozzaadUC ghuc = new GepHozzaadUC(katGepData,Convert.ToInt32(idTextbox.Text));
            frm.Text = "Gép hozzáadása";
            ghuc.Parent = frm;
            frm.Size = ghuc.Size;
            ghuc.Dock = DockStyle.Fill;
            frm.ShowDialog();
        }

        private void modositasBtn_Click(object sender, EventArgs e) {
            if (!mentesBtn.Visible) {
                mentesBtn.Visible = true;
                kategoriaNevTextbox.Enabled = true;
            } else {
                mentesBtn.Visible = false;
                kategoriaNevTextbox.Enabled = false;
            }

        }

        private void mentesBtn_Click(object sender, EventArgs e) {
            database.kategoriaModositas(new Kategoria(Convert.ToInt32(idTextbox.Text), kategoriaNevTextbox.Text));
            mentesBtn.Visible = false;
            kategoriaNevTextbox.Enabled = false;
        }

        #endregion

        private void kijeloltDelBtn_Click(object sender, EventArgs e) {
            if (katGepData.SelectedCells.Count >0) {
                int rowIndex = katGepData.SelectedCells[0].RowIndex;
                DataGridViewRow dgvr = katGepData.Rows[rowIndex];
                database.gepKategoriabolDel(Convert.ToInt32(dgvr.Cells["gepid"].Value), Convert.ToInt32(idTextbox.Text));
                populateGridView();
            }
        }
    }
}
