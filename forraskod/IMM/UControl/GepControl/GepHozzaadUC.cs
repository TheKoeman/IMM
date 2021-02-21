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
    public partial class GepHozzaadUC : UserControl {
        private DataGridView dataView;
        Database database = new Database();
        private int kategoriaid;
        public GepHozzaadUC(DataGridView dgv,int katid) {
            this.dataView = dgv;
            this.kategoriaid = katid;
            InitializeComponent();
            dataFeltolt();
        }

        void dataFeltolt() {
            List<Gep> gepLista = Gep.getAll();
            gepekGridView.DataSource = gepLista;
            gepekGridView.Columns["Id"].Visible = false;
            
            }

        void listRefresh() {
            dataView.DataSource = null;
            List<GepKategoria> szurt = (from x in GepKategoria.getAll()
                                        where x.KategoriaId == kategoriaid
                                        select x).ToList();
            dataView.DataSource = szurt;

            dataView.Columns["id"].Visible = false;
            dataView.Columns["gepid"].Visible = false;
            dataView.Columns["kategoriaid"].Visible = false;
            dataView.Columns["Gepnev"].HeaderText = "Gép név";
            dataView.Columns["Kategorianev"].Visible = false;
            dataView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }


        private void mentesBtn_Click(object sender, EventArgs e) {
            List<GepKategoria> gkat = (from x in GepKategoria.getAll()
                                       where x.KategoriaId == kategoriaid
                                       select x).ToList();

            foreach (DataGridViewRow dgvr in gepekGridView.Rows) {
                if (Convert.ToBoolean(dgvr.Cells[0].Value)) {
                    if (gkat.Count != 0) {
                        if (database.gepKatFindByIds(Convert.ToInt32(dgvr.Cells[1].Value), kategoriaid).Count != 0) {
                            MessageBox.Show(dgvr.Cells["gepnev"].Value.ToString() + " már szerepel a listában, figyelmen kívül hagytam!");
                        } else {
                            database.gepKategoriahozAdd(Convert.ToInt32(dgvr.Cells[1].Value), kategoriaid);
                        }
                    }
                }
            }
            listRefresh();
        }
    }
}
