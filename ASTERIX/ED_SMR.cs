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

using DotNetMatrix;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Runtime;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using MultiCAT6.Utils;
using System.Windows.Media;
using ColorConverter = System.Windows.Media.ColorConverter;
using Color = System.Windows.Media.Color;
using Accord.Math;

namespace ASTERIX
{
    public partial class ED_SMR : Form
    {


        public class Trafico
        {
            public CAT10 traficoSMR;
            public CAT10 traficoMLAT;
            public CAT21 traficoCAT21;
            public double distance;
            public string TargetAddress;

            public Trafico(CAT10 SMR, CAT10 MLAT)
            {
                this.traficoSMR = SMR;
                this.traficoMLAT = MLAT;
            }

            public Trafico(CAT10 SMR, CAT21 CAT21)
            {
                this.traficoSMR = SMR;
                this.traficoCAT21 = CAT21;
            }
        }

        public static List<string> listColors = new List<string>() { "#3F51B5", "#009688", "#FF5722", "#607D8B", "#FF9800", "#9C27B0", "#2196F3", "#EA676C", "#E41A4A", "#5978BB", "#018790", "#0E3441", "#00B0AD", "#721D47", "#EA4833", "#EF937E", "#F37521", "#A12059", "#126881", "#8BC240", "#364D5B", "#C7DC5B", "#0094BC", "#E4126B", "#43B76E", "#7BCFE9", "B71C46" };

        double E = Math.Sqrt(0.00669437999013);
        double A = 6378137.0;

        GeoUtils GeoUtils1;

        public CoordinatesWGS84 coordGeodesic_ARP;
        public CoordinatesUVH coordStereographic_ARP;
        public CoordinatesXYZ coordSystemCartesian_ARP;

        public CoordinatesWGS84 coordGeodesic_MLAT;
        public CoordinatesUVH coordStereographic_MLAT;
        public CoordinatesXYZ coordSystemCartesian_MLAT;

        public CoordinatesWGS84 coordGeodesic_SMR;
        public CoordinatesUVH coordStereographic_SMR;
        public CoordinatesXYZ coordSystemCartesian_SMR;

        // Centro de coordenadas SMR
        double LatSMR = 41 + (17.0 / 60.0) + (44.226 / 3600);
        double LonSMR = 02 + (05.0 / 60.0) + (42.411 / 3600);

        // Centro de coordenadas MLAT
        double LatMLAT = 41 + (17.0 / 60.0) + (49.426 / 3600);
        double LonMLAT = 02 + (04.0 / 60.0) + (42.410 / 3600);

        // Coordenadas ARP
        double LatARP = 41 + (17.0 / 60.0) + (49.426 / 3600);
        double LonARP = 02 + (04.0 / 60.0) + (42.410 / 3600);

        Bitmap blue_plane = (Bitmap)Image.FromFile("img/Planes/plane_blue_small.png");
        Bitmap red_plane = (Bitmap)Image.FromFile("img/Planes/plane_red_small.png");
        Bitmap green_plane = (Bitmap)Image.FromFile("img/Planes/plane_green_small.png");
        Bitmap white_plane = (Bitmap)Image.FromFile("img/Planes/plane_white_small.png");

        Bitmap blue_pushback = (Bitmap)Image.FromFile("img/Pushbacks/bushback_blue_small.png");
        Bitmap red_pushback = (Bitmap)Image.FromFile("img/Pushbacks/bushback_red_small.png");
        Bitmap green_pushback = (Bitmap)Image.FromFile("img/Pushbacks/bushback_green_small.png");
        Bitmap white_pushback = (Bitmap)Image.FromFile("img/Pushbacks/bushback_white_small.png");

        Bitmap blue_circle = (Bitmap)Image.FromFile("img/Circles1/circle_blue_small.png");
        Bitmap red_circle = (Bitmap)Image.FromFile("img/Circles1/circle_red_small.png");
        Bitmap green_circle = (Bitmap)Image.FromFile("img/Circles1/circle_green_small.png");
        Bitmap white_circle = (Bitmap)Image.FromFile("img/Circles1/circle_white_small.png");
        Bitmap pink_circle = (Bitmap)Image.FromFile("img/Circles1/circle_pink_small.png");

        List<CAT10> listaCAT10 = new List<CAT10>();
        List<CAT10> listaSMR = new List<CAT10>();
        List<CAT10> listaMLAT = new List<CAT10>();
        List<CAT21> listaCAT21 = new List<CAT21>();
        List<MLATCalibrationData> listaCalibrationDataVehicle = new List<MLATCalibrationData>();

        public ED_SMR(List<CAT10> listaCAT10, List<CAT21> listaCAT21, List<MLATCalibrationData> listaCalibrationDataVehicle)
        {
            InitializeComponent();

            this.listaCAT10 = listaCAT10;
            this.listaCAT21 = listaCAT21;
            this.listaCalibrationDataVehicle = listaCalibrationDataVehicle;

            CalculateARP_MLAT_SMR_coordinates();
        }

        private void ED_SMR_Load(object sender, EventArgs e)
        {
            // Separamos smr y MLAT
            List<CAT10> list1 = new List<CAT10>();
            List<CAT10> list2 = new List<CAT10>();

            for (int i = 0; i < listaCAT10.Count(); i++)
            {
                if (listaCAT10[i].SAC == 0 && listaCAT10[i].SIC == 7) { list1.Add(listaCAT10[i]); }
                if (listaCAT10[i].SAC == 0 && listaCAT10[i].SIC == 107) { list2.Add(listaCAT10[i]); }
            }

            listaSMR.Clear();
            listaMLAT.Clear();
            listaSMR = list1.OrderBy(o => o.timetotal).ToList();
            listaMLAT = list2.OrderBy(o => o.timetotal).ToList();
            listaCAT21 = listaCAT21.OrderBy(o => o.TimeofASTERIXReportTransmission_seconds).ToList();

            // Eliminamospaquetesc de periodic updates est
            FilterCAT10(listaSMR);
            FilterCAT10(listaMLAT);

            // Calculamos las tryectorias
            List<List<CAT10>> listaTrayectorias = CalculateTrajectories(listaSMR); // Funcion que calcula las trayectorias a partir de track number y distancia (poco restrictiva)
            List<List<CAT10>> listaTrayectorias1 = CalculateTrajectories1(listaSMR); // Funcion que calcula las trayectorias a partir de kalman filter
            //List<Trafico> listaTraficos = CalculateTrajectories2(listaSMR, listaMLAT, listaCAT21); // Funcion que calcula el tráfico MLAT, CAT21 equivalente de cada trafico SMR a paritr de la distancia y tiempo

            // Creamos Mapa

            Mapa.DragButton = MouseButtons.Left;
            Mapa.CanDragMap = true;
            Mapa.MapProvider = GMapProviders.OpenCycleLandscapeMap;
            Mapa.Position = new PointLatLng(41, 2);
            Mapa.MinZoom = 1;
            Mapa.MaxZoom = 30;
            Mapa.Zoom = 8;
            Mapa.AutoScroll = true;

            // Pintamos los trayectos por Track Number
            GMapOverlay polygonsoverlay = new GMapOverlay();
            int j = 0;
            foreach (List<CAT10> list in listaTrayectorias1)
            {
                for (int i = 0; i < list.Count() - 1; i++)
                {
                    SolidColorBrush color;
                    System.Windows.Media.Color color1;
                    try
                    {
                        color = new SolidColorBrush((Color)ColorConverter.ConvertFromString(listColors[j]));
                        color1 = Color.FromArgb(color.Color.A, color.Color.R, color.Color.G, color.Color.B);
                    }
                    catch
                    {
                        color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff0000"));
                        color1 = Color.FromArgb(color.Color.A, color.Color.R, color.Color.G, color.Color.B);
                    }

                    PointLatLng marker1 = new PointLatLng(list[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, list[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS);
                    PointLatLng marker2 = new PointLatLng(list[i + 1].coordGeodesic.Lat * GeoUtils.RADS2DEGS, list[i + 1].coordGeodesic.Lon * GeoUtils.RADS2DEGS);

                    List<PointLatLng> listpoints = new List<PointLatLng>() { marker1, marker2 };
                    GMapPolygon polygon = new GMapPolygon(listpoints, "")
                    {
                        Stroke = new System.Drawing.Pen(System.Drawing.Color.FromArgb(color1.A, color1.R, color1.G, color1.B))
                    };
                    polygonsoverlay.Polygons.Add(polygon);
                }
                j++;

                if (j == listColors.Count()) { j = 0; }
            }

            Mapa.Overlays.Add(polygonsoverlay);

        }

        #region Functions to calculate Performances from ASTERIX file

        public void CalculatreProbabilityofUpdate(List<List<CAT10>> lista)
        {
            double counter_bueno = 0;
            double counter_total = 0;

            foreach (List<CAT10> trayectoria in lista)
            {
                for (int i = 0; i < trayectoria.Count() - 1; i++)
                {
                    double timedelay = trayectoria[i + 1].timetotal - trayectoria[i].timetotal;
                    if (timedelay <= 1.2) { counter_bueno++; }
                    counter_total ++;
                }
            }

            double probability;
            if (counter_total == 0) { probability = 0; }
            else { probability = (counter_bueno / counter_total) * 100; }
        }

        public void CalculateProbabilityofMLATDetection(List<List<CAT10>> lista)
        {
            for(int i = 0; i<lista.Count(); i++)
            {
                // Eliminamos los paquetes sin info de posición

                List<CAT10> list1 = lista[i];
                foreach(CAT10 packet in list1)
                {
                    if((packet.PositioninCartesianCoordinates.Length>0? 1 : 0) + (packet.MeasuredPositioninPolarCoordinates.Length>0? 1 : 0) > 0)
                    {
                        list1.Add(packet);
                    }


                }
            }
        }

        #endregion

        #region Buttons to calculate Performances from ASTERIX file
        private void pb_ProbabilityofUpdate_ED116_ASTERIXfile_Click(object sender, EventArgs e)
        {
            var trayectorias = CalculateTrajectories(listaSMR);
            CalculatreProbabilityofUpdate(trayectorias);
        }

        #endregion

        public List<List<CAT10>> CalculateTrajectories(List<CAT10> lista1SMRMessages)
        {
            List<Trayectoria> listTrajectories = new List<Trayectoria>();
            listTrajectories.Clear();

            List<CAT10> listaSMRMessages = new List<CAT10>();
            listaSMRMessages.AddRange(lista1SMRMessages);

            // Ahora eliminamos traficos SMR sin info de posición
            List<CAT10> list = new List<CAT10>();
            for(int i = 0; i<listaSMRMessages.Count(); i++)
            {
                if (listaSMRMessages[i].MeasuredPositioninPolarCoordinates.Length > 0)
                {
                    list.Add(listaSMRMessages[i]);
                }
            }
            listaSMRMessages.Clear();
            listaSMRMessages.AddRange(list);


            // Primero buscamos el primer y ultimo segundo de la simulacion
            double firstsecond = Math.Floor(listaSMRMessages.First().timetotal);
            double lastsecond = Math.Floor(listaSMRMessages.Last().timetotal);
            double second = firstsecond;
            int index = 0;
            int index_id = 0;

            // Establecemos condiciones iniciales (pimera iteración)

            // Primero hay que hacer que el algoritmo seleccione los vuelos en ese segundo
            List<CAT10> listplanesthissecond = new List<CAT10>();
            double time = Math.Floor(listaSMRMessages[index].timetotal);
            while (index < listaSMRMessages.Count() && time == second)
            {
                time = Math.Floor(listaSMRMessages[index].timetotal);
                listplanesthissecond.Add(listaSMRMessages[index]);
                index++;
            }

            // una vez calculados los paquetes en ese segundo creamos una trayectoria para cada uno
            for(int i = 0; i<listplanesthissecond.Count(); i++)
            {
                Trayectoria trayectoria = new Trayectoria(index_id, listplanesthissecond[i]);
                listTrajectories.Add(trayectoria);
                index_id++;
            }

            // Pasamos al siguiente segundo;
            second++;

            // Empezamos el algorizmo

            while (second < lastsecond)
            {
                // Primero hay que hacer que el algoritmo seleccione los vuelos en ese segundo de la manera más eficiente posible
                listplanesthissecond = new List<CAT10>();
                time = Math.Floor(listaSMRMessages[index].timetotal);
                while (index < listaSMRMessages.Count() && time == second)
                {
                    time = Math.Floor(listaSMRMessages[index].timetotal);
                    listplanesthissecond.Add(listaSMRMessages[index]);
                    index++;
                }

                // Ahora que sabemos contar los paquetes que hay en cada segundo podemos pasar a programar el algoritmo

                // ----------------------------------------------------------------------------------------------------------------------------------------------------------

                // Vamos trayectoria por trayectoria asignandole una nueva posición

                // primero marcamos las trayectoriaas como no actualizadas
                foreach (Trayectoria trajectory in listTrajectories)
                {
                    trajectory.updated = false;
                }

                foreach (Trayectoria trajectory in listTrajectories)
                {
                    if(trajectory.ended == false)
                    {
                        // Buscamos si hay algún paquete con el mismo track number
                        if(listplanesthissecond.Count() > 0)
                        {
                            for (int i = 0; i < listplanesthissecond.Count(); i++)
                            {
                                if (listplanesthissecond[i].Tracknumber_value == trajectory.listaSMR.Last().Tracknumber_value)
                                {
                                    trajectory.listaSMR.Add(listplanesthissecond[i]); // Añadimos el nuevo paquee a la lista
                                    listplanesthissecond.Remove(listplanesthissecond[i]); // Eliminamos el paquete de la lista
                                    trajectory.updated = true; // Marcamos esta lista como actualizada
                                }
                            }
                        }

                        // Si no hemos actualizado el paquete en la ronda anterior pasamos a calcular la siguiente posición con el algoritmo de tracking
                        if(listplanesthissecond.Count() > 0 && trajectory.updated == false)
                        {
                            // calculamos la distancia del ultimo punto de esta trayectoria con los paquetes de listplanesthissecond que hayan sobrado
                            List<double> listadistancias = new List<double>();

                            double U1 = trajectory.listaSMR.Last().coordStereographic.U;
                            double V1 = trajectory.listaSMR.Last().coordStereographic.V;

                            foreach(CAT10 paquete in listplanesthissecond)
                            {
                                double U2 = paquete.coordStereographic.U;
                                double v2 = paquete.coordStereographic.V;
                                listadistancias.Add(Math.Sqrt(Math.Pow(U2 - U1, 2) + Math.Pow(v2 - V1, 2)));
                            }

                            // aplicamos restriccion de distancia antes de añadir
                            if(listadistancias.Min() < 70)
                            {
                                int j = listadistancias.IndexOf(listadistancias.Min());
                                trajectory.listaSMR.Add(listplanesthissecond[j]);
                                listplanesthissecond.Remove(listplanesthissecond[j]);
                                trajectory.updated = true;
                            }
                            else
                            {
                                // Calculamos si hay que acabar esta trayectoria
                                trajectory.time_since_last_update++;
                                if(trajectory.time_since_last_update == 60) { trajectory.ended = true; }
                            }
                        }
                    }
                }

                // si al acabr la iteración todavia hay paquetes en listplanesthissecond que no tienen trayectoria hay que crear una trayectoria nueva para cada paquete (falta hacerlo)
                if (listplanesthissecond.Count() > 0)
                {
                    foreach(CAT10 paquete in listplanesthissecond)
                    {
                        Trayectoria trayectoria = new Trayectoria(index_id, paquete);
                        listTrajectories.Add(trayectoria);
                        index_id++;
                    }
                }

                // Al acabar, bajamos el contador de iteracíones sin actualizar de todas las trayectorias actualizadas a 0, para que el contador solo cuente le numero de iteraciones sin actualizar CONSECUTIVAS
                foreach (Trayectoria trayectoria in listTrajectories) 
                { 
                    if(trayectoria.updated == true)
                    {
                        trayectoria.time_since_last_update = 0;
                    } 
                }

                // Al acabar la iteración hay que setear todas las trayectorias a updtade = false; 

                foreach (Trayectoria trayectoria in listTrajectories) { trayectoria.updated = false; }

                // ----------------------------------------------------------------------------------------------------------------------------------------------------------

                second++;
            }

            // Pasamos las trayectorias a una lista de listas
            List<List<CAT10>> list_of_lists = new List<List<CAT10>>();
            foreach(Trayectoria trayectoria in listTrajectories)
            {
                list_of_lists.Add(trayectoria.listaSMR);
            }

            return list_of_lists;
        }

        public List<List<CAT10>> CalculateTrajectories1(List<CAT10> lista1SMRMessages)
        {
            List<Trayectoria> listTrajectories = new List<Trayectoria>();
            listTrajectories.Clear();

            List<CAT10> listaSMRMessages = new List<CAT10>();
            listaSMRMessages.AddRange(lista1SMRMessages);

            // Ahora eliminamos traficos SMR sin info de posición
            List<CAT10> list = new List<CAT10>();
            for (int i = 0; i < listaSMRMessages.Count(); i++)
            {
                if (listaSMRMessages[i].MeasuredPositioninPolarCoordinates.Length > 0)
                {
                    list.Add(listaSMRMessages[i]);
                }
            }
            listaSMRMessages.Clear();
            listaSMRMessages.AddRange(list);


            // Primero buscamos el primer y ultimo segundo de la simulacion
            double firstsecond = Math.Floor(listaSMRMessages.First().timetotal);
            double lastsecond = Math.Floor(listaSMRMessages.Last().timetotal);
            double second = firstsecond;
            int index = 0;
            int index_id = 0;

            // Establecemos condiciones iniciales (pimera iteración)

            // Primero hay que hacer que el algoritmo seleccione los vuelos en ese segundo
            List<CAT10> listplanesthissecond = new List<CAT10>();
            double time = Math.Floor(listaSMRMessages[index].timetotal);
            while (index < listaSMRMessages.Count() && time == second)
            {
                time = Math.Floor(listaSMRMessages[index].timetotal);
                listplanesthissecond.Add(listaSMRMessages[index]);
                index++;
            }

            // una vez calculados los paquetes en ese segundo creamos una trayectoria para cada uno
            for (int i = 0; i < listplanesthissecond.Count(); i++)
            {
                Trayectoria trayectoria = new Trayectoria(index_id, listplanesthissecond[i]);
                trayectoria.coordGeodesic_SMR = listplanesthissecond[i].coordGeodesic;
                trayectoria.coordStereographic_SMR = listplanesthissecond[i].coordStereographic;
                trayectoria.coordSystemCartesian_SMR = listplanesthissecond[i].coordSystemCartesian;

                listTrajectories.Add(trayectoria);

                Predict(trayectoria);

                index_id++;
            }

            // Pasamos al siguiente segundo;
            second++;

            // Empezamos el algorizmo

            while (second < lastsecond)
            {
                // Primero hay que hacer que el algoritmo seleccione los vuelos en ese segundo de la manera más eficiente posible
                listplanesthissecond = new List<CAT10>();
                time = Math.Floor(listaSMRMessages[index].timetotal);
                while (index < listaSMRMessages.Count() && time == second)
                {
                    time = Math.Floor(listaSMRMessages[index].timetotal);
                    listplanesthissecond.Add(listaSMRMessages[index]);
                    index++;
                }

                // Ahora que sabemos contar los paquetes que hay en cada segundo podemos pasar a programar el algoritmo
                // ----------------------------------------------------------------------------------------------------------------------------------------------------------

                // Vamos trayectoria por trayectoria asignandole una nueva posición

                // primero marcamos las trayectoriaas como no actualizadas
                foreach (Trayectoria trajectory in listTrajectories)
                {
                    trajectory.updated = false;
                }

                foreach (Trayectoria trajectory in listTrajectories)
                {
                    if (trajectory.ended == false)
                    {
                        // Buscamos si hay algún paquete con el mismo track number
                        if (listplanesthissecond.Count() > 0)
                        {
                            for (int i = 0; i < listplanesthissecond.Count(); i++)
                            {
                                if (listplanesthissecond[i].Tracknumber_value == trajectory.listaSMR.Last().Tracknumber_value)
                                {
                                    trajectory.listaSMR.Add(listplanesthissecond[i]); // Añadimos el nuevo paquee a la lista
                                    listplanesthissecond.Remove(listplanesthissecond[i]); // Eliminamos el paquete de la lista

                                    Update(trajectory);
                                    trajectory.updated = true; // Marcamos esta lista como actualizada
                                }
                            }
                        }

                        // Si no hemos actualizado el paquete en la ronda anterior pasamos a calcular la siguiente posición con el algoritmo de tracking
                        if (listplanesthissecond.Count() > 0 && trajectory.updated == false)
                        {
                            // calculamos la distancia del ultimo punto de esta trayectoria con los paquetes de listplanesthissecond que hayan sobrado
                            List<double> listadistancias = new List<double>();

                            //double U1 = trajectory.listaSMR.Last().coordStereographic.U;
                            //double V1 = trajectory.listaSMR.Last().coordStereographic.V;

                            double U1 = trajectory.coordStereographic_SMR.U;
                            double V1 = trajectory.coordStereographic_SMR.V;

                            foreach (CAT10 paquete in listplanesthissecond)
                            {
                                double U2 = paquete.coordStereographic.U;
                                double v2 = paquete.coordStereographic.V;
                                listadistancias.Add(Math.Sqrt(Math.Pow(U2 - U1, 2) + Math.Pow(v2 - V1, 2)));
                            }

                            // aplicamos restriccion de distancia antes de añadir
                            if (listadistancias.Min() < 70)
                            {
                                int j = listadistancias.IndexOf(listadistancias.Min());
                                trajectory.listaSMR.Add(listplanesthissecond[j]);

                                Update(trajectory);

                                listplanesthissecond.Remove(listplanesthissecond[j]);
                                trajectory.updated = true;
                            }
                            else
                            {
                                // Calculamos si hay que acabar esta trayectoria
                                trajectory.time_since_last_update++;
                                if (trajectory.time_since_last_update == 60) { trajectory.ended = true; }
                            }
                        }
                    }
                }

                // si al acabr la iteración todavia hay paquetes en listplanesthissecond que no tienen trayectoria hay que crear una trayectoria nueva para cada paquete (falta hacerlo)
                if (listplanesthissecond.Count() > 0)
                {
                    foreach (CAT10 paquete in listplanesthissecond)
                    {
                        Trayectoria trayectoria = new Trayectoria(index_id, paquete);
                        Update(trayectoria);
                        listTrajectories.Add(trayectoria);
                        index_id++;
                    }
                }

                // Al acabar, bajamos el contador de iteracíones sin actualizar de todas las trayectorias actualizadas a 0, para que el contador solo cuente le numero de iteraciones sin actualizar CONSECUTIVAS
                foreach (Trayectoria trayectoria in listTrajectories)
                {
                    if (trayectoria.updated == true)
                    {
                        trayectoria.time_since_last_update = 0;
                    }
                }

                // Al acabar la iteración hay que setear todas las trayectorias a updtade = false; 

                foreach (Trayectoria trayectoria in listTrajectories) { trayectoria.updated = false; }


                // ----------------------------------------------------------------------------------------------------------------------------------------------------------

                second++;
            }

            // Pasamos las trayectorias a una lista de listas
            List<List<CAT10>> list_of_lists = new List<List<CAT10>>();
            foreach (Trayectoria trayectoria in listTrajectories)
            {
                list_of_lists.Add(trayectoria.listaSMR);
            }

            return list_of_lists;
        }

        public void Predict(Trayectoria trayectoria)
        {
            // Calculate error covariance     P= A*P*A' + Q    

            var A_T = Accord.Math.Matrix.Transpose(trayectoria.A);
            var a2 = Accord.Math.Matrix.Dot(trayectoria.P, A_T);
            a2 = Accord.Math.Matrix.Dot(trayectoria.A, a2);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    trayectoria.P[i, j] = a2[i, j] + trayectoria.Q[i, j];
                }
            }
        }

        public void Update(Trayectoria trayectoria)
        {
            // Primero calculamos las coordenadas cartesianas del ultimo paquete de la lista SMR de esta trayectoria respecto al radar.
            CoordinatesXYZ coordGeocent = GeoUtils1.change_geodesic2geocentric(trayectoria.listaSMR.Last().coordGeodesic);
            CoordinatesXYZ coordRadarCart = GeoUtils1.change_geocentric2radar_cartesian(new CoordinatesWGS84(LatSMR, LonSMR), coordGeocent);
            trayectoria.deltaX = coordRadarCart.X;
            trayectoria.deltaY = coordRadarCart.Y;

            double[] dist1 = new double[] { trayectoria.deltaX, trayectoria.deltaY };
            var dist = Accord.Math.Matrix.Transpose(dist1);


            // Refer to :Eq.(11), Eq.(12) and Eq.(13) in     S = H*P*H'+R

            var a3 = Accord.Math.Matrix.Dot(trayectoria.P, Accord.Math.Matrix.Transpose(trayectoria.H));
            Double[,] S = new Double[2, 2];
            a3 = Accord.Math.Matrix.Dot(trayectoria.H, a3);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    S[i, j] = a3[i, j] + trayectoria.R[i, j];
                }
            }

            // Calculate the Kalman Gain     K = P * H'* inv(H*P*H'+R)

            var a4 = Accord.Math.Matrix.Dot(Accord.Math.Matrix.Transpose(trayectoria.H), Accord.Math.Matrix.Inverse(S));
            trayectoria.K = Accord.Math.Matrix.Dot(trayectoria.P, a4);

            var a5 = Accord.Math.Matrix.Dot(trayectoria.H, trayectoria.x);
            var a6 = a5;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    a6[i, j] = dist[i,j] - a5[i, j];
                }
            }

            var a7 = Accord.Math.Matrix.Dot(trayectoria.K, a6);

            for (int i = 0; i < 4; i++)
            {
                trayectoria.x[i, 0] = trayectoria.x[i, 0] + a7[i, 0];
            }

            // Con los nuevos valores de x,y calculamos la siguiente posición predecida por el algoritmo en coordenadas WGS 84
            double rho = 0;
            double theta = 0;
            if((trayectoria.x[0, 0]==0? 1 : 0)  + (trayectoria.x[1, 0]==0? 1 : 0) >0)
            {
                rho = Math.Sqrt(Math.Pow(trayectoria.x[0, 0], 2) + Math.Pow(trayectoria.x[1, 0], 2));
                theta = (180 / Math.PI) * Math.Atan2(trayectoria.x[0, 0], trayectoria.x[1, 0]);
            }
             
            var coord_wgs84 = NewCoordinates(trayectoria.listaSMR.Last().coordGeodesic.Lat * GeoUtils.RADS2DEGS, trayectoria.listaSMR.Last().coordGeodesic.Lon * GeoUtils.RADS2DEGS, rho, theta);
            trayectoria.coordGeodesic_SMR = new CoordinatesWGS84(coord_wgs84[0] * GeoUtils.DEGS2RADS, coord_wgs84[1] * GeoUtils.DEGS2RADS);

            // Calculamos coordenadas System Cartesian
            CoordinatesXYZ coordGeocentric = GeoUtils1.change_geodesic2geocentric(trayectoria.coordGeodesic_SMR);
            trayectoria.coordSystemCartesian_SMR = GeoUtils1.change_geocentric2system_cartesian(coordGeocentric);

            // Calculamos coordenadas Stereograficas
            trayectoria.coordStereographic_SMR = GeoUtils1.change_system_cartesian2stereographic(trayectoria.coordSystemCartesian_SMR);

            // Recalculamos la P

            var a8 = Accord.Math.Matrix.Dot(trayectoria.K, trayectoria.H);
            var I = Accord.Math.Matrix.Identity(4);
            var a9 = a8;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a9[i, j] = I[i,j] - a8[i, j];
                }
            }

            trayectoria.P = Accord.Math.Matrix.Dot(a9, trayectoria.P);

        }

        public List<Trafico> CalculateTrajectories2(List<CAT10> lista1SMRMessages, List<CAT10> lista1MLATMessages, List<CAT21> lista1CAT21Messages)
        {
            List<Trafico> listaTraficos = new List<Trafico>();

            List<Trayectoria> listTrajectories = new List<Trayectoria>();
            listTrajectories.Clear();

            List<CAT10> listaSMRMessages = new List<CAT10>();
            listaSMRMessages.AddRange(lista1SMRMessages);

            List<CAT10> listaMLATMessages = new List<CAT10>();
            listaMLATMessages.AddRange(lista1MLATMessages);

            List<CAT21> listaCAT21Messages = new List<CAT21>();
            listaCAT21Messages.AddRange(lista1CAT21Messages);

            // Eliminamos los paquetes muy lejos del aeropuerto de bcn (a +10 km ARP)
            listaCAT21Messages = FilterCAT21messagesAwayfromAirport(listaCAT21Messages, 10000);

            int index_SMR = 0;

            foreach(CAT10 smr in listaSMRMessages)
            {
                // Buscamos todos los paquetes CAT21 que estan a 1s de distancia del tiempo SMR
                List<CAT21> listaPacketCAT21 = new List<CAT21>();
                for(int i = 0; i < listaCAT21Messages.Count(); i++)
                {
                    double timedelay = Math.Abs(smr.timetotal - listaCAT21Messages[i].TimeofASTERIXReportTransmission_seconds);
                    if(timedelay <= 1)
                    {
                        listaPacketCAT21.Add(listaCAT21Messages[i]);
                    }
                }

                // Buscamos todos los paquetes MLAT que estan a 1s de distancia del tiempo SMR
                List<CAT10> listaPacketMLAT = new List<CAT10>();
                for (int i = 0; i < listaMLATMessages.Count(); i++)
                {
                    double timedelay = Math.Abs(smr.timetotal - listaMLATMessages[i].timetotal);
                    if (timedelay <= 1)
                    {
                        listaPacketMLAT.Add(listaMLATMessages[i]);
                    }
                }

                // Calculamos la distancia con cada uno de ellos

                List<double> listDistances_CAT21 = new List<double>();
                List<double> listDistances_MLAT = new List<double>();

                double U1 = smr.coordStereographic.U;
                double V1 = smr.coordStereographic.V;

                foreach (CAT21 cat21 in listaPacketCAT21)
                {
                    double U2 = cat21.coordStereographic.U;
                    double V2 = cat21.coordStereographic.V;

                    listDistances_CAT21.Add(Math.Sqrt(Math.Pow(U1 - U2, 2) + Math.Pow(V1 - V2, 2)));
                }

                foreach (CAT10 mlat in listaPacketMLAT)
                {
                    double U2 = mlat.coordStereographic.U;
                    double V2 = mlat.coordStereographic.V;

                    listDistances_MLAT.Add(Math.Sqrt(Math.Pow(U1 - U2, 2) + Math.Pow(V1 - V2, 2)));
                }

                // Una vez calculadas las distancias calculñamos distancia minima y asignamos ese paquete al trafico SMR 
                double distancia_limite = 50;
                if(listDistances_CAT21.Count() > 0 && listDistances_MLAT.Count() > 0)
                {
                    double distance_MLAT_Min = listDistances_MLAT.Min();
                    double distance_CAT21_Min = listDistances_CAT21.Min();

                    if(distance_CAT21_Min < distance_MLAT_Min)
                    {
                        if (listDistances_CAT21.Min() < distancia_limite)
                        {
                            int j1 = listDistances_CAT21.IndexOf(listDistances_CAT21.Min());
                            Trafico trafico1 = new Trafico(smr, listaPacketCAT21[j1]);
                            trafico1.distance = listDistances_CAT21.Min();
                            trafico1.TargetAddress = listaPacketCAT21[j1].TargetAdress_real;
                            listaTraficos.Add(trafico1);
                        }
                    }

                    else if (distance_CAT21_Min > distance_MLAT_Min)
                    {
                        if (listDistances_MLAT.Min() < distancia_limite)
                        {
                            int j1 = listDistances_MLAT.IndexOf(listDistances_MLAT.Min());
                            Trafico trafico1 = new Trafico(smr, listaPacketMLAT[j1]);
                            trafico1.distance = listDistances_MLAT.Min();
                            trafico1.TargetAddress = listaPacketMLAT[j1].TargetAdress_decoded;
                            listaTraficos.Add(trafico1);
                        }
                    }
                }

                else if(listDistances_CAT21.Count() > 0 && listDistances_MLAT.Count() == 0)
                {
                    if (listDistances_CAT21.Min() < distancia_limite)
                    {
                        int j1 = listDistances_CAT21.IndexOf(listDistances_CAT21.Min());
                        Trafico trafico1 = new Trafico(smr, listaPacketCAT21[j1]);
                        trafico1.distance = listDistances_CAT21.Min();
                        trafico1.TargetAddress = listaPacketCAT21[j1].TargetAdress_real;
                        listaTraficos.Add(trafico1);
                    }
                }

                else if (listDistances_CAT21.Count() == 0 && listDistances_MLAT.Count() > 0)
                {
                    if(listDistances_MLAT.Min() < distancia_limite)
                    {
                        int j1 = listDistances_MLAT.IndexOf(listDistances_MLAT.Min());
                        Trafico trafico = new Trafico(smr, listaPacketMLAT[j1]);
                        trafico.distance = listDistances_MLAT.Min();
                        trafico.TargetAddress = listaPacketMLAT[j1].TargetAdress_decoded;
                        listaTraficos.Add(trafico);
                    }
                }
            }

            //// Una vez calculados los traficos los organizamos por listas de listas

            //// primero sacamos lista de target address:

            //List<string> listaTargetAddress = new List<string>();
            //for(int i = 0; i<listaTraficos.Count(); i++)
            //{
            //    string TargetAddress = listaTraficos[i].TargetAddress;
            //    if (listaTargetAddress.Contains(TargetAddress))
            //    {

            //    }
            //    else
            //    {
            //        listaTargetAddress.Add(TargetAddress);
            //    }
            //}
            //List<List<CAT10>> lista_de_listas = new List<List<CAT10>>();
            //foreach(string TA in listaTargetAddress)
            //{
            //    List<CAT10> lista = new List<CAT10>();
            //    for (int i = 0; i < listaTraficos.Count(); i++)
            //    {
            //        if(listaTraficos[i].TargetAddress == TA) { lista.Add(listaTraficos[i].traficoSMR); }
            //    }
            //    lista_de_listas.Add(lista);
            //}

            return listaTraficos;


            //GMapOverlay overlay1 = new GMapOverlay();
            //Mapa.Overlays.Clear();

            //foreach (Trafico trafico in listaTraficos)
            //{
            //    PointLatLng marker = new PointLatLng(trafico.traficoSMR.coordGeodesic.Lat * GeoUtils.RADS2DEGS, trafico.traficoSMR.coordGeodesic.Lon * GeoUtils.RADS2DEGS);
            //    GMarkerGoogle marker1 = new GMarkerGoogle(marker, white_circle);

            //    PointLatLng marker2;
            //    GMarkerGoogle marker3;
            //    if (trafico.traficoCAT21 != null)
            //    {
            //        marker2 = new PointLatLng(trafico.traficoCAT21.coordGeodesic.Lat * GeoUtils.RADS2DEGS, trafico.traficoCAT21.coordGeodesic.Lon * GeoUtils.RADS2DEGS);
            //        marker3 = new GMarkerGoogle(marker2, green_circle);
            //    }
            //    else
            //    {
            //        marker2 = new PointLatLng(trafico.traficoMLAT.coordGeodesic.Lat * GeoUtils.RADS2DEGS, trafico.traficoMLAT.coordGeodesic.Lon * GeoUtils.RADS2DEGS);
            //        marker3 = new GMarkerGoogle(marker2, blue_circle);
            //    }

            //    GMapPolygon polygon = new GMapPolygon(new List<PointLatLng>() { marker, marker2 }, "")
            //    {
            //        Stroke = new System.Drawing.Pen(System.Drawing.Color.Red, 2),
            //        Fill = new SolidBrush(System.Drawing.Color.Red)
            //    };

            //    overlay1.Polygons.Add(polygon);
            //    overlay1.Markers.Add(marker1);
            //    overlay1.Markers.Add(marker3);

            //}

            //Mapa.Overlays.Add(overlay1);
        }

        public void FilterCAT10(List<CAT10> list)
        {
            List<CAT10> list1 = new List<CAT10>();
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].MessageType_decodified == "Target Report") { list1.Add(list[i]); }
            }
            list.Clear();
            list.AddRange(list1);
        }

        public void CalculateARP_MLAT_SMR_coordinates()
        {
            GeoUtils1 = new GeoUtils(E, A, new CoordinatesWGS84(LatARP * GeoUtils.DEGS2RADS, LonARP * GeoUtils.DEGS2RADS));

            // ARP

            //Calculamos Coordenadas Geodesic
            coordGeodesic_ARP = new CoordinatesWGS84(LatARP * GeoUtils.DEGS2RADS, LonARP * GeoUtils.DEGS2RADS);

            // Calculamos coordenadas System Cartesian
            CoordinatesXYZ coordGeocentric = GeoUtils1.change_geodesic2geocentric(coordGeodesic_ARP);
            coordSystemCartesian_ARP = GeoUtils1.change_geocentric2system_cartesian(coordGeocentric);

            // Calculamos coordenadas Stereograficas
            coordStereographic_ARP = GeoUtils1.change_system_cartesian2stereographic(coordSystemCartesian_ARP);

            // MLAT

            //Calculamos Coordenadas Geodesic
            coordGeodesic_MLAT = new CoordinatesWGS84(LatMLAT * GeoUtils.DEGS2RADS, LonMLAT * GeoUtils.DEGS2RADS);

            // Calculamos coordenadas System Cartesian
            CoordinatesXYZ coordGeocentric1 = GeoUtils1.change_geodesic2geocentric(coordGeodesic_MLAT);
            coordSystemCartesian_MLAT = GeoUtils1.change_geocentric2system_cartesian(coordGeocentric1);

            // Calculamos coordenadas Stereograficas
            coordStereographic_MLAT = GeoUtils1.change_system_cartesian2stereographic(coordSystemCartesian_MLAT);

            // SMR

            //Calculamos Coordenadas Geodesic
            coordGeodesic_SMR = new CoordinatesWGS84(LatSMR * GeoUtils.DEGS2RADS, LonSMR * GeoUtils.DEGS2RADS);

            // Calculamos coordenadas System Cartesian
            CoordinatesXYZ coordGeocentric2 = GeoUtils1.change_geodesic2geocentric(coordGeodesic_SMR);
            coordSystemCartesian_SMR = GeoUtils1.change_geocentric2system_cartesian(coordGeocentric2);

            // Calculamos coordenadas Stereograficas
            coordStereographic_SMR = GeoUtils1.change_system_cartesian2stereographic(coordSystemCartesian_SMR);
        } // Calculamos coordenadas Geodesicas, Stereograficas, System cartesian de los centros de coordenadas

        public List<CAT21> FilterCAT21messagesAwayfromAirport(List<CAT21> listaCAT21messages, double distance)
        {
            List<CAT21> result = new List<CAT21>();

            for (int i = 0; i < listaCAT21messages.Count(); i++)
            {
                // Coord ARP
                double U1 = coordStereographic_ARP.U;
                double V1 = coordStereographic_ARP.V;

                // Coord message CAT21
                double U2 = listaCAT21messages[i].coordStereographic.U;
                double V2 = listaCAT21messages[i].coordStereographic.V;

                // Distance
                double distancia = Math.Sqrt((U2 - U1) * (U2 - U1) + (V2 - V1) * (V2 - V1));

                if (distancia < distance) { result.Add(listaCAT21messages[i]); }
            }

            return result;
        } // Calculamos paquetes mas cercanos al aeropuerto

        public void ColorEveryTrackNumberAndPlotMap()
        {
            Mapa.Overlays.Clear();

            // Separamos los paquetes por Tracknumber

            List<double> listaSMRTrackNumbers = new List<double>();
            for (int i = 0; i < listaSMR.Count(); i++)
            {
                double tracknumber = listaSMR[i].Tracknumber_value;

                if (listaSMRTrackNumbers.Contains(tracknumber))
                {

                }
                else
                {
                    listaSMRTrackNumbers.Add(tracknumber);
                }
            }

            List<List<CAT10>> list_of_lists_of_tracknumber = new List<List<CAT10>>();

            foreach (double tracknumber in listaSMRTrackNumbers)
            {
                List<CAT10> list_of_tracknumbers = new List<CAT10>();
                for (int i = 0; i < listaSMR.Count(); i++)
                {
                    if (listaSMR[i].Tracknumber_value == tracknumber && listaSMR[i].TrackNumber.Length > 0)
                    {
                        list_of_tracknumbers.Add(listaSMR[i]);
                    }
                }
                list_of_lists_of_tracknumber.Add(list_of_tracknumbers);
            }

            // Pintamos los trayectos por Track Number
            GMapOverlay polygonsoverlay = new GMapOverlay();
            int j = 0;
            foreach (List<CAT10> list in list_of_lists_of_tracknumber)
            {
                for (int i = 0; i < list.Count() - 1; i++)
                {
                    SolidColorBrush color;
                    System.Windows.Media.Color color1;
                    try
                    {
                        color = new SolidColorBrush((Color)ColorConverter.ConvertFromString(listColors[j]));
                        color1 = Color.FromArgb(color.Color.A, color.Color.R, color.Color.G, color.Color.B);
                    }
                    catch
                    {
                        color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff0000"));
                        color1 = Color.FromArgb(color.Color.A, color.Color.R, color.Color.G, color.Color.B);
                    }

                    PointLatLng marker1 = new PointLatLng(list[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, list[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS);
                    PointLatLng marker2 = new PointLatLng(list[i + 1].coordGeodesic.Lat * GeoUtils.RADS2DEGS, list[i + 1].coordGeodesic.Lon * GeoUtils.RADS2DEGS);

                    List<PointLatLng> listpoints = new List<PointLatLng>() { marker1, marker2 };
                    GMapPolygon polygon = new GMapPolygon(listpoints, "")
                    {
                        Stroke = new System.Drawing.Pen(System.Drawing.Color.FromArgb(color1.A, color1.R, color1.G, color1.B))
                    };
                    polygonsoverlay.Polygons.Add(polygon);
                }
                j++;

                if (j == listColors.Count()) { j = 0; }
            }

            Mapa.Overlays.Add(polygonsoverlay);
        }

        public double toRadians(double grados)
        {
            return grados * Math.PI / 180;
        }
        public double toDegrees(double radians)
        {
            return radians * 180 / (Math.PI);
        }

        public double[] NewCoordinates(double lat, double lon, double distance, double initialBearing)
        {
            double[] listaCoordenadas = new double[2];


            double φ1 = toRadians(lat);
            double λ1 = toRadians(lon);
            double α1 = toRadians(initialBearing);
            double s = distance;

            // allow alternative ellipsoid to be specified
            double a = 6378137.0;
            double b = 6356752.314245;
            double f = 1 / 298.257223563;

            double sinα1 = Math.Sin(α1);
            double cosα1 = Math.Cos(α1);

            double tanU1 = (1 - f) * Math.Tan(φ1), cosU1 = 1 / Math.Sqrt((1 + tanU1 * tanU1)), sinU1 = tanU1 * cosU1;
            double σ1 = Math.Atan2(tanU1, cosα1); // σ1 = angular distance on the sphere from the equator to P1
            double sinα = cosU1 * sinα1;          // α = azimuth of the geodesic at the equator
            double cosSqα = 1 - sinα * sinα;
            double uSq = cosSqα * (a * a - b * b) / (b * b);
            double A = 1 + uSq / 16384 * (4096 + uSq * (-768 + uSq * (320 - 175 * uSq)));
            double B = uSq / 1024 * (256 + uSq * (-128 + uSq * (74 - 47 * uSq)));

            double σ = s / (b * A);
            double sinσ;
            double cosσ;
            double Δσ; // σ = angular distance P₁ P₂ on the sphere
            double cos2σₘ; // σₘ = angular distance on the sphere from the equator to the midpoint of the line

            double σ_prima; int iterations = 0;
            do
            {
                cos2σₘ = Math.Cos(2 * σ1 + σ);
                sinσ = Math.Sin(σ);
                cosσ = Math.Cos(σ);
                Δσ = B * sinσ * (cos2σₘ + B / 4 * (cosσ * (-1 + 2 * cos2σₘ * cos2σₘ) -
                    B / 6 * cos2σₘ * (-3 + 4 * sinσ * sinσ) * (-3 + 4 * cos2σₘ * cos2σₘ)));
                σ_prima = σ;
                σ = s / (b * A) + Δσ;
            } while (Math.Abs(σ - σ_prima) > 1e-12 && ++iterations < 100);
            //if (iterations >= 100) throw new EvalError('Vincenty formula failed to converge'); // not possible?

            double x = sinU1 * sinσ - cosU1 * cosσ * cosα1;
            double φ2 = Math.Atan2(sinU1 * cosσ + cosU1 * sinσ * cosα1, (1 - f) * Math.Sqrt(sinα * sinα + x * x));
            double λ = Math.Atan2(sinσ * sinα1, cosU1 * cosσ - sinU1 * sinσ * cosα1);
            double C = f / 16 * cosSqα * (4 + f * (4 - 3 * cosSqα));
            double L = λ - (1 - C) * f * sinα * (σ + C * sinσ * (cos2σₘ + C * cosσ * (-1 + 2 * cos2σₘ * cos2σₘ)));
            double λ2 = λ1 + L;

            double α2 = Math.Atan2(sinα, -x);

            listaCoordenadas[0] = toDegrees(φ2);
            listaCoordenadas[1] = toDegrees(λ2);

            double coord1 = φ2;
            int sec1 = (int)Math.Round(coord1 * 3600);
            int deg1 = sec1 / 3600;
            sec1 = Math.Abs(sec1 % 3600);
            int min1 = sec1 / 60;
            sec1 %= 60;

            double coord2 = λ2;
            int sec2 = (int)Math.Round(coord2 * 3600);
            int deg2 = sec2 / 3600;
            sec2 = Math.Abs(sec2 % 3600);
            int min2 = sec2 / 60;
            sec2 %= 60;

            return listaCoordenadas;
        }

        public double CalculateDistanceBetweenCoordinates(double[] initial_coordinates, double[] final_coordinates)
        {
            double φ1 = toRadians(initial_coordinates[0]);
            double φ2 = toRadians(final_coordinates[0]);
            double λ1 = toRadians(initial_coordinates[1]);
            double λ2 = toRadians(final_coordinates[1]);

            double lat1 = φ1;
            double lon1 = λ1;
            double lat2 = φ2;
            double lon2 = λ2;

            double a = 6378137.0;
            double b = 6356752.314245;
            double f = 1 / 298.257223563;

            double L = (lon2 - lon1);
            double U1 = Math.Atan((1 - f) * Math.Tan(lat1));
            double U2 = Math.Atan((1 - f) * Math.Tan(lat2));
            double sinU1 = Math.Sin(U1),
            cosU1 = Math.Cos(U1);
            double sinU2 = Math.Sin(U2),
            cosU2 = Math.Cos(U2);

            double lambda = L, lambdaP, iterLimit = 100;

            double cosSqAlpha;
            double sinSigma;
            double cos2SigmaM;
            double cosSigma;
            double sigma;

            do
            {
                double sinLambda = Math.Sin(lambda),
                cosLambda = Math.Cos(lambda);
                sinSigma = Math.Sqrt((cosU2 * sinLambda) * (cosU2 * sinLambda) + (cosU1 * sinU2 - sinU1 * cosU2 * cosLambda) * (cosU1 * sinU2 - sinU1 * cosU2 * cosLambda));
                if (sinSigma == 0) return 0; // co-incident points
                cosSigma = sinU1 * sinU2 + cosU1 * cosU2 * cosLambda;
                sigma = Math.Atan2(sinSigma, cosSigma);
                double sinAlpha = cosU1 * cosU2 * sinLambda / sinSigma;
                cosSqAlpha = 1 - sinAlpha * sinAlpha;
                cos2SigmaM = cosSigma - 2 * sinU1 * sinU2 / cosSqAlpha;
                double C = f / 16 * cosSqAlpha * (4 + f * (4 - 3 * cosSqAlpha));
                lambdaP = lambda;
                lambda = L + (1 - C) * f * sinAlpha * (sigma + C * sinSigma * (cos2SigmaM + C * cosSigma * (-1 + 2 * cos2SigmaM * cos2SigmaM)));
            } while (Math.Abs(lambda - lambdaP) > 1e-12 && --iterLimit > 0);

            var uSq = cosSqAlpha * (a * a - b * b) / (b * b);
            var A = 1 + uSq / 16384 * (4096 + uSq * (-768 + uSq * (320 - 175 * uSq)));
            var B = uSq / 1024 * (256 + uSq * (-128 + uSq * (74 - 47 * uSq)));
            var deltaSigma = B * sinSigma * (cos2SigmaM + B / 4 * (cosSigma * (-1 + 2 * cos2SigmaM * cos2SigmaM) - B / 6 * cos2SigmaM * (-3 + 4 * sinSigma * sinSigma) * (-3 + 4 * cos2SigmaM * cos2SigmaM)));
            var s = b * A * (sigma - deltaSigma);
            var α1 = Math.Atan2(cosU2 * Math.Sin(L), cosU1 * sinU2 - sinU1 * cosU2 * Math.Cos(L));
            var α2 = Math.Atan2(cosU1 * Math.Sin(L), -1 * sinU1 * cosU2 + cosU1 * sinU2 * Math.Cos(L));

            double heading_btw_points = toDegrees(α2);

            return s;
        }

        public double CalculateHeadingBetweenCoordinates(double[] initial_coordinates, double[] final_coordinates)
        {
            double φ1 = toRadians(initial_coordinates[0]);
            double φ2 = toRadians(final_coordinates[0]);
            double λ1 = toRadians(initial_coordinates[1]);
            double λ2 = toRadians(final_coordinates[1]);

            double lat1 = φ1;
            double lon1 = λ1;
            double lat2 = φ2;
            double lon2 = λ2;

            double a = 6378137.0;
            double b = 6356752.314245;
            double f = 1 / 298.257223563;

            double L = (lon2 - lon1);
            double U1 = Math.Atan((1 - f) * Math.Tan(lat1));
            double U2 = Math.Atan((1 - f) * Math.Tan(lat2));
            double sinU1 = Math.Sin(U1),
            cosU1 = Math.Cos(U1);
            double sinU2 = Math.Sin(U2),
            cosU2 = Math.Cos(U2);

            double lambda = L, lambdaP, iterLimit = 100;

            double cosSqAlpha;
            double sinSigma;
            double cos2SigmaM;
            double cosSigma;
            double sigma;

            do
            {
                double sinLambda = Math.Sin(lambda),
                cosLambda = Math.Cos(lambda);
                sinSigma = Math.Sqrt((cosU2 * sinLambda) * (cosU2 * sinLambda) + (cosU1 * sinU2 - sinU1 * cosU2 * cosLambda) * (cosU1 * sinU2 - sinU1 * cosU2 * cosLambda));
                if (sinSigma == 0) return 0; // co-incident points
                cosSigma = sinU1 * sinU2 + cosU1 * cosU2 * cosLambda;
                sigma = Math.Atan2(sinSigma, cosSigma);
                double sinAlpha = cosU1 * cosU2 * sinLambda / sinSigma;
                cosSqAlpha = 1 - sinAlpha * sinAlpha;
                cos2SigmaM = cosSigma - 2 * sinU1 * sinU2 / cosSqAlpha;
                double C = f / 16 * cosSqAlpha * (4 + f * (4 - 3 * cosSqAlpha));
                lambdaP = lambda;
                lambda = L + (1 - C) * f * sinAlpha * (sigma + C * sinSigma * (cos2SigmaM + C * cosSigma * (-1 + 2 * cos2SigmaM * cos2SigmaM)));
            } while (Math.Abs(lambda - lambdaP) > 1e-12 && --iterLimit > 0);

            var uSq = cosSqAlpha * (a * a - b * b) / (b * b);
            var A = 1 + uSq / 16384 * (4096 + uSq * (-768 + uSq * (320 - 175 * uSq)));
            var B = uSq / 1024 * (256 + uSq * (-128 + uSq * (74 - 47 * uSq)));
            var deltaSigma = B * sinSigma * (cos2SigmaM + B / 4 * (cosSigma * (-1 + 2 * cos2SigmaM * cos2SigmaM) - B / 6 * cos2SigmaM * (-3 + 4 * sinSigma * sinSigma) * (-3 + 4 * cos2SigmaM * cos2SigmaM)));
            var s = b * A * (sigma - deltaSigma);
            var α1 = Math.Atan2(cosU2 * Math.Sin(L), cosU1 * sinU2 - sinU1 * cosU2 * Math.Cos(L));
            var α2 = Math.Atan2(cosU1 * Math.Sin(L), -1 * sinU1 * cosU2 + cosU1 * sinU2 * Math.Cos(L));

            double heading_btw_points = toDegrees(α2);

            return heading_btw_points;
        }


    }
}
