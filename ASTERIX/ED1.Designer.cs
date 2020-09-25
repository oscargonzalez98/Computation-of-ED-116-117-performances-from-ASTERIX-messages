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
            this.bt_CalculateUpdateRate = new System.Windows.Forms.Button();
            this.pb_UpdateRate = new System.Windows.Forms.ProgressBar();
            this.bt_ShowResultsUpdateRate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_CalculateUpdateRate
            // 
            this.bt_CalculateUpdateRate.Location = new System.Drawing.Point(51, 64);
            this.bt_CalculateUpdateRate.Name = "bt_CalculateUpdateRate";
            this.bt_CalculateUpdateRate.Size = new System.Drawing.Size(186, 30);
            this.bt_CalculateUpdateRate.TabIndex = 0;
            this.bt_CalculateUpdateRate.Text = "Calculate Update Rate";
            this.bt_CalculateUpdateRate.UseVisualStyleBackColor = true;
            this.bt_CalculateUpdateRate.Click += new System.EventHandler(this.bt_CalculateUpdateRate_Click);
            // 
            // pb_UpdateRate
            // 
            this.pb_UpdateRate.Location = new System.Drawing.Point(281, 64);
            this.pb_UpdateRate.Name = "pb_UpdateRate";
            this.pb_UpdateRate.Size = new System.Drawing.Size(481, 30);
            this.pb_UpdateRate.TabIndex = 1;
            // 
            // bt_ShowResultsUpdateRate
            // 
            this.bt_ShowResultsUpdateRate.Location = new System.Drawing.Point(817, 64);
            this.bt_ShowResultsUpdateRate.Name = "bt_ShowResultsUpdateRate";
            this.bt_ShowResultsUpdateRate.Size = new System.Drawing.Size(186, 30);
            this.bt_ShowResultsUpdateRate.TabIndex = 2;
            this.bt_ShowResultsUpdateRate.Text = "Show Results";
            this.bt_ShowResultsUpdateRate.UseVisualStyleBackColor = true;
            this.bt_ShowResultsUpdateRate.Click += new System.EventHandler(this.bt_ShowResultsUpdateRate_Click);
            // 
            // ED1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 780);
            this.Controls.Add(this.bt_ShowResultsUpdateRate);
            this.Controls.Add(this.pb_UpdateRate);
            this.Controls.Add(this.bt_CalculateUpdateRate);
            this.Name = "ED1";
            this.Text = "ED1";
            this.Load += new System.EventHandler(this.ED1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_CalculateUpdateRate;
        private System.Windows.Forms.ProgressBar pb_UpdateRate;
        private System.Windows.Forms.Button bt_ShowResultsUpdateRate;
    }
}