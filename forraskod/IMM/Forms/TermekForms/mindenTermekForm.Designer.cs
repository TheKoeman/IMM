namespace IMM
{
    partial class mindenTermekForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.close = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.termekekGrid = new System.Windows.Forms.DataGridView();
            this.selectBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.termekTree = new System.Windows.Forms.TreeView();
            this.adatokTabpage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.frissitesBtn = new System.Windows.Forms.Button();
            this.ujTermekBtn = new System.Windows.Forms.Button();
            this.gyartasTervBtn = new System.Windows.Forms.Button();
            this.termekekSzureseBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termekekGrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.LightBlue;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(1119, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 23);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.adatokTabpage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1142, 644);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.termekekGrid);
            this.tabPage1.Controls.Add(this.termekTree);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1134, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Termékek lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // termekekGrid
            // 
            this.termekekGrid.AllowUserToOrderColumns = true;
            this.termekekGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.termekekGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.termekekGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.termekekGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectBtn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.termekekGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.termekekGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.termekekGrid.Location = new System.Drawing.Point(3, 3);
            this.termekekGrid.Name = "termekekGrid";
            this.termekekGrid.ReadOnly = true;
            this.termekekGrid.Size = new System.Drawing.Size(1128, 605);
            this.termekekGrid.TabIndex = 2;
            this.termekekGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.termekekGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // termekTree
            // 
            this.termekTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.termekTree.Location = new System.Drawing.Point(3, 3);
            this.termekTree.Name = "termekTree";
            this.termekTree.Size = new System.Drawing.Size(1128, 605);
            this.termekTree.TabIndex = 1;
            // 
            // adatokTabpage
            // 
            this.adatokTabpage.Location = new System.Drawing.Point(4, 29);
            this.adatokTabpage.Name = "adatokTabpage";
            this.adatokTabpage.Padding = new System.Windows.Forms.Padding(3);
            this.adatokTabpage.Size = new System.Drawing.Size(1134, 611);
            this.adatokTabpage.TabIndex = 1;
            this.adatokTabpage.Text = "Adatok";
            this.adatokTabpage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.frissitesBtn);
            this.flowLayoutPanel1.Controls.Add(this.ujTermekBtn);
            this.flowLayoutPanel1.Controls.Add(this.gyartasTervBtn);
            this.flowLayoutPanel1.Controls.Add(this.termekekSzureseBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1142, 39);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // frissitesBtn
            // 
            this.frissitesBtn.BackColor = System.Drawing.Color.Teal;
            this.frissitesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frissitesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.frissitesBtn.ForeColor = System.Drawing.Color.White;
            this.frissitesBtn.Location = new System.Drawing.Point(3, 3);
            this.frissitesBtn.Name = "frissitesBtn";
            this.frissitesBtn.Size = new System.Drawing.Size(105, 30);
            this.frissitesBtn.TabIndex = 0;
            this.frissitesBtn.Text = "Frissítés";
            this.frissitesBtn.UseVisualStyleBackColor = false;
            this.frissitesBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ujTermekBtn
            // 
            this.ujTermekBtn.BackColor = System.Drawing.Color.Teal;
            this.ujTermekBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ujTermekBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujTermekBtn.ForeColor = System.Drawing.Color.White;
            this.ujTermekBtn.Location = new System.Drawing.Point(114, 3);
            this.ujTermekBtn.Name = "ujTermekBtn";
            this.ujTermekBtn.Size = new System.Drawing.Size(172, 30);
            this.ujTermekBtn.TabIndex = 1;
            this.ujTermekBtn.Text = "Új termék felvétele";
            this.ujTermekBtn.UseVisualStyleBackColor = false;
            this.ujTermekBtn.Click += new System.EventHandler(this.ujTermekBtn_Click);
            // 
            // gyartasTervBtn
            // 
            this.gyartasTervBtn.BackColor = System.Drawing.Color.Teal;
            this.gyartasTervBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gyartasTervBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gyartasTervBtn.ForeColor = System.Drawing.Color.White;
            this.gyartasTervBtn.Location = new System.Drawing.Point(292, 3);
            this.gyartasTervBtn.Name = "gyartasTervBtn";
            this.gyartasTervBtn.Size = new System.Drawing.Size(304, 30);
            this.gyartasTervBtn.TabIndex = 2;
            this.gyartasTervBtn.Text = "Kijelölt termék gyártás tervezése";
            this.gyartasTervBtn.UseVisualStyleBackColor = false;
            // 
            // termekekSzureseBtn
            // 
            this.termekekSzureseBtn.BackColor = System.Drawing.Color.DarkGray;
            this.termekekSzureseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.termekekSzureseBtn.ForeColor = System.Drawing.Color.Black;
            this.termekekSzureseBtn.Location = new System.Drawing.Point(602, 3);
            this.termekekSzureseBtn.Name = "termekekSzureseBtn";
            this.termekekSzureseBtn.Size = new System.Drawing.Size(304, 30);
            this.termekekSzureseBtn.TabIndex = 4;
            this.termekekSzureseBtn.Text = "Termékek szűrése";
            this.termekekSzureseBtn.UseVisualStyleBackColor = false;
            this.termekekSzureseBtn.Click += new System.EventHandler(this.termekekSzureseBtn_Click);
            // 
            // mindenTermekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 683);
            this.Controls.Add(this.close);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mindenTermekForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minden termék";
            this.Load += new System.EventHandler(this.mindenTermekForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.termekekGrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage adatokTabpage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button frissitesBtn;
        private System.Windows.Forms.Button ujTermekBtn;
        private System.Windows.Forms.Button gyartasTervBtn;
        private System.Windows.Forms.TreeView termekTree;
        private System.Windows.Forms.DataGridView termekekGrid;
        private System.Windows.Forms.DataGridViewButtonColumn selectBtn;
        private System.Windows.Forms.Button termekekSzureseBtn;
    }
}