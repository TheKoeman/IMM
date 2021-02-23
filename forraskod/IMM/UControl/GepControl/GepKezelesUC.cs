using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMM.Model;
using IMM.Classes;
using IMM.Forms;
using IMM.Forms.Parameter;

namespace IMM.UControl {
    public partial class GepKezelesUC : UserControl {

        #region INTERFACE
        Database database = new Database();
        private int hozottId;
        private DataGridView _dgv;
        private GepAdatok _gepAdatok;

        bool betoltve = false;
        #endregion
        public GepKezelesUC(DataGridView dgv, int athozottId,GepAdatok ga) {
            //ha olyan gépet nyitunk meg ami nincs normálisan kitöltve!
            if (dgv != null) {
                this._dgv = dgv;
            }
            if (ga != null) {
                this._gepAdatok = ga;
            } else {
                MessageBox.Show("Erre a gépre nincsenek felvéve adatok! Kérlek pótold!");
            }
            this.hozottId = athozottId;
            InitializeComponent();
        }

        private void GepKezelesUC_Load(object sender, EventArgs e) {
            if (_gepAdatok != null) {
                gepIdTextbox.Text = _gepAdatok.Gepid.ToString();
                gepNevTextbox.Text = (from x in Gep.getAll()
                                      where x.Id == _gepAdatok.Gepid
                                      select x.GepNev).FirstOrDefault();
                gepMarkajaTextbox.Text = _gepAdatok.Gepmarka;
                karbantartasTextbox.Text = _gepAdatok.Karbidatum;
                ciklusidoTextbox.Text = _gepAdatok.Ciklusido;
                ismetlodesTextbox.Text = _gepAdatok.Ismetlodes;
                allomasModositasBtn.Visible = false;
                allomasModositasBtn.Visible = false;
                allomasEllenorzes(0);
                lokacioFeltoltes();
                betoltve = true;
            } else {
                gepIdTextbox.Text = hozottId.ToString();
                gepNevTextbox.Text = (from x in Gep.getAll()
                                      where x.Id == hozottId
                                      select x.GepNev).FirstOrDefault();
                allomasokComboBox.Enabled = false;
                allomasHozzaadasaBtn.Enabled = false;
                allomasModositasBtn.Enabled = false;
                lokacioFeltoltes();
            }
        }

        void allomasEllenorzes(int selectedV) {
            try {
                if (GepAllomas.findByGepID(_gepAdatok.GaId).Count > 0) {
                    allomasokComboBox.DataSource = GepAllomas.findByGepID(_gepAdatok.GaId);
                    allomasokComboBox.DisplayMember = "AllomasMegnevezes";
                    allomasokComboBox.ValueMember = "GaId";
                    allomasokComboBox.Text = "";
                    allomasokComboBox.SelectedValue = selectedV;
                } else {
                    allomasokComboBox.Text = "Nincsenek állomások!";
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Állomás ellenőrzése hiba!");
            }
        }
        void lokacioFeltoltes() {
            try {
                if (_gepAdatok != null) {
                    if (_gepAdatok.Lokacio != 0) {
                        var lokacioNev = (from x in Lokacio.getAll()
                                          where x.LokId == _gepAdatok.Lokacio
                                          select x.LokNev).FirstOrDefault();

                        gepLokaciojaTextbox.DataSource = Lokacio.getAll();
                        gepLokaciojaTextbox.DisplayMember = "LokNev";
                        gepLokaciojaTextbox.ValueMember = "LokId";
                        gepLokaciojaTextbox.Text = (from x in Lokacio.getAll()
                                                    where x.LokId == _gepAdatok.Lokacio
                                                    select x.LokNev).FirstOrDefault();
                        gepLokaciojaTextbox.SelectedValue = (from x in Lokacio.getAll()
                                                             where x.LokId == _gepAdatok.Lokacio
                                                             select x.LokId).FirstOrDefault();
                    }
                } else {
                    gepLokaciojaTextbox.DataSource = Lokacio.getAll();
                    gepLokaciojaTextbox.DisplayMember = "LokNev";
                    gepLokaciojaTextbox.ValueMember = "LokId";
                    gepLokaciojaTextbox.Text = "";
                    gepLokaciojaTextbox.SelectedValue = "";
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Lokáció feltöltés hiba!");
            }
        }

        private void lepesekComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (betoltve) {
                parameterBetoltes();
            }
        }
        void parameterBetoltes() {
            ujParameterBtn.Visible = true;
            allomasModositasBtn.Visible = true;
            allomasModositasBtn.Visible = true;
            allomasParameterGrid.DataSource = GepAllomasParameter.findByAllomasID(Convert.ToInt32(allomasokComboBox.SelectedValue));
            allomasParameterGrid.Columns[0].Visible = true;
            allomasParameterGrid.Columns[1].Visible = false;
            allomasParameterGrid.Columns[1].ReadOnly = true;
            allomasParameterGrid.Columns[3].ReadOnly = true;
            allomasParameterGrid.Columns[4].ReadOnly = true;
            allomasParameterGrid.Columns[2].Visible = false;
            allomasParameterGrid.Columns[2].ReadOnly = true;

            allomasParameterGrid.Columns[3].HeaderText = "Paraméter megnevezése"; //parameternev
            allomasParameterGrid.Columns[4].HeaderText = "Paraméter értéke"; //parameterertek
            allomasParameterGrid.Columns[5].HeaderText = "Módosítás dátuma"; //modositasdatuma
            allomasParameterGrid.Columns[5].ReadOnly = true;
            allomasParameterGrid.Columns[6].HeaderText = "Módosította";//modositotta
            allomasParameterGrid.Columns[6].ReadOnly = true;

            //gaid Convert.ToInt32(lepesekComboBox.SelectedValue)
        }
        private void allomasHozzaadasaBtn_Click(object sender, EventArgs e) {
            int valasztottId = Convert.ToInt32(allomasokComboBox.SelectedValue);
            allomasHozzaadForm frm = new allomasHozzaadForm(new Gep(Convert.ToInt32(gepIdTextbox.Text), gepNevTextbox.Text));
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            allomasEllenorzes(valasztottId);
        }

        private void allomasModositasBtn_Click(object sender, EventArgs e) {

           allomasModositasForm frm = new allomasModositasForm(GepAllomas.findByID(Convert.ToInt32(allomasokComboBox.SelectedValue)).FirstOrDefault());
            frm.ShowDialog();
            allomasEllenorzes(Convert.ToInt32(allomasokComboBox.SelectedValue));
        }

        private void ujParameterBtn_Click(object sender, EventArgs e) {
            parameterHozzaadForm frm = new parameterHozzaadForm(GepAllomas.findByID(Convert.ToInt32(allomasokComboBox.SelectedValue)).FirstOrDefault());
            frm.ShowDialog();
            parameterBetoltes();
        }

        private void allomasParameterGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                if (allomasParameterGrid.Columns[e.ColumnIndex] == SelectBtn) {
                    parameterKezelesForm frm = new parameterKezelesForm(GepAllomasParameter.findByID(Convert.ToInt32(allomasParameterGrid.Rows[e.RowIndex].Cells["GapId"].Value)).FirstOrDefault());
                    frm.ShowDialog();
                    parameterBetoltes();
                } 
            }
        }

        void modositas() {
            if (gepNevTextbox.Enabled) {
                gepNevTextbox.Enabled = false;
                gepMarkajaTextbox.Enabled = false;
                ciklusidoTextbox.Enabled = false;
                karbantartasTextbox.Enabled = false;
                ismetlodesTextbox.Enabled = false;
                gepLokaciojaTextbox.Enabled = false;
                mentesBtn.Visible = false;
            } else {
                mentesBtn.Visible = true;
                gepNevTextbox.Enabled = true;
                gepMarkajaTextbox.Enabled = true;
                ciklusidoTextbox.Enabled = true;
                karbantartasTextbox.Enabled = true;
                ismetlodesTextbox.Enabled = true;
                gepLokaciojaTextbox.Enabled = true;
            }
        }

        private void modositasBtn_Click(object sender, EventArgs e) {
            modositas();
        }

        private void mentesBtn_Click(object sender, EventArgs e) {
            if (gepNevTextbox.Text == "" || gepLokaciojaTextbox.Text == "" || gepMarkajaTextbox.Text == "" || karbantartasTextbox.Text == "" || ciklusidoTextbox.Text == "") {
                MessageBox.Show("Kérlek minden adatot tölts ki!");
            } else {
                if (_gepAdatok != null) {
                    try {
                        Gep gep = new Gep(_gepAdatok.Gepid, gepNevTextbox.Text);
                        Gep.Modosit(gep);
                        GepAdatok gepadat = new GepAdatok(_gepAdatok.GaId, gep.Id, Convert.ToInt32(gepLokaciojaTextbox.SelectedValue), gepMarkajaTextbox.Text, ciklusidoTextbox.Text, karbantartasTextbox.Text, ismetlodesTextbox.SelectedItem.ToString());
                        GepAdatok.Modosit(gepadat);
                        if (_dgv != null) {
                            _dgv.DataSource = Gep.getAll();
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Mentés error!");
                    }
                } else {
                    try {
                        Gep gep = new Gep(hozottId, gepNevTextbox.Text);
                        Gep.Hozzaad(gep);
                        GepAdatok gepadat = new GepAdatok(0, hozottId, Convert.ToInt32(gepLokaciojaTextbox.SelectedValue), gepMarkajaTextbox.Text, ciklusidoTextbox.Text, karbantartasTextbox.Text, ismetlodesTextbox.SelectedItem.ToString());
                        GepAdatok.Hozzaad(gepadat);
                        if (_dgv != null) {
                            _dgv.DataSource = Gep.getAll();
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Mentés error!");
                    }
                }
            }
                modositas();
            
        }
    }
}
