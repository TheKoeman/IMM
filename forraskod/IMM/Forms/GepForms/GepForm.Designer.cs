namespace IMM.Forms {
    partial class GepForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.close = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gepekGridView = new System.Windows.Forms.DataGridView();
            this.selectBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.frissitesBtn = new System.Windows.Forms.Button();
            this.ujGepBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gepekGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.LightBlue;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(1133, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 23);
            this.close.TabIndex = 5;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1157, 598);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gepekGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1149, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gépek";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gepekGridView
            // 
            this.gepekGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gepekGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectBtn});
            this.gepekGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gepekGridView.Location = new System.Drawing.Point(3, 3);
            this.gepekGridView.Name = "gepekGridView";
            this.gepekGridView.Size = new System.Drawing.Size(1143, 559);
            this.gepekGridView.TabIndex = 0;
            this.gepekGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gepekGridView_CellContentClick);
            // 
            // selectBtn
            // 
            this.selectBtn.HeaderText = "Kiválaszt";
            this.selectBtn.Name = "selectBtn";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.frissitesBtn);
            this.flowLayoutPanel1.Controls.Add(this.ujGepBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1157, 39);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // frissitesBtn
            // 
            this.frissitesBtn.BackColor = System.Drawing.Color.Teal;
            this.frissitesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.frissitesBtn.ForeColor = System.Drawing.Color.White;
            this.frissitesBtn.Location = new System.Drawing.Point(3, 3);
            this.frissitesBtn.Name = "frissitesBtn";
            this.frissitesBtn.Size = new System.Drawing.Size(105, 30);
            this.frissitesBtn.TabIndex = 0;
            this.frissitesBtn.Text = "Frissítés";
            this.frissitesBtn.UseVisualStyleBackColor = false;
            this.frissitesBtn.Click += new System.EventHandler(this.frissitesBtn_Click);
            // 
            // ujGepBtn
            // 
            this.ujGepBtn.BackColor = System.Drawing.Color.Teal;
            this.ujGepBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujGepBtn.ForeColor = System.Drawing.Color.White;
            this.ujGepBtn.Location = new System.Drawing.Point(114, 3);
            this.ujGepBtn.Name = "ujGepBtn";
            this.ujGepBtn.Size = new System.Drawing.Size(172, 30);
            this.ujGepBtn.TabIndex = 1;
            this.ujGepBtn.Text = "Új gép hozzáadása";
            this.ujGepBtn.UseVisualStyleBackColor = false;
            this.ujGepBtn.Click += new System.EventHandler(this.ujGepBtn_Click);
            // 
            // GepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 637);
            this.Controls.Add(this.close);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GepForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gép kezelése";
            this.Load += new System.EventHandler(this.GepForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gepekGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button frissitesBtn;
        private System.Windows.Forms.Button ujGepBtn;
        private System.Windows.Forms.DataGridView gepekGridView;
        private System.Windows.Forms.DataGridViewButtonColumn selectBtn;
    }
}