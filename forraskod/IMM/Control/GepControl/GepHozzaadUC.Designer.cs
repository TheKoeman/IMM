namespace IMM.Control {
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mentesBtn = new System.Windows.Forms.Button();
            this.selectCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gepekGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.gepekGridView.Name = "gepekGridView";
            this.gepekGridView.Size = new System.Drawing.Size(1051, 560);
            this.gepekGridView.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.mentesBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 560);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1051, 36);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // mentesBtn
            // 
            this.mentesBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.mentesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mentesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesBtn.Location = new System.Drawing.Point(3, 3);
            this.mentesBtn.Name = "mentesBtn";
            this.mentesBtn.Size = new System.Drawing.Size(228, 33);
            this.mentesBtn.TabIndex = 0;
            this.mentesBtn.Text = "Változtatások mentése";
            this.mentesBtn.UseVisualStyleBackColor = false;
            this.mentesBtn.Click += new System.EventHandler(this.mentesBtn_Click);
            // 
            // selectCheckbox
            // 
            this.selectCheckbox.HeaderText = "Kiválaszt";
            this.selectCheckbox.Name = "selectCheckbox";
            // 
            // GepHozzaadUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gepekGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "GepHozzaadUC";
            this.Size = new System.Drawing.Size(1051, 596);
            ((System.ComponentModel.ISupportInitialize)(this.gepekGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gepekGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button mentesBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectCheckbox;
    }
}
