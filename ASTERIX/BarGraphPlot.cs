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
    public partial class BarGraphPlot : Form
    {

        List<IndividualBar> listbars = new List<IndividualBar>();

        public BarGraphPlot(List<IndividualBar> listbars)
        {
            InitializeComponent();
            this.listbars = listbars;
        }

        private void BarGraphPlot_Load(object sender, EventArgs e)
        {
            List<IndividualBar> listbars1 = listbars.OrderBy(o => o.AverageTime).ToList();
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.Series["Series1"].IsValueShownAsLabel = true;

            for (int i =0; i< listbars1.Count(); i++)
            {
                if (listbars1[i].TargetIdentification.Length > 0) { chart1.Series["Series1"].Points.AddXY(listbars1[i].TargetIdentification, listbars1[i].AverageTime); }
                else { chart1.Series["Series1"].Points.AddXY(listbars1[i].TargetAddress, listbars1[i].AverageTime); }
            }
        }
    }
}
