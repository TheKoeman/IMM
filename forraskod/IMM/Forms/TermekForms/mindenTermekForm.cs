using IMM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMM.Model;
using IMM.UControl;
using IMM.Forms.Termek;

namespace IMM
{
    public partial class mindenTermekForm : Form
    {
        string oldalSzoveg;
        TabControl frmControl;
        Database database = new Database();
        List<Termek> termekekLista;
        TermekAdatokUC tauc;
        public mindenTermekForm(TabControl tc)
        {
            InitializeComponent();
            oldalSzoveg = this.Text;
            frmControl = tc;
        }
        private void mindenTermekForm_Load(object sender, EventArgs e)
        {
            tauc = new TermekAdatokUC(termekekGrid);
            tauc.Parent = adatokTabpage;
            tauc.Dock = DockStyle.Fill;
            termekekLista = Termek.getAll();
            gridFeltolt();
            
        }

        #region BEZÁRÁS GOMB
        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.LightBlue;
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.CadetBlue;
        }

        private void close_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < frmControl.TabCount; i++) {
                if (frmControl.TabPages[i].Text == oldalSzoveg) {
                    frmControl.TabPages.RemoveAt(i);
                }
            }
        }
        #endregion

        

        void gridFeltolt()
        {
            termekekGrid.DataSource = termekekLista;
            termekekGrid.Columns["ID"].Visible = false;
            termekekGrid.Columns["kategoriaID"].Visible = false;
            termekekGrid.Columns["TermekNev"].HeaderText = "Terméknév";
            termekekGrid.Columns["TermekNev2"].HeaderText = "Terméknév 2";
            termekekGrid.Columns["Cikkszam"].HeaderText = "Cikkszám";
            termekekGrid.Columns["KategoriaID"].HeaderText = "KategóriaID";
            termekekGrid.Columns["TermekNev"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            termekekGrid.Columns["TermekNev2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            termekekGrid.Columns["Cikkszam"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            termekekGrid.Columns["KategoriaID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            termekekGrid.Columns["CsomagolasiDarabszam"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            termekekGrid.Columns["MinimumGyarthato"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            termekekGrid.Columns["CsomagolasiDarabszam"].HeaderText = "Csomagolási darabszám";
            termekekGrid.Columns["MinimumGyarthato"].HeaderText = "Minimum gyártható";
            termekekGrid.Columns["aktiv"].Visible = false;
            termekekGrid.Columns["Raktar"].Visible = false;
            termekekGrid.Columns["RaktarNev"].HeaderText = "Raktár név";
            termekekGrid.Columns["RaktarNev"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            termekekGrid.Columns["KategoriaNev"].HeaderText = "Kategória";
            termekekGrid.Columns["KategoriaNev"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        #region EVENTS
        private void button9_Click(object sender, EventArgs e) {
            if (termekekLista != null) {
                for (int i = 0; i < termekekLista.Count(); i++) {
                    MessageBox.Show(termekekLista[i].ToString());

                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    tauc.Termek = Termek.findByID(Convert.ToInt32(termekekGrid.Rows[e.RowIndex].Cells["ID"].Value));
                adatokTabpage.Text = string.Format("Adatok | {0} ", termekekGrid.Rows[e.RowIndex].Cells["TermekNev"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (termekekGrid.Columns[e.ColumnIndex] == selectBtn)
            {
                tabControl1.SelectedTab = adatokTabpage;
                adatokTabpage.Text = string.Format("Adatok | {0} ", termekekGrid.Rows[e.RowIndex].Cells["TermekNev"].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            termekekGrid.DataSource = Termek.getAll();
        }

        private void ujTermekBtn_Click(object sender, EventArgs e) {
            if (Model.RaktarModel.Raktar.getAll().Count > 0) {
                tauc.ujTermek();
                tabControl1.SelectedTab = adatokTabpage;
            } else {
                MessageBox.Show("Nincs raktár felvéve! Így nem lehet terméket felvinni!");
            }
        }
        #endregion

        private void termekekSzureseBtn_Click(object sender, EventArgs e) {
            termekSzureseForm frm = new termekSzureseForm(termekekGrid);
            frm.ShowDialog();
            Logger.Log("Minden termék", "Termékek szűrése");
        }
    }
}
