using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MultiCAT6.Utils;

namespace LIBRERIACLASES
{
    public class MLATCalibrationData
    {
        // Centro de coordenadas SMR
        double LatSMR = 41 + (17.0 / 60.0) + (44.226 / 3600);
        double LonSMR = 02 + (05.0 / 60.0) + (42.411 / 3600);

        // Centro de coordenadas MLAT
        double LatMLAT = 41 + (17.0 / 60.0) + (49.426 / 3600);
        double LonMLAT = 02 + (04.0 / 60.0) + (42.410 / 3600);
        //double LatMLAT = 41.297063;
        //double LonMLAT = 2.078447;

        // Coordenadas ARP
        double LatARP = 41 + (17.0 / 60.0) + (49.426 / 3600);
        double LonARP = 02 + (04.0 / 60.0) + (42.410 / 3600);

        double E = Math.Sqrt(0.00669437999013);
        double A = 6378137.0;

        GeoUtils GeoUtils1;

        public double Code = 1e10;
        public double Lat = 1e10;
        public double Lon = 1e10;
        public double Alt = 1e10;
        public double Day = 1e10;
        public double Month = 1e10;
        public double Year = 1e10;
        public double Hour = 1e10;
        public double Min = 1e10;
        public double Sec = 1e10;
        public TimeSpan timespan;
        public double time1;
        public double timetotal;

        public CoordinatesWGS84 coordGeodesic;
        public CoordinatesXYZ coordSystemCartesian;
        public CoordinatesUVH coordStereographic;


        public MLATCalibrationData(string cosa00, string cosa11, string cosa22, string cosa33, string cosa44, string cosa55, string cosa66, string cosa77, string cosa88, string cosa99)
        {
            GeoUtils1 = new GeoUtils(E, A, new CoordinatesWGS84(LatARP * GeoUtils.DEGS2RADS, LonARP * GeoUtils.DEGS2RADS, 0));

            if (cosa00 != "") { this.Code = Convert.ToDouble(cosa00.Replace(Convert.ToChar("."), Convert.ToChar(","))); }
            this.Lat = Convert.ToDouble(cosa11.Replace(Convert.ToChar("."), Convert.ToChar(",")));
            this.Lon = Convert.ToDouble(cosa22.Replace(Convert.ToChar("."), Convert.ToChar(",")));
            if (cosa33 != "") { this.Alt = Convert.ToDouble(cosa33.Replace(Convert.ToChar("."), Convert.ToChar(","))); }
            if (cosa44 != "") { this.Day = Convert.ToDouble(cosa44.Replace(Convert.ToChar("."), Convert.ToChar(","))); }
            if (cosa55 != "") { this.Month = Convert.ToDouble(cosa55.Replace(Convert.ToChar("."), Convert.ToChar(","))); }
            if (cosa66 != "") { this.Year = Convert.ToDouble(cosa66.Replace(Convert.ToChar("."), Convert.ToChar(","))); }
            this.Hour = Convert.ToDouble(cosa77.Replace(Convert.ToChar("."), Convert.ToChar(",")));
            this.Min = Convert.ToDouble(cosa88.Replace(Convert.ToChar("."), Convert.ToChar(",")));
            this.Sec = Convert.ToDouble(cosa99.Replace(Convert.ToChar("."), Convert.ToChar(",")));

            timespan = TimeSpan.FromSeconds(this.Hour * 3600 + this.Min * 60 + this.Sec);
            time1 = Hour * 3600 + Min * 60 + Sec;
            timetotal = time1;


            // Calculamos Coordenadas Geodesicas:
            coordGeodesic = new CoordinatesWGS84(Lat*GeoUtils.DEGS2RADS, Lon*GeoUtils.DEGS2RADS);
            if (Alt != 10e6) { coordGeodesic.Height = Alt; }
            else { coordGeodesic.Height = 0; }

            // Calculamos coordenadas System Cartesian:
            CoordinatesXYZ coordGeocentric = GeoUtils1.change_geodesic2geocentric(coordGeodesic);
            coordSystemCartesian = GeoUtils1.change_geocentric2system_cartesian(coordGeocentric);

            // Calculamos coordenadas Stereograficas:
            coordStereographic = GeoUtils1.change_system_cartesian2stereographic(coordSystemCartesian);

        }
    }
}
