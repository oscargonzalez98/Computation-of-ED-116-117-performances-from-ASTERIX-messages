using System;
using System.Collections.Generic;
using System.Text;

namespace LIBRERIACLASES
{
    public class MLATCalibrationData
    {
        public double cosa0;
        public double cosa1;
        public double cosa2;
        public double cosa3;
        public double cosa4;
        public double cosa5;
        public double cosa6;
        public double cosa7;
        public double cosa8;
        public double cosa9;

        public MLATCalibrationData(string cosa00, string cosa11, string cosa22, string cosa33, string cosa44, string cosa55, string cosa66, string cosa77, string cosa88, string cosa99)
        {
            try { this.cosa0 = Convert.ToDouble(cosa00.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.cosa1 = Convert.ToDouble(cosa11.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.cosa2 = Convert.ToDouble(cosa22.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.cosa3 = Convert.ToDouble(cosa33.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.cosa4 = Convert.ToDouble(cosa44.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.cosa5 = Convert.ToDouble(cosa55.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.cosa6 = Convert.ToDouble(cosa66.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.cosa7 = Convert.ToDouble(cosa77.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.cosa8 = Convert.ToDouble(cosa88.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }
            try { this.cosa9 = Convert.ToDouble(cosa99.Replace(Convert.ToChar("."), Convert.ToChar(","))); } catch { }

        }
    }
}
