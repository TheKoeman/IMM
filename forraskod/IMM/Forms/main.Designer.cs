namespace IMM
{
    partial class main
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
            this.bottomMenu = new System.Windows.Forms.MenuStrip();
            this.bottomMenuUNBox = new System.Windows.Forms.ToolStripTextBox();
            this.bottomMenuRoleBox = new System.Windows.Forms.ToolStripTextBox();
            this.bottomMenuLoggerTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.anyagokBtn = new System.Windows.Forms.Button();
            this.termekKategoriakBtn = new System.Windows.Forms.Button();
            this.mindenTermekBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.anyagRaktarozasBtn = new System.Windows.Forms.Button();
            this.raktarBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.statuszokBtn = new System.Windows.Forms.Button();
            this.azonGeneralBtn = new System.Windows.Forms.Button();
            this.mindenGyartasBtn = new System.Windows.Forms.Button();
            this.munkarendekBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.gepekBtn = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.felhasznaloKezelesBtn = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.vevoKezelesBtn = new System.Windows.Forms.Button();
            this.bottomMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomMenu
            // 
            this.bottomMenu.BackColor = System.Drawing.Color.White;
            this.bottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bottomMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bottomMenuUNBox,
            this.bottomMenuRoleBox,
            this.bottomMenuLoggerTextbox});
            this.bottomMenu.Location = new System.Drawing.Point(0, 470);
            this.bottomMenu.Name = "bottomMenu";
            this.bottomMenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.bottomMenu.Size = new System.Drawing.Size(963, 25);
            this.bottomMenu.TabIndex = 1;
            this.bottomMenu.Text = "menuStrip1";
            // 
            // bottomMenuUNBox
            // 
            this.bottomMenuUNBox.BackColor = System.Drawing.Color.White;
            this.bottomMenuUNBox.Name = "bottomMenuUNBox";
            this.bottomMenuUNBox.ReadOnly = true;
            this.bottomMenuUNBox.Size = new System.Drawing.Size(200, 23);
            // 
            // bottomMenuRoleBox
            // 
            this.bottomMenuRoleBox.BackColor = System.Drawing.Color.White;
            this.bottomMenuRoleBox.Name = "bottomMenuRoleBox";
            this.bottomMenuRoleBox.ReadOnly = true;
            this.bottomMenuRoleBox.Size = new System.Drawing.Size(200, 23);
            // 
            // bottomMenuLoggerTextbox
            // 
            this.bottomMenuLoggerTextbox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bottomMenuLoggerTextbox.BackColor = System.Drawing.Color.White;
            this.bottomMenuLoggerTextbox.ForeColor = System.Drawing.Color.Black;
            this.bottomMenuLoggerTextbox.Name = "bottomMenuLoggerTextbox";
            this.bottomMenuLoggerTextbox.ReadOnly = true;
            this.bottomMenuLoggerTextbox.Size = new System.Drawing.Size(100, 23);
            this.bottomMenuLoggerTextbox.Text = "Logger";
            this.bottomMenuLoggerTextbox.Click += new System.EventHandler(this.bottomMenuLoggerTextbox_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MaximumSize = new System.Drawing.Size(0, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 76);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.anyagokBtn);
            this.tabPage1.Controls.Add(this.termekKategoriakBtn);
            this.tabPage1.Controls.Add(this.mindenTermekBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(955, 50);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Termékek & Anyagok";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // anyagokBtn
            // 
            this.anyagokBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.anyagokBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anyagokBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.anyagokBtn.ForeColor = System.Drawing.Color.White;
            this.anyagokBtn.Location = new System.Drawing.Point(331, 3);
            this.anyagokBtn.Name = "anyagokBtn";
            this.anyagokBtn.Size = new System.Drawing.Size(180, 41);
            this.anyagokBtn.TabIndex = 2;
            this.anyagokBtn.Text = "Anyagok";
            this.anyagokBtn.UseVisualStyleBackColor = false;
            // 
            // termekKategoriakBtn
            // 
            this.termekKategoriakBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.termekKategoriakBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.termekKategoriakBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.termekKategoriakBtn.ForeColor = System.Drawing.Color.White;
            this.termekKategoriakBtn.Location = new System.Drawing.Point(145, 3);
            this.termekKategoriakBtn.Name = "termekKategoriakBtn";
            this.termekKategoriakBtn.Size = new System.Drawing.Size(180, 41);
            this.termekKategoriakBtn.TabIndex = 1;
            this.termekKategoriakBtn.Text = "Termék kategóriák";
            this.termekKategoriakBtn.UseVisualStyleBackColor = false;
            this.termekKategoriakBtn.Click += new System.EventHandler(this.termekKategoriakBtn_Click);
            // 
            // mindenTermekBtn
            // 
            this.mindenTermekBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mindenTermekBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mindenTermekBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mindenTermekBtn.ForeColor = System.Drawing.Color.White;
            this.mindenTermekBtn.Location = new System.Drawing.Point(5, 3);
            this.mindenTermekBtn.Name = "mindenTermekBtn";
            this.mindenTermekBtn.Size = new System.Drawing.Size(134, 41);
            this.mindenTermekBtn.TabIndex = 0;
            this.mindenTermekBtn.Text = "Minden termék";
            this.mindenTermekBtn.UseVisualStyleBackColor = false;
            this.mindenTermekBtn.Click += new System.EventHandler(this.mindenTermekBtn_Click);
            this.mindenTermekBtn.Resize += new System.EventHandler(this.mindenTermekBtn_Resize);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.anyagRaktarozasBtn);
            this.tabPage2.Controls.Add(this.raktarBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(955, 50);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Raktár & Lokáció";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // anyagRaktarozasBtn
            // 
            this.anyagRaktarozasBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.anyagRaktarozasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anyagRaktarozasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.anyagRaktarozasBtn.ForeColor = System.Drawing.Color.White;
            this.anyagRaktarozasBtn.Location = new System.Drawing.Point(232, 3);
            this.anyagRaktarozasBtn.Name = "anyagRaktarozasBtn";
            this.anyagRaktarozasBtn.Size = new System.Drawing.Size(155, 41);
            this.anyagRaktarozasBtn.TabIndex = 3;
            this.anyagRaktarozasBtn.Text = "Leltár";
            this.anyagRaktarozasBtn.UseVisualStyleBackColor = false;
            // 
            // raktarBtn
            // 
            this.raktarBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.raktarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raktarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.raktarBtn.ForeColor = System.Drawing.Color.White;
            this.raktarBtn.Location = new System.Drawing.Point(8, 3);
            this.raktarBtn.Name = "raktarBtn";
            this.raktarBtn.Size = new System.Drawing.Size(218, 41);
            this.raktarBtn.TabIndex = 1;
            this.raktarBtn.Text = "Raktár és Lokáció kezelés";
            this.raktarBtn.UseVisualStyleBackColor = false;
            this.raktarBtn.Click += new System.EventHandler(this.raktarBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.statuszokBtn);
            this.tabPage3.Controls.Add(this.azonGeneralBtn);
            this.tabPage3.Controls.Add(this.mindenGyartasBtn);
            this.tabPage3.Controls.Add(this.munkarendekBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(955, 50);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Megrendelés & Gyártás";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // statuszokBtn
            // 
            this.statuszokBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.statuszokBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statuszokBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statuszokBtn.ForeColor = System.Drawing.Color.White;
            this.statuszokBtn.Location = new System.Drawing.Point(795, 3);
            this.statuszokBtn.Name = "statuszokBtn";
            this.statuszokBtn.Size = new System.Drawing.Size(116, 41);
            this.statuszokBtn.TabIndex = 10;
            this.statuszokBtn.Text = "Státuszok";
            this.statuszokBtn.UseVisualStyleBackColor = false;
            this.statuszokBtn.Click += new System.EventHandler(this.statuszokBtn_Click);
            // 
            // azonGeneralBtn
            // 
            this.azonGeneralBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.azonGeneralBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.azonGeneralBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.azonGeneralBtn.ForeColor = System.Drawing.Color.White;
            this.azonGeneralBtn.Location = new System.Drawing.Point(474, 3);
            this.azonGeneralBtn.Name = "azonGeneralBtn";
            this.azonGeneralBtn.Size = new System.Drawing.Size(315, 41);
            this.azonGeneralBtn.TabIndex = 9;
            this.azonGeneralBtn.Text = "Azonosító generálás beállítások";
            this.azonGeneralBtn.UseVisualStyleBackColor = false;
            this.azonGeneralBtn.Click += new System.EventHandler(this.azonGeneralBtn_Click);
            // 
            // mindenGyartasBtn
            // 
            this.mindenGyartasBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mindenGyartasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mindenGyartasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mindenGyartasBtn.ForeColor = System.Drawing.Color.White;
            this.mindenGyartasBtn.Location = new System.Drawing.Point(245, 3);
            this.mindenGyartasBtn.Name = "mindenGyartasBtn";
            this.mindenGyartasBtn.Size = new System.Drawing.Size(223, 41);
            this.mindenGyartasBtn.TabIndex = 8;
            this.mindenGyartasBtn.Text = "Minden gyártás";
            this.mindenGyartasBtn.UseVisualStyleBackColor = false;
            this.mindenGyartasBtn.Click += new System.EventHandler(this.mindenGyartasBtn_Click);
            // 
            // munkarendekBtn
            // 
            this.munkarendekBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.munkarendekBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.munkarendekBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.munkarendekBtn.ForeColor = System.Drawing.Color.White;
            this.munkarendekBtn.Location = new System.Drawing.Point(3, 3);
            this.munkarendekBtn.Name = "munkarendekBtn";
            this.munkarendekBtn.Size = new System.Drawing.Size(240, 41);
            this.munkarendekBtn.TabIndex = 6;
            this.munkarendekBtn.Text = "Megrendelések";
            this.munkarendekBtn.UseVisualStyleBackColor = false;
            this.munkarendekBtn.Click += new System.EventHandler(this.munkarendekBtn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.gepekBtn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(955, 50);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Gépek";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(143, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 41);
            this.button4.TabIndex = 9;
            this.button4.Text = "Gépstátuszok";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // gepekBtn
            // 
            this.gepekBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gepekBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gepekBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gepekBtn.ForeColor = System.Drawing.Color.White;
            this.gepekBtn.Location = new System.Drawing.Point(3, 3);
            this.gepekBtn.Name = "gepekBtn";
            this.gepekBtn.Size = new System.Drawing.Size(134, 41);
            this.gepekBtn.TabIndex = 1;
            this.gepekBtn.Text = "Gépek";
            this.gepekBtn.UseVisualStyleBackColor = false;
            this.gepekBtn.Click += new System.EventHandler(this.gepekBtn_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.vevoKezelesBtn);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.felhasznaloKezelesBtn);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(955, 50);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Felhasználók";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(380, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Jogosultságok";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // felhasznaloKezelesBtn
            // 
            this.felhasznaloKezelesBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.felhasznaloKezelesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.felhasznaloKezelesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.felhasznaloKezelesBtn.ForeColor = System.Drawing.Color.White;
            this.felhasznaloKezelesBtn.Location = new System.Drawing.Point(4, 3);
            this.felhasznaloKezelesBtn.Name = "felhasznaloKezelesBtn";
            this.felhasznaloKezelesBtn.Size = new System.Drawing.Size(182, 41);
            this.felhasznaloKezelesBtn.TabIndex = 2;
            this.felhasznaloKezelesBtn.Text = "Felhasználók kezelése";
            this.felhasznaloKezelesBtn.UseVisualStyleBackColor = false;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(955, 50);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Riportok";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.button3);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(955, 50);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Karbantartás";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Esedékes karbantartások";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage8.Size = new System.Drawing.Size(955, 50);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Beállítások";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 76);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(963, 394);
            this.tabControl2.TabIndex = 4;
            // 
            // vevoKezelesBtn
            // 
            this.vevoKezelesBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vevoKezelesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vevoKezelesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vevoKezelesBtn.ForeColor = System.Drawing.Color.White;
            this.vevoKezelesBtn.Location = new System.Drawing.Point(192, 3);
            this.vevoKezelesBtn.Name = "vevoKezelesBtn";
            this.vevoKezelesBtn.Size = new System.Drawing.Size(182, 41);
            this.vevoKezelesBtn.TabIndex = 4;
            this.vevoKezelesBtn.Text = "Vevők kezelése";
            this.vevoKezelesBtn.UseVisualStyleBackColor = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 495);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.bottomMenu);
            this.Controls.Add(this.tabControl1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.bottomMenu;
            this.MinimumSize = new System.Drawing.Size(948, 528);
            this.Name = "main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Industry Manufacturing Manager [ Industry 4.0 ]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.Resize += new System.EventHandler(this.main_Resize);
            this.bottomMenu.ResumeLayout(false);
            this.bottomMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip bottomMenu;
        private System.Windows.Forms.ToolStripTextBox bottomMenuUNBox;
        private System.Windows.Forms.ToolStripTextBox bottomMenuRoleBox;
        private System.Windows.Forms.ToolStripTextBox bottomMenuLoggerTextbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button mindenTermekBtn;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Button termekKategoriakBtn;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button gepekBtn;
        private System.Windows.Forms.Button anyagokBtn;
        private System.Windows.Forms.Button raktarBtn;
        private System.Windows.Forms.Button munkarendekBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button felhasznaloKezelesBtn;
        private System.Windows.Forms.Button anyagRaktarozasBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button mindenGyartasBtn;
        private System.Windows.Forms.Button azonGeneralBtn;
        private System.Windows.Forms.Button statuszokBtn;
        private System.Windows.Forms.Button vevoKezelesBtn;
    }
}

