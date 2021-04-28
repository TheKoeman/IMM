
namespace IMM.UControl.RaktarControl {
    partial class raktarKezelesUC {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lokacioTorlesBtn = new System.Windows.Forms.Button();
            this.lokacioHozzaadBtn = new System.Windows.Forms.Button();
            this.lokacioFrissitesBtn = new System.Windows.Forms.Button();
            this.lokaciokGrid = new System.Windows.Forms.DataGridView();
            this.selectBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lokaciokGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lokacioTorlesBtn);
            this.panel1.Controls.Add(this.lokacioHozzaadBtn);
            this.panel1.Controls.Add(this.lokacioFrissitesBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 44);
            this.panel1.TabIndex = 0;
            // 
            // lokacioTorlesBtn
            // 
            this.lokacioTorlesBtn.BackColor = System.Drawing.Color.Teal;
            this.lokacioTorlesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lokacioTorlesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lokacioTorlesBtn.ForeColor = System.Drawing.Color.White;
            this.lokacioTorlesBtn.Location = new System.Drawing.Point(191, 3);
            this.lokacioTorlesBtn.Name = "lokacioTorlesBtn";
            this.lokacioTorlesBtn.Size = new System.Drawing.Size(107, 38);
            this.lokacioTorlesBtn.TabIndex = 3;
            this.lokacioTorlesBtn.Text = "Lokáció törlés";
            this.lokacioTorlesBtn.UseVisualStyleBackColor = false;
            // 
            // lokacioHozzaadBtn
            // 
            this.lokacioHozzaadBtn.BackColor = System.Drawing.Color.Teal;
            this.lokacioHozzaadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lokacioHozzaadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lokacioHozzaadBtn.ForeColor = System.Drawing.Color.White;
            this.lokacioHozzaadBtn.Location = new System.Drawing.Point(97, 3);
            this.lokacioHozzaadBtn.Name = "lokacioHozzaadBtn";
            this.lokacioHozzaadBtn.Size = new System.Drawing.Size(88, 38);
            this.lokacioHozzaadBtn.TabIndex = 2;
            this.lokacioHozzaadBtn.Text = "Új lokáció";
            this.lokacioHozzaadBtn.UseVisualStyleBackColor = false;
            // 
            // lokacioFrissitesBtn
            // 
            this.lokacioFrissitesBtn.BackColor = System.Drawing.Color.Teal;
            this.lokacioFrissitesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lokacioFrissitesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lokacioFrissitesBtn.ForeColor = System.Drawing.Color.White;
            this.lokacioFrissitesBtn.Location = new System.Drawing.Point(3, 3);
            this.lokacioFrissitesBtn.Name = "lokacioFrissitesBtn";
            this.lokacioFrissitesBtn.Size = new System.Drawing.Size(88, 38);
            this.lokacioFrissitesBtn.TabIndex = 1;
            this.lokacioFrissitesBtn.Text = "Frissítés";
            this.lokacioFrissitesBtn.UseVisualStyleBackColor = false;
            // 
            // lokaciokGrid
            // 
            this.lokaciokGrid.AllowUserToOrderColumns = true;
            this.lokaciokGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lokaciokGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lokaciokGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lokaciokGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectBtn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lokaciokGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.lokaciokGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lokaciokGrid.Location = new System.Drawing.Point(0, 44);
            this.lokaciokGrid.MultiSelect = false;
            this.lokaciokGrid.Name = "lokaciokGrid";
            this.lokaciokGrid.ReadOnly = true;
            this.lokaciokGrid.Size = new System.Drawing.Size(922, 566);
            this.lokaciokGrid.TabIndex = 3;
            // 
            // selectBtn
            // 
            this.selectBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.selectBtn.DefaultCellStyle = dataGridViewCellStyle2;
            this.selectBtn.HeaderText = "Kiválaszt";
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.ReadOnly = true;
            this.selectBtn.Text = "Select";
            this.selectBtn.Width = 77;
            // 
            // raktarKezelesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lokaciokGrid);
            this.Controls.Add(this.panel1);
            this.Name = "raktarKezelesUC";
            this.Size = new System.Drawing.Size(922, 610);
            this.Load += new System.EventHandler(this.raktarKezelesUC_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lokaciokGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView lokaciokGrid;
        private System.Windows.Forms.DataGridViewButtonColumn selectBtn;
        private System.Windows.Forms.Button lokacioFrissitesBtn;
        private System.Windows.Forms.Button lokacioHozzaadBtn;
        private System.Windows.Forms.Button lokacioTorlesBtn;
    }
}
