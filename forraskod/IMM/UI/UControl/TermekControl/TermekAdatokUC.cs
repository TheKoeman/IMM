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

namespace IMM.UControl
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
                _termek.KategoriaID = (from x in kategoriak where x.Id == _termek.KategoriaID select x.Id).First();
                _termek.Raktar = (from x in raktarak where x.RaktarID == _termek.Raktar select x.RaktarID).First();
                _termek.CsomagolasiDarabszam = Convert.ToInt32(csomagolasiDbTextbox.Text);
                return _termek;
            }
            set {
                _termek = value;
                idTextbox.Text = _termek.ID.ToString();
                termekNevTextbox.Text = _termek.TermekNev;
                termekNev2Textbox.Text = _termek.TermekNev2;
                cikkszamTextbox.Text = _termek.Cikkszam;
                kategoriaCombobox.Text = (from x in kategoriak where x.Id == _termek.KategoriaID select x.KategoriaNev).First();
                raktarCombobox.Text = (from x in raktarak where x.RaktarID == _termek.Raktar select x.RaktarMegnevezes).First();
                csomagolasiDbTextbox.Text = _termek.CsomagolasiDarabszam.ToString();
                if (_termek.Aktiv == 1) { aktivCheckbox.Checked = true; } else { aktivCheckbox.Checked = false; }
                }
        }
        #endregion

        public TermekAdatokUC(DataGridView dgv)
        {
            this._dgv = dgv;
            InitializeComponent();
            kategoriak = Kategoria.getAll();
            raktarak = Raktar.getAll();
        }



        #region EVENTS
        void updateEllenoriz(Termek t) {
            try {
                Model.Termek.Modosit(t);
                _dgv.DataSource = Model.Termek.getAll();
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
                                Termek.Hozzaad(t);
                                _dgv.DataSource = Model.Termek.getAll();
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
                    Termek update = new Termek(Convert.ToInt32(idTextbox.Text), termekNevTextbox.Text, termekNev2Textbox.Text, cikkszamTextbox.Text, Convert.ToInt32(kategoriaCombobox.SelectedValue),Convert.ToInt32(csomagolasiDbTextbox.Text),Convert.ToInt32(minimumGyarthatoTextbox.Text),Convert.ToInt32(raktarCombobox.SelectedValue),aktivInt);
                    updateEllenoriz(update);
                } else {
                    Termek insert = new Termek(0, termekNevTextbox.Text, termekNev2Textbox.Text, cikkszamTextbox.Text, Convert.ToInt32(kategoriaCombobox.SelectedValue), Convert.ToInt32(csomagolasiDbTextbox.Text), Convert.ToInt32(minimumGyarthatoTextbox.Text), Convert.ToInt32(raktarCombobox.SelectedValue), aktivInt);
                    insertEllenoriz(insert);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void TermekAdatokUC_Load(object sender, EventArgs e) {
            AutoScroll = false;
            HorizontalScroll.Enabled = false;
            HorizontalScroll.Visible = false;
            HorizontalScroll.Maximum = 0;
            AutoScroll = true;
            kategoriaFeltolt();
            raktarFeltolt();
        }
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
                csomagolasiDbTextbox.Enabled = false;
                minimumGyarthatoTextbox.Enabled = false;
                mentesBtn.Visible = false;
            } else {
                mentesBtn.Visible = true;
                termekNevTextbox.Enabled = true;
                termekNev2Textbox.Enabled = true;
                cikkszamTextbox.Enabled = true;
                kategoriaCombobox.Enabled = true;
                raktarCombobox.Enabled = true;
                aktivCheckbox.Enabled = true;
                csomagolasiDbTextbox.Enabled = true;
                minimumGyarthatoTextbox.Enabled = true;
            }
        }
        void raktarFeltolt() {
            raktarCombobox.DataSource = Raktar.getAll();
            raktarCombobox.DisplayMember = "RaktarMegnevezes";
            raktarCombobox.ValueMember = "RaktarID";
        }
        void kategoriaFeltolt() {
            kategoriaCombobox.DataSource = Kategoria.getAll();
            kategoriaCombobox.DisplayMember = "KategoriaNev";
            kategoriaCombobox.ValueMember = "Id";
            if (_termek != null) {
                kategoriaCombobox.SelectedValue = _termek.KategoriaID;
            }
        }
        public void ujTermek() {
            idTextbox.Text = "";
            termekNevTextbox.Text = "";
            termekNev2Textbox.Text = "";
            cikkszamTextbox.Text = "";
            kategoriaCombobox.Text = "";

            mentesBtn.Visible = true;
            mentesBtn.Enabled = true;
            termekNevTextbox.Enabled = true;
            termekNev2Textbox.Enabled = true;
            cikkszamTextbox.Enabled = true;
            kategoriaCombobox.Enabled = true;
            minimumGyarthatoTextbox.Enabled = true;
            raktarCombobox.Enabled = true;
            csomagolasiDbTextbox.Enabled = true;
        }
        #endregion

        #region CHECKBOX EVENT
        int aktivInt = 1;

        private void aktivCheckbox_CheckedChanged(object sender, EventArgs e) {
            if (aktivCheckbox.Checked) { aktivInt = 1; } else { aktivInt = 0; }
        }

        #endregion

    }
}
