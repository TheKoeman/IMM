using IMM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMM.Forms.RaktarForms {
    public partial class mindenLokacioForm : Form {
        Database database = new Database();
        string oldalSzoveg;
        TabControl frmControl;

        public mindenLokacioForm(TabControl tbc) {
            InitializeComponent();
            oldalSzoveg = this.Text;
            frmControl = tbc;
        }

        private void mindenLokacioForm_Load(object sender, EventArgs e) {

        }

        private void close_Click(object sender, EventArgs e) {
            for (int i = 0; i < frmControl.TabCount; i++) {
                if (frmControl.TabPages[i].Text == oldalSzoveg) {
                    frmControl.TabPages.RemoveAt(i);
                }
            }
        }
    }
}
