
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_Mapa = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Mapa = new GMap.NET.WindowsForms.GMapControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShowDistancesPA = new System.Windows.Forms.Button();
            this.bt_SaveMapImage = new System.Windows.Forms.Button();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_CalculateDataRenewalRateTest_ED116_CalibrationVehicle = new System.Windows.Forms.Button();
            this.pb_DetectionSensitivityTest_ED116_CalibrationVehicle = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bt_ShowTrajectory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Trajectories = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_CalculatePositionAccuracyTest_ED116_CalibrationVehicle = new System.Windows.Forms.Button();
            this.tb_CalibrationVehicleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_CalculatePositionAccuracyTest_ED116_ASTERIXfile = new System.Windows.Forms.Button();
            this.pb_DetectionSensitivityTest_ED116_ASTERIXfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_CalculateFalseTargetReportTest_ED116_ASTERIXfile = new System.Windows.Forms.Button();
            this.bt_CalculateDataRenewalRateTest_ED116_ASTERIXfile = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Map = new System.Windows.Forms.Button();
            this.bt_Performances = new System.Windows.Forms.Button();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_CalculateTrajectories_Aircraft = new System.Windows.Forms.Button();
            this.bt_CalculateTrajectories_GroundVehicles = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_Mapa.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1904, 1041);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_Mapa);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(574, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1327, 975);
            this.panel3.TabIndex = 1;
            // 
            // panel_Mapa
            // 
            this.panel_Mapa.Controls.Add(this.tableLayoutPanel3);
            this.panel_Mapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Mapa.Location = new System.Drawing.Point(0, 0);
            this.panel_Mapa.Name = "panel_Mapa";
            this.panel_Mapa.Size = new System.Drawing.Size(1327, 975);
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
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1321, 969);
            this.tableLayoutPanel3.TabIndex = 0;
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
            this.Mapa.Location = new System.Drawing.Point(3, 148);
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
            this.Mapa.Size = new System.Drawing.Size(1315, 818);
            this.Mapa.TabIndex = 0;
            this.Mapa.Zoom = 0D;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ShowDistancesPA);
            this.panel2.Controls.Add(this.bt_SaveMapImage);
            this.panel2.Controls.Add(this.bt_Update);
            this.panel2.Controls.Add(this.cb_ShowAirportZones);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 139);
            this.panel2.TabIndex = 1;
            // 
            // ShowDistancesPA
            // 
            this.ShowDistancesPA.Location = new System.Drawing.Point(729, 76);
            this.ShowDistancesPA.Name = "ShowDistancesPA";
            this.ShowDistancesPA.Size = new System.Drawing.Size(156, 43);
            this.ShowDistancesPA.TabIndex = 9;
            this.ShowDistancesPA.Text = "Show Position Accuracy Distances from Calibration Vehicle\r\n";
            this.ShowDistancesPA.UseVisualStyleBackColor = true;
            this.ShowDistancesPA.Visible = false;
            this.ShowDistancesPA.Click += new System.EventHandler(this.ShowDistancesPA_Click);
            // 
            // bt_SaveMapImage
            // 
            this.bt_SaveMapImage.Location = new System.Drawing.Point(891, 27);
            this.bt_SaveMapImage.Name = "bt_SaveMapImage";
            this.bt_SaveMapImage.Size = new System.Drawing.Size(156, 42);
            this.bt_SaveMapImage.TabIndex = 6;
            this.bt_SaveMapImage.Text = "Save Map Image";
            this.bt_SaveMapImage.UseVisualStyleBackColor = true;
            this.bt_SaveMapImage.Click += new System.EventHandler(this.bt_SaveMapImage_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(729, 28);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(156, 42);
            this.bt_Update.TabIndex = 5;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1327, 975);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bt_CalculateDataRenewalRateTest_ED116_CalibrationVehicle);
            this.panel4.Controls.Add(this.pb_DetectionSensitivityTest_ED116_CalibrationVehicle);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.bt_CalculatePositionAccuracyTest_ED116_CalibrationVehicle);
            this.panel4.Controls.Add(this.tb_CalibrationVehicleName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.bt_CalculatePositionAccuracyTest_ED116_ASTERIXfile);
            this.panel4.Controls.Add(this.pb_DetectionSensitivityTest_ED116_ASTERIXfile);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.bt_CalculateFalseTargetReportTest_ED116_ASTERIXfile);
            this.panel4.Controls.Add(this.bt_CalculateDataRenewalRateTest_ED116_ASTERIXfile);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(565, 975);
            this.panel4.TabIndex = 0;
            // 
            // bt_CalculateDataRenewalRateTest_ED116_CalibrationVehicle
            // 
            this.bt_CalculateDataRenewalRateTest_ED116_CalibrationVehicle.Location = new System.Drawing.Point(33, 482);
            this.bt_CalculateDataRenewalRateTest_ED116_CalibrationVehicle.Name = "bt_CalculateDataRenewalRateTest_ED116_CalibrationVehicle";
            this.bt_CalculateDataRenewalRateTest_ED116_CalibrationVehicle.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateDataRenewalRateTest_ED116_CalibrationVehicle.TabIndex = 60;
            this.bt_CalculateDataRenewalRateTest_ED116_CalibrationVehicle.Text = "Calculate Data Renewal Rate Test";
            this.bt_CalculateDataRenewalRateTest_ED116_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_CalculateDataRenewalRateTest_ED116_CalibrationVehicle.Click += new System.EventHandler(this.bt_CalculateDataRenewalRateTest_ED116_CalibrationVehicle_Click);
            // 
            // pb_DetectionSensitivityTest_ED116_CalibrationVehicle
            // 
            this.pb_DetectionSensitivityTest_ED116_CalibrationVehicle.Location = new System.Drawing.Point(33, 443);
            this.pb_DetectionSensitivityTest_ED116_CalibrationVehicle.Name = "pb_DetectionSensitivityTest_ED116_CalibrationVehicle";
            this.pb_DetectionSensitivityTest_ED116_CalibrationVehicle.Size = new System.Drawing.Size(223, 33);
            this.pb_DetectionSensitivityTest_ED116_CalibrationVehicle.TabIndex = 59;
            this.pb_DetectionSensitivityTest_ED116_CalibrationVehicle.Text = "Calculate Detection Sensitivity Test";
            this.pb_DetectionSensitivityTest_ED116_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.pb_DetectionSensitivityTest_ED116_CalibrationVehicle.Click += new System.EventHandler(this.pb_DetectionSensitivityTest_ED116_CalibrationVehicle_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bt_ShowTrajectory);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.lb_Trajectories);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Location = new System.Drawing.Point(33, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(498, 122);
            this.panel5.TabIndex = 58;
            this.panel5.Visible = false;
            // 
            // bt_ShowTrajectory
            // 
            this.bt_ShowTrajectory.Location = new System.Drawing.Point(198, 68);
            this.bt_ShowTrajectory.Name = "bt_ShowTrajectory";
            this.bt_ShowTrajectory.Size = new System.Drawing.Size(231, 23);
            this.bt_ShowTrajectory.TabIndex = 58;
            this.bt_ShowTrajectory.Text = "Show Trajectory";
            this.bt_ShowTrajectory.UseVisualStyleBackColor = true;
            this.bt_ShowTrajectory.Click += new System.EventHandler(this.bt_ShowTrajectory_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Plot MLAT and SMR paths of a trajectory:";
            // 
            // lb_Trajectories
            // 
            this.lb_Trajectories.AutoSize = true;
            this.lb_Trajectories.Location = new System.Drawing.Point(18, 44);
            this.lb_Trajectories.Name = "lb_Trajectories";
            this.lb_Trajectories.Size = new System.Drawing.Size(35, 13);
            this.lb_Trajectories.TabIndex = 57;
            this.lb_Trajectories.Text = "label5";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 51;
            // 
            // bt_CalculatePositionAccuracyTest_ED116_CalibrationVehicle
            // 
            this.bt_CalculatePositionAccuracyTest_ED116_CalibrationVehicle.Location = new System.Drawing.Point(33, 521);
            this.bt_CalculatePositionAccuracyTest_ED116_CalibrationVehicle.Name = "bt_CalculatePositionAccuracyTest_ED116_CalibrationVehicle";
            this.bt_CalculatePositionAccuracyTest_ED116_CalibrationVehicle.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculatePositionAccuracyTest_ED116_CalibrationVehicle.TabIndex = 54;
            this.bt_CalculatePositionAccuracyTest_ED116_CalibrationVehicle.Text = "Calculate Position Accuracy Test";
            this.bt_CalculatePositionAccuracyTest_ED116_CalibrationVehicle.UseVisualStyleBackColor = true;
            this.bt_CalculatePositionAccuracyTest_ED116_CalibrationVehicle.Click += new System.EventHandler(this.bt_CalculatePositionAccuracyTest_ED116_CalibrationVehicle_Click);
            // 
            // tb_CalibrationVehicleName
            // 
            this.tb_CalibrationVehicleName.Location = new System.Drawing.Point(339, 407);
            this.tb_CalibrationVehicleName.Name = "tb_CalibrationVehicleName";
            this.tb_CalibrationVehicleName.Size = new System.Drawing.Size(100, 20);
            this.tb_CalibrationVehicleName.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Calibration Vehicle Target Identification:";
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
            this.comboBox1.Location = new System.Drawing.Point(262, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 21);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.Text = "0 (or > 20 NM)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Calculated ED-116 Parameters from ASTERIX File:";
            // 
            // bt_CalculatePositionAccuracyTest_ED116_ASTERIXfile
            // 
            this.bt_CalculatePositionAccuracyTest_ED116_ASTERIXfile.Location = new System.Drawing.Point(33, 296);
            this.bt_CalculatePositionAccuracyTest_ED116_ASTERIXfile.Name = "bt_CalculatePositionAccuracyTest_ED116_ASTERIXfile";
            this.bt_CalculatePositionAccuracyTest_ED116_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculatePositionAccuracyTest_ED116_ASTERIXfile.TabIndex = 25;
            this.bt_CalculatePositionAccuracyTest_ED116_ASTERIXfile.Text = "Calculate Position Accuracy Test";
            this.bt_CalculatePositionAccuracyTest_ED116_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_CalculatePositionAccuracyTest_ED116_ASTERIXfile.Click += new System.EventHandler(this.bt_CalculatePositionAccuracyTest_ED116_ASTERIXfile_Click);
            // 
            // pb_DetectionSensitivityTest_ED116_ASTERIXfile
            // 
            this.pb_DetectionSensitivityTest_ED116_ASTERIXfile.Location = new System.Drawing.Point(33, 179);
            this.pb_DetectionSensitivityTest_ED116_ASTERIXfile.Name = "pb_DetectionSensitivityTest_ED116_ASTERIXfile";
            this.pb_DetectionSensitivityTest_ED116_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.pb_DetectionSensitivityTest_ED116_ASTERIXfile.TabIndex = 13;
            this.pb_DetectionSensitivityTest_ED116_ASTERIXfile.Text = "Calculate Detection Sensitivity Test";
            this.pb_DetectionSensitivityTest_ED116_ASTERIXfile.UseVisualStyleBackColor = true;
            this.pb_DetectionSensitivityTest_ED116_ASTERIXfile.Click += new System.EventHandler(this.pb_DetectionSensitivityTest_ED116_ASTERIXfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Calculated ED-116 Parameters from Calibration Vehicle File:";
            // 
            // bt_CalculateFalseTargetReportTest_ED116_ASTERIXfile
            // 
            this.bt_CalculateFalseTargetReportTest_ED116_ASTERIXfile.Location = new System.Drawing.Point(33, 257);
            this.bt_CalculateFalseTargetReportTest_ED116_ASTERIXfile.Name = "bt_CalculateFalseTargetReportTest_ED116_ASTERIXfile";
            this.bt_CalculateFalseTargetReportTest_ED116_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateFalseTargetReportTest_ED116_ASTERIXfile.TabIndex = 15;
            this.bt_CalculateFalseTargetReportTest_ED116_ASTERIXfile.Text = "Calculate False Target Report Test";
            this.bt_CalculateFalseTargetReportTest_ED116_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_CalculateFalseTargetReportTest_ED116_ASTERIXfile.Click += new System.EventHandler(this.bt_CalculateFalseTargetReportTest_ED116_ASTERIXfile_Click);
            // 
            // bt_CalculateDataRenewalRateTest_ED116_ASTERIXfile
            // 
            this.bt_CalculateDataRenewalRateTest_ED116_ASTERIXfile.Location = new System.Drawing.Point(33, 218);
            this.bt_CalculateDataRenewalRateTest_ED116_ASTERIXfile.Name = "bt_CalculateDataRenewalRateTest_ED116_ASTERIXfile";
            this.bt_CalculateDataRenewalRateTest_ED116_ASTERIXfile.Size = new System.Drawing.Size(223, 33);
            this.bt_CalculateDataRenewalRateTest_ED116_ASTERIXfile.TabIndex = 14;
            this.bt_CalculateDataRenewalRateTest_ED116_ASTERIXfile.Text = "Calculate Data Renewal Rate Test";
            this.bt_CalculateDataRenewalRateTest_ED116_ASTERIXfile.UseVisualStyleBackColor = true;
            this.bt_CalculateDataRenewalRateTest_ED116_ASTERIXfile.Click += new System.EventHandler(this.bt_CalculateDataRenewalRateTest_ED116_ASTERIXfile_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.bt_Map, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.bt_Performances, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.progressbar, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(574, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1327, 54);
            this.tableLayoutPanel4.TabIndex = 2;
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
            // progressbar
            // 
            this.progressbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressbar.Location = new System.Drawing.Point(303, 3);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(1021, 48);
            this.progressbar.TabIndex = 2;
            this.progressbar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 54);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.bt_CalculateTrajectories_Aircraft, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_CalculateTrajectories_GroundVehicles, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(565, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bt_CalculateTrajectories_Aircraft
            // 
            this.bt_CalculateTrajectories_Aircraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_CalculateTrajectories_Aircraft.Location = new System.Drawing.Point(33, 3);
            this.bt_CalculateTrajectories_Aircraft.Name = "bt_CalculateTrajectories_Aircraft";
            this.bt_CalculateTrajectories_Aircraft.Size = new System.Drawing.Size(231, 48);
            this.bt_CalculateTrajectories_Aircraft.TabIndex = 0;
            this.bt_CalculateTrajectories_Aircraft.Text = "Calculate Aircraft Trajectories\r\n(including Calibration Veicle)";
            this.bt_CalculateTrajectories_Aircraft.UseVisualStyleBackColor = true;
            this.bt_CalculateTrajectories_Aircraft.Click += new System.EventHandler(this.bt_CalculateTrajectories_Aircraft_Click);
            // 
            // bt_CalculateTrajectories_GroundVehicles
            // 
            this.bt_CalculateTrajectories_GroundVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_CalculateTrajectories_GroundVehicles.Location = new System.Drawing.Point(300, 3);
            this.bt_CalculateTrajectories_GroundVehicles.Name = "bt_CalculateTrajectories_GroundVehicles";
            this.bt_CalculateTrajectories_GroundVehicles.Size = new System.Drawing.Size(231, 48);
            this.bt_CalculateTrajectories_GroundVehicles.TabIndex = 1;
            this.bt_CalculateTrajectories_GroundVehicles.Text = "Calculate Ground Vehicle Trajectories";
            this.bt_CalculateTrajectories_GroundVehicles.UseVisualStyleBackColor = true;
            this.bt_CalculateTrajectories_GroundVehicles.Visible = false;
            this.bt_CalculateTrajectories_GroundVehicles.Click += new System.EventHandler(this.bt_CalculateTrajectories_GroundVehicles_Click);
            // 
            // ED_SMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ED_SMR";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ED_SMR_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_Mapa.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_Mapa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private GMap.NET.WindowsForms.GMapControl Mapa;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_CalculatePositionAccuracyTest_ED116_ASTERIXfile;
        private System.Windows.Forms.Button pb_DetectionSensitivityTest_ED116_ASTERIXfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_CalculateFalseTargetReportTest_ED116_ASTERIXfile;
        private System.Windows.Forms.Button bt_CalculateDataRenewalRateTest_ED116_ASTERIXfile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button bt_Map;
        private System.Windows.Forms.Button bt_Performances;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_SaveMapImage;
        private System.Windows.Forms.TextBox tb_CalibrationVehicleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.Button bt_CalculatePositionAccuracyTest_ED116_CalibrationVehicle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_CalculateTrajectories_Aircraft;
        private System.Windows.Forms.Button bt_CalculateTrajectories_GroundVehicles;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Trajectories;
        private System.Windows.Forms.Button bt_ShowTrajectory;
        private System.Windows.Forms.Button ShowDistancesPA;
        private System.Windows.Forms.Button pb_DetectionSensitivityTest_ED116_CalibrationVehicle;
        private System.Windows.Forms.Button bt_CalculateDataRenewalRateTest_ED116_CalibrationVehicle;
    }
}