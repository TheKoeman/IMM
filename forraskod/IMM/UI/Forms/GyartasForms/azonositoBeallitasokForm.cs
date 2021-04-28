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
    public partial class azonositoBeallitasokForm : Form {
        Database database = new Database();
        public azonositoBeallitasokForm() {
            InitializeComponent();
        }

        private void azonositoBeallitasokForm_Load(object sender, EventArgs e) {

        }

        private void egyediSorozatCheck_CheckedChanged(object sender, EventArgs e) {
            if (egyediSorozatCheck.Checked) {
                egyediSorozatTextbox.Visible = true;
            } else {
                egyediSorozatTextbox.Visible = false;
            }
        }
    }
}
