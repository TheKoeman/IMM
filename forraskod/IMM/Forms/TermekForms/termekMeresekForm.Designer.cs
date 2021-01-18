namespace IMM.Forms.TermekForms {
    partial class termekMeresekForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.termekIdTextbox = new System.Windows.Forms.TextBox();
            this.TermekNevTextbox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.meresekGridView = new System.Windows.Forms.DataGridView();
            this.hozzaadBtn = new System.Windows.Forms.Button();
            this.meresSorszamTextbox = new System.Windows.Forms.TextBox();
            this.meresMegnevezesTextbox = new System.Windows.Forms.TextBox();
            this.szuksegesMeresTextbox = new System.Windows.Forms.TextBox();
            this.elvegezniCombobox = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meresekGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termék id : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(177, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Termék név :";
            // 
            // termekIdTextbox
            // 
            this.termekIdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.termekIdTextbox.Location = new System.Drawing.Point(105, 9);
            this.termekIdTextbox.Name = "termekIdTextbox";
            this.termekIdTextbox.ReadOnly = true;
            this.termekIdTextbox.Size = new System.Drawing.Size(62, 26);
            this.termekIdTextbox.TabIndex = 2;
            // 
            // TermekNevTextbox
            // 
            this.TermekNevTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TermekNevTextbox.Location = new System.Drawing.Point(282, 9);
            this.TermekNevTextbox.Name = "TermekNevTextbox";
            this.TermekNevTextbox.ReadOnly = true;
            this.TermekNevTextbox.Size = new System.Drawing.Size(199, 26);
            this.TermekNevTextbox.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.hozzaadBtn);
            this.splitContainer1.Panel1.Controls.Add(this.elvegezniCombobox);
            this.splitContainer1.Panel1.Controls.Add(this.szuksegesMeresTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.meresMegnevezesTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.meresSorszamTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.TermekNevTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.termekIdTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.meresekGridView);
            this.splitContainer1.Size = new System.Drawing.Size(788, 600);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 5;
            // 
            // meresekGridView
            // 
            this.meresekGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meresekGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteBtn});
            this.meresekGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meresekGridView.Location = new System.Drawing.Point(0, 0);
            this.meresekGridView.Name = "meresekGridView";
            this.meresekGridView.Size = new System.Drawing.Size(788, 451);
            this.meresekGridView.TabIndex = 0;
            // 
            // hozzaadBtn
            // 
            this.hozzaadBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hozzaadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hozzaadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hozzaadBtn.Location = new System.Drawing.Point(0, 112);
            this.hozzaadBtn.Name = "hozzaadBtn";
            this.hozzaadBtn.Size = new System.Drawing.Size(788, 33);
            this.hozzaadBtn.TabIndex = 0;
            this.hozzaadBtn.Text = "Hozzáad";
            this.hozzaadBtn.UseVisualStyleBackColor = true;
            this.hozzaadBtn.Click += new System.EventHandler(this.hozzaadBtn_Click);
            // 
            // meresSorszamTextbox
            // 
            this.meresSorszamTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.meresSorszamTextbox.Location = new System.Drawing.Point(149, 74);
            this.meresSorszamTextbox.Name = "meresSorszamTextbox";
            this.meresSorszamTextbox.Size = new System.Drawing.Size(125, 26);
            this.meresSorszamTextbox.TabIndex = 0;
            // 
            // meresMegnevezesTextbox
            // 
            this.meresMegnevezesTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.meresMegnevezesTextbox.Location = new System.Drawing.Point(179, 43);
            this.meresMegnevezesTextbox.Name = "meresMegnevezesTextbox";
            this.meresMegnevezesTextbox.Size = new System.Drawing.Size(237, 26);
            this.meresMegnevezesTextbox.TabIndex = 1;
            // 
            // szuksegesMeresTextbox
            // 
            this.szuksegesMeresTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szuksegesMeresTextbox.Location = new System.Drawing.Point(595, 40);
            this.szuksegesMeresTextbox.Name = "szuksegesMeresTextbox";
            this.szuksegesMeresTextbox.Size = new System.Drawing.Size(141, 26);
            this.szuksegesMeresTextbox.TabIndex = 2;
            // 
            // elvegezniCombobox
            // 
            this.elvegezniCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.elvegezniCombobox.FormattingEnabled = true;
            this.elvegezniCombobox.Items.AddRange(new object[] {
            "Darabonként",
            "Dobozonként",
            "Gyártás elején",
            "Gyártás végén"});
            this.elvegezniCombobox.Location = new System.Drawing.Point(363, 74);
            this.elvegezniCombobox.Name = "elvegezniCombobox";
            this.elvegezniCombobox.Size = new System.Drawing.Size(139, 28);
            this.elvegezniCombobox.TabIndex = 3;
            // 
            // deleteBtn
            // 
            this.deleteBtn.HeaderText = "Törlés";
            this.deleteBtn.Name = "deleteBtn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mérés sorszáma :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mérés megnevezése :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(423, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Szükséges mérés db :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(280, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Elvégezni";
            // 
            // termekMeresekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 600);
            this.Controls.Add(this.splitContainer1);
            this.Name = "termekMeresekForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mérések";
            this.Load += new System.EventHandler(this.termekMeresekForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meresekGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox termekIdTextbox;
        private System.Windows.Forms.TextBox TermekNevTextbox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView meresekGridView;
        private System.Windows.Forms.Button hozzaadBtn;
        private System.Windows.Forms.TextBox meresSorszamTextbox;
        private System.Windows.Forms.TextBox meresMegnevezesTextbox;
        private System.Windows.Forms.TextBox szuksegesMeresTextbox;
        private System.Windows.Forms.ComboBox elvegezniCombobox;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}