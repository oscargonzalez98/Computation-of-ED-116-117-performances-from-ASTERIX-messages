namespace ASTERIX
{
    partial class PlotProbabilityofUpdate
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.formsPlot_Apron = new ScottPlot.FormsPlot();
            this.formsPlot_Stand = new ScottPlot.FormsPlot();
            this.formsPlot_MA = new ScottPlot.FormsPlot();
            this.formsPlot_Airborne = new ScottPlot.FormsPlot();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.formsPlot_Apron, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.formsPlot_Stand, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.formsPlot_MA, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.formsPlot_Airborne, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1010, 635);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // formsPlot_Apron
            // 
            this.formsPlot_Apron.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot_Apron.Location = new System.Drawing.Point(3, 3);
            this.formsPlot_Apron.Name = "formsPlot_Apron";
            this.formsPlot_Apron.Size = new System.Drawing.Size(499, 311);
            this.formsPlot_Apron.TabIndex = 1;
            // 
            // formsPlot_Stand
            // 
            this.formsPlot_Stand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot_Stand.Location = new System.Drawing.Point(508, 3);
            this.formsPlot_Stand.Name = "formsPlot_Stand";
            this.formsPlot_Stand.Size = new System.Drawing.Size(499, 311);
            this.formsPlot_Stand.TabIndex = 2;
            // 
            // formsPlot_MA
            // 
            this.formsPlot_MA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot_MA.Location = new System.Drawing.Point(3, 320);
            this.formsPlot_MA.Name = "formsPlot_MA";
            this.formsPlot_MA.Size = new System.Drawing.Size(499, 312);
            this.formsPlot_MA.TabIndex = 3;
            // 
            // formsPlot_Airborne
            // 
            this.formsPlot_Airborne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot_Airborne.Location = new System.Drawing.Point(508, 320);
            this.formsPlot_Airborne.Name = "formsPlot_Airborne";
            this.formsPlot_Airborne.Size = new System.Drawing.Size(499, 312);
            this.formsPlot_Airborne.TabIndex = 4;
            // 
            // PlotProbabilityofUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 659);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PlotProbabilityofUpdate";
            this.Text = "PlotProbabilityofUpdate";
            this.Load += new System.EventHandler(this.PlotProbabilityofUpdate_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ScottPlot.FormsPlot formsPlot_Apron;
        private ScottPlot.FormsPlot formsPlot_Stand;
        private ScottPlot.FormsPlot formsPlot_MA;
        private ScottPlot.FormsPlot formsPlot_Airborne;
    }
}