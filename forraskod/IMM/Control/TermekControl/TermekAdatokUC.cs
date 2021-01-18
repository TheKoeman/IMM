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
using IMM.Forms.TermekForms;
using IMM.Model.RaktarModel;

namespace IMM
{
    public partial class TermekAdatokUC : UserControl
    {

        #region INTERFACE 
        Database database = new Database();
        List<Kategoria> kategoriak = new List<Kategoria>();
        List<Raktar> raktarak = new List<Raktar>();
        private DataGridView _dgv;
        private Termek _termek;
        public Termek Termek {
            get {
                _termek.TermekNev = termekNevTextbox.Text;
                _termek.TermekNev2 = termekNev2Textbox.Text;
                _termek.Cikkszam = cikkszamTextbox.Text;
                _termek.Kategoria = (from x in kategoriak where x.Id == _termek.Kategoria select x.Id).First();
                _termek.Raktar = (from x in raktarak where x.RaktarID == _termek.Raktar select x.RaktarID).First();
                return _termek;
            }
            set {
                _termek = value;
                idTextbox.Text = _termek.ID.ToString();
                termekNevTextbox.Text = _termek.TermekNev;
                termekNev2Textbox.Text = _termek.TermekNev2;
                cikkszamTextbox.Text = _termek.Cikkszam;
                kategoriaCombobox.Text = (from x in kategoriak where x.Id == _termek.Kategoria select x.KategoriaNev).First();
                raktarCombobox.Text = (from x in raktarak where x.RaktarID == _termek.Raktar select x.RaktarMegnevezes).First();
                if (_termek.Aktiv == 1) { aktivCheckbox.Checked = true; } else { aktivCheckbox.Checked = false; }
                if (_termek.Felkesztermek == 1) { felkesztermekCheckbox.Checked = true; } else { felkesztermekCheckbox.Checked = false; }
                if (_termek.BeepuloAnyag == 1) { beepuloCheckbox.Checked = true; } else { beepuloCheckbox.Checked = false; }
            }
        }
        #endregion

        public TermekAdatokUC(DataGridView dgv)
        {
            this._dgv = dgv;
            InitializeComponent();
            kategoriak = database.getAllKategoria();
            raktarak = database.getAllRaktar();
        }



        #region EVENTS
        void updateEllenoriz(Termek t) {
            try {
                database.termekModositas(t);
                _dgv.DataSource = database.getAllTermek();
                modositas();
                MessageBox.Show("Termék módosítása sikeres volt!", "Sikeres termék módosítás");
                Logger.Log("Termék adatok", "Termék módosítása sikeres:" + t.TermekNev);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Sikertelen termék módosítás!");
                Logger.Log("Termék adatok", "Termék módosítása sikertelen:" + t.TermekNev);
            }
        }
        void insertEllenoriz(Termek t) {
            if (t.TermekNev.Length != 0) {
                if (t.Cikkszam.Length != 0) {
                    if (t.MinimumGyarthato != 0) {
                        if (t.CsomagolasiDarabszam != 0) {
                            try {
                                database.termekHozzaad(t);
                                _dgv.DataSource = database.getAllTermek();
                                ujTermek();
                                MessageBox.Show("Termék hozzáadása sikeres volt!","Sikeres termék hozzáadás");
                                Logger.Log("Termék adatok", "Termék hozzáadása sikeres:" + t.TermekNev);
                            } catch (Exception ex) {
                                MessageBox.Show(ex.Message, "Sikertelen termék hozzáadás!");
                                Logger.Log("Termék adatok", "Termék hozzáadása sikertelen:" + t.TermekNev);
                            }
                            
                        } else {
                            MessageBox.Show("Kérlek állítsd be a csomagolási darabszámot!", "Termék felvétel hiba!");
                        }
                    } else {
                        MessageBox.Show("Kérlek állítsd be a minimum gyártható mennyiséget!", "Termék felvétel hiba!");
                    }
                } else {
                    MessageBox.Show("Kérlek állítsd be a termék cikkszámát!", "Termék felvétel hiba!");
                }
            } else {
                MessageBox.Show("Kérlek állítsd be a termék nevét!", "Termék felvétel hiba!");
            }
        }
        private void mentesBtn_Click(object sender, EventArgs e) {
            try {
                if (idTextbox.Text != "") {
                    Termek update = new Termek(Convert.ToInt32(idTextbox.Text), termekNevTextbox.Text, termekNev2Textbox.Text, cikkszamTextbox.Text, Convert.ToInt32(kategoriaCombobox.SelectedValue),Convert.ToInt32(csomagolasiDbTextbox.Text),Convert.ToInt32(minimumGyarthatoTextbox.Text),felkeszTermekInt,beepuloAnyagInt,Convert.ToInt32(raktarCombobox.SelectedValue),aktivInt);
                    updateEllenoriz(update);
                } else {
                    Termek insert = new Termek(0, termekNevTextbox.Text, termekNev2Textbox.Text, cikkszamTextbox.Text, Convert.ToInt32(kategoriaCombobox.SelectedValue), Convert.ToInt32(csomagolasiDbTextbox.Text), Convert.ToInt32(minimumGyarthatoTextbox.Text), felkeszTermekInt, beepuloAnyagInt, Convert.ToInt32(raktarCombobox.SelectedValue), aktivInt);
                    insertEllenoriz(insert);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void TermekAdatokUC_Load(object sender, EventArgs e) {
            kategoriaFeltolt();
            raktarFeltolt();
        }
        bool modosit = false;
        private void modositasBtn_Click(object sender, EventArgs e)
        {
            modositas();
        }
        private void gyartasiMeresekBtn_Click(object sender, EventArgs e) {
            termekMeresekForm frm = new termekMeresekForm(_termek);
            frm.ShowDialog();
        }
        void modositas() {
            if (termekNevTextbox.Enabled) {
                termekNevTextbox.Enabled = false;
                termekNev2Textbox.Enabled = false;
                cikkszamTextbox.Enabled = false;
                kategoriaCombobox.Enabled = false;
                raktarCombobox.Enabled = false;
                aktivCheckbox.Enabled = false;
                felkesztermekCheckbox.Enabled = false;
                beepuloCheckbox.Enabled = false;
                csomagolasiDbTextbox.Enabled = false;
                minimumGyarthatoTextbox.Enabled = false;
                mentesBtn.Visible = false;
                modosit = false;
            } else {
                modosit = true;
                mentesBtn.Visible = true;
                termekNevTextbox.Enabled = true;
                termekNev2Textbox.Enabled = true;
                cikkszamTextbox.Enabled = true;
                kategoriaCombobox.Enabled = true;
                raktarCombobox.Enabled = true;
                aktivCheckbox.Enabled = true;
                felkesztermekCheckbox.Enabled = true;
                beepuloCheckbox.Enabled = true;
                csomagolasiDbTextbox.Enabled = true;
                minimumGyarthatoTextbox.Enabled = true;
            }
        }
        void raktarFeltolt() {
            raktarCombobox.DataSource = database.getAllRaktar();
            raktarCombobox.DisplayMember = "RaktarMegnevezes";
            raktarCombobox.ValueMember = "RaktarID";
        }
        void kategoriaFeltolt() {
            kategoriaCombobox.DataSource = database.getAllKategoria();
            kategoriaCombobox.DisplayMember = "KategoriaNev";
            kategoriaCombobox.ValueMember = "Id";
            if (_termek != null) {
                kategoriaCombobox.SelectedValue = _termek.Kategoria;
            }
        }
        public void ujTermek() {
            idTextbox.Text = "";
            termekNevTextbox.Text = "";
            termekNev2Textbox.Text = "";
            cikkszamTextbox.Text = "";
            kategoriaCombobox.Text = "";

            termekNevTextbox.Enabled = true;
            termekNev2Textbox.Enabled = true;
            cikkszamTextbox.Enabled = true;
            kategoriaCombobox.Enabled = true;
        }
        #endregion

        #region CHECKBOX EVENT
        int felkeszTermekInt = 0; int beepuloAnyagInt = 0; int aktivInt = 1;
        private void felkesztermekCheckbox_CheckedChanged(object sender, EventArgs e) {
            if (felkesztermekCheckbox.Checked) {
                felkeszTermekInt = 1;
                if (modosit) {
                    beepuloCheckbox.Enabled = true;
                }
                beepuloCheckbox.Visible = true;
               
            } else {
                felkeszTermekInt = 0;
                beepuloCheckbox.Visible = false;
                beepuloCheckbox.Enabled = false;
            }
        }

        private void beepuloCheckbox_CheckedChanged(object sender, EventArgs e) {
            if (beepuloCheckbox.Checked) { beepuloAnyagInt = 1; } else { beepuloAnyagInt = 0; }
        }

        private void aktivCheckbox_CheckedChanged(object sender, EventArgs e) {
            if (aktivCheckbox.Checked) { aktivInt = 1; } else { aktivInt = 0; }
        }
        #endregion

        
    }
}
