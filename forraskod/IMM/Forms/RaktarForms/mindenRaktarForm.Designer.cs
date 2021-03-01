namespace IMM.Forms.RaktarForms {
    partial class mindenRaktarForm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.close = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.frissitesBtn = new System.Windows.Forms.Button();
            this.ujRaktarBtn = new System.Windows.Forms.Button();
            this.mindenRaktarGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kivalasztBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mindenRaktarGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.LightBlue;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(1804, 0);
            this.close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(36, 35);
            this.close.TabIndex = 4;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.frissitesBtn);
            this.flowLayoutPanel1.Controls.Add(this.ujRaktarBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1839, 72);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // frissitesBtn
            // 
            this.frissitesBtn.BackColor = System.Drawing.Color.Teal;
            this.frissitesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frissitesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.frissitesBtn.ForeColor = System.Drawing.Color.White;
            this.frissitesBtn.Location = new System.Drawing.Point(4, 5);
            this.frissitesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frissitesBtn.Name = "frissitesBtn";
            this.frissitesBtn.Size = new System.Drawing.Size(138, 58);
            this.frissitesBtn.TabIndex = 0;
            this.frissitesBtn.Text = "Frissítés";
            this.frissitesBtn.UseVisualStyleBackColor = false;
            // 
            // ujRaktarBtn
            // 
            this.ujRaktarBtn.BackColor = System.Drawing.Color.Teal;
            this.ujRaktarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ujRaktarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujRaktarBtn.ForeColor = System.Drawing.Color.White;
            this.ujRaktarBtn.Location = new System.Drawing.Point(150, 5);
            this.ujRaktarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ujRaktarBtn.Name = "ujRaktarBtn";
            this.ujRaktarBtn.Size = new System.Drawing.Size(216, 58);
            this.ujRaktarBtn.TabIndex = 1;
            this.ujRaktarBtn.Text = "Új raktár felvétele";
            this.ujRaktarBtn.UseVisualStyleBackColor = false;
            this.ujRaktarBtn.Click += new System.EventHandler(this.ujRaktarBtn_Click);
            // 
            // mindenRaktarGridView
            // 
            this.mindenRaktarGridView.BackgroundColor = System.Drawing.Color.White;
            this.mindenRaktarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mindenRaktarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kivalasztBtn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mindenRaktarGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.mindenRaktarGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mindenRaktarGridView.Location = new System.Drawing.Point(4, 5);
            this.mindenRaktarGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mindenRaktarGridView.Name = "mindenRaktarGridView";
            this.mindenRaktarGridView.ReadOnly = true;
            this.mindenRaktarGridView.RowHeadersWidth = 62;
            this.mindenRaktarGridView.Size = new System.Drawing.Size(1823, 834);
            this.mindenRaktarGridView.TabIndex = 10;
            this.mindenRaktarGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mindenRaktarGridView_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 72);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1839, 877);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mindenRaktarGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1831, 844);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Minden raktár";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1831, 844);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Adatok";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // kivalasztBtn
            // 
            this.kivalasztBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.kivalasztBtn.HeaderText = "Kiválaszt";
            this.kivalasztBtn.MinimumWidth = 8;
            this.kivalasztBtn.Name = "kivalasztBtn";
            this.kivalasztBtn.ReadOnly = true;
            this.kivalasztBtn.Visible = false;
            this.kivalasztBtn.Width = 77;
            // 
            // mindenRaktarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 949);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mindenRaktarForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raktárak";
            this.Load += new System.EventHandler(this.mindenRaktarForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mindenRaktarGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button frissitesBtn;
        private System.Windows.Forms.Button ujRaktarBtn;
        private System.Windows.Forms.DataGridView mindenRaktarGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewButtonColumn kivalasztBtn;
    }
}