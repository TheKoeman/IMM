namespace IMM.Control {
    partial class TermekKategoriakUC {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aktivCheckbox = new System.Windows.Forms.CheckBox();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kategoriaNevTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.katGepData = new System.Windows.Forms.DataGridView();
            this.selectBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listaFrissitesBtn = new System.Windows.Forms.Button();
            this.gepHozzaadBtn = new System.Windows.Forms.Button();
            this.kijeloltDelBtn = new System.Windows.Forms.Button();
            this.modositasBtn = new System.Windows.Forms.Button();
            this.mentesBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katGepData)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aktivCheckbox);
            this.groupBox1.Controls.Add(this.idTextbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.kategoriaNevTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 113);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alap adatok";
            // 
            // aktivCheckbox
            // 
            this.aktivCheckbox.AutoSize = true;
            this.aktivCheckbox.Enabled = false;
            this.aktivCheckbox.Location = new System.Drawing.Point(184, 86);
            this.aktivCheckbox.Name = "aktivCheckbox";
            this.aktivCheckbox.Size = new System.Drawing.Size(62, 24);
            this.aktivCheckbox.TabIndex = 12;
            this.aktivCheckbox.Text = "Aktív";
            this.aktivCheckbox.UseVisualStyleBackColor = true;
            // 
            // idTextbox
            // 
            this.idTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idTextbox.Location = new System.Drawing.Point(136, 22);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.ReadOnly = true;
            this.idTextbox.Size = new System.Drawing.Size(287, 26);
            this.idTextbox.TabIndex = 7;
            this.idTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(96, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID :";
            // 
            // kategoriaNevTextbox
            // 
            this.kategoriaNevTextbox.Enabled = false;
            this.kategoriaNevTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kategoriaNevTextbox.Location = new System.Drawing.Point(136, 54);
            this.kategoriaNevTextbox.Name = "kategoriaNevTextbox";
            this.kategoriaNevTextbox.Size = new System.Drawing.Size(287, 26);
            this.kategoriaNevTextbox.TabIndex = 1;
            this.kategoriaNevTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategória név :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.katGepData);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(3, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(956, 443);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategóriához tartozó gépek";
            // 
            // katGepData
            // 
            this.katGepData.BackgroundColor = System.Drawing.Color.White;
            this.katGepData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.katGepData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectBtn});
            this.katGepData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.katGepData.Location = new System.Drawing.Point(3, 59);
            this.katGepData.Name = "katGepData";
            this.katGepData.Size = new System.Drawing.Size(950, 381);
            this.katGepData.TabIndex = 0;
            this.katGepData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.katGepData_CellContentClick);
            // 
            // selectBtn
            // 
            this.selectBtn.HeaderText = "Kiválaszt";
            this.selectBtn.Name = "selectBtn";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.listaFrissitesBtn);
            this.flowLayoutPanel1.Controls.Add(this.gepHozzaadBtn);
            this.flowLayoutPanel1.Controls.Add(this.kijeloltDelBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(950, 37);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // listaFrissitesBtn
            // 
            this.listaFrissitesBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listaFrissitesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaFrissitesBtn.ForeColor = System.Drawing.Color.White;
            this.listaFrissitesBtn.Location = new System.Drawing.Point(3, 3);
            this.listaFrissitesBtn.Name = "listaFrissitesBtn";
            this.listaFrissitesBtn.Size = new System.Drawing.Size(159, 29);
            this.listaFrissitesBtn.TabIndex = 2;
            this.listaFrissitesBtn.Text = "Lista frissítése";
            this.listaFrissitesBtn.UseVisualStyleBackColor = false;
            this.listaFrissitesBtn.Click += new System.EventHandler(this.listaFrissitesBtn_Click);
            // 
            // gepHozzaadBtn
            // 
            this.gepHozzaadBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gepHozzaadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gepHozzaadBtn.ForeColor = System.Drawing.Color.White;
            this.gepHozzaadBtn.Location = new System.Drawing.Point(168, 3);
            this.gepHozzaadBtn.Name = "gepHozzaadBtn";
            this.gepHozzaadBtn.Size = new System.Drawing.Size(159, 29);
            this.gepHozzaadBtn.TabIndex = 0;
            this.gepHozzaadBtn.Text = "Gép hozzáadása";
            this.gepHozzaadBtn.UseVisualStyleBackColor = false;
            this.gepHozzaadBtn.Click += new System.EventHandler(this.gepHozzaadBtn_Click);
            // 
            // kijeloltDelBtn
            // 
            this.kijeloltDelBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.kijeloltDelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kijeloltDelBtn.ForeColor = System.Drawing.Color.White;
            this.kijeloltDelBtn.Location = new System.Drawing.Point(333, 3);
            this.kijeloltDelBtn.Name = "kijeloltDelBtn";
            this.kijeloltDelBtn.Size = new System.Drawing.Size(159, 29);
            this.kijeloltDelBtn.TabIndex = 1;
            this.kijeloltDelBtn.Text = "Kijelölt eltávolítása";
            this.kijeloltDelBtn.UseVisualStyleBackColor = false;
            this.kijeloltDelBtn.Click += new System.EventHandler(this.kijeloltDelBtn_Click);
            // 
            // modositasBtn
            // 
            this.modositasBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.modositasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modositasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modositasBtn.ForeColor = System.Drawing.Color.Black;
            this.modositasBtn.Location = new System.Drawing.Point(438, 19);
            this.modositasBtn.Name = "modositasBtn";
            this.modositasBtn.Size = new System.Drawing.Size(159, 29);
            this.modositasBtn.TabIndex = 15;
            this.modositasBtn.Text = "Módosítás";
            this.modositasBtn.UseVisualStyleBackColor = false;
            this.modositasBtn.Click += new System.EventHandler(this.modositasBtn_Click);
            // 
            // mentesBtn
            // 
            this.mentesBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.mentesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mentesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesBtn.ForeColor = System.Drawing.Color.White;
            this.mentesBtn.Location = new System.Drawing.Point(438, 71);
            this.mentesBtn.Name = "mentesBtn";
            this.mentesBtn.Size = new System.Drawing.Size(159, 29);
            this.mentesBtn.TabIndex = 16;
            this.mentesBtn.Text = "Mentés";
            this.mentesBtn.UseVisualStyleBackColor = false;
            this.mentesBtn.Visible = false;
            this.mentesBtn.Click += new System.EventHandler(this.mentesBtn_Click);
            // 
            // TermekKategoriakUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mentesBtn);
            this.Controls.Add(this.modositasBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "TermekKategoriakUC";
            this.Size = new System.Drawing.Size(962, 568);
            this.Load += new System.EventHandler(this.TermekKategoriakUC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.katGepData)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox aktivCheckbox;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kategoriaNevTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView katGepData;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button listaFrissitesBtn;
        private System.Windows.Forms.Button gepHozzaadBtn;
        private System.Windows.Forms.Button kijeloltDelBtn;
        private System.Windows.Forms.DataGridViewButtonColumn selectBtn;
        private System.Windows.Forms.Button modositasBtn;
        private System.Windows.Forms.Button mentesBtn;
    }
}
