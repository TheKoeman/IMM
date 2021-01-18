namespace IMM.Forms.RaktarForms {
    partial class raktarHozzaadForm {
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
            this.ellenorzoLabel = new System.Windows.Forms.Label();
            this.raktarMegnevezesTextbox = new System.Windows.Forms.TextBox();
            this.mentesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új raktár megnevezése :";
            // 
            // ellenorzoLabel
            // 
            this.ellenorzoLabel.AutoSize = true;
            this.ellenorzoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ellenorzoLabel.Location = new System.Drawing.Point(194, 44);
            this.ellenorzoLabel.Name = "ellenorzoLabel";
            this.ellenorzoLabel.Size = new System.Drawing.Size(13, 20);
            this.ellenorzoLabel.TabIndex = 1;
            this.ellenorzoLabel.Text = ".";
            // 
            // raktarMegnevezesTextbox
            // 
            this.raktarMegnevezesTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.raktarMegnevezesTextbox.Location = new System.Drawing.Point(198, 15);
            this.raktarMegnevezesTextbox.Name = "raktarMegnevezesTextbox";
            this.raktarMegnevezesTextbox.Size = new System.Drawing.Size(261, 26);
            this.raktarMegnevezesTextbox.TabIndex = 2;
            this.raktarMegnevezesTextbox.TextChanged += new System.EventHandler(this.raktarMegnevezesTextbox_TextChanged);
            // 
            // mentesBtn
            // 
            this.mentesBtn.BackColor = System.Drawing.Color.Teal;
            this.mentesBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mentesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mentesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesBtn.ForeColor = System.Drawing.Color.White;
            this.mentesBtn.Location = new System.Drawing.Point(0, 79);
            this.mentesBtn.Name = "mentesBtn";
            this.mentesBtn.Size = new System.Drawing.Size(488, 34);
            this.mentesBtn.TabIndex = 3;
            this.mentesBtn.Text = "Felvétel";
            this.mentesBtn.UseVisualStyleBackColor = false;
            this.mentesBtn.Click += new System.EventHandler(this.mentesBtn_Click);
            // 
            // raktarHozzaadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 113);
            this.Controls.Add(this.mentesBtn);
            this.Controls.Add(this.raktarMegnevezesTextbox);
            this.Controls.Add(this.ellenorzoLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "raktarHozzaadForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raktár felvétele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ellenorzoLabel;
        private System.Windows.Forms.TextBox raktarMegnevezesTextbox;
        private System.Windows.Forms.Button mentesBtn;
    }
}