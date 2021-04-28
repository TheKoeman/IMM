namespace IMM.UControl {
    partial class GepHozzaadUC {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gepekGridView = new System.Windows.Forms.DataGridView();
            this.selectCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mentesBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gepekGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gepekGridView
            // 
            this.gepekGridView.BackgroundColor = System.Drawing.Color.White;
            this.gepekGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gepekGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectCheckbox});
            this.gepekGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gepekGridView.Location = new System.Drawing.Point(0, 0);
            this.gepekGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gepekGridView.Name = "gepekGridView";
            this.gepekGridView.RowHeadersWidth = 62;
            this.gepekGridView.Size = new System.Drawing.Size(581, 489);
            this.gepekGridView.TabIndex = 0;
            // 
            // selectCheckbox
            // 
            this.selectCheckbox.HeaderText = "Kiválaszt";
            this.selectCheckbox.MinimumWidth = 8;
            this.selectCheckbox.Name = "selectCheckbox";
            this.selectCheckbox.Width = 150;
            // 
            // mentesBtn
            // 
            this.mentesBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.mentesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mentesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mentesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesBtn.Location = new System.Drawing.Point(0, 0);
            this.mentesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mentesBtn.Name = "mentesBtn";
            this.mentesBtn.Size = new System.Drawing.Size(581, 50);
            this.mentesBtn.TabIndex = 0;
            this.mentesBtn.Text = "Változtatások mentése";
            this.mentesBtn.UseVisualStyleBackColor = false;
            this.mentesBtn.Click += new System.EventHandler(this.mentesBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mentesBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 50);
            this.panel1.TabIndex = 1;
            // 
            // GepHozzaadUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gepekGridView);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GepHozzaadUC";
            this.Size = new System.Drawing.Size(581, 539);
            ((System.ComponentModel.ISupportInitialize)(this.gepekGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gepekGridView;
        private System.Windows.Forms.Button mentesBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectCheckbox;
        private System.Windows.Forms.Panel panel1;
    }
}
