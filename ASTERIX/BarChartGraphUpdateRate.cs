using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Clases;
using LIBRERIACLASES;
namespace ASTERIX
{
    public partial class BarChartGraphUpdateRate : Form
    {
        public List<IndividualBar> listaBars = new List<IndividualBar>();
        public BarChartGraphUpdateRate(List<IndividualBar> listaBars)
        {
            InitializeComponent();
            this.listaBars = listaBars;
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void BarChartGraphUpdateRate_Load(object sender, EventArgs e)
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

            IndividualBar bar2 = new IndividualBar("Average", "Average", suma/listaBars.Count());
            listaBars.Add(bar2);

            listaBars = listaBars.OrderBy(o => o.AverageTime).ToList();

            // 4. Recalculamos las posiciones para compensar el haber metido el Average (sumamos 1 a percentile position si esta por encima de la posición del average)

            // 4.1. Calculo posición del average:
            int j = 0;
            while(j<listaBars.Count)
            {
                if (listaBars[j].TargetIdentification == "Average") { break; }

                j = j + 1;
            }

            // 4.2. Recalculamos posiciones 95th y 99th oercentile segun su posición respecto Average

            if (percentile95_hight_position >= j) { percentile95_hight_position = percentile95_hight_position + 1; }
            if (percentile99_hight_position >= j) { percentile99_hight_position = percentile99_hight_position + 1; }

            // 5. Plot

            int k = 0;
            while(k< percentile95_hight_position)
            {
                if(listaBars[k].TargetIdentification == "Average")
                {
                    chart.Series["Series1"].Points.Add(listaBars[k].AverageTime);
                    chart.Series["Series1"].Points[k].Color = Color.Red;
                    chart.Series["Series1"].Points[k].AxisLabel = listaBars[k].TargetIdentification;
                    chart.Series["Series1"].Points[k].LegendText = listaBars[k].TargetIdentification;
                    chart.Series["Series1"].Points[k].Label = listaBars[k].AverageTime.ToString();
                }

                else
                {
                    chart.Series["Series1"].Points.Add(listaBars[k].AverageTime);
                    chart.Series["Series1"].Points[k].Color = Color.Yellow;
                    if (listaBars[k].TargetIdentification != "")
                    {
                        chart.Series["Series1"].Points[k].AxisLabel = listaBars[k].TargetIdentification;
                        chart.Series["Series1"].Points[k].LegendText = listaBars[k].TargetIdentification;
                    }
                    else
                    {
                        chart.Series["Series1"].Points[k].AxisLabel = listaBars[k].TargetAddress;
                        chart.Series["Series1"].Points[k].LegendText = listaBars[k].TargetAddress;
                    }
                    chart.Series["Series1"].Points[k].Label = listaBars[k].AverageTime.ToString();
                }

                k = k + 1;
            }

            while (k < percentile99_hight_position)
            {
                if (listaBars[k].TargetIdentification == "Average")
                {
                    chart.Series["Series1"].Points.Add(listaBars[k].AverageTime);
                    chart.Series["Series1"].Points[k].Color = Color.Red;
                    chart.Series["Series1"].Points[k].AxisLabel = listaBars[k].TargetIdentification;
                    chart.Series["Series1"].Points[k].LegendText = listaBars[k].TargetIdentification;
                    chart.Series["Series1"].Points[k].Label = listaBars[k].AverageTime.ToString();
                }

                else
                {
                    chart.Series["Series1"].Points.Add(listaBars[k].AverageTime);
                    chart.Series["Series1"].Points[k].Color = Color.Blue;
                    if (listaBars[k].TargetIdentification != "")
                    {
                        chart.Series["Series1"].Points[k].AxisLabel = listaBars[k].TargetIdentification;
                        chart.Series["Series1"].Points[k].LegendText = listaBars[k].TargetIdentification;
                    }
                    else
                    {
                        chart.Series["Series1"].Points[k].AxisLabel = listaBars[k].TargetAddress;
                        chart.Series["Series1"].Points[k].LegendText = listaBars[k].TargetAddress;
                    }
                    chart.Series["Series1"].Points[k].Label = listaBars[k].AverageTime.ToString();
                }

                k = k + 1;
            }

            while (k < listaBars.Count())
            {
                if (listaBars[k].TargetIdentification == "Average")
                {
                    chart.Series["Series1"].Points.Add(listaBars[k].AverageTime);
                    chart.Series["Series1"].Points[k].Color = Color.Red;
                    chart.Series["Series1"].Points[k].AxisLabel = listaBars[k].TargetIdentification;
                    chart.Series["Series1"].Points[k].LegendText = listaBars[k].TargetIdentification;
                    chart.Series["Series1"].Points[k].Label = listaBars[k].AverageTime.ToString();
                }

                else
                {
                    chart.Series["Series1"].Points.Add(listaBars[k].AverageTime);
                    chart.Series["Series1"].Points[k].Color = Color.Green;
                    if (listaBars[k].TargetIdentification != "")
                    {
                        chart.Series["Series1"].Points[k].AxisLabel = listaBars[k].TargetIdentification;
                        chart.Series["Series1"].Points[k].LegendText = listaBars[k].TargetIdentification;
                    }
                    else
                    {
                        chart.Series["Series1"].Points[k].AxisLabel = listaBars[k].TargetAddress;
                        chart.Series["Series1"].Points[k].LegendText = listaBars[k].TargetAddress;
                    }
                    chart.Series["Series1"].Points[k].Label = listaBars[k].AverageTime.ToString();
                }

                k = k + 1;
            }

            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            chart.ChartAreas[0].AxisX.Title = "VEHICLE IDENTIFICATION";
            chart.ChartAreas[0].AxisY.Title = "AVERAGE DELAY BETWEEN MESSAGES [s]";
        }
    }
}
