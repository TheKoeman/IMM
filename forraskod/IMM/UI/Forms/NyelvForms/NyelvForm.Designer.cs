
namespace IMM.Forms.NyelvForms {
    partial class NyelvForm {
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.nyelvekTabpage = new System.Windows.Forms.TabPage();
            this.komponensekTabpage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uzenetekTabpage = new System.Windows.Forms.TabPage();
            this.ujHozzaadasaBtn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.nyelvekTabpage);
            this.tabControl1.Controls.Add(this.komponensekTabpage);
            this.tabControl1.Controls.Add(this.uzenetekTabpage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(994, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // nyelvekTabpage
            // 
            this.nyelvekTabpage.Location = new System.Drawing.Point(4, 29);
            this.nyelvekTabpage.Name = "nyelvekTabpage";
            this.nyelvekTabpage.Padding = new System.Windows.Forms.Padding(3);
            this.nyelvekTabpage.Size = new System.Drawing.Size(986, 523);
            this.nyelvekTabpage.TabIndex = 0;
            this.nyelvekTabpage.Text = "Nyelvek";
            this.nyelvekTabpage.UseVisualStyleBackColor = true;
            // 
            // komponensekTabpage
            // 
            this.komponensekTabpage.Location = new System.Drawing.Point(4, 29);
            this.komponensekTabpage.Name = "komponensekTabpage";
            this.komponensekTabpage.Padding = new System.Windows.Forms.Padding(3);
            this.komponensekTabpage.Size = new System.Drawing.Size(986, 510);
            this.komponensekTabpage.TabIndex = 1;
            this.komponensekTabpage.Text = "Komponensek";
            this.komponensekTabpage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.ujHozzaadasaBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 60);
            this.panel1.TabIndex = 1;
            // 
            // uzenetekTabpage
            // 
            this.uzenetekTabpage.Location = new System.Drawing.Point(4, 29);
            this.uzenetekTabpage.Name = "uzenetekTabpage";
            this.uzenetekTabpage.Padding = new System.Windows.Forms.Padding(3);
            this.uzenetekTabpage.Size = new System.Drawing.Size(986, 510);
            this.uzenetekTabpage.TabIndex = 2;
            this.uzenetekTabpage.Text = "Üzenetek";
            this.uzenetekTabpage.UseVisualStyleBackColor = true;
            // 
            // ujHozzaadasaBtn
            // 
            this.ujHozzaadasaBtn.BackColor = System.Drawing.Color.Teal;
            this.ujHozzaadasaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ujHozzaadasaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujHozzaadasaBtn.ForeColor = System.Drawing.Color.White;
            this.ujHozzaadasaBtn.Location = new System.Drawing.Point(13, 5);
            this.ujHozzaadasaBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ujHozzaadasaBtn.Name = "ujHozzaadasaBtn";
            this.ujHozzaadasaBtn.Size = new System.Drawing.Size(258, 46);
            this.ujHozzaadasaBtn.TabIndex = 2;
            this.ujHozzaadasaBtn.Text = "Új hozzáadása";
            this.ujHozzaadasaBtn.UseVisualStyleBackColor = false;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.LightBlue;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(958, 0);
            this.close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(36, 35);
            this.close.TabIndex = 3;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // NyelvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 616);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NyelvForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nyelv Beállítások";
            this.Load += new System.EventHandler(this.NyelvForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage nyelvekTabpage;
        private System.Windows.Forms.TabPage komponensekTabpage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage uzenetekTabpage;
        private System.Windows.Forms.Button ujHozzaadasaBtn;
        private System.Windows.Forms.Button close;
    }
}