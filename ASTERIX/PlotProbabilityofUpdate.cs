using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASTERIX
{
    public partial class PlotProbabilityofUpdate : Form
    {
        List<double> listaLimitAverageValue_Apron = new List<double>();
        List<double> listaProbabilityUpdate_Apron = new List<double>();

        List<double> listaProbabilityUpdate_Stand = new List<double>();

        List<double> listaProbabilityUpdate_MA = new List<double>();

        List<double> listaProbabilityUpdate_Airborne = new List<double>();

        public PlotProbabilityofUpdate(List<double> listaLimitAverageValue_Apron, List<double> listaProbabilityUpdate_Apron, List<double> listaProbabilityUpdate_Stand, List<double> listaProbabilityUpdate_MA, List<double> listaProbabilityUpdate_Airborne)
        {
            InitializeComponent();
            this.listaLimitAverageValue_Apron = listaLimitAverageValue_Apron;
            this.listaProbabilityUpdate_Apron = listaProbabilityUpdate_Apron;
            this.listaProbabilityUpdate_Stand = listaProbabilityUpdate_Stand;
            this.listaProbabilityUpdate_MA = listaProbabilityUpdate_MA;
            this.listaProbabilityUpdate_Airborne = listaProbabilityUpdate_Airborne;
        }

        private void PlotProbabilityofUpdate_Load(object sender, EventArgs e)
        {
            double[] vLimitAverageValue_Apron = new double[listaLimitAverageValue_Apron.Count()];
            double[] vProbabilityUpdate_Apron = new double[listaProbabilityUpdate_Apron.Count()];

            for (int i =0; i< listaLimitAverageValue_Apron.Count(); i++)
            {
                vLimitAverageValue_Apron[i] = listaLimitAverageValue_Apron[i];
            }

            for (int i = 0; i < listaProbabilityUpdate_Apron.Count(); i++)
            {
                vProbabilityUpdate_Apron[i] = listaProbabilityUpdate_Apron[i];
            }

            formsPlot_Apron.plt.PlotScatter(vLimitAverageValue_Apron, vProbabilityUpdate_Apron);
            formsPlot_Apron.plt.Title("APRON PROBABILITY OF UPDATE");
            formsPlot_Apron.plt.XLabel("Average Update Time Threshold Value");
            formsPlot_Apron.plt.YLabel("Probability of Update");
            formsPlot_Apron.Render();

            double[] vProbabilityUpdate_Stand = new double[listaProbabilityUpdate_Stand.Count()];

            for (int i = 0; i < listaProbabilityUpdate_Stand.Count(); i++)
            {
                vProbabilityUpdate_Stand[i] = listaProbabilityUpdate_Stand[i];
            }

            formsPlot_Stand.plt.PlotScatter(vLimitAverageValue_Apron, vProbabilityUpdate_Stand);
            formsPlot_Stand.plt.Title("STAND PROBABILITY OF UPDATE");
            formsPlot_Stand.plt.XLabel("Average Update Time Threshold Value");
            formsPlot_Stand.plt.YLabel("Probability of Update");
            formsPlot_Stand.Render();

            double[] vProbabilityUpdate_MA = new double[listaProbabilityUpdate_MA.Count()];

            for (int i = 0; i < listaProbabilityUpdate_MA.Count(); i++)
            {
                vProbabilityUpdate_MA[i] = listaProbabilityUpdate_MA[i];
            }

            formsPlot_MA.plt.PlotScatter(vLimitAverageValue_Apron, vProbabilityUpdate_MA);
            formsPlot_MA.plt.Title("MANOUVRNIG AREA PROBABILITY OF UPDATE");
            formsPlot_MA.plt.XLabel("Average Update Time Threshold Value");
            formsPlot_MA.plt.YLabel("Probability of Update");
            formsPlot_MA.Render();

            double[] vProbabilityUpdate_Airborne = new double[listaProbabilityUpdate_Airborne.Count()];

            for (int i = 0; i < listaProbabilityUpdate_Airborne.Count(); i++)
            {
                vProbabilityUpdate_Airborne[i] = listaProbabilityUpdate_Airborne[i];
            }

            formsPlot_Airborne.plt.PlotScatter(vLimitAverageValue_Apron, vProbabilityUpdate_Airborne);
            formsPlot_Airborne.plt.Title("AIRBORNE PROBABILITY OF UPDATE");
            formsPlot_Airborne.plt.XLabel("Average Update Time Threshold Value");
            formsPlot_Airborne.plt.YLabel("Probability of Update");
            formsPlot_Airborne.Render();
        }
    }
}
