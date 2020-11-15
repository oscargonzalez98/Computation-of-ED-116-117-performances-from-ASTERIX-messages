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
            this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle = new System.Windows.Forms.Button();
            this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle = new System.Windows.Forms.Button();
            this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle = new System.Windows.Forms.Button();
            this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle = new System.Windows.Forms.Button();
            this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle = new System.Windows.Forms.Button();
            this.bt_CalculateUpdateRate_ED117_CalibrationVehicle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_CalculateProbabilityofFalseDetection = new System.Windows.Forms.Button();
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile = new System.Windows.Forms.Button();
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.Mapa, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
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
            this.Mapa.Location = new System.Drawing.Point(567, 3);
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
            this.Mapa.Size = new System.Drawing.Size(1310, 498);
            this.Mapa.TabIndex = 0;
            this.Mapa.Zoom = 0D;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle);
            this.panel1.Controls.Add(this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle);
            this.panel1.Controls.Add(this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle);
            this.panel1.Controls.Add(this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle);
            this.panel1.Controls.Add(this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle);
            this.panel1.Controls.Add(this.bt_CalculateUpdateRate_ED117_CalibrationVehicle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bt_CalculateProbabilityofFalseDetection);
            this.panel1.Controls.Add(this.bt_ProbabilityofIdentification_ED117_ASTERIXfile);
            this.panel1.Controls.Add(this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile);
            this.panel1.Controls.Add(this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile);
            this.panel1.Controls.Add(this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile);
            this.panel1.Controls.Add(this.pb_ProbabilityofUpdate_ED117_ASTERIXfile);
            this.panel1.Controls.Add(this.bt_CalculateUpdateRate_ED117_ASTERIXfile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 11);
            this.panel1.Size = new System.Drawing.Size(558, 1011);
            this.panel1.TabIndex = 1;
            // 
            // bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle
            // 
            this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle.Location = new System.Drawing.Point(32, 429);
            this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle.Name = "bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle";
            this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle.TabIndex = 33;
            this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle.Text = "Calculate Precission Accuracy";
            this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle.Click += new System.EventHandler(this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle_Click);
            // 
            // bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle
            // 
            this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle.Location = new System.Drawing.Point(32, 585);
            this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle.Name = "bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle";
            this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle.Size = new System.Drawing.Size(223, 33);
            this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle.TabIndex = 32;
            this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle.Text = "Calculate Probability of False Identification";
            this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle.Click += new System.EventHandler(this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle_Click);
            // 
            // bt_CalculateProbabilityofFalseDetection_CalibrationVehicle
            // 
            this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle.Location = new System.Drawing.Point(32, 546);
            this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle.Name = "bt_CalculateProbabilityofFalseDetection_CalibrationVehicle";
            this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle.TabIndex = 31;
            this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle.Text = "Calculate Probability of False Detection";
            this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle.Click += new System.EventHandler(this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle_Click);
            // 
            // bt_ProbabilityofIdentification_ED117_CalibrationVehicle
            // 
            this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle.Location = new System.Drawing.Point(32, 507);
            this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle.Name = "bt_ProbabilityofIdentification_ED117_CalibrationVehicle";
            this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle.Size = new System.Drawing.Size(223, 33);
            this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle.TabIndex = 30;
            this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle.Text = "Calculate Probability of Identification";
            this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle.Click += new System.EventHandler(this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle_Click);
            // 
            // bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle
            // 
            this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle.Location = new System.Drawing.Point(32, 468);
            this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle.Name = "bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle";
            this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle.TabIndex = 29;
            this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle.Text = "Calculate Probability of MLAT Detection";
            this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle.Click += new System.EventHandler(this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle_Click);
            // 
            // bt_CalculateUpdateRate_ED117_CalibrationVehicle
            // 
            this.bt_CalculateUpdateRate_ED117_CalibrationVehicle.Location = new System.Drawing.Point(32, 391);
            this.bt_CalculateUpdateRate_ED117_CalibrationVehicle.Name = "bt_CalculateUpdateRate_ED117_CalibrationVehicle";
            this.bt_CalculateUpdateRate_ED117_CalibrationVehicle.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateUpdateRate_ED117_CalibrationVehicle.TabIndex = 28;
            this.bt_CalculateUpdateRate_ED117_CalibrationVehicle.Text = "Calculate Probability of Update";
            this.bt_CalculateUpdateRate_ED117_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_CalculateUpdateRate_ED117_CalibrationVehicle.Click += new System.EventHandler(this.bt_CalculateUpdateRate_ED117_CalibrationVehicle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Calculated ED-117 Parameters from Calibration Vehicle File:";
            // 
            // bt_CalculateProbabilityofFalseDetection
            // 
            this.bt_CalculateProbabilityofFalseDetection.Location = new System.Drawing.Point(32, 259);
            this.bt_CalculateProbabilityofFalseDetection.Name = "bt_CalculateProbabilityofFalseDetection";
            this.bt_CalculateProbabilityofFalseDetection.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateProbabilityofFalseDetection.TabIndex = 26;
            this.bt_CalculateProbabilityofFalseDetection.Text = "Calculate Probability of False Detection";
            this.bt_CalculateProbabilityofFalseDetection.UseVisualStyleBackColor = true;
            this.bt_CalculateProbabilityofFalseDetection.Click += new System.EventHandler(this.bt_CalculateProbabilityofFalseDetection_Click);
            // 
            // bt_ProbabilityofIdentification_ED117_ASTERIXfile
            // 
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.Location = new System.Drawing.Point(32, 220);
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.Name = "bt_ProbabilityofIdentification_ED117_ASTERIXfile";
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.TabIndex = 25;
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.Text = "Calculate Probability of Identification";
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.Click += new System.EventHandler(this.bt_ProbabilityofIdentification_ED117_ASTERIXfile_Click);
            // 
            // bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile
            // 
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.Location = new System.Drawing.Point(32, 298);
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.Name = "bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile";
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.TabIndex = 24;
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.Text = "Calculate Probability of False Identification";
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.Click += new System.EventHandler(this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile_Click);
            // 
            // bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile
            // 
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Location = new System.Drawing.Point(32, 181);
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Name = "bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile";
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.TabIndex = 15;
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Text = "Calculate Probability of MLAT Detection";
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Click += new System.EventHandler(this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile_Click);
            // 
            // bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile
            // 
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Location = new System.Drawing.Point(32, 142);
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Name = "bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile";
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.TabIndex = 14;
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Text = "Calculate Precission Accuracy";
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Click += new System.EventHandler(this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile_Click);
            // 
            // pb_ProbabilityofUpdate_ED117_ASTERIXfile
            // 
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.Location = new System.Drawing.Point(32, 103);
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.Name = "pb_ProbabilityofUpdate_ED117_ASTERIXfile";
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.TabIndex = 13;
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.Text = "Calculate Probability of Update";
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.Click += new System.EventHandler(this.pb_ProbabilityofUpdate_ED117_ASTERIXfile_Click);
            // 
            // bt_CalculateUpdateRate_ED117_ASTERIXfile
            // 
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile.Location = new System.Drawing.Point(32, 64);
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile.Name = "bt_CalculateUpdateRate_ED117_ASTERIXfile";
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile.TabIndex = 12;
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile.Text = "Calculate Update Rate";
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile.Click += new System.EventHandler(this.bt_CalculateUpdateRate_ED117_ASTERIXfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Calculated ED-117 Parameters from ASTERIX File:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(567, 507);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1310, 498);
            this.dataGridView1.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_CalculateUpdateRate_ED117_ASTERIXfile;
        private System.Windows.Forms.Button pb_ProbabilityofUpdate_ED117_ASTERIXfile;
        private System.Windows.Forms.Button bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile;
        private System.Windows.Forms.Button bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile;
        private System.Windows.Forms.Button bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile;
        private System.Windows.Forms.Button bt_ProbabilityofIdentification_ED117_ASTERIXfile;
        private System.Windows.Forms.Button bt_CalculateProbabilityofFalseDetection;
        private System.Windows.Forms.Button bt_CalculateUpdateRate_ED117_CalibrationVehicle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle;
        private System.Windows.Forms.Button bt_ProbabilityofIdentification_ED117_CalibrationVehicle;
        private System.Windows.Forms.Button bt_CalculateProbabilityofFalseDetection_CalibrationVehicle;
        private System.Windows.Forms.Button bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle;
        private System.Windows.Forms.Button bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle;
        private GMap.NET.WindowsForms.GMapControl Mapa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}