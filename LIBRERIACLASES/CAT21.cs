using System;
using System.Collections.Generic;
using System.Text;

using System.Text.RegularExpressions;
using DotNetMatrix;
using MultiCAT6.Utils;

namespace LIBRERIACLASES
{
    public class CAT21
    {
        int i = 0;
        public string[] paquete;
        public string[] arrayFSPEC;
        public string FSPEC;
        public string FSPEC_fake;
        public int data_position = 0;

        public string DataSourseIdentification = "";
        public int SAC;
        public int SIC;

        public string TargetReportDescriptor = "";
        public string ATP = "";
        public string ARC = "";
        public string RC = "";
        public string RAB = "";
        public string DCR = "";
        public string GBS = "";
        public string SIM = "";
        public string TST = "";
        public string SAA = "";
        public string CL = "";
        public string IPC = "";
        public string NOGO = "";
        public string CPR = "";
        public string LDPJ = "";
        public string RCF = "";

        public string TrackNumber = "";
        public int TrackNumber_number;

        public string ServiceIdentification = "";
        public int ServiceIdentification_number;

        public string TimeofApplicability_Position = "";
        public double TimeofApplicability_Position_seconds;

        public string PositioninWGS_coordinates = "";
        public double latWGS84 = 0;
        public double lonWGS84 = 0;

        public string PositioninWGS_HRcoordinates = "";
        public double latWGS84_HR = 0;
        public double lonWGS84_HR = 0;

        public CoordinatesWGS84 coordinatesWGS84;
        public CoordinatesUVH coordinatesUVH;

        public string TimeofApplicability_Velocity = "";
        public double TimeofApplicability_Velocity_seconds;

        public string AirSpeed = "";
        public string IM = "";
        public double AirSpeed_velocity;
        public double AirSpeed_Mach;

        public string TrueAirSpeed = "";
        public double TrueAirSpeed_number;
        public string RE_TAS = "";

        public string TargetAddress_bin = "";
        public string TargetAdress_real = "";

        public string TimeofMessageReception_Position = "";
        public double TimeofMessageReception_Position_seconds;

        public string TimeofMessageReception_HRPosition = "";
        public double TimeofMessageReception_HRPosition_seconds;
        public string FSI1 = "";

        public string TimeofMessageReception_Velocity = "";
        public double TimeofMessageReception_Velocity_seconds;
        public string FSI2 = "";

        public string TimeofMessageReception_HRVelocity = "";
        public double TimeofMessageReception_HRVelocity_seconds;

        public string GeometricHeight = "";
        public double GeometricHeight_feet;

        public string QualityIndicators = "";
        public int NACv;
        public int NUCp;
        public int NIC_Baro;
        public string SIL = "";
        public int NACp;
        public int SDA;
        public int GVA;
        public int PIC;

        public string MOPSVersion = "";
        public string VNS = "";
        public string VN = "";
        public string LTT = "";

        public string Mode3ACode_bin = "";
        public string Mode3ACode_oct = "";

        public string RollAngle = "";
        public double RollAngle_degrees;

        public string FlightLevel = "";
        public double FlightLevel_FL;

        public string MagneticHeading = "";
        public double MagneticHeading_degrees;

        public string TargetStatus = "";
        public string ICF = "";
        public string LNAV = "";
        public string PS = "";
        public string SS = "";

        public string BarometricVerticalRate = "";
        public string RE_BVR = "";
        public double BarometricVerticalRate_fmin;

        public string GeometricVerticalRate = "";
        public string RE_GVR = "";
        public double GeometricVerticalRate_fmin;

        public string AirborneGoundVector = "";
        public string RE_AGV = "";
        public double GroundSpeed;
        public double TrackAngle;

        public string TrackAngleRate = "";
        public double TrackAngleRate_degs;

        public string TimeofASTERIXReportTransmission = "";
        public double TimeofASTERIXReportTransmission_seconds;

        public string TargetIdentification = "";
        public string TargetIdentification_decoded = "";

        public string EmitterCategory = "";
        public string ECAT = "";

        public string MetInformation = "";
        public double WindSpeed;
        public double WindDirection;
        public double Temperature;
        public double Turbulence;

        public string SelectedAltitude = "";
        public string SAS = "";
        public string Source = "";
        public double SelectedAltitude_ft;

        public string FinalStateSelectedAltitude = "";
        public string MV = "";
        public string AH = "";
        public string AM = "";
        public double FinalStateSelectedAltitude_ft;

        public string TrajectoryIntent = "";
        public string NAV = "";
        public string NVB = "";
        public int REP;
        public string TCA = "";
        public string NC = "";
        public int TCP;
        public double TI_ALtitude;
        public double TI_Latitude;
        public double TI_Longitude;
        public string PointType = "";
        public string TD = "";
        public string TRA = "";
        public string TOA = "";
        public int TOV;
        public double TTR;

        public string ServiceManagement = "";
        public double RP;

        public string AircraftOperationalStatus = "";
        public string RA = "";
        public string TC = "";
        public string TS = "";
        public string ARV = "";
        public string CDTI_A = "";
        public string TCAS = "";
        public string SA = "";

        public string SurfaceCapabilitiesandCharacteristicas = "";
        public string POA = "";
        public string CDTI_S = "";
        public string B2low = "";
        public string RAS = "";
        public string IDENT = "";
        public string Length = "";
        public string Width = "";

        public string ModeSMBData = "";
        public string[] REP_MS;
        public string[] MBDATA;
        public string[] BDS1;
        public string[] BDS2;

        public string ACASResolutionAdvisoryReport = "";
        public int TYP;
        public int STYP;
        public int ARA_ACAS;
        public int RAC;
        public int RAT;
        public int MTE;
        public int TTI;
        public int TID;

        public string MessageAmplitude = "";
        public double MessageAmplitude_dBm;

        public string ReceiverID = "";
        public int ReceiverID_number;

        public string DataAges = "";
        public double AOS = -1;
        public double TRD = -1;
        public double M3A = -1;
        public double QI = -1;
        public double TI = -1;
        public double MAM = -1;
        public double GH = -1;
        public double FL = -1;
        public double ISA = -1;
        public double FSA = -1;
        public double AS = -1;
        public double TAS = -1;
        public double MH = -1;
        public double BVR = -1;
        public double GVR = -1;
        public double GV = -1;
        public double TAR = -1;
        public double TI_DA = -1;
        public double TS_DA = -1;
        public double MET = -1;
        public double ROA = -1;
        public double ARA = -1;
        public double SCC = -1;

        public CAT21(string[] packet)
        {
            this.paquete = packet;
        }

        public string AddZeros(string octeto)
        {
            while (octeto.Length < 8)
            {
                octeto = octeto.Insert(0, "0");
            }

            return octeto;
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
        public void Calculate_DataSourceIdentification(string paquete)
        {
            string string1 = paquete.Substring(0, 8);
            string string2 = paquete.Substring(8, 8);

            SAC = Convert.ToInt32(string1, 2);
            SIC = Convert.ToInt32(string2, 2);

        }
        public void Calculate_TargetReportDescriptor(string paquete)
        {
            string str1 = paquete.Substring(0, 3);
            int atp1 = Convert.ToInt32(str1, 2);

            if (atp1 == 0)
            {
                ATP = "24-Bit ICAO address.";
            }

            if (atp1 == 1)
            {
                ATP = "Duplicate address.";
            }

            if (atp1 == 2)
            {
                ATP = "Surface vehicle address.";
            }

            if (atp1 == 3)
            {
                ATP = "Anonymous address.";
            }

            str1 = paquete.Substring(3, 2);
            int arc1 = Convert.ToInt32(str1, 2);

            if (arc1 == 0)
            {
                ARC = "25 ft.";
            }

            if (arc1 == 1)
            {
                ARC = "100 ft.";
            }

            if (arc1 == 2)
            {
                ARC = "Unknown.";
            }

            if (arc1 == 3)
            {
                ARC = "Invalid .";
            }

            string rc1 = paquete.Substring(5, 1);

            if (rc1 == "0")
            {
                RC = "Default.";
            }

            if (rc1 == "1")
            {
                RC = "Range Check passed, CPR Validation pending.";
            }

            string rab1 = paquete.Substring(6, 1);

            if (rab1 == "0")
            {
                RAB = "Report from target transponder.";
            }

            if (rab1 == "1")
            {
                RAB = "Report from field monitor (fixed transponder).";
            }

            if (paquete.Length > 8)
            {
                string dcr1 = paquete.Substring(8, 1);

                if (dcr1 == "0")
                {
                    DCR = "No differential correction (ADS-B).";
                }

                if (dcr1 == "1")
                {
                    DCR = "Differential correction (ADS-B)";
                }

                string gbs1 = paquete.Substring(9, 1);

                if (gbs1 == "0")
                {
                    GBS = "Ground Bit not set.";
                }

                if (gbs1 == "1")
                {
                    GBS = "Ground Bit set.";
                }

                string sim1 = paquete.Substring(10, 1);

                if (sim1 == "0")
                {
                    SIM = "Actual target report.";
                }

                if (sim1 == "1")
                {
                    SIM = "Simulated target report.";
                }

                string tst1 = paquete.Substring(11, 1);

                if (tst1 == "0")
                {
                    TST = "Default.";
                }

                if (tst1 == "1")
                {
                    TST = "Test Target.";
                }

                string saa1 = paquete.Substring(12, 1);

                if (saa1 == "0")
                {
                    SAA = "Equipment capable to provide Selected Altitude.";
                }

                if (saa1 == "1")
                {
                    SAA = "Equipment not capable to provide Selected Altitude.";
                }

                str1 = paquete.Substring(13, 2);
                int cl1 = Convert.ToInt32(str1, 2);

                if (cl1 == 0)
                {
                    CL = "Report valid.";
                }

                if (cl1 == 1)
                {
                    CL = "Report suspect.";
                }

                if (cl1 == 2)
                {
                    CL = "No information.";
                }

                if (paquete.Length > 16)
                {
                    string ipc1 = paquete.Substring(18, 1);

                    if (ipc1 == "0")
                    {
                        IPC = "Independent Position Check = 0 default";
                    }

                    if (ipc1 == "1")
                    {
                        IPC = "Independent Position Check failed.";
                    }

                    string nogo1 = paquete.Substring(18, 1);

                    if (nogo1 == "0")
                    {
                        NOGO = "NOGO-bit not set.";
                    }

                    if (nogo1 == "1")
                    {
                        NOGO = "NOGO-bit set.";
                    }

                    string cpr1 = paquete.Substring(19, 1);

                    if (cpr1 == "0")
                    {
                        CPR = "CPR Validation correct.";
                    }

                    if (cpr1 == "1")
                    {
                        CPR = "CPR Validation failed.";
                    }

                    string ldpj1 = paquete.Substring(20, 1);

                    if (ldpj1 == "0")
                    {
                        LDPJ = "LDPJ not detected.";
                    }

                    if (ldpj1 == "1")
                    {
                        LDPJ = "LDPJ detected.";
                    }

                    string rcf1 = paquete.Substring(21, 1);

                    if (rcf1 == "0")
                    {
                        RCF = "Default.";
                    }

                    if (rcf1 == "1")
                    {
                        RCF = "Range Check failed .";
                    }

                }
            }


        }
        public void Calculate_TrackNumber(string paquete)
        {
            string string1 = paquete.Substring(4, 12);
            TrackNumber_number = Convert.ToInt32(string1, 2);
        }
        public void Calculate_TimeofAppliability_Position(string paquete)
        {
            double time = Convert.ToInt32(paquete, 2);
            TimeofApplicability_Position_seconds = time / 128;

        }
        public void CalculatePositionWGS84_coordinates(string paquete)
        {
            string str1 = paquete.Substring(0, 24);
            string str2 = paquete.Substring(24, 24);

            double a1 = Calculate_ComplementoA2(str1);
            double b1 = Calculate_ComplementoA2(str2);

            latWGS84 = a1 * (180 / Math.Pow(2, 23));
            lonWGS84 = b1 * (180 / Math.Pow(2, 23));
        }
        public void CalculatePositionWGS84_HRcoordinates(string paquete)
        {

            string str1 = paquete.Substring(0, 32);
            string str2 = paquete.Substring(32, 32);

            double a1 = Calculate_ComplementoA2(str1);
            double b1 = Calculate_ComplementoA2(str2);

            latWGS84_HR = a1 * (180 / Math.Pow(2, 30));
            lonWGS84_HR = b1 * (180 / Math.Pow(2, 30));


        }
        public void Calculate_TimeofAppliability_Velocity(string paquete)
        {
            double time = Convert.ToInt32(paquete, 2);
            TimeofApplicability_Position_seconds = time * (1 / 128);
        }
        public void Calculate_AirSpeed(string paquete)
        {

            string velocity = paquete.Substring(1, 15);

            if (Convert.ToInt32(paquete[0]) == 0)
            {
                IM = "IAS";
                double vel1 = Convert.ToInt32(velocity);
                TimeofApplicability_Position_seconds = vel1 * (1 / Math.Pow(2, 14));

            }
            else
            {
                IM = "Mach";

                AirSpeed_Mach = Convert.ToInt32(velocity);
                AirSpeed_Mach = AirSpeed_Mach * 0.001;
            }


        }
        public void Calculate_TrueAirSpeed(string paquete)
        {
            string ra1 = Convert.ToString(paquete[0]);

            if (ra1 == "0")
            {
                RE_TAS = "Value in defined range.";
            }

            else
            {
                RE_TAS = "Value exceeds defined range.";
            }

            string tas = paquete.Substring(1, paquete.Length - 1);
            TrueAirSpeed_number = Convert.ToInt32(tas, 2);

        }
        public void Calculate_TimeofMessageReception_HRPosition(string paquete)
        {
            string fsi1 = paquete.Substring(0, 2);
            int fsi2 = Convert.ToInt32(fsi1, 2);

            if (fsi2 == 11)
            {
                FSI1 = "Reserved.";
            }

            if (fsi2 == 10)
            {
                string seconds = Convert.ToString(TimeofMessageReception_Position_seconds);
                FSI1 = "TOMRp whole seconds = " + seconds + " Whole seconds -1.";
            }

            if (fsi2 == 01)
            {
                string seconds = Convert.ToString(TimeofMessageReception_Position_seconds);
                FSI1 = "TOMRp whole seconds = " + seconds + " Whole seconds +1.";
            }

            if (fsi2 == 00)
            {
                string seconds = Convert.ToString(TimeofMessageReception_Position_seconds);
                FSI1 = "TOMRp whole seconds = " + seconds + " Whole seconds.";
            }

            string str1 = paquete.Substring(2, 30);
            int seconds1 = Convert.ToInt32(str1, 2);
            TimeofMessageReception_HRPosition_seconds = seconds1 * (Math.Pow(2, -30));

        }
        public void Calculate_TimeofMessageReception_HRVelocity(string paquete)
        {
            string fsi1 = paquete.Substring(0, 2);
            int fsi2 = Convert.ToInt32(fsi1, 2);

            if (fsi2 == 11)
            {
                FSI2 = "Reserved.";
            }

            if (fsi2 == 10)
            {
                string seconds = Convert.ToString(TimeofMessageReception_Velocity_seconds);
                FSI2 = "TOMRp whole seconds = " + seconds + " Whole seconds -1.";
            }

            if (fsi2 == 01)
            {
                string seconds = Convert.ToString(TimeofMessageReception_Velocity_seconds);
                FSI2 = "TOMRp whole seconds = " + seconds + " Whole seconds +1.";
            }

            if (fsi2 == 00)
            {
                string seconds = Convert.ToString(TimeofMessageReception_Velocity_seconds);
                FSI2 = "TOMRp whole seconds = " + seconds + " Whole seconds.";
            }

            string str1 = paquete.Substring(2, 30);
            int seconds1 = Convert.ToInt32(str1, 2);
            TimeofMessageReception_HRVelocity_seconds = seconds1 * (Math.Pow(2, -30));

        }

        public void Calculate_QualityIndicators(string paquete)
        {
            if (paquete.Length > 0)
            {
                string str1 = paquete.Substring(0, 3);
                string str2 = paquete.Substring(3, 4);

                NACv = Convert.ToInt32(str1, 2);
                NUCp = Convert.ToInt32(str2, 2);

                if (paquete.Length > 8)
                {
                    string str3 = Convert.ToString(paquete[8]);
                    NIC_Baro = Convert.ToInt32(str3);

                    string str5 = paquete.Substring(11, 4);
                    NACp = Convert.ToInt32(str5, 2);

                    string sil1 = paquete.Substring(9, 2);
                    SIL = Convert.ToInt32(sil1, 2).ToString();

                    if (paquete.Length > 16)
                    {
                        string str6 = paquete.Substring(18, 1);
                        if (str6 == "0") { SIL = String.Concat(SIL, "/", "Measured per flight-hour."); }
                        else { SIL = String.Concat(SIL, "/", "Measured per sample."); }

                        string str7 = paquete.Substring(19, 2);
                        SDA = Convert.ToInt32(str7, 2);

                        string str8 = paquete.Substring(21, 2);
                        GVA = Convert.ToInt32(str8, 2);

                        if (paquete.Length > 24)
                        {
                            string str9 = paquete.Substring(24, 4);
                            PIC = Convert.ToInt32(str9, 2);
                        }
                    }
                }
            }
        }


        public void Calculate_MOPSVersion(string paquete)
        {
            string vns1 = Convert.ToString(paquete[1]);
            if (vns1 == "0")
            {
                VNS = "The MOPS Version is supported by the GS.";
            }

            else
            {
                VNS = "The MOPS Version is not supported by the GS.";
            }

            string vn = paquete.Substring(2, 3);
            int vn1 = Convert.ToInt32(vn, 2);
            if (vn1 == 0)
            {
                VN = "ED102/DO-260 [Ref. 8].";
            }

            if (vn1 == 1)
            {
                VN = "DO-260A [Ref. 9].";
            }

            if (vn1 == 2)
            {
                VN = "ED102A/DO-260B [Ref. 11].";
            }


            string ltt = paquete.Substring(5, 3);
            int ltt1 = Convert.ToInt32(ltt, 2);
            if (ltt1 == 0)
            {
                LTT = "Other.";
            }

            if (ltt1 == 1)
            {
                LTT = "UAT";
            }

            if (ltt1 == 2)
            {
                LTT = "1090 ES.";
            }

            if (ltt1 == 4)
            {
                LTT = "VDL 4.";
            }

            if (ltt1 == 4 || ltt1 == 5 || ltt1 == 6 || ltt1 == 7)
            {
                LTT = "Not Assigned";
            }

        }
        public void Calculate_TargetStatus(string paquete)
        {
            string icf1 = paquete.Substring(0, 1);
            if (icf1 == "0")
            {
                ICF = "No intent change active.";
            }

            if (icf1 == "1")
            {
                ICF = "Intent change active.";
            }

            string lnav1 = paquete.Substring(1, 1);
            if (icf1 == "0")
            {
                LNAV = "LNAV Mode engaged.";
            }

            else if (icf1 == "1")
            {
                LNAV = "LNAV Mode not engaged.";
            }

            string ps = paquete.Substring(3, 3);
            int ps1 = Convert.ToInt32(ps, 2);
            if (ps1 == 0)
            {
                PS = "No emergency / not reported.";
            }

            if (ps1 == 1)
            {
                PS = "General emergency.";
            }

            if (ps1 == 2)
            {
                PS = "Lifeguard / medical emergency.";
            }

            if (ps1 == 3)
            {
                PS = "Minimum fuel.";
            }

            if (ps1 == 4)
            {
                PS = "No communications.";
            }

            if (ps1 == 5)
            {
                PS = "Unlawful interference.";
            }

            if (ps1 == 6)
            {
                PS = "“Downed” Aircraft.";
            }

            string ss = paquete.Substring(6, 2);
            int ss1 = Convert.ToInt32(ss, 2);
            if (ss1 == 0)
            {
                SS = "No condition reported.";
            }

            if (ss1 == 1)
            {
                SS = "Permanent Alert (Emergency condition).";
            }

            if (ss1 == 2)
            {
                SS = "Temporary Alert (change in Mode 3/A Code other than emergency).";
            }

            if (ss1 == 3)
            {
                SS = "SPI set.";
            }
        }
        public void Calculate_AirborneGroundVector(string paquete)
        {
            string str1 = paquete.Substring(0, 16);
            string str2 = paquete.Substring(16, 16);

            if (str1[0] == Convert.ToChar("0"))
            {
                RE_AGV = "Value in defined range.";
            }

            else
            {
                RE_AGV = "Value exceeds defined range.";
            }

            string str3 = str1.Substring(1, 15);

            GroundSpeed = Convert.ToInt32(str3, 2) * Math.Pow(2, -14);
            TrackAngle = Convert.ToInt32(str2, 2) * (360 / Math.Pow(2, 16));
        }
        public void Calculate_BarometricVerticalRate(string paquete)
        {
            string str1 = Convert.ToString(paquete[0]);
            if (str1 == "0")
            {
                RE_BVR = "Value in defined range.";
            }

            else
            {
                RE_BVR = "Value exceeds defined range.";
            }

            string str2 = paquete.Substring(1, 15);

            BarometricVerticalRate_fmin = Calculate_ComplementoA2(str2) * 6.25;
        }
        public void Calculate_GeometricVerticalRate(string paquete)
        {
            string str1 = Convert.ToString(paquete[0]);
            if (str1 == "0")
            {
                RE_GVR = "Value in defined range.";
            }

            else
            {
                RE_GVR = "Value exceeds defined range.";
            }

            string str2 = paquete.Substring(1, 15);

            GeometricVerticalRate_fmin = Calculate_ComplementoA2(str2) * 6.25;
        }
        public void Compute_TargetIdentification(string paquete)
        {
            int i = 0;
            while (i < 8)
            {
                string str1 = paquete.Substring(i * 6, 6);

                int b1 = Convert.ToInt32(Convert.ToString(str1[5]));
                int b2 = Convert.ToInt32(Convert.ToString(str1[4]));
                int b3 = Convert.ToInt32(Convert.ToString(str1[3]));
                int b4 = Convert.ToInt32(Convert.ToString(str1[2]));
                int b5 = Convert.ToInt32(Convert.ToString(str1[1]));
                int b6 = Convert.ToInt32(Convert.ToString(str1[0]));

                if (b4 == 0 && b3 == 0 && b2 == 0 && b1 == 1 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "A");
                }
                if (b4 == 0 && b3 == 0 && b2 == 1 && b1 == 0 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "B");
                }
                if (b4 == 0 && b3 == 0 && b2 == 1 && b1 == 1 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "C");
                }
                if (b4 == 0 && b3 == 1 && b2 == 0 && b1 == 0 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "D");
                }
                if (b4 == 0 && b3 == 1 && b2 == 0 && b1 == 1 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "E");
                }
                if (b4 == 0 && b3 == 1 && b2 == 1 && b1 == 0 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "F");
                }
                if (b4 == 0 && b3 == 1 && b2 == 1 && b1 == 1 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "G");
                }
                if (b4 == 1 && b3 == 0 && b2 == 0 && b1 == 0 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "H");
                }
                if (b4 == 1 && b3 == 0 && b2 == 0 && b1 == 1 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "I");
                }
                if (b4 == 1 && b3 == 0 && b2 == 1 && b1 == 0 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "J");
                }
                if (b4 == 1 && b3 == 0 && b2 == 1 && b1 == 1 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "K");
                }
                if (b4 == 1 && b3 == 1 && b2 == 0 && b1 == 0 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "L");
                }
                if (b4 == 1 && b3 == 1 && b2 == 0 && b1 == 1 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "M");
                }
                if (b4 == 1 && b3 == 1 && b2 == 1 && b1 == 0 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "N");
                }
                if (b4 == 1 && b3 == 1 && b2 == 1 && b1 == 1 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "O");
                }
                if (b4 == 0 && b3 == 0 && b2 == 0 && b1 == 0 && b5 == 1 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "P");
                }
                if (b4 == 0 && b3 == 0 && b2 == 0 && b1 == 1 && b5 == 1 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "Q");
                }
                if (b4 == 0 && b3 == 0 && b2 == 1 && b1 == 0 && b5 == 1 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "R");
                }
                if (b4 == 0 && b3 == 0 && b2 == 1 && b1 == 1 && b5 == 1 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "S");
                }
                if (b4 == 0 && b3 == 1 && b2 == 0 && b1 == 0 && b5 == 1 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "T");
                }
                if (b4 == 0 && b3 == 1 && b2 == 0 && b1 == 1 && b5 == 1 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "U");
                }
                if (b4 == 0 && b3 == 1 && b2 == 1 && b1 == 0 && b5 == 1 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "V");
                }
                if (b4 == 0 && b3 == 1 && b2 == 1 && b1 == 1 && b5 == 1 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "W");
                }
                if (b4 == 1 && b3 == 0 && b2 == 0 && b1 == 0 && b5 == 1 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "X");
                }
                if (b4 == 1 && b3 == 0 && b2 == 0 && b1 == 1 && b5 == 1 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "Y");
                }
                if (b4 == 1 && b3 == 0 && b2 == 1 && b1 == 0 && b5 == 1 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "Z");
                }
                if (b4 == 0 && b3 == 0 && b2 == 0 && b1 == 0 && b5 == 1 && b6 == 1)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "0");
                }
                if (b4 == 0 && b3 == 0 && b2 == 0 && b1 == 1 && b5 == 1 && b6 == 1)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "1");
                }
                if (b4 == 0 && b3 == 0 && b2 == 1 && b1 == 0 && b5 == 1 && b6 == 1)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "2");
                }
                if (b4 == 0 && b3 == 0 && b2 == 1 && b1 == 1 && b5 == 1 && b6 == 1)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "3");
                }
                if (b4 == 0 && b3 == 1 && b2 == 0 && b1 == 0 && b5 == 1 && b6 == 1)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "4");
                }
                if (b4 == 0 && b3 == 1 && b2 == 0 && b1 == 1 && b5 == 1 && b6 == 1)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "5");
                }
                if (b4 == 0 && b3 == 1 && b2 == 1 && b1 == 0 && b5 == 1 && b6 == 1)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "6");
                }
                if (b4 == 0 && b3 == 1 && b2 == 1 && b1 == 1 && b5 == 1 && b6 == 1)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "7");
                }
                if (b4 == 1 && b3 == 0 && b2 == 0 && b1 == 0 && b5 == 1 && b6 == 1)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "8");
                }
                if (b4 == 1 && b3 == 0 && b2 == 0 && b1 == 1 && b5 == 1 && b6 == 1)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "9");
                }
                if (b4 == 0 && b3 == 0 && b2 == 0 && b1 == 0 && b5 == 0 && b6 == 1)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "");
                }
                if (b4 == 0 && b3 == 0 && b2 == 0 && b1 == 0 && b5 == 0 && b6 == 0)
                {
                    TargetIdentification_decoded = String.Concat(TargetIdentification_decoded, "");
                }

                i = i + 1;

            }

        }
        public void Calculate_EmitterCategory(string paquete)
        {
            int ecat = Convert.ToInt32(paquete, 2);
            if (ecat == 0)
            {
                ECAT = "No ADS-B Emitter Category Information.";
            }
            if (ecat == 1)
            {
                ECAT = "Light aircraft <= 15500 lbs.";
            }
            if (ecat == 2)
            {
                ECAT = "15500 lbs < small aircraft <75000 lbs.";
            }
            if (ecat == 3)
            {
                ECAT = "75000 lbs < medium a/c  < 300000 lbs.";
            }
            if (ecat == 4)
            {
                ECAT = "High Vortex Large.";
            }
            if (ecat == 5)
            {
                ECAT = "300000 lbs <= heavy aircraft.";
            }
            if (ecat == 6)
            {
                ECAT = "Highly manoeuvrable (5g acceleration capability) and high speed (>400 knots cruise).";
            }
            if (ecat == 7 || ecat == 8 || ecat == 9)
            {
                ECAT = "Reserved";
            }
            if (ecat == 10)
            {
                ECAT = "Rotocraft.";
            }
            if (ecat == 11)
            {
                ECAT = "Glider/Sailplane.";
            }
            if (ecat == 12)
            {
                ECAT = "Lighter-than-air.";
            }
            if (ecat == 13)
            {
                ECAT = "Unmanned aerial vehicle.";
            }
            if (ecat == 14)
            {
                ECAT = "Space/Transatmospheric Vehicle.";
            }
            if (ecat == 15)
            {
                ECAT = "Ultralight/Handglider/Paraglider.";
            }
            if (ecat == 16)
            {
                ECAT = "Parachutist/Skydiver.";
            }
            if (ecat == 17 || ecat == 18 || ecat == 19)
            {
                ECAT = "Reserved.";
            }
            if (ecat == 20)
            {
                ECAT = "Surface emergency vehicle";
            }
            if (ecat == 21)
            {
                ECAT = "Surface service vehicle.";
            }
            if (ecat == 22)
            {
                ECAT = "Fixed ground or tethered obstruction.";
            }
            if (ecat == 23)
            {
                ECAT = "Cluster obstacle.";
            }
            if (ecat == 24)
            {
                ECAT = "Line obstacle.";
            }


        }
        public void Calculate_MetInformation(string paquete)
        {

            int counter = 8;
            string ws = "";
            string wd = "";
            string temp = "";
            string turb = "";

            if (Convert.ToString(paquete[0]) == "1")
            {
                ws = paquete.Substring(counter, 16);
                counter = counter + 16;

                WindSpeed = Convert.ToInt32(ws, 2);
            }

            if (Convert.ToString(paquete[1]) == "1")
            {
                wd = paquete.Substring(counter, 16);
                counter = counter + 16;

                WindDirection = Convert.ToInt32(wd, 2);
            }

            if (Convert.ToString(paquete[2]) == "1")
            {
                temp = paquete.Substring(counter, 16);
                counter = counter + 16;

                Temperature = Calculate_ComplementoA2(temp) * 0.25;
            }

            if (Convert.ToString(paquete[3]) == "1")
            {
                turb = paquete.Substring(counter, 8);
                counter = counter + 8;

                Turbulence = Convert.ToInt32(turb, 2);
            }


        }
        public void Calculate_SelectedAltitude(string paquete)
        {
            string sas = Convert.ToString(paquete[0]);
            if (sas == "0")
            {
                SAS = "No source information provided.";
            }

            if (sas == "1")
            {
                SAS = "Source information provided.";
            }

            string source1 = Convert.ToString(paquete[1]);
            string source2 = Convert.ToString(paquete[2]);

            if (source1 == "0" && source2 == "0")
            {
                Source = "Unknown";
            }

            if (source1 == "0" && source2 == "1")
            {
                Source = "Aircraft Altitude (Holding Altitude).";
            }

            if (source1 == "1" && source2 == "0")
            {
                Source = "MCP/FCU Selected Altitude.";
            }
            if (source1 == "1" && source2 == "1")
            {
                Source = "FMS Selected Altitude.";
            }

            string alt = paquete.Substring(3, 13);
            SelectedAltitude_ft = Calculate_ComplementoA2(alt) * 25;

        }
        public void Calculate_FinalStateSelectedAltitude(string paquete)
        {
            string mv1 = Convert.ToString(paquete[0]);
            if (mv1 == "0")
            {
                MV = "Not actice or unknown.";
            }
            else
            {
                MV = "Active.";
            }

            string ah1 = Convert.ToString(paquete[1]);
            if (ah1 == "0")
            {
                AH = "Not actice or unknown.";
            }
            else
            {
                AH = "Active.";
            }

            string am1 = Convert.ToString(paquete[1]);
            if (am1 == "0")
            {
                AM = "Not actice or unknown.";
            }
            else
            {
                AM = "Active.";
            }

            string alt1 = paquete.Substring(3, 13);
            FinalStateSelectedAltitude_ft = Calculate_ComplementoA2(alt1) * 25;
        }
        public void Calculate_TrajectoryIntent(string paquete)
        {
            int counter = 8;
            string trajectoryintentstatus = "";
            string trajectoryintentdata = "";

            if (Convert.ToString(paquete[0]) == "1")
            {
                trajectoryintentstatus = paquete.Substring(counter, 8);
                counter = counter + 8;

                string str1 = Convert.ToString(trajectoryintentstatus[0]);
                if (str1 == "0")
                {
                    NAV = "Trajectory Intent Data is available for this aircraft.";
                }

                else
                {
                    NAV = "Trajectory Intent Data is not available for this aircraft.";
                }

                string str2 = Convert.ToString(trajectoryintentstatus[0]);
                if (str2 == "0")
                {
                    NVB = "Trajectory Intent Data is valid.";
                }

                else
                {
                    NVB = "Trajectory Intent Data is not valid.";
                }
            }

            if (Convert.ToString(paquete[1]) == "1")
            {
                trajectoryintentdata = paquete.Substring(counter, 128);
                counter = counter + 128;

                string rep1 = trajectoryintentdata.Substring(0, 8);
                string tca1 = trajectoryintentdata.Substring(8, 1);
                string nc1 = trajectoryintentdata.Substring(9, 1);
                string tcp1 = trajectoryintentdata.Substring(10, 6);
                string alt1 = trajectoryintentdata.Substring(16, 16);
                string lat1 = trajectoryintentdata.Substring(32, 24);
                string lon1 = trajectoryintentdata.Substring(56, 24);
                string pointtype1 = trajectoryintentdata.Substring(80, 4);
                string td1 = trajectoryintentdata.Substring(84, 2);
                string tra1 = trajectoryintentdata.Substring(86, 1);
                string toa1 = trajectoryintentdata.Substring(87, 1);
                string tov1 = trajectoryintentdata.Substring(88, 24);
                string ttr1 = trajectoryintentdata.Substring(112, 16);

                REP = Convert.ToInt32(rep1, 2);

                if (Convert.ToString(tca1) == "0")
                {
                    TCA = "TCP number available";
                }
                else
                {
                    TCA = "TCP number not available.";
                }

                if (Convert.ToString(nc1) == "0")
                {
                    NC = "TCP compliance.";

                }
                else
                {
                    NC = "TCP non-compliance.";
                }

                TCP = Convert.ToInt32(tcp1, 2);
                TI_ALtitude = Calculate_ComplementoA2(alt1) * 10;
                TI_Latitude = Calculate_ComplementoA2(lat1) * 180 / (Math.Pow(2, 23));
                TI_Longitude = Calculate_ComplementoA2(lon1) * 180 / (Math.Pow(2, 23));

                int int1 = Convert.ToInt32(pointtype1);
                if (int1 == 0)
                {
                    PointType = "Unknown";
                }
                if (int1 == 1)
                {
                    PointType = "Fly by Waypoint (LT)";
                }
                if (int1 == 2)
                {
                    PointType = "Fly over waypoint (LT).";
                }
                if (int1 == 3)
                {
                    PointType = "Hold pattern (LT).";
                }
                if (int1 == 4)
                {
                    PointType = "Procedure hold (LT).";
                }
                if (int1 == 5)
                {
                    PointType = "Procedure turn (LT).";
                }
                if (int1 == 6)
                {
                    PointType = "RF leg (LT).";
                }
                if (int1 == 7)
                {
                    PointType = "Top of climb (VT).";
                }
                if (int1 == 8)
                {
                    PointType = "Top of descent (VT).";
                }
                if (int1 == 9)
                {
                    PointType = "Start of level (VT).";
                }
                if (int1 == 10)
                {
                    PointType = "Cross-over altitude (VT).";
                }
                if (int1 == 11)
                {
                    PointType = "Transition altitude (VT).";
                }

                string str1 = Convert.ToString(td1[0]);
                string str2 = Convert.ToString(td1[1]);

                if (str1 == "0" && str2 == "8")
                {
                    TD = "N/A";
                }
                if (str1 == "0" && str2 == "1")
                {
                    TD = "Turn right.";
                }
                if (str1 == "1" && str2 == "0")
                {
                    TD = "Turn left.";
                }
                else
                {
                    TD = "No turn.";
                }

                if (tra1 == "0")
                {
                    TRA = "TTR not available.";
                }
                else
                {
                    TRA = "TTR available.";
                }

                TOV = Convert.ToInt32(tov1, 2);
                TTR = Convert.ToInt32(ttr1, 2) * 0.01;
            }
        }
        public void Calculate_AircraftOperationalStatus(string paquete)
        {

            string ra1 = paquete.Substring(1, 1);

            if (ra1 == "1")
            {
                RA = "TCAS RA active";
            }

            else
            {
                RA = "TCAS II or ACAS RA not active";
            }


            string TC1 = Convert.ToString((paquete.Substring(1, 2)));

            if (Convert.ToInt32(TC1, 2) == 0)
            {
                TC = "No capability for Trajectory Change Reports.";
            }

            if (Convert.ToInt32(TC1, 2) == 1)
            {
                TC = "Support for TC+0 reports only.";
            }

            if (Convert.ToInt32(TC1, 2) == 2)
            {
                TC = "Support for multiple TC reports.";
            }

            if (Convert.ToInt32(TC1, 2) == 3)
            {
                TC = "Reserved.";
            }

            string ta1 = paquete.Substring(3, 1);

            if (ta1 == "0")
            {
                TS = "No capability to support Target State Reports.";
            }

            if (ta1 == "1")
            {
                TS = "Capable of supporting target State Reports.";
            }

            string arv1 = paquete.Substring(4, 1);

            if (arv1 == "0")
            {
                ARV = "No capability to generate ARV-reports.";
            }

            if (arv1 == "1")
            {
                ARV = "Capable of generate ARV-reports.";
            }

            string cdti_a1 = paquete.Substring(5, 1);

            if (cdti_a1 == "0")
            {
                CDTI_A = "CDTI not operational.";
            }

            if (cdti_a1 == "1")
            {
                CDTI_A = "CDTI operational.";
            }

            string tcas1 = paquete.Substring(6, 1);

            if (tcas1 == "0")
            {
                TCAS = "TCAS operational.";
            }

            if (tcas1 == "1")
            {
                TCAS = "TCAS not operational.";
            }

            string sa1 = paquete.Substring(7, 1);

            if (sa1 == "0")
            {
                SA = "Antenna Diversity.";
            }

            if (sa1 == "1")
            {
                SA = "Single Antenna only.";
            }
        }
        public void Calculate_SurfaceCapabilitiesandCharacterístics(string paquete)
        {
            string poa1 = Convert.ToString(paquete[3]);
            if (poa1 == "0")
            {
                POA = "Position transmitted is not ADS-B position reference point.";
            }
            else
            {
                POA = "Position transmitted is the ADS-B position reference point ";
            }

            string cdtis1 = Convert.ToString(paquete[4]);
            if (cdtis1 == "0")
            {
                CDTI_S = "CDTI not operational.";
            }
            else
            {
                CDTI_S = "CDTI operational.";
            }

            string b2low1 = Convert.ToString(paquete[5]);
            if (b2low1 == "0")
            {
                B2low = "≥ 70 Watts.";
            }
            else
            {
                B2low = "< 70 Watts.";
            }

            string ras1 = Convert.ToString(paquete[6]);
            if (ras1 == "0")
            {
                RAS = "Aircraft not receiving ATC-services.";
            }
            else
            {
                RAS = "Aircraft receiving ATC services.";
            }

            string ident1 = paquete.Substring(6, 2);
            if (ident1 == "0")
            {
                IDENT = "IDENT switch not active.";
            }
            else
            {
                IDENT = "IDENT switch active.";
            }

            if (paquete.Length > 8)
            {
                int int2 = Convert.ToInt32(paquete.Substring(12, 4), 2);

                if (VN == "DO-260A [Ref. 9].")
                {
                    if (int2 == 0)
                    {
                        Width = "W < 11.5 ";
                        Length = "L < 15";
                    }
                    if (int2 == 1)
                    {
                        Width = "W < 23";
                        Length = "L < 15";
                    }
                    if (int2 == 2)
                    {
                        Width = "W < 28.5";
                        Length = "L < 25";
                    }
                    if (int2 == 3)
                    {
                        Width = "W < 28.5";
                        Length = "L < 25";
                    }
                    if (int2 == 4)
                    {
                        Width = "W < 33";
                        Length = "L < 35";
                    }
                    if (int2 == 5)
                    {
                        Width = "W < 38";
                        Length = "L < 35";
                    }
                    if (int2 == 6)
                    {
                        Width = "W < 39.5";
                        Length = "L < 45";
                    }
                    if (int2 == 7)
                    {
                        Width = "W < 45";
                        Length = "L < 45";
                    }
                    if (int2 == 8)
                    {
                        Width = "W < 45";
                        Length = "L < 55";
                    }
                    if (int2 == 9)
                    {
                        Width = "W < 52";
                        Length = "L < 55";
                    }
                    if (int2 == 10)
                    {
                        Width = "W < 59.5";
                        Length = "L < 65";
                    }
                    if (int2 == 11)
                    {
                        Width = "W < 67";
                        Length = "L < 65";
                    }
                    if (int2 == 12)
                    {
                        Width = "W < 72.5";
                        Length = "L < 75";
                    }
                    if (int2 == 13)
                    {
                        Width = "W < 80";
                        Length = "L < 75";
                    }
                    if (int2 == 14)
                    {
                        Width = "W < 80";
                        Length = "L < 85";
                    }
                    if (int2 == 15)
                    {
                        Width = "W > 80";
                        Length = "L < 85";
                    }

                }

                if (VN == "ED102A/DO-260B [Ref. 11].")
                {
                    if (int2 == 0)
                    {
                        Width = "W < 11.5 ";
                        Length = "L < 15";
                    }
                    if (int2 == 1)
                    {
                        Width = "W < 23";
                        Length = "L < 15";
                    }
                    if (int2 == 2)
                    {
                        Width = "W < 28.5";
                        Length = "L < 25";
                    }
                    if (int2 == 3)
                    {
                        Width = "W < 28.5";
                        Length = "L < 25";
                    }
                    if (int2 == 4)
                    {
                        Width = "W < 33";
                        Length = "L < 35";
                    }
                    if (int2 == 5)
                    {
                        Width = "W < 38";
                        Length = "L < 35";
                    }
                    if (int2 == 6)
                    {
                        Width = "W < 39.5";
                        Length = "L < 45";
                    }
                    if (int2 == 7)
                    {
                        Width = "W < 45";
                        Length = "L < 45";
                    }
                    if (int2 == 8)
                    {
                        Width = "W < 45";
                        Length = "L < 55";
                    }
                    if (int2 == 9)
                    {
                        Width = "W < 52";
                        Length = "L < 55";
                    }
                    if (int2 == 10)
                    {
                        Width = "W < 59.5";
                        Length = "L < 65";
                    }
                    if (int2 == 11)
                    {
                        Width = "W < 67";
                        Length = "L < 65";
                    }
                    if (int2 == 12)
                    {
                        Width = "W < 72.5";
                        Length = "L < 75";
                    }
                    if (int2 == 13)
                    {
                        Width = "W < 80";
                        Length = "L < 75";
                    }
                    if (int2 == 14)
                    {
                        Width = "W < 80";
                        Length = "L < 85";
                    }
                    if (int2 == 15)
                    {
                        Width = "W > 80";
                        Length = "L < 85";
                    }
                }
            }

        }
        public int Calculate_ModeSMBData(string[] paquete, int pos)
        {
            //contador dels octets q ocupa
            int cont = 1;

            //el primer octet és el número de missatges
            int REP = int.Parse(paquete[pos], System.Globalization.NumberStyles.HexNumber);

            //creamos los vectores:
            this.MBDATA = new string[REP];
            this.BDS1 = new string[REP];
            this.BDS2 = new string[REP];

            //agafem les dades
            int i = 0;
            while (i < REP)
            {
                //MB Data
                string mbdata = "";

                int j = 0;
                while (j < 7) //7 octets
                {
                    mbdata = mbdata + paquete[pos + cont + j];

                    j++;
                }

                this.MBDATA[i] = Convert.ToString(Convert.ToInt32(mbdata, 2), 16).PadLeft(8, '0');

                //BDS1 & BDS2
                string octet8 = Convert.ToString(Convert.ToInt32(paquete[pos + cont + 7], 16), 2).PadLeft(8, '0');

                this.BDS1[i] = octet8.Substring(0, 4);
                this.BDS2[i] = octet8.Substring(4, 4);

                cont = cont + 8;

                i++;
            }

            return cont;
        }
        public void Calculate_ACASResolutionAdvisoryReport(string paquete)
        {
            string typ1 = paquete.Substring(0, 5);
            TYP = Convert.ToInt32(typ1, 2);

            string styp1 = paquete.Substring(5, 3);
            STYP = Convert.ToInt32(styp1, 2);

            string ara1 = paquete.Substring(8, 14);
            ARA_ACAS = Convert.ToInt32(ara1, 2);

            string rac1 = paquete.Substring(22, 4);
            RAC = Convert.ToInt32(rac1, 2);

            string rat1 = paquete.Substring(26, 1);
            RAT = Convert.ToInt32(rat1);

            string mte = paquete.Substring(27, 1);
            MTE = Convert.ToInt32(mte, 2);

            string tti1 = paquete.Substring(28, 2);
            TTI = Convert.ToInt32(tti1, 2);

            string tid1 = paquete.Substring(30, 26);
            TID = Convert.ToInt32(tid1, 2);
        }
        public void Calculate_ReceiverID(string paquete)
        {
            ReceiverID_number = Convert.ToInt32(paquete);
        }
        public int Calculate_Data_Ages(string DataAges, string[] paquete, int data_position)
        {
            while (DataAges.Length < 32)
            {
                DataAges = String.Concat(DataAges, "0");
            }

            if (Convert.ToString(DataAges[0]) == "1")
            {
                string aos1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                AOS = Convert.ToInt32(aos1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[1]) == "1")
            {
                string trd1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                TRD = Convert.ToInt32(trd1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[2]) == "1")
            {
                string m3a1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                M3A = Convert.ToInt32(m3a1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[3]) == "1")
            {
                string qi1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                QI = Convert.ToInt32(qi1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[4]) == "1")
            {
                string ti1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                TI = Convert.ToInt32(ti1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[5]) == "1")
            {
                string mam1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                MAM = Convert.ToInt32(mam1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[6]) == "1")
            {
                string gh1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                GH = Convert.ToInt32(gh1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[8]) == "1")
            {
                string fl1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                FL = Convert.ToInt32(fl1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[9]) == "1")
            {
                string isa1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                ISA = Convert.ToInt32(isa1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[10]) == "1")
            {
                string fsa1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                FSA = Convert.ToInt32(fsa1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[11]) == "1")
            {
                string as1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                AS = Convert.ToInt32(as1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[12]) == "1")
            {
                string tas1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                TAS = Convert.ToInt32(tas1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[13]) == "1")
            {
                string mh1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                MH = Convert.ToInt32(mh1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[14]) == "1")
            {
                string bvr1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                BVR = Convert.ToInt32(bvr1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[16]) == "1")
            {
                string gvr1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                GVR = Convert.ToInt32(gvr1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[17]) == "1")
            {
                string gv1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                GV = Convert.ToInt32(gv1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[18]) == "1")
            {
                string tar1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                TAR = Convert.ToInt32(tar1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[19]) == "1")
            {
                string ti1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                TI_DA = Convert.ToInt32(ti1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[20]) == "1")
            {
                string ts1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                TS_DA = Convert.ToInt32(ts1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[21]) == "1")
            {
                string met1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                MET = Convert.ToInt32(met1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[22]) == "1")
            {
                string roa1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                ROA = Convert.ToInt32(roa1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[24]) == "1")
            {
                string ara1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                ARA = Convert.ToInt32(ara1, 2) * 0.1;
            }

            if (Convert.ToString(DataAges[25]) == "1")
            {
                string scc1 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                data_position = data_position + 1;
                SCC = Convert.ToInt32(scc1, 2) * 0.1;
            }

            return data_position;
        }



        public void Calculate_FSPEC(string[] paquete)
        {
            int j = 3;
            bool found = false;

            while (found == false)
            {
                FSPEC = Convert.ToString(Convert.ToInt32(paquete[j], 16), 2);// Convertir de hex a binario paquete [3]
                FSPEC = AddZeros(FSPEC);

                if (Char.ToString(FSPEC[FSPEC.Length - 1]) == "1")
                {
                    while (Char.ToString(FSPEC[FSPEC.Length - 1]) != "0")
                    {
                        j = j + 1;
                        string parte2 = Convert.ToString(Convert.ToInt32(paquete[j], 16), 2);
                        parte2 = AddZeros(parte2);

                        FSPEC = String.Concat(FSPEC, parte2);
                    }

                    found = true;
                }

                found = true;
            }

            FSPEC_fake = FSPEC;

            while (FSPEC_fake.Length < (7 * 8))
            {
                FSPEC_fake = String.Concat(FSPEC_fake, "0");
            }

            data_position = 1 + 2 + ((FSPEC.Length) / 8);

            //-------------------------------------------------------------------------------------------------------------
            // Aqui porocesamos los parametros que hemos encontrado en el FSPEC
            //-------------------------------------------------------------------------------------------------------------

            if (FSPEC.Length > 0)
            {
                if (Char.ToString(FSPEC_fake[0]) == "1") // 1 I021/010 Data Source Identification
                {

                    string string1 = Convert.ToString(paquete[data_position]);
                    string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                    string1 = AddZeros(string1);

                    string string2 = Convert.ToString(paquete[data_position + 1]);
                    string2 = Convert.ToString(Convert.ToInt32(string2, 16), 2);
                    string2 = AddZeros(string2);

                    data_position = data_position + 2;

                    DataSourseIdentification = String.Concat(string1, string2);

                    Calculate_DataSourceIdentification(DataSourseIdentification);

                }  // 1 I021/010 Data Source Identification

                if (Char.ToString(FSPEC_fake[1]) == "1") // 2 I021/040 Target Report Descriptor
                {

                    // primero leemos el primer paquete y lo pasamos a binario

                    string string_packet = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                    string_packet = AddZeros(string_packet);

                    if ((Convert.ToString(string_packet[7])) == "0") // si ultima posicion es un 0 guardamos el octeto y pasamos al siguiente
                    {
                        TargetReportDescriptor = string_packet;
                        data_position = data_position + 1;
                    }
                    if ((Convert.ToString(string_packet[7])) == "1") // si ultimo valor =1 hacemos un bucle que vaya concatenando todos los octetos acabados en 1
                    {
                        i = 0;
                        data_position = data_position + 1;
                        while ((Convert.ToString(string_packet[string_packet.Length - 1])) == "1" && string_packet.Length < 24)
                        {
                            string string_packet2 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                            string_packet2 = AddZeros(string_packet2);
                            string_packet = string.Concat(string_packet, string_packet2);
                            data_position = data_position + 1;
                            i = i + 1;
                        }
                    }

                    TargetReportDescriptor = string_packet;

                    Calculate_TargetReportDescriptor(TargetReportDescriptor);

                }// 2 I021/040 Target Report Descriptor

                if (Char.ToString(FSPEC_fake[2]) == "1") // 3 I021/161 Track Number 
                {
                    string string1 = Convert.ToString(paquete[data_position]);
                    string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                    string1 = AddZeros(string1);

                    string string2 = Convert.ToString(paquete[data_position + 1]);
                    string2 = Convert.ToString(Convert.ToInt32(string2, 16), 2);
                    string2 = AddZeros(string2);


                    TrackNumber = String.Concat(string1, string2);

                    data_position = data_position + 2;

                    Calculate_TrackNumber(TrackNumber);
                }// 3 I021/161 Track Number 

                if (Char.ToString(FSPEC_fake[3]) == "1") // 4 I021/015 Service Identification 
                {
                    string string1 = Convert.ToString(paquete[data_position]);
                    string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                    string1 = AddZeros(string1);

                    ServiceIdentification = String.Concat(string1);

                    data_position = data_position + 1;

                    ServiceIdentification_number = Convert.ToInt32(ServiceIdentification, 2);

                } // 4 I021/015 Service Identification 

                if (Char.ToString(FSPEC_fake[4]) == "1") // 5 I021/071 Time of Applicability for Position
                {
                    string string1 = Convert.ToString(paquete[data_position]);
                    string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                    string1 = AddZeros(string1);

                    string string2 = Convert.ToString(paquete[data_position + 1]);
                    string2 = Convert.ToString(Convert.ToInt32(string2, 16), 2);
                    string2 = AddZeros(string2);

                    string string3 = Convert.ToString(paquete[data_position + 2]);
                    string3 = Convert.ToString(Convert.ToInt32(string3, 16), 2);
                    string3 = AddZeros(string3);

                    TimeofApplicability_Position = String.Concat(string1, string2, string3);

                    data_position = data_position + 3;

                    Calculate_TimeofAppliability_Position(TimeofApplicability_Position);
                }// 5 I021/071 Time of Applicability for Position

                if (Char.ToString(FSPEC_fake[5]) == "1") // 6 I021/130 Position in WGS-84 coordinates
                {

                    string string1 = Convert.ToString(paquete[data_position]);
                    string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                    string1 = AddZeros(string1);

                    string string2 = Convert.ToString(paquete[data_position + 1]);
                    string2 = Convert.ToString(Convert.ToInt32(string2, 16), 2);
                    string2 = AddZeros(string2);

                    string string3 = Convert.ToString(paquete[data_position + 2]);
                    string3 = Convert.ToString(Convert.ToInt32(string3, 16), 2);
                    string3 = AddZeros(string3);

                    string string4 = Convert.ToString(paquete[data_position + 3]);
                    string4 = Convert.ToString(Convert.ToInt32(string4, 16), 2);
                    string4 = AddZeros(string4);

                    string string5 = Convert.ToString(paquete[data_position + 4]);
                    string5 = Convert.ToString(Convert.ToInt32(string5, 16), 2);
                    string5 = AddZeros(string5);

                    string string6 = Convert.ToString(paquete[data_position + 5]);
                    string6 = Convert.ToString(Convert.ToInt32(string6, 16), 2);
                    string6 = AddZeros(string6);

                    PositioninWGS_coordinates = String.Concat(string1, string2, string3, string4, string5, string6);

                    data_position = data_position + 6;

                    CalculatePositionWGS84_coordinates(PositioninWGS_coordinates);

                    coordinatesWGS84 = new CoordinatesWGS84(latWGS84, lonWGS84);
                    CoordinatesXYZ coordGeocentric = change_geodesic2geocentric(coordinatesWGS84);
                    CoordinatesXYZ coordSystemCartesian = change_geocentric2system_cartesian(coordGeocentric);
                    coordinatesUVH = change_system_cartesian2stereographic(coordSystemCartesian);


                }// 6 I021/130 Position in WGS-84 coordinates

                if (Char.ToString(FSPEC_fake[6]) == "1") // 7 I021/131 Position in WGS-84 co-ordinates, high res
                {

                    string string1 = Convert.ToString(paquete[data_position]);
                    string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                    string1 = AddZeros(string1);

                    string string2 = Convert.ToString(paquete[data_position + 1]);
                    string2 = Convert.ToString(Convert.ToInt32(string2, 16), 2);
                    string2 = AddZeros(string2);

                    string string3 = Convert.ToString(paquete[data_position + 2]);
                    string3 = Convert.ToString(Convert.ToInt32(string3, 16), 2);
                    string3 = AddZeros(string3);

                    string string4 = Convert.ToString(paquete[data_position + 3]);
                    string4 = Convert.ToString(Convert.ToInt32(string4, 16), 2);
                    string4 = AddZeros(string4);

                    string string5 = Convert.ToString(paquete[data_position + 4]);
                    string5 = Convert.ToString(Convert.ToInt32(string5, 16), 2);
                    string5 = AddZeros(string5);

                    string string6 = Convert.ToString(paquete[data_position + 5]);
                    string6 = Convert.ToString(Convert.ToInt32(string6, 16), 2);
                    string6 = AddZeros(string6);

                    string string7 = Convert.ToString(paquete[data_position + 6]);
                    string7 = Convert.ToString(Convert.ToInt32(string7, 16), 2);
                    string7 = AddZeros(string7);

                    string string8 = Convert.ToString(paquete[data_position + 7]);
                    string8 = Convert.ToString(Convert.ToInt32(string8, 16), 2);
                    string8 = AddZeros(string8);

                    PositioninWGS_HRcoordinates = String.Concat(string1, string2, string3, string4, string5, string6, string7, string8);

                    data_position = data_position + 8;

                    CalculatePositionWGS84_HRcoordinates(PositioninWGS_HRcoordinates);

                    coordinatesWGS84 = new CoordinatesWGS84(latWGS84, lonWGS84);
                    CoordinatesXYZ coordGeocentric = change_geodesic2geocentric(coordinatesWGS84);
                    CoordinatesXYZ coordSystemCartesian = change_geocentric2system_cartesian(coordGeocentric);
                    coordinatesUVH = change_system_cartesian2stereographic(coordSystemCartesian);

                } // 7 I021/131 Position in WGS-84 co-ordinates, high res

                if (Char.ToString(FSPEC_fake[7]) == "1") //FX
                {
                }// FX

                if (FSPEC.Length > 8)
                {
                    if (Char.ToString(FSPEC_fake[8]) == "1") // 8 I021/072 Time of Applicability for Velocity
                    {
                        i = 0;
                        while (i < 3)
                        {
                            string string1 = Convert.ToString(paquete[data_position + i]);
                            string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                            string2 = AddZeros(string2);
                            TimeofApplicability_Velocity = String.Concat(TimeofApplicability_Velocity, string2);
                            i = i + 1;
                        }

                        data_position = data_position + 3;

                        TimeofApplicability_Velocity_seconds = Convert.ToInt32(TimeofApplicability_Velocity, 2) / 128;

                    }

                    if (Char.ToString(FSPEC_fake[9]) == "1") // 9 I021/150 Air Speed 
                    {
                        i = 0;
                        while (i < 2)
                        {
                            string string1 = Convert.ToString(paquete[data_position + i]);
                            string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                            string2 = AddZeros(string2);
                            AirSpeed = String.Concat(AirSpeed, string2);
                            i = i + 1;
                        }

                        data_position = data_position + 2;

                        Calculate_AirSpeed(AirSpeed);

                    }

                    if (Char.ToString(FSPEC_fake[10]) == "1") // 10 I021/151 True Air Speed
                    {
                        i = 0;
                        while (i < 2 && data_position < paquete.Length)
                        {
                            string string1 = Convert.ToString(paquete[data_position + i]);
                            string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                            string2 = AddZeros(string2);
                            TrueAirSpeed = String.Concat(TrueAirSpeed, string2);
                            i = i + 1;
                            data_position = data_position + 1;
                        }

                        Calculate_TrueAirSpeed(TrueAirSpeed);

                    }

                    if (Char.ToString(FSPEC_fake[11]) == "1") // 11 I021/080 Target Address
                    {

                        string hexa = "";

                        i = 0;
                        while (i < 3)
                        {
                            string string1 = Convert.ToString(paquete[data_position + i]);
                            char a = string1[0];
                            char b = string1[1];
                            hexa = string.Concat(hexa, a);
                            hexa = string.Concat(hexa, b);
                            string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                            string2 = AddZeros(string2);
                            TargetAddress_bin = String.Concat(TargetAddress_bin, string2);
                            i = i + 1;
                        }

                        data_position = data_position + 3;

                        TargetAdress_real = hexa;
                    }

                    if (Char.ToString(FSPEC_fake[12]) == "1") // 12 I021/073 Time of Message Reception of Position
                    {

                        i = 0;
                        while (i < 3)
                        {
                            string string1 = Convert.ToString(paquete[data_position + i]);
                            string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                            string2 = AddZeros(string2);
                            TimeofMessageReception_Position = String.Concat(TimeofMessageReception_Position, string2);
                            i = i + 1;
                        }

                        data_position = data_position + 3;

                        TimeofMessageReception_Position_seconds = Convert.ToInt32(TimeofMessageReception_Position, 2);
                        TimeofMessageReception_Position_seconds = TimeofMessageReception_Position_seconds / 128;

                    }

                    if (Char.ToString(FSPEC_fake[13]) == "1") // 13 I021 / 074 Time of Message Reception of Position-High
                    {

                        i = 0;
                        while (i < 4)
                        {
                            string string1 = Convert.ToString(paquete[data_position + i]);
                            string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                            string2 = AddZeros(string2);
                            TimeofMessageReception_HRPosition = String.Concat(TimeofMessageReception_HRPosition, string2);
                            i = i + 1;
                        }

                        data_position = data_position + 4;

                        Calculate_TimeofMessageReception_HRPosition(TimeofMessageReception_HRPosition);
                    }

                    if (Char.ToString(FSPEC_fake[14]) == "1") // 14 I021/075 Time of Message Reception of Velocity 
                    {
                        i = 0;
                        while (i < 3)
                        {
                            string string1 = Convert.ToString(paquete[data_position + i]);
                            string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                            string2 = AddZeros(string2);
                            TimeofMessageReception_Velocity = String.Concat(TimeofMessageReception_Velocity, string2);
                            i = i + 1;
                        }

                        data_position = data_position + 3;

                        int time = Convert.ToInt32(TimeofMessageReception_Velocity, 2);
                        TimeofMessageReception_Velocity_seconds = time * 1 / 128;

                    }

                    if (Char.ToString(FSPEC_fake[15]) == "1") // FX - Field extension indicator 
                    {
                    }// FX

                    if (FSPEC.Length > 16)
                    {
                        if (Char.ToString(FSPEC_fake[16]) == "1") // 15 I021 / 076 Time of Message Reception of Velocity-High Precision
                        {
                            i = 0;
                            while (i < 4)
                            {
                                string string1 = Convert.ToString(paquete[data_position + i]);
                                string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                string2 = AddZeros(string2);
                                TimeofMessageReception_HRVelocity = String.Concat(TimeofMessageReception_HRVelocity, string2);
                                i = i + 1;
                            }

                            data_position = data_position + 4;

                            Calculate_TimeofMessageReception_HRVelocity(TimeofMessageReception_HRVelocity);
                            var a = TimeofMessageReception_HRVelocity_seconds;
                        }

                        if (Char.ToString(FSPEC_fake[17]) == "1") // 16 I021/140 Geometric Height
                        {
                            i = 0;
                            while (i < 2)
                            {
                                string string1 = Convert.ToString(paquete[data_position + i]);
                                string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                string2 = AddZeros(string2);
                                GeometricHeight = String.Concat(GeometricHeight, string2);
                                i = i + 1;
                            }

                            data_position = data_position + 2;

                            if (GeometricHeight[0] == Convert.ToChar("0"))
                            {
                                string str1 = GeometricHeight.Substring(1, 15);
                                GeometricHeight_feet = Calculate_ComplementoA2(str1);
                                GeometricHeight_feet = GeometricHeight_feet * 6.25;
                            }
                            else
                            {
                                string str1 = GeometricHeight.Substring(1, 15);
                                GeometricHeight_feet = Convert.ToInt32(str1, 2);
                                GeometricHeight_feet = GeometricHeight_feet * 6.25;
                            }

                        }

                        if (Char.ToString(FSPEC_fake[18]) == "1")// 17 I021/090 Quality Indicators
                        {
                            // primero leemos el primer paquete y lo pasamos a binario

                            string string_packet = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                            string_packet = AddZeros(string_packet);

                            if ((Convert.ToString(string_packet[7])) == "0") // si ultima posicion es un 0 guardamos el octeto y pasamos al siguiente
                            {
                                QualityIndicators = string_packet;
                                data_position = data_position + 1;
                            }
                            if ((Convert.ToString(string_packet[7])) == "1") // si ultimo valor =1 hacemos un bucle que vaya concatenando todos los octetos acabados en 1
                            {
                                i = 0;
                                data_position = data_position + 1;
                                while ((Convert.ToString(string_packet[string_packet.Length - 1])) == "1" && string_packet.Length < 32)
                                {
                                    string string_packet2 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                                    string_packet2 = AddZeros(string_packet2);
                                    string_packet = string.Concat(string_packet, string_packet2);
                                    data_position = data_position + 1;
                                    i = i + 1;
                                }
                            }

                            QualityIndicators = string_packet;

                            Calculate_QualityIndicators(QualityIndicators);

                        }

                        if (Char.ToString(FSPEC_fake[19]) == "1")// 18 I021/210 MOPS Version
                        {
                            i = 0;
                            while (i < 1)
                            {
                                string string1 = Convert.ToString(paquete[data_position + i]);
                                string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                string2 = AddZeros(string2);
                                MOPSVersion = String.Concat(MOPSVersion, string2);
                                i = i + 1;
                            }

                            data_position = data_position + 1;

                            Calculate_MOPSVersion(MOPSVersion);
                        }

                        if (Char.ToString(FSPEC_fake[20]) == "1") // 19 I021/070 Mode 3/A Code
                        {
                            bool bool1 = false;

                            i = 0;
                            while (i < 2 && data_position < paquete.Length)
                            {
                                string string1 = Convert.ToString(paquete[data_position + i]);
                                string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                string2 = AddZeros(string2);
                                Mode3ACode_bin = String.Concat(Mode3ACode_bin, string2);
                                i = i + 1;
                                bool1 = true;
                            }

                            data_position = data_position + 2;

                            if (bool1 == true)
                            {
                                int int1 = Convert.ToInt32(Mode3ACode_bin, 2); // pasamos de binario a decimal
                                Mode3ACode_oct = Convert.ToString(int1, 8); // pasamos de decimal a octal
                                while (Mode3ACode_oct.Length < 4) { Mode3ACode_oct = String.Concat("0", Mode3ACode_oct); }
                            }

                        }

                        if (Char.ToString(FSPEC_fake[21]) == "1") // 20 I021/230 Roll Angle
                        {
                            i = 0;
                            while (i < 2)
                            {
                                string string1 = Convert.ToString(paquete[data_position + i]);
                                string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                string2 = AddZeros(string2);
                                RollAngle = String.Concat(RollAngle, string2);
                                i = i + 1;
                            }

                            data_position = data_position + 2;

                            int int1 = Convert.ToInt32(RollAngle, 2);
                            RollAngle_degrees = int1 * 0.01;
                        }

                        if (Char.ToString(FSPEC_fake[22]) == "1") // 21 I021/145 Flight Level
                        {
                            i = 0;
                            while (i < 2)
                            {
                                string string1 = Convert.ToString(paquete[data_position + i]);
                                string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                string2 = AddZeros(string2);
                                FlightLevel = String.Concat(FlightLevel, string2);
                                i = i + 1;
                            }

                            data_position = data_position + 2;

                            FlightLevel_FL = Math.Round((Calculate_ComplementoA2(FlightLevel)) / 4);

                        }

                        if (Char.ToString(FSPEC_fake[23]) == "1") // FX - Field extension indicator
                        {
                        } // FX

                        if (FSPEC.Length > 24)
                        {
                            if (Char.ToString(FSPEC_fake[24]) == "1") // 22 I021/152 Magnetic Heading
                            {
                                i = 0;
                                while (i < 2)
                                {
                                    string string1 = Convert.ToString(paquete[data_position + i]);
                                    string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                    string2 = AddZeros(string2);
                                    MagneticHeading = String.Concat(MagneticHeading, string2);
                                    i = i + 1;
                                }

                                data_position = data_position + 2;

                                MagneticHeading_degrees = (Convert.ToInt32(MagneticHeading, 2)) * (360 / Math.Pow(2, 16));
                            }

                            if (Char.ToString(FSPEC_fake[25]) == "1") // 23 I021/200 Target Status 
                            {
                                i = 0;
                                while (i < 1)
                                {
                                    string string1 = Convert.ToString(paquete[data_position + i]);
                                    string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                    string2 = AddZeros(string2);
                                    TargetStatus = String.Concat(TargetStatus, string2);
                                    i = i + 1;
                                }

                                data_position = data_position + 1;

                                Calculate_TargetStatus(TargetStatus);
                            }

                            if (Char.ToString(FSPEC_fake[26]) == "1") // 24 I021/155 Barometric Vertical Rate
                            {
                                i = 0;
                                while (i < 2)
                                {
                                    string string1 = Convert.ToString(paquete[data_position + i]);
                                    string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                    string2 = AddZeros(string2);
                                    BarometricVerticalRate = String.Concat(BarometricVerticalRate, string2);
                                    i = i + 1;
                                }

                                data_position = data_position + 2;

                                Calculate_BarometricVerticalRate(BarometricVerticalRate);


                            }

                            if (Char.ToString(FSPEC_fake[27]) == "1") // 25 I021/157 Geometric Vertical Rate
                            {
                                i = 0;
                                while (i < 2)
                                {
                                    string string1 = Convert.ToString(paquete[data_position + i]);
                                    string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                    string2 = AddZeros(string2);
                                    GeometricVerticalRate = String.Concat(GeometricVerticalRate, string2);
                                    i = i + 1;
                                }

                                data_position = data_position + 2;

                                Calculate_GeometricVerticalRate(GeometricVerticalRate);

                            }

                            if (Char.ToString(FSPEC_fake[28]) == "1") // 26 I021/160 Airborne Ground Vector 
                            {
                                i = 0;
                                while (i < 4)
                                {
                                    string string1 = Convert.ToString(paquete[data_position + i]);
                                    string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                    string2 = AddZeros(string2);
                                    AirborneGoundVector = String.Concat(AirborneGoundVector, string2);
                                    i = i + 1;
                                }

                                data_position = data_position + 4;

                                Calculate_AirborneGroundVector(AirborneGoundVector);
                            }

                            if (Char.ToString(FSPEC_fake[29]) == "1") // 27 I021/165 Track Angle Rate
                            {
                                i = 0;
                                while (i < 2)
                                {
                                    string string1 = Convert.ToString(paquete[data_position + i]);
                                    string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                    string2 = AddZeros(string2);
                                    TrackAngleRate = String.Concat(TrackAngleRate, string2);
                                    i = i + 1;
                                }

                                data_position = data_position + 2;

                                string str1 = TrackAngleRate.Substring(6, 10);
                                TrackAngleRate_degs = (Calculate_ComplementoA2(str1)) / 32;
                            }

                            if (Char.ToString(FSPEC_fake[30]) == "1") // 28 I021/077 Time of Report Transmission 
                            {
                                i = 0;
                                while (i < 3)
                                {
                                    string string1 = Convert.ToString(paquete[data_position + i]);
                                    string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                    string2 = AddZeros(string2);
                                    TimeofASTERIXReportTransmission = String.Concat(TimeofASTERIXReportTransmission, string2);
                                    i = i + 1;
                                }

                                data_position = data_position + 3;

                                double int1 = Convert.ToInt32(TimeofASTERIXReportTransmission, 2);
                                TimeofASTERIXReportTransmission_seconds = int1 / 128;
                            }

                            if (Char.ToString(FSPEC_fake[31]) == "1") // FX - Field extension indicator 
                            {

                            }// FX

                            if (FSPEC.Length > 32)
                            {
                                if (Char.ToString(FSPEC_fake[32]) == "1") // 29 I021/170 Target Identification
                                {
                                    i = 0;
                                    while (i < 6)
                                    {
                                        string string1 = Convert.ToString(paquete[data_position + i]);
                                        string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                        string2 = AddZeros(string2);
                                        TargetIdentification = String.Concat(TargetIdentification, string2);
                                        i = i + 1;
                                    }

                                    data_position = data_position + 6;

                                    Compute_TargetIdentification(TargetIdentification);
                                    string a = TargetIdentification_decoded;
                                }

                                if (Char.ToString(FSPEC_fake[33]) == "1") // 30 I021/020 Emitter Category 
                                {

                                    i = 0;
                                    while (i < 1)
                                    {
                                        string string1 = Convert.ToString(paquete[data_position + i]);
                                        string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                        string2 = AddZeros(string2);
                                        EmitterCategory = String.Concat(EmitterCategory, string2);
                                        i = i + 1;
                                    }

                                    data_position = data_position + 1;

                                    Calculate_EmitterCategory(EmitterCategory);

                                }

                                if (Char.ToString(FSPEC_fake[34]) == "1") // 31 I021/220 Met Information
                                {
                                    // primero leemos el primer paquete y lo pasamos a binario

                                    string string_packet = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                                    string_packet = AddZeros(string_packet);

                                    if ((Convert.ToString(string_packet[7])) == "0") // si ultima posicion es un 0 guardamos el octeto y pasamos al siguiente
                                    {
                                        MetInformation = string_packet;
                                        data_position = data_position + 1;
                                    }
                                    if ((Convert.ToString(string_packet[7])) == "1") // si ultimo valor =1 hacemos un bucle que vaya concatenando todos los octetos acabados en 1
                                    {
                                        i = 0;
                                        data_position = data_position + 1;
                                        while ((Convert.ToString(string_packet[string_packet.Length - 1])) == "1" && string_packet.Length < 64)
                                        {
                                            string string_packet2 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                                            string_packet2 = AddZeros(string_packet2);
                                            string_packet = string.Concat(string_packet, string_packet2);
                                            data_position = data_position + 1;
                                            i = i + 1;
                                        }
                                    }

                                    MetInformation = string_packet;

                                    Calculate_MetInformation(MetInformation);

                                }

                                if (Char.ToString(FSPEC_fake[35]) == "1") // 32 I021/146 Selected Altitude  
                                {
                                    i = 0;
                                    while (i < 2)
                                    {
                                        string string1 = Convert.ToString(paquete[data_position + i]);
                                        string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                        string2 = AddZeros(string2);
                                        SelectedAltitude = String.Concat(SelectedAltitude, string2);
                                        i = i + 1;
                                    }

                                    data_position = data_position + 2;

                                    Calculate_SelectedAltitude(SelectedAltitude);
                                }

                                if (Char.ToString(FSPEC_fake[36]) == "1") // 33 I021/148 Final State Selected Altitude 
                                {
                                    i = 0;
                                    while (i < 2)
                                    {
                                        string string1 = Convert.ToString(paquete[data_position + i]);
                                        string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                        string2 = AddZeros(string2);
                                        FinalStateSelectedAltitude = String.Concat(FinalStateSelectedAltitude, string2);
                                        i = i + 1;
                                    }

                                    data_position = data_position + 2;

                                    Calculate_FinalStateSelectedAltitude(FinalStateSelectedAltitude);

                                }

                                if (Char.ToString(FSPEC_fake[37]) == "1") // 34 I021/110 Trajectory Intent
                                {


                                    string string_packet = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                                    string_packet = AddZeros(string_packet);

                                    if ((Convert.ToString(string_packet[7])) == "0") // si ultima posicion es un 0 guardamos el octeto y pasamos al siguiente
                                    {
                                        TrajectoryIntent = string_packet;
                                        data_position = data_position + 1;

                                    }

                                    if ((Convert.ToString(string_packet[7])) == "1") // si ultimo valor =1 hacemos un bucle que vaya concatenando todos los octetos acabados en 1
                                    {
                                        while (Convert.ToString(string_packet[string_packet.Length - 1]) == "1" && string_packet.Length < (18 * 8))
                                        {
                                            string string_packet2 = Convert.ToString(Convert.ToInt32(paquete[data_position + 1], 16), 2);
                                            string_packet2 = AddZeros(string_packet2);
                                            string_packet = string.Concat(string_packet, string_packet2);
                                            data_position = data_position + 1;
                                        }

                                    }

                                    TrajectoryIntent = string_packet;
                                    Calculate_TrajectoryIntent(TrajectoryIntent);

                                }

                                if (Char.ToString(FSPEC_fake[38]) == "1") // 35 I021/016 Service Management
                                {
                                    i = 0;
                                    while (i < 1)
                                    {
                                        string string1 = Convert.ToString(paquete[data_position + i]);
                                        string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                        string2 = AddZeros(string2);
                                        ServiceManagement = String.Concat(ServiceManagement, string2);
                                        i = i + 1;
                                    }

                                    data_position = data_position + 1;

                                    RP = Convert.ToInt32(ServiceManagement, 2) * 0.5;

                                }

                                if (Char.ToString(FSPEC_fake[39]) == "1") // FX - Field extension indicator 
                                {

                                }// FX

                                if (FSPEC.Length > 40)
                                {
                                    if (Char.ToString(FSPEC_fake[40]) == "1") // 36 I021/008 Aircraft Operational Status
                                    {
                                        i = 0;
                                        while (i < 1)
                                        {
                                            string string1 = Convert.ToString(paquete[data_position + i]);
                                            string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                            string2 = AddZeros(string2);
                                            AircraftOperationalStatus = String.Concat(AircraftOperationalStatus, string2);
                                            i = i + 1;
                                        }

                                        data_position = data_position + 1;

                                        Calculate_AircraftOperationalStatus(AircraftOperationalStatus);
                                    }

                                    if (Char.ToString(FSPEC_fake[41]) == "1") // 37 I021/271 Surface Capabilities and Characteristics
                                    {

                                        // primero leemos el primer paquete y lo pasamos a binario

                                        string string_packet = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                                        string_packet = AddZeros(string_packet);

                                        if ((Convert.ToString(string_packet[7])) == "0") // si ultima posicion es un 0 guardamos el octeto y pasamos al siguiente
                                        {
                                            SurfaceCapabilitiesandCharacteristicas = string_packet;
                                            data_position = data_position + 1;
                                        }
                                        if ((Convert.ToString(string_packet[7])) == "1") // si ultimo valor =1 hacemos un bucle que vaya concatenando todos los octetos acabados en 1
                                        {
                                            i = 0;
                                            data_position = data_position + 1;
                                            while ((Convert.ToString(string_packet[string_packet.Length - 1])) == "1" && string_packet.Length < 16)
                                            {
                                                string string_packet2 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                                                string_packet2 = AddZeros(string_packet2);
                                                string_packet = string.Concat(string_packet, string_packet2);
                                                data_position = data_position + 1;
                                                i = i + 1;
                                            }
                                        }

                                        SurfaceCapabilitiesandCharacteristicas = string_packet;

                                        Calculate_SurfaceCapabilitiesandCharacterístics(SurfaceCapabilitiesandCharacteristicas);

                                    }

                                    if (Char.ToString(FSPEC_fake[42]) == "1") // 38 I021/132 Message Amplitude 
                                    {
                                        i = 0;
                                        while (i < 1)
                                        {
                                            string string1 = Convert.ToString(paquete[data_position + i]);
                                            string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                            string2 = AddZeros(string2);
                                            MessageAmplitude = String.Concat(MessageAmplitude, string2);
                                            i = i + 1;
                                        }

                                        data_position = data_position + 1;

                                        MessageAmplitude_dBm = Calculate_ComplementoA2(MessageAmplitude);
                                    }

                                    if (Char.ToString(FSPEC_fake[43]) == "1") // 39 I021/250 Mode S MB Data
                                    {

                                        data_position = data_position + Calculate_ModeSMBData(paquete, data_position);

                                    }

                                    if (Char.ToString(FSPEC_fake[44]) == "1") // 40 I021/260 ACAS Resolution Advisory Report 
                                    {
                                        i = 0;
                                        while (i < 7)
                                        {
                                            string string1 = Convert.ToString(paquete[data_position + i]);
                                            string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                            string2 = AddZeros(string2);
                                            ACASResolutionAdvisoryReport = String.Concat(ACASResolutionAdvisoryReport, string2);
                                            i = i + 1;
                                        }

                                        data_position = data_position + 7;

                                        Calculate_ACASResolutionAdvisoryReport(ACASResolutionAdvisoryReport);
                                    }

                                    if (Char.ToString(FSPEC_fake[45]) == "1") // 41 I021/400 Receiver ID
                                    {
                                        i = 0;
                                        while (i < 1)
                                        {
                                            string string1 = Convert.ToString(paquete[data_position + i]);
                                            string string2 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                            string2 = AddZeros(string2);
                                            ReceiverID = String.Concat(ReceiverID, string2);
                                            i = i + 1;
                                        }

                                        data_position = data_position + 1;

                                        Calculate_ReceiverID(ReceiverID);
                                    }

                                    if (Char.ToString(FSPEC_fake[46]) == "1") // 42 I021/295 Data Ages 
                                    {

                                        // primero leemos el primer paquete y lo pasamos a binario

                                        string string_packet = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                                        string_packet = AddZeros(string_packet);

                                        if ((Convert.ToString(string_packet[7])) == "0") // si ultima posicion es un 0 guardamos el octeto y pasamos al siguiente
                                        {
                                            DataAges = string_packet;
                                            data_position = data_position + 1;
                                        }
                                        if ((Convert.ToString(string_packet[7])) == "1") // si ultimo valor =1 hacemos un bucle que vaya concatenando todos los octetos acabados en 1
                                        {
                                            i = 0;
                                            data_position = data_position + 1;
                                            while (((Convert.ToString(string_packet[string_packet.Length - 1])) == "1") && (string_packet.Length < 32))
                                            {
                                                string string_packet2 = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                                                string_packet2 = AddZeros(string_packet2);
                                                string_packet = string.Concat(string_packet, string_packet2);
                                                data_position = data_position + 1;
                                                i = i + 1;
                                            }
                                        }


                                        DataAges = string_packet;
                                        data_position = Calculate_Data_Ages(DataAges, paquete, data_position);
                                    }

                                    if (Char.ToString(FSPEC_fake[47]) == "1") // FX - Field extension indicator 
                                    {

                                    }// FX
                                }
                            }
                        }
                    }
                }
            }
        }

        public static readonly object PositionRadarMatrixLock = new Object();
        public static readonly object RotationRadarMatrixLock = new Object();
        /// <summary>
        /// 1 meter -> 3,28084 feet
        /// </summary>
        public const double METERS2FEET = 3.28084;
        /// <summary>
        /// 1 feet -> 0,3048 meters
        /// </summary>
        public const double FEET2METERS = 0.3048;
        /// <summary>
        /// 1 meter -> 1/1852 nautic miles
        /// </summary>
        public const double METERS2NM = 1 / GeoUtils.NM2METERS;
        /// <summary>
        /// 1 nautic mile -> 1852 metres
        /// </summary>
        public const double NM2METERS = 1852.0;
        /// <summary>
        /// 1 degree -> pi/180.0 radians
        /// </summary>
        public const double DEGS2RADS = Math.PI / 180.0;
        /// <summary>
        /// 1 radian -> 180.0/pi degrees
        /// </summary>
        public const double RADS2DEGS = 180.0 / Math.PI;
        /// <summary>
        /// semi-major axis of the Europe-50 & WGS84 ellipsoid (in metres)
        /// </summary>
        public double A = 6378137.0;
        /// <summary>
        /// semi-minor axis of the Europe-50 & WGS84 ellipsoid (in metres)
        /// </summary>
        public double B = 6356752.3142;
        /// <summary>
        /// eccentricity of the ellipsoid squared
        /// </summary>
        public double E2 = 0.00669437999013;
        //(0.081819190843*0.081819190843);
        /// <summary>
        /// almost zero for zero comparisions with floating point maths
        /// </summary>
        public const double ALMOST_ZERO = 1e-10;
        /// <summary>
        /// almost zero for zero comparisions with floating point maths
        /// </summary>
        public const double REQUIERED_PRECISION = 1e-8;
        /// <summary>
        /// center of projection for the system cartesian coordinate transformation
        /// </summary>
        public CoordinatesWGS84 centerProjection;
        /// <summary>
        /// matrix for translation, from centerProjection
        /// </summary>
        private GeneralMatrix T1;
        /// <summary>
        /// matrix for rotation coordinates, from centerProjection
        /// </summary>
        private GeneralMatrix R1;
        /// <summary>
        /// best earth radius from centerProjection
        /// </summary>
        public double R_S = 0;

        /// <summary>
        /// rotation matrix for radar cartesian to geocentric
        /// </summary>
        private Dictionary<CoordinatesWGS84, GeneralMatrix> rotationMatrixHT = null;
        /// <summary>
        /// translation matrix (vector) for radar cartesian to geocentric
        /// </summary>
        private Dictionary<CoordinatesWGS84, GeneralMatrix> translationMatrixHT = null;
        /// <summary>
        /// position matrix (vector) for each radar in system coordinates (center on centerprojection)
        /// </summary>
        private Dictionary<CoordinatesWGS84, GeneralMatrix> positionRadarMatrixHT = null;
        /// <summary>
        /// rotation matrix for each radar in system coordinates (center on centerprojection)
        /// </summary>
        private Dictionary<CoordinatesWGS84, GeneralMatrix> rotationRadarMatrixHT = null;

        /// <summary>
        /// Default constructor
        /// </summary>
        //public GeoUtils() { }

        /// <summary>
        /// Constructor with initializers
        /// </summary>
        /// <param name="E">eccentricity of the ellipsoid</param>
        /// <param name="A">semi-major axis of the Europe-50 ellipsoid (in metres)</param>
        //public GeoUtils(double E, double A)
        //{
        //    this.E2 = E * E;
        //    this.A = A;
        //    setCenterProjection(new CoordinatesWGS84());
        //}
        /// <summary>
        /// Constructor with initializers
        /// </summary>
        /// <param name="E">eccentricity of the ellipsoid</param>
        /// <param name="A">semi-major axis of the Europe-50 ellipsoid (in metres)</param>
        /// <param name="centerProjection">center coordinates in lat,lon (radians), height (meters) for projections</param>
        //public GeoUtils(double E, double A, CoordinatesWGS84 centerProjection)
        //{
        //    this.E2 = E * E;
        //    this.A = A;
        //    setCenterProjection(centerProjection);
        //}
        /// <summary>
        /// parses a line containing latitude and longitude and returns an wgs84 object
        /// </summary>
        /// <param name="line">string line with coordinates in "[-]hh:mm:ss.ssss[NS] [-]hh:mm:ss.ssss[EW]" format</param>
        /// <param name="height">height of the point</param>
        /// <returns>height, latitude and longitude object in radians</returns>
        static public CoordinatesWGS84 LatLonStringBoth2Radians(string line, double height)
        {
            CoordinatesWGS84 res = LatLonStringBoth2Radians(line);
            res.Height = height;
            return res;
        }
        /// <summary>
        /// parses a line containing latitude and longitude and returns the numeric value
        /// </summary>
        /// <param name="line">string line with coordinates in "[-]hh:mm:ss.ssss[NS] [-]hh:mm:ss.ssss[EW] xxx.yyy" format</param>
        /// <returns>latitude and longitude in radians</returns>
        static public CoordinatesWGS84 LatLonStringBoth2Radians(string line)
        {
            string pattern = @"([-+]?)([0-9]+):([0-9]+):([0-9][0-9]*[.]*[0-9]+)([NS]?)\s+([-+]?)([0-9]+):([0-9]+):([0-9][0-9]*[.]*[0-9]+)([EW]?)[\s]*([0-9][0-9]*[.]*[0-9]+)?[.]*";
            //"40:29:58.00N 003:31:26.0W";
            //"40:29:58.00 -003:31:26.0"; // both are acceptable

            Regex reggie = new Regex(pattern);
            MatchCollection matches = reggie.Matches(line);
            string latMinus = string.Empty, lonMinus = string.Empty, latNS = string.Empty, lonEW = string.Empty;
            double lat1 = 0, lat2 = 0, lat3 = 0, lon1 = 0, lon2 = 0, lon3 = 0, height = 0;
            try
            {
                // we use the invariantInfo because our double is separated 
                // by a dot, and in other countries they use commas.
                System.Globalization.NumberFormatInfo myInv = System.Globalization.NumberFormatInfo.InvariantInfo;
                latMinus = matches[0].Groups[1].Captures[0].Value;
                lat1 = Convert.ToDouble(matches[0].Groups[2].Captures[0].Value);
                lat2 = Convert.ToDouble(matches[0].Groups[3].Captures[0].Value);
                lat3 = Convert.ToDouble(matches[0].Groups[4].Captures[0].Value, myInv);
                latNS = matches[0].Groups[5].Captures[0].Value;

                lonMinus = matches[0].Groups[6].Captures[0].Value;
                lon1 = Convert.ToDouble(matches[0].Groups[7].Captures[0].Value);
                lon2 = Convert.ToDouble(matches[0].Groups[8].Captures[0].Value);
                lon3 = Convert.ToDouble(matches[0].Groups[9].Captures[0].Value, myInv);
                lonEW = matches[0].Groups[10].Captures[0].Value;

                if (matches[0].Groups[11].Captures.Count > 0)
                    height = Convert.ToDouble(matches[0].Groups[11].Captures[0].Value, myInv);
                else
                    height = 0;
            }
            catch (Exception e)
            {
                //Program.logger.Log(NSpring.Logging.Level.Exception, "expecting line(" + line + ") to be accomply with the following regex:" + Environment.NewLine +
                //    pattern + Environment.NewLine +
                //    "more or less the following valid wgs84 strings will be correctly parsed (no negative heights):" + Environment.NewLine +
                //    "-00:20:23.98 +003:45:33 897.09m" + Environment.NewLine +
                //    "0:20:23.98S 03:45:33E 897" + Environment.NewLine +
                //    "00:20:23.98S 3:45:33E");
                //Program.logger.Log(NSpring.Logging.Level.Exception, "ERROR LatLonStringBoth2Radians(string line): " + e.ToString());
                //Environment.Exit(-1);
            }
            CoordinatesWGS84 res = new CoordinatesWGS84();
            int n = 0;
            if ((latMinus.Length > 0 && latMinus.Substring(0, 1).Equals("-")) || latNS.Equals("S"))
            {
                n = 1; if (lat1 < 0) lat1 *= -1; //quitamos el menos porque ya lo vamos a hacer con el parametro n
            }
            res.Lat = GeoUtils.LatLon2Radians(lat1, lat2, lat3, n);
            n = 0;
            if ((lonMinus.Length > 0 && lonMinus.Substring(0, 1).Equals("-")) || lonEW.Equals("W"))
            {
                n = 1; if (lon1 < 0) lon1 *= -1; //quitamos el menos porque ya lo vamos a hacer con el parametro n
            }
            res.Lon = GeoUtils.LatLon2Radians(lon1, lon2, lon3, n);
            res.Height = height;
            return res;
        }

        /// <summary>
        /// converts latitude or longitude expressed as ggºmm'ss,ss'' X to degrees dd,ddddº
        /// </summary>
        /// <param name="d1">degree</param>
        /// <param name="d2">minutes</param>
        /// <param name="d3">seconds</param>
        /// <param name="ns">North(0)/East(0) or South(1)/West(1)</param>
        /// <returns>degrees</returns>
        static public double LatLon2Degrees(double d1, double d2, double d3, int ns)
        {
            double d = d1 + (d2 / 60.0) + (d3 / 3600.0);
            if (ns == 1)
                d *= -1.0;
            return d;
        }

        /// <summary>
        /// converts latitude or longitude expressed as ggºmm'ss,ss'' X to radians dd,ddddr
        /// </summary>
        /// <param name="d1">degree</param>
        /// <param name="d2">minutes</param>
        /// <param name="d3">seconds</param>
        /// <param name="ns">North(0)/East(0) or South(1)/West(1)</param>
        /// <returns>radians</returns>
        static public double LatLon2Radians(double d1, double d2, double d3, int ns)
        {
            double d = d1 + (d2 / 60.0) + (d3 / 3600.0);
            if (ns == 1)
                d *= -1.0;
            return d * GeoUtils.DEGS2RADS;
        }

        /// <summary>
        /// converts latitude or longitude expressed as ggºmm'ss,ss'' X in a string to degrees dd,ddddº
        /// </summary>
        /// <param name="s1">degree</param>
        /// <param name="s2">minutes</param>
        /// <param name="s3">seconds</param>
        /// <param name="ns">North(0)/East(0) or South(1)/West(1)</param>
        /// <returns>degrees</returns>
        static public double LatLonString2Degrees(string s1, string s2, string s3, int ns)
        {
            double d = 0;
            try
            {
                double d1 = double.Parse(s1);
                double d2 = double.Parse(s2);
                double d3 = double.Parse(s3);
                d = GeoUtils.LatLon2Degrees(d1, d2, d3, ns);
            }
            catch (FormatException) { }
            return d;
        }

        /// <summary>
        /// converts degrees dd,ddddd to latitude or longitude expressed as ggºmm'ss,ss'' X 
        /// </summary>
        /// <param name="d">full degrees</param>
        /// <param name="d1">degree</param>
        /// <param name="d2">minutes</param>
        /// <param name="d3">seconds</param>
        /// <param name="ns">North(0)/East(0) or South(1)/West(1)</param>
        /// <returns></returns>
        static public void Degrees2LatLon(double d, out double d1, out double d2, out double d3, out int ns)
        {
            if (d < 0) { d *= -1.0; ns = 1; } else { ns = 0; }
            d1 = Math.Floor(d);
            d2 = Math.Floor((d - d1) * 60.0);
            d3 = (((d - d1) * 60.0) - d2) * 60.0;
        }

        /// <summary>
        /// converts radians dd,ddddd to latitude or longitude expressed as ggºmm'ss,ss'' X 
        /// </summary>
        /// <param name="d">full radians</param>
        /// <param name="d1">degree</param>
        /// <param name="d2">minutes</param>
        /// <param name="d3">seconds</param>
        /// <param name="ns">North(0)/East(0) or South(1)/West(1)</param>
        /// <returns></returns>
        static public void Radians2LatLon(double d, out double d1, out double d2, out double d3, out int ns)
        {
            d *= GeoUtils.RADS2DEGS;
            if (d < 0) { d *= -1.0; ns = 1; } else { ns = 0; }
            d1 = Math.Floor(d);
            d2 = Math.Floor((d - d1) * 60.0);
            d3 = (((d - d1) * 60.0) - d2) * 60.0;
        }

        /// <summary>
        /// Calculates centre of coordinates from a list of radians (lat/lon).
        /// </summary>
        /// <param name="l">Arraylist of Coordinates</param>
        /// <returns>Center of coordinates</returns>
        static public CoordinatesWGS84 CenterCoordinates(List<CoordinatesWGS84> l)
        {
            double maxLat = -999, maxLon = -999, minLat = 999, minLon = 999, maxHeight = -999;
            if (l != null && l.Count > 0)
            {
                foreach (CoordinatesWGS84 c in l)
                {
                    if (maxLat < c.Lat) maxLat = c.Lat;
                    if (maxLon < c.Lon) maxLon = c.Lon;
                    if (minLat > c.Lat) minLat = c.Lat;
                    if (minLon > c.Lon) minLon = c.Lon;
                    if (maxHeight < c.Height) maxHeight = c.Height; // wont be used for setCenterProjection
                }
                CoordinatesWGS84 res = new CoordinatesWGS84();
                res.Lat = (maxLat + minLat) / 2.0;
                res.Lon = (maxLon + minLon) / 2.0;
                res.Height = maxHeight;
                return res;
            }
            else
                return (CoordinatesWGS84)null;
        }

        /// <summary>
        /// changes the coordinates from geodesic to geocentric (lat,lon to x,y,z)
        /// </summary>
        /// <param name="c">lat,lon (radians), height (meters) coordinates</param>
        /// <returns>x,y,z coordinates</returns>
        public CoordinatesXYZ change_geodesic2geocentric(CoordinatesWGS84 c)
        {
            if (c == null) return (CoordinatesXYZ)null;
            CoordinatesXYZ res = new CoordinatesXYZ();
            double nu = this.A / Math.Sqrt(1 - this.E2 * Math.Pow(Math.Sin(c.Lat), 2.0));
            res.X = (nu + c.Height) * Math.Cos(c.Lat) * Math.Cos(c.Lon);
            res.Y = (nu + c.Height) * Math.Cos(c.Lat) * Math.Sin(c.Lon);
            res.Z = (nu * (1 - this.E2) + c.Height) * Math.Sin(c.Lat);
            return res;
        }

        /// <summary>
        /// changes the coordinates from geocentric to geodesic (x,y,z to lat,lon)
        /// </summary>
        /// <param name="c">x,y,z coordinates</param>
        /// <returns>lat,lon (radians),height (meters) coordinates</returns>
        public CoordinatesWGS84 change_geocentric2geodesic(CoordinatesXYZ c)
        {
            if (c == null) return null;
            CoordinatesWGS84 res = new CoordinatesWGS84();
            // semi-minor earth axis
            //double b = this.A * Math.Sqrt(1 - this.E2);
            double b = 6356752.3142;

            if ((Math.Abs(c.X) < GeoUtils.ALMOST_ZERO) && (Math.Abs(c.Y) < GeoUtils.ALMOST_ZERO))
            {
                if (Math.Abs(c.Z) < GeoUtils.ALMOST_ZERO)
                {
                    // the point is at the center of earth :)
                    res.Lat = Math.PI / 2.0;
                }
                else
                {
                    res.Lat = (Math.PI / 2.0) * ((c.Z / Math.Abs(c.Z)) + 0.5);
                }
                res.Lon = 0;
                res.Height = Math.Abs(c.Z) - b;
                return res;
            }

            double d_xy = Math.Sqrt(c.X * c.X + c.Y * c.Y);
            // from formula 20
            res.Lat = Math.Atan((c.Z / d_xy) /
                (1 - (this.A * this.E2) / Math.Sqrt(d_xy * d_xy + c.Z * c.Z)));
            // from formula 24
            double nu = this.A / Math.Sqrt(1 - this.E2 * Math.Pow(Math.Sin(res.Lat), 2.0));
            // from formula 20
            res.Height = (d_xy / Math.Cos(res.Lat)) - nu;

            // iteration from formula 20b
            double Lat_over;
            if (res.Lat >= 0) { Lat_over = -0.1; } else { Lat_over = 0.1; }

            int loop_count = 0;
            while ((Math.Abs(res.Lat - Lat_over) > GeoUtils.REQUIERED_PRECISION)
                && (loop_count < 50))
            {
                loop_count++;
                Lat_over = res.Lat;
                res.Lat = Math.Atan((c.Z * (1 + res.Height / nu)) /
                    (d_xy * ((1 - this.E2) + (res.Height / nu))));
                nu = this.A / Math.Sqrt(1 - this.E2 * Math.Pow(Math.Sin(res.Lat), 2.0));
                res.Height = d_xy / Math.Cos(res.Lat) - nu;
            }
            res.Lon = Math.Atan2(c.Y, c.X);
            // if (loop_count == 50) { // exception }
            return res;
        }
        /// <summary>
        /// set the center coordinates for the system projections.
        /// </summary>
        /// <param name="c">coordinate center (lat, lon (radians), h (meters))</param>
        public CoordinatesWGS84 setCenterProjection(CoordinatesWGS84 c)
        {
            if (c == null) return null;

            // we create a new instance of c2. we need to modify c, and we don't
            // want the change to be bounced back to the caller. (classes are always 
            // passed as ref)
            // we set the height = 0 because the center of our projections will be
            // the ground. this is because all the height are referred to ground (AMSL?),
            // not to the top of a mountain.
            CoordinatesWGS84 c2 = new CoordinatesWGS84(c.Lat, c.Lon, 0); //c.Height);
            this.centerProjection = c2;
            double nu = this.A / Math.Sqrt(1 - this.E2 * Math.Pow(Math.Sin(c2.Lat), 2.0));

            this.R_S = (this.A * (1.0 - this.E2)) /
                Math.Pow(1 - this.E2 * Math.Pow(Math.Sin(c2.Lat), 2.0), 1.5);

            // alternative implementation as per wikipedia article.
            // doesn't give the same result! probably doesn't work. NOT TO BE USED, NEVER!
            //R(f)^2 = ( a^4 cos(f)^2 + b^4 sin(f)^2 ) / ( a^2 cos(f)^2 + b^2 sin(f)^2 ).
            //this.R_S = Math.Sqrt((Math.Pow((this.A * this.A * Math.Cos(c2.Lat)), 2) +
            //    Math.Pow((this.B * this.B * Math.Sin(c2.Lat)), 2)) / (
            //    Math.Pow((this.A * Math.Cos(c2.Lat)), 2) +
            //    Math.Pow((this.B * Math.Sin(c2.Lat)), 2)
            //    ));

            this.T1 = CalculateTranslationMatrix(c2, this.A, this.E2);
            this.R1 = GeoUtils.CalculateRotationMatrix(c2.Lat, c2.Lon);

            return this.centerProjection;
        }

        /// <summary>
        /// get the center coordinates for the system projections.
        /// </summary>
        public CoordinatesWGS84 getCenterProjection() { return this.centerProjection; }

        /// <summary>
        /// changes the coordinates from geocentric to cartesian (x,y,z to x,y,z projected)
        /// </summary>
        /// <param name="geo">x,y,z geocentric coordinates</param>
        /// <returns>x,y,z projected</returns>
        public CoordinatesXYZ change_geocentric2system_cartesian(CoordinatesXYZ geo)
        {

            if (this.centerProjection == null || this.R1 == null ||
                this.T1 == null || geo == null) return (CoordinatesXYZ)null;

            double[][] coefInput = { new double[1], new double[1], new double[1] };
            coefInput[0][0] = geo.X; coefInput[1][0] = geo.Y; coefInput[2][0] = geo.Z;
            GeneralMatrix inputMatrix = new GeneralMatrix(coefInput, 3, 1);

            inputMatrix.SubtractEquals(this.T1);
            GeneralMatrix R2 = this.R1.Multiply(inputMatrix);

            CoordinatesXYZ res = new CoordinatesXYZ(R2.GetElement(0, 0),
                                        R2.GetElement(1, 0),
                                        R2.GetElement(2, 0));
            return res;
        }
        /// <summary>
        /// changes the coordinates from cartesian to geocentric (x,y,z projected to x,y,z)
        /// </summary>
        /// <param name="car">x,y,z projected coordinates</param>
        /// <returns>x,y,z geocentric coordinates</returns>
        public CoordinatesXYZ change_system_cartesian2geocentric(CoordinatesXYZ car)
        {

            if (car == null) return (CoordinatesXYZ)null;

            double[][] coefInput = { new double[1], new double[1], new double[1] };
            coefInput[0][0] = car.X; coefInput[1][0] = car.Y; coefInput[2][0] = car.Z;
            GeneralMatrix inputMatrix = new GeneralMatrix(coefInput, 3, 1);

            GeneralMatrix R2 = this.R1.Transpose();
            GeneralMatrix R3 = R2.Multiply(inputMatrix);
            R3.AddEquals(this.T1);

            CoordinatesXYZ res = new CoordinatesXYZ(R3.GetElement(0, 0),
                                                    R3.GetElement(1, 0),
                                                    R3.GetElement(2, 0));
            return res;
        }
        /// <summary>
        /// helper function that transforms H into Z
        /// </summary>
        /// <param name="c">x,y,h</param>
        /// <returns>z</returns>
        public double change_system_xyh2system_z(CoordinatesXYH c)
        {
            double z = 0.0;
            if (c == null) return 0.0;

            double xh = c.X / (this.R_S + c.Height);
            double yh = c.Y / (this.R_S + c.Height);
            double temp = xh * xh + yh * yh;
            if (temp > 1)
            {
                z = -(this.R_S + this.centerProjection.Height);
            }
            else
            {
                z = (this.R_S + c.Height) * Math.Sqrt(1.0 - temp) -
                    (this.R_S + this.centerProjection.Height);
            }
            return z;
        }
        /// <summary>
        /// changes coordinates from cartesian to stereographic(x,y,z projected to u,v,h)
        /// </summary>
        /// <param name="c">x,y,z projected coordinates</param>
        /// <returns>u,v,h stereographic projection</returns>
        public CoordinatesUVH change_system_cartesian2stereographic(CoordinatesXYZ c)
        {
            if (c == null) return (CoordinatesUVH)null;
            // don't know why we have to do this ¿?
            // double z = this.change_system_xyh2system_z(c);

            CoordinatesUVH res = new CoordinatesUVH();
            double d_xy2 = c.X * c.X + c.Y * c.Y;
            res.Height = Math.Sqrt(d_xy2 +
                (c.Z + this.centerProjection.Height + this.R_S) *
                (c.Z + this.centerProjection.Height + this.R_S)) - this.R_S;
            double k = (2 * this.R_S) /
                (2 * this.R_S + this.centerProjection.Height + c.Z + res.Height);
            res.U = k * c.X;
            res.V = k * c.Y;
            return res;
        }
        /// <summary>
        /// changes coordinates from stereographic to cartesian(u,v,h to x,y,z projected)
        /// </summary>
        /// <param name="c">u,v,h stereographic projection</param>
        /// <returns>x,y,z projected coordinates</returns>
        public CoordinatesXYZ change_stereographic2system_cartesian(CoordinatesUVH c)
        {

            if (c == null) return (CoordinatesXYZ)null;

            CoordinatesXYZ res = new CoordinatesXYZ();
            double d_uv2 = c.U * c.U + c.V * c.V;
            res.Z = (c.Height + this.R_S) * ((4 * this.R_S * this.R_S - d_uv2) /
                (4 * this.R_S * this.R_S + d_uv2)) -
                (this.R_S + this.centerProjection.Height);
            double k = (2 * this.R_S) / (2 * this.R_S + this.centerProjection.Height + res.Z + c.Height);
            res.X = c.U / k;
            res.Y = c.V / k;
            // we should not use Z because z=0 by the equations, but we need it 
            // if we're going back and fore
            // res.Z = 0;
            return res;
        }
        /// <summary>
        /// calculates elevation angle in radians
        /// </summary>
        /// <param name="centerCoordinates">center of calculations (only height in meters)</param>
        /// <param name="R">best earth radius for the centerCoordinates</param>
        /// <param name="rho">distance from center to target in meters</param>
        /// <param name="h">height of the target in meters</param>
        /// <returns>elevation angle in radians</returns>
        static public double CalculateElevation(CoordinatesWGS84 centerCoordinates, double R, double rho, double h)
        {
            if ((rho < GeoUtils.ALMOST_ZERO) || (R == -1.0) || (centerCoordinates == null))
            {
                // when rho < 0 and rho = 0 a division by zero could happen
                return 0;
            }
            else
            {
                double temp = (2 * R *
                    (h - centerCoordinates.Height) + h * h -
                    centerCoordinates.Height * centerCoordinates.Height - rho * rho) /
                    (2 * rho * (R + centerCoordinates.Height));
                if ((temp > -1.0) && (temp < 1.0))
                {
                    return Math.Asin(temp);
                }
                else
                {
                    return (Math.PI / 2.0);
                }
            }
        }
        /// <summary>
        /// calculates azimuth between two vectors in radians
        /// </summary>
        /// <param name="x">cartesian x</param>
        /// <param name="y">cartesian y</param>
        /// <returns>azimuth in radians</returns>
        static public double CalculateAzimuth(double x, double y)
        {
            double theta;
            if (Math.Abs(y) < GeoUtils.ALMOST_ZERO)
            {
                theta = (x / Math.Abs(x)) * Math.PI / 2.0;
            }
            else
            {
                theta = Math.Atan2(x, y);
            }

            if (theta < 0.0)
            {
                theta += 2 * Math.PI;
            }
            return theta;
        }
        /// <summary>
        /// Calculate best earth radius (radius of curvature in meridian)
        /// for the given geodesic coordinates (lat, lon) in radians
        /// </summary>
        /// <param name="geo">lat,lon</param>
        /// <returns>earth radius</returns>
        public double CalculateEarthRadius(CoordinatesWGS84 geo)
        {
            Double ret = Double.NaN;
            if (geo != null)
            {
                // Explanation about different radius calculations
                // http://www.gmat.unsw.edu.au/snap/gps/clynch_pdfs/radiigeo.pdf

                // Radius of curvature in Meridian
                // Matlib ARTAS &&
                // http://williams.best.vwh.net/avform.htm (local, flat earth approximation)
                // R1=a(1-e^2)/(1-e^2*(sin(lat0))^2)^(3/2)
                ret = (this.A * (1.0 - this.E2)) /
                    Math.Pow(1 - this.E2 * Math.Pow(Math.Sin(geo.Lat), 2.0), 1.5);

                // Radius of curvature in Prime Vertical
                // Double ret0 = this.A / (Math.Pow(1 - this.E2 * Math.Pow(Math.Sin(geo.Lat), 2), 0.5));

                // Matlib Transform (transform.c) from NLR 2.33
                // Double ret1 = this.A * (1.0 - (1.0/2.0) * this.E2 * Math.Cos(2.0*geo.Lat));

                // WIKIPEDIA     
                // http://gis.stackexchange.com/questions/20200/how-do-you-compute-the-earths-radius-at-a-given-geodetic-latitude
                //
                // R(f)^2 = ( (a^2 cos(f))^2 + (b^2 sin(f))^2 ) / ( (a cos(f))^2 + (b sin(f))^2 )
                // Double ret2 = Math.Pow(
                //    (Math.Pow(this.A * this.A * Math.Cos(geo.Lat), 2) +
                //    Math.Pow(this.B * this.B * Math.Sin(geo.Lat), 2)) /
                //    (Math.Pow(this.A * Math.Cos(geo.Lat), 2) +
                //    Math.Pow(this.B * Math.Sin(geo.Lat), 2))
                //    , 0.5);
            }

            return ret;

        }

        static public GeneralMatrix CalculateRotationMatrix(double lat, double lon)
        {
            double[][] coefR1 = { new double[3], new double[3], new double[3] };

            coefR1[0][0] = -(Math.Sin(lon));
            coefR1[0][1] = Math.Cos(lon);
            coefR1[0][2] = 0;
            coefR1[1][0] = -(Math.Sin(lat) * Math.Cos(lon));
            coefR1[1][1] = -(Math.Sin(lat) * Math.Sin(lon));
            coefR1[1][2] = Math.Cos(lat);
            coefR1[2][0] = Math.Cos(lat) * Math.Cos(lon);
            coefR1[2][1] = Math.Cos(lat) * Math.Sin(lon);
            coefR1[2][2] = Math.Sin(lat);
            GeneralMatrix m = new GeneralMatrix(coefR1, 3, 3);
            return m;
        }
        /// <summary>
        /// calculates the translation matrix needed in several members of the GeoUtils class
        /// </summary>
        /// <param name="c">radarPosition coordiantes lat lon(rads), height(meters)</param>
        /// <param name="A">semi-major axis of earth ellipsoid (in metres)</param>
        /// <param name="E2">eccentricity of the ellipsoid squared</param>
        /// <returns>position GeneralMatrix</returns>
        static public GeneralMatrix CalculateTranslationMatrix(CoordinatesWGS84 c, double A, double E2)
        {
            double nu = A / Math.Sqrt(1 - E2 * Math.Pow(Math.Sin(c.Lat), 2.0));
            double[][] coefT1 = { new double[1], new double[1], new double[1] };
            coefT1[0][0] = (nu + c.Height) * Math.Cos(c.Lat) * Math.Cos(c.Lon);
            coefT1[1][0] = (nu + c.Height) * Math.Cos(c.Lat) * Math.Sin(c.Lon);
            coefT1[2][0] = (nu * (1 - E2) + c.Height) * Math.Sin(c.Lat);
            GeneralMatrix m = new GeneralMatrix(coefT1, 3, 1);
            return m;
        }
        /// <summary>
        /// calculates the position matrix needed in several members of the GeoUtils class
        /// </summary>
        /// <param name="T1">translation matrix to the system center</param>
        /// <param name="t">translation matrix to the radar</param>
        /// <param name="r">rotation matrix to the radar</param>
        /// <returns>position GeneralMatrix</returns>
        static public GeneralMatrix CalculatePositionRadarMatrix(GeneralMatrix T1, GeneralMatrix t, GeneralMatrix r)
        {

            GeneralMatrix R1 = T1.Subtract(t);
            GeneralMatrix res = r.Multiply(R1);

            return res;
        }
        /// <summary>
        /// calculates the rotation matrix needed in several members of the GeoUtils class
        /// </summary>
        /// <param name="R1">rotation matrix to the system center</param>
        /// <param name="r">rotation matrix to the radar</param>
        /// <returns>position GeneralMatrix</returns>
        static public GeneralMatrix CalculateRotationRadarMatrix(GeneralMatrix R1, GeneralMatrix r)
        {

            GeneralMatrix R2 = R1.Transpose();
            GeneralMatrix res = r.Multiply(R2);
            return res;
        }
        /// <summary>
        /// changes coordinates from radar spherical (rho, theta, elevation) to radar local cartesian (x,y,z) SR7
        /// </summary>
        /// <param name="polarCoordinates">rho(m), theta(radians), elevation(radians)</param>
        /// <returns>x,y,z in meters</returns>
        static public CoordinatesXYZ change_radar_spherical2radar_cartesian(CoordinatesPolar polarCoordinates)
        {
            if (polarCoordinates == null) return (CoordinatesXYZ)null;

            CoordinatesXYZ res = new CoordinatesXYZ();

            res.X = polarCoordinates.Rho * Math.Cos(polarCoordinates.Elevation) *
                Math.Sin(polarCoordinates.Theta);
            res.Y = polarCoordinates.Rho * Math.Cos(polarCoordinates.Elevation) *
                Math.Cos(polarCoordinates.Theta);
            res.Z = polarCoordinates.Rho * Math.Sin(polarCoordinates.Elevation);

            return res;
        }
        /// <summary>
        /// changes coordinates from radar local cartesian (x,y,z) to radar spherical (rho, theta, elevation)
        /// </summary>
        /// <param name="cartesianCoordinates">x,y,z (meters)</param>
        /// <returns>rho(meters), theta (radians), elevation (radians)</returns>
        static public CoordinatesPolar change_radar_cartesian2radar_spherical(CoordinatesXYZ cartesianCoordinates)
        {
            if (cartesianCoordinates == null) return (CoordinatesPolar)null;

            CoordinatesPolar res = new CoordinatesPolar();

            res.Rho = Math.Sqrt(cartesianCoordinates.X * cartesianCoordinates.X +
                cartesianCoordinates.Y * cartesianCoordinates.Y +
                cartesianCoordinates.Z * cartesianCoordinates.Z);
            res.Theta = GeoUtils.CalculateAzimuth(cartesianCoordinates.X, cartesianCoordinates.Y);
            res.Elevation = Math.Asin(cartesianCoordinates.Z / res.Rho);
            return res;
        }
        /// <summary>
        /// changes coordinates from radar local cartesian (x,y,z meters) to geocentric coordinates (x,y,z meters) SR10
        /// </summary>
        /// <param name="radarCoordinates">radar coordinates in lat lon (rads)</param>
        /// <param name="cartesianCoordinates">object with cartesian coordinates (x,y,z meters)</param>
        /// <returns>geocentric coordinates (x,y,z meters)</returns>
        public CoordinatesXYZ change_radar_cartesian2geocentric(CoordinatesWGS84 radarCoordinates, CoordinatesXYZ cartesianCoordinates)
        {
            //at_radar_local_to_geocentric
            GeneralMatrix translationMatrix = ObtainTranslationMatrix(radarCoordinates);
            GeneralMatrix rotationMatrix = ObtainRotationMatrix(radarCoordinates);

            double[][] coefInput = { new double[1], new double[1], new double[1] };
            coefInput[0][0] = cartesianCoordinates.X;
            coefInput[1][0] = cartesianCoordinates.Y;
            coefInput[2][0] = cartesianCoordinates.Z;
            GeneralMatrix inputMatrix = new GeneralMatrix(coefInput, 3, 1);

            GeneralMatrix R1 = rotationMatrix.Transpose();
            GeneralMatrix R2 = R1.Multiply(inputMatrix);
            R2.AddEquals(translationMatrix);

            CoordinatesXYZ res = new CoordinatesXYZ(R2.GetElement(0, 0),
                                    R2.GetElement(1, 0),
                                    R2.GetElement(2, 0));
            return res;

        }
        /// <summary>
        /// changes coordinates from geocentric (x,y,z meters) to radar local cartesian (x,y,z meters)
        /// </summary>
        /// <param name="radarCoordinates">radar coordinates in lat lon (rads)</param>
        /// <param name="geocentricCoordinates">object with geocentric coordinates (x,y,z meters)</param>
        /// <returns>radar local cartesian coords (x,y,z meters)centered on radar</returns>
        public CoordinatesXYZ change_geocentric2radar_cartesian(CoordinatesWGS84 radarCoordinates, CoordinatesXYZ geocentricCoordinates)
        {
            //at_radar_local_to_geocentric
            GeneralMatrix translationMatrix = ObtainTranslationMatrix(radarCoordinates);
            GeneralMatrix rotationMatrix = ObtainRotationMatrix(radarCoordinates);

            double[][] coefInput = { new double[1], new double[1], new double[1] };
            coefInput[0][0] = geocentricCoordinates.X;
            coefInput[1][0] = geocentricCoordinates.Y;
            coefInput[2][0] = geocentricCoordinates.Z;
            GeneralMatrix inputMatrix = new GeneralMatrix(coefInput, 3, 1);

            inputMatrix.SubtractEquals(translationMatrix);
            GeneralMatrix R1 = rotationMatrix.Multiply(inputMatrix);

            CoordinatesXYZ res = new CoordinatesXYZ(R1.GetElement(0, 0),
                                    R1.GetElement(1, 0),
                                    R1.GetElement(2, 0));
            return res;

        }
        /// <summary>
        /// changes coordinates from radar cartesian local (x,y,z) to system cartesian projected (x,y,z)
        /// </summary>
        /// <param name="radarCoordinates">radar coordiantes in lat, lon (rads)</param>
        /// <param name="cartesianCoordinates">object with cartesian coordinates in x,y,z (meters)</param>
        /// <returns>cartesian projected coordinates (x,y,z projected meters)</returns>
        public CoordinatesXYZ change_radar_cartesian2system_cartesian(CoordinatesWGS84 radarCoordinates, CoordinatesXYZ cartesianCoordinates)
        {
            //at_radar_local_to_system
            GeneralMatrix positionRadarMatrix = ObtainPositionRadarMatrix(radarCoordinates);
            GeneralMatrix rotationRadarMatrix = ObtainRotationRadarMatrix(radarCoordinates);

            double[][] coefInput = { new double[1], new double[1], new double[1] };
            coefInput[0][0] = cartesianCoordinates.X;
            coefInput[1][0] = cartesianCoordinates.Y;
            coefInput[2][0] = cartesianCoordinates.Z;
            GeneralMatrix inputMatrix = new GeneralMatrix(coefInput, 3, 1);

            inputMatrix.SubtractEquals(positionRadarMatrix);
            GeneralMatrix R1 = rotationRadarMatrix.Multiply(inputMatrix);

            CoordinatesXYZ res = new CoordinatesXYZ(R1.GetElement(0, 0),
                                                    R1.GetElement(1, 0),
                                                    R1.GetElement(2, 0));
            return res;
        }
        /// <summary>
        /// changes coordinates from system cartesian projected (x,y,z) to radar cartesian local (x,y,z)
        /// </summary>
        /// <param name="radarCoordinates">radar coordiantes in lat,lon (rads)</param>
        /// <param name="cartesianCoordinates">object with system cartesian projected (x,y,z projected meters)</param>
        /// <returns>radar cartesian coordinates (x,y,z meters)</returns>
        public CoordinatesXYZ change_system_cartesian2radar_cartesian(CoordinatesWGS84 radarCoordinates, CoordinatesXYZ cartesianCoordinates)
        {
            //at_system_to_radar_local
            GeneralMatrix positionRadarMatrix = ObtainPositionRadarMatrix(radarCoordinates);
            GeneralMatrix rotationRadarMatrix = ObtainRotationRadarMatrix(radarCoordinates);

            double[][] coefInput = { new double[1], new double[1], new double[1] };
            coefInput[0][0] = cartesianCoordinates.X;
            coefInput[1][0] = cartesianCoordinates.Y;
            coefInput[2][0] = cartesianCoordinates.Z;
            GeneralMatrix inputMatrix = new GeneralMatrix(coefInput, 3, 1);

            GeneralMatrix R1 = rotationRadarMatrix.Multiply(inputMatrix);
            R1.AddEquals(positionRadarMatrix);

            CoordinatesXYZ res = new CoordinatesXYZ(R1.GetElement(0, 0),
                                                    R1.GetElement(1, 0),
                                                    R1.GetElement(2, 0));
            return res;
        }
        /// <summary>
        /// builds or looksup a matrix for the transformation equations from the hashtable
        /// </summary>
        /// <returns>translation matrix</returns>
        private GeneralMatrix ObtainRotationMatrix(CoordinatesWGS84 radarCoordinates)
        {
            GeneralMatrix rotationMatrix = null;
            if (this.rotationMatrixHT == null)
                this.rotationMatrixHT = new Dictionary<CoordinatesWGS84, GeneralMatrix>(16);
            if (this.rotationMatrixHT.ContainsKey(radarCoordinates))
            {
                rotationMatrix = this.rotationMatrixHT[radarCoordinates];
            }
            else
            {
                rotationMatrix = GeoUtils.CalculateRotationMatrix(radarCoordinates.Lat, radarCoordinates.Lon);
                this.rotationMatrixHT.Add(radarCoordinates, rotationMatrix);
            }
            return rotationMatrix;
        }
        /// <summary>
        /// builds or looksup a matrix for the transformation equations from the hashtable
        /// </summary>
        /// <returns>translation matrix</returns>
        private GeneralMatrix ObtainTranslationMatrix(CoordinatesWGS84 radarCoordinates)
        {
            GeneralMatrix translationMatrix = null;
            if (this.translationMatrixHT == null)
                this.translationMatrixHT = new Dictionary<CoordinatesWGS84, GeneralMatrix>(16);
            if (this.translationMatrixHT.ContainsKey(radarCoordinates))
            {
                translationMatrix = this.translationMatrixHT[radarCoordinates];
            }
            else
            {
                translationMatrix = CalculateTranslationMatrix(radarCoordinates, this.A, this.E2);
                this.translationMatrixHT.Add(radarCoordinates, translationMatrix);
            }
            return translationMatrix;
        }
        /// <summary>
        /// builds or looksup a matrix for the transformation equations from the hashtable
        /// </summary>
        /// <returns>position matrix for the radar in system coordinates</returns>
        private GeneralMatrix ObtainPositionRadarMatrix(CoordinatesWGS84 radarCoordinates)
        {
            GeneralMatrix p = null;
            lock (PositionRadarMatrixLock)
            {
                if (this.positionRadarMatrixHT == null)
                    this.positionRadarMatrixHT = new Dictionary<CoordinatesWGS84, GeneralMatrix>(16);
                if (this.positionRadarMatrixHT.ContainsKey(radarCoordinates))
                {
                    p = this.positionRadarMatrixHT[radarCoordinates];
                }
                else
                {
                    p = GeoUtils.CalculatePositionRadarMatrix(this.T1,
                        ObtainTranslationMatrix(radarCoordinates),
                        ObtainRotationMatrix(radarCoordinates));
                    this.positionRadarMatrixHT.Add(radarCoordinates, p);
                }
            }
            return p;
        }
        /// <summary>
        /// builds or looksup a matrix for the rotation equations from the hashtable
        /// </summary>
        /// <returns>position matrix for the radar in system coordinates</returns>
        private GeneralMatrix ObtainRotationRadarMatrix(CoordinatesWGS84 radarCoordinates)
        {
            GeneralMatrix p = null;
            lock (RotationRadarMatrixLock)
            {
                if (this.rotationRadarMatrixHT == null)
                    this.rotationRadarMatrixHT = new Dictionary<CoordinatesWGS84, GeneralMatrix>(16);
                if (this.rotationRadarMatrixHT.ContainsKey(radarCoordinates))
                {
                    p = this.rotationRadarMatrixHT[radarCoordinates];
                }
                else
                {
                    p = GeoUtils.CalculateRotationRadarMatrix(this.R1,
                        ObtainRotationMatrix(radarCoordinates));
                    this.rotationRadarMatrixHT.Add(radarCoordinates, p);
                }
            }
            return p;
        }
    }
    /// <summary>
    /// Helper class with Coordinates (contains definitions for Rho,Theta, Longitude,Latitude, X, Y)
    /// </summary>
    public class Coordinates
    {
    }
    /// <summary>
    /// Support for polar coordinates (rho, theta and elevation)
    /// </summary>
    public class CoordinatesPolar : Coordinates
    {
        private double rho; private double theta;
        private double elevation;
        /// <summary>
        /// getter and setter
        /// </summary>
        public double Rho { get { return rho; } set { rho = value; } }
        /// <summary>
        /// getter and setter
        /// </summary>
        public double Theta { get { return theta; } set { theta = value; } }
        /// <summary>
        /// getter and setter
        /// </summary>
        public double Elevation { get { return elevation; } set { elevation = value; } }
        /// <summary>
        /// default constructor
        /// </summary>
        public CoordinatesPolar() { }
        /// <summary>
        /// useful constructor
        /// </summary>
        /// <param name="rho">x in meters</param>
        /// <param name="theta">theta in radians</param>
        /// <param name="elevation">elevation in meters</param>
        public CoordinatesPolar(double rho, double theta, double elevation) { this.Rho = rho; this.Theta = theta; this.Elevation = elevation; }
        /// <summary>
        /// Writes a summary of the class to a string
        /// </summary>
        /// <param name="c">class to summarize</param>
        /// <returns>string with latitude and longitude</returns>
        public static string ToString(CoordinatesPolar c)
        {
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            s.AppendFormat(" R: {0:f4}m T: {1:f4}rad E: {2:f4}rad", c.Rho, c.Theta, c.Elevation);
            return s.ToString();
        }
        /// <summary>
        /// Writes a summary of the class to a string, using NM in rho and degrees as theta
        /// </summary>
        /// <param name="c">class to summarize</param>
        /// <returns>string with latitude and longitude</returns>
        public static string ToStringStandard(CoordinatesPolar c)
        {
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            s.AppendFormat(" R: {0:f4}NM T: {1:f4}º E: {2:f4}º", c.Rho * GeoUtils.METERS2NM, c.Theta * GeoUtils.RADS2DEGS, c.Elevation * GeoUtils.RADS2DEGS);
            return s.ToString();
        }
    }
    /// <summary>
    /// support for cartesian coordinates (x y z)
    /// </summary>
    public class CoordinatesXYZ : Coordinates
    {
        private double x; private double y;
        private double z;
        /// <summary>
        /// getter and setter
        /// </summary>
        public double X { get { return x; } set { x = value; } }
        /// <summary>
        /// getter and setter
        /// </summary>
        public double Y { get { return y; } set { y = value; } }
        /// <summary>
        /// getter and setter
        /// </summary>
        public double Z { get { return z; } set { z = value; } }
        /// <summary>
        /// default constructor
        /// </summary>
        public CoordinatesXYZ() { }
        /// <summary>
        /// useful constructor
        /// </summary>
        /// <param name="x">x in meters</param>
        /// <param name="y">y in meters</param>
        /// <param name="z">z in meters</param>
        public CoordinatesXYZ(double x, double y, double z) { this.X = x; this.Y = y; this.Z = z; }
        /// <summary>
        /// Writes a summary of the class to a string
        /// </summary>
        /// <param name="c">class to summarize</param>
        /// <returns>string with x,y and z in meters</returns>
        public static string ToString(CoordinatesXYZ c)
        {
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            s.AppendFormat(" X: {0:f4}m Y: {1:f4}m Z: {2:f4}m", c.X, c.Y, c.Z);
            return s.ToString();
        }
        /// <summary>
        /// Writes a summary of the class to a string
        /// </summary>
        /// <param name="c">class to summarize</param>
        /// <returns>string with x, y and z in meters</returns>
        public override string ToString()
        {
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            s.AppendFormat(" X: {0:f4}m Y: {1:f4}m Z: {2:f4}m", this.X, this.Y, this.Z);
            return s.ToString();
        }
    }
    /// <summary>
    /// support for stereographic coordinates (u,v,h)
    /// </summary>
    public class CoordinatesUVH : Coordinates
    {
        private double u; private double v;
        private double h;
        /// <summary>
        /// getter and setter
        /// </summary>
        public double U { get { return u; } set { u = value; } }
        /// <summary>
        /// getter and setter
        /// </summary>
        public double V { get { return v; } set { v = value; } }
        /// <summary>
        /// getter and setter
        /// </summary>
        public double Height { get { return h; } set { h = value; } }
    }
    /// <summary>
    /// support for x y height coordinates
    /// </summary>
    public class CoordinatesXYH : Coordinates
    {
        private double x; private double y;
        private double height;
        /// <summary>
        /// getter and setter
        /// </summary>
        public double X { get { return x; } set { x = value; } }
        /// <summary>
        /// getter and setter
        /// </summary>
        public double Y { get { return y; } set { y = value; } }
        /// <summary>
        /// getter and setter
        /// </summary>
        public double Height { get { return height; } set { height = value; } }
    }
    /// <summary>
    /// support for geodesic coordinates (latitude longitude height)
    /// </summary>
    public class CoordinatesWGS84 : Coordinates
    {
        private double lat; private double lon; private double height;
        /// <summary>
        /// getter and setter
        /// </summary>
        public double Height { get { return height; } set { height = value; } }
        /// <summary>
        /// getter and setter
        /// </summary>
        public double Lat { get { return lat; } set { lat = value; } }
        /// <summary>
        /// getter and setter
        /// </summary>
        public double Lon { get { return lon; } set { lon = value; } }
        /// <summary>
        /// default constructor
        /// </summary>
        public CoordinatesWGS84() { this.lat = 0; this.lon = 0; this.height = 0; }
        /// <summary>
        /// useful constructor
        /// </summary>
        /// <param name="lat">latitude</param>
        /// <param name="lon">longitude</param>
        public CoordinatesWGS84(double lat, double lon) { this.lat = lat; this.lon = lon; this.height = 0; }
        /// <summary>
        /// useful constructor
        /// </summary>
        /// <param name="lat">latitude in degrees</param>
        /// <param name="lon">longitude in degrees</param>
        /// <param name="h">height in meters</param>
        public CoordinatesWGS84(string lat, string lon, double h)
        {
            this.lat = Convert.ToDouble(lat) * GeoUtils.DEGS2RADS;
            this.lon = Convert.ToDouble(lon) * GeoUtils.DEGS2RADS;
            this.height = h;
        }

        /// <summary>
        /// useful constructor
        /// </summary>
        /// <param name="lat">latitude</param>
        /// <param name="lon">longitude</param>
        /// <param name="height">height (meters)</param>
        public CoordinatesWGS84(double lat, double lon, double height) { this.lat = lat; this.lon = lon; this.height = height; }
        /// <summary>
        /// Writes a summary of the class to a string
        /// </summary>
        /// <param name="c">class to summarize</param>
        /// <returns>string with latitude and longitude</returns>
        public override string ToString()
        {
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            double d1, d2, d3; int n;
            GeoUtils.Radians2LatLon(lat, out d1, out d2, out d3, out n);
            //s.AppendFormat("{0:d2}º{1:d2}'{2:f4}" + (n == 0 ? 'N' : 'S') + " ", (int)d1, (int)d2, d3);
            s.AppendFormat("{0:d2}:{1:d2}:{2:f4}" + (n == 0 ? 'N' : 'S') + " ", (int)d1, (int)d2, d3);
            GeoUtils.Radians2LatLon(lon, out d1, out d2, out d3, out n);
            //s.AppendFormat("{0:d2}º{1:d2}'{2:f4}" + (n == 0 ? 'E' : 'W') + " ", (int)d1, (int)d2, d3);
            s.AppendFormat("{0:d3}:{1:d2}:{2:f4}" + (n == 0 ? 'E' : 'W') + " ", (int)d1, (int)d2, d3);
            s.AppendFormat("{0:f4}m", height);
            s.Append(Environment.NewLine);
            s.AppendFormat("lat:{0:f9} lon:{1:f9}", this.Lat * GeoUtils.RADS2DEGS, this.Lon * GeoUtils.RADS2DEGS);
            return s.ToString();
        }
    }
}