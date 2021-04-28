using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMM
{
    public partial class DBBeallitasForm : Form
    {
        public DBBeallitasForm()
        {
            InitializeComponent();
        }

        private void alapertelmezettBtn_Click(object sender, EventArgs e)
        {
            dbNevBox.Text = "URI = file:imm.db";
        }

        private void DBBeallitasForm_Load(object sender, EventArgs e)
        {
            dbNevBox.Text = Properties.Settings.Default.dbConn;
        }

        private void dbSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.dbConn = dbNevBox.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Sikeres beállítás!");
            }
            catch(Exception hiba)
            {
                MessageBox.Show(hiba.ToString());
            }

        }
    }
}
