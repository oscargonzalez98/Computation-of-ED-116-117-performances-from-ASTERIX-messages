namespace ASTERIX
{
    partial class DataGrid_PositionAcuracy_fromASTERIXfile
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P95 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Standard95thPercentile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P99 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Muestras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.P95,
            this.Standard95thPercentile,
            this.P99,
            this.Column1,
            this.Mean,
            this.STD,
            this.Muestras});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Zone";
            this.Column2.Name = "Column2";
            // 
            // P95
            // 
            this.P95.HeaderText = "95th Percentile (m)";
            this.P95.Name = "P95";
            this.P95.ReadOnly = true;
            // 
            // Standard95thPercentile
            // 
            this.Standard95thPercentile.HeaderText = "Expected 95th Percentile";
            this.Standard95thPercentile.Name = "Standard95thPercentile";
            // 
            // P99
            // 
            this.P99.HeaderText = "99th Percentile";
            this.P99.Name = "P99";
            this.P99.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Expected 99th Percentile";
            this.Column1.Name = "Column1";
            // 
            // Mean
            // 
            this.Mean.HeaderText = "Mean";
            this.Mean.Name = "Mean";
            this.Mean.ReadOnly = true;
            // 
            // STD
            // 
            this.STD.HeaderText = "Standard Deviation";
            this.STD.Name = "STD";
            this.STD.ReadOnly = true;
            // 
            // Muestras
            // 
            this.Muestras.HeaderText = "Samples";
            this.Muestras.Name = "Muestras";
            this.Muestras.ReadOnly = true;
            // 
            // DataGrid_PositionAcuracy_fromASTERIXfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataGrid_PositionAcuracy_fromASTERIXfile";
            this.Text = "DataGrid_PositionAcuracy_fromASTERIXfile";
            this.Load += new System.EventHandler(this.DataGrid_PositionAcuracy_fromASTERIXfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn P95;
        private System.Windows.Forms.DataGridViewTextBoxColumn Standard95thPercentile;
        private System.Windows.Forms.DataGridViewTextBoxColumn P99;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mean;
        private System.Windows.Forms.DataGridViewTextBoxColumn STD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Muestras;
    }
}