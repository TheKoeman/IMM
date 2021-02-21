using IMM.Classes;
using IMM.Model;
using IMM.Model.GyartasModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IMM.Forms.GyartasForms {
    public partial class munkarendKivalasztForm : Form {
        Database database = new Database();
        Munkarend mr;
        List<MunkarendTermekek> mrt;
        private int munkarendId;
        public munkarendKivalasztForm(int mrid) {
            this.munkarendId = mrid;
            InitializeComponent();
        }

        private void munkarendKivalasztForm_Load(object sender, EventArgs e) {
            if (munkarendId >= 0) {
                mr = database.munkarendFindByID(munkarendId).First();
                mrt = (from x in MunkarendTermekek.getAll()
                      where x.MrID==munkarendId
                      select x).ToList();
                
                munAzonTextbox.Text = mr.MrAzonosito;
                megnevezesTextbox.Text = mr.MrMegnevezes;
                this.Text = "Munkarend azonosító : " + munAzonTextbox.Text.ToString() + " id: " + munkarendId.ToString();
                termekGridFeltolt();

            }
        }

        void termekGridFeltolt() {
            munkarendGyartasGridView.DataSource = (from x in MunkarendTermekek.getAll()
                                                   where x.MrID == munkarendId
                                                   select x).ToList();
            munkarendGyartasGridView.Columns["MrtID"].Visible = false;
            munkarendGyartasGridView.Columns["MrID"].HeaderText = "Munkarend ID";
            munkarendGyartasGridView.Columns["TermekID"].HeaderText = "Termék ID";
            munkarendGyartasGridView.Columns["SzuksegesDarabszam"].HeaderText = "Szükséges darabszám";
            munkarendGyartasGridView.Columns["TermekNev"].HeaderText = "Termék név";
            munkarendGyartasGridView.Columns["Statusz"].HeaderText = "Státusz";
            munkarendGyartasGridView.Columns["MunkarendMegnevezes"].Visible = false;
            munkarendGyartasGridView.Columns["MrID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            munkarendGyartasGridView.Columns["TermekID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            munkarendGyartasGridView.Columns["SzuksegesDarabszam"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            munkarendGyartasGridView.Columns["TermekNev"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            munkarendGyartasGridView.Columns["MunkarendMegnevezes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            munkarendGyartasGridView.Columns["Statusz"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            munkarendGyartasGridView.Columns["torlesColumnBtn"].DisplayIndex = 9;
            sorokSzinez();
        }

        void sorokSzinez() {
            
            foreach (DataGridViewRow dgvr in munkarendGyartasGridView.Rows) {
                if (dgvr.Cells["Statusz"].Value.ToString().Length > 1) {
                    MunkarendStatusz mrs = (from x in MunkarendStatusz.getAll()
                                            where x.Megnevezes == dgvr.Cells["Statusz"].Value.ToString()
                                            select x).First();
                    if (dgvr.Cells["Statusz"].Value.ToString() == mrs.Megnevezes) {
                        dgvr.DefaultCellStyle.BackColor = Color.FromName(mrs.Szin);
                    }
                }
            }
        }

        private void termekGyartasbaBtn_Click(object sender, EventArgs e) {
            termekGyartashozForm frm = new termekGyartashozForm(database.munkarendFindByAzonosito(munAzonTextbox.Text).First().MrId);
            frm.ShowDialog();
            termekGridFeltolt();
        }

        private void munkarendGyartasGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (munkarendGyartasGridView.Columns[e.ColumnIndex] == modositasColumnBtn) {
                MunkarendTermekek mrt = (from x in MunkarendTermekek.getAll()
                                         where x.MrtID == Convert.ToInt32(munkarendGyartasGridView.Rows[e.RowIndex].Cells["MrtID"].Value)
                                         select x).First();
                munkarendTermekModositasForm frm = new munkarendTermekModositasForm(mrt);
                frm.ShowDialog();
                termekGridFeltolt();
            } else if (munkarendGyartasGridView.Columns[e.ColumnIndex] == torlesColumnBtn) {
                MunkarendTermekek mrt = (from x in MunkarendTermekek.getAll()
                                         where x.MrtID == Convert.ToInt32(munkarendGyartasGridView.Rows[e.RowIndex].Cells["MrtID"].Value)
                                         select x).First();
                if (munkarendGyartasGridView.Rows[e.RowIndex].Cells["Statusz"].Value.ToString() != (from x in MunkarendStatusz.getAll() where x.Sorszam == 1 select x).First().Megnevezes) {
                    string a = (from x in MunkarendStatusz.getAll() where x.Sorszam == 1 select x).First().Megnevezes;
                    MessageBox.Show("Nem módosítható a gyártás ha a státusza megváltozott!\nNem [" + a + "]!", "Törlés hiba");
                } else {
                    database.munkarendTermekDel(mrt);
                }
                termekGridFeltolt();
            } else if (munkarendGyartasGridView.Columns[e.ColumnIndex] == gepListaColumn) {
                Model.Termek termek = Model.Termek.findByID(Convert.ToInt32(munkarendGyartasGridView.Rows[e.RowIndex].Cells["TermekID"].Value));
                List<GepKategoria> gepLista = (from x in GepKategoria.getAll()
                                      where x.KategoriaId == termek.KategoriaID
                                      select x).OrderBy(x => x.GepId).ToList();
                Form frm = new Form();
                frm.Size = new Size(500, 500);
                frm.Text = "A(z) " + termek.TermekNev + " termék kategóriában megadott gépek listája";
                DataGridView dgv = new DataGridView();
                frm.StartPosition = FormStartPosition.CenterScreen;
                dgv.Parent = frm;
                dgv.Dock = DockStyle.Fill;
                dgv.DataSource = gepLista;
                dgv.BackgroundColor = Color.White;
                dgv.Columns["Id"].Visible = false;
                dgv.Columns["KategoriaId"].Visible = false;
                dgv.Columns["GepId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns["GepNev"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns["GepId"].HeaderText = "Gép ID";
                dgv.Columns["GepNev"].HeaderText = "Gép név";
                dgv.Columns["KategoriaNev"].HeaderText = "Kategória név";
                frm.ShowDialog();
            }
        }
    }
}
