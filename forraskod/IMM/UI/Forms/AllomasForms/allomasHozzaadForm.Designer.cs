namespace IMM.Forms {
    partial class allomasHozzaadForm {
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
            this.label3 = new System.Windows.Forms.Label();
            this.kivalasztottGepTextbox = new System.Windows.Forms.TextBox();
            this.allomasSzamTextbox = new System.Windows.Forms.TextBox();
            this.allomasNevTextbox = new System.Windows.Forms.TextBox();
            this.kivalasztottGepIdTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.allomasHozzaadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A kiválasztott gép :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(73, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Állomás száma :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Állomás megnevezése :";
            // 
            // kivalasztottGepTextbox
            // 
            this.kivalasztottGepTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kivalasztottGepTextbox.Location = new System.Drawing.Point(203, 36);
            this.kivalasztottGepTextbox.Name = "kivalasztottGepTextbox";
            this.kivalasztottGepTextbox.ReadOnly = true;
            this.kivalasztottGepTextbox.Size = new System.Drawing.Size(258, 26);
            this.kivalasztottGepTextbox.TabIndex = 3;
            // 
            // allomasSzamTextbox
            // 
            this.allomasSzamTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.allomasSzamTextbox.Location = new System.Drawing.Point(203, 71);
            this.allomasSzamTextbox.Name = "allomasSzamTextbox";
            this.allomasSzamTextbox.Size = new System.Drawing.Size(258, 26);
            this.allomasSzamTextbox.TabIndex = 4;
            // 
            // allomasNevTextbox
            // 
            this.allomasNevTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.allomasNevTextbox.Location = new System.Drawing.Point(203, 106);
            this.allomasNevTextbox.Name = "allomasNevTextbox";
            this.allomasNevTextbox.Size = new System.Drawing.Size(258, 26);
            this.allomasNevTextbox.TabIndex = 5;
            // 
            // kivalasztottGepIdTextbox
            // 
            this.kivalasztottGepIdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kivalasztottGepIdTextbox.Location = new System.Drawing.Point(203, 4);
            this.kivalasztottGepIdTextbox.Name = "kivalasztottGepIdTextbox";
            this.kivalasztottGepIdTextbox.ReadOnly = true;
            this.kivalasztottGepIdTextbox.Size = new System.Drawing.Size(258, 26);
            this.kivalasztottGepIdTextbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(39, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "A kiválasztott gép id :";
            // 
            // allomasHozzaadBtn
            // 
            this.allomasHozzaadBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.allomasHozzaadBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.allomasHozzaadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allomasHozzaadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.allomasHozzaadBtn.Location = new System.Drawing.Point(0, 144);
            this.allomasHozzaadBtn.Name = "allomasHozzaadBtn";
            this.allomasHozzaadBtn.Size = new System.Drawing.Size(473, 38);
            this.allomasHozzaadBtn.TabIndex = 8;
            this.allomasHozzaadBtn.Text = "Állomás hozzáadása";
            this.allomasHozzaadBtn.UseVisualStyleBackColor = false;
            this.allomasHozzaadBtn.Click += new System.EventHandler(this.allomasHozzaadBtn_Click);
            // 
            // allomasHozzaadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 182);
            this.Controls.Add(this.allomasHozzaadBtn);
            this.Controls.Add(this.kivalasztottGepIdTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.allomasNevTextbox);
            this.Controls.Add(this.allomasSzamTextbox);
            this.Controls.Add(this.kivalasztottGepTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(489, 221);
            this.MinimumSize = new System.Drawing.Size(489, 221);
            this.Name = "allomasHozzaadForm";
            this.ShowIcon = false;
            this.Text = "Állomás hozzáadása -";
            this.Load += new System.EventHandler(this.allomasHozzaad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kivalasztottGepTextbox;
        private System.Windows.Forms.TextBox allomasSzamTextbox;
        private System.Windows.Forms.TextBox allomasNevTextbox;
        private System.Windows.Forms.TextBox kivalasztottGepIdTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button allomasHozzaadBtn;
    }
}