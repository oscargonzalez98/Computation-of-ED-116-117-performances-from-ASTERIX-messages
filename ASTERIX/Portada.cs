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
    public partial class Portada : Form
    {
        public int counter = 0;

        public List<CAT10> listaCAT10 = new List<CAT10>();
        public List<CAT10> listaMLAT = new List<CAT10>();
        public List<CAT10> listaSMR = new List<CAT10>();
        public List<CAT20> listaCAT20 = new List<CAT20>();
        public List<CAT21> listaCAT21 = new List<CAT21>();
        public List<CAT21v23> listaCAT21v23 = new List<CAT21v23>();
        public List<MLATCalibrationData> listaCalibrationDataVehicle = new List<MLATCalibrationData>();

        private Button currentButton;
        private Form activeForm;

        public Portada()
        {
            InitializeComponent();
        }

        private void Portada_Load(object sender, EventArgs e)
        {
            if ((listaCAT10.Count > 0 ? 1 : 0 + listaCAT21.Count() > 0 ? 1 : 0 + listaCalibrationDataVehicle.Count() > 0 ? 1 : 0) > 0)
            {
                DialogResult r = MessageBox.Show("If this window opens the decoded data will be deleted. Are you shure you want to continue?", "", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    BrowseFile bf1 = new BrowseFile();
                    OpenChildForm(bf1, sender);

                    listaCAT10 = bf1.ListaCAT10;
                    listaCAT20 = bf1.ListaCAT20;
                    listaCAT21 = bf1.ListaCAT21;
                    listaCAT21v23 = bf1.ListaCAT21v23;
                    listaCalibrationDataVehicle = bf1.listaMLATCalibrationVehicleData;
                }
            }

            else
            {
                BrowseFile bf1 = new BrowseFile();

                activeForm = bf1;
                bf1.TopLevel = false;
                bf1.FormBorderStyle = FormBorderStyle.None;
                bf1.Dock = DockStyle.Fill;
                this.panelDesktopPanel.Controls.Add(bf1);
                this.panelDesktopPanel.Tag = bf1;
                bf1.BringToFront();
                bf1.Show();

                listaCAT10 = bf1.ListaCAT10;
                listaCAT20 = bf1.ListaCAT20;
                listaCAT21 = bf1.ListaCAT21;
                listaCAT21v23 = bf1.ListaCAT21v23;
                listaCalibrationDataVehicle = bf1.listaMLATCalibrationVehicleData;
            }
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    Disableutton();

                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(39, 39, 58);
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void Disableutton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (childForm != null)
            {

            }

            {
                ActivateButton(btnSender);
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelDesktopPanel.Controls.Add(childForm);
                this.panelDesktopPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

            //private void button5_Click(object sender, EventArgs e)
            //{
            //    pruebapoly hola = new pruebapoly();
            //    hola.Show();
            //}

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_Tables_Click(object sender, EventArgs e)
        {
            Tables Tables1 = new Tables(listaCAT10, listaCAT20, listaCAT21, listaCAT21v23, listaCalibrationDataVehicle);
            OpenChildForm(Tables1, sender);
        }

        private void btn_browsefiles_Click(object sender, EventArgs e)
        {
            counter = 0;
            if((listaCAT10.Count>0? 1:0 + listaCAT21.Count()>0? 1:0 + listaCalibrationDataVehicle.Count()>0? 1:0) > 0)
            {
                DialogResult r = MessageBox.Show("If this window opens the decoded data will be deleted. Are you shure you want to continue?","", MessageBoxButtons.YesNo);
                if(r == DialogResult.Yes)
                {
                    BrowseFile bf1 = new BrowseFile();
                    OpenChildForm(bf1, sender);

                    listaCAT10 = bf1.ListaCAT10;
                    listaCAT20 = bf1.ListaCAT20;
                    listaCAT21 = bf1.ListaCAT21;
                    listaCAT21v23 = bf1.ListaCAT21v23;
                    listaCalibrationDataVehicle = bf1.listaMLATCalibrationVehicleData;
                }
            }

            else
            {
                BrowseFile bf1 = new BrowseFile();
                OpenChildForm(bf1, sender);

                listaCAT10 = bf1.ListaCAT10;
                listaCAT20 = bf1.ListaCAT20;
                listaCAT21 = bf1.ListaCAT21;
                listaCAT21v23 = bf1.ListaCAT21v23;
                listaCalibrationDataVehicle = bf1.listaMLATCalibrationVehicleData;
            }
        }

        private void btn_mapsimulation_Click(object sender, EventArgs e)
        {
            MapView1 MapView = new MapView1(listaCAT10, listaCAT21, listaCAT21v23);
            OpenChildForm(MapView, sender);
        }

        private void btn_ed_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                for (int i = 0; i < listaCAT10.Count(); i++)
                {
                    if (listaCAT10[i].SAC == 0 && listaCAT10[i].SIC == 7) { listaSMR.Add(listaCAT10[i]); }
                    if (listaCAT10[i].SAC == 0 && listaCAT10[i].SIC == 107) { listaMLAT.Add(listaCAT10[i]); }
                }
                counter++;
            }

            ED_MLAT ED2 = new ED_MLAT(listaMLAT, listaCAT21, listaCAT21v23, listaCalibrationDataVehicle);
            OpenChildForm(ED2, sender);

            listaMLAT = ED2.listaMLAT;
            listaSMR = ED2.listaSMR;
        }

        private void btn_ED_SMR_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                for (int i = 0; i < listaCAT10.Count(); i++)
                {
                    if (listaCAT10[i].SAC == 0 && listaCAT10[i].SIC == 7) { listaSMR.Add(listaCAT10[i]); }
                    if (listaCAT10[i].SAC == 0 && listaCAT10[i].SIC == 107) { listaMLAT.Add(listaCAT10[i]); }
                }
                counter++;
            }

            ED_SMR ED = new ED_SMR(listaCAT10, listaCAT21, listaCalibrationDataVehicle);
            OpenChildForm(ED, sender);
        }

        private void bt_Export_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                for (int i = 0; i < listaCAT10.Count(); i++)
                {
                    if (listaCAT10[i].SAC == 0 && listaCAT10[i].SIC == 7) { listaSMR.Add(listaCAT10[i]); }
                    if (listaCAT10[i].SAC == 0 && listaCAT10[i].SIC == 107) { listaMLAT.Add(listaCAT10[i]); }
                }
                counter++;
            }

            Export export1 = new Export(listaCAT10, listaMLAT, listaCAT21, listaCAT21v23, listaCalibrationDataVehicle);
            OpenChildForm(export1, sender);
        }
    }
}
