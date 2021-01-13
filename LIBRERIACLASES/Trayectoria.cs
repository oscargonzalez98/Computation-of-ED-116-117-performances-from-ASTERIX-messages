using System;
using System.Collections.Generic;
using MultiCAT6.Utils;

namespace LIBRERIACLASES
{
    public class Trayectoria
    {
        public int id;
        public int time_since_last_update = 0;

        public bool ended = false;
        public bool updated = false;

        public List<CAT10> listaSMR = new List<CAT10>();
        public List<CAT10> lista_MLAT = new List<CAT10>();

        //public List<List<double>> lista_distancias_SMR = new List<List<double>>();
        //public List<double> lista_distancias_min = new List<double>();
        public List<Pack> lista_Packs = new List<Pack>();

        public Double[,] A = new Double[4, 4];
        public Double[,] B = new Double[4, 2];
        public Double[,] H = new Double[2, 4];
        public Double[,] Q = new Double[4, 4];
        public Double[,] R = new Double[2, 2];
        public Double[,] x = new Double[4, 1];
        public Double[,] u = new Double[2, 2];
        public Double[,] P = new Double[4, 4];
        public Double[,] K;

        public double deltaX;
        public double deltaY;

        // Centro de coordenadas SMR
        double LatSMR = 41 + (17.0 / 60.0) + (44.226 / 3600);
        double LonSMR = 02 + (05.0 / 60.0) + (42.411 / 3600);

        // Centro de coordenadas MLAT
        double LatMLAT = 41 + (17.0 / 60.0) + (49.426 / 3600);
        double LonMLAT = 02 + (04.0 / 60.0) + (42.410 / 3600);

        // Coordenadas ARP
        double LatARP = 41 + (17.0 / 60.0) + (49.426 / 3600);
        double LonARP = 02 + (04.0 / 60.0) + (42.410 / 3600);

        GeoUtils GeoUtils1;

        public CoordinatesWGS84 coordGeodesic_SMR;
        public CoordinatesUVH coordStereographic_SMR;
        public CoordinatesXYZ coordSystemCartesian_SMR;

        public Trayectoria()
        {

        }

        public Trayectoria(int id, CAT10 paquete)
        {
            this.id = id;
            listaSMR.Add(paquete);
            GeoUtils1 = new GeoUtils(Math.Sqrt(0.00669437999013), 6378137.0);

            double delta_t = 1;

            double Vx = paquete.GroundSpeed * 1852 * Math.Cos(GeoUtils.DEGS2RADS * paquete.TrackAngle);
            double Vy = paquete.GroundSpeed * 1852 * Math.Sin(GeoUtils.DEGS2RADS * paquete.TrackAngle);

            double Ax = paquete.CalculatedAcceleration_X;
            double Ay = paquete.CalculatedAcceleration_Y;

            double std_acc = 1;
            double x_std_meas = 0.1;
            double y_std_meas = 0.1;

            A[0, 0] = 1;
            A[0, 1] = 0;
            A[0, 2] = delta_t;
            A[0, 3] = 0;

            A[1, 0] = 0;
            A[1, 1] = 1;
            A[1, 2] = 0;
            A[1, 3] = delta_t;

            A[2, 0] = 0;
            A[2, 1] = 0;
            A[2, 2] = 1;
            A[2, 3] = 0;

            A[3, 0] = 0;
            A[3, 1] = 0;
            A[3, 2] = 0;
            A[3, 3] = 1;

            B[0, 0] = 0.5 * Math.Pow(delta_t, 2);
            B[0, 1] = 0;

            B[1, 0] = 0;
            B[1, 1] = 0.5 * Math.Pow(delta_t, 2);

            B[2, 0] = delta_t;
            B[2, 1] = 0;

            B[3, 0] = 0;
            B[3, 1] = delta_t;

            H[0, 0] = 1;
            H[0, 1] = 0;
            H[0, 2] = 0;
            H[0, 3] = 0;

            H[1, 0] = 0;
            H[1, 1] = 1;
            H[1, 2] = 0;
            H[1, 3] = 0;

            Q[0, 0] = Math.Pow(delta_t, 4) / 4;
            Q[0, 1] = 0;
            Q[0, 2] = Math.Pow(delta_t, 3) / 2;
            Q[0, 3] = 0;

            Q[1, 0] = 0;
            Q[1, 1] = Math.Pow(delta_t, 4) / 4;
            Q[1, 2] = 0;
            Q[1, 3] = Math.Pow(delta_t, 3) / 2;

            Q[2, 0] = Math.Pow(delta_t, 3) / 2;
            Q[2, 1] = 0;
            Q[2, 2] = Math.Pow(delta_t, 2);
            Q[2, 3] = 0;

            Q[3, 0] = 0;
            Q[3, 1] = Math.Pow(delta_t, 3) / 2;
            Q[3, 2] = 0;
            Q[3, 3] = Math.Pow(delta_t, 2);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Q[i, j] = Q[i, j] * Math.Pow(std_acc, 2);
                }
            }

            R[0, 0] = Math.Pow(x_std_meas, 2);
            R[0, 1] = 0;

            R[1, 0] = 0;
            R[1, 1] = Math.Pow(y_std_meas, 2);

            // sponemos que el trafico esta en 0,0
            x[0, 0] = 0;
            x[1, 0] = 0;
            x[2, 0] = Vx;
            x[3, 0] = Vy;

            u[0, 0] = Ax;
            u[1, 0] = Ay;
        }

        public void SetInitialConditions()
        {
            
        }
    }
}
