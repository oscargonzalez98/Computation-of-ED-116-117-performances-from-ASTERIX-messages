using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text.RegularExpressions;
using MultiCAT6.Utils;
using DotNetMatrix;
using System.Runtime;

namespace LIBRERIACLASES
{
    public class CAT10
    {
        public double LatARP = 41 + (17/60) + (49.426/3600);
        public double LonARP = 002 + (04/60) + (42.410/3600);

        int i = 0;
        public string[] paquete;
        public string[] arrayFSPEC;
        public string FSPEC;
        public string FSPEC_fake;
        public int data_position = 0;

        public string DataSourceIdentifier = "";
        public int SIC;
        public int SAC;

        public string MessageType = "";
        public string MessageType_decodified = "";

        public string TargetReportDescriptor = "";
        public string TYP = "";
        public string DCR = "";
        public string CHN = "";
        public string GBS = "";
        public string CRT = "";
        public string SIM = "";
        public string TST = "";
        public string RAB = "";
        public string LOP = "";
        public string TOT = "";
        public string SPI = "";

        public string TimeofDay = "";
        public double TimeofDay_seconds;

        public string PositioninWGS84_coordinates = "";
        public double latWGS84 = 0;
        public double lonWGS84 = 0;

        public string MeasuredPositioninPolarCoordinates = "";
        public double Theta;
        public double Rho;

        public string PositioninCartesianCoordinates = "";
        public double X_cartesian;
        public double Y_cartesian;

        public string CalculatedTrackVelocityinPolarCoordinates = "";
        public double GroundSpeed;
        public double TrackAngle;

        public CoordinatesWGS84 coordinatesWGS84;
        public CoordinatesUVH coordinatesUVH;

        public string CalculatedTrackVelocityinCartesianCoordinates = "";
        public double Vx_cartesian;
        public double Vy_cartesian;

        public string TrackNumber = "";
        public double Tracknumber_value;

        public string TrackStatus = "";
        public string CNF="";
        public string TRE = "";
        public string CST = "";
        public string MAH = "";
        public string TCC = "";
        public string STH = "";
        public string TOM = "";
        public string DOU = "";
        public string MRS = "";
        public string GHO = "";

        public string Mode3ACodeinOctal = "";
        public string V = "";
        public string G = "";
        public string L = "";
        public string Mode3ACodeinOctal_decodified = "";

        public string TargetAdress = "";
        public string TargetAdress_decoded = "";

        public string TargetIdentification = "";
        public string TargetIdentification_decoded = "";
        public string STI = "";

        public string ModeSMBData = "";
        public string[] REP_MS;
        public string[] MBDATA;
        public string[] BDS1;
        public string[] BDS2;

        public string VehicleFleetIdentification = "";
        public string VFI = "";

        public string FlightLevelInBinaryRepresentation = "";
        public string V_fl = "";
        public string G_fl = "";
        public double FlightLevel;

        public string MeasuredHeight = "";
        public double MeasuredHeight_ft;

        public string TargetSizeOrientation = "";
        public double Length;
        public double Orientation;
        public double Width;

        public string SystemStatus = "";
        public string NOGO = "";
        public string OVL = "";
        public string TSV = "";
        public string DIV = "";
        public string TTF = "";

        public string PreProgrammedMessage = "";
        public string TRB = "";
        public string MSG = "";

        public string StandardDeviationofPosition = "";
        public double StdDeviation_x;
        public double StdDeviation_y;
        public double StdDeviation_xy;

        public string Presence = "";
        public int REP;
        public double[] DRHO;
        public double[] DTHETA;

        public string AmplitudeofPrimaryPlot = "";
        public double AmplitudeofPrimaryPlot_value;

        public string CalculatedAcceleration = "";
        public double CalculatedAcceleration_X;
        public double CalculatedAcceleration_Y;



        public CAT10(string[] packet)
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
        public void Calculate_MessageType(string paquete)
        {
            int int1 = Convert.ToInt32(paquete,2);
            if (int1 == 1) { MessageType_decodified = "Target Report"; }
            if (int1 == 2) { MessageType_decodified = "Start of Update Cycle";}
            if (int1 == 3) { MessageType_decodified = "Periodic Status Message"; }
            if (int1 == 4) { MessageType_decodified = "Event-triggered Status Message"; }
        }
        public void Calculate_TargetReportDescriptor(string paquete) 
        {
            string typ = paquete.Substring(0, 3);

            if (typ=="000") { TYP="SSR multilateration."; }
            if (typ=="001") { TYP = "Mode S multilateration."; }
            if (typ=="010") { TYP = "ADS-B."; }
            if (typ=="011") { TYP = "PSR."; }
            if (typ=="100") { TYP = "Magnetic Loop System."; }
            if (typ=="101") { TYP = "HF multilateration."; }
            if (typ=="110") { TYP = "Not defined."; }
            if (typ=="111") { TYP = "Other types."; }

            string dcr1 = paquete.Substring(3,1);
            if (dcr1 == "0") { DCR = "No differential correction (ADS-B)."; }
            else { DCR = "Differential correction (ADS-B)."; }

            string chn1 = paquete.Substring(4,1);
            if (chn1 == "0") { CHN = "Chain 1."; }
            else { CHN = "Chain 2."; }

            string gbs1 = paquete.Substring(5,1);
            if (gbs1 == "0") { GBS = "Transponder Ground bit not set."; }
            else { GBS = "Transponder Ground bit set."; }

            string crt1 = paquete.Substring(6,1);
            if (crt1 == "0") { CRT = "No Corrupted reply in multilateration."; }
            else { CRT = "Corrupted reply in multilateration."; }


            if (paquete.Length > 8)
            {
                string sim1 = paquete.Substring(8, 1);
                if (sim1 == "0") { SIM = "Actual target report."; }
                else { SIM = "Simulated target report."; }

                string tst1 = paquete.Substring(9, 1);
                if (tst1 =="0") { TST = "Default."; }
                else { TST = "Test target."; }

                string rab1 = paquete.Substring(10, 1);
                if (rab1 == "0") { RAB = "Report from target transponder."; }
                else { RAB = "Report from field monitor (fixed transponder)."; }

                string lop = paquete.Substring(11, 2);
                if(lop=="00") { LOP = "Undeterminated."; }
                if (lop=="01") { LOP = "Loop start."; }
                else { LOP = "Loop finish."; }

                string tot = paquete.Substring(13, 2);
                if(tot == "00") { TOT = "Undetermined."; }
                if(tot=="01") { TOT = "Aircraft."; }
                if (tot == "10") 
                {
                    TOT = "Ground Vehicle."; 
                }
                if(tot == "11") { TOT = "Helicopter."; }

                if (paquete.Length > 16)
                {
                    string spi1 = paquete.Substring(16, 1); ;
                    if (spi1 == "0") { SPI = "Absence of SPI"; }
                    else { SPI = "Special Position Identification."; }
                }
            }
        }
        public void Calculate_PositionWGS84_coordinates(string paquete)
        {
            string str1 = paquete.Substring(0, 32);
            string str2 = paquete.Substring(32, 32);

            double a1 = Calculate_ComplementoA2(str1);
            double b1 = Calculate_ComplementoA2(str2);

            latWGS84 = a1 * (180 / Math.Pow(2, 31));
            lonWGS84 = b1 * (180 / Math.Pow(2, 31));
        }
        public void Calculate_TrackStatus(string paquete)
        {
            string cnf = Convert.ToString(paquete[0]);
            if (cnf == "0") { CNF = "Confirmed track."; }
            else { CNF = "Track initialisation phase."; }

            string tre = Convert.ToString(paquete[1]);
            if (tre == "0") { TRE = "Default."; }
            else { TRE = "Last report for a track."; }

            string cst = paquete.Substring(2, 2);

            if(cst== "00") { CST = "No extrapolation."; }
            if(cst== "01") { CST = "Predictable extrapolation due to sensor refresh period."; }
            if(cst== "10") { CST = " Predictable extrapolation in masked area."; }
            if(cst== "11") { CST = "Extrapolation due to unpredictable absence of detection."; }

            string mah = Convert.ToString(paquete[4]);
            if (mah == "0") { MAH = "Default."; }
            else { MAH = "Horizontal manoeuvre."; }

            string tcc = Convert.ToString(paquete[5]);
            if (tcc == "0") { TCC = "Tracking performed in 'Sensor Plane', i.e. neither slant range correction nor projection was applied."; }
            else { TCC = "Slant range correction and a suitable projection technique are used to track in a 2D.reference plane, tangential to the earth model at the Sensor Site co-ordinates."; }

            string sth = Convert.ToString(paquete[6]);
            if (sth == "0") { STH = "Measured position."; }
            else { STH = "Smoothed position."; }

            if (paquete.Length>8)
            {
                string tom = paquete.Substring(8, 2);
                if(tom == "00") { TOM = "Unknown type of movement."; }
                if(tom == "01") { TOM = "Taking-off."; }
                if(tom == "10") { TOM = "Landing."; }
                if(tom == "11") { TOM = "Other types of movement."; }

                string dou = paquete.Substring(10, 3);

                if(dou == "000") { DOU = "No doubt."; }
                if(dou == "001") { DOU = " Doubtful correlation (undetermined reason)."; }
                if(dou == "010") { DOU = " Doubtful correlation in clutter."; }
                if(dou == "011") { DOU = " Loss of accuracy."; }
                if(dou == "100") { DOU = " Loss of accuracy in clutter."; }
                if(dou == "101") { DOU = "Unstable track."; }
                if(dou == "110") { DOU = "Previously coasted."; }

                string mrs = paquete.Substring(13, 2);

                if(mrs == "00") { MRS = "Merge or split indication undetermined."; }
                if(mrs == "01") { MRS = "Track merged by association to plot."; }
                if(mrs == "10") { MRS = "Track merged by non-association to ."; }
                if(mrs == "11") { MRS = "Split track."; }

                if (paquete.Length > 16)
                {
                    string gho = Convert.ToString(paquete[16]);
                    if (gho == "0") { GHO = "default."; }
                    else { GHO = "Ghost track."; }
                }


            }

        }
        public void Calculate_Mode3ACode_octal(string paquete)
        {
            string v1 = paquete.Substring(0,1);
            if (v1 == "0") { V = "Code validated."; }
            if (v1 == "1"){ V = "Code not validated."; }

            string g1 = paquete.Substring(1,1);
            if (g1 == "0") { G = "Default."; }
            if (g1 == "1") { G = "Garbled code."; }

            string l1 = paquete.Substring(2,1);
            if (l1 == "0") { L = "Mode-3/A code derived from the reply of the transponder."; }
            if (l1 == "1") { L = "Mode-3/A code not extracted during the last scan."; }

            string str1 = paquete.Substring(4, 12);
            Mode3ACodeinOctal_decodified = Convert.ToString(Convert.ToInt32(str1, 2), 8);
            while (Mode3ACodeinOctal_decodified.Length < 4)
            {
                Mode3ACodeinOctal_decodified = String.Concat("0", Mode3ACodeinOctal_decodified); 
            }
        }
        public void Calculate_TargetIdentification(string paquete)
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

    public void Calculate_VehicleFleetIdentification(string paquete)
        {
            int vfi1 = Convert.ToInt32(paquete, 2);
            if (vfi1 == 0) { VFI = "Unknown."; }
            if (vfi1 == 1) { VFI = "ATC equipment maintenance."; }
            if (vfi1 == 2) { VFI = "Airport maintenance."; }
            if (vfi1 == 3) { VFI = "Fire."; }
            if (vfi1 == 4) { VFI = "Bird scarer."; }
            if (vfi1 == 5) { VFI = "Snow plough."; }
            if (vfi1 == 6) { VFI = "Runway sweeper."; }
            if (vfi1 == 7) { VFI = "Emergency."; }
            if (vfi1 == 8) { VFI = "Police."; }
            if (vfi1 == 9) { VFI = "Bus."; }
            if (vfi1 == 10) { VFI = "Tug(push/tow)."; }
            if (vfi1 == 11) { VFI = "Grass cuttert."; }
            if (vfi1 == 12) { VFI = "Fuel."; }
            if (vfi1 == 13) { VFI = "Baggage."; }
            if (vfi1 == 14) { VFI = "Catering."; }
            if (vfi1 == 15) { VFI = "Aircraft maintenance."; }
            if (vfi1 == 16) { VFI = "Flyco(follow me)."; }
        }
        public void Calculate_TargetSizeOrientation(string paquete)
        {
            string length = paquete.Substring(0, 7);
            Length = Convert.ToInt32(length,2);

            if(paquete.Length>8)
            {
                string orientation = paquete.Substring(8, 7);
                Orientation = Convert.ToInt32(orientation,2) * 360 / 128;

                if(paquete.Length>16)
                {
                    string width = paquete.Substring(16, 7);
                    Width = Convert.ToInt32(width, 2);
                }
            }
        }
        public void Calculate_SystemStatus(string paquete)
        {
            string nogo = paquete.Substring(0, 2);
            if (nogo == "00") { NOGO = "Operational."; }
            if (nogo == "01") { NOGO = "Degraded."; }
            if (nogo == "10") { NOGO = "NOGO"; }

            string ovl = paquete.Substring(2, 1);
            if (ovl == "0") { OVL = "No overload."; }
            else { OVL = "Overload."; }

            string tsv = paquete.Substring(3, 1);
            if (tsv == "0") { TSV = "Valid."; }
            else { TSV = "Invalid."; }

            string div = paquete.Substring(4, 1);
            if (div == "0") { DIV = "Normal operation."; }
            else { DIV = "Diversity degraded."; }

            string ttf = paquete.Substring(5, 0);
            if (ttf == "0") { TTF = "Test Target Operative."; }
            else { TTF = "Test Target Failure."; }
        }

        public int ComputePresence(string[] paquete, int pos) // Data Item I010/280
        {
            //contador
            int cont = 1;

            //el primer octet és el número de diferències
            int REP = int.Parse(paquete[pos], System.Globalization.NumberStyles.HexNumber);

            //creamos los vectores
            this.DRHO = new double[REP];
            this.DTHETA = new double[REP];

            //agafem les dades
            int i = 0;
            while (i < REP)
            {
                //agafem els octets en string de bits:
                string octetRHO = Convert.ToString(Convert.ToInt32(paquete[pos + cont], 16), 2).PadLeft(8, '0');
                string octetoDTHETA = Convert.ToString(Convert.ToInt32(paquete[pos + cont + 1], 16), 2).PadLeft(8, '0');

                //agafem el num fent el complement a2:
                double rho = this.Calculate_ComplementoA2(octetRHO);
                double dtheta = this.Calculate_ComplementoA2(octetoDTHETA);

                //multipliquem per la resolució
                this.DRHO[i] = rho * 1;
                this.DTHETA[i] = dtheta * 0.15;

                this.Presence = this.DRHO[i] + " m, " + this.DTHETA[i] + "º \n";

                cont = cont + 2;

                i++;
            }

            return cont;
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

            while (FSPEC_fake.Length < (4 * 8))
            {
                FSPEC_fake = String.Concat(FSPEC_fake, "0");
            }

            data_position = 1 + 2 + ((FSPEC.Length) / 8);

            //-------------------------------------------------------------------------------------------------------------
            // Aqui porocesamos los parametros que hemos encontrado en el FSPEC
            //-------------------------------------------------------------------------------------------------------------

            if(FSPEC.Length>0)
            {
                if (Char.ToString(FSPEC_fake[0]) == "1") // 1 I021/010 Data Source Identification
                {

                    string string1 = Convert.ToString(paquete[data_position]);
                    string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                    string1 = AddZeros(string1);

                    string string2 = Convert.ToString(paquete[data_position + 1]);
                    string2 = Convert.ToString(Convert.ToInt32(string2, 16), 2);
                    string2 = AddZeros(string2);

                    DataSourceIdentifier = String.Concat(string1, string2);

                    data_position = data_position + 2;

                    Calculate_DataSourceIdentification(DataSourceIdentifier);

                } // 1 I021/010 Data Source Identification

                if (Char.ToString(FSPEC_fake[1]) == "1") // 2 I010/000 Message Type 
                {

                    string string1 = Convert.ToString(paquete[data_position]);
                    string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                    string1 = AddZeros(string1);

                    MessageType = string1;

                    data_position = data_position + 1;

                    Calculate_MessageType(MessageType);

                }// 2 I010/000 Message Type 

                if (Char.ToString(FSPEC_fake[2]) == "1") // 3 I010/020 Target Report Descriptor  
                {
                    // primero leemos el primer paquete y lo pasamos a binario

                    string string_packet = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                    string_packet = AddZeros(string_packet);

                    if ((Convert.ToString(string_packet[7])) == "0") // si ultima posicion es un 0 guardamos el octeto y pasamos al siguiente
                    {
                        TargetReportDescriptor = string_packet;
                        data_position = data_position + 1;
                    }
                    if ((Convert.ToString(string_packet[7])) == "1" && string_packet.Length < 24) // si ultimo valor =1 hacemos un bucle que vaya concatenando todos los octetos acabados en 1
                    {
                        i = 0;
                        data_position = data_position + 1;
                        while ((Convert.ToString(string_packet[string_packet.Length - 1])) == "1")
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

                } // 3 I010/020 Target Report Descriptor  

                if (Char.ToString(FSPEC_fake[3]) == "1") // 4 I010 / 140 Time of Day
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

                    data_position = data_position + 3;

                    TimeofDay = String.Concat(string1, string2, string3);

                    TimeofDay_seconds = Convert.ToInt32(TimeofDay, 2);
                    TimeofDay_seconds = TimeofDay_seconds/128;

                    int a = 1;

                }// 4 I010 / 140 Time of Day

                if (Char.ToString(FSPEC_fake[4]) == "1") // 5 I010 / 041  Position in WGS-84 Co-ordinates 
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

                    PositioninWGS84_coordinates = String.Concat(string1, string2, string3, string4, string5, string6, string7, string8);

                    data_position = data_position + 8;

                    Calculate_PositionWGS84_coordinates(PositioninWGS84_coordinates);

                } // 5 I010 / 041  Position in WGS-84 Co-ordinates 

                if (Char.ToString(FSPEC_fake[5]) == "1") // 6 I010/040  Measured Position in Polar Co-ordinates 
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

                    data_position = data_position + 4;

                    MeasuredPositioninPolarCoordinates = String.Concat(string1, string2, string3, string4);

                    string rho1 = (MeasuredPositioninPolarCoordinates.Substring(0, 16));
                    string theta1 = (MeasuredPositioninPolarCoordinates.Substring(16, 16));

                    Rho = Convert.ToInt32(rho1, 2);
                    Theta = Convert.ToInt32(theta1, 2) * 360 / (Math.Pow(2, 16));

                    //// Calculamos Coordenadas Esterograficas
                    //CoordinatesPolar coordRadarSpherical = new CoordinatesPolar(Rho, Theta, 0);
                    //CoordinatesXYZ coordRadarCartesian = change_radar_spherical2radar_cartesian(coordRadarSpherical);
                    //CoordinatesXYZ coordSystemCartesian = change_radar_cartesian2system_cartesian(new CoordinatesWGS84(LatARP, LonARP), coordRadarCartesian);
                    //CoordinatesUVH coordinatesUVH = change_system_cartesian2stereographic(coordSystemCartesian);

                    //// Calculamos Coordenadas WGS84
                    //CoordinatesXYZ coordGeocentric = change_radar_cartesian2geocentric(new CoordinatesWGS84(LatARP, LonARP), coordRadarCartesian);
                    //coordinatesWGS84 = change_geocentric2geodesic(coordGeocentric);

                    // Calculamos WGS84
                    double[] coordWGS84 = MLATPolarCoordinates2WGS84(Rho, Theta);
                    coordinatesWGS84 = new CoordinatesWGS84(coordWGS84[0], coordWGS84[1]);

                    // Calculamos Estereograficas
                    CoordinatesXYZ coordGeocentric = change_geodesic2geocentric(coordinatesWGS84);
                    CoordinatesXYZ coordSystemCartesian = change_geocentric2system_cartesian(coordGeocentric);
                    coordinatesUVH = change_system_cartesian2stereographic(coordSystemCartesian);

                }// 6 I010/040  Measured Position in Polar Co-ordinates 

                if (Char.ToString(FSPEC_fake[6]) == "1") // 7 I010/042  Position in Cartesian Co-ordinates
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

                    PositioninCartesianCoordinates = String.Concat(string1, string2, string3, string4);

                    data_position = data_position + 4;

                    string xcartesian = (PositioninCartesianCoordinates.Substring(0, 16));
                    string ycartesian = (PositioninCartesianCoordinates.Substring(16, 16));

                    X_cartesian = Calculate_ComplementoA2(xcartesian);
                    Y_cartesian = Calculate_ComplementoA2(ycartesian);

                    //// Calculamos Coordenadas Esterograficas
                    //CoordinatesXYZ coordRadarCartesian = new CoordinatesXYZ(X_cartesian, Y_cartesian, 0);
                    //CoordinatesXYZ coordSystemCartesian = change_radar_cartesian2system_cartesian(new CoordinatesWGS84(LatARP, LonARP), coordRadarCartesian);
                    //CoordinatesUVH coordinatesUVH = change_system_cartesian2stereographic(coordSystemCartesian);

                    //// Calculamos Coordenadas WGS84
                    //CoordinatesXYZ coordGeocentric = change_radar_cartesian2geocentric(new CoordinatesWGS84(LatARP, LonARP), coordRadarCartesian);
                    //coordinatesWGS84 = change_geocentric2geodesic(coordGeocentric);

                    // Calculamos WGS84
                    double[] coordWGS84 = MLATcARTESIANCoordinates2WGS84(X_cartesian, Y_cartesian);
                    coordinatesWGS84 = new CoordinatesWGS84(coordWGS84[0], coordWGS84[1]);

                    // Calculamos Estereograficas
                    CoordinatesXYZ coordGeocentric = change_geodesic2geocentric(coordinatesWGS84);
                    CoordinatesXYZ coordSystemCartesian = change_geocentric2system_cartesian(coordGeocentric);
                    coordinatesUVH = change_system_cartesian2stereographic(coordSystemCartesian);

                }// 7 I010/042  Position in Cartesian Co-ordinates

                if (Char.ToString(FSPEC_fake[7]) == "1") // 8 - _FX
                {

                } // FX

                if(FSPEC.Length>8)
                {
                    if (Char.ToString(FSPEC_fake[8]) == "1") // 8 I010/200  Calculated Track Velocity in Polar Co-ordinates
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

                        CalculatedTrackVelocityinPolarCoordinates = String.Concat(string1, string2, string3, string4);

                        data_position = data_position + 4;

                        string gs1 = CalculatedTrackVelocityinPolarCoordinates.Substring(0, 16);
                        string ta1 = CalculatedTrackVelocityinPolarCoordinates.Substring(16, 16);

                        GroundSpeed = Convert.ToInt32(gs1, 2) * (Math.Pow(2, -14));
                        TrackAngle = Convert.ToInt32(ta1, 2) * 360 / (Math.Pow(2, 16));


                    }// 8 I010/200  Calculated Track Velocity in Polar Co-ordinates

                    if (Char.ToString(FSPEC_fake[9]) == "1") // 9 I010/202  Calculated Track Velocity in Cartesian Coord
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

                        CalculatedTrackVelocityinCartesianCoordinates = String.Concat(string1, string2, string3, string4);
                        data_position = data_position + 4;

                        string vx = CalculatedTrackVelocityinCartesianCoordinates.Substring(0, 16);
                        string vy = CalculatedTrackVelocityinCartesianCoordinates.Substring(16, 16);

                        Vx_cartesian = Calculate_ComplementoA2(vx) * 0.25;
                        Vy_cartesian = Calculate_ComplementoA2(vy) * 0.25;
                    } // 9 I010/202  Calculated Track Velocity in Cartesian Coord

                    if (Char.ToString(FSPEC_fake[10]) == "1") // 10 I010/161  Track Number 
                    {
                        string string1 = Convert.ToString(paquete[data_position]);
                        string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                        string1 = AddZeros(string1);

                        string string2 = Convert.ToString(paquete[data_position + 1]);
                        string2 = Convert.ToString(Convert.ToInt32(string2, 16), 2);
                        string2 = AddZeros(string2);

                        TrackNumber = String.Concat(string1, string2);

                        data_position = data_position + 2;

                        string tn = TrackNumber.Substring(4, 12);
                        Tracknumber_value = Convert.ToInt32(tn, 2);

                    } // 10 I010/161  Track Number 

                    if (Char.ToString(FSPEC_fake[11]) == "1") // 11 I010/170  Track Status 
                    {
                        // primero leemos el primer paquete y lo pasamos a binario

                        string string_packet = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                        string_packet = AddZeros(string_packet);

                        if ((Convert.ToString(string_packet[7])) == "0") // si ultima posicion es un 0 guardamos el octeto y pasamos al siguiente
                        {
                            TrackStatus = string_packet;
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

                        TrackStatus = string_packet;

                        Calculate_TrackStatus(TrackStatus);

                    }// 11 I010/170  Track Status 

                    if (Char.ToString(FSPEC_fake[12]) == "1") // 12  I010/060  Mode-3/A Code in Octal Representation 
                    {
                        string string1 = Convert.ToString(paquete[data_position]);
                        string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                        string1 = AddZeros(string1);

                        string string2 = Convert.ToString(paquete[data_position + 1]);
                        string2 = Convert.ToString(Convert.ToInt32(string2, 16), 2);
                        string2 = AddZeros(string2);

                        Mode3ACodeinOctal = String.Concat(string1, string2);

                        data_position = data_position + 2;

                        Calculate_Mode3ACode_octal(Mode3ACodeinOctal);

                    }// 12  I010/060  Mode-3/A Code in Octal Representation 

                    if (Char.ToString(FSPEC_fake[13]) == "1") // 13  I010 / 220 Target Adress 
                    {
                        string string1 = Convert.ToString(paquete[data_position]);
                        string str1 = string1;
                        string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                        string1 = AddZeros(string1);

                        string string2 = Convert.ToString(paquete[data_position + 1]);
                        string str2 = string2;
                        string2 = Convert.ToString(Convert.ToInt32(string2, 16), 2);
                        string2 = AddZeros(string2);

                        string string3 = Convert.ToString(paquete[data_position + 2]);
                        string str3 = string3;
                        string3 = Convert.ToString(Convert.ToInt32(string3, 16), 2);
                        string3 = AddZeros(string3);

                        TargetAdress = String.Concat(string1, string2, string3);

                        data_position = data_position + 3;

                        TargetAdress_decoded = String.Concat(str1, str2, str3);

                    }// 13  I010 / 220 Target Adress 

                    if (Char.ToString(FSPEC_fake[14]) == "1") // 14  I010/245 Target Identification   
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

                        TargetIdentification = String.Concat(string1, string2, string3, string4, string5, string6, string7);

                        data_position = data_position + 7;

                        string sti1 = TargetIdentification.Substring(0, 2);
                        if (sti1 == "00") { STI = "Callsign or registration downlinked from transponder."; }
                        if (sti1 == "01") { STI = "Callsign not downlinked from transponder."; }
                        else { STI = "Registration not downlinked from transponder."; }

                        string todecode = TargetIdentification.Substring(2, 48);

                        Calculate_TargetIdentification(todecode);

                    } // 14  I010/245 Target Identification 

                    if (Char.ToString(FSPEC_fake[15]) == "1")  // FX - Field Extension Indicator
                    {

                    } // FX

                    if(FSPEC.Length>16)
                    {
                        if (Char.ToString(FSPEC_fake[16]) == "1") // 15  I010/250  Mode S MB Data
                        {
                            data_position = data_position + Calculate_ModeSMBData(paquete, data_position);

                        }// 15  I010/250  Mode S MB Data

                        if (Char.ToString(FSPEC_fake[17]) == "1") // 16  I010/300 Vehicle Fleet Identification 
                        {
                            string string1 = Convert.ToString(paquete[data_position]);
                            string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                            string1 = AddZeros(string1);

                            data_position = data_position + 1;

                            VehicleFleetIdentification = string1;
                            Calculate_VehicleFleetIdentification(VehicleFleetIdentification);
                        } // 16  I010/300 Vehicle Fleet Identification 

                        if (Char.ToString(FSPEC_fake[18]) == "1") // 17  I010/090 Flight Level in Binary Representation 
                        {
                            string string1 = Convert.ToString(paquete[data_position]);
                            string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                            string1 = AddZeros(string1);

                            string string2 = Convert.ToString(paquete[data_position]);
                            string2 = Convert.ToString(Convert.ToInt32(string2, 16), 2);
                            string2 = AddZeros(string2);


                            data_position = data_position + 2;

                            FlightLevelInBinaryRepresentation = String.Concat(string1, string2);

                            string v1 = FlightLevelInBinaryRepresentation.Substring(0, 1);
                            if (v1 == "0") { V_fl = "Code validated."; }
                            else { V_fl = "Code not validated."; }

                            string g1 = FlightLevelInBinaryRepresentation.Substring(1, 1);
                            if (g1 == "0") { G_fl = "Default."; }
                            else { G_fl = "Garbled code."; }

                            string fl = FlightLevelInBinaryRepresentation.Substring(2, 14);
                            FlightLevel = Calculate_ComplementoA2(fl) * 0.25;

                        }// 17  I010/090 Flight Level in Binary Representation 

                        if (Char.ToString(FSPEC_fake[19]) == "1") // 18  I010/091 Measured Height 
                        {
                            string string1 = Convert.ToString(paquete[data_position]);
                            string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                            string1 = AddZeros(string1);

                            string string2 = Convert.ToString(paquete[data_position]);
                            string2 = Convert.ToString(Convert.ToInt32(string2, 16), 2);
                            string2 = AddZeros(string2);


                            data_position = data_position + 2;

                            MeasuredHeight = String.Concat(string1, string2);

                            MeasuredHeight_ft = Calculate_ComplementoA2(MeasuredHeight) * 6.26;

                        }// 18  I010/091 Measured Height 

                        if (Char.ToString(FSPEC_fake[20]) == "1") // 19  I010/270 Target Size & Orientation
                        {
                            // primero leemos el primer paquete y lo pasamos a binario

                            string string_packet = Convert.ToString(Convert.ToInt32(paquete[data_position], 16), 2);
                            string_packet = AddZeros(string_packet);

                            if ((Convert.ToString(string_packet[7])) == "0") // si ultima posicion es un 0 guardamos el octeto y pasamos al siguiente
                            {
                                TargetSizeOrientation = string_packet;
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

                            TargetSizeOrientation = string_packet;

                            Calculate_TargetSizeOrientation(TargetSizeOrientation);
                        }// 19  I010/270 Target Size & Orientation

                        if (Char.ToString(FSPEC_fake[21]) == "1") // 20  I010/550 System Status
                        {
                            string string1 = Convert.ToString(paquete[data_position]);
                            string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                            string1 = AddZeros(string1);


                            data_position = data_position + 1;

                            SystemStatus = string1;

                            Calculate_SystemStatus(SystemStatus);
                        } // 20  I010/550 System Status

                        if (Char.ToString(FSPEC_fake[22]) == "1") // 21  I010/310 Pre-programmed Message
                        {
                            string string1 = Convert.ToString(paquete[data_position]);
                            string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                            string1 = AddZeros(string1);

                            data_position = data_position + 1;

                            PreProgrammedMessage = string1;

                            string trb = PreProgrammedMessage.Substring(0, 1);
                            if (trb == "0") { TRB = "Default."; }
                            else { TRB = "In Trouble."; }

                            string msg = PreProgrammedMessage.Substring(1, 7);
                            int msg1 = Convert.ToInt32(msg, 2);
                            if (msg1 == 1) { MSG = "Towing aircraft."; }
                            if (msg1 == 2) { MSG = "“Follow me” operation."; }
                            if (msg1 == 3) { MSG = "Runway check."; }
                            if (msg1 == 4) { MSG = "Emergency operation (fire, medical…)."; }
                            if (msg1 == 5) { MSG = "Work in progress (maintenance, birds scarer, sweepers…)"; }

                        }// 21  I010/310 Pre-programmed Message

                        if (Char.ToString(FSPEC_fake[23]) == "1")  // FX - Field Extension Indicator
                        {

                        } // FX

                        if(FSPEC.Length>24)
                        {
                            if (Char.ToString(FSPEC_fake[24]) == "1") // 22 I010/500   Standard Deviation of Position 
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

                                StandardDeviationofPosition = String.Concat(string1, string2, string3, string4);

                                data_position = data_position + 4;

                                string sdx = StandardDeviationofPosition.Substring(0, 8);
                                string sdy = StandardDeviationofPosition.Substring(8, 8);
                                string sdxy = StandardDeviationofPosition.Substring(16, 16);

                                StdDeviation_x = Convert.ToInt32(sdx, 2) * 0.25;
                                StdDeviation_y = Convert.ToInt32(sdy, 2) * 0.25;
                                StdDeviation_xy = Convert.ToInt32(sdxy, 2) * 0.25;
                            } // 22 I010/500   Standard Deviation of Position 

                            if (Char.ToString(FSPEC_fake[25]) == "1") // 23  I010/280  Presence 
                            {
                                data_position = data_position + ComputePresence(paquete, data_position);
                            }// 23  I010/280  Presence 

                            if (Char.ToString(FSPEC_fake[26]) == "1") // 24  I010/131  Amplitude of Primary Plot 
                            {
                                string string1 = Convert.ToString(paquete[data_position]);
                                string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                string1 = AddZeros(string1);

                                AmplitudeofPrimaryPlot = string1;

                                data_position = data_position + 1;

                                AmplitudeofPrimaryPlot_value = Convert.ToInt32(AmplitudeofPrimaryPlot, 2);
                            }// 24  I010/131  Amplitude of Primary Plot 

                            if (Char.ToString(FSPEC_fake[27]) == "1") // 25  I010/210  Calculated Acceleration 
                            {
                                string string1 = Convert.ToString(paquete[data_position]);
                                string1 = Convert.ToString(Convert.ToInt32(string1, 16), 2);
                                string1 = AddZeros(string1);

                                string string2 = Convert.ToString(paquete[data_position + 1]);
                                string2 = Convert.ToString(Convert.ToInt32(string2, 16), 2);
                                string2 = AddZeros(string2);

                                CalculatedAcceleration = String.Concat(string1, string2);

                                data_position = data_position + 2;

                                CalculatedAcceleration_X = Calculate_ComplementoA2(CalculatedAcceleration.Substring(0, 8));
                                CalculatedAcceleration_Y = Calculate_ComplementoA2(CalculatedAcceleration.Substring(8, 8));
                            } // 25  I010/210  Calculated Acceleration 
                        }
                    }
                }
            }
        }

        public double[] MLATPolarCoordinates2WGS84(double rho, double theta)
        {
            double[] coordenadesMLAT_WGS84 = NewCoordinatesMLAT(rho, theta);
            return coordenadesMLAT_WGS84;
        }

        public double[] MLATcARTESIANCoordinates2WGS84(double X, double Y)
        {
            double coordX = X;
            double coordY = Y;

            double rho = Math.Sqrt(coordX * coordX + coordY * coordY);
            double theta = (180 / Math.PI) * Math.Atan2(coordX, coordY);

            double[] coordenadesMLAT_WGS84 = NewCoordinatesMLAT(rho, theta);
            return coordenadesMLAT_WGS84;
        }

        public double toRadians(double grados)
        {
            return grados * Math.PI / 180;
        }

        public double toDegrees(double radians)
        {
            return radians * 180 / (Math.PI);
        }

        public double[] NewCoordinatesMLAT(double distance, double initialBearing)
        {
            double[] listaCoordenadas = new double[2];

            double φ1 = toRadians(LatARP);
            double λ1 = toRadians(LonARP);
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
}
