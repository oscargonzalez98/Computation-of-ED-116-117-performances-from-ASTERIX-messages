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
using MultiCAT6.Utils;

namespace ASTERIX
{
    public partial class BrowseFile : Form
    {
        public List<CAT10> listaCAT10 = new List<CAT10>();
        public List<CAT20> listaCAT20 = new List<CAT20>();
        public List<CAT21> listaCAT21 = new List<CAT21>();
        public List<CAT21v23> listaCAT21v23 = new List<CAT21v23>();
        public List<MLATCalibrationData> listaMLATCalibrationVehicleData = new List<MLATCalibrationData>();

        string[] list_paths;
        List<string> list_filepaths = new List<string>();

        GeoUtils GeoUtils1;
        // Centro de coordenadas SMR
        double LatSMR = 41 + (17.0 / 60.0) + (44.226 / 3600);
        double LonSMR = 02 + (05.0 / 60.0) + (42.411 / 3600);

        // Centro de coordenadas MLAT
        double LatMLAT = 41 + (17.0 / 60.0) + (49.426 / 3600);
        double LonMLAT = 02 + (04.0 / 60.0) + (42.410 / 3600);

        // Coordenadas ARP
        double LatARP = 41 + (17.0 / 60.0) + (49.426 / 3600);
        double LonARP = 02 + (04.0 / 60.0) + (42.410 / 3600);

        double E = Math.Sqrt(0.00669437999013);
        double A = 6378137.0;


        int SAC = 0;
        int SIC = 0;




        public BrowseFile()
        {
            InitializeComponent();

            //Bitmap img = new Bitmap(Application.StartupPath + @"\img\Captura.png");
            //this.BackgroundImage = img;
            //this.BackgroundImageLayout = ImageLayout.Stretch;

            lblError.Text = "";
            lbTitle.Text = "BROWSE A FILE AND SELECT IT TO DECODE";

            //this.forASTERIX = forASTERIX;
            //this.forMULTI = forMULTI;
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
                // Guardamos los path de todos los archivos en la lista
                string[] list_paths = openFileDialog1.FileNames;

                foreach (string direccion in list_paths)
                {
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

                    //tbDirection.Text = direccion.Replace(char1, char2);
                    //list_filepaths.Add(tbDirection.Text);
                }
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

        private void BrowseFile_Load(object sender, EventArgs e)
        {

        }

        private void pb_ASTERIXfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fichero = new OpenFileDialog();
            fichero.Multiselect = true;
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                GeoUtils1 = new GeoUtils(E, A, new CoordinatesWGS84(LatARP * GeoUtils.DEGS2RADS, LonARP * GeoUtils.DEGS2RADS, 0));

                // Primero hacemos una lista con los paths que hay
                List<string> list_filepaths = new List<string>();
                string[] list_paths = fichero.FileNames;
                foreach (string path in list_paths){ list_filepaths.Add(path); }
                

                if (list_filepaths.Count > 0)
                {
                    try
                    {
                        // Recorremos cada fichero y calculamos el num de paquetes en cada uno
                        lb_PacketsDecoded.Visible = true;
                        lb_PacketsDecoded.Text = "Decoing the file. Please wait.";

                        int sum = 0;
                        foreach (string path in list_filepaths)
                        {
                            Fichero newfichero = new Fichero(path);
                            List<string[]> listahex = newfichero.leer();
                            sum = sum + listahex.Count();
                        }
                        progressBar1.Visible = true;
                        progressBar1.Value = 0;
                        progressBar1.Maximum = sum;

                        list_filepaths.Sort();

                        // Ahora lo recorremos decodificando los paquetes y separandolos en listas

                        foreach (string path in list_filepaths)
                        {
                            Fichero newfichero = new Fichero(path);
                            List<string[]> listahex = newfichero.leer();

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
                        }

                        // Ahora añadimos el tiempo total en cada para cada paquete SI hay un momento en que pasamos de un dia a otro

                        for (int i = 0; i < listaCAT10.Count() - 1; i++)
                        {
                            if (Math.Abs(listaCAT10[i + 1].TimeofDay_seconds - listaCAT10[i].TimeofDay_seconds) > 12 * 3600)
                            {
                                i = i + 1;
                                while (i < listaCAT10.Count())
                                {
                                    listaCAT10[i].timetotal = listaCAT10[i].TimeofDay_seconds + 24 * 3600;
                                    i = i + 1;
                                }
                                break;
                            }
                        }
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

            lb_PacketsDecoded.Text = "The file has been decoded successfully.";
        }

        private void pb_CalibrationVehicle_Click(object sender, EventArgs e)
        {
            OpenFileDialog fichero = new OpenFileDialog();
            fichero.Multiselect = true;
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                GeoUtils1 = new GeoUtils(E, A, new CoordinatesWGS84(LatARP * GeoUtils.DEGS2RADS, LonARP * GeoUtils.DEGS2RADS, 0));

                // Primero hacemos una lista con los paths que hay
                List<string> list_filepaths = new List<string>();
                string[] list_paths = fichero.FileNames;
                foreach (string path in list_paths) { list_filepaths.Add(path); }

                // Intentamos decodificartlo como los archivos .txt "sencillos"
                try
                {
                    foreach(string path in list_paths)
                    {
                        string[] startinglines = File.ReadAllLines(path);

                        StreamReader sr = new StreamReader(path);
                        string line = sr.ReadLine();

                        while (line != null)
                        {
                            if (line.Length > 0)
                            {
                                string[] mychars = { Convert.ToString(""), Convert.ToString(' '), Convert.ToString('\t') };
                                string[] properties = line.Split(mychars, StringSplitOptions.RemoveEmptyEntries);

                                if (properties[0] != "IGNORE")
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

                    // Ahora asignamo el valor de tiempo real (si hemos pasado de 23:59:59 a 0:00:00 vamos a tener problemas, hay que especificar que aunque hayamos papsado a tiempo = 0 es un tiwmpomayor que el anterior)
                    // Recorremos la lista. si entre un tiempo y otro hay un cambio de +12h es que hemos cambiado de dia
                    for (int i = 0; i < listaMLATCalibrationVehicleData.Count() - 1; i++)
                    {
                        if (Math.Abs(listaMLATCalibrationVehicleData[i + 1].time1 - listaMLATCalibrationVehicleData[i].time1) > 12 * 3600)
                        {
                            i = i + 1;
                            while (i < listaMLATCalibrationVehicleData.Count())
                            {
                                listaMLATCalibrationVehicleData[i].timetotal = listaMLATCalibrationVehicleData[i].time1 + 24 * 3600;
                                i = i + 1;
                            }
                            break;
                        }
                    }
                }
                // Si no podemos decodificar como los archivos .txt sencillos es que es un archivo txt complicado y lo decodificamos de otra forma
                catch
                {
                    foreach(string path in list_filepaths)
                    {
                        string[] startinglines = File.ReadAllLines(path);

                        StreamReader sr = new StreamReader(path);

                        // Leemos las primeras lineas 

                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();
                        sr.ReadLine();

                        // Ahora con un Loop calculamos los valores

                        string line = sr.ReadLine();
                        while (line != null)
                        {
                            string[] mychars = { Convert.ToString(""), Convert.ToString(' '), Convert.ToString('\t') };
                            string[] properties = line.Split(mychars, StringSplitOptions.RemoveEmptyEntries);

                            // leemos el tiempo
                            string time = properties[1];
                            string[] mychars1 = { Convert.ToString(":") };
                            string[] properties1 = time.Split(mychars1, StringSplitOptions.RemoveEmptyEntries);

                            double hour = Convert.ToDouble(properties1[0]);
                            double minute = Convert.ToDouble(properties1[1]);
                            double second = Convert.ToDouble(properties1[2].Replace(Convert.ToChar("."), Convert.ToChar(",")));


                            // leemos la altitud
                            string alt = properties[5];
                            double altitude = Convert.ToDouble(alt.Replace(Convert.ToChar("."), Convert.ToChar(","))) * GeoUtils.FEET2METERS;

                            // leemos GS Lat
                            string lat = properties[9];
                            string[] mychars2 = { Convert.ToString("º?"), Convert.ToString("'?"), Convert.ToString("?"), Convert.ToString("�"), Convert.ToString("\"") };
                            string[] properties2 = lat.Split(mychars2, StringSplitOptions.RemoveEmptyEntries);

                            double lat_degrees = Convert.ToDouble(properties2[0]);
                            double lat_minutes = Convert.ToDouble(properties2[1]);
                            double lat_seconds = Convert.ToDouble(properties2[2].Replace(Convert.ToChar("."), Convert.ToChar(",")));
                            double latitude = lat_degrees + lat_minutes / 60 + lat_seconds / 3600;

                            if (properties2[3] == "S")
                            {
                                latitude = latitude * (-1);
                            }


                            // leemos GS Lon
                            string lon = properties[11];
                            string[] mychars3 = { Convert.ToString("º?"), Convert.ToString("'?"), Convert.ToString("?"), Convert.ToString("�"), Convert.ToString("\"") };
                            string[] properties3 = lon.Split(mychars3, StringSplitOptions.RemoveEmptyEntries);

                            double lon_degrees = Convert.ToDouble(properties3[0]);
                            double lon_minutes = Convert.ToDouble(properties3[1]);
                            double lon_seconds = Convert.ToDouble(properties3[2].Replace(Convert.ToChar("."), Convert.ToChar(",")));
                            double longitude = lon_degrees + lon_minutes / 60 + lon_seconds / 3600;

                            if (properties[3] == "W")
                            {
                                longitude = longitude * (-1);
                            }

                            // Ahora creamos el objeto de coordenadas geodesicas, systema cartesian, estereograficas

                            // Calculamos Coordenadas Geodesicas:
                            CoordinatesWGS84 coordGeodesic = new CoordinatesWGS84(latitude * GeoUtils.DEGS2RADS, longitude * GeoUtils.DEGS2RADS, altitude);

                            // Calculamos coordenadas System Cartesian:
                            CoordinatesXYZ coordGeocentric = GeoUtils1.change_geodesic2geocentric(coordGeodesic);
                            CoordinatesXYZ coordSystemCartesian = GeoUtils1.change_geocentric2system_cartesian(coordGeocentric);

                            // Calculamos coordenadas Stereograficas:
                            CoordinatesUVH coordStereographic = GeoUtils1.change_system_cartesian2stereographic(coordSystemCartesian);



                            // Ahora metemos toda la info en un objeto y el objeto en una lista
                            MLATCalibrationData data1 = new MLATCalibrationData();

                            data1.Lat = latitude;
                            data1.Lon = longitude;
                            data1.Alt = altitude;
                            data1.Hour = hour;
                            data1.Min = minute;
                            data1.Sec = second;
                            data1.timespan = TimeSpan.FromSeconds(hour * 3600 + minute * 60 + second);
                            data1.timetotal = hour * 3600 + minute * 60 + second;
                            data1.coordGeodesic = coordGeodesic;
                            data1.coordSystemCartesian = coordSystemCartesian;
                            data1.coordStereographic = coordStereographic;

                            listaMLATCalibrationVehicleData.Add(data1);

                            line = sr.ReadLine();
                        }
                    }

                    // Ahora asignamo el valor de tiempo real (si hemos pasado de 23:59:59 a 0:00:00 vamos a tener problemas, hay que especificar que aunque hayamos papsado a tiempo = 0 es un tiwmpomayor que el anterior)
                    // Recorremos la lista. si entre un tiempo y otro hay un cambio de +12h es que hemos cambiado de dia
                    for (int i = 0; i < listaMLATCalibrationVehicleData.Count() - 1; i++)
                    {
                        if (Math.Abs(listaMLATCalibrationVehicleData[i + 1].time1 - listaMLATCalibrationVehicleData[i].time1) > 12 * 3600)
                        {
                            i = i + 1;
                            while (i < listaMLATCalibrationVehicleData.Count())
                            {
                                listaMLATCalibrationVehicleData[i].timetotal = listaMLATCalibrationVehicleData[i].time1 + 24 * 3600;
                                i = i + 1;
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}
