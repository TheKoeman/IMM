using IMM.Model.GyartasModel;
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
    public partial class gyartasSzuresForm : Form {
        private DataGridView _dgv;
        public gyartasSzuresForm(DataGridView dgv) {
            this._dgv = dgv;
            InitializeComponent();

        }

        private void gyartasSzuresForm_Load(object sender, EventArgs e) {

        }

        private void mrendMegnev_CheckedChanged(object sender, EventArgs e) {
            if (mrendMegnev.Checked) {
                mrendMegnevTextbox.Enabled = true;
                mrendAzonTextbox.Enabled = false;
                terNevTextbox.Enabled = false;
            }
        }

        private void terNev_CheckedChanged(object sender, EventArgs e) {
            if (terNev.Checked) {
                mrendMegnevTextbox.Enabled = false;
                mrendAzonTextbox.Enabled = false;
                terNevTextbox.Enabled = true;
            }
        }

        private void mrendAzon_CheckedChanged(object sender, EventArgs e) {
            if (mrendAzon.Checked) {
                mrendMegnevTextbox.Enabled = false;
                mrendAzonTextbox.Enabled = true;
                terNevTextbox.Enabled = false;
            }
        }

        private void szuresBtn_Click(object sender, EventArgs e) {
            if (mrendAzon.Checked) {
                Munkarend mrend = Munkarend.findByAzonosito(mrendAzonTextbox.Text);
                if (mrend != null) {
                    _dgv.DataSource = (from x in MunkarendTermekek.getAll() where x.MrID == mrend.MrId select x).ToList();
                } else {
                    MessageBox.Show("Nincs ilyen azonosító!");
                }
               
            } else if (mrendMegnev.Checked) {
                _dgv.DataSource = (from x in MunkarendTermekek.getAll() where x.MunkarendMegnevezes.Contains(mrendMegnevTextbox.Text) select x).ToList();
            } else if (terNev.Checked) {
                _dgv.DataSource = (from x in MunkarendTermekek.getAll() where x.TermekNev.Contains(terNevTextbox.Text) select x).ToList();
            }
        }

        private void szuresTorleseBtn_Click(object sender, EventArgs e) {
            _dgv.DataSource = MunkarendTermekek.getAll();
        }
    }
}
