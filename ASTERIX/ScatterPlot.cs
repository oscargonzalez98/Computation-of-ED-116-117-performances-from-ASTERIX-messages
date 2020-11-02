using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBRERIACLASES;

namespace ASTERIX
{
    public partial class ScatterPlot : Form
    {
        double[] vXAxis;
        double[] vYAxis;

        string Title;
        string Xaxis;
        string Yaxis;

        public ScatterPlot(List<double> xAxis, List<double> yAxis, string Title, string Xaxis, string Yaxis)
        {
            InitializeComponent();

            this.vXAxis = xAxis.ToArray();
            this.vYAxis = yAxis.ToArray();
            this.Title = Title;
            this.Xaxis = Xaxis;
            this.Yaxis = Yaxis;
        }

        private void PlotForm_Load(object sender, EventArgs e)
        {
            formsPlot1.plt.PlotScatter(vXAxis, vYAxis, lineWidth: 0);
            formsPlot1.plt.Title(Title);
            formsPlot1.plt.XLabel(Xaxis);
            formsPlot1.plt.YLabel(Yaxis);
            formsPlot1.Render();
        }
    }
}
