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
    public partial class DataGrid_PositionAcuracy_fromASTERIXfile : Form
    {
        List<List<double>> ListResults_STAND;
        List<List<double>> ListResults_APRON;
        List<List<double>> ListResults_TAXI;
        List<List<double>> ListResults_RWY1;
        List<List<double>> ListResults_RWY2;
        List<List<double>> ListResults_RWY3;
        List<List<double>> ListResults_MA_APRON;
        List<List<double>> ListResults_AIRBORNE25;
        List<List<double>> ListResults_AIRBORNE5;


        public DataGrid_PositionAcuracy_fromASTERIXfile(List<List<double>> ListResults_STAND, List<List<double>> ListResults_APRON, List<List<double>> ListResults_TAXI, List<List<double>> ListResults_RWY1, List<List<double>> ListResults_RWY2, List<List<double>> ListResults_RWY3, List<List<double>> ListResults_MA_APRON, List<List<double>> ListResults_AIRBORNE25, List<List<double>> ListResults_AIRBORNE5)
        {
            InitializeComponent();
            this.ListResults_STAND = ListResults_STAND;
            this.ListResults_APRON = ListResults_APRON;
            this.ListResults_TAXI = ListResults_TAXI;
            this.ListResults_RWY1 = ListResults_RWY1;
            this.ListResults_RWY2 = ListResults_RWY2;
            this.ListResults_RWY3 = ListResults_RWY3;
            this.ListResults_MA_APRON = ListResults_MA_APRON;
            this.ListResults_AIRBORNE25 = ListResults_AIRBORNE25;
            this.ListResults_AIRBORNE5 = ListResults_AIRBORNE5;
        }

        private void DataGrid_PositionAcuracy_fromASTERIXfile_Load(object sender, EventArgs e)
        {
            // STAND
            if (ListResults_STAND[0].Count > 0)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                List<double> listadistances_STAND = ListResults_STAND[0];
                listadistances_STAND.Sort();

                double percentile95_STAND = CalculatePercentile(95, listadistances_STAND);
                double percentile99_STAND = CalculatePercentile(99, listadistances_STAND);
                double mean_STAND = listadistances_STAND.Average();
                double stdDeviation_STAND = CalculateStandardDeviation(listadistances_STAND);

                dataGridView1.Rows[n].Cells[0].Value = "STAND";
                dataGridView1.Rows[n].Cells[1].Value = percentile95_STAND.ToString();
                dataGridView1.Rows[n].Cells[2].Value = "20";
                dataGridView1.Rows[n].Cells[3].Value = percentile99_STAND.ToString();
                dataGridView1.Rows[n].Cells[4].Value = "20";
                dataGridView1.Rows[n].Cells[5].Value = mean_STAND.ToString();
                dataGridView1.Rows[n].Cells[6].Value = stdDeviation_STAND.ToString();
                dataGridView1.Rows[n].Cells[7].Value = listadistances_STAND.Count().ToString();
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = "STAND";
                dataGridView1.Rows[n].Cells[1].Value = "No Info";
                dataGridView1.Rows[n].Cells[2].Value = "No Info";
                dataGridView1.Rows[n].Cells[3].Value = "No Info";
                dataGridView1.Rows[n].Cells[4].Value = "No Info";
                dataGridView1.Rows[n].Cells[5].Value = "No Info";
                dataGridView1.Rows[n].Cells[6].Value = "No Info";
                dataGridView1.Rows[n].Cells[7].Value = "No Info";
            }

            // APRON
            if (ListResults_APRON[0].Count > 0)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                List<double> listadistancesAPRON = ListResults_APRON[0];
                listadistancesAPRON.Sort();

                double percentile95_APRON = CalculatePercentile(95, listadistancesAPRON);
                double percentile99_APRON = CalculatePercentile(95, listadistancesAPRON);
                double mean_APRON = listadistancesAPRON.Average();
                double stdDeviation_APRON = CalculateStandardDeviation(listadistancesAPRON);

                dataGridView1.Rows[n].Cells[0].Value = "APRON";
                dataGridView1.Rows[n].Cells[1].Value = percentile95_APRON.ToString();
                dataGridView1.Rows[n].Cells[2].Value = "7.5";
                dataGridView1.Rows[n].Cells[3].Value = percentile99_APRON.ToString();
                dataGridView1.Rows[n].Cells[4].Value = "12";
                dataGridView1.Rows[n].Cells[5].Value = mean_APRON.ToString();
                dataGridView1.Rows[n].Cells[6].Value = stdDeviation_APRON.ToString();
                dataGridView1.Rows[n].Cells[7].Value = listadistancesAPRON.Count().ToString();
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = "APRON";
                dataGridView1.Rows[n].Cells[1].Value = "No Info";
                dataGridView1.Rows[n].Cells[2].Value = "No Info";
                dataGridView1.Rows[n].Cells[3].Value = "No Info";
                dataGridView1.Rows[n].Cells[4].Value = "No Info";
                dataGridView1.Rows[n].Cells[5].Value = "No Info";
                dataGridView1.Rows[n].Cells[6].Value = "No Info";
                dataGridView1.Rows[n].Cells[7].Value = "No Info";
            }

            // TAXI
            if (ListResults_TAXI[0].Count > 0)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                List<double> listadistancesTAXI = ListResults_TAXI[0];
                listadistancesTAXI.Sort();

                double percentile95_TAXI = CalculatePercentile(95, listadistancesTAXI);
                double percentile99_TAXI = CalculatePercentile(95, listadistancesTAXI);
                double mean_TAXI = listadistancesTAXI.Average();
                double stdDeviation_TAXI = CalculateStandardDeviation(listadistancesTAXI);

                dataGridView1.Rows[n].Cells[0].Value = "TAXIWAY";
                dataGridView1.Rows[n].Cells[1].Value = percentile95_TAXI.ToString();
                dataGridView1.Rows[n].Cells[2].Value = "7.5";
                dataGridView1.Rows[n].Cells[3].Value = percentile99_TAXI.ToString();
                dataGridView1.Rows[n].Cells[4].Value = "12";
                dataGridView1.Rows[n].Cells[5].Value = mean_TAXI.ToString();
                dataGridView1.Rows[n].Cells[6].Value = stdDeviation_TAXI.ToString();
                dataGridView1.Rows[n].Cells[7].Value = listadistancesTAXI.Count().ToString();
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = "TAXIWAY";
                dataGridView1.Rows[n].Cells[1].Value = "No Info";
                dataGridView1.Rows[n].Cells[2].Value = "No Info";
                dataGridView1.Rows[n].Cells[3].Value = "No Info";
                dataGridView1.Rows[n].Cells[4].Value = "No Info";
                dataGridView1.Rows[n].Cells[5].Value = "No Info";
                dataGridView1.Rows[n].Cells[6].Value = "No Info";
                dataGridView1.Rows[n].Cells[7].Value = "No Info";
            }

            // RWY1
            if (ListResults_RWY1[0].Count > 0)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                List<double> listadistancesRWY1 = ListResults_RWY1[0];
                listadistancesRWY1.Sort();

                double percentile95_RWY1 = CalculatePercentile(95, listadistancesRWY1);
                double percentile99_RWY1 = CalculatePercentile(95, listadistancesRWY1);
                double mean_RWY1 = listadistancesRWY1.Average();
                double stdDeviation_RWY1 = CalculateStandardDeviation(listadistancesRWY1);

                dataGridView1.Rows[n].Cells[0].Value = "RUNWAY 02/20";
                dataGridView1.Rows[n].Cells[1].Value = percentile95_RWY1.ToString();
                dataGridView1.Rows[n].Cells[2].Value = "7.5";
                dataGridView1.Rows[n].Cells[3].Value = percentile99_RWY1.ToString();
                dataGridView1.Rows[n].Cells[4].Value = "12";
                dataGridView1.Rows[n].Cells[5].Value = mean_RWY1.ToString();
                dataGridView1.Rows[n].Cells[6].Value = stdDeviation_RWY1.ToString();
                dataGridView1.Rows[n].Cells[7].Value = listadistancesRWY1.Count().ToString();
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = "RUNWAY 02/20";
                dataGridView1.Rows[n].Cells[1].Value = "No Info";
                dataGridView1.Rows[n].Cells[2].Value = "No Info";
                dataGridView1.Rows[n].Cells[3].Value = "No Info";
                dataGridView1.Rows[n].Cells[4].Value = "No Info";
                dataGridView1.Rows[n].Cells[5].Value = "No Info";
                dataGridView1.Rows[n].Cells[6].Value = "No Info";
                dataGridView1.Rows[n].Cells[7].Value = "No Info";
            }

            // RWY2
            if (ListResults_RWY2[0].Count > 0)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                List<double> listadistancesRWY2 = ListResults_RWY2[0];
                listadistancesRWY2.Sort();

                double percentile95_RWY2 = CalculatePercentile(95, listadistancesRWY2);
                double percentile99_RWY2 = CalculatePercentile(95, listadistancesRWY2);
                double mean_RWY2 = listadistancesRWY2.Average();
                double stdDeviation_RWY2 = CalculateStandardDeviation(listadistancesRWY2);

                dataGridView1.Rows[n].Cells[0].Value = "RUNWAY 07R/25L";
                dataGridView1.Rows[n].Cells[1].Value = percentile95_RWY2.ToString();
                dataGridView1.Rows[n].Cells[2].Value = "7.5";
                dataGridView1.Rows[n].Cells[3].Value = percentile99_RWY2.ToString();
                dataGridView1.Rows[n].Cells[4].Value = "12";
                dataGridView1.Rows[n].Cells[5].Value = mean_RWY2.ToString();
                dataGridView1.Rows[n].Cells[6].Value = stdDeviation_RWY2.ToString();
                dataGridView1.Rows[n].Cells[7].Value = listadistancesRWY2.Count().ToString();
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = "RUNWAY 07R/25L";
                dataGridView1.Rows[n].Cells[1].Value = "No Info";
                dataGridView1.Rows[n].Cells[2].Value = "No Info";
                dataGridView1.Rows[n].Cells[3].Value = "No Info";
                dataGridView1.Rows[n].Cells[4].Value = "No Info";
                dataGridView1.Rows[n].Cells[5].Value = "No Info";
                dataGridView1.Rows[n].Cells[6].Value = "No Info";
                dataGridView1.Rows[n].Cells[7].Value = "No Info";
            }

            // RWY3
            if (ListResults_RWY3[0].Count > 0)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                List<double> listadistancesRWY3 = ListResults_RWY3[0];
                listadistancesRWY3.Sort();

                double percentile95_RWY3 = CalculatePercentile(95, listadistancesRWY3);
                double percentile99_RWY3 = CalculatePercentile(95, listadistancesRWY3);
                double mean_RWY3 = listadistancesRWY3.Average();
                double stdDeviation_RWY3 = CalculateStandardDeviation(listadistancesRWY3);

                dataGridView1.Rows[n].Cells[0].Value = "RUNWAY 07L/25R";
                dataGridView1.Rows[n].Cells[1].Value = percentile95_RWY3.ToString();
                dataGridView1.Rows[n].Cells[2].Value = "7.5";
                dataGridView1.Rows[n].Cells[3].Value = percentile99_RWY3.ToString();
                dataGridView1.Rows[n].Cells[4].Value = "12";
                dataGridView1.Rows[n].Cells[5].Value = mean_RWY3.ToString();
                dataGridView1.Rows[n].Cells[6].Value = stdDeviation_RWY3.ToString();
                dataGridView1.Rows[n].Cells[7].Value = listadistancesRWY3.Count().ToString();
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = "RUNWAY 07L/25R";
                dataGridView1.Rows[n].Cells[1].Value = "No Info";
                dataGridView1.Rows[n].Cells[2].Value = "No Info";
                dataGridView1.Rows[n].Cells[3].Value = "No Info";
                dataGridView1.Rows[n].Cells[4].Value = "No Info";
                dataGridView1.Rows[n].Cells[5].Value = "No Info";
                dataGridView1.Rows[n].Cells[6].Value = "No Info";
                dataGridView1.Rows[n].Cells[7].Value = "No Info";
            }

            // MA
            if (ListResults_MA_APRON[0].Count > 0)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                List<double> listadistancesMA = ListResults_MA_APRON[0];
                listadistancesMA.Sort();

                double percentile95_MA = CalculatePercentile(95, listadistancesMA);
                double percentile99_MA = CalculatePercentile(95, listadistancesMA);
                double mean_MA = listadistancesMA.Average();
                double stdDeviation_MA = CalculateStandardDeviation(listadistancesMA);

                dataGridView1.Rows[n].Cells[0].Value = "MANEUVERING AREA";
                dataGridView1.Rows[n].Cells[1].Value = percentile95_MA.ToString();
                dataGridView1.Rows[n].Cells[2].Value = "7.5";
                dataGridView1.Rows[n].Cells[3].Value = percentile99_MA.ToString();
                dataGridView1.Rows[n].Cells[4].Value = "12";
                dataGridView1.Rows[n].Cells[5].Value = mean_MA.ToString();
                dataGridView1.Rows[n].Cells[6].Value = stdDeviation_MA.ToString();
                dataGridView1.Rows[n].Cells[7].Value = listadistancesMA.Count().ToString();
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = "MANEUVERING AREA";
                dataGridView1.Rows[n].Cells[1].Value = "No Info";
                dataGridView1.Rows[n].Cells[2].Value = "No Info";
                dataGridView1.Rows[n].Cells[3].Value = "No Info";
                dataGridView1.Rows[n].Cells[4].Value = "No Info";
                dataGridView1.Rows[n].Cells[5].Value = "No Info";
                dataGridView1.Rows[n].Cells[6].Value = "No Info";
                dataGridView1.Rows[n].Cells[7].Value = "No Info";
            }

            // AIRBORNE 2.5NM
            if (ListResults_AIRBORNE25[0].Count > 0)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                List<double> listadistancesairborne25 = ListResults_AIRBORNE25[0];
                listadistancesairborne25.Sort();

                double percentile95_AIRBORNE25 = CalculatePercentile(95, listadistancesairborne25);
                double percentile99_AIRBORNE25 = CalculatePercentile(95, listadistancesairborne25);
                double mean_AIRBORNE25 = listadistancesairborne25.Average();
                double stdDeviation_AIRBORNE25 = CalculateStandardDeviation(listadistancesairborne25);

                dataGridView1.Rows[n].Cells[0].Value = "AIRBORNE 0 - 2.5 NM";
                dataGridView1.Rows[n].Cells[1].Value = percentile95_AIRBORNE25.ToString();
                dataGridView1.Rows[n].Cells[2].Value = "20";
                dataGridView1.Rows[n].Cells[3].Value = "-------";
                dataGridView1.Rows[n].Cells[4].Value = "-------";
                dataGridView1.Rows[n].Cells[5].Value = mean_AIRBORNE25.ToString();
                dataGridView1.Rows[n].Cells[6].Value = stdDeviation_AIRBORNE25.ToString();
                dataGridView1.Rows[n].Cells[7].Value = listadistancesairborne25.Count().ToString();
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = "AIRBORNE 0 - 2.5 NM";
                dataGridView1.Rows[n].Cells[1].Value = "No Info";
                dataGridView1.Rows[n].Cells[2].Value = "No Info";
                dataGridView1.Rows[n].Cells[3].Value = "No Info";
                dataGridView1.Rows[n].Cells[4].Value = "No Info";
                dataGridView1.Rows[n].Cells[5].Value = "No Info";
                dataGridView1.Rows[n].Cells[6].Value = "No Info";
                dataGridView1.Rows[n].Cells[7].Value = "No Info";
            }

            // AIRBORNE 5 NM
            if (ListResults_AIRBORNE5[0].Count > 0)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                List<double> listadistancesairborne5 = ListResults_AIRBORNE5[0];
                listadistancesairborne5.Sort();

                double percentile95_AIRBORNE5 = CalculatePercentile(95, listadistancesairborne5);
                double percentile99_AIRBORNE5 = CalculatePercentile(95, listadistancesairborne5);
                double mean_AIRBORNE5 = listadistancesairborne5.Average();
                double stdDeviation_AIRBORNE5 = CalculateStandardDeviation(listadistancesairborne5);

                dataGridView1.Rows[n].Cells[0].Value = "AIRBORNE 2.5 - 5 NM";
                dataGridView1.Rows[n].Cells[1].Value = percentile95_AIRBORNE5.ToString();
                dataGridView1.Rows[n].Cells[2].Value = "20";
                dataGridView1.Rows[n].Cells[3].Value = "-------";
                dataGridView1.Rows[n].Cells[4].Value = "-------";
                dataGridView1.Rows[n].Cells[5].Value = mean_AIRBORNE5.ToString();
                dataGridView1.Rows[n].Cells[6].Value = stdDeviation_AIRBORNE5.ToString();
                dataGridView1.Rows[n].Cells[7].Value = listadistancesairborne5.Count().ToString();
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.Blue;

                n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = "AIRBORNE 0 - 2.5 NM";
                dataGridView1.Rows[n].Cells[1].Value = "No Info";
                dataGridView1.Rows[n].Cells[2].Value = "No Info";
                dataGridView1.Rows[n].Cells[3].Value = "No Info";
                dataGridView1.Rows[n].Cells[4].Value = "No Info";
                dataGridView1.Rows[n].Cells[5].Value = "No Info";
                dataGridView1.Rows[n].Cells[6].Value = "No Info";
                dataGridView1.Rows[n].Cells[7].Value = "No Info";
            }
        }

        public double CalculateStandardDeviation(IEnumerable<double> values)
        {
            double standardDeviation = 0;

            if (values.Any())
            {
                // Compute the average.     
                double avg = values.Average();

                // Perform the Sum of (value-avg)_2_2.      
                double sum = values.Sum(d => Math.Pow(d - avg, 2));

                // Put it all together.      
                standardDeviation = Math.Sqrt((sum) / (values.Count() - 1));
            }

            return standardDeviation;
        }

        public double CalculatePercentile(int perc, List<double> lista)
        {
            double percentile = Convert.ToDouble(perc);
            percentile = percentile / 100;

            int posicion_inferior = Convert.ToInt32(Math.Floor(lista.Count() * percentile));
            int posicion_superior = Convert.ToInt32(Math.Ceiling(lista.Count() * percentile));

            try
            {
                return (lista[posicion_inferior] + lista[posicion_superior]) / 2;
            }
            catch
            {
                return lista[posicion_inferior - 1];
            }
        }
    }
}
