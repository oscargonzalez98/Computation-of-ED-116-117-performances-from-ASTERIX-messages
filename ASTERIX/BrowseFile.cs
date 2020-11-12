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

        int SAC = 0;
        int SIC = 0;


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
                        List<string[]> listahex = newfichero.leer();

                        progressBar1.Visible = true;
                        progressBar1.Value = 0;
                        progressBar1.Maximum = listahex.Count();

                        for (int q = 0; q < listahex.Count; q++)
                        {
                            string[] arraystring = listahex[q];
                            int CAT = int.Parse(arraystring[0], System.Globalization.NumberStyles.HexNumber);

                            if (CAT == 10)
                            {
                                CAT10 newcat10 = new CAT10(arraystring);
                                newcat10.Calculate_FSPEC(newcat10.paquete);
                                listaCAT10.Add(newcat10);
                            }


                            if (CAT == 21)
                            {

                                string FSPEC = "";

                                int j = 3;
                                bool found = false;

                                while (found == false)
                                {
                                    FSPEC = Convert.ToString(Convert.ToInt32(arraystring[j], 16), 2);// Convertir de hex a binario paquete [3]
                                    FSPEC = AddZeros(FSPEC);

                                    if (Char.ToString(FSPEC[FSPEC.Length - 1]) == "1")
                                    {
                                        while (Char.ToString(FSPEC[FSPEC.Length - 1]) != "0")
                                        {
                                            j = j + 1;
                                            string parte2 = Convert.ToString(Convert.ToInt32(arraystring[j], 16), 2);
                                            parte2 = AddZeros(parte2);

                                            FSPEC = String.Concat(FSPEC, parte2);
                                        }

                                        found = true;
                                    }

                                    found = true;
                                }

                                int data_position = 1 + 2 + ((FSPEC.Length) / 8);

                                string string1 = Convert.ToString(arraystring[data_position]);
                                string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                string1 = AddZeros(string1);

                                string string2 = Convert.ToString(arraystring[data_position + 1]);
                                string2 = Convert.ToString(Convert.ToInt32(string2, 16), 2);
                                string2 = AddZeros(string2);

                                data_position = data_position + 2;

                                string DataSourceIdentification = String.Concat(string1, string2);

                                Calculate_DataSourceIdentification(DataSourceIdentification);

                                // ahora que sabemos que version es cada paquete los metemos en su lista correspondiente.

                                if (SAC == 20 && SIC == 219)
                                {
                                    CAT21 newcat21 = new CAT21(arraystring);
                                    newcat21.Calculate_FSPEC(newcat21.paquete);
                                    listaCAT21.Add(newcat21);
                                }

                                if (SAC == 0 && SIC == 107)
                                {
                                    CAT21v23 newcat21v23 = new CAT21v23(arraystring);
                                    newcat21v23.Calculate_FSPEC(newcat21v23.paquete);
                                    listaCAT21v23.Add(newcat21v23);
                                }
                            }
                            progressBar1.Value = progressBar1.Value + 1;
                        }

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

                // Ahora asignamo el valor de tiempo real (si hemos pasado de 23:59:59 a 0:00:00 vamos a tener problemas, hay que especificar que aunque hayamos papsado a tiempo = 0 es un tiwmpomayor que el anterior)
                // Recorremos la lista. si entre un tiempo y otro hay un cambio de +12h es que hemos cambiado de dia
                for(int i=0; i<listaMLATCalibrationVehicleData.Count()-1; i++)
                {
                    if(Math.Abs(listaMLATCalibrationVehicleData[i+1].time1 - listaMLATCalibrationVehicleData[i].time1) > 12 * 3600)
                    {
                        i = i + 1;
                        while(i< listaMLATCalibrationVehicleData.Count())
                        {
                            listaMLATCalibrationVehicleData[i].timetotal = listaMLATCalibrationVehicleData[i].time1 + 24*3600;
                            i = i + 1;
                        }
                        break;
                    }
                }

                this.Close();
            }
        }

        public double Calculate_ComplementoA2(string bits)
        {
            if (bits == "1")
                return -1;
            if (bits == "0")
                return 0;
            else
            {
                if (Convert.ToString(bits[0]) == "0")
                {
                    int num = Convert.ToInt32(bits, 2);
                    return Convert.ToSingle(num);
                }
                else
                {
                    //elimino primer bit
                    string bitss = bits.Substring(1, bits.Length - 1);

                    //creo nuevo string cambiando 0s por 1s y viceversa
                    string newbits = "";
                    int i = 0;
                    while (i < bitss.Length)
                    {
                        if (Convert.ToString(bitss[i]) == "1")
                            newbits = newbits + "0";
                        if (Convert.ToString(bitss[i]) == "0")
                            newbits = newbits + "1";
                        i++;
                    }

                    //convertimos a int
                    double num = Convert.ToInt32(newbits, 2);

                    return -(num + 1);
                }
            }
        }

        public string AddZeros(string octeto)
        {
            while (octeto.Length < 8)
            {
                octeto = octeto.Insert(0, "0");
            }

            return octeto;
        }

        public void Calculate_DataSourceIdentification(string paquete)
        {
            string string1 = paquete.Substring(0, 8);
            string string2 = paquete.Substring(8, 8);

            SAC = Convert.ToInt32(string1, 2);
            SIC = Convert.ToInt32(string2, 2);
        }

        private void tbDirection_TextChanged(object sender, EventArgs e)
        {

        }

        private void BrowseFile_Load(object sender, EventArgs e)
        {

        }
    }
}
