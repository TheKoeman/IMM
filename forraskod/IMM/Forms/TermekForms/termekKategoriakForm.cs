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
    public partial class termekKategoriakForm : Form {
        string oldalSzoveg;
        Database database;
        TabControl frmControl;
        TermekKategoriakUC terkatUC;

       void populateTreeview() {
            kategoriakTree.Nodes.Clear();
            List<Kategoria> katList = Kategoria.getAll();
            List<GepKategoria> gkLista = GepKategoria.getAll();
            try {
                foreach (var kategoria in katList) {
                    List<GepKategoria> szurtGepkategoriak = (from x in GepKategoria.getAll()
                                                             where x.KategoriaId == kategoria.Id
                                                             orderby x.GepId
                                                             select x).ToList();
                    kategoriakTree.Nodes.Add(kategoria.KategoriaNev);
                    if (szurtGepkategoriak.Count != 0) {
                        foreach (var szgepkategoria in szurtGepkategoriak) {
                            kategoriakTree.Nodes[kategoria.Id-1].Nodes.Add(szgepkategoria.GepNev);
                        }
                    } else {

                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "populateTreeError");
            }
        }

        #region EVENTS
        public termekKategoriakForm(TabControl tc) {
            InitializeComponent();
            oldalSzoveg = this.Text;
            frmControl = tc;
        }
        private void kategoriakTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            try {
                var kivalasztott = kategoriakTree.SelectedNode;
                if (kivalasztott != null) {
                    if (kivalasztott.Parent != null) {
                        Kategoria kat = new Kategoria(Convert.ToInt32(Kategoria.findByName(kivalasztott.Parent.Text).Id), kivalasztott.Parent.Text.ToString());
                        terkatUC.Kategoria = kat;
                        tabControl1.SelectedTab = adatokTabpage;
                        terkatUC.populateGridView();
                    } else {
                        Kategoria kat = new Kategoria(Convert.ToInt32(Kategoria.findByName(kivalasztott.Text).Id), kivalasztott.Text.ToString());
                        terkatUC.Kategoria = kat;
                        tabControl1.SelectedTab = adatokTabpage;
                        terkatUC.populateGridView();
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void termekKategoriakForm_Load(object sender, EventArgs e) {
            AutoSize = false;
            this.HorizontalScroll.Enabled = false;
            AutoSize = true;
            database = new Database();
            terkatUC = new TermekKategoriakUC();
            terkatUC.Parent = adatokTabpage;
            terkatUC.Dock = DockStyle.Fill;
            populateTreeview();
        }
        private void frissitesBtn_Click(object sender, EventArgs e) {
            populateTreeview();
        }
        #endregion

        #region BEZÁRÁS GOMB
        private void close_Click(object sender, EventArgs e) {
            for (int i = 0; i < frmControl.TabCount; i++) {
                if (frmControl.TabPages[i].Text == oldalSzoveg) {
                    frmControl.TabPages.RemoveAt(i);
                }
            }
        }
        private void close_MouseEnter(object sender, EventArgs e) {
            close.BackColor = Color.CadetBlue;
        }

        private void close_MouseLeave(object sender, EventArgs e) {
            close.BackColor = Color.LightBlue;
        }

        #endregion

 
    }
}
