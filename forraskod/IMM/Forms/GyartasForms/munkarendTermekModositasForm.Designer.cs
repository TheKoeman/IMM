namespace IMM.Forms.GyartasForms {
    partial class munkarendTermekModositasForm {
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
            this.label5 = new System.Windows.Forms.Label();
            this.munkarendMegnevezesTextbox = new System.Windows.Forms.TextBox();
            this.termekNevTextbox = new System.Windows.Forms.TextBox();
            this.megrendeltMennyisegTextbox = new System.Windows.Forms.TextBox();
            this.dobozMennyisegTextbox = new System.Windows.Forms.TextBox();
            this.mentesBtn = new System.Windows.Forms.Button();
            this.egyDobozLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Munkarend megnevezése :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(88, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Termék neve :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(31, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Megrendelt mennyiség :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(36, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dobozok mennyisége :";
            // 
            // munkarendMegnevezesTextbox
            // 
            this.munkarendMegnevezesTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.munkarendMegnevezesTextbox.Location = new System.Drawing.Point(188, 5);
            this.munkarendMegnevezesTextbox.Name = "munkarendMegnevezesTextbox";
            this.munkarendMegnevezesTextbox.ReadOnly = true;
            this.munkarendMegnevezesTextbox.Size = new System.Drawing.Size(162, 22);
            this.munkarendMegnevezesTextbox.TabIndex = 5;
            // 
            // termekNevTextbox
            // 
            this.termekNevTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.termekNevTextbox.Location = new System.Drawing.Point(188, 33);
            this.termekNevTextbox.Name = "termekNevTextbox";
            this.termekNevTextbox.ReadOnly = true;
            this.termekNevTextbox.Size = new System.Drawing.Size(162, 22);
            this.termekNevTextbox.TabIndex = 6;
            // 
            // megrendeltMennyisegTextbox
            // 
            this.megrendeltMennyisegTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.megrendeltMennyisegTextbox.Location = new System.Drawing.Point(188, 64);
            this.megrendeltMennyisegTextbox.Name = "megrendeltMennyisegTextbox";
            this.megrendeltMennyisegTextbox.Size = new System.Drawing.Size(162, 22);
            this.megrendeltMennyisegTextbox.TabIndex = 8;
            this.megrendeltMennyisegTextbox.TextChanged += new System.EventHandler(this.megrendeltMennyisegTextbox_TextChanged);
            // 
            // dobozMennyisegTextbox
            // 
            this.dobozMennyisegTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dobozMennyisegTextbox.Location = new System.Drawing.Point(188, 92);
            this.dobozMennyisegTextbox.Name = "dobozMennyisegTextbox";
            this.dobozMennyisegTextbox.ReadOnly = true;
            this.dobozMennyisegTextbox.Size = new System.Drawing.Size(162, 22);
            this.dobozMennyisegTextbox.TabIndex = 9;
            // 
            // mentesBtn
            // 
            this.mentesBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.mentesBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mentesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mentesBtn.ForeColor = System.Drawing.Color.White;
            this.mentesBtn.Location = new System.Drawing.Point(0, 144);
            this.mentesBtn.Name = "mentesBtn";
            this.mentesBtn.Size = new System.Drawing.Size(362, 23);
            this.mentesBtn.TabIndex = 10;
            this.mentesBtn.Text = "Mentés";
            this.mentesBtn.UseVisualStyleBackColor = false;
            this.mentesBtn.Click += new System.EventHandler(this.mentesBtn_Click);
            // 
            // egyDobozLabel
            // 
            this.egyDobozLabel.AutoSize = true;
            this.egyDobozLabel.Location = new System.Drawing.Point(12, 128);
            this.egyDobozLabel.Name = "egyDobozLabel";
            this.egyDobozLabel.Size = new System.Drawing.Size(78, 13);
            this.egyDobozLabel.TabIndex = 12;
            this.egyDobozLabel.Text = "Egy dobozba : ";
            // 
            // munkarendTermekModositasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 167);
            this.Controls.Add(this.egyDobozLabel);
            this.Controls.Add(this.mentesBtn);
            this.Controls.Add(this.dobozMennyisegTextbox);
            this.Controls.Add(this.megrendeltMennyisegTextbox);
            this.Controls.Add(this.termekNevTextbox);
            this.Controls.Add(this.munkarendMegnevezesTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(378, 206);
            this.MinimumSize = new System.Drawing.Size(378, 206);
            this.Name = "munkarendTermekModositasForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módosítás";
            this.Load += new System.EventHandler(this.munkarendTermekModositasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox munkarendMegnevezesTextbox;
        private System.Windows.Forms.TextBox termekNevTextbox;
        private System.Windows.Forms.TextBox megrendeltMennyisegTextbox;
        private System.Windows.Forms.TextBox dobozMennyisegTextbox;
        private System.Windows.Forms.Button mentesBtn;
        private System.Windows.Forms.Label egyDobozLabel;
    }
}