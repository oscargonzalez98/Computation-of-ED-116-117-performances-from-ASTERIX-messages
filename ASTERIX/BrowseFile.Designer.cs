namespace ASTERIX
{
    partial class BrowseFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseFile));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pb_ASTERIXfile = new System.Windows.Forms.PictureBox();
            this.pb_CalibrationVehicle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lb_PacketsDecoded = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_CAT21 = new System.Windows.Forms.Label();
            this.lb_MLAT = new System.Windows.Forms.Label();
            this.lb_SMR = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_dgps = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ASTERIXfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CalibrationVehicle)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.White;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbTitle.Location = new System.Drawing.Point(24, 80);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(109, 39);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(98, 824);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1192, 28);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // pb_ASTERIXfile
            // 
            this.pb_ASTERIXfile.Image = ((System.Drawing.Image)(resources.GetObject("pb_ASTERIXfile.Image")));
            this.pb_ASTERIXfile.Location = new System.Drawing.Point(115, 119);
            this.pb_ASTERIXfile.Name = "pb_ASTERIXfile";
            this.pb_ASTERIXfile.Size = new System.Drawing.Size(259, 287);
            this.pb_ASTERIXfile.TabIndex = 5;
            this.pb_ASTERIXfile.TabStop = false;
            this.pb_ASTERIXfile.Click += new System.EventHandler(this.pb_ASTERIXfile_Click);
            // 
            // pb_CalibrationVehicle
            // 
            this.pb_CalibrationVehicle.Image = ((System.Drawing.Image)(resources.GetObject("pb_CalibrationVehicle.Image")));
            this.pb_CalibrationVehicle.Location = new System.Drawing.Point(108, 478);
            this.pb_CalibrationVehicle.Name = "pb_CalibrationVehicle";
            this.pb_CalibrationVehicle.Size = new System.Drawing.Size(266, 287);
            this.pb_CalibrationVehicle.TabIndex = 6;
            this.pb_CalibrationVehicle.TabStop = false;
            this.pb_CalibrationVehicle.Click += new System.EventHandler(this.pb_CalibrationVehicle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Click To search for ASTERIX file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Click To search for Calibration Vehicle file";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.White;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblError.Location = new System.Drawing.Point(648, 872);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(86, 31);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "label1";
            // 
            // lb_PacketsDecoded
            // 
            this.lb_PacketsDecoded.AutoSize = true;
            this.lb_PacketsDecoded.Location = new System.Drawing.Point(105, 872);
            this.lb_PacketsDecoded.Name = "lb_PacketsDecoded";
            this.lb_PacketsDecoded.Size = new System.Drawing.Size(35, 13);
            this.lb_PacketsDecoded.TabIndex = 12;
            this.lb_PacketsDecoded.Text = "label3";
            this.lb_PacketsDecoded.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select the CAT 21 type contained in the ASTERIIX file:\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CAT 21 v2.1",
            "CAT 21 v0.23",
            "None"});
            this.comboBox1.Location = new System.Drawing.Point(525, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "CAT 21 v2.1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(848, 218);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.52381F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.47619F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 525);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.71233F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.28767F));
            this.tableLayoutPanel2.Controls.Add(this.lb_SMR, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_MLAT, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_CAT21, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(438, 91);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "CAT 21:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "MLAT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "SMR:";
            // 
            // lb_CAT21
            // 
            this.lb_CAT21.AutoSize = true;
            this.lb_CAT21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CAT21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CAT21.Location = new System.Drawing.Point(119, 0);
            this.lb_CAT21.Name = "lb_CAT21";
            this.lb_CAT21.Size = new System.Drawing.Size(316, 30);
            this.lb_CAT21.TabIndex = 4;
            this.lb_CAT21.Text = "CAT 21:";
            // 
            // lb_MLAT
            // 
            this.lb_MLAT.AutoSize = true;
            this.lb_MLAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_MLAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MLAT.Location = new System.Drawing.Point(119, 30);
            this.lb_MLAT.Name = "lb_MLAT";
            this.lb_MLAT.Size = new System.Drawing.Size(316, 30);
            this.lb_MLAT.TabIndex = 5;
            this.lb_MLAT.Text = "CAT 21:";
            // 
            // lb_SMR
            // 
            this.lb_SMR.AutoSize = true;
            this.lb_SMR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_SMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SMR.Location = new System.Drawing.Point(119, 60);
            this.lb_SMR.Name = "lb_SMR";
            this.lb_SMR.Size = new System.Drawing.Size(316, 31);
            this.lb_SMR.TabIndex = 6;
            this.lb_SMR.Text = "CAT 21:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.71233F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.28767F));
            this.tableLayoutPanel3.Controls.Add(this.lb_dgps, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 284);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(414, 91);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Visible = false;
            // 
            // lb_dgps
            // 
            this.lb_dgps.AutoSize = true;
            this.lb_dgps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_dgps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dgps.Location = new System.Drawing.Point(113, 0);
            this.lb_dgps.Name = "lb_dgps";
            this.lb_dgps.Size = new System.Drawing.Size(298, 91);
            this.lb_dgps.TabIndex = 4;
            this.lb_dgps.Text = "CAT 21:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 91);
            this.label10.TabIndex = 0;
            this.label10.Text = "D-GPS:";
            // 
            // BrowseFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_PacketsDecoded);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_CalibrationVehicle);
            this.Controls.Add(this.pb_ASTERIXfile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblError);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BrowseFile";
            this.Text = "BrowseFile";
            this.Load += new System.EventHandler(this.BrowseFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ASTERIXfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CalibrationVehicle)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pb_ASTERIXfile;
        private System.Windows.Forms.PictureBox pb_CalibrationVehicle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lb_PacketsDecoded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_SMR;
        private System.Windows.Forms.Label lb_MLAT;
        private System.Windows.Forms.Label lb_CAT21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lb_dgps;
        private System.Windows.Forms.Label label10;
    }
}