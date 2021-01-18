namespace IMM.Forms.GyartasForms {
    partial class termekGyartashozForm {
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
            this.jovahagyBtn = new System.Windows.Forms.Button();
            this.termekekGridView = new System.Windows.Forms.DataGridView();
            this.checkBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.termekekGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // jovahagyBtn
            // 
            this.jovahagyBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.jovahagyBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.jovahagyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jovahagyBtn.ForeColor = System.Drawing.Color.White;
            this.jovahagyBtn.Location = new System.Drawing.Point(0, 410);
            this.jovahagyBtn.Name = "jovahagyBtn";
            this.jovahagyBtn.Size = new System.Drawing.Size(800, 40);
            this.jovahagyBtn.TabIndex = 1;
            this.jovahagyBtn.Text = "Jóváhagyás";
            this.jovahagyBtn.UseVisualStyleBackColor = false;
            this.jovahagyBtn.Click += new System.EventHandler(this.jovahagyBtn_Click);
            // 
            // termekekGridView
            // 
            this.termekekGridView.BackgroundColor = System.Drawing.Color.White;
            this.termekekGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.termekekGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBoxColumn});
            this.termekekGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.termekekGridView.Location = new System.Drawing.Point(0, 0);
            this.termekekGridView.Name = "termekekGridView";
            this.termekekGridView.Size = new System.Drawing.Size(800, 410);
            this.termekekGridView.TabIndex = 2;
            // 
            // checkBoxColumn
            // 
            this.checkBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.checkBoxColumn.HeaderText = "Kiválaszt";
            this.checkBoxColumn.Name = "checkBoxColumn";
            this.checkBoxColumn.Width = 55;
            // 
            // termekGyartashozForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.termekekGridView);
            this.Controls.Add(this.jovahagyBtn);
            this.Name = "termekGyartashozForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termékek hozzáadása a munkarendhez";
            this.Load += new System.EventHandler(this.termekGyartashozForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.termekekGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jovahagyBtn;
        private System.Windows.Forms.DataGridView termekekGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxColumn;
    }
}