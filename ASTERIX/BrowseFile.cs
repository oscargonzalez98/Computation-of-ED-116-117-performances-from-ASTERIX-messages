using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using LIBRERIACLASES;

namespace ASTERIX
{
    public partial class BrowseFile : Form
    {
        public List<CAT10> listaCAT10 = new List<CAT10>();
        public List<CAT20> listaCAT20 = new List<CAT20>();
        public List<CAT21> listaCAT21 = new List<CAT21>();
        public List<CAT21v23> listaCAT21v23 = new List<CAT21v23>();

        public List<MLATCalibrationData> listaMLATCalibrationVehicleData = new List<MLATCalibrationData>();

        public bool forASTERIX;
        public bool forMULTI;


        public BrowseFile(bool forASTERIX, bool forMULTI)
        {
            InitializeComponent();

            //Bitmap img = new Bitmap(Application.StartupPath + @"\img\Captura.png");
            //this.BackgroundImage = img;
            //this.BackgroundImageLayout = ImageLayout.Stretch;

            lblError.Text = "";
            lbTitle.Text = "BROWSE A FILE AND SELECT IT TO DECODE";

            this.forASTERIX = forASTERIX;
            this.forMULTI = forMULTI;
        }


        public List<CAT21v23> ListaCAT21v23
        {
            get { return listaCAT21v23; }
        }
        public List<CAT21> ListaCAT21
        {
            get { return listaCAT21; }
        }

        public List<CAT20> ListaCAT20
        {
            get { return listaCAT20; }
        }
        public List<CAT10> ListaCAT10
        {
            get { return listaCAT10; }
        }

        private void bt_SelectFile_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string direccion = openFileDialog1.FileName;
                char char1;
                int i = 0;
                bool bool1 = false;
                while (i < direccion.Length && direccion[i] != Convert.ToChar(":") && bool1 == false)
                {
                    try
                    {
                        char1 = Convert.ToChar(direccion[i]);
                    }
                    catch
                    {
                        bool1 = true;
                    }
                    i = i + 1;
                }
                char1 = Convert.ToChar(direccion[i + 1]);
                char char2 = Convert.ToChar("/");

                tbDirection.Text = direccion.Replace(char1, char2);
            }
        }

        private void bt_Decode_Click(object sender, EventArgs e)
        {
            if(forASTERIX==true && forMULTI==false)
            {
                if (tbDirection.Text.Length > 0)
                {
                    try
                    {
                        string path = tbDirection.Text;
                        Fichero newfichero = new Fichero(path);
                        newfichero.leer();

                        listaCAT21v23 = newfichero.GetListCAT21v23();
                        listaCAT21 = newfichero.GetListCAT21(); // devuelve lista de clases CAT21, cada una con un paquete
                        listaCAT20 = newfichero.GetListCAT20();
                        listaCAT10 = newfichero.getListCAT10();

                        this.Close();
                    }
                    catch
                    {
                        lblError.Text = "Error. Please select a valid file.";
                    }
                }

                else
                {
                    lblError.Text = "Please select a file.";
                }
            }

            if(forASTERIX==false && forMULTI == true)
            {
                string[] startinglines = File.ReadAllLines(tbDirection.Text);

                StreamReader sr = new StreamReader(tbDirection.Text);
                string line = sr.ReadLine();

                while (line != null)
                {
                    if (line.Length > 0)
                    {
                        string[] mychars = { Convert.ToString(""), Convert.ToString(' '), Convert.ToString('\t') };
                        string[] properties = line.Split(mychars, StringSplitOptions.RemoveEmptyEntries);

                        if(properties[0]!="IGNORE")
                        {
                            MLATCalibrationData data1 = new MLATCalibrationData(properties[0], properties[1], properties[2], properties[3], properties[4], properties[5], properties[6], properties[7], properties[8], properties[9]);
                            listaMLATCalibrationVehicleData.Add(data1);
                        }
                        else
                        {
                            MLATCalibrationData data1 = new MLATCalibrationData("", properties[1], properties[2], "", "", "", "", properties[5], properties[6], properties[7]);
                            listaMLATCalibrationVehicleData.Add(data1);
                        }
                    }
                    line = sr.ReadLine();
                }
            }
        }

        private void tbDirection_TextChanged(object sender, EventArgs e)
        {

        }

        private void BrowseFile_Load(object sender, EventArgs e)
        {

        }
    }
}
