using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LIBRERIACLASES
{
    public class MLATCalibrationData
    {
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
        public TimeSpan time;

        public MLATCalibrationData(string cosa00, string cosa11, string cosa22, string cosa33, string cosa44, string cosa55, string cosa66, string cosa77, string cosa88, string cosa99)
        {
            try { this.Code = Convert.ToDouble(cosa00.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.Lat = Convert.ToDouble(cosa11.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.Lon = Convert.ToDouble(cosa22.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.Alt = Convert.ToDouble(cosa33.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.Day = Convert.ToDouble(cosa44.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.Month = Convert.ToDouble(cosa55.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.Year = Convert.ToDouble(cosa66.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.Hour = Convert.ToDouble(cosa77.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.Min = Convert.ToDouble(cosa88.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.Sec = Convert.ToDouble(cosa99.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }

            time = TimeSpan.FromSeconds(this.Hour * 3600 + this.Min * 60 + this.Sec);
        }
    }
}
