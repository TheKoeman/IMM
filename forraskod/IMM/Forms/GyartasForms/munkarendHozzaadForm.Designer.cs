namespace IMM.Forms.GyartasForms {
    partial class munkarendHozzaadForm {
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.munAzonTextbox = new System.Windows.Forms.TextBox();
            this.ellenorzoLabel = new System.Windows.Forms.Label();
            this.munkarendGyartasGridView = new System.Windows.Forms.DataGridView();
            this.modositasColumnBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.torlesColumnBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.termekGyartasbaBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.megnevezesTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.letrehozasBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.munkarendGyartasGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(8, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Automatikus azonosító generálás";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(186, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Munkarend azonosító :";
            // 
            // munAzonTextbox
            // 
            this.munAzonTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.munAzonTextbox.Location = new System.Drawing.Point(325, 13);
            this.munAzonTextbox.Name = "munAzonTextbox";
            this.munAzonTextbox.Size = new System.Drawing.Size(176, 22);
            this.munAzonTextbox.TabIndex = 2;
            this.munAzonTextbox.TextChanged += new System.EventHandler(this.munAzonTextbox_TextChanged);
            // 
            // ellenorzoLabel
            // 
            this.ellenorzoLabel.AutoSize = true;
            this.ellenorzoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ellenorzoLabel.ForeColor = System.Drawing.Color.Red;
            this.ellenorzoLabel.Location = new System.Drawing.Point(507, 16);
            this.ellenorzoLabel.Name = "ellenorzoLabel";
            this.ellenorzoLabel.Size = new System.Drawing.Size(103, 16);
            this.ellenorzoLabel.TabIndex = 3;
            this.ellenorzoLabel.Text = "Nem megfelelő!";
            // 
            // munkarendGyartasGridView
            // 
            this.munkarendGyartasGridView.BackgroundColor = System.Drawing.Color.White;
            this.munkarendGyartasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.munkarendGyartasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modositasColumnBtn,
            this.torlesColumnBtn});
            this.munkarendGyartasGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.munkarendGyartasGridView.Location = new System.Drawing.Point(3, 55);
            this.munkarendGyartasGridView.Name = "munkarendGyartasGridView";
            this.munkarendGyartasGridView.ReadOnly = true;
            this.munkarendGyartasGridView.Size = new System.Drawing.Size(1142, 446);
            this.munkarendGyartasGridView.TabIndex = 4;
            // 
            // modositasColumnBtn
            // 
            this.modositasColumnBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.modositasColumnBtn.HeaderText = "Módosítás";
            this.modositasColumnBtn.Name = "modositasColumnBtn";
            this.modositasColumnBtn.ReadOnly = true;
            this.modositasColumnBtn.Width = 63;
            // 
            // torlesColumnBtn
            // 
            this.torlesColumnBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.torlesColumnBtn.HeaderText = "Törlés";
            this.torlesColumnBtn.Name = "torlesColumnBtn";
            this.torlesColumnBtn.ReadOnly = true;
            this.torlesColumnBtn.Width = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.munkarendGyartasGridView);
            this.groupBox1.Controls.Add(this.termekGyartasbaBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1148, 504);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // termekGyartasbaBtn
            // 
            this.termekGyartasbaBtn.BackColor = System.Drawing.Color.Teal;
            this.termekGyartasbaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.termekGyartasbaBtn.Enabled = false;
            this.termekGyartasbaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.termekGyartasbaBtn.ForeColor = System.Drawing.Color.White;
            this.termekGyartasbaBtn.Location = new System.Drawing.Point(3, 16);
            this.termekGyartasbaBtn.Name = "termekGyartasbaBtn";
            this.termekGyartasbaBtn.Size = new System.Drawing.Size(1142, 39);
            this.termekGyartasbaBtn.TabIndex = 4;
            this.termekGyartasbaBtn.Text = "Termék hozzáadása a gyártáshoz";
            this.termekGyartasbaBtn.UseVisualStyleBackColor = false;
            this.termekGyartasbaBtn.Click += new System.EventHandler(this.termekGyartasbaBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.megnevezesTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.letrehozasBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.munAzonTextbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ellenorzoLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 50);
            this.panel1.TabIndex = 6;
            // 
            // megnevezesTextbox
            // 
            this.megnevezesTextbox.Enabled = false;
            this.megnevezesTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.megnevezesTextbox.Location = new System.Drawing.Point(700, 13);
            this.megnevezesTextbox.Name = "megnevezesTextbox";
            this.megnevezesTextbox.Size = new System.Drawing.Size(217, 22);
            this.megnevezesTextbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(609, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Megnevezés :";
            // 
            // letrehozasBtn
            // 
            this.letrehozasBtn.BackColor = System.Drawing.Color.Teal;
            this.letrehozasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letrehozasBtn.ForeColor = System.Drawing.Color.White;
            this.letrehozasBtn.Location = new System.Drawing.Point(941, 5);
            this.letrehozasBtn.Name = "letrehozasBtn";
            this.letrehozasBtn.Size = new System.Drawing.Size(195, 39);
            this.letrehozasBtn.TabIndex = 5;
            this.letrehozasBtn.Text = "Munkarend létrehozása";
            this.letrehozasBtn.UseVisualStyleBackColor = false;
            this.letrehozasBtn.Visible = false;
            this.letrehozasBtn.Click += new System.EventHandler(this.letrehozasBtn_Click);
            // 
            // munkarendHozzaadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "munkarendHozzaadForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Munkarend felvétele";
            ((System.ComponentModel.ISupportInitialize)(this.munkarendGyartasGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox munAzonTextbox;
        private System.Windows.Forms.Label ellenorzoLabel;
        private System.Windows.Forms.DataGridView munkarendGyartasGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button termekGyartasbaBtn;
        private System.Windows.Forms.DataGridViewButtonColumn modositasColumnBtn;
        private System.Windows.Forms.DataGridViewButtonColumn torlesColumnBtn;
        private System.Windows.Forms.Button letrehozasBtn;
        private System.Windows.Forms.TextBox megnevezesTextbox;
        private System.Windows.Forms.Label label2;
    }
}