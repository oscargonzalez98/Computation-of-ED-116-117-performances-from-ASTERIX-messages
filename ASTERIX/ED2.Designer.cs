namespace ASTERIX
{
    partial class ED2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Mapa = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile = new System.Windows.Forms.Button();
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile = new System.Windows.Forms.Button();
            this.bt_ProbabilityofMLATIdentification_ED117_fromASTERIXfile = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.Mapa, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1880, 1017);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Mapa
            // 
            this.Mapa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mapa.Bearing = 0F;
            this.Mapa.CanDragMap = true;
            this.Mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.Mapa.GrayScaleMode = false;
            this.Mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Mapa.LevelsKeepInMemmory = 5;
            this.Mapa.Location = new System.Drawing.Point(708, 3);
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
            this.Mapa.Size = new System.Drawing.Size(1169, 1011);
            this.Mapa.TabIndex = 0;
            this.Mapa.Zoom = 0D;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_ProbabilityofMLATIdentification_ED117_fromASTERIXfile);
            this.panel1.Controls.Add(this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile);
            this.panel1.Controls.Add(this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile);
            this.panel1.Controls.Add(this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile);
            this.panel1.Controls.Add(this.pb_ProbabilityofUpdate_ED117_ASTERIXfile);
            this.panel1.Controls.Add(this.bt_CalculateUpdateRate_ED117_ASTERIXfile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 1011);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Calculated ED-117 Parameters from ASTERIX File:";
            // 
            // bt_CalculateUpdateRate_ED117_ASTERIXfile
            // 
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile.Location = new System.Drawing.Point(44, 87);
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile.Name = "bt_CalculateUpdateRate_ED117_ASTERIXfile";
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile.TabIndex = 12;
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile.Text = "Calculate Update Rate";
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile.Click += new System.EventHandler(this.bt_CalculateUpdateRate_ED117_ASTERIXfile_Click);
            // 
            // pb_ProbabilityofUpdate_ED117_ASTERIXfile
            // 
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.Location = new System.Drawing.Point(44, 126);
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.Name = "pb_ProbabilityofUpdate_ED117_ASTERIXfile";
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.TabIndex = 13;
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.Text = "Calculate Probability of Update";
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.Click += new System.EventHandler(this.pb_ProbabilityofUpdate_ED117_ASTERIXfile_Click);
            // 
            // bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile
            // 
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Location = new System.Drawing.Point(44, 165);
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Name = "bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile";
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.TabIndex = 14;
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Text = "Calculate Precission Accuracy";
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Click += new System.EventHandler(this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile_Click);
            // 
            // bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile
            // 
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Location = new System.Drawing.Point(44, 204);
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Name = "bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile";
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.TabIndex = 15;
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Text = "Calculate Probability of MLAT Detection";
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Click += new System.EventHandler(this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile_Click);
            // 
            // bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile
            // 
            this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile.Location = new System.Drawing.Point(44, 243);
            this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile.Name = "bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile";
            this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile.Size = new System.Drawing.Size(223, 33);
            this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile.TabIndex = 16;
            this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile.Text = "Calculate Probability of Identification";
            this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile.UseVisualStyleBackColor = true;
            // 
            // bt_ProbabilityofMLATIdentification_ED117_fromASTERIXfile
            // 
            this.bt_ProbabilityofMLATIdentification_ED117_fromASTERIXfile.Location = new System.Drawing.Point(44, 282);
            this.bt_ProbabilityofMLATIdentification_ED117_fromASTERIXfile.Name = "bt_ProbabilityofMLATIdentification_ED117_fromASTERIXfile";
            this.bt_ProbabilityofMLATIdentification_ED117_fromASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_ProbabilityofMLATIdentification_ED117_fromASTERIXfile.TabIndex = 17;
            this.bt_ProbabilityofMLATIdentification_ED117_fromASTERIXfile.Text = "Calculate Probability of Identification";
            this.bt_ProbabilityofMLATIdentification_ED117_fromASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_ProbabilityofMLATIdentification_ED117_fromASTERIXfile.Click += new System.EventHandler(this.bt_ProbabilityofMLATIdentification_ED117_fromASTERIXfile_Click);
            // 
            // ED2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ED2";
            this.Text = "ED2";
            this.Load += new System.EventHandler(this.ED2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GMap.NET.WindowsForms.GMapControl Mapa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_CalculateUpdateRate_ED117_ASTERIXfile;
        private System.Windows.Forms.Button pb_ProbabilityofUpdate_ED117_ASTERIXfile;
        private System.Windows.Forms.Button bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile;
        private System.Windows.Forms.Button bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile;
        private System.Windows.Forms.Button bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile;
        private System.Windows.Forms.Button bt_ProbabilityofMLATIdentification_ED117_fromASTERIXfile;
    }
}