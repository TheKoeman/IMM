using IMM.Classes;
using IMM.Model.RaktarModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMM.UControl.RaktarControl {
    public partial class raktarKezelesUC : UserControl {
        Database database = new Database();
        private DataGridView dgv;
        private List<RaktarLokacio> _rlokacio;
        public List<RaktarLokacio> Rlokacio { get => _rlokacio; set {
                _rlokacio = value;
                lokaciokGrid.DataSource = _rlokacio;
                gridFeltolt();
            }
                }
        public raktarKezelesUC(DataGridView _dgv) {
            InitializeComponent();
            this.dgv = _dgv;
        }

        void gridFeltolt() {
            lokaciokGrid.Columns["RID"].Visible = false;
            lokaciokGrid.Columns["RlID"].HeaderText = "Lokáció ID";
            lokaciokGrid.Columns["LokacioNev"].HeaderText = "Lokáció megnevezés";
            lokaciokGrid.Columns["RlID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lokaciokGrid.Columns["LokacioNev"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void raktarKezelesUC_Load(object sender, EventArgs e) {
            AutoScroll = false;
            HorizontalScroll.Enabled = false;
            HorizontalScroll.Visible = false;
            HorizontalScroll.Maximum = 0;
            AutoScroll = true;
        }
    }
}
