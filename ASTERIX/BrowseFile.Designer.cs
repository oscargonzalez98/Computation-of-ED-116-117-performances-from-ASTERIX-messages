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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ASTERIXfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CalibrationVehicle)).BeginInit();
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
            this.progressBar1.Location = new System.Drawing.Point(103, 733);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1192, 28);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // pb_ASTERIXfile
            // 
            this.pb_ASTERIXfile.Image = ((System.Drawing.Image)(resources.GetObject("pb_ASTERIXfile.Image")));
            this.pb_ASTERIXfile.Location = new System.Drawing.Point(103, 82);
            this.pb_ASTERIXfile.Name = "pb_ASTERIXfile";
            this.pb_ASTERIXfile.Size = new System.Drawing.Size(543, 535);
            this.pb_ASTERIXfile.TabIndex = 5;
            this.pb_ASTERIXfile.TabStop = false;
            this.pb_ASTERIXfile.Click += new System.EventHandler(this.pb_ASTERIXfile_Click);
            // 
            // pb_CalibrationVehicle
            // 
            this.pb_CalibrationVehicle.Image = ((System.Drawing.Image)(resources.GetObject("pb_CalibrationVehicle.Image")));
            this.pb_CalibrationVehicle.Location = new System.Drawing.Point(752, 82);
            this.pb_CalibrationVehicle.Name = "pb_CalibrationVehicle";
            this.pb_CalibrationVehicle.Size = new System.Drawing.Size(543, 535);
            this.pb_CalibrationVehicle.TabIndex = 6;
            this.pb_CalibrationVehicle.TabStop = false;
            this.pb_CalibrationVehicle.Click += new System.EventHandler(this.pb_CalibrationVehicle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Click To search for ASTERIX file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(759, 19);
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
            this.lblError.Location = new System.Drawing.Point(653, 781);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(86, 31);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "label1";
            // 
            // lb_PacketsDecoded
            // 
            this.lb_PacketsDecoded.AutoSize = true;
            this.lb_PacketsDecoded.Location = new System.Drawing.Point(236, 699);
            this.lb_PacketsDecoded.Name = "lb_PacketsDecoded";
            this.lb_PacketsDecoded.Size = new System.Drawing.Size(35, 13);
            this.lb_PacketsDecoded.TabIndex = 12;
            this.lb_PacketsDecoded.Text = "label3";
            this.lb_PacketsDecoded.Visible = false;
            // 
            // BrowseFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 940);
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
    }
}