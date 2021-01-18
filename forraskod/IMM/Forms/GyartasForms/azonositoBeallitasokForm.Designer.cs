namespace IMM.Forms.GyartasForms {
    partial class azonositoBeallitasokForm {
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
            this.evszamCheck = new System.Windows.Forms.CheckBox();
            this.honapCheck = new System.Windows.Forms.CheckBox();
            this.napCheck = new System.Windows.Forms.CheckBox();
            this.egyediSorozatCheck = new System.Windows.Forms.CheckBox();
            this.betuszamCheck = new System.Windows.Forms.CheckBox();
            this.azonGenTextbox = new System.Windows.Forms.TextBox();
            this.tesztBtn = new System.Windows.Forms.Button();
            this.mentesBtn = new System.Windows.Forms.Button();
            this.egyediSorozatTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // evszamCheck
            // 
            this.evszamCheck.AutoSize = true;
            this.evszamCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.evszamCheck.Location = new System.Drawing.Point(30, 12);
            this.evszamCheck.Name = "evszamCheck";
            this.evszamCheck.Size = new System.Drawing.Size(75, 20);
            this.evszamCheck.TabIndex = 0;
            this.evszamCheck.Text = "Évszám";
            this.evszamCheck.UseVisualStyleBackColor = true;
            // 
            // honapCheck
            // 
            this.honapCheck.AutoSize = true;
            this.honapCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.honapCheck.Location = new System.Drawing.Point(30, 35);
            this.honapCheck.Name = "honapCheck";
            this.honapCheck.Size = new System.Drawing.Size(68, 20);
            this.honapCheck.TabIndex = 1;
            this.honapCheck.Text = "Hónap";
            this.honapCheck.UseVisualStyleBackColor = true;
            // 
            // napCheck
            // 
            this.napCheck.AutoSize = true;
            this.napCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napCheck.Location = new System.Drawing.Point(30, 58);
            this.napCheck.Name = "napCheck";
            this.napCheck.Size = new System.Drawing.Size(53, 20);
            this.napCheck.TabIndex = 2;
            this.napCheck.Text = "Nap";
            this.napCheck.UseVisualStyleBackColor = true;
            // 
            // egyediSorozatCheck
            // 
            this.egyediSorozatCheck.AutoSize = true;
            this.egyediSorozatCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.egyediSorozatCheck.Location = new System.Drawing.Point(30, 110);
            this.egyediSorozatCheck.Name = "egyediSorozatCheck";
            this.egyediSorozatCheck.Size = new System.Drawing.Size(117, 20);
            this.egyediSorozatCheck.TabIndex = 3;
            this.egyediSorozatCheck.Text = "Egyedi sorozat";
            this.egyediSorozatCheck.UseVisualStyleBackColor = true;
            this.egyediSorozatCheck.CheckedChanged += new System.EventHandler(this.egyediSorozatCheck_CheckedChanged);
            // 
            // betuszamCheck
            // 
            this.betuszamCheck.AutoSize = true;
            this.betuszamCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.betuszamCheck.Location = new System.Drawing.Point(30, 84);
            this.betuszamCheck.Name = "betuszamCheck";
            this.betuszamCheck.Size = new System.Drawing.Size(341, 20);
            this.betuszamCheck.TabIndex = 4;
            this.betuszamCheck.Text = "Betű + Szám ( ha ki van kapcsolva akkor csak szám!)";
            this.betuszamCheck.UseVisualStyleBackColor = true;
            // 
            // azonGenTextbox
            // 
            this.azonGenTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.azonGenTextbox.Location = new System.Drawing.Point(30, 136);
            this.azonGenTextbox.Name = "azonGenTextbox";
            this.azonGenTextbox.ReadOnly = true;
            this.azonGenTextbox.Size = new System.Drawing.Size(335, 22);
            this.azonGenTextbox.TabIndex = 5;
            // 
            // tesztBtn
            // 
            this.tesztBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tesztBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tesztBtn.Location = new System.Drawing.Point(0, 164);
            this.tesztBtn.Name = "tesztBtn";
            this.tesztBtn.Size = new System.Drawing.Size(377, 23);
            this.tesztBtn.TabIndex = 6;
            this.tesztBtn.Text = "Teszt azonosító generálás";
            this.tesztBtn.UseVisualStyleBackColor = true;
            // 
            // mentesBtn
            // 
            this.mentesBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.mentesBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mentesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mentesBtn.ForeColor = System.Drawing.Color.White;
            this.mentesBtn.Location = new System.Drawing.Point(0, 187);
            this.mentesBtn.Name = "mentesBtn";
            this.mentesBtn.Size = new System.Drawing.Size(377, 23);
            this.mentesBtn.TabIndex = 7;
            this.mentesBtn.Text = "Mentés";
            this.mentesBtn.UseVisualStyleBackColor = false;
            // 
            // egyediSorozatTextbox
            // 
            this.egyediSorozatTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.egyediSorozatTextbox.Location = new System.Drawing.Point(148, 108);
            this.egyediSorozatTextbox.Name = "egyediSorozatTextbox";
            this.egyediSorozatTextbox.Size = new System.Drawing.Size(219, 22);
            this.egyediSorozatTextbox.TabIndex = 8;
            this.egyediSorozatTextbox.Visible = false;
            // 
            // azonositoBeallitasokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 210);
            this.Controls.Add(this.egyediSorozatTextbox);
            this.Controls.Add(this.tesztBtn);
            this.Controls.Add(this.azonGenTextbox);
            this.Controls.Add(this.betuszamCheck);
            this.Controls.Add(this.egyediSorozatCheck);
            this.Controls.Add(this.napCheck);
            this.Controls.Add(this.honapCheck);
            this.Controls.Add(this.evszamCheck);
            this.Controls.Add(this.mentesBtn);
            this.MaximumSize = new System.Drawing.Size(393, 249);
            this.MinimumSize = new System.Drawing.Size(393, 249);
            this.Name = "azonositoBeallitasokForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Azonosító beállítások";
            this.Load += new System.EventHandler(this.azonositoBeallitasokForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox evszamCheck;
        private System.Windows.Forms.CheckBox honapCheck;
        private System.Windows.Forms.CheckBox napCheck;
        private System.Windows.Forms.CheckBox egyediSorozatCheck;
        private System.Windows.Forms.CheckBox betuszamCheck;
        private System.Windows.Forms.TextBox azonGenTextbox;
        private System.Windows.Forms.Button tesztBtn;
        private System.Windows.Forms.Button mentesBtn;
        private System.Windows.Forms.TextBox egyediSorozatTextbox;
    }
}