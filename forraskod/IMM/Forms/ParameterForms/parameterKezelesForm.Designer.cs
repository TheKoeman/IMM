namespace IMM.Forms.Parameter {
    partial class parameterKezelesForm {
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
            this.kivalasztottGepNevTextbox = new System.Windows.Forms.TextBox();
            this.parameterNeveTextbox = new System.Windows.Forms.TextBox();
            this.parameterErtekeTextbox = new System.Windows.Forms.TextBox();
            this.parameterTorlesBtn = new System.Windows.Forms.Button();
            this.modositasBtn = new System.Windows.Forms.Button();
            this.mentesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiválasztott gép :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paraméter neve :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(5, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paraméter értéke :";
            // 
            // kivalasztottGepNevTextbox
            // 
            this.kivalasztottGepNevTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kivalasztottGepNevTextbox.Location = new System.Drawing.Point(151, 38);
            this.kivalasztottGepNevTextbox.Name = "kivalasztottGepNevTextbox";
            this.kivalasztottGepNevTextbox.ReadOnly = true;
            this.kivalasztottGepNevTextbox.Size = new System.Drawing.Size(255, 26);
            this.kivalasztottGepNevTextbox.TabIndex = 3;
            // 
            // parameterNeveTextbox
            // 
            this.parameterNeveTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parameterNeveTextbox.Location = new System.Drawing.Point(151, 69);
            this.parameterNeveTextbox.Name = "parameterNeveTextbox";
            this.parameterNeveTextbox.ReadOnly = true;
            this.parameterNeveTextbox.Size = new System.Drawing.Size(255, 26);
            this.parameterNeveTextbox.TabIndex = 4;
            // 
            // parameterErtekeTextbox
            // 
            this.parameterErtekeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parameterErtekeTextbox.Location = new System.Drawing.Point(151, 101);
            this.parameterErtekeTextbox.Name = "parameterErtekeTextbox";
            this.parameterErtekeTextbox.ReadOnly = true;
            this.parameterErtekeTextbox.Size = new System.Drawing.Size(255, 26);
            this.parameterErtekeTextbox.TabIndex = 5;
            // 
            // parameterTorlesBtn
            // 
            this.parameterTorlesBtn.BackColor = System.Drawing.Color.IndianRed;
            this.parameterTorlesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.parameterTorlesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parameterTorlesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parameterTorlesBtn.Location = new System.Drawing.Point(0, 0);
            this.parameterTorlesBtn.Name = "parameterTorlesBtn";
            this.parameterTorlesBtn.Size = new System.Drawing.Size(422, 32);
            this.parameterTorlesBtn.TabIndex = 6;
            this.parameterTorlesBtn.Text = "Paraméter törlése";
            this.parameterTorlesBtn.UseVisualStyleBackColor = false;
            this.parameterTorlesBtn.Click += new System.EventHandler(this.parameterTorlesBtn_Click);
            // 
            // modositasBtn
            // 
            this.modositasBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.modositasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modositasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modositasBtn.Location = new System.Drawing.Point(0, 143);
            this.modositasBtn.Name = "modositasBtn";
            this.modositasBtn.Size = new System.Drawing.Size(422, 35);
            this.modositasBtn.TabIndex = 7;
            this.modositasBtn.Text = "Módosítás";
            this.modositasBtn.UseVisualStyleBackColor = true;
            this.modositasBtn.Click += new System.EventHandler(this.modositasBtn_Click);
            // 
            // mentesBtn
            // 
            this.mentesBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.mentesBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mentesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mentesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesBtn.Location = new System.Drawing.Point(0, 178);
            this.mentesBtn.Name = "mentesBtn";
            this.mentesBtn.Size = new System.Drawing.Size(422, 35);
            this.mentesBtn.TabIndex = 8;
            this.mentesBtn.Text = "Mentés";
            this.mentesBtn.UseVisualStyleBackColor = false;
            this.mentesBtn.Visible = false;
            this.mentesBtn.Click += new System.EventHandler(this.mentesBtn_Click);
            // 
            // parameterKezelesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 213);
            this.Controls.Add(this.modositasBtn);
            this.Controls.Add(this.parameterErtekeTextbox);
            this.Controls.Add(this.parameterTorlesBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.parameterNeveTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kivalasztottGepNevTextbox);
            this.Controls.Add(this.mentesBtn);
            this.MaximumSize = new System.Drawing.Size(438, 252);
            this.MinimumSize = new System.Drawing.Size(438, 252);
            this.Name = "parameterKezelesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paraméter kezelése";
            this.Load += new System.EventHandler(this.parameterKezelesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parameterErtekeTextbox;
        private System.Windows.Forms.TextBox parameterNeveTextbox;
        private System.Windows.Forms.TextBox kivalasztottGepNevTextbox;
        private System.Windows.Forms.Button mentesBtn;
        private System.Windows.Forms.Button modositasBtn;
        private System.Windows.Forms.Button parameterTorlesBtn;
    }
}