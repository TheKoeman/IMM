namespace IMM.Forms {
    partial class termekKategoriakForm {
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.frissitesBtn = new System.Windows.Forms.Button();
            this.ujTermekBtn = new System.Windows.Forms.Button();
            this.gyartasTervBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kategoriakTree = new System.Windows.Forms.TreeView();
            this.termekekFaNezet = new System.Windows.Forms.TreeView();
            this.adatokTabpage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.close.Location = new System.Drawing.Point(995, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 23);
            this.close.TabIndex = 5;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.frissitesBtn);
            this.flowLayoutPanel1.Controls.Add(this.ujTermekBtn);
            this.flowLayoutPanel1.Controls.Add(this.gyartasTervBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1019, 39);
            this.flowLayoutPanel1.TabIndex = 6;
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
            // ujTermekBtn
            // 
            this.ujTermekBtn.BackColor = System.Drawing.Color.Teal;
            this.ujTermekBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujTermekBtn.ForeColor = System.Drawing.Color.White;
            this.ujTermekBtn.Location = new System.Drawing.Point(114, 3);
            this.ujTermekBtn.Name = "ujTermekBtn";
            this.ujTermekBtn.Size = new System.Drawing.Size(172, 30);
            this.ujTermekBtn.TabIndex = 1;
            this.ujTermekBtn.Text = "Új kategória felvétele";
            this.ujTermekBtn.UseVisualStyleBackColor = false;
            // 
            // gyartasTervBtn
            // 
            this.gyartasTervBtn.BackColor = System.Drawing.Color.Teal;
            this.gyartasTervBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gyartasTervBtn.ForeColor = System.Drawing.Color.White;
            this.gyartasTervBtn.Location = new System.Drawing.Point(292, 3);
            this.gyartasTervBtn.Name = "gyartasTervBtn";
            this.gyartasTervBtn.Size = new System.Drawing.Size(304, 30);
            this.gyartasTervBtn.TabIndex = 2;
            this.gyartasTervBtn.Text = "Kijelölt kategória gyártási folyamatok";
            this.gyartasTervBtn.UseVisualStyleBackColor = false;
            this.gyartasTervBtn.Visible = false;
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
            this.tabControl1.Size = new System.Drawing.Size(1019, 487);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.kategoriakTree);
            this.tabPage1.Controls.Add(this.termekekFaNezet);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1011, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kategóriák lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // kategoriakTree
            // 
            this.kategoriakTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kategoriakTree.Location = new System.Drawing.Point(3, 3);
            this.kategoriakTree.Name = "kategoriakTree";
            this.kategoriakTree.Size = new System.Drawing.Size(1005, 448);
            this.kategoriakTree.TabIndex = 1;
            this.kategoriakTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.kategoriakTree_NodeMouseDoubleClick);
            // 
            // termekekFaNezet
            // 
            this.termekekFaNezet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.termekekFaNezet.Location = new System.Drawing.Point(3, 3);
            this.termekekFaNezet.Name = "termekekFaNezet";
            this.termekekFaNezet.Size = new System.Drawing.Size(1005, 448);
            this.termekekFaNezet.TabIndex = 0;
            // 
            // adatokTabpage
            // 
            this.adatokTabpage.Location = new System.Drawing.Point(4, 29);
            this.adatokTabpage.Name = "adatokTabpage";
            this.adatokTabpage.Padding = new System.Windows.Forms.Padding(3);
            this.adatokTabpage.Size = new System.Drawing.Size(1011, 454);
            this.adatokTabpage.TabIndex = 1;
            this.adatokTabpage.Text = "Adatok";
            this.adatokTabpage.UseVisualStyleBackColor = true;
            // 
            // termekKategoriakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 526);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "termekKategoriakForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termék kategóriák";
            this.Load += new System.EventHandler(this.termekKategoriakForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button frissitesBtn;
        private System.Windows.Forms.Button ujTermekBtn;
        private System.Windows.Forms.Button gyartasTervBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView termekekFaNezet;
        private System.Windows.Forms.TabPage adatokTabpage;
        private System.Windows.Forms.TreeView kategoriakTree;
    }
}