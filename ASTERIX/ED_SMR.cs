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

namespace ASTERIX
{
    public partial class ED_SMR : Form
    {
        public class Trajectory
        {
            public int id;
            public int time_since_last_update = 0;

            public bool ended = false;
            public bool updated = false;

            public List<CAT10> listaSMR = new List<CAT10>();
            public List<CAT10> lista_MLAT = new List<CAT10>();

            public Trajectory(int id)
            {
                this.id = id;
            }
        }

        public static List<string> listColors = new List<string>() { "#3F51B5", "#009688", "#FF5722", "#607D8B", "#FF9800", "#9C27B0", "#2196F3", "#EA676C", "#E41A4A", "#5978BB", "#018790", "#0E3441", "#00B0AD", "#721D47", "#EA4833", "#EF937E", "#F37521", "#A12059", "#126881", "#8BC240", "#364D5B", "#C7DC5B", "#0094BC", "#E4126B", "#43B76E", "#7BCFE9", "B71C46" };

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
        }

        // Creamos función que asigna un color random de una lista
        public void ColorRandom()
        {

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

            List<CAT10> listaSMR = list1.OrderBy(o => o.timetotal).ToList();
            List<CAT10> listaMAT = list2.OrderBy(o => o.timetotal).ToList();

            // Eliminamos paquetes sin info de
            // - track number 
            // - posición

            FilterSMR(listaSMR);

            // Calculamos las tryectorias
            CalculateTrajectories(listaSMR);

            // Creamos Mapa

            Mapa.DragButton = MouseButtons.Left;
            Mapa.CanDragMap = true;
            Mapa.MapProvider = GMapProviders.OpenCycleLandscapeMap;
            Mapa.Position = new PointLatLng(41, 2);
            Mapa.MinZoom = 1;
            Mapa.MaxZoom = 30;
            Mapa.Zoom = 8;
            Mapa.AutoScroll = true;

            GMapOverlay overlay = new GMapOverlay();
            for(int i = 0; i<listaSMR.Count(); i++)
            {
                PointLatLng marker = new PointLatLng(listaSMR[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listaSMR[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS);
                GMarkerGoogle marker1 = new GMarkerGoogle(marker, red_circle);
                overlay.Markers.Add(marker1);
            }
            Mapa.Overlays.Add(overlay);
        }

        public void CalculateTrajectories(List<CAT10> listaSMRMessages)
        {
            List<Trajectory> listTrajectories = new List<Trajectory>();

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
                Trajectory trayectoria = new Trajectory(i);
                trayectoria.listaSMR.Add(listplanesthissecond[i]);
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
                foreach (Trajectory trajectory in listTrajectories)
                {
                    trajectory.updated = false;
                }

                foreach (Trajectory trajectory in listTrajectories)
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
                        Trajectory trayectoria = new Trajectory(index_id);
                        trayectoria.listaSMR.Add(paquete);
                        listTrajectories.Add(trayectoria);
                        index_id++;
                    }
                }

                // Al acabar la iteración hay que setear todas las trayectorias a updtade = false;

                foreach (Trajectory trayectoria in listTrajectories) { trayectoria.updated = false; }

                // ----------------------------------------------------------------------------------------------------------------------------------------------------------

                second++;
            }

            // Separamos los paquetes por Tracknumber

            List<double> listaSMRTrackNumbers = new List<double>();
            for (int i = 0; i < listaSMRMessages.Count(); i++)
            {
                double tracknumber = listaSMRMessages[i].Tracknumber_value;

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
                for (int i = 0; i < listaSMRMessages.Count(); i++)
                {
                    if (listaSMRMessages[i].Tracknumber_value == tracknumber && listaSMRMessages[i].TrackNumber.Length > 0)
                    {
                        list_of_tracknumbers.Add(listaSMRMessages[i]);
                    }
                }
                list_of_lists_of_tracknumber.Add(list_of_tracknumbers);
            }


            //for (int i = listTrajectories.Count() - 1; i > 0; i--)
            //{
            //    if (listTrajectories[i].listaSMR.Count() < 50) { listTrajectories.Remove(listTrajectories[i]); }
            //}

            //for (int i = list_of_lists_of_tracknumber.Count() - 1; i > 0; i--)
            //{
            //    if (list_of_lists_of_tracknumber[i].Count() < 50) { list_of_lists_of_tracknumber.Remove(list_of_lists_of_tracknumber[i]); }
            //}



            //Mapa.Overlays.Clear();
            //// Pintamos los trayectos por Track Number
            //GMapOverlay polygonsoverlay = new GMapOverlay();
            //int k = 0;
            //foreach (Trajectory trayectoria in listTrajectories)
            //{
            //    var list = trayectoria.listaSMR;
            //    for (int i = 0; i < list.Count() - 1; i++)
            //    {
            //        SolidColorBrush color;
            //        System.Windows.Media.Color color1;
            //        try
            //        {
            //            color = new SolidColorBrush((Color)ColorConverter.ConvertFromString(listColors[k]));
            //            color1 = Color.FromArgb(color.Color.A, color.Color.R, color.Color.G, color.Color.B);
            //        }
            //        catch
            //        {
            //            color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff0000"));
            //            color1 = Color.FromArgb(color.Color.A, color.Color.R, color.Color.G, color.Color.B);
            //        }

            //        PointLatLng marker1 = new PointLatLng(list[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, list[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS);
            //        PointLatLng marker2 = new PointLatLng(list[i + 1].coordGeodesic.Lat * GeoUtils.RADS2DEGS, list[i + 1].coordGeodesic.Lon * GeoUtils.RADS2DEGS);

            //        List<PointLatLng> listpoints = new List<PointLatLng>() { marker1, marker2 };
            //        GMapPolygon polygon = new GMapPolygon(listpoints, "")
            //        {
            //            Stroke = new System.Drawing.Pen(System.Drawing.Color.FromArgb(color1.A, color1.R, color1.G, color1.B))
            //        };
            //        polygonsoverlay.Polygons.Add(polygon);
            //    }
            //    k++;

            //    if (k == listColors.Count()) { k = 0; }
            //}

            //Mapa.Overlays.Add(polygonsoverlay);
        }

        public void FilterSMR(List<CAT10> list)
        {
            List<CAT10> list1 = new List<CAT10>();
            for(int i = 0; i<list.Count(); i++)
            {
                if (list[i].TrackNumber.Length > 0) { list1.Add(list[i]); }
            }
            list.Clear();
            list.AddRange(list1);

            List<CAT10> list2 = new List<CAT10>();
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].PositioninCartesianCoordinates.Length != 0 && list[i].MeasuredPositioninPolarCoordinates.Length != 0) { list2.Add(list[i]); }
            }
            list.Clear();
            list.AddRange(list2);

        }

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
    }
}
