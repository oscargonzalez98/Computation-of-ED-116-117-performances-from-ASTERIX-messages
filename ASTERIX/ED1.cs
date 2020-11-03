using Clases;
using DotNetMatrix;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using LIBRERIACLASES;
using MultiCAT6.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

using System.Diagnostics;
using System.Windows.Media.Media3D;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Remoting.Messaging;
using System.IO;
using System.Collections;

using Excel = Microsoft.Office.Interop.Excel;

namespace ASTERIX
{
    public partial class ED1 : Form
    {
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

        List<CAT10> listaCAT10 = new List<CAT10>();
        List<CAT21> listaCAT21 = new List<CAT21>();
        List<CAT21v23> listaCAT21v23 = new List<CAT21v23>();

        List<CAT10> listaMLAT = new List<CAT10>();
        List<CAT10> listaSMR = new List<CAT10>();

        List<CAT10> listaMLATmodeS = new List<CAT10>();

        List<CAT10> listaMLAT_Stand = new List<CAT10>();
        List<CAT10> listaMLAT_Apron = new List<CAT10>();
        List<CAT10> listaMLAT_MA = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne = new List<CAT10>();
        List<CAT10> listaRunway1 = new List<CAT10>();
        List<CAT10> listaRunway2 = new List<CAT10>();
        List<CAT10> listaRunway3 = new List<CAT10>();
        List<CAT10> listaMLAT_Taxiway = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne_2coma5NM = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne_5NM = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne_2coma5NM_L = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne_2coma5NM_N = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne_2coma5NM_P = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne_2coma5NM_R = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne_2coma5NM_T = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne_2coma5NM_V = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne_5NM_K = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne_5NM_M = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne_5NM_O = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne_5NM_Q = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne_5NM_S = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne_5NM_U = new List<CAT10>();

        List<CAT21> listaCAT21nearAirport = new List<CAT21>();

        DataGridView dgv_ProbabilityofUpdate_fromASTERIXfile = new DataGridView();
        DataGridView dgv_PrecissionAccuracy_fromASTERIXfile = new DataGridView();
        DataGridView dgv_ProbabilityofMLATDetection_fromASTERIXfile = new DataGridView();
        DataGridView dgv_ProbabilityofMLATIdentification_fromASTERIXfile = new DataGridView();


        public List<PointLatLng> polygonApoints = new List<PointLatLng>();
        public List<PointLatLng> polygonBpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonCpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonDpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonEpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonFpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonGpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonHpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonIpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonJpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonKpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonLpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonMpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonNpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonOpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonPpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonQpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonRpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonSpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonTpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonUpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonVpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonWpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonXpoints = new List<PointLatLng>();
        public List<PointLatLng> polygonYpoints = new List<PointLatLng>();

        // CoordenadasSMR
        double LatSMR = 41.295618;
        double LonSMR = 2.095114;

        // Coordenadas MLAT
        double LatMLAT = 41.297063;
        double LonMLAT = 2.078447;
        public CoordinatesWGS84 radarcoordinates = new CoordinatesWGS84(41 + 17 / 60 + 49.426 / 3600, 2 + 04 / 60 + 42.41 / 3600);

        // Lista Bar Chart UpdateRate
        public List<IndividualBar> listBarsUpdateRate = new List<IndividualBar>();

        // Heading Pistas
        double heading07R;
        double heading25L;
        double heading07L;
        double heading25R;
        double heading02;
        double heading20;
        int i = 0;

        List<List<double>> ListResults_STAND;
        List<List<double>> ListResults_APRON;
        List<List<double>> ListResults_TAXI;
        List<List<double>> ListResults_RW1;
        List<List<double>> ListResults_RW2;
        List<List<double>> ListResults_RW3;
        List<List<double>> ListResults_MA_APRON;
        List<List<double>> ListResults_AIRBORNE25;
        List<List<double>> ListResults_AIRBORNE5;

        public ED1(List<CAT10> listaCAT10, List<CAT21> listaCAT21, List<CAT21v23> listaCAT21v23)
        {
            InitializeComponent();

            this.listaCAT10 = listaCAT10;
            this.listaCAT21 = listaCAT21;
            this.listaCAT21v23 = listaCAT21v23;

            // Cordenadas de los poligonos/superficies
            polygonApoints.Add(new PointLatLng(41.28504464668583, 2.072303599775964));
            polygonApoints.Add(new PointLatLng(41.28723009374163, 2.078718953092844));
            polygonApoints.Add(new PointLatLng(41.28885874916784, 2.077748868970652));
            polygonApoints.Add(new PointLatLng(41.29065643929236, 2.082995639066103));
            polygonApoints.Add(new PointLatLng(41.29222850233552, 2.083778238090788));
            polygonApoints.Add(new PointLatLng(41.29331871109087, 2.083045684310492));
            polygonApoints.Add(new PointLatLng(41.29106949349184, 2.076476920740631));
            polygonApoints.Add(new PointLatLng(41.29254944569193, 2.07558284559707));
            polygonApoints.Add(new PointLatLng(41.29012709275927, 2.06851382450906));
            polygonApoints.Add(new PointLatLng(41.28504464668583, 2.072303599775964));

            polygonBpoints.Add(new PointLatLng(41.28731823416347, 2.079764007059928));
            polygonBpoints.Add(new PointLatLng(41.28800136938792, 2.081802629828544));
            polygonBpoints.Add(new PointLatLng(41.28977528736695, 2.082630893033546));
            polygonBpoints.Add(new PointLatLng(41.28853318264134, 2.079046297054801));
            polygonBpoints.Add(new PointLatLng(41.28731823416347, 2.079764007059928));

            polygonCpoints.Add(new PointLatLng(41.29321070274573, 2.076320083519241));
            polygonCpoints.Add(new PointLatLng(41.29195041474841, 2.077077431934582));
            polygonCpoints.Add(new PointLatLng(41.29399206258152, 2.083029237964267));
            polygonCpoints.Add(new PointLatLng(41.29523587263329, 2.082249984443576));
            polygonCpoints.Add(new PointLatLng(41.29321070274573, 2.076320083519241));

            polygonDpoints.Add(new PointLatLng(41.30065330913252, 2.070303020960496));
            polygonDpoints.Add(new PointLatLng(41.30039539419548, 2.070456969215939));
            polygonDpoints.Add(new PointLatLng(41.30000776347889, 2.070917770368974));
            polygonDpoints.Add(new PointLatLng(41.29967596479406, 2.071688864944305));
            polygonDpoints.Add(new PointLatLng(41.29959146994269, 2.073228664122788));
            polygonDpoints.Add(new PointLatLng(41.30345473670611, 2.084537100676138));
            polygonDpoints.Add(new PointLatLng(41.30290495825957, 2.084875104603385));
            polygonDpoints.Add(new PointLatLng(41.30427409853728, 2.088851435790822));
            polygonDpoints.Add(new PointLatLng(41.30590241356465, 2.087869558272031));
            polygonDpoints.Add(new PointLatLng(41.3066804890744, 2.090125795521962));
            polygonDpoints.Add(new PointLatLng(41.30814452382673, 2.090862227752639));
            polygonDpoints.Add(new PointLatLng(41.30909185035398, 2.090291339935599));
            polygonDpoints.Add(new PointLatLng(41.30793723174423, 2.087009092954473));
            polygonDpoints.Add(new PointLatLng(41.30723056199035, 2.087458996395015));
            polygonDpoints.Add(new PointLatLng(41.30537957229418, 2.082053043424263));
            polygonDpoints.Add(new PointLatLng(41.30456131346386, 2.082557609714792));
            polygonDpoints.Add(new PointLatLng(41.3008830436416, 2.071957346981628));
            polygonDpoints.Add(new PointLatLng(41.30108765385491, 2.071574780556449));
            polygonDpoints.Add(new PointLatLng(41.3009155651295, 2.071091535633292));
            polygonDpoints.Add(new PointLatLng(41.30065330913252, 2.070303020960496));

            polygonEpoints.Add(new PointLatLng(41.29823865877675, 2.071231420732036));
            polygonEpoints.Add(new PointLatLng(41.30048609041909, 2.06980943057711));
            polygonEpoints.Add(new PointLatLng(41.29660223362265, 2.058475006326426));
            polygonEpoints.Add(new PointLatLng(41.29432958671836, 2.059839814242947));
            polygonEpoints.Add(new PointLatLng(41.29823865877675, 2.071231420732036));

            polygonFpoints.Add(new PointLatLng(41.30457448017142, 2.089729725733855));
            polygonFpoints.Add(new PointLatLng(41.30601803372394, 2.090395674079863));
            polygonFpoints.Add(new PointLatLng(41.30667782929991, 2.090126725817183));
            polygonFpoints.Add(new PointLatLng(41.30590134700933, 2.08787278165617));
            polygonFpoints.Add(new PointLatLng(41.30427336943613, 2.088855090126935));
            polygonFpoints.Add(new PointLatLng(41.30457448017142, 2.089729725733855));

            polygonGpoints.Add(new PointLatLng(41.30290531321184, 2.084874124781602));
            polygonGpoints.Add(new PointLatLng(41.30345261322027, 2.084533535543849));
            polygonGpoints.Add(new PointLatLng(41.29959074400027, 2.073228700331884));
            polygonGpoints.Add(new PointLatLng(41.29967470998086, 2.071693187872741));
            polygonGpoints.Add(new PointLatLng(41.30000697053827, 2.070919075000397));
            polygonGpoints.Add(new PointLatLng(41.30039357167374, 2.070459446529713));
            polygonGpoints.Add(new PointLatLng(41.30065260460123, 2.070303243523943));
            polygonGpoints.Add(new PointLatLng(41.30048650533456, 2.069808660956183));
            polygonGpoints.Add(new PointLatLng(41.29824304575094, 2.071236941944723));
            polygonGpoints.Add(new PointLatLng(41.30290531321184, 2.084874124781602));

            polygonHpoints.Add(new PointLatLng(41.29321248629184, 2.076317037912934));
            polygonHpoints.Add(new PointLatLng(41.28956758097301, 2.065554125358897));
            polygonHpoints.Add(new PointLatLng(41.28902431178173, 2.067520686236));
            polygonHpoints.Add(new PointLatLng(41.28955440513675, 2.068940144725449));
            polygonHpoints.Add(new PointLatLng(41.29012143210162, 2.06851590292412));
            polygonHpoints.Add(new PointLatLng(41.2925490011068, 2.075579761626731));
            polygonHpoints.Add(new PointLatLng(41.29106910015326, 2.076481303710718));
            polygonHpoints.Add(new PointLatLng(41.29331848519782, 2.08304615591185));
            polygonHpoints.Add(new PointLatLng(41.29222983099868, 2.083777753836971));
            polygonHpoints.Add(new PointLatLng(41.29065712208786, 2.082996332139622));
            polygonHpoints.Add(new PointLatLng(41.28885798115613, 2.077750786024948));
            polygonHpoints.Add(new PointLatLng(41.28723092652747, 2.078719350618556));
            polygonHpoints.Add(new PointLatLng(41.28504511955603, 2.072303471860446));
            polygonHpoints.Add(new PointLatLng(41.28429457970675, 2.073252038146045));
            polygonHpoints.Add(new PointLatLng(41.28661860767006, 2.080221795722565));
            polygonHpoints.Add(new PointLatLng(41.28733664026725, 2.0797506736647));
            polygonHpoints.Add(new PointLatLng(41.28855512194733, 2.079026526525407));
            polygonHpoints.Add(new PointLatLng(41.28980251153607, 2.082629487656971));
            polygonHpoints.Add(new PointLatLng(41.28803492635546, 2.081812539971151));
            polygonHpoints.Add(new PointLatLng(41.28734153685148, 2.079747588265484));
            polygonHpoints.Add(new PointLatLng(41.28661855511135, 2.080222823254285));
            polygonHpoints.Add(new PointLatLng(41.28708936718802, 2.081638558546843));
            polygonHpoints.Add(new PointLatLng(41.29231849483453, 2.084087751298431));
            polygonHpoints.Add(new PointLatLng(41.29399278888424, 2.083033619151));
            polygonHpoints.Add(new PointLatLng(41.29194845323224, 2.077076414636956));
            polygonHpoints.Add(new PointLatLng(41.29321248629184, 2.076317037912934));

            polygonIpoints.Add(new PointLatLng(41.29432853911477, 2.059841290590052));
            polygonIpoints.Add(new PointLatLng(41.29244352372002, 2.061081990705518));
            polygonIpoints.Add(new PointLatLng(41.29224414586391, 2.061526737006945));
            polygonIpoints.Add(new PointLatLng(41.29046417484277, 2.062609057585825));
            polygonIpoints.Add(new PointLatLng(41.28956626644186, 2.065553730733145));
            polygonIpoints.Add(new PointLatLng(41.29523767718762, 2.082250085220523));
            polygonIpoints.Add(new PointLatLng(41.29231726437897, 2.084091640755907));
            polygonIpoints.Add(new PointLatLng(41.28708946239801, 2.081639593866493));
            polygonIpoints.Add(new PointLatLng(41.28429573389018, 2.073249376619946));
            polygonIpoints.Add(new PointLatLng(41.28316212451168, 2.072989239047482));
            polygonIpoints.Add(new PointLatLng(41.28173786975413, 2.073784781912147));
            polygonIpoints.Add(new PointLatLng(41.29214530239392, 2.104127198089036));
            polygonIpoints.Add(new PointLatLng(41.29276318268523, 2.103757546620602));
            polygonIpoints.Add(new PointLatLng(41.29268764126339, 2.103528317911267));
            polygonIpoints.Add(new PointLatLng(41.29376290078783, 2.102914286073472));
            polygonIpoints.Add(new PointLatLng(41.29406164912393, 2.101945088686166));
            polygonIpoints.Add(new PointLatLng(41.28984141121184, 2.089462718011443));
            polygonIpoints.Add(new PointLatLng(41.29291561892327, 2.087628140011148));
            polygonIpoints.Add(new PointLatLng(41.29770085373364, 2.089788471416973));
            polygonIpoints.Add(new PointLatLng(41.30310731952297, 2.105503857052842));
            polygonIpoints.Add(new PointLatLng(41.3045527080456, 2.106123180658501));
            polygonIpoints.Add(new PointLatLng(41.30589157106402, 2.105346701864339));
            polygonIpoints.Add(new PointLatLng(41.30600926520326, 2.105639828306998));
            polygonIpoints.Add(new PointLatLng(41.30663924753058, 2.105276267770742));
            polygonIpoints.Add(new PointLatLng(41.30655247146466, 2.104984548921465));
            polygonIpoints.Add(new PointLatLng(41.30837639640288, 2.103832509588435));
            polygonIpoints.Add(new PointLatLng(41.30873186529448, 2.10248806583335));
            polygonIpoints.Add(new PointLatLng(41.30889602389677, 2.102398604206603));
            polygonIpoints.Add(new PointLatLng(41.30585742852851, 2.093493628556393));
            polygonIpoints.Add(new PointLatLng(41.30981681400108, 2.095287778329102));
            polygonIpoints.Add(new PointLatLng(41.31026232364314, 2.09403547590874));
            polygonIpoints.Add(new PointLatLng(41.30944477429792, 2.091586281567523));
            polygonIpoints.Add(new PointLatLng(41.30668316969677, 2.090133391519693));
            polygonIpoints.Add(new PointLatLng(41.30601822928018, 2.090406330589658));
            polygonIpoints.Add(new PointLatLng(41.3045732877946, 2.089731129076438));
            polygonIpoints.Add(new PointLatLng(41.29432853911477, 2.059841290590052));

            polygonJpoints.Add(new PointLatLng(41.28020883952823, 2.074747391943093));
            polygonJpoints.Add(new PointLatLng(41.28530469506816, 2.090058251819151));
            polygonJpoints.Add(new PointLatLng(41.28605447581095, 2.091570242240717));
            polygonJpoints.Add(new PointLatLng(41.29063812643459, 2.105913970311935));
            polygonJpoints.Add(new PointLatLng(41.29737362002733, 2.101759523428246));
            polygonJpoints.Add(new PointLatLng(41.30771845741656, 2.11093540410253));
            polygonJpoints.Add(new PointLatLng(41.31473140675691, 2.104026880102139));
            polygonJpoints.Add(new PointLatLng(41.31668145005288, 2.102337915089512));
            polygonJpoints.Add(new PointLatLng(41.30899903959134, 2.079427650796146));
            polygonJpoints.Add(new PointLatLng(41.30683929524009, 2.080486992271846));
            polygonJpoints.Add(new PointLatLng(41.2978989759275, 2.054726075032385));
            polygonJpoints.Add(new PointLatLng(41.29289249376819, 2.057959899448454));
            polygonJpoints.Add(new PointLatLng(41.29146706018695, 2.058982856630855));
            polygonJpoints.Add(new PointLatLng(41.28818507652813, 2.060651401810178));
            polygonJpoints.Add(new PointLatLng(41.28607411574124, 2.065276741711466));
            polygonJpoints.Add(new PointLatLng(41.28417467071309, 2.070733183164153));
            polygonJpoints.Add(new PointLatLng(41.28156789356743, 2.070583348773718));
            polygonJpoints.Add(new PointLatLng(41.27985715658978, 2.072825029809195));
            polygonJpoints.Add(new PointLatLng(41.28020883952823, 2.074747391943093));

            // Superficies pista 07R
            double[] coordenadas1 = new double[2];
            coordenadas1[0] = 41.282576;
            coordenadas1[1] = 2.074278;
            double[] coordenadas2 = new double[2];
            coordenadas2[0] = 41.282102;
            coordenadas2[1] = 2.074562;

            double angle1 = CalculateHeadingBetweenCoordinates(coordenadas1, coordenadas2);
            double angle2 = angle1 + 90;
            heading07R = angle1 - 90;

            double[] newcoordinates = new double[2];
            newcoordinates[0] = (coordenadas1[0] + coordenadas2[0]) / 2;
            newcoordinates[1] = (coordenadas1[1] + coordenadas2[1]) / 2;
            newcoordinates = NewCoordinates(newcoordinates, 2.5 * 1852, angle2);

            double[] coordenadas3 = NewCoordinates(newcoordinates, 30 + 2.5 * 1852 * Math.Sin(toRadians(10)), angle2 - 90);
            double[] coordenadas4 = NewCoordinates(newcoordinates, 30 + 2.5 * 1852 * Math.Sin(toRadians(10)), angle2 + 90);

            newcoordinates = NewCoordinates(newcoordinates, 2.5 * 1852, angle2);

            double[] coordenadas5 = NewCoordinates(newcoordinates, 30 + 5 * 1852 * Math.Sin(toRadians(10)), angle2 - 90);
            double[] coordenadas6 = NewCoordinates(newcoordinates, 30 + 5 * 1852 * Math.Sin(toRadians(10)), angle2 + 90);


            //polygonKpoints.Add(new PointLatLng(41.282576, 2.074278));
            //polygonKpoints.Add(new PointLatLng(41.282102, 2.074562));
            polygonKpoints.Add(new PointLatLng(coordenadas3[0], coordenadas3[1]));
            polygonKpoints.Add(new PointLatLng(coordenadas5[0], coordenadas5[1]));
            polygonKpoints.Add(new PointLatLng(coordenadas6[0], coordenadas6[1]));
            polygonKpoints.Add(new PointLatLng(coordenadas4[0], coordenadas4[1]));

            polygonLpoints.Add(new PointLatLng(41.282576, 2.074278));
            polygonLpoints.Add(new PointLatLng(41.282102, 2.074562));
            polygonLpoints.Add(new PointLatLng(coordenadas3[0], coordenadas3[1]));
            polygonLpoints.Add(new PointLatLng(coordenadas4[0], coordenadas4[1]));

            // Superficies pista 25L
            coordenadas2 = new double[2];
            coordenadas2[0] = 41.291965;
            coordenadas2[1] = 2.103366;
            coordenadas1 = new double[2];
            coordenadas1[0] = 41.292440;
            coordenadas1[1] = 2.103079;

            angle1 = CalculateHeadingBetweenCoordinates(coordenadas1, coordenadas2);
            angle2 = angle1 - 90;
            heading25L = angle1 + 90;

            newcoordinates = new double[2];
            newcoordinates[0] = (coordenadas1[0] + coordenadas2[0]) / 2;
            newcoordinates[1] = (coordenadas1[1] + coordenadas2[1]) / 2;
            newcoordinates = NewCoordinates(newcoordinates, 2.5 * 1852, angle2);

            coordenadas3 = NewCoordinates(newcoordinates, 30 + 2.5 * 1852 * Math.Sin(toRadians(10)), angle2 - 90);
            coordenadas4 = NewCoordinates(newcoordinates, 30 + 2.5 * 1852 * Math.Sin(toRadians(10)), angle2 + 90);

            newcoordinates = NewCoordinates(newcoordinates, 2.5 * 1852, angle2);

            coordenadas5 = NewCoordinates(newcoordinates, 30 + 5 * 1852 * Math.Sin(toRadians(10)), angle2 - 90);
            coordenadas6 = NewCoordinates(newcoordinates, 30 + 5 * 1852 * Math.Sin(toRadians(10)), angle2 + 90);


            //polygonMpoints.Add(new PointLatLng(coordenadas2[0], coordenadas2[1]));
            //polygonMpoints.Add(new PointLatLng(coordenadas1[0], coordenadas1[1]));
            polygonMpoints.Add(new PointLatLng(coordenadas3[0], coordenadas3[1]));
            polygonMpoints.Add(new PointLatLng(coordenadas5[0], coordenadas5[1]));
            polygonMpoints.Add(new PointLatLng(coordenadas6[0], coordenadas6[1]));
            polygonMpoints.Add(new PointLatLng(coordenadas4[0], coordenadas4[1]));

            polygonNpoints.Add(new PointLatLng(coordenadas2[0], coordenadas2[1]));
            polygonNpoints.Add(new PointLatLng(coordenadas1[0], coordenadas1[1]));
            polygonNpoints.Add(new PointLatLng(coordenadas3[0], coordenadas3[1]));
            polygonNpoints.Add(new PointLatLng(coordenadas4[0], coordenadas4[1]));

            // Superficies pista 07L
            coordenadas1 = new double[2];
            coordenadas1[0] = 41.295108;
            coordenadas1[1] = 2.071877;
            coordenadas2 = new double[2];
            coordenadas2[0] = 41.294635;
            coordenadas2[1] = 2.072162;

            angle1 = CalculateHeadingBetweenCoordinates(coordenadas1, coordenadas2);
            angle2 = angle1 + 90;
            heading07L = angle1 - 90;

            newcoordinates = new double[2];
            newcoordinates[0] = (coordenadas1[0] + coordenadas2[0]) / 2;
            newcoordinates[1] = (coordenadas1[1] + coordenadas2[1]) / 2;
            newcoordinates = NewCoordinates(newcoordinates, 2.5 * 1852, angle2);

            coordenadas3 = NewCoordinates(newcoordinates, 30 + 2.5 * 1852 * Math.Sin(toRadians(10)), angle2 - 90);
            coordenadas4 = NewCoordinates(newcoordinates, 30 + 2.5 * 1852 * Math.Sin(toRadians(10)), angle2 + 90);

            newcoordinates = NewCoordinates(newcoordinates, 2.5 * 1852, angle2);

            coordenadas5 = NewCoordinates(newcoordinates, 30 + 5 * 1852 * Math.Sin(toRadians(10)), angle2 - 90);
            coordenadas6 = NewCoordinates(newcoordinates, 30 + 5 * 1852 * Math.Sin(toRadians(10)), angle2 + 90);


            //polygonOpoints.Add(new PointLatLng(41.295108, 2.071877));
            //polygonOpoints.Add(new PointLatLng(41.294635, 2.072162));
            polygonOpoints.Add(new PointLatLng(coordenadas3[0], coordenadas3[1]));
            polygonOpoints.Add(new PointLatLng(coordenadas5[0], coordenadas5[1]));
            polygonOpoints.Add(new PointLatLng(coordenadas6[0], coordenadas6[1]));
            polygonOpoints.Add(new PointLatLng(coordenadas4[0], coordenadas4[1]));

            polygonPpoints.Add(new PointLatLng(41.295108, 2.071877));
            polygonPpoints.Add(new PointLatLng(41.294635, 2.072162));
            polygonPpoints.Add(new PointLatLng(coordenadas3[0], coordenadas3[1]));
            polygonPpoints.Add(new PointLatLng(coordenadas4[0], coordenadas4[1]));

            // Superficies pista 25R
            coordenadas1 = new double[2];
            coordenadas1[0] = 41.305946;
            coordenadas1[1] = 2.103528;
            coordenadas2 = new double[2];
            coordenadas2[0] = 41.305473;
            coordenadas2[1] = 2.103814;

            angle1 = CalculateHeadingBetweenCoordinates(coordenadas1, coordenadas2);
            angle2 = angle1 - 90;
            heading25R = angle1 + 90;

            newcoordinates = new double[2];
            newcoordinates[0] = (coordenadas1[0] + coordenadas2[0]) / 2;
            newcoordinates[1] = (coordenadas1[1] + coordenadas2[1]) / 2;
            newcoordinates = NewCoordinates(newcoordinates, 2.5 * 1852, angle2);

            coordenadas3 = NewCoordinates(newcoordinates, 30 + 2.5 * 1852 * Math.Sin(toRadians(10)), angle2 - 90);
            coordenadas4 = NewCoordinates(newcoordinates, 30 + 2.5 * 1852 * Math.Sin(toRadians(10)), angle2 + 90);

            newcoordinates = NewCoordinates(newcoordinates, 2.5 * 1852, angle2);

            coordenadas5 = NewCoordinates(newcoordinates, 30 + 5 * 1852 * Math.Sin(toRadians(10)), angle2 - 90);
            coordenadas6 = NewCoordinates(newcoordinates, 30 + 5 * 1852 * Math.Sin(toRadians(10)), angle2 + 90);


            //polygonQpoints.Add(new PointLatLng(coordenadas2[0], coordenadas2[1]));
            //polygonQpoints.Add(new PointLatLng(coordenadas1[0], coordenadas1[1]));
            polygonQpoints.Add(new PointLatLng(coordenadas3[0], coordenadas3[1]));
            polygonQpoints.Add(new PointLatLng(coordenadas5[0], coordenadas5[1]));
            polygonQpoints.Add(new PointLatLng(coordenadas6[0], coordenadas6[1]));
            polygonQpoints.Add(new PointLatLng(coordenadas4[0], coordenadas4[1]));

            polygonRpoints.Add(new PointLatLng(coordenadas2[0], coordenadas2[1]));
            polygonRpoints.Add(new PointLatLng(coordenadas1[0], coordenadas1[1]));
            polygonRpoints.Add(new PointLatLng(coordenadas3[0], coordenadas3[1]));
            polygonRpoints.Add(new PointLatLng(coordenadas4[0], coordenadas4[1]));

            // Superficies pista 02
            coordenadas1 = new double[2];
            coordenadas1[0] = 41.287878;
            coordenadas1[1] = 2.084619;
            coordenadas2 = new double[2];
            coordenadas2[0] = 41.287752;
            coordenadas2[1] = 2.085107;

            angle1 = CalculateHeadingBetweenCoordinates(coordenadas1, coordenadas2);
            angle2 = angle1 + 90;
            heading02 = angle1 - 90;

            newcoordinates = new double[2];
            newcoordinates[0] = (coordenadas1[0] + coordenadas2[0]) / 2;
            newcoordinates[1] = (coordenadas1[1] + coordenadas2[1]) / 2;
            newcoordinates = NewCoordinates(newcoordinates, 2.5 * 1852, angle2);

            coordenadas3 = NewCoordinates(newcoordinates, 30 + 2.5 * 1852 * Math.Sin(toRadians(10)), angle2 - 90);
            coordenadas4 = NewCoordinates(newcoordinates, 30 + 2.5 * 1852 * Math.Sin(toRadians(10)), angle2 + 90);

            newcoordinates = NewCoordinates(newcoordinates, 2.5 * 1852, angle2);

            coordenadas5 = NewCoordinates(newcoordinates, 30 + 5 * 1852 * Math.Sin(toRadians(10)), angle2 - 90);
            coordenadas6 = NewCoordinates(newcoordinates, 30 + 5 * 1852 * Math.Sin(toRadians(10)), angle2 + 90);


            //polygonSpoints.Add(new PointLatLng(41.287878, 2.084619));
            //polygonSpoints.Add(new PointLatLng(41.287752, 2.085107));
            polygonSpoints.Add(new PointLatLng(coordenadas3[0], coordenadas3[1]));
            polygonSpoints.Add(new PointLatLng(coordenadas5[0], coordenadas5[1]));
            polygonSpoints.Add(new PointLatLng(coordenadas6[0], coordenadas6[1]));
            polygonSpoints.Add(new PointLatLng(coordenadas4[0], coordenadas4[1]));

            polygonTpoints.Add(new PointLatLng(41.287878, 2.084619));
            polygonTpoints.Add(new PointLatLng(41.287752, 2.085107));
            polygonTpoints.Add(new PointLatLng(coordenadas3[0], coordenadas3[1]));
            polygonTpoints.Add(new PointLatLng(coordenadas4[0], coordenadas4[1]));

            // Superficies pista 20
            coordenadas1 = new double[2];
            coordenadas1[0] = 41.309307;
            coordenadas1[1] = 2.094396;
            coordenadas2 = new double[2];
            coordenadas2[0] = 41.309180;
            coordenadas2[1] = 2.094881;

            angle1 = CalculateHeadingBetweenCoordinates(coordenadas1, coordenadas2);
            angle2 = angle1 - 90;
            heading20 = angle1 + 90;

            newcoordinates = new double[2];
            newcoordinates[0] = (coordenadas1[0] + coordenadas2[0]) / 2;
            newcoordinates[1] = (coordenadas1[1] + coordenadas2[1]) / 2;
            newcoordinates = NewCoordinates(newcoordinates, 2.5 * 1852, angle2);

            coordenadas3 = NewCoordinates(newcoordinates, 30 + 2.5 * 1852 * Math.Sin(toRadians(10)), angle2 - 90);
            coordenadas4 = NewCoordinates(newcoordinates, 30 + 2.5 * 1852 * Math.Sin(toRadians(10)), angle2 + 90);

            newcoordinates = NewCoordinates(newcoordinates, 2.5 * 1852, angle2);

            coordenadas5 = NewCoordinates(newcoordinates, 30 + 5 * 1852 * Math.Sin(toRadians(10)), angle2 - 90);
            coordenadas6 = NewCoordinates(newcoordinates, 30 + 5 * 1852 * Math.Sin(toRadians(10)), angle2 + 90);


            //polygonUpoints.Add(new PointLatLng(coordenadas2[0], coordenadas2[1]));
            //polygonUpoints.Add(new PointLatLng(coordenadas1[0], coordenadas1[1]));
            polygonUpoints.Add(new PointLatLng(coordenadas3[0], coordenadas3[1]));
            polygonUpoints.Add(new PointLatLng(coordenadas5[0], coordenadas5[1]));
            polygonUpoints.Add(new PointLatLng(coordenadas6[0], coordenadas6[1]));
            polygonUpoints.Add(new PointLatLng(coordenadas4[0], coordenadas4[1]));

            polygonVpoints.Add(new PointLatLng(coordenadas2[0], coordenadas2[1]));
            polygonVpoints.Add(new PointLatLng(coordenadas1[0], coordenadas1[1]));
            polygonVpoints.Add(new PointLatLng(coordenadas3[0], coordenadas3[1]));
            polygonVpoints.Add(new PointLatLng(coordenadas4[0], coordenadas4[1]));

            // RWY1 (la diagonal)
            polygonWpoints.Add(new PointLatLng(41.287752, 2.085107));
            polygonWpoints.Add(new PointLatLng(41.287878, 2.084619));
            polygonWpoints.Add(new PointLatLng(41.309307, 2.094396));
            polygonWpoints.Add(new PointLatLng(41.309180, 2.094881));

            // RW2(la de abajo))
            polygonXpoints.Add(new PointLatLng(41.282576, 2.074278));
            polygonXpoints.Add(new PointLatLng(41.282102, 2.074562));
            polygonXpoints.Add(new PointLatLng(41.291965, 2.103366));
            polygonXpoints.Add(new PointLatLng(41.292440, 2.103079));


            // RW3 (la de arriba)
            polygonYpoints.Add(new PointLatLng(41.295108, 2.071877));
            polygonYpoints.Add(new PointLatLng(41.294635, 2.072162));
            polygonYpoints.Add(new PointLatLng(41.305473, 2.103814));
            polygonYpoints.Add(new PointLatLng(41.305946, 2.103528));

        }

        private void ED1_Load(object sender, EventArgs e)
        {
            // En el load vamos a hacer los filtros y las separaciones que necesitamos para calcular cada performance

            // Separamos los paquetes según son SMR o MLAT

            int i = 0;
            while (i < listaCAT10.Count)
            {
                int SAC = listaCAT10[i].SAC;
                int SIC = listaCAT10[i].SIC;

                if (SAC == 0 && SIC == 7)
                {
                    listaSMR.Add(listaCAT10[i]);
                }
                if (SAC == 0 && SIC == 107)
                {
                    listaMLAT.Add(listaCAT10[i]);
                }
                i = i + 1;
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //// Update Rate: based on the squitter rate of Mode S transponders) (hay que hacer una lista solo con paquetes de Transponder mode S) 

            i = 0;
            while (i < listaMLAT.Count)
            {
                if (listaMLAT[i].TYP == "Mode S multilateration." && listaMLAT[i].MessageType_decodified != "Periodic Status Message" && listaMLAT[i].MessageType_decodified != "Start of Update Cycle" && listaMLAT[i].TOT == "Aircraft.")
                {
                    listaMLATmodeS.Add(listaMLAT[i]);
                }
                i = i + 1;
            }

            listaCAT21nearAirport = FilterCAT21packets(listaCAT21);

            //List<CAT10> lista2 = new List<CAT10>();
            //for (i = 0; i < listaMLATmodeS.Count(); i++)
            //{
            //    if (listaMLATmodeS[i].TargetAdress_decoded != "34340A") // cojemos solo los paquetes con info de posición y velocidad en radianes
            //    {
            //        lista2.Add(listaMLATmodeS[i]);
            //    }
            //}
            //listaMLATmodeS.Clear();
            //for (i = 0; i < lista2.Count; i++) { listaMLATmodeS.Add(lista2[i]); }

            //// Filtramos los paquetes CAT21 mas alejados del aeropuerto
            //double[] c1 = new double[2];
            //c1[0] = LatMLAT;
            //c1[1] = LonMLAT;

            //for(i=0; i<listaCAT21.Count(); i++)
            //{
            //    double distance = CalculateDistanceBetweenCoordinates(c1, CoordinatesADSB_WGS84(listaCAT21[i]));
            //    if (distance < 6.5 * 1852) { listaCAT21nearAirport.Add(listaCAT21[i]); } // cojemos los paquetes a menos de 10NM del aeropuerto
            //}

            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // Probability of Update: Separamos la listaMLATmodeS en 4 listas según la posición del paquete en el mapa

            // Creamos las superficies con las coordenadas anteriores
            GMapOverlay polygonsOverlay = new GMapOverlay();
            polygonsOverlay.Clear();
            var polygonA = new GMapPolygon(polygonApoints, "PolygonA")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };
            polygonsOverlay.Polygons.Add(polygonA);
            Mapa.Overlays.Add(polygonsOverlay);

            var polygonC = new GMapPolygon(polygonCpoints, "PolygonC")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };
            polygonsOverlay.Polygons.Add(polygonC);
            Mapa.Overlays.Add(polygonsOverlay);

            var polygonD = new GMapPolygon(polygonDpoints, "PolygonD")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };
            polygonsOverlay.Polygons.Add(polygonD);
            Mapa.Overlays.Add(polygonsOverlay);

            var polygonE = new GMapPolygon(polygonEpoints, "PolygonE")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };
            polygonsOverlay.Polygons.Add(polygonE);
            Mapa.Overlays.Add(polygonsOverlay);

            var polygonF = new GMapPolygon(polygonFpoints, "PolygonF")
            {
                Stroke = new Pen(Color.Yellow, 2),
                Fill = new SolidBrush(Color.Yellow)
            };
            polygonsOverlay.Polygons.Add(polygonF);
            Mapa.Overlays.Add(polygonsOverlay);

            var polygonG = new GMapPolygon(polygonGpoints, "PolygonG")
            {
                Stroke = new Pen(Color.Yellow, 2),
                Fill = new SolidBrush(Color.Yellow)
            };
            polygonsOverlay.Polygons.Add(polygonG);
            Mapa.Overlays.Add(polygonsOverlay);

            var polygonH = new GMapPolygon(polygonHpoints, "PolygonH")
            {
                Stroke = new Pen(Color.Yellow, 2),
                Fill = new SolidBrush(Color.Yellow)
            };
            polygonsOverlay.Polygons.Add(polygonH);
            Mapa.Overlays.Add(polygonsOverlay);

            var polygonB = new GMapPolygon(polygonBpoints, "PolygonB")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };
            polygonsOverlay.Polygons.Add(polygonB);
            Mapa.Overlays.Add(polygonsOverlay);

            var polygonI = new GMapPolygon(polygonIpoints, "PolygonI")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Green)
            };
            polygonsOverlay.Polygons.Add(polygonI);

            var polygonJ = new GMapPolygon(polygonJpoints, "PolygonJ")
            {
                Stroke = new Pen(Color.Red, 2),
                Fill = new SolidBrush(Color.Red)
            };

            var polygonK = new GMapPolygon(polygonKpoints, "PolygonK")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };
            polygonsOverlay.Polygons.Add(polygonK);

            var polygonL = new GMapPolygon(polygonLpoints, "PolygonL")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };
            polygonsOverlay.Polygons.Add(polygonL);

            var polygonM = new GMapPolygon(polygonMpoints, "PolygonM")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };
            polygonsOverlay.Polygons.Add(polygonM);

            var polygonN = new GMapPolygon(polygonNpoints, "PolygonN")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };
            polygonsOverlay.Polygons.Add(polygonN);

            var polygonO = new GMapPolygon(polygonOpoints, "PolygonO")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };
            polygonsOverlay.Polygons.Add(polygonO);

            var polygonP = new GMapPolygon(polygonPpoints, "PolygonP")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };
            polygonsOverlay.Polygons.Add(polygonP);

            var polygonQ = new GMapPolygon(polygonQpoints, "PolygonQ")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };
            polygonsOverlay.Polygons.Add(polygonQ);

            var polygonR = new GMapPolygon(polygonRpoints, "PolygonR")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };
            polygonsOverlay.Polygons.Add(polygonR);

            var polygonS = new GMapPolygon(polygonSpoints, "PolygonS")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };
            polygonsOverlay.Polygons.Add(polygonS);

            var polygonT = new GMapPolygon(polygonTpoints, "PolygonT")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };
            polygonsOverlay.Polygons.Add(polygonT);

            var polygonU = new GMapPolygon(polygonUpoints, "PolygonU")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };
            polygonsOverlay.Polygons.Add(polygonU);

            var polygonV = new GMapPolygon(polygonVpoints, "PolygonV")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };
            polygonsOverlay.Polygons.Add(polygonV);

            var polygonW = new GMapPolygon(polygonWpoints, "PolygonW")
            {
                Stroke = new Pen(Color.White, 2),
                Fill = new SolidBrush(Color.White)
            };
            polygonsOverlay.Polygons.Add(polygonW);

            var polygonX = new GMapPolygon(polygonXpoints, "PolygonX")
            {
                Stroke = new Pen(Color.White, 2),
                Fill = new SolidBrush(Color.White)
            };
            polygonsOverlay.Polygons.Add(polygonX);

            var polygonY = new GMapPolygon(polygonYpoints, "PolygonY")
            {
                Stroke = new Pen(Color.White, 2),
                Fill = new SolidBrush(Color.White)
            };
            polygonsOverlay.Polygons.Add(polygonY);

            Mapa.Overlays.Add(polygonsOverlay);

            i = 0;
            while (i < listaMLATmodeS.Count)
            {
                double[] coordenadas;

                if ((listaMLATmodeS[i].MeasuredPositioninPolarCoordinates.Length > 0 && listaMLATmodeS[i].CalculatedTrackVelocityinPolarCoordinates.Length > 0) || (listaMLATmodeS[i].PositioninCartesianCoordinates.Length > 0 && listaMLATmodeS[i].CalculatedTrackVelocityinPolarCoordinates.Length > 0)) // cojemos solo los paquetes con info de posición y velocidad en radianes
                {
                    if (listaMLATmodeS[i].MeasuredPositioninPolarCoordinates.Length > 0) // si tienen posición en coordenadas polares
                    {
                        coordenadas = NewCoordinatesMLAT(listaMLATmodeS[i].Rho, listaMLATmodeS[i].Theta);
                    }

                    else // si tienen posición en coordenadas cartesianas
                    {
                        double rho = Math.Sqrt((listaMLATmodeS[i].X_cartesian) * (listaMLATmodeS[i].X_cartesian) + (listaMLATmodeS[i].Y_cartesian) * (listaMLATmodeS[i].Y_cartesian));
                        double theta = (180 / Math.PI) * Math.Atan2(listaMLATmodeS[i].X_cartesian, listaMLATmodeS[i].Y_cartesian);

                        coordenadas = NewCoordinatesMLAT(rho, theta);
                    }

                    // Todos los paquetes que pasan por aqui tienen coordenadas convertidas a wgs84 y info de la velocidad en coordenadas polares
                    // Ahora comprobamos si el paquete de turno esta en alguna zona del aeropuerto
                    bool insideA = polygonA.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideB = polygonB.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideC = polygonC.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideD = polygonD.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideE = polygonE.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideF = polygonF.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideG = polygonG.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideH = polygonH.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideI = polygonI.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideJ = polygonJ.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideK = polygonK.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideL = polygonL.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideM = polygonM.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideN = polygonN.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideO = polygonO.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideP = polygonP.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideQ = polygonQ.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideR = polygonR.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideS = polygonS.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideT = polygonT.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideU = polygonU.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideV = polygonV.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideW = polygonW.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideX = polygonX.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                    bool insideY = polygonY.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));

                    // Separtamos los paquetes según su zona del aeropuerto, diferenciando los que estan volando y los que no
                    double Vthreshold = 300;
                    // Zona Stand (A,B,C,D,E)
                    if ((insideA == true || insideB == true || insideC == true || insideD == true || insideE == true))
                    {
                        listaMLAT_Stand.Add(listaMLATmodeS[i]);
                    }

                    // Zona Apron (F,G,H)
                    else if ((insideF == true || insideG == true || insideH == true))
                    {
                        listaMLAT_Apron.Add(listaMLATmodeS[i]);
                    }

                    // Zona MA (I)
                    else if (insideI)
                    {
                        double velocity = listaMLATmodeS[i].GroundSpeed * (1852 * 3600 / 1000);

                        //Si la velocidad esta por encima de un valor threshold esta en Zona Aire
                        if (insideL && velocity > Vthreshold) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_L.Add(listaMLATmodeS[i]); }
                        if (insideN && velocity > Vthreshold) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_N.Add(listaMLATmodeS[i]); }
                        if (insideP && velocity > Vthreshold) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_P.Add(listaMLATmodeS[i]); }
                        if (insideR && velocity > Vthreshold) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_R.Add(listaMLATmodeS[i]); }
                        if (insideT && velocity > Vthreshold) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_T.Add(listaMLATmodeS[i]); }
                        if (insideV && velocity > Vthreshold) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_V.Add(listaMLATmodeS[i]); }

                        // Si esta por debajo de un treshold esta en MA. Como esta en MA, filtramos para saber si esta en una runway o en Taxi
                        if (insideL && velocity < Vthreshold) { listaMLAT_MA.Add(listaMLATmodeS[i]); if (insideW) { listaRunway1.Add(listaMLATmodeS[i]); } else if (insideX) { listaRunway2.Add(listaMLATmodeS[i]); } else if (insideY) { listaRunway3.Add(listaMLATmodeS[i]); } else { listaMLAT_Taxiway.Add(listaMLATmodeS[i]); } }
                        if (insideN && velocity < Vthreshold) { listaMLAT_MA.Add(listaMLATmodeS[i]); if (insideW) { listaRunway1.Add(listaMLATmodeS[i]); } else if (insideX) { listaRunway2.Add(listaMLATmodeS[i]); } else if (insideY) { listaRunway3.Add(listaMLATmodeS[i]); } else { listaMLAT_Taxiway.Add(listaMLATmodeS[i]); } }
                        if (insideP && velocity < Vthreshold) { listaMLAT_MA.Add(listaMLATmodeS[i]); if (insideW) { listaRunway1.Add(listaMLATmodeS[i]); } else if (insideX) { listaRunway2.Add(listaMLATmodeS[i]); } else if (insideY) { listaRunway3.Add(listaMLATmodeS[i]); } else { listaMLAT_Taxiway.Add(listaMLATmodeS[i]); } }
                        if (insideR && velocity < Vthreshold) { listaMLAT_MA.Add(listaMLATmodeS[i]); if (insideW) { listaRunway1.Add(listaMLATmodeS[i]); } else if (insideX) { listaRunway2.Add(listaMLATmodeS[i]); } else if (insideY) { listaRunway3.Add(listaMLATmodeS[i]); } else { listaMLAT_Taxiway.Add(listaMLATmodeS[i]); } }
                        if (insideT && velocity < Vthreshold) { listaMLAT_MA.Add(listaMLATmodeS[i]); if (insideW) { listaRunway1.Add(listaMLATmodeS[i]); } else if (insideX) { listaRunway2.Add(listaMLATmodeS[i]); } else if (insideY) { listaRunway3.Add(listaMLATmodeS[i]); } else { listaMLAT_Taxiway.Add(listaMLATmodeS[i]); } }
                        if (insideV && velocity < Vthreshold) { listaMLAT_MA.Add(listaMLATmodeS[i]); if (insideW) { listaRunway1.Add(listaMLATmodeS[i]); } else if (insideX) { listaRunway2.Add(listaMLATmodeS[i]); } else if (insideY) { listaRunway3.Add(listaMLATmodeS[i]); } else { listaMLAT_Taxiway.Add(listaMLATmodeS[i]); } }

                        if (insideI && insideL == false && insideN == false && insideP == false && insideR == false && insideT == false && insideV == false) { listaMLAT_MA.Add(listaMLATmodeS[i]); if (insideW) { listaRunway1.Add(listaMLATmodeS[i]); } else if (insideX) { listaRunway2.Add(listaMLATmodeS[i]); } else if (insideY) { listaRunway3.Add(listaMLATmodeS[i]); } else { listaMLAT_Taxiway.Add(listaMLATmodeS[i]); } }

                    }
                    else if (insideI == false && insideJ == true) // fuera de Apron, Stand, MA pero dentro de Zona aeropuerto
                    {
                        double heading = listaMLATmodeS[i].TrackAngle;
                        if (listaMLATmodeS[i].GroundSpeed * (1852 * 3600 / 1000) > Vthreshold || (heading < heading07R + 10 && heading > heading07R - 10) || (heading < heading25L + 10 && heading > heading25L - 10) || (heading < heading25R + 10 && heading > heading25R - 10) || (heading < heading07L + 10 && heading > heading07L - 10) || (heading < heading20 + 10 && heading > heading20 - 10) || (heading < heading02 + 10 && heading > heading02 - 10))
                        {
                            listaMLAT_Airborne.Add(listaMLATmodeS[i]);

                            if (insideL) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_L.Add(listaMLATmodeS[i]); }
                            if (insideN) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_N.Add(listaMLATmodeS[i]); }
                            if (insideP) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_P.Add(listaMLATmodeS[i]); }
                            if (insideR) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_R.Add(listaMLATmodeS[i]); }
                            if (insideT) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_T.Add(listaMLATmodeS[i]); }
                            if (insideV) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_V.Add(listaMLATmodeS[i]); }
                        }
                    }
                    else // fuera de la zona aeropuerto
                    {
                        if (listaMLATmodeS[i].GroundSpeed * (1852 * 3600 / 1000) > 110)
                        {
                            listaMLAT_Airborne.Add(listaMLATmodeS[i]);

                            if (insideK) { listaMLAT_Airborne_5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_5NM_K.Add(listaMLATmodeS[i]); }
                            if (insideM) { listaMLAT_Airborne_5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_5NM_M.Add(listaMLATmodeS[i]); }
                            if (insideO) { listaMLAT_Airborne_5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_5NM_O.Add(listaMLATmodeS[i]); }
                            if (insideQ) { listaMLAT_Airborne_5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_5NM_Q.Add(listaMLATmodeS[i]); }
                            if (insideS) { listaMLAT_Airborne_5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_5NM_S.Add(listaMLATmodeS[i]); }
                            if (insideU) { listaMLAT_Airborne_5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_5NM_U.Add(listaMLATmodeS[i]); }

                            if (insideL) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_L.Add(listaMLATmodeS[i]); }
                            if (insideN) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_N.Add(listaMLATmodeS[i]); }
                            if (insideP) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_P.Add(listaMLATmodeS[i]); }
                            if (insideR) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_R.Add(listaMLATmodeS[i]); }
                            if (insideT) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_T.Add(listaMLATmodeS[i]); }
                            if (insideV) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); listaMLAT_Airborne_2coma5NM_V.Add(listaMLATmodeS[i]); }
                        }
                    }
                    i = i + 1;
                }
            }

            //////----------------------------------------------------------------------- Ploteamos en el mapa

            Mapa.DragButton = MouseButtons.Left;
            Mapa.CanDragMap = true;
            Mapa.MapProvider = GMapProviders.GoogleMap;
            Mapa.Position = new PointLatLng(LatMLAT, LonMLAT);
            Mapa.MinZoom = 1;
            Mapa.MaxZoom = 30;
            Mapa.Zoom = 8;
            Mapa.AutoScroll = true;

            GMapOverlay overlayMA = PlotListadePaquetesenOverlayMLAT(listaMLAT_Stand, red_circle);
            Mapa.Overlays.Add(overlayMA);

            GMapOverlay overlayAIRBORNE25 = PlotListadePaquetesenOverlayMLAT(listaMLAT_Apron, white_circle);
            Mapa.Overlays.Add(overlayAIRBORNE25);

            GMapOverlay overlayAIRBORNE5 = PlotListadePaquetesenOverlayMLAT(listaMLAT_MA, blue_circle);
            Mapa.Overlays.Add(overlayAIRBORNE5);

            //GMapOverlay overlayCAT21 = new GMapOverlay();
            //for (i = 0; i < listaCAT21nearAirport.Count(); i++) { overlayCAT21.Markers.Add(new GMarkerGoogle(new PointLatLng(CoordinatesADSB_WGS84(listaCAT21nearAirport[i])[0], CoordinatesADSB_WGS84(listaCAT21nearAirport[i])[1]), green_circle)); }
            //Mapa.Overlays.Add(overlayCAT21);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Parametros ED-117 de un archivo ASTERIX

        private void bt_CalculateUpdateRate_Click(object sender, EventArgs e)
        {
            List<string> listaNombresUsados = new List<string>();
            List<List<CAT10>> listadelistasdeavionesconmismonombre = new List<List<CAT10>>();
            List<double> listaAvgDelay = new List<double>();

            int i = 0;
            while (i < listaMLATmodeS.Count)
            {
                string TargetIdentification;
                string TargetAddress;

                if ((listaMLATmodeS[i].TargetIdentification.Length > 0 && listaMLATmodeS[i].TargetAdress.Length > 0) || (listaMLATmodeS[i].TargetIdentification.Length > 0) || (listaMLATmodeS[i].TargetAdress.Length > 0)) // cojemos los paquetes que tienen Target Address y/o Target Identification
                {
                    TargetIdentification = listaMLATmodeS[i].TargetIdentification_decoded;
                    TargetAddress = listaMLATmodeS[i].TargetAdress_decoded;

                    if ((listaNombresUsados.Contains(TargetIdentification) && listaNombresUsados.Contains(TargetAddress)) || (listaNombresUsados.Contains(TargetIdentification)) || (listaNombresUsados.Contains(TargetAddress))) // si Target Address y/o Target Identification estan en la lista de paquetes ya calculados no hacemos nada
                    { }
                    else
                    {
                        int j = i + 1;
                        List<CAT10> ListaPlanesMismoNombre = new List<CAT10>();
                        ListaPlanesMismoNombre.Add(listaMLATmodeS[i]);
                        while (j < listaMLATmodeS.Count)
                        {
                            if (listaMLATmodeS[j].TargetIdentification_decoded == TargetIdentification && listaMLATmodeS[j].TargetIdentification_decoded != "")
                            {
                                ListaPlanesMismoNombre.Add(listaMLATmodeS[j]);
                                listaNombresUsados.Add(TargetIdentification);
                            }

                            else if (listaMLATmodeS[j].TargetAdress_decoded == TargetAddress && listaMLATmodeS[j].TargetAdress_decoded != "")
                            {
                                ListaPlanesMismoNombre.Add(listaMLATmodeS[j]);
                                listaNombresUsados.Add(TargetAddress);
                            }
                            j = j + 1;
                        }

                        listadelistasdeavionesconmismonombre.Add(ListaPlanesMismoNombre);

                        int k = 0;
                        double AvgSeconds = 0;
                        int counter = 0;
                        while (k < ListaPlanesMismoNombre.Count - 1)
                        {
                            if (Math.Abs(ListaPlanesMismoNombre[k + 1].TimeofDay_seconds - ListaPlanesMismoNombre[k].TimeofDay_seconds) < 30) // si entre un report y otro hay +10s de diferencia asumimos que el vehiculo ha dejado de emitir y por tanto no cuenta como tiempo entre mensaje y mensaje
                            {
                                AvgSeconds = AvgSeconds + Math.Abs(ListaPlanesMismoNombre[k + 1].TimeofDay_seconds - ListaPlanesMismoNombre[k].TimeofDay_seconds);
                                counter = counter + 1;
                            }
                            k = k + 1;
                        }
                        AvgSeconds = AvgSeconds / counter;
                        listaAvgDelay.Add(AvgSeconds);

                        IndividualBar bar1 = new IndividualBar(TargetIdentification, TargetAddress, AvgSeconds);
                        listBarsUpdateRate.Add(bar1);
                    }
                }
                i = i + 1;
            }
        }

        private void pb_ProbabilityofUpdate_Click(object sender, EventArgs e)
        {
            //STAND
            double[] info_ProbabilityofUpdate_STAND = CalculateProbabilityofUpdateGROUND(listaMLAT_Stand);
            double found_STAND = info_ProbabilityofUpdate_STAND[0];
            double expected_STAND = info_ProbabilityofUpdate_STAND[1];
            double ProbabilityofUpdate_STAND = info_ProbabilityofUpdate_STAND[2];

            //APRON
            double[] info_ProbabilityofUpdate_APRON = CalculateProbabilityofUpdateGROUND(listaMLAT_Apron);
            double found_APRON = info_ProbabilityofUpdate_APRON[0];
            double expected_APRON = info_ProbabilityofUpdate_APRON[1];
            double ProbabilityofUpdate_APRON = info_ProbabilityofUpdate_APRON[2];

            //TAXI
            double[] info_ProbabilityofUpdate_TAXI = CalculateProbabilityofUpdateGROUND(listaMLAT_Taxiway);
            double found_TAXI = info_ProbabilityofUpdate_TAXI[0];
            double expected_TAXI = info_ProbabilityofUpdate_TAXI[1];
            double ProbabilityofUpdate_TAXI = info_ProbabilityofUpdate_TAXI[2];

            //RWY1
            double[] info_ProbabilityofUpdate_RWY1 = CalculateProbabilityofUpdateGROUND(listaRunway1);
            double found_RWY1 = info_ProbabilityofUpdate_RWY1[0];
            double expected_RWY1 = info_ProbabilityofUpdate_RWY1[1];
            double ProbabilityofUpdate_RWY1 = info_ProbabilityofUpdate_RWY1[2];

            //RWY2
            double[] info_ProbabilityofUpdate_RWY2 = CalculateProbabilityofUpdateGROUND(listaRunway2);
            double found_RWY2 = info_ProbabilityofUpdate_RWY2[0];
            double expected_RWY2 = info_ProbabilityofUpdate_RWY2[1];
            double ProbabilityofUpdate_RWY2 = info_ProbabilityofUpdate_RWY2[2];

            //RWY3
            double[] info_ProbabilityofUpdate_RWY3 = CalculateProbabilityofUpdateGROUND(listaRunway3);
            double found_RWY3 = info_ProbabilityofUpdate_RWY3[0];
            double expected_RWY3 = info_ProbabilityofUpdate_RWY3[1];
            double ProbabilityofUpdate_RWY3 = info_ProbabilityofUpdate_RWY3[2];

            //MA
            double[] info_ProbabilityofUpdate_MA = CalculateProbabilityofUpdateGROUND(listaMLAT_MA);
            double found_MA = info_ProbabilityofUpdate_MA[0];
            double expected_MA = info_ProbabilityofUpdate_MA[1];
            double ProbabilityofUpdate_MA = info_ProbabilityofUpdate_MA[2];

            //AIRBORNE
            List<List<CAT10>> Lista_listaMLAT_Airborne_2coma5NM = new List<List<CAT10>>();
            List<List<CAT10>> Lista_listaMLAT_Airborne_5NM = new List<List<CAT10>>();

            Lista_listaMLAT_Airborne_2coma5NM.Add(listaMLAT_Airborne_2coma5NM_L);
            Lista_listaMLAT_Airborne_2coma5NM.Add(listaMLAT_Airborne_2coma5NM_N);
            Lista_listaMLAT_Airborne_2coma5NM.Add(listaMLAT_Airborne_2coma5NM_P);
            Lista_listaMLAT_Airborne_2coma5NM.Add(listaMLAT_Airborne_2coma5NM_R);
            Lista_listaMLAT_Airborne_2coma5NM.Add(listaMLAT_Airborne_2coma5NM_T);
            Lista_listaMLAT_Airborne_2coma5NM.Add(listaMLAT_Airborne_2coma5NM_V);
            double[] info_ProbabilityofUpdateAirborne__2coma5NM = CalculateProbabilityofUpdateAIRBORNE(Lista_listaMLAT_Airborne_2coma5NM);
            double found_Airborne25 = info_ProbabilityofUpdateAirborne__2coma5NM[0];
            double expected_Airborne25 = info_ProbabilityofUpdateAirborne__2coma5NM[1];
            double ProbabilityofUpdate_Airborne25 = info_ProbabilityofUpdateAirborne__2coma5NM[2];

            Lista_listaMLAT_Airborne_5NM.Add(listaMLAT_Airborne_5NM_K);
            Lista_listaMLAT_Airborne_5NM.Add(listaMLAT_Airborne_5NM_M);
            Lista_listaMLAT_Airborne_5NM.Add(listaMLAT_Airborne_5NM_O);
            Lista_listaMLAT_Airborne_5NM.Add(listaMLAT_Airborne_5NM_Q);
            Lista_listaMLAT_Airborne_5NM.Add(listaMLAT_Airborne_5NM_S);
            Lista_listaMLAT_Airborne_5NM.Add(listaMLAT_Airborne_5NM_U);
            double[] info_ProbabilityofUpdateAirborne_5NM = CalculateProbabilityofUpdateAIRBORNE(Lista_listaMLAT_Airborne_5NM);
            double found_Airborne5 = info_ProbabilityofUpdateAirborne_5NM[0];
            double expected_Airborne5 = info_ProbabilityofUpdateAirborne_5NM[1];
            double ProbabilityofUpdate_Airborne5 = info_ProbabilityofUpdateAirborne_5NM[2];

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            dgv_ProbabilityofUpdate_fromASTERIXfile.ColumnCount = 6;
            dgv_ProbabilityofUpdate_fromASTERIXfile.Columns[0].Name = "Airport Zone";
            dgv_ProbabilityofUpdate_fromASTERIXfile.Columns[1].Name = "Expected Updates";
            dgv_ProbabilityofUpdate_fromASTERIXfile.Columns[2].Name = "Received Updates";
            dgv_ProbabilityofUpdate_fromASTERIXfile.Columns[3].Name = "Missing Updates";
            dgv_ProbabilityofUpdate_fromASTERIXfile.Columns[4].Name = "Probability of Update (%)";
            dgv_ProbabilityofUpdate_fromASTERIXfile.Columns[5].Name = "ED - 117 Value (%)";

            int n = dgv_ProbabilityofUpdate_fromASTERIXfile.Rows.Add("Airport Zone", "Expected Updates", "Received Updates", "Missing Updates", "Probability of Update (%)", "ED - 117 Value (%)");

            // STAND
            if (info_ProbabilityofUpdate_STAND.Count() > 0) 
            {
                string PU = info_ProbabilityofUpdate_STAND[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_ProbabilityofUpdate_fromASTERIXfile.Rows.Add("Stand", info_ProbabilityofUpdate_STAND[0], info_ProbabilityofUpdate_STAND[1], info_ProbabilityofUpdate_STAND[0] - info_ProbabilityofUpdate_STAND[1], PU, "50");
            }

            // APRON
            if (info_ProbabilityofUpdate_APRON.Count() > 0)
            {
                string PU = info_ProbabilityofUpdate_APRON[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_ProbabilityofUpdate_fromASTERIXfile.Rows.Add("Apron", info_ProbabilityofUpdate_APRON[0], info_ProbabilityofUpdate_APRON[1], info_ProbabilityofUpdate_APRON[0] - info_ProbabilityofUpdate_APRON[1], PU, "70");
            }

            // TAXI
            if (info_ProbabilityofUpdate_TAXI.Count() > 0)
            {
                string PU = info_ProbabilityofUpdate_TAXI[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_ProbabilityofUpdate_fromASTERIXfile.Rows.Add("Taxiway", info_ProbabilityofUpdate_TAXI[0], info_ProbabilityofUpdate_TAXI[1], info_ProbabilityofUpdate_TAXI[0] - info_ProbabilityofUpdate_TAXI[1], PU, "95");
            }

            // RWY1
            if (info_ProbabilityofUpdate_RWY1.Count() > 0)
            {
                string PU = info_ProbabilityofUpdate_RWY1[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_ProbabilityofUpdate_fromASTERIXfile.Rows.Add("Runway 02/20", info_ProbabilityofUpdate_RWY1[0], info_ProbabilityofUpdate_RWY1[1], info_ProbabilityofUpdate_RWY1[0] - info_ProbabilityofUpdate_RWY1[1], PU, "95");
            }

            // RWY2
            if (info_ProbabilityofUpdate_RWY2.Count() > 0)
            {
                string PU = info_ProbabilityofUpdate_RWY2[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_ProbabilityofUpdate_fromASTERIXfile.Rows.Add("Runway 07R/25L", info_ProbabilityofUpdate_RWY2[0], info_ProbabilityofUpdate_RWY2[1], info_ProbabilityofUpdate_RWY2[0] - info_ProbabilityofUpdate_RWY2[1], PU, "95");
            }

            // RWY3
            if (info_ProbabilityofUpdate_RWY3.Count() > 0)
            {
                string PU = info_ProbabilityofUpdate_RWY3[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_ProbabilityofUpdate_fromASTERIXfile.Rows.Add("Runway 07L/25R", info_ProbabilityofUpdate_RWY3[0], info_ProbabilityofUpdate_RWY3[1], info_ProbabilityofUpdate_RWY3[0] - info_ProbabilityofUpdate_RWY3[1], PU, "95");
            }

            // MA
            if (info_ProbabilityofUpdate_MA.Count() > 0)
            {
                string PU = info_ProbabilityofUpdate_MA[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_ProbabilityofUpdate_fromASTERIXfile.Rows.Add("MANEUVERING AREA", info_ProbabilityofUpdate_MA[0], info_ProbabilityofUpdate_MA[1], info_ProbabilityofUpdate_MA[0] - info_ProbabilityofUpdate_MA[1], PU, "95");
            }

            // AIRBORNE 2.5
            if (info_ProbabilityofUpdateAirborne__2coma5NM.Count() > 0)
            {
                string PU = info_ProbabilityofUpdateAirborne__2coma5NM[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_ProbabilityofUpdate_fromASTERIXfile.Rows.Add("AIRBORNE 0 - 2.5 NM", info_ProbabilityofUpdateAirborne__2coma5NM[0], info_ProbabilityofUpdateAirborne__2coma5NM[1], info_ProbabilityofUpdateAirborne__2coma5NM[0] - info_ProbabilityofUpdateAirborne__2coma5NM[1], PU, "95");
            }

            // AIRBORNE 5
            if (info_ProbabilityofUpdateAirborne_5NM.Count() > 0)
            {
                string PU = info_ProbabilityofUpdateAirborne_5NM[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_ProbabilityofUpdate_fromASTERIXfile.Rows.Add("AIRBORNE 2.5 - 5 NM", info_ProbabilityofUpdateAirborne_5NM[0], info_ProbabilityofUpdateAirborne_5NM[1], info_ProbabilityofUpdateAirborne_5NM[0] - info_ProbabilityofUpdateAirborne_5NM[1], PU, "95");
            }
        }

        private void bt_CalculatePRecissionAccuracy_Click(object sender, EventArgs e)
        {
            string[] mychars = { Convert.ToString(""), Convert.ToString(' '), Convert.ToString('\t') };
            string[] properties = comboBox1.Text.Split(mychars, StringSplitOptions.RemoveEmptyEntries);

            int PIC = Convert.ToInt32(properties[0]);

            //STAND
            ListResults_STAND = CalculatePrecissionAccuracy_fromnearestdistance(listaMLAT_Stand, listaCAT21nearAirport, PIC);

            // APRON
            ListResults_APRON = CalculatePrecissionAccuracy_fromnearestdistance(listaMLAT_Apron, listaCAT21nearAirport, PIC);


            // TAXI
            ListResults_TAXI = CalculatePrecissionAccuracy_fromnearestdistance(listaMLAT_Taxiway, listaCAT21nearAirport, PIC);


            // RUNWAY 1
            ListResults_RW1 = CalculatePrecissionAccuracy_fromnearestdistance(listaRunway1, listaCAT21nearAirport, PIC);


            // RUNWAY 2
            ListResults_RW2 = CalculatePrecissionAccuracy_fromnearestdistance(listaRunway2, listaCAT21nearAirport, PIC);


            // RUNWAY 3
            ListResults_RW3 = CalculatePrecissionAccuracy_fromnearestdistance(listaRunway3, listaCAT21nearAirport, PIC);


            //MA
            ListResults_MA_APRON = CalculatePrecissionAccuracy_fromnearestdistance(listaMLAT_MA, listaCAT21nearAirport, PIC);


            //airborne 2.5nm
            ListResults_AIRBORNE25 = CalculatePrecissionAccuracy_fromnearestdistance(listaMLAT_Airborne_2coma5NM, listaCAT21nearAirport, PIC);


            //airborne 5nm
            ListResults_AIRBORNE5 = CalculatePrecissionAccuracy_fromnearestdistance(listaMLAT_Airborne_2coma5NM, listaCAT21nearAirport, PIC);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Creamos DGV y columnas
            dgv_PrecissionAccuracy_fromASTERIXfile.ColumnCount = 8;
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[0].Name = "Airport Zone";
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[1].Name = "95th Percentile (m)";
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[2].Name = "ED-117 Value (m)";
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[3].Name = "99th Percentile (m)";
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[4].Name = "ED-117 Value (m)";
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[5].Name = "Mean (m)";
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[6].Name = "STD Deviation (m)";
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[7].Name = "Samples";
            // _EScribimos el nombre de las columnas otra vez para poder verlas en el excel
            int n = dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Add("Airport Zone", "95th Percentile (m)", "ED-117 Value (m)", "99th Percentile (m)", "ED-117 Value (m)", "Mean (m)", "STD Deviation (m)", "Samples");


            // STAND
            if (ListResults_STAND[0].Count() > 0)
            {
                ListResults_STAND[0].Sort();
                string p95 = CalculatePercentile(95, ListResults_STAND[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string average = ListResults_STAND[0].Average().ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string STDdeviation = CalculateStandardDeviation(ListResults_STAND[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));

                n = dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Add("STAND", p95, "20", "----------", "----------", average, STDdeviation, ListResults_STAND[0].Count().ToString());
            }

            // APRON
            if (ListResults_APRON[0].Count() > 0)
            {
                ListResults_APRON[0].Sort();
                string p95 = CalculatePercentile(95, ListResults_APRON[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string p99 = CalculatePercentile(99, ListResults_APRON[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string average = ListResults_APRON[0].Average().ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string STDdeviation = CalculateStandardDeviation(ListResults_APRON[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));

                n = dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Add("APRON", p95, "7.5", p99, "12", average, STDdeviation , ListResults_APRON[0].Count().ToString());
            }

            // TAXI
            if (ListResults_TAXI[0].Count() > 0)
            {
                ListResults_TAXI[0].Sort();
                string p95 = CalculatePercentile(95, ListResults_TAXI[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string p99 = CalculatePercentile(99, ListResults_TAXI[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string average = ListResults_TAXI[0].Average().ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string STDdeviation = CalculateStandardDeviation(ListResults_TAXI[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));

                n = dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Add("Taxiway", p95, "7.5", p99, "12", average, STDdeviation, ListResults_TAXI[0].Count().ToString());
            }

            // RW1
            if (ListResults_RW1[0].Count() > 0)
            {
                ListResults_RW1[0].Sort();
                string p95 = CalculatePercentile(95, ListResults_RW1[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string p99 = CalculatePercentile(99, ListResults_RW1[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string average = ListResults_RW1[0].Average().ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string STDdeviation = CalculateStandardDeviation(ListResults_RW1[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));

                n = dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Add("Runway 02/20", p95, "7.5", p99, "12", average, STDdeviation, ListResults_RW1[0].Count().ToString());
            }

            // RW2
            if (ListResults_RW2[0].Count() > 0)
            {
                ListResults_RW2[0].Sort();
                string p95 = CalculatePercentile(95, ListResults_RW2[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string p99 = CalculatePercentile(99, ListResults_RW2[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string average = ListResults_RW2[0].Average().ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string STDdeviation = CalculateStandardDeviation(ListResults_RW2[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));

                n = dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Add("Runway 07R/25L", p95, "7.5", p99, "12", average, STDdeviation , ListResults_RW2[0].Count().ToString());
            }

            // RW3
            if (ListResults_RW3[0].Count() > 0)
            {
                ListResults_RW3[0].Sort();
                string p95 = CalculatePercentile(95, ListResults_RW3[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string p99 = CalculatePercentile(99, ListResults_RW3[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string average = ListResults_RW3[0].Average().ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string STDdeviation = CalculateStandardDeviation(ListResults_RW3[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));

                n = dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Add("Runway 07L/25R", p95, "7.5", p99, "12", average, STDdeviation, ListResults_RW3[0].Count().ToString());
            }

            // MA
            if (ListResults_MA_APRON[0].Count() > 0)
            {
                ListResults_MA_APRON[0].Sort();
                string p95 = CalculatePercentile(95, ListResults_MA_APRON[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string p99 = CalculatePercentile(99, ListResults_MA_APRON[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string average = ListResults_MA_APRON[0].Average().ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string STDdeviation = CalculateStandardDeviation(ListResults_MA_APRON[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));

                n = dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Add("MANEUVERING AREA", p95, "7.5", p99, "12", average, STDdeviation, ListResults_MA_APRON[0].Count().ToString());
            }

            // AIRBORNE 0-2.5 NM
            if (ListResults_AIRBORNE25[0].Count() > 0)
            {
                ListResults_AIRBORNE25[0].Sort();
                string p95 = CalculatePercentile(95, ListResults_AIRBORNE25[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string average = ListResults_AIRBORNE25[0].Average().ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string STDdeviation = CalculateStandardDeviation(ListResults_AIRBORNE25[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));

                n = dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Add("AIRBORNE 0 - 2.5 NM", p95, "20", "----------", "----------", average, STDdeviation, ListResults_AIRBORNE25[0].Count().ToString());
            }

            // AIRBORNE 2.5-5 NM
            if (ListResults_AIRBORNE5[0].Count() > 0)
            {
                ListResults_AIRBORNE5[0].Sort();
                string p95 = CalculatePercentile(95, ListResults_AIRBORNE5[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string average = ListResults_AIRBORNE5[0].Average().ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string STDdeviation = CalculateStandardDeviation(ListResults_AIRBORNE5[0]).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));

                n = dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Add("AIRBORNE 2.5 - 5 NM", p95, "20", "----------", "----------", average, STDdeviation, ListResults_AIRBORNE5[0].Count().ToString());
            }
        }

        private void bt_ShowData_PA_fromASTERIXfile_Click(object sender, EventArgs e)
        {

            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Excel.Application aplicacion;
                Excel.Workbook libros_trabajo;
                Excel.Worksheet hoja_trabajo;
                aplicacion = new Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo = (Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo

                int rows = 0;

                hoja_trabajo.Cells[rows + 1, 0 + 1] = "PROBABILITY OF UPDATE:";
                rows = rows + 2;

                for (int i = 0; i < dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv_ProbabilityofUpdate_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_ProbabilityofUpdate_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }
                rows = rows + 5;

                hoja_trabajo.Cells[rows + 1, 0 + 1] = "PRECISSIUON ACCURACY:";
                rows = rows + 2;

                for (int i = 0; i < dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv_PrecissionAccuracy_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_PrecissionAccuracy_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }
                rows = rows + 5;

                hoja_trabajo.Cells[rows + 1, 0 + 1] = "PROBABILITY OF MLAT DETECTION:";
                rows = rows + 2;

                for (int i = 0; i < dgv_ProbabilityofMLATDetection_fromASTERIXfile.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv_ProbabilityofMLATDetection_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_ProbabilityofMLATDetection_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }
                rows = rows + 5;

                hoja_trabajo.Cells[rows + 1, 0 + 1] = "PROBABILITY OF MLAT IDENTIFICATION:";
                rows = rows + 2;

                for (int i = 0; i < dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }



                libros_trabajo.SaveAs(fichero.FileName,
                Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }

            //SaveFileDialog fichero = new SaveFileDialog();
            //fichero.Filter = "Excel (*.xls)|*.xls";
            //if (fichero.ShowDialog() == DialogResult.OK)
            //{
            //    Excel.Application aplicacion;
            //    Excel.Workbook libros_trabajo;
            //    Excel.Worksheet hoja_trabajo;
            //    aplicacion = new Excel.Application();
            //    libros_trabajo = aplicacion.Workbooks.Add();
            //    hoja_trabajo = (Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
            //    Recorremos el DataGridView rellenando la hoja de trabajo
            //    for (int i = 0; i < dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Count - 1; i++)
            //    {
            //        for (int j = 0; j < dgv_PrecissionAccuracy_fromASTERIXfile.Columns.Count; j++)
            //        {
            //            hoja_trabajo.Cells[i + 1, j + 1] = dgv_PrecissionAccuracy_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }
            //    libros_trabajo.SaveAs(fichero.FileName,
            //    Excel.XlFileFormat.xlWorkbookNormal);
            //    libros_trabajo.Close(true);
            //    aplicacion.Quit();
            //}

            // SHOW Plots:
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //ScatterPlot PA_STAND_fromASTERIXfile = new ScatterPlot(ListResults_STAND[1], ListResults_STAND[2], "Precission Acuracy Error in Stand", "X axis Error (m)", "Y axis Error (m)");
            //PA_STAND_fromASTERIXfile.Show();

            //ScatterPlot PA_MA_fromASTERIXfile = new ScatterPlot(ListResults_MA_APRON[1], ListResults_MA_APRON[2], "Precission Acuracy Error in Manoeuvring Area", "X axis Error (m)", "Y axis Error (m)");
            //PA_MA_fromASTERIXfile.Show();

            //ScatterPlot PA_AIRBORNE25_fromASTERIXfile = new ScatterPlot(ListResults_AIRBORNE25[1], ListResults_AIRBORNE25[2], "Precission Acuracy Error in Airborne Area (0 - 2.5 NM)", "X axis Error (m)", "Y axis Error (m)");
            //PA_AIRBORNE25_fromASTERIXfile.Show();

            //ScatterPlot PA_AIRBORNE5_fromASTERIXfile = new ScatterPlot(ListResults_AIRBORNE5[1], ListResults_AIRBORNE5[2], "Precission Acuracy Error in Airborne Area (2.5 NM - 5 NM)", "X axis Error (m)", "Y axis Error (m)");
            //PA_AIRBORNE5_fromASTERIXfile.Show();

            // SHOW Plots:
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            DataGrid_PositionAcuracy_fromASTERIXfile DGV1 = new DataGrid_PositionAcuracy_fromASTERIXfile(ListResults_STAND, ListResults_APRON, ListResults_TAXI, ListResults_RW1, ListResults_RW2, ListResults_RW3, ListResults_MA_APRON, ListResults_AIRBORNE25, ListResults_AIRBORNE5);
            DGV1.Show();


        }

        private void bt_CalculateProbabilityofMLATDetection_Click(object sender, EventArgs e)
        {
            //STAND
            double[] info_probabilityofMLATDetection_STAND = CalculateProbabilityofMLATDetection(listaMLAT_Stand, 5);
            double found_STAND = info_probabilityofMLATDetection_STAND[0];
            double total_STAND = info_probabilityofMLATDetection_STAND[1];
            double probabilityofMLATDetection_STAND = info_probabilityofMLATDetection_STAND[2];

            // taxi
            double[] info_probabilityofMLATDetection_MA = CalculateProbabilityofMLATDetection(listaMLAT_Taxiway, 2);

            // RWY1
            double[] info_probabilityofMLATDetection_RWY1 = CalculateProbabilityofMLATDetection(listaRunway1, 2);

            // RWY2
            double[] info_probabilityofMLATDetection_RWY2 = CalculateProbabilityofMLATDetection(listaRunway2, 2);

            // RWY3
            double[] info_probabilityofMLATDetection_RWY3 = CalculateProbabilityofMLATDetection(listaRunway3, 2);

            // MA
            double[] info_probabilityofMLATDetection_APRON = CalculateProbabilityofMLATDetection(listaMLAT_MA, 2);
            double found_MA = info_probabilityofMLATDetection_MA[0];
            double total_MA = info_probabilityofMLATDetection_MA[1];
            double probabilityofMLATDetection_MA = info_probabilityofMLATDetection_MA[2];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            dgv_ProbabilityofMLATDetection_fromASTERIXfile.ColumnCount = 6;
            dgv_ProbabilityofMLATDetection_fromASTERIXfile.Columns[0].Name = "Airport Zone";
            dgv_ProbabilityofMLATDetection_fromASTERIXfile.Columns[1].Name = "Expected Updates";
            dgv_ProbabilityofMLATDetection_fromASTERIXfile.Columns[2].Name = "Received Updates";
            dgv_ProbabilityofMLATDetection_fromASTERIXfile.Columns[3].Name = "Missing Updates";
            dgv_ProbabilityofMLATDetection_fromASTERIXfile.Columns[4].Name = "Probability of MLAT Detection (%)";
            dgv_ProbabilityofMLATDetection_fromASTERIXfile.Columns[5].Name = "ED - 117 Value (%)";

            int n = dgv_ProbabilityofMLATDetection_fromASTERIXfile.Rows.Add("Airport Zone", "Expected Updates", "Received Updates", "Missing Updates", "Probability of MLAT Detection (%)", "ED - 117 Value (%)");

            // STAND
            if (info_probabilityofMLATDetection_STAND.Count() > 0)
            {
                string PU = info_probabilityofMLATDetection_STAND[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_ProbabilityofMLATDetection_fromASTERIXfile.Rows.Add("Stand", info_probabilityofMLATDetection_STAND[1], info_probabilityofMLATDetection_STAND[0], info_probabilityofMLATDetection_STAND[1] - info_probabilityofMLATDetection_STAND[0], PU, "99.9");
            }

            // APRON
            if (info_probabilityofMLATDetection_APRON.Count() > 0)
            {
                string PU = info_probabilityofMLATDetection_APRON[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_ProbabilityofMLATDetection_fromASTERIXfile.Rows.Add("Apron", info_probabilityofMLATDetection_APRON[1], info_probabilityofMLATDetection_APRON[0], info_probabilityofMLATDetection_APRON[1] - info_probabilityofMLATDetection_APRON[0], PU, "99.9");
            }

            // RWY1
            if (info_probabilityofMLATDetection_RWY1.Count() > 0)
            {
                string PU = info_probabilityofMLATDetection_RWY1[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_ProbabilityofMLATDetection_fromASTERIXfile.Rows.Add("Runway 02/20", info_probabilityofMLATDetection_RWY1[1], info_probabilityofMLATDetection_RWY1[0], info_probabilityofMLATDetection_RWY1[1] - info_probabilityofMLATDetection_RWY1[0], PU, "99.9");
            }

            // RWY2
            if (info_probabilityofMLATDetection_RWY2.Count() > 0)
            {
                string PU = info_probabilityofMLATDetection_RWY2[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_ProbabilityofMLATDetection_fromASTERIXfile.Rows.Add("Runway 07R/25L", info_probabilityofMLATDetection_RWY2[1], info_probabilityofMLATDetection_RWY2[0], info_probabilityofMLATDetection_RWY2[1] - info_probabilityofMLATDetection_RWY2[0], PU, "99.9");
            }

            // RWY3
            if (info_probabilityofMLATDetection_RWY3.Count() > 0)
            {
                string PU = info_probabilityofMLATDetection_RWY3[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_ProbabilityofMLATDetection_fromASTERIXfile.Rows.Add("Runway 07L/25R", info_probabilityofMLATDetection_RWY3[1], info_probabilityofMLATDetection_RWY3[0], info_probabilityofMLATDetection_RWY3[1] - info_probabilityofMLATDetection_RWY3[0], PU, "99.9");
            }

            // RWY3
            if (info_probabilityofMLATDetection_MA.Count() > 0)
            {
                string PU = info_probabilityofMLATDetection_MA[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_ProbabilityofMLATDetection_fromASTERIXfile.Rows.Add("MANEUVERING AREA", info_probabilityofMLATDetection_MA[1], info_probabilityofMLATDetection_MA[0], info_probabilityofMLATDetection_MA[1] - info_probabilityofMLATDetection_MA[0], PU, "99.9");
            }
        }

        private void bt_ProbabilityofMLATIdentification_Click(object sender, EventArgs e)
        {
            List<double> listofProbabilityofIdentification = CalculateProbabilityofIdentification(listaMLATmodeS);
            double ProbabilityofIdentifcation = listofProbabilityofIdentification.Average() * 100;


            dgv_ProbabilityofMLATIdentification_fromASTERIXfile.ColumnCount = 6;
            dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Columns[0].Name = "Airport Zone";
            dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Columns[1].Name = "Expected Updates";
            dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Columns[2].Name = "Received Updates";
            dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Columns[3].Name = "Missing Updates";
            dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Columns[4].Name = "Probability of Update (%)";
            dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Columns[5].Name = "ED - 117 Value (%)";

            int n = dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Rows.Add("Airport Zone", "Expected Updates", "Received Updates", "Missing Updates", "Probability of Update (%)", "ED - 117 Value (%)");

            // Stand
            List<double> listofProbabilityofIdentification_STAND = CalculateProbabilityofIdentification(listaMLAT_Stand);
            if (listofProbabilityofIdentification_STAND[1] > 0) 
            {
                string PU = listofProbabilityofIdentification_STAND[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Rows.Add("Stand", listofProbabilityofIdentification_STAND[1].ToString(), listofProbabilityofIdentification_STAND[0].ToString(), (listofProbabilityofIdentification_STAND[1] - listofProbabilityofIdentification_STAND[0]).ToString(), PU, "99.9");
            }

            // Apron
            List<double> listofProbabilityofIdentification_APRON = CalculateProbabilityofIdentification(listaMLAT_Apron);
            if (listofProbabilityofIdentification_APRON[1] > 0)
            {
                string PU = listofProbabilityofIdentification_APRON[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Rows.Add("Apron", listofProbabilityofIdentification_APRON[1].ToString(), listofProbabilityofIdentification_APRON[0].ToString(), (listofProbabilityofIdentification_APRON[1] - listofProbabilityofIdentification_APRON[0]).ToString(), PU, "99.9");
            }

            // Taxiway
            List<double> listofProbabilityofIdentification_TAXI = CalculateProbabilityofIdentification(listaMLAT_Taxiway);
            if (listofProbabilityofIdentification_TAXI[1] > 0)
            {
                string PU = listofProbabilityofIdentification_TAXI[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Rows.Add("Apron", listofProbabilityofIdentification_TAXI[1].ToString(), listofProbabilityofIdentification_TAXI[0].ToString(), (listofProbabilityofIdentification_TAXI[1] - listofProbabilityofIdentification_TAXI[0]).ToString(), PU, "99.9");
            }

            // RWY1
            List<double> listofProbabilityofIdentification_RWY1 = CalculateProbabilityofIdentification(listaRunway1);
            if (listofProbabilityofIdentification_TAXI[1] > 0)
            {
                string PU = listofProbabilityofIdentification_TAXI[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Rows.Add("Runway 02/20", listofProbabilityofIdentification_TAXI[1].ToString(), listofProbabilityofIdentification_TAXI[0].ToString(), (listofProbabilityofIdentification_TAXI[1] - listofProbabilityofIdentification_TAXI[0]).ToString(), PU, "99.9");
            }

            // RWY2
            List<double> listofProbabilityofIdentification_RWY2 = CalculateProbabilityofIdentification(listaRunway2);
            if (listofProbabilityofIdentification_RWY2[1] > 0)
            {
                string PU = listofProbabilityofIdentification_RWY2[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Rows.Add("Runway 07R/25L", listofProbabilityofIdentification_RWY2[1].ToString(), listofProbabilityofIdentification_RWY2[0].ToString(), (listofProbabilityofIdentification_RWY2[1] - listofProbabilityofIdentification_RWY2[0]).ToString(), PU, "99.9");
            }

            // RWY3
            List<double> listofProbabilityofIdentification_RWY3 = CalculateProbabilityofIdentification(listaRunway3);
            if (listofProbabilityofIdentification_RWY3[1] > 0)
            {
                string PU = listofProbabilityofIdentification_RWY3[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Rows.Add("Runway 07l/25r", listofProbabilityofIdentification_RWY3[1].ToString(), listofProbabilityofIdentification_RWY3[0].ToString(), (listofProbabilityofIdentification_RWY3[1] - listofProbabilityofIdentification_RWY3[0]).ToString(), PU, "99.9");
            }

            // MA
            List<double> listofProbabilityofIdentification_MA    = CalculateProbabilityofIdentification(listaMLAT_MA);
            if (listofProbabilityofIdentification_MA[1] > 0)
            {
                string PU = listofProbabilityofIdentification_MA[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Rows.Add("MANEUVERING AREA", listofProbabilityofIdentification_MA[1].ToString(), listofProbabilityofIdentification_MA[0].ToString(), (listofProbabilityofIdentification_MA[1] - listofProbabilityofIdentification_MA[0]).ToString(), PU, "99.9");
            }

            // AIRBORNE 2.5 NM
            List<double> listofProbabilityofIdentification_AIRBORNE25 = CalculateProbabilityofIdentification(listaMLAT_Airborne_2coma5NM);
            if (listofProbabilityofIdentification_AIRBORNE25[1] > 0)
            {
                string PU = listofProbabilityofIdentification_AIRBORNE25[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Rows.Add("AIRBORNE 0 - 2.5 NM", listofProbabilityofIdentification_AIRBORNE25[1].ToString(), listofProbabilityofIdentification_AIRBORNE25[0].ToString(), (listofProbabilityofIdentification_AIRBORNE25[1] - listofProbabilityofIdentification_AIRBORNE25[0]).ToString(), PU, "99.9");
            }

            // AIRBORNE 5 NM
            List<double> listofProbabilityofIdentification_AIRBORNE5 = CalculateProbabilityofIdentification(listaMLAT_Airborne_5NM);
            if (listofProbabilityofIdentification_AIRBORNE5[1] > 0)
            {
                string PU = listofProbabilityofIdentification_AIRBORNE5[2].ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                dgv_ProbabilityofMLATIdentification_fromASTERIXfile.Rows.Add("AIRBORNE 2.5 - 5 NM", listofProbabilityofIdentification_AIRBORNE5[1].ToString(), listofProbabilityofIdentification_AIRBORNE5[0].ToString(), (listofProbabilityofIdentification_AIRBORNE5[1] - listofProbabilityofIdentification_AIRBORNE5[0]).ToString(), PU, "99.9");
            }
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Parametros ED-117 de un archivo Calibration Vehicle

        private void pb_ProbabilityofUpdate_ED117_CalibrationVehicle_Click(object sender, EventArgs e)
        {
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public double[] MLATcoordinates2WGS84(CAT10 packet)
        {
            double[] coordenadesMLAT_WGS84 = new double[2];

            if (packet.PositioninCartesianCoordinates.Length > 0)
            {
                double coordX = packet.X_cartesian;
                double coordY = packet.Y_cartesian;

                double rho = Math.Sqrt(coordX * coordX + coordY * coordY);
                double theta = (180 / Math.PI) * Math.Atan2(coordX, coordY);

                coordenadesMLAT_WGS84 = NewCoordinatesMLAT(rho, theta);
            }
            else
            {
                double rho = packet.Rho;
                double theta = packet.TrackAngle;

                coordenadesMLAT_WGS84 = NewCoordinatesMLAT(rho, theta);
            }

            return coordenadesMLAT_WGS84;
        }

        public double[] CoordinatesADSB_WGS84(CAT21 packet)
        {
            double[] coordenadasADSB = new double[2];

            if (packet.PositioninWGS_HRcoordinates.Length > 0)
            {
                coordenadasADSB[0] = packet.latWGS84_HR;
                coordenadasADSB[1] = packet.lonWGS84_HR;
            }
            else
            {
                coordenadasADSB[0] = packet.latWGS84;
                coordenadasADSB[1] = packet.lonWGS84;
            }

            return coordenadasADSB;
        }

        public double toRadians(double grados)
        {
            return grados * Math.PI / 180;
        }

        public double toDegrees(double radians)
        {
            return radians * 180 / (Math.PI);
        }

        public double[] NewCoordinates(double[] coordinates, double distance, double initialBearing)
        {
            double[] listaCoordenadas = new double[2];

            double φ1 = toRadians(coordinates[0]);
            double λ1 = toRadians(coordinates[1]);
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

        public double[] NewCoordinatesMLAT(double distance, double initialBearing)
        {
            double[] listaCoordenadas = new double[2];

            double φ1 = toRadians(LatMLAT);
            double λ1 = toRadians(LonMLAT);
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

        public double[] NewCoordinatesADSB(double[] coordenadasADSB, double distance, double initialBearing)
        {
            double[] listaCoordenadas = new double[2];

            double φ1 = toRadians(coordenadasADSB[0]);
            double λ1 = toRadians(coordenadasADSB[1]);
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
            } while (Math.Abs(lambda - lambdaP) > 1e-20 && --iterLimit > 0);

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

        public GMapOverlay PlotListadePaquetesenOverlayMLAT(List<CAT10> listaMLATmodeS, Bitmap blue_plane)
        {
            GMapOverlay overlayLoad = new GMapOverlay();
            overlayLoad.Clear();

            int i = 0;
            while (i < listaMLATmodeS.Count())
            {
                if (listaMLATmodeS[i].MeasuredPositioninPolarCoordinates.Length == 0 && listaMLATmodeS[i].PositioninCartesianCoordinates.Length > 0) // si no tenemos coordenadas polares pero si coordenadas cartesianas
                {
                    double rho = Math.Sqrt((listaMLATmodeS[i].X_cartesian) * (listaMLATmodeS[i].X_cartesian) + (listaMLATmodeS[i].Y_cartesian) * (listaMLATmodeS[i].Y_cartesian));
                    double theta = (180 / Math.PI) * Math.Atan2(listaMLATmodeS[i].X_cartesian, listaMLATmodeS[i].Y_cartesian);

                    double[] coordenadas = NewCoordinatesMLAT(rho, theta);
                    var marker = new GMarkerGoogle(new PointLatLng(coordenadas[0], coordenadas[1]), blue_plane);

                    if (listaMLATmodeS[i].TOT == "Ground Vehicle." || listaMLATmodeS[i].Mode3ACodeinOctal.Length == 0)
                    {
                        marker = new GMarkerGoogle(new PointLatLng(coordenadas[0], coordenadas[1]), blue_plane);
                        overlayLoad.Markers.Add(marker);
                        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    }
                    else
                    {
                        marker = new GMarkerGoogle(new PointLatLng(coordenadas[0], coordenadas[1]), blue_plane);
                        overlayLoad.Markers.Add(marker);
                        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    }

                    marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    if (listaMLATmodeS[i].TargetIdentification.Length > 0 && Convert.ToInt64(listaMLATmodeS[i].TargetIdentification, 2) > 1 && listaMLATmodeS[i].CalculatedTrackVelocityinPolarCoordinates.Length > 0) { marker.ToolTipText = string.Concat("Target Identification: ", listaMLATmodeS[i].TargetIdentification_decoded, " Speed:", listaMLATmodeS[i].GroundSpeed * 1852 * 3.6); }
                    else if (listaMLATmodeS[i].TargetIdentification.Length > 0 && Convert.ToInt64(listaMLATmodeS[i].TargetIdentification, 2) > 1) { marker.ToolTipText = string.Concat("Target Identification: ", listaMLATmodeS[i].TargetIdentification_decoded); }

                    else if (listaMLATmodeS[i].TargetAdress.Length > 0 && listaMLATmodeS[i].CalculatedTrackVelocityinPolarCoordinates.Length > 0 && listaMLATmodeS[i].CalculatedTrackVelocityinPolarCoordinates.Length > 0) { marker.ToolTipText = string.Concat("Target Address: ", listaMLATmodeS[i].TargetAdress_decoded, " Speed:", listaMLATmodeS[i].GroundSpeed * 1852 * 3.6); }
                    else if (listaMLATmodeS[i].TargetAdress.Length > 0) { marker.ToolTipText = string.Concat("Target Address: ", listaMLATmodeS[i].TargetAdress_decoded); }

                    else if (listaMLATmodeS[i].TrackNumber.Length > 0 && listaMLATmodeS[i].CalculatedTrackVelocityinPolarCoordinates.Length > 0 && listaMLATmodeS[i].CalculatedTrackVelocityinPolarCoordinates.Length > 0) { marker.ToolTipText = string.Concat("Track Number: ", listaMLATmodeS[i].Tracknumber_value, " Speed:", listaMLATmodeS[i].GroundSpeed * 1852 * 3.6); }
                    else if (listaMLATmodeS[i].TrackNumber.Length > 0) { marker.ToolTipText = string.Concat("Track Number: ", listaMLATmodeS[i].Tracknumber_value); }

                    overlayLoad.Markers.Add(marker);
                }
                i = i + 1;
            }

            return overlayLoad;
        }

        public List<CAT21> FilterCAT21packets(List<CAT21> listaCAT21)
        {
            List<CAT21> lista_aviones_filtrados = new List<CAT21>();
            lista_aviones_filtrados.Clear();

            var polygonA = new GMapPolygon(polygonApoints, "PolygonA")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };

            var polygonC = new GMapPolygon(polygonCpoints, "PolygonC")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };

            var polygonD = new GMapPolygon(polygonDpoints, "PolygonD")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };

            var polygonE = new GMapPolygon(polygonEpoints, "PolygonE")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };

            var polygonF = new GMapPolygon(polygonFpoints, "PolygonF")
            {
                Stroke = new Pen(Color.Yellow, 2),
                Fill = new SolidBrush(Color.Yellow)
            };

            var polygonG = new GMapPolygon(polygonGpoints, "PolygonG")
            {
                Stroke = new Pen(Color.Yellow, 2),
                Fill = new SolidBrush(Color.Yellow)
            };

            var polygonH = new GMapPolygon(polygonHpoints, "PolygonH")
            {
                Stroke = new Pen(Color.Yellow, 2),
                Fill = new SolidBrush(Color.Yellow)
            };

            var polygonB = new GMapPolygon(polygonBpoints, "PolygonB")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };

            var polygonI = new GMapPolygon(polygonIpoints, "PolygonI")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Green)
            };

            var polygonJ = new GMapPolygon(polygonJpoints, "PolygonJ")
            {
                Stroke = new Pen(Color.Red, 2),
                Fill = new SolidBrush(Color.Red)
            };

            var polygonK = new GMapPolygon(polygonKpoints, "PolygonK")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };

            var polygonL = new GMapPolygon(polygonLpoints, "PolygonL")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };

            var polygonM = new GMapPolygon(polygonMpoints, "PolygonM")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };

            var polygonN = new GMapPolygon(polygonNpoints, "PolygonN")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };

            var polygonO = new GMapPolygon(polygonOpoints, "PolygonO")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };

            var polygonP = new GMapPolygon(polygonPpoints, "PolygonP")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };

            var polygonQ = new GMapPolygon(polygonQpoints, "PolygonQ")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };

            var polygonR = new GMapPolygon(polygonRpoints, "PolygonR")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };

            var polygonS = new GMapPolygon(polygonSpoints, "PolygonS")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };

            var polygonT = new GMapPolygon(polygonTpoints, "PolygonT")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };

            var polygonU = new GMapPolygon(polygonUpoints, "PolygonU")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };

            var polygonV = new GMapPolygon(polygonVpoints, "PolygonV")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };

            var polygonW = new GMapPolygon(polygonWpoints, "PolygonW")
            {
                Stroke = new Pen(Color.White, 2),
                Fill = new SolidBrush(Color.White)
            };

            var polygonX = new GMapPolygon(polygonXpoints, "PolygonX")
            {
                Stroke = new Pen(Color.White, 2),
                Fill = new SolidBrush(Color.White)
            };

            var polygonY = new GMapPolygon(polygonYpoints, "PolygonY")
            {
                Stroke = new Pen(Color.White, 2),
                Fill = new SolidBrush(Color.White)
            };

            i = 0;
            while (i < listaCAT21.Count)
            {
                double[] coordenadas = CoordinatesADSB_WGS84(listaCAT21[i]);

                // Todos los paquetes que pasan por aqui tienen coordenadas convertidas a wgs84 y info de la velocidad en coordenadas polares
                // Ahora comprobamos si el paquete de turno esta en alguna zona del aeropuerto
                bool insideA = polygonA.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideB = polygonB.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideC = polygonC.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideD = polygonD.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideE = polygonE.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideF = polygonF.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideG = polygonG.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideH = polygonH.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideI = polygonI.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideJ = polygonJ.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideK = polygonK.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideL = polygonL.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideM = polygonM.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideN = polygonN.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideO = polygonO.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideP = polygonP.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideQ = polygonQ.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideR = polygonR.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideS = polygonS.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideT = polygonT.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideU = polygonU.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideV = polygonV.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideW = polygonW.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideX = polygonX.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                bool insideY = polygonY.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));

                if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) + (insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0)
                     + (insideI ? 1 : 0) /*+ (insideJ? 1:0)*/ + (insideK ? 1 : 0) + (insideL ? 1 : 0) + (insideM ? 1 : 0) + (insideN ? 1 : 0) + (insideO ? 1 : 0) + (insideP ? 1 : 0)
                      + (insideQ ? 1 : 0) + (insideR ? 1 : 0) + (insideS ? 1 : 0) + (insideT ? 1 : 0) + (insideU ? 1 : 0) + (insideV ? 1 : 0) + (insideW ? 1 : 0) + (insideX ? 1 : 0)
                       + (insideY ? 1 : 0) > 0) { lista_aviones_filtrados.Add(listaCAT21[i]); }



                i = i + 1;
            }
            return lista_aviones_filtrados;
        }

        public List<double> CalculateListaSecondsMLAT(List<CAT10> listaMLAT)
        {
            List<double> listasecondsMLAT = new List<double>();

            double sec = Convert.ToInt32(Math.Floor(Convert.ToDouble(listaMLAT[0].TimeofDay_seconds)));
            listasecondsMLAT.Add(sec);

            int i = 1;
            while (i < listaMLAT.Count)
            {
                int second = Convert.ToInt32(Math.Floor(Convert.ToDouble(listaMLAT[i].TimeofDay_seconds)));
                if (second > listasecondsMLAT.Last())
                {
                    listasecondsMLAT.Add(second);
                }
                i = i + 1;
            }

            return listasecondsMLAT;
        }

        public List<double> CalculateListaSecondsMLATporNombre(string nombre, List<CAT10> listaMLAT)
        {
            var listasecondsMLAT = CalculateListaSecondsMLAT(listaMLAT);

            List<double> lista = new List<double>();
            List<double> listaquedevolvemos = new List<double>();

            int i = 0;
            while (i < listaMLAT.Count)
            {
                if (listaMLAT[i].TYP == "Mode S multilateration.")
                {
                    lista.Add(listaMLAT[i].TimeofDay_seconds);
                }
                i = i + 1;
            }

            i = 0;
            while (i < listaMLAT.Count)
            {
                double second = listaMLAT[i].TimeofDay_seconds;
                if (listaMLAT[i].TargetAdress.Length > 0 && listaMLAT[i].TargetAdress_decoded == nombre)
                {
                    listaquedevolvemos.Add(second);
                }
                i = i + 1;
            }

            return listaquedevolvemos;
        }

        public double CalculateStandardDeviation(IEnumerable<double> values)
        {
            double standardDeviation = 0;

            if (values.Any())
            {
                // Compute the average.     
                double avg = values.Average();

                // Perform the Sum of (value-avg)_2_2.      
                double sum = values.Sum(d => Math.Pow(d - avg, 2));

                // Put it all together.      
                standardDeviation = Math.Sqrt((sum) / (values.Count() - 1));
            }

            return standardDeviation;
        }

        public double CalculatePercentile(int perc, List<double> lista)
        {
            double percentile = Convert.ToDouble(perc);
            percentile = percentile / 100;

            int posicion_inferior = Convert.ToInt32(Math.Floor(lista.Count() * percentile));
            int posicion_superior = Convert.ToInt32(Math.Ceiling(lista.Count() * percentile));

            try
            {
                return (lista[posicion_inferior] + lista[posicion_superior]) / 2;
            }
            catch
            {
                return lista[posicion_inferior - 1];
            }
        }

        public double[] CalculateComponentesDistancia(double[] CoordenadasMLAT, double[] CoordenadasADSB)
        {
            double LatMLAT = CoordenadasMLAT[0];
            double LonMLAT = CoordenadasMLAT[1];

            double LatADSB = CoordenadasADSB[0];
            double LonADSB = CoordenadasADSB[1];

            double deltaX = CalculateDistanceBetweenCoordinates(new double[] { LatMLAT, LonADSB }, CoordenadasMLAT);
            double deltaY = CalculateDistanceBetweenCoordinates(new double[] { LatADSB, LonMLAT }, CoordenadasMLAT);

            if (LatADSB >= LatMLAT && LonADSB>=LonMLAT)
            {
                // No hacemos nada porque las dos componentes son positivas ya
            }

            else if(LonADSB>=LonMLAT && LatADSB < LatMLAT)
            {
                deltaY = -1 * deltaY;
            }

            else if (LonADSB < LonMLAT && LatADSB >= LatMLAT)
            {
                deltaX = -1 * deltaX;
            }
            else if(LonADSB<LonMLAT && LatADSB < LatMLAT)
            {
                deltaY = -1 * deltaY;
                deltaX = -1 * deltaX;
            }

            double[] results = new double[] { deltaX, deltaY };
            return results;
        }



        public double[] CalculateProbabilityofUpdateGROUND(List<CAT10> listaMLAT_Apron)
        {
            List<CAT10> ListaMLAT = new List<CAT10>();
            List<string> listaNombresUsados = new List<string>();
            List<double> listaaverages111 = new List<double>();

            double contadorTrue = 0;
            double contadorTotal = 0;

            ListaMLAT.AddRange(listaMLAT_Apron);

            for (int s = 0; s < ListaMLAT.Count(); s++)
            {
                string name = ListaMLAT[s].TargetAdress_decoded;
                if (listaNombresUsados.Contains(name) == false && name != "")
                {
                    listaNombresUsados.Add(name);
                }
                s = s + 1;
            }

            int i = 0;
            for (i = 0; i < listaNombresUsados.Count(); i++) // Bucle que vaya avion por avion
            {
                // primero sacamosel nombre de ese avion
                string nombre = listaNombresUsados[i];

                //Ahora sacamos su segundo maximo y su segundo minimo de ese avion
                var lista_seconds_de_este_avion = CalculateListaSecondsMLATporNombre(nombre, ListaMLAT);

                if (lista_seconds_de_este_avion.Count > 1)
                {
                    double secondinicial = lista_seconds_de_este_avion.Min();
                    double secondfinal = lista_seconds_de_este_avion.Max();
                    double secondactual = lista_seconds_de_este_avion[1];

                    int counter_bien = 0;
                    int counter_total = 0;

                    //Bucle que pase pr todos los segundos y compruebe que entre un mensaje y otro hay 1 seg como max
                    int j = 1;
                    while (j < lista_seconds_de_este_avion.Count)
                    {
                        if (lista_seconds_de_este_avion[j] - lista_seconds_de_este_avion[j - 1] <= 1)
                        {
                            counter_bien = counter_bien + 1;
                        }
                        j = j + 1;
                        counter_total = counter_total + 1;
                    }

                    contadorTrue = contadorTrue + counter_bien;
                    contadorTotal = contadorTotal + counter_total;

                    listaaverages111.Add((counter_bien) / Convert.ToDouble(counter_total));
                }
            }

            double[] values = new double[3] { contadorTrue, contadorTotal, listaaverages111.Average() * 100 };
            return values;
        }

        public double CalculateProbabilityofUpdateGROUND1(List<CAT10> listaMLAT_Apron)
        {
            List<CAT10> ListaMLAT = new List<CAT10>();
            ListaMLAT.AddRange(listaMLAT_Apron);

            List<CAT10> lista1 = new List<CAT10>();
            for (int k = 0; k < ListaMLAT.Count(); k++)
            {
                if (ListaMLAT[k].TargetAdress.Length != 0 && listaMLAT[k].TargetAdress_decoded != "") { lista1.Add(ListaMLAT[k]); }
            }
            ListaMLAT.Clear();
            for (int k = 0; k < lista1.Count; k++) { ListaMLAT.Add(lista1[k]); }


            // Apron

            List<string> listaNombresUsados_Apron = new List<string>();
            List<double> listaAvgDelay_Apron = new List<double>();

            double counterbuenos = 0;
            double countertotales = 0;

            int i = 0;
            while (i < ListaMLAT.Count)
            {
                string TargetAddress = ListaMLAT[i].TargetAdress_decoded;

                if (listaNombresUsados_Apron.Contains(TargetAddress)) // si Target Address y/o Target Identification estan en la lista de paquetes ya calculados no hacemos nada
                { }
                else
                {
                    listaNombresUsados_Apron.Add(TargetAddress);

                    List<CAT10> ListaPlanesMismoNombre = new List<CAT10>();
                    for (int j = 0; j < ListaMLAT.Count(); j++){if (ListaMLAT[j].TargetAdress_decoded == TargetAddress) { ListaPlanesMismoNombre.Add(ListaMLAT[j]); } }

                    for (int q = 0; q < ListaPlanesMismoNombre.Count(); q++)
                    {
                        Console.WriteLine(ListaPlanesMismoNombre[q].TargetAdress_decoded + "   " + ListaPlanesMismoNombre[q].TimeofDay_seconds);
                    }

                    // Ordenamos lista por tiempo
                    List<CAT10> ListaPlanesMismoNombre1 = ListaPlanesMismoNombre.OrderBy(o => o.TimeofDay_seconds).ToList();

                    if (ListaPlanesMismoNombre1.Count() > 1)
                    {
                        double counterSteps = 0;
                        double counterTrue = 0;

                        List<double> hola = new List<double>();

                        int k = 0;
                        while (k < ListaPlanesMismoNombre1.Count - 1)
                        {
                            double timedelay = ListaPlanesMismoNombre1[k + 1].TimeofDay_seconds - ListaPlanesMismoNombre1[k].TimeofDay_seconds;

                            if (Math.Abs(timedelay) < 30)
                            {
                                if (Math.Abs(timedelay) <= 1)
                                {
                                    counterTrue = counterTrue + 1;
                                }
                                counterSteps = counterSteps + 1;
                                hola.Add(timedelay);
                            }
                            k = k + 1;
                        }

                        counterbuenos = counterbuenos + counterTrue;
                        countertotales = countertotales + counterSteps;
                    }
                }
                i = i + 1;
            }
            return (counterbuenos / countertotales) * 100;
        }

        public double[] CalculateProbabilityofUpdateAIRBORNE(List<List<CAT10>> listaAirborneLists)
        {

            List<double> listaaverages111 = new List<double>();

            double contadorTrue = 0;
            double contadorTotal = 0;

            for (int q = 0; q < listaAirborneLists.Count; q++)
            {
                List<CAT10> listaMLAT_Apron = listaAirborneLists[q];
                List<CAT10> ListaMLAT = new List<CAT10>();
                List<string> listaNombresUsados = new List<string>();

                if (listaMLAT_Apron.Count > 1)
                {
                    ListaMLAT.Clear();
                    ListaMLAT.AddRange(listaMLAT_Apron);

                    for (int s = 0; s < ListaMLAT.Count(); s++)
                    {
                        string name = ListaMLAT[s].TargetAdress_decoded;
                        if (listaNombresUsados.Contains(name) == false && name != "")
                        {
                            listaNombresUsados.Add(name);
                        }
                        s = s + 1;
                    }

                    int i = 0;
                    for (i = 0; i < listaNombresUsados.Count(); i++) // Bucle que vaya avion por avion
                    {
                        // primero sacamosel nombre de ese avion
                        string nombre = listaNombresUsados[i];

                        //Ahora sacamos su segundo maximo y su segundo minimo de ese avion
                        var lista_seconds_de_este_avion = CalculateListaSecondsMLATporNombre(nombre, ListaMLAT);

                        if (lista_seconds_de_este_avion.Count > 1)
                        {
                            double secondinicial = lista_seconds_de_este_avion.Min();
                            double secondfinal = lista_seconds_de_este_avion.Max();
                            double secondactual = lista_seconds_de_este_avion[1];

                            int counter_bien = 0;
                            int counter_total = 0;

                            //Bucle que pase pr todos los segundos y compruebe que entre un mensaje y otro hay 1 seg como max
                            int j = 1;
                            while (j < lista_seconds_de_este_avion.Count)
                            {
                                if (lista_seconds_de_este_avion[j] - lista_seconds_de_este_avion[j - 1] <= 1)
                                {
                                    counter_bien = counter_bien + 1;
                                }
                                j = j + 1;
                                counter_total = counter_total + 1;
                            }

                            contadorTrue = contadorTrue + counter_bien;
                            contadorTotal = contadorTotal + counter_total;

                            listaaverages111.Add((counter_bien) / Convert.ToDouble(counter_total));
                        }
                    }
                }
            }
            double[] values = new double[3] { contadorTrue, contadorTotal, listaaverages111.Average() * 100 };
            return values;
        }

        public double CalculateProbabilityofUpdateAIRBORNE1(List<List<CAT10>> listaAirborneLists)
        {
            List<double> listaAvgDelay_Apron = new List<double>();

            for (int q = 0; q < listaAirborneLists.Count; q++)
            {
                List<CAT10> listaMLAT_Apron = listaAirborneLists[q];

                if (listaMLAT_Apron.Count > 1)
                {
                    List<CAT10> lista1 = new List<CAT10>();
                    for (int k = 0; k < listaMLAT_Apron.Count(); k++)
                    {
                        if (listaMLAT_Apron[k].TargetAdress.Length != 0 && listaMLAT[k].TargetAdress_decoded != "") { lista1.Add(listaMLAT_Apron[k]); }
                    }
                    listaMLAT_Apron.Clear();
                    for (int k = 0; k < lista1.Count; k++) { listaMLAT_Apron.Add(lista1[k]); }

                    // Apron

                    List<string> listaNombresUsados_Apron = new List<string>();

                    int i = 0;
                    while (i < listaMLAT_Apron.Count)
                    {
                        string TargetAddress;

                        if (listaMLAT_Apron[i].TargetAdress.Length > 0) // cojemos los paquetes que tienen Target Address y/o Target Identification
                        {
                            TargetAddress = listaMLAT_Apron[i].TargetAdress_decoded;

                            if (listaNombresUsados_Apron.Contains(TargetAddress)) // si Target Address y/o Target Identification estan en la lista de paquetes ya calculados no hacemos nada
                            { }
                            else
                            {
                                int j = 0;
                                List<CAT10> ListaPlanesMismoNombre = new List<CAT10>();
                                ListaPlanesMismoNombre.Add(listaMLAT_Apron[i]);
                                while (j < listaMLAT_Apron.Count)
                                {
                                    if (listaMLAT_Apron[j].TargetAdress_decoded == TargetAddress && listaMLAT_Apron[j].TargetAdress_decoded != "")
                                    {
                                        ListaPlanesMismoNombre.Add(listaMLAT_Apron[j]);
                                    }
                                    j = j + 1;
                                }

                                // Ordenamos lista por tiempo
                                List<CAT10> ListaPlanesMismoNombre1 = ListaPlanesMismoNombre.OrderBy(o => o.TimeofDay_seconds).ToList();


                                int k = 0;
                                double AvgSeconds = 0;

                                if (ListaPlanesMismoNombre.Count() > 1)
                                {
                                    double counterSteps = 0;
                                    double counterTrue = 0;

                                    while (k < ListaPlanesMismoNombre.Count - 1)
                                    {
                                        double a = ListaPlanesMismoNombre[k + 1].TimeofDay_seconds;
                                        double b = ListaPlanesMismoNombre[k].TimeofDay_seconds;

                                        if (Math.Abs(ListaPlanesMismoNombre[k + 1].TimeofDay_seconds - ListaPlanesMismoNombre[k].TimeofDay_seconds) < 5)
                                        {
                                            if (Math.Abs(ListaPlanesMismoNombre[k + 1].TimeofDay_seconds - ListaPlanesMismoNombre[k].TimeofDay_seconds) <= 1)
                                            {
                                                counterTrue = counterTrue + 1;
                                            }
                                            counterSteps = counterSteps + 1;
                                        }
                                        k = k + 1;
                                    }
                                    AvgSeconds = counterTrue / counterSteps;
                                    listaAvgDelay_Apron.Add(AvgSeconds);
                                }
                            }
                        }
                        i = i + 1;
                    }
                }
            }
            return listaAvgDelay_Apron.Average() * 100;
        }

        public List<List<double>> CalculatePrecissionAccuracy_fromnearestdistance(List<CAT10> listaMLAT_Apron, List<CAT21> listaCAT21, int PIC)
        {
            List<CAT10> listaMLAT = new List<CAT10>();
            listaMLAT.AddRange(listaMLAT_Apron);

            List<CAT21> listaADSB = new List<CAT21>();
            listaADSB.AddRange(listaCAT21);

            // Filtramos los paquetes MLAT que no tienen target identification
            List<CAT10> lista1 = new List<CAT10>();
            for (int i = 0; i < listaMLAT.Count; i++)
            {
                if (listaMLAT[i].TargetAdress.Length > 0 || (listaMLAT[i].TargetAdress.Length > 0 && listaMLAT[i].TargetAdress_decoded != ""))
                {
                    lista1.Add(listaMLAT[i]);
                }
            }
            listaMLAT.Clear();
            for (i = 0; i < lista1.Count(); i++) { listaMLAT.Add(lista1[i]); }

            // Filtramos los paquetes MLAT que no tengan coordemadas
            lista1.Clear();
            for (i = 0; i < listaMLAT.Count(); i++)
            {
                if ((listaMLAT[i].MeasuredPositioninPolarCoordinates.Length > 0) || (listaMLAT[i].PositioninCartesianCoordinates.Length > 0) || (listaMLAT[i].MeasuredPositioninPolarCoordinates.Length > 0 && listaMLAT[i].PositioninCartesianCoordinates.Length > 0)) // cojemos solo los paquetes con info de posición y velocidad en radianes
                { lista1.Add(listaMLAT[i]); }
            }
            listaMLAT.Clear();
            for (i = 0; i < lista1.Count(); i++) { listaMLAT.Add(lista1[i]); }


            ////Filtramos paquetes ADSB con version MOPS != 2
            List<CAT21> lista2 = new List<CAT21>();
            lista2.Clear();
            for (int i = 0; i < listaADSB.Count; i++)
            {
                if (listaADSB[i].VN == "ED102A/DO-260B [Ref. 11].")
                {
                    lista2.Add(listaADSB[i]);
                }
            }
            listaADSB.Clear();
            for (i = 0; i < lista2.Count(); i++) { listaADSB.Add(lista2[i]); }

            ////Filtramos paquetes ADSB PIC inferior al num de introducimos como parametro
            List<CAT21> lista3 = new List<CAT21>();
            lista3.Clear();
            for (int i = 0; i < listaADSB.Count; i++)
            {
                if (listaADSB[i].PIC >= PIC)
                {
                    lista3.Add(listaADSB[i]);
                }
            }
            listaADSB.Clear();
            for (i = 0; i < lista3.Count(); i++) { listaADSB.Add(lista3[i]); }


            List<List<double>> results = new List<List<double>>();
            List<double> listadistances = new List<double>();
            List<double> listaDeltaX = new List<double>();
            List<double> listaDeltaY = new List<double>();

            string TargetAddresssMLAT;
            int indexi = 1000000;
            int indexj = 1000000;

            for (int i = 0; i < listaMLAT.Count(); i++) // recorrem la lista MLAT
            {
                double distance = 1e8;
                TargetAddresssMLAT = listaMLAT[i].TargetAdress_decoded;
                List<CAT21> listaavionesCAT21mismonombre = new List<CAT21>();

                // Recorremos listaCAT21 y guardamos los paquetes con mismo Target Address
                for (int j = 0; j < listaADSB.Count(); j++) { if (listaADSB[j].TargetAdress_real == TargetAddresssMLAT) { listaavionesCAT21mismonombre.Add(listaADSB[j]); } }

                if (listaavionesCAT21mismonombre.Count > 1) // necesitamos 2 paquetes para calcular 1 interpolacion, por eso en cada lista hay 2 paquetes (primero y ultimo) que no usamos
                {
                    List<PaqueteADSByTiempo> listaavionesCAT21mismonombre1 = new List<PaqueteADSByTiempo>();
                    //VAmos a hacer una lista de objetos donde cada objeto tiene un cat21 y un tiempo
                    for (int k = 0; k < listaavionesCAT21mismonombre.Count(); k++)
                    {
                        PaqueteADSByTiempo datosytiepo1;
                        if (listaavionesCAT21mismonombre[k].TimeofApplicability_Position.Length > 0)
                        {
                            datosytiepo1 = new PaqueteADSByTiempo(listaavionesCAT21mismonombre[k].TimeofApplicability_Position_seconds, listaavionesCAT21mismonombre[k]);
                            listaavionesCAT21mismonombre1.Add(datosytiepo1);
                        }
                        else if (listaavionesCAT21mismonombre[k].TimeofMessageReception_HRPosition.Length > 0)
                        {
                            datosytiepo1 = new PaqueteADSByTiempo(listaavionesCAT21mismonombre[k].TimeofMessageReception_HRPosition_seconds, listaavionesCAT21mismonombre[k]);
                            listaavionesCAT21mismonombre1.Add(datosytiepo1);
                        }
                        else
                        {
                            datosytiepo1 = new PaqueteADSByTiempo(listaavionesCAT21mismonombre[k].TimeofMessageReception_Position_seconds, listaavionesCAT21mismonombre[k]);
                            listaavionesCAT21mismonombre1.Add(datosytiepo1);
                        }
                    }

                    // Ordenamos lista por tiempo
                    List<PaqueteADSByTiempo> ListaPlanesMismoNombre1 = listaavionesCAT21mismonombre1.OrderBy(o => o.time).ToList();

                    // Calculamos una linea entre el paquete ADSB anterior y posterior al tMLAT
                    int indexj_anterior = 1000000;
                    int indexj_posterior = 1000000;

                    double timeMLAT = listaMLAT[i].TimeofDay_seconds;

                    // 1. Buscamos posicion paquete inmediatamente anterior
                    for (int k = 0; k < ListaPlanesMismoNombre1.Count(); k++)
                    {
                        if (ListaPlanesMismoNombre1[k].time < timeMLAT) { indexj_anterior = k; }
                    }

                    // 2. Buscamos posicion paquete inmediatamente posterior
                    for (int k = ListaPlanesMismoNombre1.Count() - 1; k >= 0; k--)
                    {
                        if (ListaPlanesMismoNombre1[k].time > timeMLAT) { indexj_posterior = k; }
                    }

                    if (indexj_anterior != 1000000 && indexj_posterior != 1000000)
                    {
                        double timeanteriorADSB = ListaPlanesMismoNombre1[indexj_anterior].time;
                        double timesiguienteADSB = ListaPlanesMismoNombre1[indexj_posterior].time;

                        if(Math.Abs(indexj_anterior - indexj_posterior) <= 1 /*&& (Math.Abs(timeMLAT - timeanteriorADSB) + Math.Abs(timeMLAT - timesiguienteADSB) <= 1)*/)
                        {
                            double[] newCoordinatesADSB = new double[2];

                            //Interpolamos para encontrar Lat
                            double x0 = ListaPlanesMismoNombre1[indexj_anterior].time;
                            double x1 = ListaPlanesMismoNombre1[indexj_posterior].time;
                            double x = timeMLAT;

                            double y0 = CoordinatesADSB_WGS84(ListaPlanesMismoNombre1[indexj_anterior].cat21)[0];
                            double y1 = CoordinatesADSB_WGS84(ListaPlanesMismoNombre1[indexj_posterior].cat21)[0];

                            if ((x1 - x0) == 0)
                            {
                                newCoordinatesADSB[0] = (y0 + y1) / 2;
                            }
                            newCoordinatesADSB[0] = y0 + (x - x0) * (y1 - y0) / (x1 - x0);

                            // Interpolamos para encontrar Lon
                            y0 = CoordinatesADSB_WGS84(ListaPlanesMismoNombre1[indexj_anterior].cat21)[1];
                            y1 = CoordinatesADSB_WGS84(ListaPlanesMismoNombre1[indexj_posterior].cat21)[1];
                            x = timeMLAT;

                            if ((x1 - x0) == 0)
                            {
                                newCoordinatesADSB[1] = (y0 + y1) / 2;
                            }
                            newCoordinatesADSB[1] = y0 + (x - x0) * (y1 - y0) / (x1 - x0);

                            // Ahora calculamos distancia entre MLAT y ADSB
                            distance = CalculateDistanceBetweenCoordinates(newCoordinatesADSB, MLATcoordinates2WGS84(listaMLAT[i]));
                            listadistances.Add(distance);

                            // Calculamos componente X e Y de la distancia, suponiendo ADSB en el centro
                            double[] distancecopmponents = CalculateComponentesDistancia(newCoordinatesADSB, MLATcoordinates2WGS84(listaMLAT[i]));
                            listaDeltaX.Add(distancecopmponents[0] * -1);
                            listaDeltaY.Add(distancecopmponents[1] * -1);
                        }
                    }
                }
            }
            results.Add(listadistances);
            results.Add(listaDeltaX);
            results.Add(listaDeltaY);

            return results;
        }

        public List<double> CalculatePrecissionAccuracy_fromnearestdistance1(List<CAT10> listaMLAT_Apron, List<CAT21> listaCAT21)
        {
            // Filtramos los paquetes que no tienen target identification
            List<CAT10> lista1 = new List<CAT10>();
            for (int i = 0; i < listaMLAT_Apron.Count(); i++)
            {
                if (listaMLAT_Apron[i].TargetAdress.Length != 0 && listaMLAT[i].TargetAdress_decoded != "") { lista1.Add(listaMLAT_Apron[i]); }
            }
            listaMLAT_Apron.Clear();
            for (i = 0; i < lista1.Count; i++) { listaMLAT_Apron.Add(lista1[i]); }


            // Filtramos los paquetes que no tengan coordemadas + velocidad en polares
            lista1.Clear();
            for (i = 0; i < listaMLAT_Apron.Count(); i++)
            {
                if ((listaMLAT_Apron[i].MeasuredPositioninPolarCoordinates.Length > 0 && listaMLAT_Apron[i].CalculatedTrackVelocityinPolarCoordinates.Length > 0) || (listaMLAT_Apron[i].PositioninCartesianCoordinates.Length > 0 && listaMLAT_Apron[i].CalculatedTrackVelocityinPolarCoordinates.Length > 0) || (listaMLAT_Apron[i].MeasuredPositioninPolarCoordinates.Length > 0 && listaMLAT_Apron[i].CalculatedTrackVelocityinPolarCoordinates.Length > 0 && listaMLAT_Apron[i].PositioninCartesianCoordinates.Length > 0)) // cojemos solo los paquetes con info de posición y velocidad en radianes
                {
                    lista1.Add(listaMLAT_Apron[i]);
                }
            }
            listaMLAT_Apron.Clear();
            for (i = 0; i < lista1.Count; i++) { listaMLAT_Apron.Add(lista1[i]); }

            string TargetAddresssMLAT;
            List<double> listadistances = new List<double>();
            var overlay = new GMapOverlay();
            int indexj = 0;


            double[] CoordenadasMLAT = new double[2];
            double[] CoordenadasADSB = new double[2];

            for (int i = 0; i < listaMLAT_Apron.Count(); i++) // recorrem la lista MLAT
            {
                double distance = 1e8;
                TargetAddresssMLAT = listaMLAT_Apron[i].TargetAdress_decoded;
                List<CAT21> listaavionesCAT21mismonombre = new List<CAT21>();

                // Recorremos listaCAT21 y guardamos los paquetes con mismo Target Address
                for (int j = 0; j < listaCAT21.Count(); j++) { if (listaCAT21[j].TargetAdress_real == TargetAddresssMLAT /*&& listaCAT21[j].AirborneGoundVector.Length>0*/) { listaavionesCAT21mismonombre.Add(listaCAT21[j]); } }

                //Ahora recorremos lista de aviones con mismo address y nos quedamos con el mas cercano
                for (int j = 0; j < listaavionesCAT21mismonombre.Count; j++)
                {
                    var coord_i = MLATcoordinates2WGS84(listaMLAT_Apron[i]);
                    var coord_j = CoordinatesADSB_WGS84(listaavionesCAT21mismonombre[j]);
                    double d1 = CalculateDistanceBetweenCoordinates(coord_i, coord_j);

                    if (d1 < distance)
                    {
                        distance = d1;

                        CoordenadasADSB = coord_j;
                        CoordenadasMLAT = coord_i;

                        indexj = j;
                    }
                }

                if (distance != 1e8)
                {
                    double timedelay = listaMLAT_Apron[i].TimeofDay_seconds - listaavionesCAT21mismonombre[indexj].TimeofASTERIXReportTransmission_seconds;

                    double[] newCordenadasMLAT = new double[2];

                    double deltaX = listaMLAT_Apron[i].GroundSpeed * 1852 * Math.Cos(toRadians(listaMLAT_Apron[i].TrackAngle)) * timedelay;
                    double deltaY = listaMLAT_Apron[i].GroundSpeed * 1852 * Math.Sin(toRadians(listaMLAT_Apron[i].TrackAngle)) * timedelay;

                    // interpolamos

                    if (timedelay > 0/* && Math.Abs(timedelay) < 10*/)
                    {
                        double coordX = listaMLAT_Apron[i].X_cartesian - deltaX;
                        double coordY = listaMLAT_Apron[i].Y_cartesian - deltaY;

                        double rho = Math.Sqrt(coordX * coordX + coordY * coordY);
                        double theta = (180 / Math.PI) * Math.Atan2(coordX, coordY);

                        newCordenadasMLAT = NewCoordinatesMLAT(rho, theta);

                        distance = CalculateDistanceBetweenCoordinates(newCordenadasMLAT, CoordenadasADSB);
                        listadistances.Add(distance);

                        //if (CalculateDistanceBetweenCoordinates(newCordenadasMLAT, CoordenadasADSB) < distance) { listadistances.Add(CalculateDistanceBetweenCoordinates(newCordenadasMLAT, CoordenadasADSB)); }
                        //else { listadistances.Add(distance); }
                    }

                    if (timedelay < 0 /*&& Math.Abs(timedelay) < 10*/)
                    {
                        double coordX = listaMLAT_Apron[i].X_cartesian + deltaX;
                        double coordY = listaMLAT_Apron[i].Y_cartesian + deltaY;

                        double rho = Math.Sqrt(coordX * coordX + coordY * coordY);
                        double theta = (180 / Math.PI) * Math.Atan2(coordX, coordY);

                        newCordenadasMLAT = NewCoordinatesMLAT(rho, theta);

                        distance = CalculateDistanceBetweenCoordinates(newCordenadasMLAT, CoordenadasADSB);
                        listadistances.Add(distance);

                        //if (CalculateDistanceBetweenCoordinates(newCordenadasMLAT, CoordenadasADSB) < distance) { listadistances.Add(CalculateDistanceBetweenCoordinates(newCordenadasMLAT, CoordenadasADSB)); }
                        //else { listadistances.Add(distance); }
                    }
                    else if (timedelay == 0)
                    {
                        double coordX = listaMLAT_Apron[i].X_cartesian;
                        double coordY = listaMLAT_Apron[i].Y_cartesian;

                        double rho = Math.Sqrt(coordX * coordX + coordY * coordY);
                        double theta = (180 / Math.PI) * Math.Atan2(coordX, coordY);

                        newCordenadasMLAT = NewCoordinatesMLAT(rho, theta);

                        distance = CalculateDistanceBetweenCoordinates(newCordenadasMLAT, CoordenadasADSB);
                        listadistances.Add(distance);

                        //if (CalculateDistanceBetweenCoordinates(newCordenadasMLAT, CoordenadasADSB) < distance) { listadistances.Add(CalculateDistanceBetweenCoordinates(newCordenadasMLAT, CoordenadasADSB)); }
                        //else { listadistances.Add(distance); }
                    }
                }
            }
            return (listadistances);
        }

        public List<double> CalculatePRecissionAccuracySTAND(List<CAT10> listaMLAT_Apron, List<CAT21> listaCAT21)
        {
            string TargetAddresssMLAT;
            double[] coordenadasADSB = new double[2];
            List<double> listadistances = new List<double>();
            List<double> listatiempos = new List<double>();

            for (int i = 0; i < listaMLAT_Apron.Count(); i++)
            {
                double timedelay = 1e5;

                if (listaMLAT_Apron[i].TargetAdress_decoded.Length > 0 && listaMLAT_Apron[i].TargetAdress_decoded != "")
                {
                    TargetAddresssMLAT = listaMLAT_Apron[i].TargetAdress_decoded;

                    for (int j = 0; j < listaCAT21.Count; j++)
                    {
                        if (listaCAT21[j].TargetAdress_real.Length > 0 && listaCAT21[j].TargetAdress_real == TargetAddresssMLAT)
                        {
                            if (Math.Abs(listaMLAT_Apron[i].TimeofDay_seconds - listaCAT21[j].TimeofASTERIXReportTransmission_seconds) < timedelay)
                            {
                                timedelay = listaMLAT_Apron[i].TimeofDay_seconds - listaCAT21[j].TimeofASTERIXReportTransmission_seconds;
                                coordenadasADSB[0] = listaCAT21[j].latWGS84;
                                coordenadasADSB[1] = listaCAT21[j].lonWGS84;
                            }
                        }
                    }

                    if (timedelay != 1e5 && Math.Abs(timedelay) < 4)
                    {
                        if ((listaMLAT_Apron[i].MeasuredPositioninPolarCoordinates.Length > 0 && listaMLAT_Apron[i].CalculatedTrackVelocityinPolarCoordinates.Length > 0) || (listaMLAT_Apron[i].PositioninCartesianCoordinates.Length > 0 && listaMLAT_Apron[i].CalculatedTrackVelocityinPolarCoordinates.Length > 0) || (listaMLAT_Apron[i].MeasuredPositioninPolarCoordinates.Length > 0 && listaMLAT_Apron[i].CalculatedTrackVelocityinPolarCoordinates.Length > 0 && listaMLAT_Apron[i].PositioninCartesianCoordinates.Length > 0)) // cojemos solo los paquetes con info de posición y velocidad en radianes
                        {
                            double distance;

                            double deltaX = listaMLAT_Apron[i].GroundSpeed * 1852 * Math.Cos(toRadians(listaMLAT_Apron[i].TrackAngle)) * timedelay;
                            double deltaY = listaMLAT_Apron[i].GroundSpeed * 1852 * Math.Sin(toRadians(listaMLAT_Apron[i].TrackAngle)) * timedelay;

                            // interpolamos

                            if (timedelay > 0)
                            {
                                double coordX = listaMLAT_Apron[i].X_cartesian - deltaX;
                                double coordY = listaMLAT_Apron[i].Y_cartesian - deltaY;

                                double rho = Math.Sqrt(coordX * coordX + coordY * coordY);
                                double theta = (180 / Math.PI) * Math.Atan2(coordX, coordY);

                                double[] coordenadasMLAT = NewCoordinatesMLAT(rho, theta);

                                distance = CalculateDistanceBetweenCoordinates(coordenadasMLAT, coordenadasADSB);
                                listadistances.Add(distance);
                                listatiempos.Add(listaMLAT_Apron[i].TimeofDay_seconds);
                            }

                            if (timedelay < 0)
                            {
                                double coordX = listaMLAT_Apron[i].X_cartesian + deltaX;
                                double coordY = listaMLAT_Apron[i].Y_cartesian + deltaY;

                                double rho = Math.Sqrt(coordX * coordX + coordY * coordY);
                                double theta = (180 / Math.PI) * Math.Atan2(coordX, coordY);

                                double[] coordenadasMLAT = NewCoordinatesMLAT(rho, theta);

                                distance = CalculateDistanceBetweenCoordinates(coordenadasMLAT, coordenadasADSB);
                                listadistances.Add(distance);
                                listatiempos.Add(listaMLAT_Apron[i].TimeofDay_seconds);
                            }

                            {
                                double coordX = listaMLAT_Apron[i].X_cartesian;
                                double coordY = listaMLAT_Apron[i].Y_cartesian;

                                double rho = Math.Sqrt(coordX * coordX + coordY * coordY);
                                double theta = (180 / Math.PI) * Math.Atan2(coordX, coordY);

                                double[] coordenadasMLAT = NewCoordinatesMLAT(rho, theta);

                                distance = CalculateDistanceBetweenCoordinates(coordenadasMLAT, coordenadasADSB);
                                listadistances.Add(distance);
                                listatiempos.Add(listaMLAT_Apron[i].TimeofDay_seconds);
                            }
                        }
                    }
                }
            }

            List<double> listaAverages = new List<double>();
            int k = 0;
            for (double time = listatiempos[0]; time < listatiempos[listatiempos.Count - 1]; time = time + 5)
            {
                double distance = 0;
                int counter = 0;

                if (k < listatiempos.Count)
                {
                    while (listatiempos[k] < (time + 5))
                    {
                        distance = distance + listadistances[k];
                        counter = counter + 1;

                        k = k + 1;
                    }
                    time = time + 5;

                    if (distance > 0 && counter > 0) { listaAverages.Add(distance / counter); }
                }
            }
            return listaAverages;
        }

        public List<double> CalculatePRecissionAccuracySTAND1(List<CAT10> listaMLAT_Apron, List<CAT21> listaCAT21)
        {
            List<CAT10> listaMLAT = new List<CAT10>();
            listaMLAT.AddRange(listaMLAT_Apron);

            List<CAT21> listaADSB = new List<CAT21>();
            listaADSB.AddRange(listaCAT21);

            // Filtramos los paquetes MLAT que no tienen target identification
            List<CAT10> lista1 = new List<CAT10>();
            for (int i = 0; i < listaMLAT.Count; i++)
            {
                if (listaMLAT[i].TargetAdress.Length > 0 || (listaMLAT[i].TargetAdress.Length > 0 && listaMLAT[i].TargetAdress_decoded != ""))
                {
                    lista1.Add(listaMLAT[i]);
                }
            }
            listaMLAT.Clear();
            for (i = 0; i < lista1.Count(); i++) { listaMLAT.Add(lista1[i]); }

            // Filtramos los paquetes MLAT que no tengan coordemadas
            lista1.Clear();
            for (i = 0; i < listaMLAT.Count(); i++)
            {
                if ((listaMLAT[i].MeasuredPositioninPolarCoordinates.Length > 0) || (listaMLAT[i].PositioninCartesianCoordinates.Length > 0) || (listaMLAT[i].MeasuredPositioninPolarCoordinates.Length > 0 && listaMLAT[i].PositioninCartesianCoordinates.Length > 0)) // cojemos solo los paquetes con info de posición y velocidad en radianes
                { lista1.Add(listaMLAT[i]); }
            }
            listaMLAT.Clear();
            for (i = 0; i < lista1.Count(); i++) { listaMLAT.Add(lista1[i]); }


            ////Filtramos paquetes ADSB con version MOPS != 2
            List<CAT21> lista2 = new List<CAT21>();
            lista2.Clear();
            for (int i = 0; i < listaADSB.Count; i++)
            {
                if (listaADSB[i].VN == "ED102A/DO-260B [Ref. 11].")
                {
                    lista2.Add(listaADSB[i]);
                }
            }
            listaADSB.Clear();
            for (i = 0; i < lista2.Count(); i++) { listaADSB.Add(lista2[i]); }



            string TargetAddresssMLAT;
            List<double> listadistances = new List<double>();
            List<double> listatiempos = new List<double>();
            int indexi = 1000000;
            int indexj = 1000000;

            for (int i = 0; i < listaMLAT.Count(); i++) // recorrem la lista MLAT
            {
                double distance = 1e8;
                TargetAddresssMLAT = listaMLAT[i].TargetAdress_decoded;
                List<CAT21> listaavionesCAT21mismonombre = new List<CAT21>();

                // Recorremos listaCAT21 y guardamos los paquetes con mismo Target Address
                for (int j = 0; j < listaADSB.Count(); j++) { if (listaADSB[j].TargetAdress_real == TargetAddresssMLAT) { listaavionesCAT21mismonombre.Add(listaADSB[j]); } }

                if (listaavionesCAT21mismonombre.Count > 1) // necesitamos 2 paquetes para calcular 1 interpolacion, por eso en cada lista hay 2 paquetes (primero y ultimo) que no usamos
                {
                    List<PaqueteADSByTiempo> listaavionesCAT21mismonombre1 = new List<PaqueteADSByTiempo>();
                    //VAmos a hacer una lista de objetos donde cada objeto tiene un cat21 y un tiempo
                    for (int s = 0; s < listaavionesCAT21mismonombre.Count(); s++)
                    {
                        PaqueteADSByTiempo datosytiepo1;
                        if (listaavionesCAT21mismonombre[s].TimeofApplicability_Position.Length > 0)
                        {
                            datosytiepo1 = new PaqueteADSByTiempo(listaavionesCAT21mismonombre[s].TimeofApplicability_Position_seconds, listaavionesCAT21mismonombre[s]);
                            listaavionesCAT21mismonombre1.Add(datosytiepo1);
                        }
                        else if (listaavionesCAT21mismonombre[s].TimeofMessageReception_HRPosition.Length > 0)
                        {
                            datosytiepo1 = new PaqueteADSByTiempo(listaavionesCAT21mismonombre[s].TimeofMessageReception_HRPosition_seconds, listaavionesCAT21mismonombre[s]);
                            listaavionesCAT21mismonombre1.Add(datosytiepo1);
                        }
                        else
                        {
                            datosytiepo1 = new PaqueteADSByTiempo(listaavionesCAT21mismonombre[s].TimeofMessageReception_Position_seconds, listaavionesCAT21mismonombre[s]);
                            listaavionesCAT21mismonombre1.Add(datosytiepo1);
                        }
                    }

                    // Ordenamos lista por tiempo
                    List<PaqueteADSByTiempo> ListaPlanesMismoNombre1 = listaavionesCAT21mismonombre1.OrderBy(o => o.time).ToList();

                    // Calculamos una linea entre el paquete ADSB anterior y posterior al tMLAT
                    int indexj_anterior = 1000000;
                    int indexj_posterior = 1000000;

                    double timeMLAT = listaMLAT[i].TimeofDay_seconds;

                    // 1. Buscamos posicion paquete inmediatamente anterior
                    for (int t = 0; t < ListaPlanesMismoNombre1.Count(); t++)
                    {
                        if (ListaPlanesMismoNombre1[t].time < timeMLAT) { indexj_anterior = t; }
                    }

                    // 2. Buscamos posicion paquete inmediatamente posterior
                    for (int r = ListaPlanesMismoNombre1.Count() - 1; r >= 0; r--)
                    {
                        if (ListaPlanesMismoNombre1[r].time > timeMLAT) { indexj_posterior = r; }
                    }


                    if (indexj_anterior != 1000000 && indexj_posterior != 1000000 && Math.Abs(indexj_anterior - indexj_posterior) <= 2 /*&& Math.Abs(timeMLAT- timeanteriorADSB)<=0.5 && Math.Abs(timeMLAT - timesiguienteADSB) <= 0.5*/)
                    {
                        double[] newCoordinatesADSB = new double[2];

                        //Interpolamos para encontrar Lat
                        double x0 = ListaPlanesMismoNombre1[indexj_anterior].time;
                        double x1 = ListaPlanesMismoNombre1[indexj_posterior].time;
                        double x = timeMLAT;

                        double y0 = CoordinatesADSB_WGS84(ListaPlanesMismoNombre1[indexj_anterior].cat21)[0];
                        double y1 = CoordinatesADSB_WGS84(ListaPlanesMismoNombre1[indexj_posterior].cat21)[0];

                        if ((x1 - x0) == 0)
                        {
                            newCoordinatesADSB[0] = (y0 + y1) / 2;
                        }
                        newCoordinatesADSB[0] = y0 + (x - x0) * (y1 - y0) / (x1 - x0);

                        // Interpolamos para encontrar Lon
                        y0 = CoordinatesADSB_WGS84(ListaPlanesMismoNombre1[indexj_anterior].cat21)[1];
                        y1 = CoordinatesADSB_WGS84(ListaPlanesMismoNombre1[indexj_posterior].cat21)[1];
                        x = timeMLAT;

                        if ((x1 - x0) == 0)
                        {
                            newCoordinatesADSB[1] = (y0 + y1) / 2;
                        }
                        newCoordinatesADSB[1] = y0 + (x - x0) * (y1 - y0) / (x1 - x0);

                        // Ahora calculamos distancia entre MLAT y ADSB
                        distance = CalculateDistanceBetweenCoordinates(newCoordinatesADSB, MLATcoordinates2WGS84(listaMLAT[i]));
                        listadistances.Add(distance);
                        listatiempos.Add(listaMLAT[i].TimeofDay_seconds);
                    }
                }
            }

            List<double> listaAverages = new List<double>();

            int k = 0;
            for (double time = listatiempos[0]; time < listatiempos[listatiempos.Count - 1]; time = time + 5)
            {
                double distance = 0;
                int counter = 0;

                if (k < listatiempos.Count)
                {
                    while (listatiempos[k] < (time + 5))
                    {
                        distance = distance + listadistances[k];
                        counter = counter + 1;

                        k = k + 1;
                    }
                    time = time + 5;

                    if (distance > 0 && counter > 0) { listaAverages.Add(distance / counter); }
                }
            }

            return listaAverages;
        }

        public double[] CalculateProbabilityofMLATDetection(List<CAT10> listaMLAT_Apron, double interval)
        {
            List<CAT10> ListaMLAT = new List<CAT10>();
            List<string> listaNombresUsados = new List<string>();
            List<double> listaaverages111 = new List<double>();

            double contadorTrue = 0;
            double contadorTotal = 0;

            ListaMLAT.AddRange(listaMLAT_Apron);

            for (int s = 0; s < ListaMLAT.Count(); s++)
            {
                string name = ListaMLAT[s].TargetAdress_decoded;
                if (listaNombresUsados.Contains(name) == false && name != "")
                {
                    listaNombresUsados.Add(name);
                }
                s = s + 1;
            }

            int i = 0;
            for (i = 0; i < listaNombresUsados.Count(); i++) // Bucle que vaya avion por avion
            {
                // primero sacamosel nombre de ese avion
                string nombre = listaNombresUsados[i];

                //Ahora sacamos su segundo maximo y su segundo minimo de ese avion
                var lista_seconds_de_este_avion = CalculateListaSecondsMLATporNombre(nombre, ListaMLAT);

                if (lista_seconds_de_este_avion.Count > 1)
                {
                    double secondinicial = lista_seconds_de_este_avion.Min();
                    double secondfinal = lista_seconds_de_este_avion.Max();
                    double secondactual = lista_seconds_de_este_avion[1];

                    int counter_bien = 0;
                    int counter_total = 0;

                    //Bucle que pase pr todos los segundos y compruebe que entre un mensaje y otro hay 1 seg como max
                    int j = 1;
                    while (j < lista_seconds_de_este_avion.Count)
                    {
                        if (lista_seconds_de_este_avion[j] - lista_seconds_de_este_avion[j - 1] <= interval)
                        {
                            counter_bien = counter_bien + 1;
                        }
                        j = j + 1;
                        counter_total = counter_total + 1;
                    }

                    contadorTrue = contadorTrue + counter_bien;
                    contadorTotal = contadorTotal + counter_total;

                    listaaverages111.Add((counter_bien) / Convert.ToDouble(counter_total));
                }
            }

            double[] values = new double[3] { contadorTrue, contadorTotal, listaaverages111.Average() * 100 };
            return values;
        }

        public double CalculateProbabilityofMLATDetection1(List<CAT10> listaMLAT_Apron, double interval)
        {
            List<CAT10> lista1 = new List<CAT10>();
            for (int k = 0; k < listaMLAT_Apron.Count(); k++)
            {
                if (listaMLAT_Apron[k].TargetAdress.Length != 0 && listaMLAT[k].TargetAdress_decoded != "") { lista1.Add(listaMLAT_Apron[k]); }
            }
            listaMLAT_Apron.Clear();
            for (int k = 0; k < lista1.Count; k++) { listaMLAT_Apron.Add(lista1[k]); }

            // Apron

            List<string> listaNombresUsados_Apron = new List<string>();
            List<double> listaAvgDelay_Apron = new List<double>();

            int i = 0;
            while (i < listaMLAT_Apron.Count)
            {
                string TargetAddress;

                if (listaMLAT_Apron[i].TargetAdress.Length > 0) // cojemos los paquetes que tienen Target Address y/o Target Identification
                {
                    TargetAddress = listaMLAT_Apron[i].TargetAdress_decoded;

                    if (listaNombresUsados_Apron.Contains(TargetAddress)) // si Target Address y/o Target Identification estan en la lista de paquetes ya calculados no hacemos nada
                    { }
                    else
                    {
                        int j = 0;
                        List<CAT10> ListaPlanesMismoNombre = new List<CAT10>();
                        ListaPlanesMismoNombre.Add(listaMLAT_Apron[i]);
                        while (j < listaMLAT_Apron.Count)
                        {
                            if (listaMLAT_Apron[j].TargetAdress_decoded == TargetAddress && listaMLAT_Apron[j].TargetAdress_decoded != "")
                            {
                                ListaPlanesMismoNombre.Add(listaMLAT_Apron[j]);
                            }
                            j = j + 1;
                        }

                        // Ordenamos lista por tiempo
                        List<CAT10> ListaPlanesMismoNombre1 = ListaPlanesMismoNombre.OrderBy(o => o.TimeofDay_seconds).ToList();


                        int k = 0;
                        double AvgSeconds = 0;

                        if (ListaPlanesMismoNombre.Count() > 1)
                        {
                            double counterSteps = 0;
                            double counterTrue = 0;

                            while (k < ListaPlanesMismoNombre.Count - 1)
                            {
                                double a = ListaPlanesMismoNombre[k + 1].TimeofDay_seconds;
                                double b = ListaPlanesMismoNombre[k].TimeofDay_seconds;

                                if (Math.Abs(ListaPlanesMismoNombre[k + 1].TimeofDay_seconds - ListaPlanesMismoNombre[k].TimeofDay_seconds) < 10)
                                {
                                    if (Math.Abs(ListaPlanesMismoNombre[k + 1].TimeofDay_seconds - ListaPlanesMismoNombre[k].TimeofDay_seconds) <= interval)
                                    {
                                        counterTrue = counterTrue + 1;
                                    }
                                    counterSteps = counterSteps + 1;
                                }
                                k = k + 1;
                            }
                            AvgSeconds = counterTrue / counterSteps;
                            listaAvgDelay_Apron.Add(AvgSeconds);
                        }
                    }
                }
                i = i + 1;
            }
            return listaAvgDelay_Apron.Average() * 100;
        }

        public List<double> CalculateProbabilityofIdentification(List<CAT10> listaMLATmodeS)
        {
            string TrackNumber;
            List<string> listaTrackNumbers = new List<string>();
            List<double> listofProbabilityofIdentification = new List<double>();
            List<double> listResults = new List<double>();

            double counter_true = 0;
            double counter_total = 0;

            for (int i = 0; i < listaMLATmodeS.Count; i++)
            {
                if (listaMLATmodeS[i].TrackNumber.Length > 0 && listaTrackNumbers.Contains(listaMLATmodeS[i].TrackNumber) == false)
                {
                    TrackNumber = listaMLATmodeS[i].TrackNumber;
                    listaTrackNumbers.Add(listaMLATmodeS[i].TrackNumber);

                    List<CAT10> listapaquetesmismonombre = new List<CAT10>();

                    // Ahora buscamos todos los paquetes con ese track number y los metemos en una lista

                    for (int j = 0; j < listaMLATmodeS.Count; j++)
                    {
                        if (listaMLATmodeS[j].TrackNumber == TrackNumber) { listapaquetesmismonombre.Add(listaMLATmodeS[j]); }
                    }

                    // Ahora recorremos esa lista comprobando que todos los paquetes tengan el mismo Target Address
                    // Contamos cuantos nombres hay y cuantas veces aparece cada uno, luego el Address que mas veces aparezca es el bueno y el resto son errores

                    // 1- Contamos cuantos nombres diferentes hay
                    List<string> listadenombres = new List<string>();
                    for (int k = 0; k < listapaquetesmismonombre.Count(); k++)
                    {
                        if (listadenombres.Contains(listapaquetesmismonombre[k].TargetAdress) == false) { listadenombres.Add(listapaquetesmismonombre[k].TargetAdress); }
                    }

                    // 2- Cuantos paquetes hay con cada nombre?
                    List<int> listadecontadores = new List<int>();
                    for (int m = 0; m < listadenombres.Count; m++)
                    {
                        int counter = 0;
                        for (int n = 0; n < listapaquetesmismonombre.Count; n++)
                        {
                            if (listadenombres[m] == listapaquetesmismonombre[n].TargetAdress) { counter = counter + 1; }
                        }
                        listadecontadores.Add(counter);
                    }

                    // 3- Calculamos porcentaje de aciertos/errores

                    double casosbuenos = listadecontadores.Max();
                    double casostotales = listapaquetesmismonombre.Count();

                    counter_true = counter_true + casosbuenos;
                    counter_total = counter_total + casostotales;
                }
            }
            listResults.Add(counter_true);
            listResults.Add(counter_total);
            listResults.Add((counter_true / counter_total)*100);
            return listResults;
        }

        public class PaqueteADSByTiempo
        {
            public double time;
            public CAT21 cat21;

            public PaqueteADSByTiempo(double time, CAT21 cat21)
            {
                this.cat21 = cat21;
                this.time = time;
            }
        }

        private void Mapa_Load(object sender, EventArgs e)
        {

        }
    }
}
