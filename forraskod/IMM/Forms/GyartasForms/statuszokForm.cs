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

namespace IMM.Forms.GyartasForms {
    public partial class statuszokForm : Form {

        private string oldalSzoveg;
        TabControl frmControl;
        Database database = new Database();
        public statuszokForm(TabControl tc) {
            InitializeComponent();
            frmControl = tc;
            oldalSzoveg = this.Text;
        }

        private void close_MouseLeave(object sender, EventArgs e) {
            close.BackColor = Color.LightBlue;
        }

        private void close_MouseEnter(object sender, EventArgs e) {
            close.BackColor = Color.CadetBlue;
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
