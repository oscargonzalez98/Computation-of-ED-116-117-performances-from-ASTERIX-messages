
namespace ASTERIX
{
    partial class ED_SMR
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
            this.Mapa = new GMap.NET.WindowsForms.GMapControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_CalculateProbabilityofFalseDetection = new System.Windows.Forms.Button();
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile = new System.Windows.Forms.Button();
            this.pb_ProbabilityofUpdate_ED116_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mapa
            // 
            this.Mapa.Bearing = 0F;
            this.Mapa.CanDragMap = true;
            this.Mapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.Mapa.GrayScaleMode = false;
            this.Mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Mapa.LevelsKeepInMemmory = 5;
            this.Mapa.Location = new System.Drawing.Point(620, 3);
            this.Mapa.MarkersEnabled = true;
            this.Mapa.MaxZoom = 2;
            this.Mapa.MinZoom = 2;
            this.Mapa.MouseWheelZoomEnabled = true;
            this.Mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Mapa.Name = "Mapa";
            this.Mapa.NegativeMode = false;
            this.Mapa.PolygonsEnabled = true;
            this.Mapa.RetryLoadTile = 0;
            this.Mapa.RoutesEnabled = true;
            this.Mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Mapa.ShowTileGridLines = false;
            this.Mapa.Size = new System.Drawing.Size(1281, 1035);
            this.Mapa.TabIndex = 0;
            this.Mapa.Zoom = 0D;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.41445F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.58555F));
            this.tableLayoutPanel1.Controls.Add(this.Mapa, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1904, 1041);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_ProbabilityofIdentification_ED117_ASTERIXfile);
            this.panel1.Controls.Add(this.bt_CalculateProbabilityofFalseDetection);
            this.panel1.Controls.Add(this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile);
            this.panel1.Controls.Add(this.pb_ProbabilityofUpdate_ED116_ASTERIXfile);
            this.panel1.Controls.Add(this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile);
            this.panel1.Controls.Add(this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 1035);
            this.panel1.TabIndex = 1;
            // 
            // bt_ProbabilityofIdentification_ED117_ASTERIXfile
            // 
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.Location = new System.Drawing.Point(41, 249);
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.Name = "bt_ProbabilityofIdentification_ED117_ASTERIXfile";
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.TabIndex = 32;
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.Text = "Calculate Probability of Identification";
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            // 
            // bt_CalculateProbabilityofFalseDetection
            // 
            this.bt_CalculateProbabilityofFalseDetection.Location = new System.Drawing.Point(41, 288);
            this.bt_CalculateProbabilityofFalseDetection.Name = "bt_CalculateProbabilityofFalseDetection";
            this.bt_CalculateProbabilityofFalseDetection.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateProbabilityofFalseDetection.TabIndex = 33;
            this.bt_CalculateProbabilityofFalseDetection.Text = "Calculate Probability of False Detection";
            this.bt_CalculateProbabilityofFalseDetection.UseVisualStyleBackColor = true;
            // 
            // bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile
            // 
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.Location = new System.Drawing.Point(41, 327);
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.Name = "bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile";
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.TabIndex = 31;
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.Text = "Calculate Probability of False Identification";
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            // 
            // pb_ProbabilityofUpdate_ED116_ASTERIXfile
            // 
            this.pb_ProbabilityofUpdate_ED116_ASTERIXfile.Location = new System.Drawing.Point(41, 132);
            this.pb_ProbabilityofUpdate_ED116_ASTERIXfile.Name = "pb_ProbabilityofUpdate_ED116_ASTERIXfile";
            this.pb_ProbabilityofUpdate_ED116_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.pb_ProbabilityofUpdate_ED116_ASTERIXfile.TabIndex = 28;
            this.pb_ProbabilityofUpdate_ED116_ASTERIXfile.Text = "Calculate Probability of Update";
            this.pb_ProbabilityofUpdate_ED116_ASTERIXfile.UseVisualStyleBackColor = true;
            this.pb_ProbabilityofUpdate_ED116_ASTERIXfile.Click += new System.EventHandler(this.pb_ProbabilityofUpdate_ED116_ASTERIXfile_Click);
            // 
            // bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile
            // 
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Location = new System.Drawing.Point(41, 210);
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Name = "bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile";
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.TabIndex = 30;
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Text = "Calculate Probability of MLAT Detection";
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            // 
            // bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile
            // 
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Location = new System.Drawing.Point(41, 171);
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Name = "bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile";
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.TabIndex = 29;
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Text = "Calculate Precission Accuracy";
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            // 
            // ED_SMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ED_SMR";
            this.Text = "ED_SMR";
            this.Load += new System.EventHandler(this.ED_SMR_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl Mapa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_ProbabilityofIdentification_ED117_ASTERIXfile;
        private System.Windows.Forms.Button bt_CalculateProbabilityofFalseDetection;
        private System.Windows.Forms.Button bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile;
        private System.Windows.Forms.Button pb_ProbabilityofUpdate_ED116_ASTERIXfile;
        private System.Windows.Forms.Button bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile;
        private System.Windows.Forms.Button bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile;
    }
}