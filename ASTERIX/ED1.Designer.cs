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
            this.bt_CalculateUpdateRate = new System.Windows.Forms.Button();
            this.bt_ShowResultsUpdateRate = new System.Windows.Forms.Button();
            this.pb_ProbabilityofUpdate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bt_PrecissionAccuracy = new System.Windows.Forms.Button();
            this.Mapa = new GMap.NET.WindowsForms.GMapControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_MLATDetection = new System.Windows.Forms.Button();
            this.bt_ProbofIdentification = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_CalculateUpdateRate
            // 
            this.bt_CalculateUpdateRate.Location = new System.Drawing.Point(3, 3);
            this.bt_CalculateUpdateRate.Name = "bt_CalculateUpdateRate";
            this.bt_CalculateUpdateRate.Size = new System.Drawing.Size(181, 44);
            this.bt_CalculateUpdateRate.TabIndex = 0;
            this.bt_CalculateUpdateRate.Text = "Calculate Update Rate";
            this.bt_CalculateUpdateRate.UseVisualStyleBackColor = true;
            this.bt_CalculateUpdateRate.Click += new System.EventHandler(this.bt_CalculateUpdateRate_Click);
            // 
            // bt_ShowResultsUpdateRate
            // 
            this.bt_ShowResultsUpdateRate.Location = new System.Drawing.Point(564, 3);
            this.bt_ShowResultsUpdateRate.Name = "bt_ShowResultsUpdateRate";
            this.bt_ShowResultsUpdateRate.Size = new System.Drawing.Size(181, 44);
            this.bt_ShowResultsUpdateRate.TabIndex = 2;
            this.bt_ShowResultsUpdateRate.Text = "Show Results";
            this.bt_ShowResultsUpdateRate.UseVisualStyleBackColor = true;
            this.bt_ShowResultsUpdateRate.Click += new System.EventHandler(this.bt_ShowResultsUpdateRate_Click);
            // 
            // pb_ProbabilityofUpdate
            // 
            this.pb_ProbabilityofUpdate.Location = new System.Drawing.Point(3, 53);
            this.pb_ProbabilityofUpdate.Name = "pb_ProbabilityofUpdate";
            this.pb_ProbabilityofUpdate.Size = new System.Drawing.Size(181, 44);
            this.pb_ProbabilityofUpdate.TabIndex = 3;
            this.pb_ProbabilityofUpdate.Text = "Calculate Probability of Update";
            this.pb_ProbabilityofUpdate.UseVisualStyleBackColor = true;
            this.pb_ProbabilityofUpdate.Click += new System.EventHandler(this.pb_ProbabilityofUpdate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bt_PrecissionAccuracy
            // 
            this.bt_PrecissionAccuracy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_PrecissionAccuracy.Location = new System.Drawing.Point(3, 103);
            this.bt_PrecissionAccuracy.Name = "bt_PrecissionAccuracy";
            this.bt_PrecissionAccuracy.Size = new System.Drawing.Size(181, 44);
            this.bt_PrecissionAccuracy.TabIndex = 6;
            this.bt_PrecissionAccuracy.Text = "Calculate PrecissionAccuracy";
            this.bt_PrecissionAccuracy.UseVisualStyleBackColor = true;
            this.bt_PrecissionAccuracy.Click += new System.EventHandler(this.bt_PrecissionAccuracy_Click);
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
            this.Mapa.Location = new System.Drawing.Point(751, 3);
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
            this.tableLayoutPanel1.SetRowSpan(this.Mapa, 6);
            this.Mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Mapa.ShowTileGridLines = false;
            this.Mapa.Size = new System.Drawing.Size(931, 1031);
            this.Mapa.TabIndex = 7;
            this.Mapa.Zoom = 0D;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.Controls.Add(this.Mapa, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_PrecissionAccuracy, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_CalculateUpdateRate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_ShowResultsUpdateRate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pb_ProbabilityofUpdate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_MLATDetection, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt_ProbofIdentification, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1685, 1037);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // bt_MLATDetection
            // 
            this.bt_MLATDetection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_MLATDetection.Location = new System.Drawing.Point(3, 153);
            this.bt_MLATDetection.Name = "bt_MLATDetection";
            this.bt_MLATDetection.Size = new System.Drawing.Size(181, 44);
            this.bt_MLATDetection.TabIndex = 8;
            this.bt_MLATDetection.Text = "Calculate MLAT Detection Probability";
            this.bt_MLATDetection.UseVisualStyleBackColor = true;
            this.bt_MLATDetection.Click += new System.EventHandler(this.bt_MLATDetection_Click);
            // 
            // bt_ProbofIdentification
            // 
            this.bt_ProbofIdentification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ProbofIdentification.Location = new System.Drawing.Point(3, 203);
            this.bt_ProbofIdentification.Name = "bt_ProbofIdentification";
            this.bt_ProbofIdentification.Size = new System.Drawing.Size(181, 44);
            this.bt_ProbofIdentification.TabIndex = 9;
            this.bt_ProbofIdentification.Text = "Calculate Probability of Identification";
            this.bt_ProbofIdentification.UseVisualStyleBackColor = true;
            this.bt_ProbofIdentification.Click += new System.EventHandler(this.bt_ProbofIdentification_Click);
            // 
            // ED1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 1061);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ED1";
            this.Text = "ED1";
            this.Load += new System.EventHandler(this.ED1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_CalculateUpdateRate;
        private System.Windows.Forms.Button bt_ShowResultsUpdateRate;
        private System.Windows.Forms.Button pb_ProbabilityofUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bt_PrecissionAccuracy;
        private GMap.NET.WindowsForms.GMapControl Mapa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_MLATDetection;
        private System.Windows.Forms.Button bt_ProbofIdentification;
    }
}