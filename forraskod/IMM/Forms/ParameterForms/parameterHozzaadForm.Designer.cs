namespace IMM.Forms {
    partial class parameterHozzaadForm {
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
            this.parameterErtekTextbox = new System.Windows.Forms.TextBox();
            this.parameterNevTextbox = new System.Windows.Forms.TextBox();
            this.kivalasztottGepTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parameterHozzaadBtn = new System.Windows.Forms.Button();
            this.allomasNevTexbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // parameterErtekTextbox
            // 
            this.parameterErtekTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parameterErtekTextbox.Location = new System.Drawing.Point(173, 108);
            this.parameterErtekTextbox.Name = "parameterErtekTextbox";
            this.parameterErtekTextbox.Size = new System.Drawing.Size(271, 26);
            this.parameterErtekTextbox.TabIndex = 13;
            // 
            // parameterNevTextbox
            // 
            this.parameterNevTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parameterNevTextbox.Location = new System.Drawing.Point(173, 73);
            this.parameterNevTextbox.Name = "parameterNevTextbox";
            this.parameterNevTextbox.Size = new System.Drawing.Size(271, 26);
            this.parameterNevTextbox.TabIndex = 12;
            // 
            // kivalasztottGepTextbox
            // 
            this.kivalasztottGepTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kivalasztottGepTextbox.Location = new System.Drawing.Point(173, 12);
            this.kivalasztottGepTextbox.Name = "kivalasztottGepTextbox";
            this.kivalasztottGepTextbox.ReadOnly = true;
            this.kivalasztottGepTextbox.Size = new System.Drawing.Size(271, 26);
            this.kivalasztottGepTextbox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(27, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Paraméter értéke :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(38, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Paraméter neve :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "A kiválasztott gép :";
            // 
            // parameterHozzaadBtn
            // 
            this.parameterHozzaadBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.parameterHozzaadBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parameterHozzaadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parameterHozzaadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parameterHozzaadBtn.Location = new System.Drawing.Point(0, 146);
            this.parameterHozzaadBtn.Name = "parameterHozzaadBtn";
            this.parameterHozzaadBtn.Size = new System.Drawing.Size(459, 38);
            this.parameterHozzaadBtn.TabIndex = 16;
            this.parameterHozzaadBtn.Text = "Paraméter hozzáadása";
            this.parameterHozzaadBtn.UseVisualStyleBackColor = false;
            this.parameterHozzaadBtn.Click += new System.EventHandler(this.parameterHozzaadBtn_Click);
            // 
            // allomasNevTexbox
            // 
            this.allomasNevTexbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.allomasNevTexbox.Location = new System.Drawing.Point(173, 44);
            this.allomasNevTexbox.Name = "allomasNevTexbox";
            this.allomasNevTexbox.ReadOnly = true;
            this.allomasNevTexbox.Size = new System.Drawing.Size(271, 26);
            this.allomasNevTexbox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(56, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Állomás neve :";
            // 
            // parameterHozzaadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 184);
            this.Controls.Add(this.allomasNevTexbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.parameterHozzaadBtn);
            this.Controls.Add(this.parameterErtekTextbox);
            this.Controls.Add(this.parameterNevTextbox);
            this.Controls.Add(this.kivalasztottGepTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(475, 223);
            this.MinimumSize = new System.Drawing.Size(475, 223);
            this.Name = "parameterHozzaadForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paraméter hozzáadása :";
            this.Load += new System.EventHandler(this.parameterHozzaadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox parameterErtekTextbox;
        private System.Windows.Forms.TextBox parameterNevTextbox;
        private System.Windows.Forms.TextBox kivalasztottGepTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button parameterHozzaadBtn;
        private System.Windows.Forms.TextBox allomasNevTexbox;
        private System.Windows.Forms.Label label4;
    }
}