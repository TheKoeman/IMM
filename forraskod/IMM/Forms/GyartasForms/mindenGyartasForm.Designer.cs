namespace IMM.Forms.GyartasForms {
    partial class mindenGyartasForm {
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.mindenGyartasGridView = new System.Windows.Forms.DataGridView();
            this.gyartasOldalBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.munkarendOldalBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mindenGyartasGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 45);
            this.panel1.TabIndex = 1;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.LightBlue;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(1107, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 23);
            this.close.TabIndex = 3;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // mindenGyartasGridView
            // 
            this.mindenGyartasGridView.BackgroundColor = System.Drawing.Color.White;
            this.mindenGyartasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mindenGyartasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gyartasOldalBtn,
            this.munkarendOldalBtn});
            this.mindenGyartasGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mindenGyartasGridView.Location = new System.Drawing.Point(0, 45);
            this.mindenGyartasGridView.Name = "mindenGyartasGridView";
            this.mindenGyartasGridView.ReadOnly = true;
            this.mindenGyartasGridView.Size = new System.Drawing.Size(1131, 500);
            this.mindenGyartasGridView.TabIndex = 9;
            this.mindenGyartasGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mindenGyartasGridView_CellContentClick);
            // 
            // gyartasOldalBtn
            // 
            this.gyartasOldalBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gyartasOldalBtn.HeaderText = "Gyártás Oldal";
            this.gyartasOldalBtn.Name = "gyartasOldalBtn";
            this.gyartasOldalBtn.ReadOnly = true;
            this.gyartasOldalBtn.Width = 76;
            // 
            // munkarendOldalBtn
            // 
            this.munkarendOldalBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.munkarendOldalBtn.HeaderText = "Munkarend Oldal";
            this.munkarendOldalBtn.Name = "munkarendOldalBtn";
            this.munkarendOldalBtn.ReadOnly = true;
            this.munkarendOldalBtn.Width = 85;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mindenGyartasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 545);
            this.Controls.Add(this.mindenGyartasGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mindenGyartasForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minden gyártás";
            this.Load += new System.EventHandler(this.mindenGyartasForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mindenGyartasGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridView mindenGyartasGridView;
        private System.Windows.Forms.DataGridViewButtonColumn gyartasOldalBtn;
        private System.Windows.Forms.DataGridViewButtonColumn munkarendOldalBtn;
        private System.Windows.Forms.Timer timer1;
    }
}