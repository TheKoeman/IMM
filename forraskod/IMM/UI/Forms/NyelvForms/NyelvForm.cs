using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMM.Forms.NyelvForms {
    public partial class NyelvForm : Form {
        private TabControl frmControl;
        private string oldalSzoveg;
        public NyelvForm(TabControl tabControl) {
            frmControl = tabControl;
            InitializeComponent();
        }

        #region BEZÁRÁS GOMB
        private void close_MouseLeave(object sender, EventArgs e) {
            close.BackColor = Color.LightBlue;
        }

        private void close_MouseEnter(object sender, EventArgs e) {
            close.BackColor = Color.CadetBlue;
        }

        private void close_Click(object sender, EventArgs e) {
            main.closeTabpage(oldalSzoveg);
        }
        #endregion

        private void NyelvForm_Load(object sender, EventArgs e) {
            oldalSzoveg = this.Text;
        }
    }
}
