namespace IMM.Forms {
    partial class allomasModositasForm {
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
            this.mentesBtn = new System.Windows.Forms.Button();
            this.torlesBtn = new System.Windows.Forms.Button();
            this.modositasBtn = new System.Windows.Forms.Button();
            this.kivalasztottGepIdTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.allomasNevTextbox = new System.Windows.Forms.TextBox();
            this.allomasSzamTextbox = new System.Windows.Forms.TextBox();
            this.kivalasztottGepTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mentesBtn
            // 
            this.mentesBtn.BackColor = System.Drawing.Color.LightGreen;
            this.mentesBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mentesBtn.Enabled = false;
            this.mentesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mentesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesBtn.Location = new System.Drawing.Point(0, 219);
            this.mentesBtn.Name = "mentesBtn";
            this.mentesBtn.Size = new System.Drawing.Size(473, 44);
            this.mentesBtn.TabIndex = 0;
            this.mentesBtn.Text = "Mentés";
            this.mentesBtn.UseVisualStyleBackColor = false;
            this.mentesBtn.Visible = false;
            this.mentesBtn.Click += new System.EventHandler(this.mentesBtn_Click);
            // 
            // torlesBtn
            // 
            this.torlesBtn.BackColor = System.Drawing.Color.Firebrick;
            this.torlesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.torlesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.torlesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torlesBtn.ForeColor = System.Drawing.Color.White;
            this.torlesBtn.Location = new System.Drawing.Point(0, 0);
            this.torlesBtn.Name = "torlesBtn";
            this.torlesBtn.Size = new System.Drawing.Size(473, 43);
            this.torlesBtn.TabIndex = 1;
            this.torlesBtn.Text = "Állomás törlése";
            this.torlesBtn.UseVisualStyleBackColor = false;
            this.torlesBtn.Click += new System.EventHandler(this.torlesBtn_Click);
            // 
            // modositasBtn
            // 
            this.modositasBtn.BackColor = System.Drawing.Color.White;
            this.modositasBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.modositasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modositasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modositasBtn.Location = new System.Drawing.Point(0, 175);
            this.modositasBtn.Name = "modositasBtn";
            this.modositasBtn.Size = new System.Drawing.Size(473, 44);
            this.modositasBtn.TabIndex = 2;
            this.modositasBtn.Text = "Módosítás";
            this.modositasBtn.UseVisualStyleBackColor = false;
            this.modositasBtn.Click += new System.EventHandler(this.modositasBtn_Click);
            // 
            // kivalasztottGepIdTextbox
            // 
            this.kivalasztottGepIdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kivalasztottGepIdTextbox.Location = new System.Drawing.Point(187, 43);
            this.kivalasztottGepIdTextbox.Name = "kivalasztottGepIdTextbox";
            this.kivalasztottGepIdTextbox.ReadOnly = true;
            this.kivalasztottGepIdTextbox.Size = new System.Drawing.Size(274, 26);
            this.kivalasztottGepIdTextbox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(23, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "A kiválasztott gép id :";
            // 
            // allomasNevTextbox
            // 
            this.allomasNevTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.allomasNevTextbox.Location = new System.Drawing.Point(187, 145);
            this.allomasNevTextbox.Name = "allomasNevTextbox";
            this.allomasNevTextbox.ReadOnly = true;
            this.allomasNevTextbox.Size = new System.Drawing.Size(274, 26);
            this.allomasNevTextbox.TabIndex = 13;
            // 
            // allomasSzamTextbox
            // 
            this.allomasSzamTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.allomasSzamTextbox.Location = new System.Drawing.Point(187, 110);
            this.allomasSzamTextbox.Name = "allomasSzamTextbox";
            this.allomasSzamTextbox.ReadOnly = true;
            this.allomasSzamTextbox.Size = new System.Drawing.Size(274, 26);
            this.allomasSzamTextbox.TabIndex = 12;
            // 
            // kivalasztottGepTextbox
            // 
            this.kivalasztottGepTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kivalasztottGepTextbox.Location = new System.Drawing.Point(187, 75);
            this.kivalasztottGepTextbox.Name = "kivalasztottGepTextbox";
            this.kivalasztottGepTextbox.ReadOnly = true;
            this.kivalasztottGepTextbox.Size = new System.Drawing.Size(274, 26);
            this.kivalasztottGepTextbox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(5, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Állomás megnevezése :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(57, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Állomás száma :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(39, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "A kiválasztott gép :";
            // 
            // allomasModositasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 263);
            this.Controls.Add(this.kivalasztottGepIdTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.allomasNevTextbox);
            this.Controls.Add(this.allomasSzamTextbox);
            this.Controls.Add(this.kivalasztottGepTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modositasBtn);
            this.Controls.Add(this.torlesBtn);
            this.Controls.Add(this.mentesBtn);
            this.MaximumSize = new System.Drawing.Size(489, 302);
            this.MinimumSize = new System.Drawing.Size(489, 302);
            this.Name = "allomasModositasForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Állomás módosítása -";
            this.Load += new System.EventHandler(this.allomasModositasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mentesBtn;
        private System.Windows.Forms.Button torlesBtn;
        private System.Windows.Forms.Button modositasBtn;
        private System.Windows.Forms.TextBox kivalasztottGepIdTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox allomasNevTextbox;
        private System.Windows.Forms.TextBox allomasSzamTextbox;
        private System.Windows.Forms.TextBox kivalasztottGepTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}