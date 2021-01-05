namespace ASTERIX
{
    partial class ED2_MLAT
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt_Export_ProbabilityofFalseIdentification_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_Export_ProbabilityofFalseDetection_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_Export_ProbabilityofIdentification_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_Export_ProbabilityofMLATDetection_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_Export_PrecissionAccuracy_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_Export_ProbabilityofUpdate_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_Export_UpdateRate_ASTERIXfile = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_Mapa = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Update = new System.Windows.Forms.Button();
            this.cb_ShowAirportZones = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_ColorbyAirportZone = new System.Windows.Forms.RadioButton();
            this.rb_ColorbyGB = new System.Windows.Forms.RadioButton();
            this.rb_allsamecolor = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_plotCalVehiclefromTEXTfile = new System.Windows.Forms.RadioButton();
            this.rb_PlotCalVehiclefromASTfile = new System.Windows.Forms.RadioButton();
            this.rb_PlotAllfromASTERIXfile = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Export_ProbabilityofMLATDetection_CalibrationVehicle = new System.Windows.Forms.Button();
            this.bt_Export_ProbabilityofUpdate_CalibrationVehicle = new System.Windows.Forms.Button();
            this.bt_Export_PrecissionAccuracy_CalibrationVehicle = new System.Windows.Forms.Button();
            this.bt_Export_ProbabilityofIdentification_CalibrationVehicle = new System.Windows.Forms.Button();
            this.bt_Export_ProbabilityofFalseIdentification_CalibrationVehicle = new System.Windows.Forms.Button();
            this.bt_Export_ProbabilityofFalseDetection_CalibrationVehicle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Map = new System.Windows.Forms.Button();
            this.bt_Performances = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_Mapa.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.Mapa.Location = new System.Drawing.Point(3, 144);
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
            this.Mapa.Size = new System.Drawing.Size(1280, 798);
            this.Mapa.TabIndex = 0;
            this.Mapa.Zoom = 0D;
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
            "14 (or < 0.004 NM)",
            "Auto"});
            this.comboBox1.Location = new System.Drawing.Point(232, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 21);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.Text = "0 (or > 20 NM)";
            // 
            // bt_Export_ProbabilityofFalseIdentification_ASTERIXfile
            // 
            this.bt_Export_ProbabilityofFalseIdentification_ASTERIXfile.Location = new System.Drawing.Point(358, 277);
            this.bt_Export_ProbabilityofFalseIdentification_ASTERIXfile.Name = "bt_Export_ProbabilityofFalseIdentification_ASTERIXfile";
            this.bt_Export_ProbabilityofFalseIdentification_ASTERIXfile.Size = new System.Drawing.Size(104, 33);
            this.bt_Export_ProbabilityofFalseIdentification_ASTERIXfile.TabIndex = 40;
            this.bt_Export_ProbabilityofFalseIdentification_ASTERIXfile.Text = "Export";
            this.bt_Export_ProbabilityofFalseIdentification_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_Export_ProbabilityofFalseIdentification_ASTERIXfile.Click += new System.EventHandler(this.bt_Export_ProbabilityofFalseIdentification_ASTERIXfile_Click);
            // 
            // bt_Export_ProbabilityofFalseDetection_ASTERIXfile
            // 
            this.bt_Export_ProbabilityofFalseDetection_ASTERIXfile.Location = new System.Drawing.Point(358, 238);
            this.bt_Export_ProbabilityofFalseDetection_ASTERIXfile.Name = "bt_Export_ProbabilityofFalseDetection_ASTERIXfile";
            this.bt_Export_ProbabilityofFalseDetection_ASTERIXfile.Size = new System.Drawing.Size(104, 33);
            this.bt_Export_ProbabilityofFalseDetection_ASTERIXfile.TabIndex = 39;
            this.bt_Export_ProbabilityofFalseDetection_ASTERIXfile.Text = "Export";
            this.bt_Export_ProbabilityofFalseDetection_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_Export_ProbabilityofFalseDetection_ASTERIXfile.Click += new System.EventHandler(this.bt_Export_ProbabilityofFalseDetection_ASTERIXfile_Click);
            // 
            // bt_Export_ProbabilityofIdentification_ASTERIXfile
            // 
            this.bt_Export_ProbabilityofIdentification_ASTERIXfile.Location = new System.Drawing.Point(358, 199);
            this.bt_Export_ProbabilityofIdentification_ASTERIXfile.Name = "bt_Export_ProbabilityofIdentification_ASTERIXfile";
            this.bt_Export_ProbabilityofIdentification_ASTERIXfile.Size = new System.Drawing.Size(104, 33);
            this.bt_Export_ProbabilityofIdentification_ASTERIXfile.TabIndex = 38;
            this.bt_Export_ProbabilityofIdentification_ASTERIXfile.Text = "Export";
            this.bt_Export_ProbabilityofIdentification_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_Export_ProbabilityofIdentification_ASTERIXfile.Click += new System.EventHandler(this.bt_Export_ProbabilityofIdentification_ASTERIXfile_Click);
            // 
            // bt_Export_ProbabilityofMLATDetection_ASTERIXfile
            // 
            this.bt_Export_ProbabilityofMLATDetection_ASTERIXfile.Location = new System.Drawing.Point(358, 160);
            this.bt_Export_ProbabilityofMLATDetection_ASTERIXfile.Name = "bt_Export_ProbabilityofMLATDetection_ASTERIXfile";
            this.bt_Export_ProbabilityofMLATDetection_ASTERIXfile.Size = new System.Drawing.Size(104, 33);
            this.bt_Export_ProbabilityofMLATDetection_ASTERIXfile.TabIndex = 37;
            this.bt_Export_ProbabilityofMLATDetection_ASTERIXfile.Text = "Export";
            this.bt_Export_ProbabilityofMLATDetection_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_Export_ProbabilityofMLATDetection_ASTERIXfile.Click += new System.EventHandler(this.bt_Export_ProbabilityofMLATDetection_ASTERIXfile_Click);
            // 
            // bt_Export_PrecissionAccuracy_ASTERIXfile
            // 
            this.bt_Export_PrecissionAccuracy_ASTERIXfile.Location = new System.Drawing.Point(358, 121);
            this.bt_Export_PrecissionAccuracy_ASTERIXfile.Name = "bt_Export_PrecissionAccuracy_ASTERIXfile";
            this.bt_Export_PrecissionAccuracy_ASTERIXfile.Size = new System.Drawing.Size(104, 33);
            this.bt_Export_PrecissionAccuracy_ASTERIXfile.TabIndex = 36;
            this.bt_Export_PrecissionAccuracy_ASTERIXfile.Text = "Export";
            this.bt_Export_PrecissionAccuracy_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_Export_PrecissionAccuracy_ASTERIXfile.Click += new System.EventHandler(this.bt_Export_PrecissionAccuracy_ASTERIXfile_Click);
            // 
            // bt_Export_ProbabilityofUpdate_ASTERIXfile
            // 
            this.bt_Export_ProbabilityofUpdate_ASTERIXfile.Location = new System.Drawing.Point(358, 82);
            this.bt_Export_ProbabilityofUpdate_ASTERIXfile.Name = "bt_Export_ProbabilityofUpdate_ASTERIXfile";
            this.bt_Export_ProbabilityofUpdate_ASTERIXfile.Size = new System.Drawing.Size(104, 33);
            this.bt_Export_ProbabilityofUpdate_ASTERIXfile.TabIndex = 35;
            this.bt_Export_ProbabilityofUpdate_ASTERIXfile.Text = "Export";
            this.bt_Export_ProbabilityofUpdate_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_Export_ProbabilityofUpdate_ASTERIXfile.Click += new System.EventHandler(this.bt_Export_ProbabilityofUpdate_ASTERIXfile_Click);
            // 
            // bt_Export_UpdateRate_ASTERIXfile
            // 
            this.bt_Export_UpdateRate_ASTERIXfile.Location = new System.Drawing.Point(358, 43);
            this.bt_Export_UpdateRate_ASTERIXfile.Name = "bt_Export_UpdateRate_ASTERIXfile";
            this.bt_Export_UpdateRate_ASTERIXfile.Size = new System.Drawing.Size(104, 33);
            this.bt_Export_UpdateRate_ASTERIXfile.TabIndex = 34;
            this.bt_Export_UpdateRate_ASTERIXfile.Text = "Export";
            this.bt_Export_UpdateRate_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_Export_UpdateRate_ASTERIXfile.Click += new System.EventHandler(this.bt_Export_UpdateRate_ASTERIXfile_Click);
            // 
            // bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle
            // 
            this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle.Location = new System.Drawing.Point(3, 422);
            this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle.Name = "bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle";
            this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle.TabIndex = 33;
            this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle.Text = "Calculate Position Accuracy";
            this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle.Click += new System.EventHandler(this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle_Click);
            // 
            // bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle
            // 
            this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle.Location = new System.Drawing.Point(3, 578);
            this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle.Name = "bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle";
            this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle.Size = new System.Drawing.Size(223, 33);
            this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle.TabIndex = 32;
            this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle.Text = "Calculate Probability of False Identification";
            this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle.Click += new System.EventHandler(this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle_Click);
            // 
            // bt_CalculateProbabilityofFalseDetection_CalibrationVehicle
            // 
            this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle.Location = new System.Drawing.Point(3, 539);
            this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle.Name = "bt_CalculateProbabilityofFalseDetection_CalibrationVehicle";
            this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle.TabIndex = 31;
            this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle.Text = "Calculate Probability of False Detection";
            this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle.Click += new System.EventHandler(this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle_Click);
            // 
            // bt_ProbabilityofIdentification_ED117_CalibrationVehicle
            // 
            this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle.Location = new System.Drawing.Point(3, 500);
            this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle.Name = "bt_ProbabilityofIdentification_ED117_CalibrationVehicle";
            this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle.Size = new System.Drawing.Size(223, 33);
            this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle.TabIndex = 30;
            this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle.Text = "Calculate Probability of Identification";
            this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle.Click += new System.EventHandler(this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle_Click);
            // 
            // bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle
            // 
            this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle.Location = new System.Drawing.Point(3, 461);
            this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle.Name = "bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle";
            this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle.TabIndex = 29;
            this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle.Text = "Calculate Probability of MLAT Detection";
            this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle.Click += new System.EventHandler(this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle_Click);
            // 
            // bt_CalculateUpdateRate_ED117_CalibrationVehicle
            // 
            this.bt_CalculateUpdateRate_ED117_CalibrationVehicle.Location = new System.Drawing.Point(3, 384);
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
            this.label2.Location = new System.Drawing.Point(0, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Calculated ED-117 Parameters from Calibration Vehicle File:";
            // 
            // bt_CalculateProbabilityofFalseDetection
            // 
            this.bt_CalculateProbabilityofFalseDetection.Location = new System.Drawing.Point(3, 238);
            this.bt_CalculateProbabilityofFalseDetection.Name = "bt_CalculateProbabilityofFalseDetection";
            this.bt_CalculateProbabilityofFalseDetection.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateProbabilityofFalseDetection.TabIndex = 26;
            this.bt_CalculateProbabilityofFalseDetection.Text = "Calculate Probability of False Detection";
            this.bt_CalculateProbabilityofFalseDetection.UseVisualStyleBackColor = true;
            this.bt_CalculateProbabilityofFalseDetection.Click += new System.EventHandler(this.bt_CalculateProbabilityofFalseDetection_Click);
            // 
            // bt_ProbabilityofIdentification_ED117_ASTERIXfile
            // 
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.Location = new System.Drawing.Point(3, 199);
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.Name = "bt_ProbabilityofIdentification_ED117_ASTERIXfile";
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.TabIndex = 25;
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.Text = "Calculate Probability of Identification";
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_ProbabilityofIdentification_ED117_ASTERIXfile.Click += new System.EventHandler(this.bt_ProbabilityofIdentification_ED117_ASTERIXfile_Click);
            // 
            // bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile
            // 
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.Location = new System.Drawing.Point(3, 277);
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.Name = "bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile";
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.TabIndex = 24;
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.Text = "Calculate Probability of False Identification";
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile.Click += new System.EventHandler(this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile_Click);
            // 
            // bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile
            // 
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Location = new System.Drawing.Point(3, 160);
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Name = "bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile";
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.TabIndex = 15;
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Text = "Calculate Probability of MLAT Detection";
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile.Click += new System.EventHandler(this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile_Click);
            // 
            // bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile
            // 
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Location = new System.Drawing.Point(3, 121);
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Name = "bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile";
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.TabIndex = 14;
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Text = "Calculate Precission Accuracy";
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile.Click += new System.EventHandler(this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile_Click);
            // 
            // pb_ProbabilityofUpdate_ED117_ASTERIXfile
            // 
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.Location = new System.Drawing.Point(3, 82);
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.Name = "pb_ProbabilityofUpdate_ED117_ASTERIXfile";
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.TabIndex = 13;
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.Text = "Calculate Probability of Update";
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.UseVisualStyleBackColor = true;
            this.pb_ProbabilityofUpdate_ED117_ASTERIXfile.Click += new System.EventHandler(this.pb_ProbabilityofUpdate_ED117_ASTERIXfile_Click);
            // 
            // bt_CalculateUpdateRate_ED117_ASTERIXfile
            // 
            this.bt_CalculateUpdateRate_ED117_ASTERIXfile.Location = new System.Drawing.Point(3, 43);
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
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Calculated ED-117 Parameters from ASTERIX File:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1292, 951);
            this.dataGridView1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1853, 1017);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_Mapa);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(558, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1292, 951);
            this.panel3.TabIndex = 1;
            // 
            // panel_Mapa
            // 
            this.panel_Mapa.Controls.Add(this.tableLayoutPanel3);
            this.panel_Mapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Mapa.Location = new System.Drawing.Point(0, 0);
            this.panel_Mapa.Name = "panel_Mapa";
            this.panel_Mapa.Size = new System.Drawing.Size(1292, 951);
            this.panel_Mapa.TabIndex = 3;
            this.panel_Mapa.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.Mapa, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1286, 945);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Update);
            this.panel1.Controls.Add(this.cb_ShowAirportZones);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 135);
            this.panel1.TabIndex = 1;
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(729, 28);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(156, 42);
            this.bt_Update.TabIndex = 5;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // cb_ShowAirportZones
            // 
            this.cb_ShowAirportZones.AutoSize = true;
            this.cb_ShowAirportZones.Location = new System.Drawing.Point(479, 27);
            this.cb_ShowAirportZones.Name = "cb_ShowAirportZones";
            this.cb_ShowAirportZones.Size = new System.Drawing.Size(119, 17);
            this.cb_ShowAirportZones.TabIndex = 4;
            this.cb_ShowAirportZones.Text = "Show Airport Zones";
            this.cb_ShowAirportZones.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_ColorbyAirportZone);
            this.groupBox2.Controls.Add(this.rb_ColorbyGB);
            this.groupBox2.Controls.Add(this.rb_allsamecolor);
            this.groupBox2.Location = new System.Drawing.Point(295, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 104);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // rb_ColorbyAirportZone
            // 
            this.rb_ColorbyAirportZone.AutoSize = true;
            this.rb_ColorbyAirportZone.Location = new System.Drawing.Point(16, 73);
            this.rb_ColorbyAirportZone.Name = "rb_ColorbyAirportZone";
            this.rb_ColorbyAirportZone.Size = new System.Drawing.Size(124, 17);
            this.rb_ColorbyAirportZone.TabIndex = 2;
            this.rb_ColorbyAirportZone.Text = "Color by Airport Zone";
            this.rb_ColorbyAirportZone.UseVisualStyleBackColor = true;
            // 
            // rb_ColorbyGB
            // 
            this.rb_ColorbyGB.AutoSize = true;
            this.rb_ColorbyGB.Location = new System.Drawing.Point(16, 49);
            this.rb_ColorbyGB.Name = "rb_ColorbyGB";
            this.rb_ColorbyGB.Size = new System.Drawing.Size(116, 17);
            this.rb_ColorbyGB.TabIndex = 1;
            this.rb_ColorbyGB.Text = "Color by Ground Bit";
            this.rb_ColorbyGB.UseVisualStyleBackColor = true;
            // 
            // rb_allsamecolor
            // 
            this.rb_allsamecolor.AutoSize = true;
            this.rb_allsamecolor.Location = new System.Drawing.Point(16, 23);
            this.rb_allsamecolor.Name = "rb_allsamecolor";
            this.rb_allsamecolor.Size = new System.Drawing.Size(78, 17);
            this.rb_allsamecolor.TabIndex = 0;
            this.rb_allsamecolor.Text = "Same color";
            this.rb_allsamecolor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_plotCalVehiclefromTEXTfile);
            this.groupBox1.Controls.Add(this.rb_PlotCalVehiclefromASTfile);
            this.groupBox1.Controls.Add(this.rb_PlotAllfromASTERIXfile);
            this.groupBox1.Location = new System.Drawing.Point(21, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rb_plotCalVehiclefromTEXTfile
            // 
            this.rb_plotCalVehiclefromTEXTfile.AutoSize = true;
            this.rb_plotCalVehiclefromTEXTfile.Location = new System.Drawing.Point(16, 73);
            this.rb_plotCalVehiclefromTEXTfile.Name = "rb_plotCalVehiclefromTEXTfile";
            this.rb_plotCalVehiclefromTEXTfile.Size = new System.Drawing.Size(189, 17);
            this.rb_plotCalVehiclefromTEXTfile.TabIndex = 2;
            this.rb_plotCalVehiclefromTEXTfile.Text = "Plot Calibration Vehicle from .txt file";
            this.rb_plotCalVehiclefromTEXTfile.UseVisualStyleBackColor = true;
            this.rb_plotCalVehiclefromTEXTfile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rb_plotCalVehiclefromTEXTfile_MouseClick);
            // 
            // rb_PlotCalVehiclefromASTfile
            // 
            this.rb_PlotCalVehiclefromASTfile.AutoSize = true;
            this.rb_PlotCalVehiclefromASTfile.Location = new System.Drawing.Point(16, 49);
            this.rb_PlotCalVehiclefromASTfile.Name = "rb_PlotCalVehiclefromASTfile";
            this.rb_PlotCalVehiclefromASTfile.Size = new System.Drawing.Size(221, 17);
            this.rb_PlotCalVehiclefromASTfile.TabIndex = 1;
            this.rb_PlotCalVehiclefromASTfile.Text = "Plot Calibration Vehicle from ASTERIX file";
            this.rb_PlotCalVehiclefromASTfile.UseVisualStyleBackColor = true;
            this.rb_PlotCalVehiclefromASTfile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rb_PlotCalVehiclefromASTfile_MouseClick);
            // 
            // rb_PlotAllfromASTERIXfile
            // 
            this.rb_PlotAllfromASTERIXfile.AutoSize = true;
            this.rb_PlotAllfromASTERIXfile.Location = new System.Drawing.Point(16, 23);
            this.rb_PlotAllfromASTERIXfile.Name = "rb_PlotAllfromASTERIXfile";
            this.rb_PlotAllfromASTERIXfile.Size = new System.Drawing.Size(145, 17);
            this.rb_PlotAllfromASTERIXfile.TabIndex = 0;
            this.rb_PlotAllfromASTERIXfile.Text = "Plot All from ASTERIX file";
            this.rb_PlotAllfromASTERIXfile.UseVisualStyleBackColor = true;
            this.rb_PlotAllfromASTERIXfile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rb_PlotAllfromASTERIXfile_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_Export_ProbabilityofMLATDetection_CalibrationVehicle);
            this.panel2.Controls.Add(this.bt_Export_ProbabilityofUpdate_CalibrationVehicle);
            this.panel2.Controls.Add(this.bt_Export_PrecissionAccuracy_CalibrationVehicle);
            this.panel2.Controls.Add(this.bt_Export_ProbabilityofIdentification_CalibrationVehicle);
            this.panel2.Controls.Add(this.bt_Export_ProbabilityofFalseIdentification_CalibrationVehicle);
            this.panel2.Controls.Add(this.bt_Export_ProbabilityofFalseDetection_CalibrationVehicle);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bt_ProbabilityofIdentification_ED117_ASTERIXfile);
            this.panel2.Controls.Add(this.bt_CalculateUpdateRate_ED117_ASTERIXfile);
            this.panel2.Controls.Add(this.bt_Export_ProbabilityofUpdate_ASTERIXfile);
            this.panel2.Controls.Add(this.bt_Export_PrecissionAccuracy_ASTERIXfile);
            this.panel2.Controls.Add(this.bt_ProbabilityofIdentification_ED117_CalibrationVehicle);
            this.panel2.Controls.Add(this.bt_CalculateProbabilityofFalseDetection);
            this.panel2.Controls.Add(this.bt_Export_ProbabilityofFalseIdentification_ASTERIXfile);
            this.panel2.Controls.Add(this.bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile);
            this.panel2.Controls.Add(this.bt_CalculateProbabilityofFalseDetection_CalibrationVehicle);
            this.panel2.Controls.Add(this.bt_Export_UpdateRate_ASTERIXfile);
            this.panel2.Controls.Add(this.pb_ProbabilityofUpdate_ED117_ASTERIXfile);
            this.panel2.Controls.Add(this.bt_Export_ProbabilityofMLATDetection_ASTERIXfile);
            this.panel2.Controls.Add(this.bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bt_Export_ProbabilityofFalseDetection_ASTERIXfile);
            this.panel2.Controls.Add(this.bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile);
            this.panel2.Controls.Add(this.bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle);
            this.panel2.Controls.Add(this.bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle);
            this.panel2.Controls.Add(this.bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile);
            this.panel2.Controls.Add(this.bt_Export_ProbabilityofIdentification_ASTERIXfile);
            this.panel2.Controls.Add(this.bt_CalculateUpdateRate_ED117_CalibrationVehicle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 951);
            this.panel2.TabIndex = 0;
            // 
            // bt_Export_ProbabilityofMLATDetection_CalibrationVehicle
            // 
            this.bt_Export_ProbabilityofMLATDetection_CalibrationVehicle.Location = new System.Drawing.Point(358, 461);
            this.bt_Export_ProbabilityofMLATDetection_CalibrationVehicle.Name = "bt_Export_ProbabilityofMLATDetection_CalibrationVehicle";
            this.bt_Export_ProbabilityofMLATDetection_CalibrationVehicle.Size = new System.Drawing.Size(104, 33);
            this.bt_Export_ProbabilityofMLATDetection_CalibrationVehicle.TabIndex = 49;
            this.bt_Export_ProbabilityofMLATDetection_CalibrationVehicle.Text = "Export";
            this.bt_Export_ProbabilityofMLATDetection_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_Export_ProbabilityofMLATDetection_CalibrationVehicle.Click += new System.EventHandler(this.bt_Export_ProbabilityofMLATDetection_CalibrationVehicle_Click);
            // 
            // bt_Export_ProbabilityofUpdate_CalibrationVehicle
            // 
            this.bt_Export_ProbabilityofUpdate_CalibrationVehicle.Location = new System.Drawing.Point(358, 383);
            this.bt_Export_ProbabilityofUpdate_CalibrationVehicle.Name = "bt_Export_ProbabilityofUpdate_CalibrationVehicle";
            this.bt_Export_ProbabilityofUpdate_CalibrationVehicle.Size = new System.Drawing.Size(104, 33);
            this.bt_Export_ProbabilityofUpdate_CalibrationVehicle.TabIndex = 48;
            this.bt_Export_ProbabilityofUpdate_CalibrationVehicle.Text = "Export";
            this.bt_Export_ProbabilityofUpdate_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_Export_ProbabilityofUpdate_CalibrationVehicle.Click += new System.EventHandler(this.bt_Export_ProbabilityofUpdate_CalibrationVehicle_Click);
            // 
            // bt_Export_PrecissionAccuracy_CalibrationVehicle
            // 
            this.bt_Export_PrecissionAccuracy_CalibrationVehicle.Location = new System.Drawing.Point(358, 422);
            this.bt_Export_PrecissionAccuracy_CalibrationVehicle.Name = "bt_Export_PrecissionAccuracy_CalibrationVehicle";
            this.bt_Export_PrecissionAccuracy_CalibrationVehicle.Size = new System.Drawing.Size(104, 33);
            this.bt_Export_PrecissionAccuracy_CalibrationVehicle.TabIndex = 43;
            this.bt_Export_PrecissionAccuracy_CalibrationVehicle.Text = "Export";
            this.bt_Export_PrecissionAccuracy_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_Export_PrecissionAccuracy_CalibrationVehicle.Click += new System.EventHandler(this.bt_Export_PrecissionAccuracy_CalibrationVehicle_Click);
            // 
            // bt_Export_ProbabilityofIdentification_CalibrationVehicle
            // 
            this.bt_Export_ProbabilityofIdentification_CalibrationVehicle.Location = new System.Drawing.Point(358, 500);
            this.bt_Export_ProbabilityofIdentification_CalibrationVehicle.Name = "bt_Export_ProbabilityofIdentification_CalibrationVehicle";
            this.bt_Export_ProbabilityofIdentification_CalibrationVehicle.Size = new System.Drawing.Size(104, 33);
            this.bt_Export_ProbabilityofIdentification_CalibrationVehicle.TabIndex = 45;
            this.bt_Export_ProbabilityofIdentification_CalibrationVehicle.Text = "Export";
            this.bt_Export_ProbabilityofIdentification_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_Export_ProbabilityofIdentification_CalibrationVehicle.Click += new System.EventHandler(this.bt_Export_ProbabilityofIdentification_CalibrationVehicle_Click);
            // 
            // bt_Export_ProbabilityofFalseIdentification_CalibrationVehicle
            // 
            this.bt_Export_ProbabilityofFalseIdentification_CalibrationVehicle.Location = new System.Drawing.Point(358, 578);
            this.bt_Export_ProbabilityofFalseIdentification_CalibrationVehicle.Name = "bt_Export_ProbabilityofFalseIdentification_CalibrationVehicle";
            this.bt_Export_ProbabilityofFalseIdentification_CalibrationVehicle.Size = new System.Drawing.Size(104, 33);
            this.bt_Export_ProbabilityofFalseIdentification_CalibrationVehicle.TabIndex = 47;
            this.bt_Export_ProbabilityofFalseIdentification_CalibrationVehicle.Text = "Export";
            this.bt_Export_ProbabilityofFalseIdentification_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_Export_ProbabilityofFalseIdentification_CalibrationVehicle.Click += new System.EventHandler(this.bt_Export_ProbabilityofFalseIdentification_CalibrationVehicle_Click);
            // 
            // bt_Export_ProbabilityofFalseDetection_CalibrationVehicle
            // 
            this.bt_Export_ProbabilityofFalseDetection_CalibrationVehicle.Location = new System.Drawing.Point(358, 539);
            this.bt_Export_ProbabilityofFalseDetection_CalibrationVehicle.Name = "bt_Export_ProbabilityofFalseDetection_CalibrationVehicle";
            this.bt_Export_ProbabilityofFalseDetection_CalibrationVehicle.Size = new System.Drawing.Size(104, 33);
            this.bt_Export_ProbabilityofFalseDetection_CalibrationVehicle.TabIndex = 46;
            this.bt_Export_ProbabilityofFalseDetection_CalibrationVehicle.Text = "Export";
            this.bt_Export_ProbabilityofFalseDetection_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_Export_ProbabilityofFalseDetection_CalibrationVehicle.Click += new System.EventHandler(this.bt_Export_ProbabilityofFalseDetection_CalibrationVehicle_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bt_Map, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_Performances, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(558, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1292, 54);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // bt_Map
            // 
            this.bt_Map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Map.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Map.Location = new System.Drawing.Point(153, 3);
            this.bt_Map.Name = "bt_Map";
            this.bt_Map.Size = new System.Drawing.Size(144, 48);
            this.bt_Map.TabIndex = 1;
            this.bt_Map.Text = "Map";
            this.bt_Map.UseVisualStyleBackColor = true;
            this.bt_Map.Click += new System.EventHandler(this.bt_Map_Click);
            // 
            // bt_Performances
            // 
            this.bt_Performances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Performances.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Performances.Location = new System.Drawing.Point(3, 3);
            this.bt_Performances.Name = "bt_Performances";
            this.bt_Performances.Size = new System.Drawing.Size(144, 48);
            this.bt_Performances.TabIndex = 0;
            this.bt_Performances.Text = "Performances";
            this.bt_Performances.UseVisualStyleBackColor = true;
            this.bt_Performances.Click += new System.EventHandler(this.bt_Performances_Click);
            // 
            // ED2_MLAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1877, 1041);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ED2_MLAT";
            this.Text = "ED2";
            this.Load += new System.EventHandler(this.ED2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_Mapa.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button bt_Export_UpdateRate_ASTERIXfile;
        private System.Windows.Forms.Button bt_Export_ProbabilityofUpdate_ASTERIXfile;
        private System.Windows.Forms.Button bt_Export_PrecissionAccuracy_ASTERIXfile;
        private System.Windows.Forms.Button bt_Export_ProbabilityofMLATDetection_ASTERIXfile;
        private System.Windows.Forms.Button bt_Export_ProbabilityofIdentification_ASTERIXfile;
        private System.Windows.Forms.Button bt_Export_ProbabilityofFalseDetection_ASTERIXfile;
        private System.Windows.Forms.Button bt_Export_ProbabilityofFalseIdentification_ASTERIXfile;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_Mapa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_Map;
        private System.Windows.Forms.Button bt_Performances;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.CheckBox cb_ShowAirportZones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_ColorbyAirportZone;
        private System.Windows.Forms.RadioButton rb_ColorbyGB;
        private System.Windows.Forms.RadioButton rb_allsamecolor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_plotCalVehiclefromTEXTfile;
        private System.Windows.Forms.RadioButton rb_PlotCalVehiclefromASTfile;
        private System.Windows.Forms.RadioButton rb_PlotAllfromASTERIXfile;
        private System.Windows.Forms.Button bt_Export_ProbabilityofUpdate_CalibrationVehicle;
        private System.Windows.Forms.Button bt_Export_PrecissionAccuracy_CalibrationVehicle;
        private System.Windows.Forms.Button bt_Export_ProbabilityofIdentification_CalibrationVehicle;
        private System.Windows.Forms.Button bt_Export_ProbabilityofFalseIdentification_CalibrationVehicle;
        private System.Windows.Forms.Button bt_Export_ProbabilityofFalseDetection_CalibrationVehicle;
        private System.Windows.Forms.Button bt_Export_ProbabilityofMLATDetection_CalibrationVehicle;
    }
}