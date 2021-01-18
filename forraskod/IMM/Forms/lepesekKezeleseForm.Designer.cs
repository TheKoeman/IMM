namespace IMM.Forms {
    partial class lepesekKezeleseForm {
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
            this.lepesekDatagrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.lepesekDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lepesekDatagrid
            // 
            this.lepesekDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lepesekDatagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lepesekDatagrid.Location = new System.Drawing.Point(0, 52);
            this.lepesekDatagrid.Name = "lepesekDatagrid";
            this.lepesekDatagrid.Size = new System.Drawing.Size(876, 372);
            this.lepesekDatagrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 52);
            this.panel1.TabIndex = 1;
            // 
            // lepesekKezeleseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 424);
            this.Controls.Add(this.lepesekDatagrid);
            this.Controls.Add(this.panel1);
            this.Name = "lepesekKezeleseForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lépések kezelése";
            ((System.ComponentModel.ISupportInitialize)(this.lepesekDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lepesekDatagrid;
        private System.Windows.Forms.Panel panel1;
    }
}