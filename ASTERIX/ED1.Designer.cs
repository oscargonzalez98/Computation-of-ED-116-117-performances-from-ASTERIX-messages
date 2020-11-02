namespace ASTERIX
{
    partial class ED1
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Mapa = new GMap.NET.WindowsForms.GMapControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_ShowData_PA_fromASTERIXfile = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pb_ProbabilityofUpdate_ED117_CalibrationVehicle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile = new System.Windows.Forms.Button();
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXFile = new System.Windows.Forms.Button();
            this.bt_CalculatePRecissionAccuracy_ED117_ASTERIXFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_CalculateUpdateRate_ED117_ASTERIXFile = new System.Windows.Forms.Button();
            this.pb_ProbabilityofUpdate_ED117_ASTERIXFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.Mapa.Location = new System.Drawing.Point(943, 3);
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
            this.Mapa.Size = new System.Drawing.Size(934, 1011);
            this.Mapa.TabIndex = 1;
            this.Mapa.Zoom = 0D;
            this.Mapa.Load += new System.EventHandler(this.Mapa_Load);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Mapa, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1880, 1017);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_ShowData_PA_fromASTERIXfile);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pb_ProbabilityofUpdate_ED117_CalibrationVehicle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile);
            this.panel1.Controls.Add(this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXFile);
            this.panel1.Controls.Add(this.bt_CalculatePRecissionAccuracy_ED117_ASTERIXFile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_CalculateUpdateRate_ED117_ASTERIXFile);
            this.panel1.Controls.Add(this.pb_ProbabilityofUpdate_ED117_ASTERIXFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 1011);
            this.panel1.TabIndex = 2;
            // 
            // bt_ShowData_PA_fromASTERIXfile
            // 
            this.bt_ShowData_PA_fromASTERIXfile.Location = new System.Drawing.Point(518, 135);
            this.bt_ShowData_PA_fromASTERIXfile.Name = "bt_ShowData_PA_fromASTERIXfile";
            this.bt_ShowData_PA_fromASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_ShowData_PA_fromASTERIXfile.TabIndex = 20;
            this.bt_ShowData_PA_fromASTERIXfile.Text = "Show Position Accuracy Data";
            this.bt_ShowData_PA_fromASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_ShowData_PA_fromASTERIXfile.Click += new System.EventHandler(this.bt_ShowData_PA_fromASTERIXfile_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0 (or > 20 NM)",
            "1 (or < 20 NM)",
            "2 (or < 10 NM)",
            "3 (or < 8 NM)",
            "4 (or < 4 NM)",
            "5 (or < 2 NM)",
            "6 (or < 1 NM)",
            "7 (or < 0.6 NM)",
            "8 (or < 0.5 NM)",
            "9 (or > 0.3 NM)",
            "10 (or < 0.2 NM)",
            "11 (or < 0.1 NM)",
            "12 (or < 0.04 NM)",
            "13 (or < 0.013 NM)",
            "14 (or < 0.004 NM)"});
            this.comboBox1.Location = new System.Drawing.Point(317, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Text = "0 (or > 20 NM)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate PRobability of Identification";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Calculate Probability of MLAT Detection";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 33);
            this.button3.TabIndex = 16;
            this.button3.Text = "Calculate Precission Accuracy";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pb_ProbabilityofUpdate_ED117_CalibrationVehicle
            // 
            this.pb_ProbabilityofUpdate_ED117_CalibrationVehicle.Location = new System.Drawing.Point(18, 308);
            this.pb_ProbabilityofUpdate_ED117_CalibrationVehicle.Name = "pb_ProbabilityofUpdate_ED117_CalibrationVehicle";
            this.pb_ProbabilityofUpdate_ED117_CalibrationVehicle.Size = new System.Drawing.Size(223, 33);
            this.pb_ProbabilityofUpdate_ED117_CalibrationVehicle.TabIndex = 15;
            this.pb_ProbabilityofUpdate_ED117_CalibrationVehicle.Text = "Calculate Probability of Update";
            this.pb_ProbabilityofUpdate_ED117_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.pb_ProbabilityofUpdate_ED117_CalibrationVehicle.Click += new System.EventHandler(this.pb_ProbabilityofUpdate_ED117_CalibrationVehicle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Calculated ED-117 Parameters from Calibration Vehicle File:";
            // 
            // bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile
            // 
            this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile.Location = new System.Drawing.Point(18, 213);
            this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile.Name = "bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile";
            this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile.Size = new System.Drawing.Size(223, 33);
            this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile.TabIndex = 13;
            this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile.Text = "Calculate Probability of Identification";
            this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile.UseVisualStyleBackColor = true;
            this.bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile.Click += new System.EventHandler(this.bt_ProbabilityofMLATIdentification_Click);
            // 
            // bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXFile
            // 
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXFile.Location = new System.Drawing.Point(18, 174);
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXFile.Name = "bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXFile";
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXFile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXFile.TabIndex = 12;
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXFile.Text = "Calculate Probability of MLAT Detection";
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXFile.UseVisualStyleBackColor = true;
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXFile.Click += new System.EventHandler(this.bt_CalculateProbabilityofMLATDetection_Click);
            // 
            // bt_CalculatePRecissionAccuracy_ED117_ASTERIXFile
            // 
            this.bt_CalculatePRecissionAccuracy_ED117_ASTERIXFile.Location = new System.Drawing.Point(18, 135);
            this.bt_CalculatePRecissionAccuracy_ED117_ASTERIXFile.Name = "bt_CalculatePRecissionAccuracy_ED117_ASTERIXFile";
            this.bt_CalculatePRecissionAccuracy_ED117_ASTERIXFile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculatePRecissionAccuracy_ED117_ASTERIXFile.TabIndex = 11;
            this.bt_CalculatePRecissionAccuracy_ED117_ASTERIXFile.Text = "Calculate Precission Accuracy";
            this.bt_CalculatePRecissionAccuracy_ED117_ASTERIXFile.UseVisualStyleBackColor = true;
            this.bt_CalculatePRecissionAccuracy_ED117_ASTERIXFile.Click += new System.EventHandler(this.bt_CalculatePRecissionAccuracy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calculated ED-117 Parameters from ASTERIX File:";
            // 
            // bt_CalculateUpdateRate_ED117_ASTERIXFile
            // 
            this.bt_CalculateUpdateRate_ED117_ASTERIXFile.Location = new System.Drawing.Point(18, 57);
            this.bt_CalculateUpdateRate_ED117_ASTERIXFile.Name = "bt_CalculateUpdateRate_ED117_ASTERIXFile";
            this.bt_CalculateUpdateRate_ED117_ASTERIXFile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateUpdateRate_ED117_ASTERIXFile.TabIndex = 0;
            this.bt_CalculateUpdateRate_ED117_ASTERIXFile.Text = "Calculate Update Rate";
            this.bt_CalculateUpdateRate_ED117_ASTERIXFile.UseVisualStyleBackColor = true;
            this.bt_CalculateUpdateRate_ED117_ASTERIXFile.Click += new System.EventHandler(this.bt_CalculateUpdateRate_Click);
            // 
            // pb_ProbabilityofUpdate_ED117_ASTERIXFile
            // 
            this.pb_ProbabilityofUpdate_ED117_ASTERIXFile.Location = new System.Drawing.Point(18, 96);
            this.pb_ProbabilityofUpdate_ED117_ASTERIXFile.Name = "pb_ProbabilityofUpdate_ED117_ASTERIXFile";
            this.pb_ProbabilityofUpdate_ED117_ASTERIXFile.Size = new System.Drawing.Size(223, 33);
            this.pb_ProbabilityofUpdate_ED117_ASTERIXFile.TabIndex = 3;
            this.pb_ProbabilityofUpdate_ED117_ASTERIXFile.Text = "Calculate Probability of Update";
            this.pb_ProbabilityofUpdate_ED117_ASTERIXFile.UseVisualStyleBackColor = true;
            this.pb_ProbabilityofUpdate_ED117_ASTERIXFile.Click += new System.EventHandler(this.pb_ProbabilityofUpdate_Click);
            // 
            // ED1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ED1";
            this.Text = "ED1";
            this.Load += new System.EventHandler(this.ED1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private GMap.NET.WindowsForms.GMapControl Mapa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_CalculateUpdateRate_ED117_ASTERIXFile;
        private System.Windows.Forms.Button pb_ProbabilityofUpdate_ED117_ASTERIXFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_CalculatePRecissionAccuracy_ED117_ASTERIXFile;
        private System.Windows.Forms.Button bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXFile;
        private System.Windows.Forms.Button bt_ProbabilityofMLATIdentification_ED117_ASTERIXFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button pb_ProbabilityofUpdate_ED117_CalibrationVehicle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt_ShowData_PA_fromASTERIXfile;
    }
}