using System;
using System.Collections.Generic;
using System.Text;

namespace LIBRERIACLASES
{
    public class IndividualBar
    {
        public string TargetIdentification;
        public string TargetAddress;
        public double AverageTime;

        public IndividualBar(string TargetIdentification, string TargetAddress, double AverageTime)
        {
            this.TargetIdentification = TargetIdentification;
            this.TargetAddress = TargetAddress;
            this.AverageTime = AverageTime;
        }
    }
}
