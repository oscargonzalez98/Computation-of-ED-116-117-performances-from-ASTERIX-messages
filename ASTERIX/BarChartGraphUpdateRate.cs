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

        }
    }
}
