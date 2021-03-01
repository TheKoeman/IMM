
namespace IMM.Forms.GyartasForms {
    partial class gyartasSzuresForm {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.szuresBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mrendMegnevTextbox = new System.Windows.Forms.TextBox();
            this.terNevTextbox = new System.Windows.Forms.TextBox();
            this.mrendAzonTextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mrendMegnev = new System.Windows.Forms.RadioButton();
            this.terNev = new System.Windows.Forms.RadioButton();
            this.mrendAzon = new System.Windows.Forms.RadioButton();
            this.szuresTorleseBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mrendMegnevTextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.terNevTextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mrendAzonTextbox, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(810, 216);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // szuresBtn
            // 
            this.szuresBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.szuresBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szuresBtn.Location = new System.Drawing.Point(0, 330);
            this.szuresBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.szuresBtn.Name = "szuresBtn";
            this.szuresBtn.Size = new System.Drawing.Size(810, 62);
            this.szuresBtn.TabIndex = 1;
            this.szuresBtn.Text = "Szűrés";
            this.szuresBtn.UseVisualStyleBackColor = true;
            this.szuresBtn.Click += new System.EventHandler(this.szuresBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Munkarend megnevezése:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Termék név:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Munkarend azonosító:";
            // 
            // mrendMegnevTextbox
            // 
            this.mrendMegnevTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mrendMegnevTextbox.Enabled = false;
            this.mrendMegnevTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mrendMegnevTextbox.Location = new System.Drawing.Point(305, 3);
            this.mrendMegnevTextbox.Name = "mrendMegnevTextbox";
            this.mrendMegnevTextbox.Size = new System.Drawing.Size(502, 35);
            this.mrendMegnevTextbox.TabIndex = 4;
            // 
            // terNevTextbox
            // 
            this.terNevTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terNevTextbox.Enabled = false;
            this.terNevTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.terNevTextbox.Location = new System.Drawing.Point(305, 44);
            this.terNevTextbox.Name = "terNevTextbox";
            this.terNevTextbox.Size = new System.Drawing.Size(502, 35);
            this.terNevTextbox.TabIndex = 5;
            // 
            // mrendAzonTextbox
            // 
            this.mrendAzonTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mrendAzonTextbox.Enabled = false;
            this.mrendAzonTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mrendAzonTextbox.Location = new System.Drawing.Point(305, 85);
            this.mrendAzonTextbox.Name = "mrendAzonTextbox";
            this.mrendAzonTextbox.Size = new System.Drawing.Size(502, 35);
            this.mrendAzonTextbox.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mrendAzon);
            this.panel1.Controls.Add(this.terNev);
            this.panel1.Controls.Add(this.mrendMegnev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 52);
            this.panel1.TabIndex = 2;
            // 
            // mrendMegnev
            // 
            this.mrendMegnev.AutoSize = true;
            this.mrendMegnev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mrendMegnev.Location = new System.Drawing.Point(12, 12);
            this.mrendMegnev.Name = "mrendMegnev";
            this.mrendMegnev.Size = new System.Drawing.Size(301, 33);
            this.mrendMegnev.TabIndex = 0;
            this.mrendMegnev.TabStop = true;
            this.mrendMegnev.Text = "Munkarend megnevezés";
            this.mrendMegnev.UseVisualStyleBackColor = true;
            this.mrendMegnev.CheckedChanged += new System.EventHandler(this.mrendMegnev_CheckedChanged);
            // 
            // terNev
            // 
            this.terNev.AutoSize = true;
            this.terNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.terNev.Location = new System.Drawing.Point(315, 12);
            this.terNev.Name = "terNev";
            this.terNev.Size = new System.Drawing.Size(166, 33);
            this.terNev.TabIndex = 1;
            this.terNev.TabStop = true;
            this.terNev.Text = "Termék név";
            this.terNev.UseVisualStyleBackColor = true;
            this.terNev.CheckedChanged += new System.EventHandler(this.terNev_CheckedChanged);
            // 
            // mrendAzon
            // 
            this.mrendAzon.AutoSize = true;
            this.mrendAzon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mrendAzon.Location = new System.Drawing.Point(487, 12);
            this.mrendAzon.Name = "mrendAzon";
            this.mrendAzon.Size = new System.Drawing.Size(267, 33);
            this.mrendAzon.TabIndex = 2;
            this.mrendAzon.TabStop = true;
            this.mrendAzon.Text = "Munkarend azonosító";
            this.mrendAzon.UseVisualStyleBackColor = true;
            this.mrendAzon.CheckedChanged += new System.EventHandler(this.mrendAzon_CheckedChanged);
            // 
            // szuresTorleseBtn
            // 
            this.szuresTorleseBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.szuresTorleseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szuresTorleseBtn.Location = new System.Drawing.Point(0, 268);
            this.szuresTorleseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.szuresTorleseBtn.Name = "szuresTorleseBtn";
            this.szuresTorleseBtn.Size = new System.Drawing.Size(810, 62);
            this.szuresTorleseBtn.TabIndex = 3;
            this.szuresTorleseBtn.Text = "Szűrés törlése\r\n";
            this.szuresTorleseBtn.UseVisualStyleBackColor = true;
            this.szuresTorleseBtn.Click += new System.EventHandler(this.szuresTorleseBtn_Click);
            // 
            // gyartasSzuresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 392);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.szuresTorleseBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.szuresBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(650, 307);
            this.Name = "gyartasSzuresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gyártások szűrése";
            this.Load += new System.EventHandler(this.gyartasSzuresForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button szuresBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mrendMegnevTextbox;
        private System.Windows.Forms.TextBox terNevTextbox;
        private System.Windows.Forms.TextBox mrendAzonTextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton mrendAzon;
        private System.Windows.Forms.RadioButton terNev;
        private System.Windows.Forms.RadioButton mrendMegnev;
        private System.Windows.Forms.Button szuresTorleseBtn;
    }
}