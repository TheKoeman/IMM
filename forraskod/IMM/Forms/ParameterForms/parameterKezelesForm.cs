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

namespace IMM.Forms.Parameter {
    public partial class parameterKezelesForm : Form {
        private GepAllomasParameter _parameter;
        private Database database;
        public parameterKezelesForm(GepAllomasParameter parameter) {
            this._parameter = parameter;
            InitializeComponent();
        }

        private void parameterKezelesForm_Load(object sender, EventArgs e) {
            if (_parameter != null) {
                database = new Database();
                kivalasztottGepNevTextbox.Text = database.gepFindById(database.gepAllomasFindByID(_parameter.AllomasId).FirstOrDefault().GepId).FirstOrDefault().GepNev;
                parameterErtekeTextbox.Text = _parameter.ParameterErtek;
                parameterNeveTextbox.Text = _parameter.ParameterNev;
            }
        }

        private void modositasBtn_Click(object sender, EventArgs e) {
            modositas();
        }
        void modositas() {
            if (parameterErtekeTextbox.ReadOnly) {
                parameterErtekeTextbox.ReadOnly = false;
                parameterNeveTextbox.ReadOnly = false;
                mentesBtn.Visible = true;
            } else {
                parameterErtekeTextbox.ReadOnly = true;
                parameterNeveTextbox.ReadOnly = true;
                mentesBtn.Visible = false;
            }
        }
        int torles = 0;
        private void parameterTorlesBtn_Click(object sender, EventArgs e) {
            if (torles == 0) {
                parameterTorlesBtn.Text = "Paraméter törlése " + torles.ToString();
                torles++;
                MessageBox.Show("Töröli fogod a paramétert! Nyomj rá még kétszer, hogy töröld!");
            } else if (torles > 0 && torles < 3) {
                parameterTorlesBtn.Text = "Paraméter törlése " + torles.ToString();
                torles++;
            } else if (torles == 3) {

                database.gepAllomasParameterDel(_parameter);
                parameterTorlesBtn.Text = "Paraméter törlése";
                parameterErtekeTextbox.Text = "";
                parameterNeveTextbox.Text = "";
                torles = 3;
            }
           
        }

        private void mentesBtn_Click(object sender, EventArgs e) {
            GepAllomasParameter _ujParameter = new GepAllomasParameter(_parameter.GapId,_parameter.AllomasId,parameterNeveTextbox.Text,parameterErtekeTextbox.Text,DateTime.Now.ToString(),"");
            database.gepAllomasParameterModositas(_ujParameter);
            modositas();
        }
    }
}
