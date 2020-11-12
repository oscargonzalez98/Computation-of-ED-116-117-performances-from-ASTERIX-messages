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
    public partial class ED2 : Form
    {
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

        List<PointLatLng> polygonApoints = new List<PointLatLng>();
        List<PointLatLng> polygonBpoints = new List<PointLatLng>();
        List<PointLatLng> polygonCpoints = new List<PointLatLng>();
        List<PointLatLng> polygonDpoints = new List<PointLatLng>();
        List<PointLatLng> polygonEpoints = new List<PointLatLng>();
        List<PointLatLng> polygonFpoints = new List<PointLatLng>();
        List<PointLatLng> polygonGpoints = new List<PointLatLng>();
        List<PointLatLng> polygonHpoints = new List<PointLatLng>();
        List<PointLatLng> polygonIpoints = new List<PointLatLng>();
        List<PointLatLng> polygonJpoints = new List<PointLatLng>();
        List<PointLatLng> polygonKpoints = new List<PointLatLng>();
        List<PointLatLng> polygonLpoints = new List<PointLatLng>();
        List<PointLatLng> polygonMpoints = new List<PointLatLng>();
        List<PointLatLng> polygonNpoints = new List<PointLatLng>();
        List<PointLatLng> polygonOpoints = new List<PointLatLng>();
        List<PointLatLng> polygonPpoints = new List<PointLatLng>();
        List<PointLatLng> polygonQpoints = new List<PointLatLng>();
        List<PointLatLng> polygonRpoints = new List<PointLatLng>();
        List<PointLatLng> polygonSpoints = new List<PointLatLng>();
        List<PointLatLng> polygonTpoints = new List<PointLatLng>();
        List<PointLatLng> polygonUpoints = new List<PointLatLng>();
        List<PointLatLng> polygonVpoints = new List<PointLatLng>();
        List<PointLatLng> polygonWpoints = new List<PointLatLng>();
        List<PointLatLng> polygonXpoints = new List<PointLatLng>();
        List<PointLatLng> polygonYpoints = new List<PointLatLng>();

        GMapPolygon polygonA;
        GMapPolygon polygonB;
        GMapPolygon polygonC;
        GMapPolygon polygonD;
        GMapPolygon polygonE;
        GMapPolygon polygonF;
        GMapPolygon polygonG;
        GMapPolygon polygonH;
        GMapPolygon polygonI;
        GMapPolygon polygonJ;
        GMapPolygon polygonK;
        GMapPolygon polygonL;
        GMapPolygon polygonM;
        GMapPolygon polygonN;
        GMapPolygon polygonO;
        GMapPolygon polygonP;
        GMapPolygon polygonQ;
        GMapPolygon polygonR;
        GMapPolygon polygonS;
        GMapPolygon polygonT;
        GMapPolygon polygonU;
        GMapPolygon polygonV;
        GMapPolygon polygonW;
        GMapPolygon polygonX;
        GMapPolygon polygonY;

        GMapOverlay polygonsOverlay = new GMapOverlay();

        // Heading Pistas
        double heading07R;
        double heading25L;
        double heading07L;
        double heading25R;
        double heading02;
        double heading20;

        List<CAT10> listaCAT10 = new List<CAT10>();
        List<CAT10> listaSMR = new List<CAT10>();
        List<CAT10> listaMLAT = new List<CAT10>();
        List<CAT21> listaCAT21 = new List<CAT21>();
        List<CAT21v23> listaCAT21v23 = new List<CAT21v23>();
        List<MLATCalibrationData> listaCalibrationDataVehicle = new List<MLATCalibrationData>();

        List<CAT10> listaMLAT_Stand = new List<CAT10>();
        List<CAT10> listaMLAT_Stand_T1 = new List<CAT10>();
        List<CAT10> listaMLAT_Stand_T2 = new List<CAT10>();
        List<CAT10> listaMLAT_Apron = new List<CAT10>();
        List<CAT10> listaMLAT_Apron_T1 = new List<CAT10>();
        List<CAT10> listaMLAT_Apron_T2 = new List<CAT10>();
        List<CAT10> listaMLAT_MA = new List<CAT10>();
        List<CAT10> listaMLAT_Ground = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne = new List<CAT10>();
        List<CAT10> listaMLAT_RWY1 = new List<CAT10>();
        List<CAT10> listaMLAT_RWY2 = new List<CAT10>();
        List<CAT10> listaMLAT_RWY3 = new List<CAT10>();
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

        List<CAT21> listaCAT21_NearAirport = new List<CAT21>();

        double LatInicial = 41.2969444;
        double LongInicial = 2.0783333333333336;

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

        public ED2(List<CAT10> listaCAT10, List<CAT21> listaCAT21, List<CAT21v23> listaCAT21v23, List<MLATCalibrationData> listaCalibrationDataVehicle)
        {
            InitializeComponent();

            this.listaCAT10 = listaCAT10;
            this.listaCAT21 = listaCAT21;
            this.listaCAT21v23 = listaCAT21v23;
            this.listaCalibrationDataVehicle = listaCalibrationDataVehicle;

            #region Airport Zones Coordinates

            // Creamos los puntos de los Polígonos
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

            #endregion //  Class variables

            #region Polygon Variable Declaration

            polygonsOverlay.Clear();

            polygonJ = new GMapPolygon(polygonJpoints, "PolygonJ")
            {
                Stroke = new Pen(Color.Red, 2),
                Fill = new SolidBrush(Color.Red)
            };
            polygonsOverlay.Polygons.Add(polygonJ);

            polygonA = new GMapPolygon(polygonApoints, "PolygonA")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };
            polygonsOverlay.Polygons.Add(polygonA);
            Mapa.Overlays.Add(polygonsOverlay);

            polygonB = new GMapPolygon(polygonBpoints, "PolygonB")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };
            polygonsOverlay.Polygons.Add(polygonB);
            Mapa.Overlays.Add(polygonsOverlay);

            polygonC = new GMapPolygon(polygonCpoints, "PolygonC")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };
            polygonsOverlay.Polygons.Add(polygonC);
            Mapa.Overlays.Add(polygonsOverlay);

            polygonD = new GMapPolygon(polygonDpoints, "PolygonD")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };
            polygonsOverlay.Polygons.Add(polygonD);
            Mapa.Overlays.Add(polygonsOverlay);

            polygonE = new GMapPolygon(polygonEpoints, "PolygonE")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };
            polygonsOverlay.Polygons.Add(polygonE);
            Mapa.Overlays.Add(polygonsOverlay);

            polygonF = new GMapPolygon(polygonFpoints, "PolygonF")
            {
                Stroke = new Pen(Color.Yellow, 2),
                Fill = new SolidBrush(Color.Yellow)
            };
            polygonsOverlay.Polygons.Add(polygonF);
            Mapa.Overlays.Add(polygonsOverlay);

            polygonG = new GMapPolygon(polygonGpoints, "PolygonG")
            {
                Stroke = new Pen(Color.Yellow, 2),
                Fill = new SolidBrush(Color.Yellow)
            };
            polygonsOverlay.Polygons.Add(polygonG);
            Mapa.Overlays.Add(polygonsOverlay);

            polygonH = new GMapPolygon(polygonHpoints, "PolygonH")
            {
                Stroke = new Pen(Color.Yellow, 2),
                Fill = new SolidBrush(Color.Yellow)
            };
            polygonsOverlay.Polygons.Add(polygonH);
            Mapa.Overlays.Add(polygonsOverlay);

            polygonI = new GMapPolygon(polygonIpoints, "PolygonI")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Green)
            };
            polygonsOverlay.Polygons.Add(polygonI);

            polygonK = new GMapPolygon(polygonKpoints, "PolygonK")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };
            polygonsOverlay.Polygons.Add(polygonK);

            polygonL = new GMapPolygon(polygonLpoints, "PolygonL")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };
            polygonsOverlay.Polygons.Add(polygonL);

            polygonM = new GMapPolygon(polygonMpoints, "PolygonM")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };
            polygonsOverlay.Polygons.Add(polygonM);

            polygonN = new GMapPolygon(polygonNpoints, "PolygonN")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };
            polygonsOverlay.Polygons.Add(polygonN);

            polygonO = new GMapPolygon(polygonOpoints, "PolygonO")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };
            polygonsOverlay.Polygons.Add(polygonO);

            polygonP = new GMapPolygon(polygonPpoints, "PolygonP")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };
            polygonsOverlay.Polygons.Add(polygonP);

            polygonQ = new GMapPolygon(polygonQpoints, "PolygonQ")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };
            polygonsOverlay.Polygons.Add(polygonQ);

            polygonR = new GMapPolygon(polygonRpoints, "PolygonR")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };
            polygonsOverlay.Polygons.Add(polygonR);

            polygonS = new GMapPolygon(polygonSpoints, "PolygonS")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };
            polygonsOverlay.Polygons.Add(polygonS);

            polygonT = new GMapPolygon(polygonTpoints, "PolygonT")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };
            polygonsOverlay.Polygons.Add(polygonT);

            polygonU = new GMapPolygon(polygonUpoints, "PolygonU")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.Blue)
            };
            polygonsOverlay.Polygons.Add(polygonU);

            polygonV = new GMapPolygon(polygonVpoints, "PolygonV")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.LightBlue)
            };
            polygonsOverlay.Polygons.Add(polygonV);

            polygonW = new GMapPolygon(polygonWpoints, "PolygonW")
            {
                Stroke = new Pen(Color.White, 2),
                Fill = new SolidBrush(Color.White)
            };
            polygonsOverlay.Polygons.Add(polygonW);

            polygonX = new GMapPolygon(polygonXpoints, "PolygonX")
            {
                Stroke = new Pen(Color.White, 2),
                Fill = new SolidBrush(Color.White)
            };
            polygonsOverlay.Polygons.Add(polygonX);

            polygonY = new GMapPolygon(polygonYpoints, "PolygonY")
            {
                Stroke = new Pen(Color.White, 2),
                Fill = new SolidBrush(Color.White)
            };
            polygonsOverlay.Polygons.Add(polygonY);

            Mapa.Overlays.Add(polygonsOverlay);

            #endregion //  Class variables

        }

        private void ED2_Load(object sender, EventArgs e)
        {
            //////----------------------------------------------------------------------- Ploteamos en el mapa

            Mapa.DragButton = MouseButtons.Left;
            Mapa.CanDragMap = true;
            Mapa.MapProvider = GMapProviders.GoogleMap;
            Mapa.Position = new PointLatLng(LatInicial, LongInicial);
            Mapa.MinZoom = 1;
            Mapa.MaxZoom = 30;
            Mapa.Zoom = 8;
            Mapa.AutoScroll = true;

            //////----------------------------------------------------------------------- Separamos lista CAT10 en listaMLAT y listaSMR
            
            for(int i = 0; i< listaCAT10.Count(); i++)
            {
                if (listaCAT10[i].SAC == 0 && listaCAT10[i].SIC == 7) { listaSMR.Add(listaCAT10[i]); }
                if (listaCAT10[i].SAC == 0 && listaCAT10[i].SIC == 107) { listaMLAT.Add(listaCAT10[i]); }
            }

            //////----------------------------------------------------------------------- Filtramos paquetes MLAT y ADSB (Quitamos periodic updates, ground vehicles, paquetes muy lejanos, etc...)

            FilterCAT21messages(listaCAT21);
            CalculateARP_MLAT_SMR_coordinates();
            listaCAT21_NearAirport = FilterCAT21messagesAwayfromAirport(listaCAT21, 20000);
            FilterMLATmessages(listaMLAT);

            //////----------------------------------------------------------------------- Filtramos paquetes por Zonas del Aeropuerto

            FilterByAirportZones(listaMLAT);
        }

        #region Filtering Functions

            public void FilterByAirportZones(List<CAT10> listaMLATmessages1)
            {
                List<CAT10> listaMLATmessages = new List<CAT10>();
                listaMLATmessages.AddRange(listaMLATmessages1);

                // Recorremos lista, guardandonos todos los target Address
                List<string> namelist = new List<string>();
                for (int i = 0; i < listaMLATmessages.Count(); i++)
                {
                    if (namelist.Contains(listaMLATmessages[i].TargetAdress_decoded))
                    {
                    }
                    else
                    {
                        namelist.Add(listaMLATmessages[i].TargetAdress_decoded);
                    }
                }

                // Ahora vamos Target Address por Target Address, guardamos todos los paquetes con esa identificacion en una lista y la guardamos
                List<List<CAT10>> listoflists = new List<List<CAT10>>();
                for (int i = 0; i < namelist.Count(); i++)
                {
                    List<CAT10> listplanessamename = new List<CAT10>();
                    listplanessamename.Clear();
                    for (int j = 0; j < listaMLATmessages.Count(); j++)
                    {
                        if (listaMLATmessages[j].TargetAdress_decoded == namelist[i])
                        {
                            listplanessamename.Add(listaMLATmessages[j]);
                        }
                    }

                    listoflists.Add(listplanessamename);
                }

                // Buscamos si en alguna lista de nombres tenemos diferentes Track Number para un mismo TA
                List<List<CAT10>> listoflists1 = new List<List<CAT10>>();
                for (int i = 0; i < listoflists.Count(); i++)
                {
                    // Cojemos una lista de paquetes con mismo TA
                    List<CAT10> listplanes = listoflists[i];

                    // Buscamos cuantos TN hay
                    List<double> listTrackAngle = new List<double>();
                    for (int j = 0; j < listplanes.Count(); j++)
                    {
                        if (listTrackAngle.Contains(listplanes[j].Tracknumber_value) == false) { listTrackAngle.Add(listplanes[j].Tracknumber_value); }
                    }

                    // Por cada TN que hay calculamos todos los aviones que lo tienen y los metemos en una lista
                    for (int j = 0; j < listTrackAngle.Count(); j++)
                    {
                        List<CAT10> listplanes1 = new List<CAT10>();
                        for (int k = 0; k < listplanes.Count(); k++)
                        {
                            if (listplanes[k].Tracknumber_value == listTrackAngle[j]) { listplanes1.Add(listplanes[k]); }
                        }
                        listoflists1.Add(listplanes1);
                    }
                }

                // Ahora vamos lista de aviones por lista de aviones y los separamos por zonas.
                for (int i = 0; i < listoflists1.Count(); i++)
                {
                    var listplanes = listoflists1[i];

                    //Miramos los casos en que el avion sigue una trayectoria de despegue o aterrizaje (o ninguna de las dos)
                    bool insideJ_start = polygonJ.IsInside(new PointLatLng(listplanes.First().coordGeodesic.Lat*GeoUtils.RADS2DEGS, listplanes.First().coordGeodesic.Lon*GeoUtils.RADS2DEGS));
                    bool insideJ_end = polygonJ.IsInside(new PointLatLng(listplanes.Last().coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes.Last().coordGeodesic.Lon * GeoUtils.RADS2DEGS));

                    // Si el avion sigue una trayectoria de despegue (empieza dentro de zona aeropuerto y acaba fuera)
                    if (insideJ_start == true && insideJ_end == false)
                    {
                        // Guardamos los vuelos con ground bit = 1 en lista MA
                        int j = 0;
                        while (j < listplanes.Count() && listplanes[j].GBS == "Transponder Ground bit set.")
                        {
                            listaMLAT_Ground.Add(listplanes[j]);

                            double[] coordenadas = new double[] { listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

                            bool insideA = polygonA.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideB = polygonB.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideC = polygonC.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideD = polygonD.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideE = polygonE.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideF = polygonF.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideG = polygonG.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideH = polygonH.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideI = polygonI.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideW = polygonW.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideX = polygonX.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideY = polygonY.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));

                            // STAND
                            if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) > 0)
                            {
                                listaMLAT_Stand.Add(listplanes[j]);

                                if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) > 0) { listaMLAT_Stand_T1.Add(listplanes[j]); }
                                else { listaMLAT_Stand_T2.Add(listplanes[j]); }
                            }

                            // APRON
                            if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                            {
                                listaMLAT_Apron.Add(listplanes[j]);

                                if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                            }

                            // MA
                            if (insideI)
                            {
                                listaMLAT_MA.Add(listplanes[j]);

                                if ((insideW ? 1 : 0) + (insideX ? 1 : 0) + (insideY ? 1 : 0) > 0)
                                {
                                    if (insideW) { listaMLAT_RWY1.Add(listplanes[j]); }
                                    if (insideX) { listaMLAT_RWY2.Add(listplanes[j]); }
                                    if (insideY) { listaMLAT_RWY3.Add(listplanes[j]); }
                                }
                                else { listaMLAT_Taxiway.Add(listplanes[j]); }
                            }
                            j++;
                        }

                        // Si no tienen ground  bit = 1 pero siguen encima de la pista de despegue también los consideramos como que estan en tierra

                        // Guardamos en que pista estaba la ultima vez que tenia un ground bit = 1
                        bool inside_RWY1_CambioGBS = polygonW.IsInside(new PointLatLng(listplanes[j - 1].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j - 1].coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                        bool inside_RWY2_CambioGBS = polygonX.IsInside(new PointLatLng(listplanes[j - 1].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j - 1].coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                        bool inside_RWY3_CambioGBS = polygonY.IsInside(new PointLatLng(listplanes[j - 1].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j - 1].coordGeodesic.Lon * GeoUtils.RADS2DEGS));

                        if (j < listplanes.Count())
                        {
                            // Mientras sigamos en la misma pista del ultimo ground bit set = 1 guardamos los paquetes en lista MA
                            while (j < listplanes.Count())
                            {
                                bool inside_RWY1 = polygonW.IsInside(new PointLatLng(listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                                bool inside_RWY2 = polygonX.IsInside(new PointLatLng(listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                                bool inside_RWY3 = polygonY.IsInside(new PointLatLng(listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS));

                                if (inside_RWY1_CambioGBS == inside_RWY1 && inside_RWY2_CambioGBS == inside_RWY2 && inside_RWY3_CambioGBS == inside_RWY3)
                                {
                                    listaMLAT_Ground.Add(listplanes[j]);

                                    double[] coordenadas = new double[] { listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

                                    bool insideA = polygonA.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                    bool insideB = polygonB.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                    bool insideC = polygonC.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                    bool insideD = polygonD.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                    bool insideE = polygonE.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                    bool insideF = polygonF.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                    bool insideG = polygonG.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                    bool insideH = polygonH.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                    bool insideI = polygonI.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                    bool insideW = polygonW.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                    bool insideX = polygonX.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                    bool insideY = polygonY.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));

                                    // STAND
                                    if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) > 0)
                                    {
                                        listaMLAT_Stand.Add(listplanes[j]);

                                        if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) > 0) { listaMLAT_Stand_T1.Add(listplanes[j]); }
                                        else { listaMLAT_Stand_T2.Add(listplanes[j]); }
                                    }

                                    // APRON
                                    if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0) 
                                    {
                                        listaMLAT_Apron.Add(listplanes[j]);

                                        if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                        else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                                    }

                                    // MA
                                    if (insideI)
                                    {
                                        listaMLAT_MA.Add(listplanes[j]);

                                        if ((insideW ? 1 : 0) + (insideX ? 1 : 0) + (insideY ? 1 : 0) > 0)
                                        {
                                            if (insideW) { listaMLAT_RWY1.Add(listplanes[j]); }
                                            if (insideX) { listaMLAT_RWY2.Add(listplanes[j]); }
                                            if (insideY) { listaMLAT_RWY3.Add(listplanes[j]); }
                                        }
                                        else { listaMLAT_Taxiway.Add(listplanes[j]); }
                                    }
                                }

                                // Si no estan encima de la pista del ultimo GB = 1 es que han acabado la pista y estan en zona aire
                                else
                                {
                                    listaMLAT_Airborne.Add(listplanes[j]);

                                    double[] coordenadas = new double[] { listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

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

                                    if ((insideL ? 1 : 0) + (insideN ? 1 : 0) + (insideP ? 1 : 0) + (insideR ? 1 : 0) + (insideT ? 1 : 0) + (insideV ? 1 : 0) > 0)
                                    {
                                        listaMLAT_Airborne_2coma5NM.Add(listplanes[j]);

                                        if (insideL) { listaMLAT_Airborne_2coma5NM_L.Add(listplanes[j]); }
                                        if (insideN) { listaMLAT_Airborne_2coma5NM_N.Add(listplanes[j]); }
                                        if (insideP) { listaMLAT_Airborne_2coma5NM_P.Add(listplanes[j]); }
                                        if (insideR) { listaMLAT_Airborne_2coma5NM_R.Add(listplanes[j]); }
                                        if (insideT) { listaMLAT_Airborne_2coma5NM_T.Add(listplanes[j]); }
                                        if (insideV) { listaMLAT_Airborne_2coma5NM_V.Add(listplanes[j]); }
                                    }
                                    else if ((insideK ? 1 : 0) + (insideM ? 1 : 0) + (insideO ? 1 : 0) + (insideQ ? 1 : 0) + (insideS ? 1 : 0) + (insideU ? 1 : 0) > 0)
                                    {
                                        listaMLAT_Airborne_5NM.Add(listplanes[j]);

                                        if (insideK) { listaMLAT_Airborne_5NM_K.Add(listplanes[j]); }
                                        if (insideM) { listaMLAT_Airborne_5NM_M.Add(listplanes[j]); }
                                        if (insideO) { listaMLAT_Airborne_5NM_O.Add(listplanes[j]); }
                                        if (insideQ) { listaMLAT_Airborne_5NM_Q.Add(listplanes[j]); }
                                        if (insideS) { listaMLAT_Airborne_5NM_S.Add(listplanes[j]); }
                                        if (insideU) { listaMLAT_Airborne_5NM_U.Add(listplanes[j]); }
                                    }
                                }
                                j++;
                            }
                        }
                    }

                    // Si el avion sigue una trayectoria de aterrizaje (empieza fuera de zona aeropuerto y acaba dentro)
                    else if (insideJ_start == false && insideJ_end == true)
                    {
                        // Buscamos en que indice de la lista pasa el ground bit de 0 a 1;
                        int index_j = 0;
                        for (int j = 0; j < listplanes.Count(); j++)
                        {
                            if(listplanes[j].GBS == "Transponder Ground bit not set.") { index_j = j; }
                        }

                        // Buscamos en que runway estamos
                        bool inside_RWY1_CambioGBS = polygonW.IsInside(new PointLatLng(listplanes[index_j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[index_j].coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                        bool inside_RWY2_CambioGBS = polygonX.IsInside(new PointLatLng(listplanes[index_j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[index_j].coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                        bool inside_RWY3_CambioGBS = polygonY.IsInside(new PointLatLng(listplanes[index_j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[index_j].coordGeodesic.Lon * GeoUtils.RADS2DEGS));

                        // Buscamos si, antes de estar en las pistas que dice estar, ha pasado por una zona aire de esa pista o ha pasado ppor esa pista de casualidad

                        if(inside_RWY1_CambioGBS == true)
                        {
                            bool bool1 = false;
                            for(int j = 0; j < index_j && bool1==false; j++) 
                            {
                                double[] coordenadas = new double[] { listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

                                bool insideT = polygonT.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideV = polygonV.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));

                                if(insideT || insideV)
                                {
                                    inside_RWY1_CambioGBS = true;
                                    bool1 = true;
                                }
                            }
                            if (bool1 == false) { inside_RWY1_CambioGBS = false; }
                        }

                        if (inside_RWY2_CambioGBS == true)
                        {
                            bool bool1 = false;
                            for (int j = 0; j < index_j && bool1 == false; j++)
                            {
                                double[] coordenadas = new double[] { listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

                                bool insideL = polygonL.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideN = polygonN.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));

                                if (insideL || insideN)
                                {
                                    inside_RWY2_CambioGBS = true;
                                    bool1 = true;
                                }
                            }
                            if (bool1 == false) { inside_RWY2_CambioGBS = false; }
                        }

                        if (inside_RWY3_CambioGBS == true)
                        {
                            bool bool1 = false;
                            for (int j = 0; j < index_j && bool1 == false; j++)
                            {
                                double[] coordenadas = new double[] { listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

                                bool insideP = polygonP.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideR = polygonR.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));

                                if (insideP || insideR)
                                {
                                    inside_RWY3_CambioGBS = true;
                                    bool1 = true;
                                }
                            }
                            if (bool1 == false) { inside_RWY3_CambioGBS = false; }
                        }

                        // Ahora ya hemos filtrado las pistas por las que hemos pasado de casualidad

                        // Ahora, por cada pista separamos entre zona aire y MA
                        if (inside_RWY1_CambioGBS)
                        {
                            int j = 0;
                            while ( j < listplanes.Count() && polygonW.IsInside(new PointLatLng(listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS)) == false)
                            {
                                listaMLAT_Airborne.Add(listplanes[j]);

                                double[] coordenadas = new double[] { listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

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

                                if ((insideL ? 1 : 0) + (insideN ? 1 : 0) + (insideP ? 1 : 0) + (insideR ? 1 : 0) + (insideT ? 1 : 0) + (insideV ? 1 : 0) > 0)
                                {
                                    listaMLAT_Airborne_2coma5NM.Add(listplanes[j]);

                                    if (insideL) { listaMLAT_Airborne_2coma5NM_L.Add(listplanes[j]); }
                                    if (insideN) { listaMLAT_Airborne_2coma5NM_N.Add(listplanes[j]); }
                                    if (insideP) { listaMLAT_Airborne_2coma5NM_P.Add(listplanes[j]); }
                                    if (insideR) { listaMLAT_Airborne_2coma5NM_R.Add(listplanes[j]); }
                                    if (insideT) { listaMLAT_Airborne_2coma5NM_T.Add(listplanes[j]); }
                                    if (insideV) { listaMLAT_Airborne_2coma5NM_V.Add(listplanes[j]); }
                                }
                                else if ((insideK ? 1 : 0) + (insideM ? 1 : 0) + (insideO ? 1 : 0) + (insideQ ? 1 : 0) + (insideS ? 1 : 0) + (insideU ? 1 : 0) > 0)
                                {
                                    listaMLAT_Airborne_5NM.Add(listplanes[j]);

                                    if (insideK) { listaMLAT_Airborne_5NM_K.Add(listplanes[j]); }
                                    if (insideM) { listaMLAT_Airborne_5NM_M.Add(listplanes[j]); }
                                    if (insideO) { listaMLAT_Airborne_5NM_O.Add(listplanes[j]); }
                                    if (insideQ) { listaMLAT_Airborne_5NM_Q.Add(listplanes[j]); }
                                    if (insideS) { listaMLAT_Airborne_5NM_S.Add(listplanes[j]); }
                                    if (insideU) { listaMLAT_Airborne_5NM_U.Add(listplanes[j]); }
                                }
                                j++;
                            }
                            while(j< listplanes.Count())
                            {
                                listaMLAT_Ground.Add(listplanes[j]);

                                double[] coordenadas = new double[] { listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

                                bool insideA = polygonA.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideB = polygonB.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideC = polygonC.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideD = polygonD.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideE = polygonE.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideF = polygonF.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideG = polygonG.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideH = polygonH.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideI = polygonI.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideW = polygonW.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideX = polygonX.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideY = polygonY.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));

                                // STAND
                                if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) > 0)
                                {
                                    listaMLAT_Stand.Add(listplanes[j]);

                                    if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) > 0) { listaMLAT_Stand_T1.Add(listplanes[j]); }
                                    else { listaMLAT_Stand_T2.Add(listplanes[j]); }
                                }

                                // APRON
                                if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                                {
                                    listaMLAT_Apron.Add(listplanes[j]);

                                    if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                    else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                                }

                                // MA
                                if (insideI)
                                {
                                    listaMLAT_MA.Add(listplanes[j]);

                                    if ((insideW ? 1 : 0) + (insideX ? 1 : 0) + (insideY ? 1 : 0) > 0)
                                    {
                                        if (insideW) { listaMLAT_RWY1.Add(listplanes[j]); }
                                        if (insideX) { listaMLAT_RWY2.Add(listplanes[j]); }
                                        if (insideY) { listaMLAT_RWY3.Add(listplanes[j]); }
                                    }
                                    else { listaMLAT_Taxiway.Add(listplanes[j]); }
                                }
                                j++;
                            }
                        }

                        else if (inside_RWY2_CambioGBS)
                        {
                            int j = 0;
                            while (j < listplanes.Count() && polygonX.IsInside(new PointLatLng(listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS)) == false)
                            {
                                listaMLAT_Airborne.Add(listplanes[j]);

                                double[] coordenadas = new double[] { listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

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

                                if ((insideL ? 1 : 0) + (insideN ? 1 : 0) + (insideP ? 1 : 0) + (insideR ? 1 : 0) + (insideT ? 1 : 0) + (insideV ? 1 : 0) > 0)
                                {
                                    listaMLAT_Airborne_2coma5NM.Add(listplanes[j]);

                                    if (insideL) { listaMLAT_Airborne_2coma5NM_L.Add(listplanes[j]); }
                                    if (insideN) { listaMLAT_Airborne_2coma5NM_N.Add(listplanes[j]); }
                                    if (insideP) { listaMLAT_Airborne_2coma5NM_P.Add(listplanes[j]); }
                                    if (insideR) { listaMLAT_Airborne_2coma5NM_R.Add(listplanes[j]); }
                                    if (insideT) { listaMLAT_Airborne_2coma5NM_T.Add(listplanes[j]); }
                                    if (insideV) { listaMLAT_Airborne_2coma5NM_V.Add(listplanes[j]); }
                                }
                                else if ((insideK ? 1 : 0) + (insideM ? 1 : 0) + (insideO ? 1 : 0) + (insideQ ? 1 : 0) + (insideS ? 1 : 0) + (insideU ? 1 : 0) > 0)
                                {
                                    listaMLAT_Airborne_5NM.Add(listplanes[j]);

                                    if (insideK) { listaMLAT_Airborne_5NM_K.Add(listplanes[j]); }
                                    if (insideM) { listaMLAT_Airborne_5NM_M.Add(listplanes[j]); }
                                    if (insideO) { listaMLAT_Airborne_5NM_O.Add(listplanes[j]); }
                                    if (insideQ) { listaMLAT_Airborne_5NM_Q.Add(listplanes[j]); }
                                    if (insideS) { listaMLAT_Airborne_5NM_S.Add(listplanes[j]); }
                                    if (insideU) { listaMLAT_Airborne_5NM_U.Add(listplanes[j]); }
                                }
                                j++;
                            }
                            while (j < listplanes.Count())
                            {
                                listaMLAT_Ground.Add(listplanes[j]);

                                double[] coordenadas = new double[] { listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

                                bool insideA = polygonA.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideB = polygonB.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideC = polygonC.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideD = polygonD.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideE = polygonE.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideF = polygonF.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideG = polygonG.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideH = polygonH.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideI = polygonI.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideW = polygonW.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideX = polygonX.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideY = polygonY.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));

                                // STAND
                                if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) > 0)
                                {
                                    listaMLAT_Stand.Add(listplanes[j]);

                                    if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) > 0) { listaMLAT_Stand_T1.Add(listplanes[j]); }
                                    else { listaMLAT_Stand_T2.Add(listplanes[j]); }
                                }

                                // APRON
                                if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                                {
                                    listaMLAT_Apron.Add(listplanes[j]);

                                    if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                    else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                                }

                                // MA
                                if (insideI)
                                {
                                    listaMLAT_MA.Add(listplanes[j]);

                                    if ((insideW ? 1 : 0) + (insideX ? 1 : 0) + (insideY ? 1 : 0) > 0)
                                    {
                                        if (insideW) { listaMLAT_RWY1.Add(listplanes[j]); }
                                        if (insideX) { listaMLAT_RWY2.Add(listplanes[j]); }
                                        if (insideY) { listaMLAT_RWY3.Add(listplanes[j]); }
                                    }
                                    else { listaMLAT_Taxiway.Add(listplanes[j]); }
                                }
                                j++;
                            }
                        }

                        else if (inside_RWY3_CambioGBS)
                        {
                            int j = 0;
                            while (j < listplanes.Count() && polygonY.IsInside(new PointLatLng(listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS)) == false)
                            {
                                listaMLAT_Airborne.Add(listplanes[j]);

                                double[] coordenadas = new double[] { listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

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

                                if ((insideL ? 1 : 0) + (insideN ? 1 : 0) + (insideP ? 1 : 0) + (insideR ? 1 : 0) + (insideT ? 1 : 0) + (insideV ? 1 : 0) > 0)
                                {
                                    listaMLAT_Airborne_2coma5NM.Add(listplanes[j]);

                                    if (insideL) { listaMLAT_Airborne_2coma5NM_L.Add(listplanes[j]); }
                                    if (insideN) { listaMLAT_Airborne_2coma5NM_N.Add(listplanes[j]); }
                                    if (insideP) { listaMLAT_Airborne_2coma5NM_P.Add(listplanes[j]); }
                                    if (insideR) { listaMLAT_Airborne_2coma5NM_R.Add(listplanes[j]); }
                                    if (insideT) { listaMLAT_Airborne_2coma5NM_T.Add(listplanes[j]); }
                                    if (insideV) { listaMLAT_Airborne_2coma5NM_V.Add(listplanes[j]); }
                                }
                                else if ((insideK ? 1 : 0) + (insideM ? 1 : 0) + (insideO ? 1 : 0) + (insideQ ? 1 : 0) + (insideS ? 1 : 0) + (insideU ? 1 : 0) > 0)
                                {
                                    listaMLAT_Airborne_5NM.Add(listplanes[j]);

                                    if (insideK) { listaMLAT_Airborne_5NM_K.Add(listplanes[j]); }
                                    if (insideM) { listaMLAT_Airborne_5NM_M.Add(listplanes[j]); }
                                    if (insideO) { listaMLAT_Airborne_5NM_O.Add(listplanes[j]); }
                                    if (insideQ) { listaMLAT_Airborne_5NM_Q.Add(listplanes[j]); }
                                    if (insideS) { listaMLAT_Airborne_5NM_S.Add(listplanes[j]); }
                                    if (insideU) { listaMLAT_Airborne_5NM_U.Add(listplanes[j]); }
                                }
                                j++;
                            }
                            while (j < listplanes.Count())
                            {
                                listaMLAT_Ground.Add(listplanes[j]);

                                double[] coordenadas = new double[] { listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

                                bool insideA = polygonA.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideB = polygonB.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideC = polygonC.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideD = polygonD.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideE = polygonE.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideF = polygonF.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideG = polygonG.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideH = polygonH.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideI = polygonI.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideW = polygonW.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideX = polygonX.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideY = polygonY.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));

                                // STAND
                                if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) > 0)
                                {
                                    listaMLAT_Stand.Add(listplanes[j]);

                                    if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) > 0) { listaMLAT_Stand_T1.Add(listplanes[j]); }
                                    else { listaMLAT_Stand_T2.Add(listplanes[j]); }
                                }

                                // APRON
                                if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                                {
                                    listaMLAT_Apron.Add(listplanes[j]);

                                    if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                    else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                                }

                                // MA
                                if (insideI)
                                {
                                    listaMLAT_MA.Add(listplanes[j]);

                                    if ((insideW ? 1 : 0) + (insideX ? 1 : 0) + (insideY ? 1 : 0) > 0)
                                    {
                                        if (insideW) { listaMLAT_RWY1.Add(listplanes[j]); }
                                        if (insideX) { listaMLAT_RWY2.Add(listplanes[j]); }
                                        if (insideY) { listaMLAT_RWY3.Add(listplanes[j]); }
                                    }
                                    else { listaMLAT_Taxiway.Add(listplanes[j]); }
                                }
                                j++;
                            }
                        }
                    }

                    // Si empieza y acaba dentro o empieza y acaba fuera no es un TO/Landing y se puede calcular la zona mucho mas facilmente
                    else
                    {
                        for(int j = 0; j < listplanes.Count(); j++)
                        {
                            double[] coordenadas = new double[] { listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

                            bool insideA = polygonA.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideB = polygonB.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideC = polygonC.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideD = polygonD.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideE = polygonE.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideF = polygonF.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideG = polygonG.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideH = polygonH.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideI = polygonI.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
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

                            // STAND
                            if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) > 0)
                            {
                                listaMLAT_Stand.Add(listplanes[j]);

                                if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) > 0) { listaMLAT_Stand_T1.Add(listplanes[j]); }
                                else { listaMLAT_Stand_T2.Add(listplanes[j]); }
                            }

                            // APRON
                            if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                            {
                                listaMLAT_Apron.Add(listplanes[j]);

                                if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                            }

                            // MA
                            if (insideI)
                            {
                                listaMLAT_MA.Add(listplanes[j]);

                                if ((insideW ? 1 : 0) + (insideX ? 1 : 0) + (insideY ? 1 : 0) > 0)
                                {
                                    if (insideW) { listaMLAT_RWY1.Add(listplanes[j]); }
                                    if (insideX) { listaMLAT_RWY2.Add(listplanes[j]); }
                                    if (insideY) { listaMLAT_RWY3.Add(listplanes[j]); }
                                }
                                else { listaMLAT_Taxiway.Add(listplanes[j]); }
                            }

                            // Airborne

                            if ((insideL ? 1 : 0) + (insideN ? 1 : 0) + (insideP ? 1 : 0) + (insideR ? 1 : 0) + (insideT ? 1 : 0) + (insideV ? 1 : 0) > 0)
                            {
                                listaMLAT_Airborne.Add(listplanes[j]);
                                listaMLAT_Airborne_2coma5NM.Add(listplanes[j]);

                                if (insideL) { listaMLAT_Airborne_2coma5NM_L.Add(listplanes[j]); }
                                if (insideN) { listaMLAT_Airborne_2coma5NM_N.Add(listplanes[j]); }
                                if (insideP) { listaMLAT_Airborne_2coma5NM_P.Add(listplanes[j]); }
                                if (insideR) { listaMLAT_Airborne_2coma5NM_R.Add(listplanes[j]); }
                                if (insideT) { listaMLAT_Airborne_2coma5NM_T.Add(listplanes[j]); }
                                if (insideV) { listaMLAT_Airborne_2coma5NM_V.Add(listplanes[j]); }
                            }
                            else if ((insideK ? 1 : 0) + (insideM ? 1 : 0) + (insideO ? 1 : 0) + (insideQ ? 1 : 0) + (insideS ? 1 : 0) + (insideU ? 1 : 0) > 0)
                            {
                                listaMLAT_Airborne.Add(listplanes[j]);
                                listaMLAT_Airborne_5NM.Add(listplanes[j]);

                                if (insideK) { listaMLAT_Airborne_5NM_K.Add(listplanes[j]); }
                                if (insideM) { listaMLAT_Airborne_5NM_M.Add(listplanes[j]); }
                                if (insideO) { listaMLAT_Airborne_5NM_O.Add(listplanes[j]); }
                                if (insideQ) { listaMLAT_Airborne_5NM_Q.Add(listplanes[j]); }
                                if (insideS) { listaMLAT_Airborne_5NM_S.Add(listplanes[j]); }
                                if (insideU) { listaMLAT_Airborne_5NM_U.Add(listplanes[j]); }
                            }
                        }
                    }
                }
            } // Separamos los paquetes MLAT por zonas del Aeropuerto

            public void FilterMLATmessages(List<CAT10> listaMLATmessages)
            {
                List<CAT10> list = new List<CAT10>();
                for (int i = 0; i < listaMLATmessages.Count(); i++)
                {
                    if (listaMLATmessages[i].TOT == "Aircraft.") { list.Add(listaMLATmessages[i]); }
                }
                listaMLATmessages.Clear();
                listaMLATmessages.AddRange(list);
            } // Filtramos paquetes MLAT (Quitamos periodic updates, ground vehicles, etc...)

            public void FilterCAT21messages(List<CAT21> listaCAT21messages)
            {// Filtramos paquetes ADSB (Quitamos periodic updates, ground vehicles, etc...)
                List<CAT21> list1 = new List<CAT21>();
                for (int i = 0; i < listaCAT21messages.Count(); i++)
                {
                    string ECAT = listaCAT21messages[i].ECAT;

                    if (ECAT != "Line obstacle." && ECAT != "Cluster obstacle." && ECAT != "Fixed ground or tethered obstruction." && ECAT != "Surface service vehicle." && ECAT != "Surface emergency vehicle" && ECAT != "Parachutist/Skydiver." && ECAT != "No ADS-B Emitter Category Information.")
                    {
                        list1.Add(listaCAT21messages[i]);
                    }
                }
                listaCAT21messages.Clear();
                listaCAT21messages.AddRange(list1);
            } // Filtramos paquetes ADSB (Quitamos periodic updates, ground vehicles, etc...)

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

                    if(distancia < distance) { result.Add(listaCAT21messages[i]); }
                }

                return result;
            } // Calculamos paquetes mas cercanos al aeropuerto

        # endregion

        #region Vincenty Equations & Related
        public double toRadians(double grados)
            {
                return grados * Math.PI / 180;
            }

            public double toDegrees(double radians)
            {
                return radians * 180 / (Math.PI);
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

        #endregion
    }
}
