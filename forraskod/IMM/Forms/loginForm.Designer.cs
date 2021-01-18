namespace IMM.Install
{
    partial class loginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.showPassBtn = new System.Windows.Forms.Button();
            this.loginFormServerStatusLabel = new System.Windows.Forms.Label();
            this.dbSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 99;
            this.label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(82, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 99;
            this.label2.Text = "Jelszó";
            // 
            // usernameText
            // 
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameText.Location = new System.Drawing.Point(142, 6);
            this.usernameText.MaxLength = 20;
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(153, 26);
            this.usernameText.TabIndex = 1;
            this.usernameText.Text = "admin";
            // 
            // passText
            // 
            this.passText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passText.Location = new System.Drawing.Point(142, 38);
            this.passText.MaxLength = 20;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '*';
            this.passText.Size = new System.Drawing.Size(153, 26);
            this.passText.TabIndex = 2;
            this.passText.Text = "admin";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.loginBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(0, 109);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(307, 37);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Bejelentkezés";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            this.loginBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginBtn_KeyDown);
            // 
            // showPassBtn
            // 
            this.showPassBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showPassBtn.Location = new System.Drawing.Point(0, 86);
            this.showPassBtn.Name = "showPassBtn";
            this.showPassBtn.Size = new System.Drawing.Size(307, 23);
            this.showPassBtn.TabIndex = 4;
            this.showPassBtn.Text = "Jelszó megjelenítése";
            this.showPassBtn.UseVisualStyleBackColor = true;
            this.showPassBtn.Click += new System.EventHandler(this.showPassBtn_Click);
            // 
            // loginFormServerStatusLabel
            // 
            this.loginFormServerStatusLabel.AutoSize = true;
            this.loginFormServerStatusLabel.Location = new System.Drawing.Point(12, 70);
            this.loginFormServerStatusLabel.Name = "loginFormServerStatusLabel";
            this.loginFormServerStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.loginFormServerStatusLabel.TabIndex = 6;
            // 
            // dbSet
            // 
            this.dbSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dbSet.Location = new System.Drawing.Point(12, 33);
            this.dbSet.Name = "dbSet";
            this.dbSet.Size = new System.Drawing.Size(67, 37);
            this.dbSet.TabIndex = 5;
            this.dbSet.Text = "Beállítás";
            this.dbSet.UseVisualStyleBackColor = true;
            this.dbSet.Click += new System.EventHandler(this.dbSet_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 146);
            this.Controls.Add(this.dbSet);
            this.Controls.Add(this.loginFormServerStatusLabel);
            this.Controls.Add(this.showPassBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(323, 185);
            this.MinimumSize = new System.Drawing.Size(323, 185);
            this.Name = "loginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button showPassBtn;
        private System.Windows.Forms.Label loginFormServerStatusLabel;
        private System.Windows.Forms.Button dbSet;
    }
}