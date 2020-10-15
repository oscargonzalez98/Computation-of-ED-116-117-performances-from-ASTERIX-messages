using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using LIBRERIACLASES;

namespace ASTERIX
{
    public partial class BarPlotUpdateRate1 : Form
    {
        public List<IndividualBar> listaBars = new List<IndividualBar>();
        public BarPlotUpdateRate1(List<IndividualBar> listaBars)
        {
            InitializeComponent();
            this.listaBars = listaBars;
        }

        private void BarPlotUpdateRate1_Load(object sender, EventArgs e)
        {
            // 1. Calculate Percentiles

            double percentile95 = 0.95 * listaBars.Count();
            int percentile95_hight_position = Convert.ToInt32(Math.Floor(percentile95)); // cojemos el haigh porque es peor caso

            double percentile99 = 0.99 * listaBars.Count();
            int percentile99_hight_position = Convert.ToInt32(Math.Floor(percentile99));

            listaBars = listaBars.OrderBy(o => o.AverageTime).ToList();

            // 2. Calculamos y metemos el Average (Es decir, metemos el average y lo volvemos a ordenar)

            double suma = 0;
            int i = 0;
            while (i < listaBars.Count)
            {
                suma = suma + listaBars[i].AverageTime;
                i = i + 1;
            }

            IndividualBar bar2 = new IndividualBar("Average", "Average", suma / listaBars.Count());
            listaBars.Add(bar2);

            listaBars = listaBars.OrderBy(o => o.AverageTime).ToList();

            // 4. Recalculamos las posiciones para compensar el haber metido el Average (sumamos 1 a percentile position si esta por encima de la posición del average)

            // 4.1. Calculo posición del average:
            int j = 0;
            while (j < listaBars.Count)
            {
                if (listaBars[j].TargetIdentification == "Average") { break; }

                j = j + 1;
            }

            // 4.2. Recalculamos posiciones 95th y 99th oercentile segun su posición respecto Average

            if (percentile95_hight_position >= j) { percentile95_hight_position = percentile95_hight_position + 1; }
            if (percentile99_hight_position >= j) { percentile99_hight_position = percentile99_hight_position + 1; }

            // 5. Plot

            double[] x = new double[listaBars.Count()];
            double[] y = new double[listaBars.Count()];
            string[] labels = new string[listaBars.Count()];

            for (i = 0; i < listaBars.Count(); i++)
            {

                if (listaBars[i].TargetIdentification.Length > 0) { labels[i] = listaBars[i].TargetAddress; }
                else { labels[i] = listaBars[i].TargetAddress; }

                x[i] = i;
                y[i] = listaBars[i].AverageTime;
            }

            formsplot1.plt.PlotBar(x, y, showValues: true);
            formsplot1.plt.XTicks(x, labels);
        }
    }
}
