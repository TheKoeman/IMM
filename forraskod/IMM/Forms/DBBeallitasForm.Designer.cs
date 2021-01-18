namespace IMM
{
    partial class DBBeallitasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dbNevBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.alapertelmezettBtn = new System.Windows.Forms.Button();
            this.dbSaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbNevBox
            // 
            this.dbNevBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbNevBox.Location = new System.Drawing.Point(166, 12);
            this.dbNevBox.Name = "dbNevBox";
            this.dbNevBox.Size = new System.Drawing.Size(277, 26);
            this.dbNevBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Csatlakozási URL :";
            // 
            // alapertelmezettBtn
            // 
            this.alapertelmezettBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.alapertelmezettBtn.Location = new System.Drawing.Point(0, 88);
            this.alapertelmezettBtn.Name = "alapertelmezettBtn";
            this.alapertelmezettBtn.Size = new System.Drawing.Size(447, 22);
            this.alapertelmezettBtn.TabIndex = 4;
            this.alapertelmezettBtn.Text = "Alapértelmezett";
            this.alapertelmezettBtn.UseVisualStyleBackColor = true;
            this.alapertelmezettBtn.Click += new System.EventHandler(this.alapertelmezettBtn_Click);
            // 
            // dbSaveBtn
            // 
            this.dbSaveBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dbSaveBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dbSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbSaveBtn.ForeColor = System.Drawing.Color.White;
            this.dbSaveBtn.Location = new System.Drawing.Point(0, 40);
            this.dbSaveBtn.Name = "dbSaveBtn";
            this.dbSaveBtn.Size = new System.Drawing.Size(447, 48);
            this.dbSaveBtn.TabIndex = 5;
            this.dbSaveBtn.Text = "Mentés";
            this.dbSaveBtn.UseVisualStyleBackColor = false;
            this.dbSaveBtn.Click += new System.EventHandler(this.dbSaveBtn_Click);
            // 
            // DBBeallitasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 110);
            this.Controls.Add(this.dbSaveBtn);
            this.Controls.Add(this.alapertelmezettBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbNevBox);
            this.MaximumSize = new System.Drawing.Size(463, 149);
            this.MinimumSize = new System.Drawing.Size(463, 149);
            this.Name = "DBBeallitasForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adatbázis beállítása";
            this.Load += new System.EventHandler(this.DBBeallitasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dbNevBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button alapertelmezettBtn;
        private System.Windows.Forms.Button dbSaveBtn;
    }
}