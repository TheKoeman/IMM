namespace IMM.Forms.GyartasForms {
    partial class munkarendKivalasztForm {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.megnevezesTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.munAzonTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.munkarendGyartasGridView = new System.Windows.Forms.DataGridView();
            this.termekGyartasbaBtn = new System.Windows.Forms.Button();
            this.modositasColumnBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gepListaColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.torlesColumnBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.munkarendGyartasGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.megnevezesTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.munAzonTextbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 37);
            this.panel1.TabIndex = 7;
            // 
            // megnevezesTextbox
            // 
            this.megnevezesTextbox.Enabled = false;
            this.megnevezesTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.megnevezesTextbox.Location = new System.Drawing.Point(440, 6);
            this.megnevezesTextbox.Name = "megnevezesTextbox";
            this.megnevezesTextbox.ReadOnly = true;
            this.megnevezesTextbox.Size = new System.Drawing.Size(217, 22);
            this.megnevezesTextbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(342, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Megnevezés :";
            // 
            // munAzonTextbox
            // 
            this.munAzonTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.munAzonTextbox.Location = new System.Drawing.Point(160, 6);
            this.munAzonTextbox.Name = "munAzonTextbox";
            this.munAzonTextbox.ReadOnly = true;
            this.munAzonTextbox.Size = new System.Drawing.Size(176, 22);
            this.munAzonTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Munkarend azonosító :";
            // 
            // munkarendGyartasGridView
            // 
            this.munkarendGyartasGridView.BackgroundColor = System.Drawing.Color.White;
            this.munkarendGyartasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.munkarendGyartasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modositasColumnBtn,
            this.gepListaColumn,
            this.torlesColumnBtn});
            this.munkarendGyartasGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.munkarendGyartasGridView.Location = new System.Drawing.Point(0, 76);
            this.munkarendGyartasGridView.Name = "munkarendGyartasGridView";
            this.munkarendGyartasGridView.ReadOnly = true;
            this.munkarendGyartasGridView.Size = new System.Drawing.Size(1034, 466);
            this.munkarendGyartasGridView.TabIndex = 8;
            this.munkarendGyartasGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.munkarendGyartasGridView_CellContentClick);
            // 
            // termekGyartasbaBtn
            // 
            this.termekGyartasbaBtn.BackColor = System.Drawing.Color.Teal;
            this.termekGyartasbaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.termekGyartasbaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.termekGyartasbaBtn.ForeColor = System.Drawing.Color.White;
            this.termekGyartasbaBtn.Location = new System.Drawing.Point(0, 37);
            this.termekGyartasbaBtn.Name = "termekGyartasbaBtn";
            this.termekGyartasbaBtn.Size = new System.Drawing.Size(1034, 39);
            this.termekGyartasbaBtn.TabIndex = 9;
            this.termekGyartasbaBtn.Text = "Termék hozzáadása a gyártáshoz";
            this.termekGyartasbaBtn.UseVisualStyleBackColor = false;
            this.termekGyartasbaBtn.Click += new System.EventHandler(this.termekGyartasbaBtn_Click);
            // 
            // modositasColumnBtn
            // 
            this.modositasColumnBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.modositasColumnBtn.HeaderText = "Módosítás";
            this.modositasColumnBtn.Name = "modositasColumnBtn";
            this.modositasColumnBtn.ReadOnly = true;
            this.modositasColumnBtn.Width = 63;
            // 
            // gepListaColumn
            // 
            this.gepListaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gepListaColumn.HeaderText = "Gyártható";
            this.gepListaColumn.Name = "gepListaColumn";
            this.gepListaColumn.ReadOnly = true;
            this.gepListaColumn.Width = 59;
            // 
            // torlesColumnBtn
            // 
            this.torlesColumnBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.torlesColumnBtn.HeaderText = "Törlés";
            this.torlesColumnBtn.Name = "torlesColumnBtn";
            this.torlesColumnBtn.ReadOnly = true;
            this.torlesColumnBtn.Width = 42;
            // 
            // munkarendKivalasztForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 542);
            this.Controls.Add(this.munkarendGyartasGridView);
            this.Controls.Add(this.termekGyartasbaBtn);
            this.Controls.Add(this.panel1);
            this.Name = "munkarendKivalasztForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Munkarend :";
            this.Load += new System.EventHandler(this.munkarendKivalasztForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.munkarendGyartasGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox megnevezesTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox munAzonTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView munkarendGyartasGridView;
        private System.Windows.Forms.Button termekGyartasbaBtn;
        private System.Windows.Forms.DataGridViewButtonColumn modositasColumnBtn;
        private System.Windows.Forms.DataGridViewButtonColumn gepListaColumn;
        private System.Windows.Forms.DataGridViewButtonColumn torlesColumnBtn;
    }
}