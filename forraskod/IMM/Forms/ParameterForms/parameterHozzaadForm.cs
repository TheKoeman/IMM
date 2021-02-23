using IMM.Classes;
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
    public partial class parameterHozzaadForm : Form {
        private Database database;
        private GepAllomas _gepAllomas;
        string gepNev;
        public parameterHozzaadForm(GepAllomas gepallomas) {
            this._gepAllomas = gepallomas;
            InitializeComponent();
        }

        private void parameterHozzaadForm_Load(object sender, EventArgs e) {
            if (_gepAllomas != null) {
                database = new Database();
                gepNev = Gep.findByID(_gepAllomas.GepId).GepNev;
                allomasNevTexbox.Text = _gepAllomas.AllomasNev;
                kivalasztottGepTextbox.Text = gepNev;
                this.Text = "Paraméter hozzáadása - " + _gepAllomas.GepId + " | " + gepNev;
              
            }
        }

        private void parameterHozzaadBtn_Click(object sender, EventArgs e) {
            GepAllomasParameter.Hozzaad(new GepAllomasParameter(0, _gepAllomas.GaId, parameterNevTextbox.Text.ToString(), parameterErtekTextbox.Text.ToString(), DateTime.Now.ToString(), ""));
            parameterErtekTextbox.Text = "";
            parameterNevTextbox.Text = "";
        }
    }
}
