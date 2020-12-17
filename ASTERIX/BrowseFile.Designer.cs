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
            this.bt_SelectFile = new System.Windows.Forms.Button();
            this.tbDirection = new System.Windows.Forms.TextBox();
            this.bt_Decode = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblError = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pb_ASTERIXfile = new System.Windows.Forms.PictureBox();
            this.pb_CalibrationVehicle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ASTERIXfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CalibrationVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_SelectFile
            // 
            this.bt_SelectFile.Location = new System.Drawing.Point(305, 790);
            this.bt_SelectFile.Margin = new System.Windows.Forms.Padding(2);
            this.bt_SelectFile.Name = "bt_SelectFile";
            this.bt_SelectFile.Size = new System.Drawing.Size(126, 26);
            this.bt_SelectFile.TabIndex = 0;
            this.bt_SelectFile.Text = "Select File";
            this.bt_SelectFile.UseVisualStyleBackColor = true;
            this.bt_SelectFile.Click += new System.EventHandler(this.bt_SelectFile_Click);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(441, 793);
            this.tbDirection.Margin = new System.Windows.Forms.Padding(2);
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(327, 20);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.TextChanged += new System.EventHandler(this.tbDirection_TextChanged);
            // 
            // bt_Decode
            // 
            this.bt_Decode.Location = new System.Drawing.Point(783, 786);
            this.bt_Decode.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Decode.Name = "bt_Decode";
            this.bt_Decode.Size = new System.Drawing.Size(98, 35);
            this.bt_Decode.TabIndex = 2;
            this.bt_Decode.Text = "Decode";
            this.bt_Decode.UseVisualStyleBackColor = true;
            this.bt_Decode.Click += new System.EventHandler(this.bt_Decode_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.White;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblError.Location = new System.Drawing.Point(560, 825);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(86, 31);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "label1";
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
            this.progressBar1.Location = new System.Drawing.Point(441, 880);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(327, 28);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // pb_ASTERIXfile
            // 
            this.pb_ASTERIXfile.Image = ((System.Drawing.Image)(resources.GetObject("pb_ASTERIXfile.Image")));
            this.pb_ASTERIXfile.Location = new System.Drawing.Point(103, 47);
            this.pb_ASTERIXfile.Name = "pb_ASTERIXfile";
            this.pb_ASTERIXfile.Size = new System.Drawing.Size(543, 535);
            this.pb_ASTERIXfile.TabIndex = 5;
            this.pb_ASTERIXfile.TabStop = false;
            this.pb_ASTERIXfile.Click += new System.EventHandler(this.pb_ASTERIXfile_Click);
            // 
            // pb_CalibrationVehicle
            // 
            this.pb_CalibrationVehicle.Image = ((System.Drawing.Image)(resources.GetObject("pb_CalibrationVehicle.Image")));
            this.pb_CalibrationVehicle.Location = new System.Drawing.Point(748, 47);
            this.pb_CalibrationVehicle.Name = "pb_CalibrationVehicle";
            this.pb_CalibrationVehicle.Size = new System.Drawing.Size(543, 535);
            this.pb_CalibrationVehicle.TabIndex = 6;
            this.pb_CalibrationVehicle.TabStop = false;
            this.pb_CalibrationVehicle.Click += new System.EventHandler(this.pb_CalibrationVehicle_Click);
            // 
            // BrowseFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 940);
            this.Controls.Add(this.pb_CalibrationVehicle);
            this.Controls.Add(this.pb_ASTERIXfile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.bt_Decode);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.bt_SelectFile);
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

        private System.Windows.Forms.Button bt_SelectFile;
        private System.Windows.Forms.TextBox tbDirection;
        private System.Windows.Forms.Button bt_Decode;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pb_ASTERIXfile;
        private System.Windows.Forms.PictureBox pb_CalibrationVehicle;
    }
}