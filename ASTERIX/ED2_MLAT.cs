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
    public partial class ED2_MLAT : Form
    {
        #region Variables

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
        Bitmap pink_circle = (Bitmap)Image.FromFile("img/Circles1/circle_pink_small.png");

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

        DataGridView dgv_UpdateRate_fromASTERIXfile = new DataGridView();
        DataGridView dgv_ProbabilityofUpdate_fromASTERIXfile = new DataGridView();
        DataGridView dgv_PrecissionAccuracy_fromASTERIXfile = new DataGridView();
        DataGridView dgv_ProbabilityofMLATDetection_fromASTERIXfile = new DataGridView();
        DataGridView dgv_ProbabilityofIdentification_fromASTERIXfile = new DataGridView();
        DataGridView dgv_ProbabilityofFalseDetection_fromASTERIXfile = new DataGridView();
        DataGridView dgv_ProbabilityofFalseIdentification_fromASTERIXfile = new DataGridView();

        DataGridView dgv_PrecissionAccuracyError_Stand_fromASTERIXfile = new DataGridView();
        DataGridView dgv_PrecissionAccuracyError_Apron_fromASTERIXfile = new DataGridView();
        DataGridView dgv_PrecissionAccuracyError_MA_fromASTERIXfile = new DataGridView();
        DataGridView dgv_PrecissionAccuracyError_Airborne25_fromASTERIXfile = new DataGridView();
        DataGridView dgv_PrecissionAccuracyError_Airborne5_fromASTERIXfile = new DataGridView();
        DataGridView dgv_PrecissionAccuracyError_Total_fromASTERIXfile = new DataGridView();

        DataGridView dgv_ProbabilityofUpdate_CalibrationVehicle = new DataGridView();
        DataGridView dgv_PrecissionAccuracy_CalibrationVehicle = new DataGridView();
        DataGridView dgv_ProbabilityofMLATDetection_CalibrationVehicle = new DataGridView();
        DataGridView dgv_ProbabilityofIdentification_CalibrationVehicle = new DataGridView();
        DataGridView dgv_ProbabilityofFalseDetection_CalibrationVehicle = new DataGridView();
        DataGridView dgv_ProbabilityofFalseIdentification_CalibrationVehicle = new DataGridView();

        DataGridView dgv_PrecissionAccuracyError_Stand_fromCalibrationVehicle = new DataGridView();
        DataGridView dgv_PrecissionAccuracyError_Apron_fromCalibrationVehicle = new DataGridView();
        DataGridView dgv_PrecissionAccuracyError_MA_fromCalibrationVehicle = new DataGridView();
        DataGridView dgv_PrecissionAccuracyError_Airborne25_fromCalibrationVehicle = new DataGridView();
        DataGridView dgv_PrecissionAccuracyError_Airborne5_fromCalibrationVehicle = new DataGridView();
        DataGridView dgv_PrecissionAccuracyError_Total_fromCalibrationVehicle = new DataGridView();

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

        // Coordenadas ARP
        double LatARP = 41 + (17.0 / 60.0) + (49.426 / 3600);
        double LonARP = 02 + (04.0 / 60.0) + (42.410 / 3600);

        string GBS = "Transponder Ground bit set.";
        string GBNS = "Transponder Ground bit not set.";

        #endregion

        public ED2_MLAT(List<CAT10> listaCAT10, List<CAT21> listaCAT21, List<CAT21v23> listaCAT21v23, List<MLATCalibrationData> listaCalibrationDataVehicle)
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


            //// RW3 (la de arriba)
            polygonYpoints.Add(new PointLatLng(41.29297049468716, 2.065622392172579));
            polygonYpoints.Add(new PointLatLng(41.29248193489276, 2.065916364393845));
            polygonYpoints.Add(new PointLatLng(41.30547193468261, 2.103816950027875));
            polygonYpoints.Add(new PointLatLng(41.30594777193178, 2.103529206755665));
            polygonYpoints.Add(new PointLatLng(41.29297049468716, 2.065622392172579));


            #endregion //  Class variables

            #region Polygon Variable Declaration

            polygonsOverlay.Clear();
            int opacity = 128;

            polygonJ = new GMapPolygon(polygonJpoints, "PolygonJ")
            {
                Stroke = new Pen(Color.Red, 2),
                Fill = new SolidBrush(Color.Red)
            };
            //polygonsOverlay.Polygons.Add(polygonJ);

            polygonA = new GMapPolygon(polygonApoints, "PolygonA")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 255, 0, 255))
            };
            polygonsOverlay.Polygons.Add(polygonA);

            polygonB = new GMapPolygon(polygonBpoints, "PolygonB")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 255, 0, 255))
            };
            polygonsOverlay.Polygons.Add(polygonB);

            polygonC = new GMapPolygon(polygonCpoints, "PolygonC")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 255, 0, 255))
            };
            polygonsOverlay.Polygons.Add(polygonC);

            polygonD = new GMapPolygon(polygonDpoints, "PolygonD")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 255, 0, 255))
            };
            polygonsOverlay.Polygons.Add(polygonD);

            polygonE = new GMapPolygon(polygonEpoints, "PolygonE")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 255, 0, 255))
            };
            polygonsOverlay.Polygons.Add(polygonE);

            polygonF = new GMapPolygon(polygonFpoints, "PolygonF")
            {
                Stroke = new Pen(Color.Yellow, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 255, 255, 102))
            };
            polygonsOverlay.Polygons.Add(polygonF);

            polygonG = new GMapPolygon(polygonGpoints, "PolygonG")
            {
                Stroke = new Pen(Color.Yellow, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 255, 255, 102))
            };
            polygonsOverlay.Polygons.Add(polygonG);

            polygonH = new GMapPolygon(polygonHpoints, "PolygonH")
            {
                Stroke = new Pen(Color.Yellow, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 255, 255, 102))
            };
            polygonsOverlay.Polygons.Add(polygonH);

            polygonI = new GMapPolygon(polygonIpoints, "PolygonI")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 11,102,35))
            };
            polygonsOverlay.Polygons.Add(polygonI);

            polygonK = new GMapPolygon(polygonKpoints, "PolygonK")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 0, 0, 255))
            };
            polygonsOverlay.Polygons.Add(polygonK);

            polygonL = new GMapPolygon(polygonLpoints, "PolygonL")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 0, 204, 204))
            };
            polygonsOverlay.Polygons.Add(polygonL);

            polygonM = new GMapPolygon(polygonMpoints, "PolygonM")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 0, 0, 255))
            };
            polygonsOverlay.Polygons.Add(polygonM);

            polygonN = new GMapPolygon(polygonNpoints, "PolygonN")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 0, 204, 204))
            };
            polygonsOverlay.Polygons.Add(polygonN);

            polygonO = new GMapPolygon(polygonOpoints, "PolygonO")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 0, 0, 255))
            };
            polygonsOverlay.Polygons.Add(polygonO);

            polygonP = new GMapPolygon(polygonPpoints, "PolygonP")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 0, 204, 204))
            };
            polygonsOverlay.Polygons.Add(polygonP);

            polygonQ = new GMapPolygon(polygonQpoints, "PolygonQ")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 0, 0, 255))
            };
            polygonsOverlay.Polygons.Add(polygonQ);

            polygonR = new GMapPolygon(polygonRpoints, "PolygonR")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 0, 204, 204))
            };
            polygonsOverlay.Polygons.Add(polygonR);

            polygonS = new GMapPolygon(polygonSpoints, "PolygonS")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 0, 0, 255))
            };
            polygonsOverlay.Polygons.Add(polygonS);

            polygonT = new GMapPolygon(polygonTpoints, "PolygonT")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 0, 204, 204))
            };
            polygonsOverlay.Polygons.Add(polygonT);

            polygonU = new GMapPolygon(polygonUpoints, "PolygonU")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 0, 0, 255))
            };
            polygonsOverlay.Polygons.Add(polygonU);

            polygonV = new GMapPolygon(polygonVpoints, "PolygonV")
            {
                Stroke = new Pen(Color.LightBlue, 2),
                Fill = new SolidBrush(Color.FromArgb(opacity, 0, 204, 204))
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

            //Mapa.Overlays.Add(polygonsOverlay);

            #endregion //  Class variables

            CalculateARP_MLAT_SMR_coordinates(); // Calculamos las cooreenadas Geodesicas, Estereograficas y ÇSystem Cartesian del centro de coordenadas ARP, SMR, MLAT
        }

        private void bt_Performances_Click(object sender, EventArgs e)
        {
            panel_Mapa.Visible = false;
        }

        private void bt_Map_Click(object sender, EventArgs e)
        {
            panel_Mapa.Visible = true;
        }

        private void rb_PlotAllfromASTERIXfile_MouseClick(object sender, MouseEventArgs e)
        {
            rb_allsamecolor.Enabled = true;
            rb_ColorbyGB.Enabled = true;
            rb_ColorbyAirportZone.Enabled = true;
        }

        private void rb_PlotCalVehiclefromASTfile_MouseClick(object sender, MouseEventArgs e)
        {
            rb_allsamecolor.Enabled = true;
            rb_ColorbyGB.Enabled = true;
            rb_ColorbyAirportZone.Enabled = true;
        }

        private void rb_plotCalVehiclefromTEXTfile_MouseClick(object sender, MouseEventArgs e)
        {
            rb_allsamecolor.Enabled = true;
            rb_ColorbyGB.Enabled = false;
            rb_ColorbyAirportZone.Enabled = false;
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            Mapa.Overlays.Clear();
            GMapOverlay overlay = new GMapOverlay();

            // Primero establecemos que queremos plotear

            // Creamos una lista por cada tipo de vehiculo:
            // Tipo 1: Todos los archivos MLAT
            // Tipo 2: Los archivo MLAT del vehiculo de calibracion
            // Tipo 3: Los archivos DGPS del .txt

            List<CAT10> lista_MLAT_AllPackets = new List<CAT10>();
            List<CAT10> lista_MLAT_CVPackets = new List<CAT10>();
            List<MLATCalibrationData> lista_CV_fromTXTfile = new List<MLATCalibrationData>();

            if (rb_PlotAllfromASTERIXfile.Checked)
            {
                lista_MLAT_AllPackets.AddRange(listaMLAT);
                FilterByAirportZones(listaMLAT);
            }
            else if (rb_PlotCalVehiclefromASTfile.Checked)
            {
                List<CAT10> lista11 = FilterMLATifCalibrationVehiclePresent(listaMLAT);
                FilterByAirportZones(lista11);
                lista_MLAT_CVPackets.AddRange(lista11);
            }
            else if (rb_plotCalVehiclefromTEXTfile.Checked)
            {
                lista_CV_fromTXTfile.AddRange(listaCalibrationDataVehicle);
            }

            // Ahora Coloreamos

            if (rb_allsamecolor.Checked)
            {
                if (lista_MLAT_AllPackets.Count > 0)
                {
                    for (int i = 0; i < lista_MLAT_AllPackets.Count(); i++)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lista_MLAT_AllPackets[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, lista_MLAT_AllPackets[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), red_circle);
                        overlay.Markers.Add(marker);
                    }
                }

                if (lista_MLAT_CVPackets.Count > 0)
                {
                    for (int i = 0; i < lista_MLAT_CVPackets.Count(); i++)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lista_MLAT_CVPackets[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, lista_MLAT_CVPackets[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), red_circle);
                        overlay.Markers.Add(marker);
                    }
                }

                if (lista_CV_fromTXTfile.Count > 0)
                {
                    for (int i = 0; i < lista_CV_fromTXTfile.Count(); i++)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lista_CV_fromTXTfile[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, lista_CV_fromTXTfile[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), red_circle);
                        overlay.Markers.Add(marker);
                    }
                }
            }

            else if (rb_ColorbyGB.Checked)
            {
                if (lista_MLAT_AllPackets.Count > 0)
                {
                    for (int i = 0; i < lista_MLAT_AllPackets.Count(); i++)
                    {
                        if (lista_MLAT_AllPackets[i].GBS == GBS)
                        {
                            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lista_MLAT_AllPackets[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, lista_MLAT_AllPackets[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), red_circle);
                            overlay.Markers.Add(marker);
                        }
                        else if (lista_MLAT_AllPackets[i].GBS == GBNS)
                        {
                            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lista_MLAT_AllPackets[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, lista_MLAT_AllPackets[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), white_circle);
                            overlay.Markers.Add(marker);
                        }
                    }
                }

                if (lista_MLAT_CVPackets.Count > 0)
                {
                    for (int i = 0; i < lista_MLAT_CVPackets.Count(); i++)
                    {
                        if (lista_MLAT_CVPackets[i].GBS == GBS)
                        {
                            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lista_MLAT_CVPackets[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, lista_MLAT_CVPackets[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), red_circle);
                            overlay.Markers.Add(marker);
                        }
                        else if (lista_MLAT_CVPackets[i].GBS == GBNS)
                        {
                            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lista_MLAT_CVPackets[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, lista_MLAT_CVPackets[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), white_circle);
                            overlay.Markers.Add(marker);
                        }
                    }
                }
            }

            else if (rb_ColorbyAirportZone.Checked)
            {
                if (lista_MLAT_AllPackets.Count > 0)
                {
                    for (int i = 0; i < listaMLAT_Stand.Count(); i++)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(listaMLAT_Stand[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listaMLAT_Stand[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), blue_circle);
                        overlay.Markers.Add(marker);
                    }

                    for (int i = 0; i < listaMLAT_Apron.Count(); i++)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(listaMLAT_Apron[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listaMLAT_Apron[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), green_circle);
                        overlay.Markers.Add(marker);
                    }

                    for (int i = 0; i < listaMLAT_MA.Count(); i++)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(listaMLAT_MA[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listaMLAT_MA[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), red_circle);
                        overlay.Markers.Add(marker);
                    }

                    for (int i = 0; i < listaMLAT_Airborne_2coma5NM.Count(); i++)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(listaMLAT_Airborne_2coma5NM[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listaMLAT_Airborne_2coma5NM[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), white_circle);
                        overlay.Markers.Add(marker);
                    }

                    for (int i = 0; i < listaMLAT_Airborne_5NM.Count(); i++)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(listaMLAT_Airborne_5NM[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listaMLAT_Airborne_5NM[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), pink_circle);
                        overlay.Markers.Add(marker);
                    }
                }

                if (lista_MLAT_CVPackets.Count() > 0)
                {
                    for (int i = 0; i < listaMLAT_Stand.Count(); i++)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(listaMLAT_Stand[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listaMLAT_Stand[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), blue_circle);
                        overlay.Markers.Add(marker);
                    }

                    for (int i = 0; i < listaMLAT_Apron.Count(); i++)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(listaMLAT_Apron[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listaMLAT_Apron[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), green_circle);
                        overlay.Markers.Add(marker);
                    }

                    for (int i = 0; i < listaMLAT_MA.Count(); i++)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(listaMLAT_MA[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listaMLAT_MA[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), red_circle);
                        overlay.Markers.Add(marker);
                    }

                    for (int i = 0; i < listaMLAT_Airborne_2coma5NM.Count(); i++)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(listaMLAT_Airborne_2coma5NM[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listaMLAT_Airborne_2coma5NM[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), white_circle);
                        overlay.Markers.Add(marker);
                    }

                    for (int i = 0; i < listaMLAT_Airborne_5NM.Count(); i++)
                    {
                        GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(listaMLAT_Airborne_5NM[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listaMLAT_Airborne_5NM[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), pink_circle);
                        overlay.Markers.Add(marker);
                    }
                }
            }

            if(cb_ShowAirportZones.Checked == true)
            {
                Mapa.Overlays.Add(polygonsOverlay);
            }

            Mapa.Overlays.Add(overlay);
        }

        private void ED2_Load(object sender, EventArgs e)
        {
            //////----------------------------------------------------------------------- Ploteamos en el mapa

            Mapa.DragButton = MouseButtons.Left;
            Mapa.CanDragMap = true;
            Mapa.MapProvider = GMapProviders.OpenCycleLandscapeMap;
            Mapa.Position = new PointLatLng(LatInicial, LongInicial);
            Mapa.MinZoom = 1;
            Mapa.MaxZoom = 30;
            Mapa.Zoom = 8;
            Mapa.AutoScroll = true;

            //////----------------------------------------------------------------------- Separamos lista CAT10 en listaMLAT y listaSMR

            for (int i = 0; i < listaCAT10.Count(); i++)
            {
                if (listaCAT10[i].SAC == 0 && listaCAT10[i].SIC == 7) { listaSMR.Add(listaCAT10[i]); }
                if (listaCAT10[i].SAC == 0 && listaCAT10[i].SIC == 107) { listaMLAT.Add(listaCAT10[i]); }
            }

            //////----------------------------------------------------------------------- Filtramos paquetes MLAT y ADSB (Quitamos periodic updates, ground vehicles, paquetes muy lejanos, paquetes con version MOPS != 2 etc...)

            FilterCAT21messages(listaCAT21); // eliminamos paquetes ground vehicle, periodic updates, MOPS != 2, etc...
            listaCAT21_NearAirport = FilterCAT21messagesAwayfromAirport(listaCAT21, 15000); // Limpiamos vuelos lejnos al aeropuerto para acelerar calculo

            FilterMLATmessages(listaMLAT); // eliminamos paquetes ground vehicle, periodic updates, etc...

            List<CAT10> lista11 = FilterMLATifCalibrationVehiclePresent(listaMLAT);
            FilterByAirportZones(lista11);
        }

        #region Buttons to calculate ED-117 performances from ASTERIX file

        private void bt_CalculateUpdateRate_ED117_ASTERIXfile_Click(object sender, EventArgs e)
        {
            List<IndividualBar> listBarsUpdateRate = new List<IndividualBar>();
            List<string> listaNombresUsados = new List<string>();
            List<List<CAT10>> listadelistasdeavionesconmismonombre = new List<List<CAT10>>();
            List<double> listaAvgDelay = new List<double>();

            int i = 0;
            while (i < listaMLAT.Count)
            {
                string TargetIdentification;
                string TargetAddress;

                if ((listaMLAT[i].TargetIdentification.Length > 0 && listaMLAT[i].TargetAdress.Length > 0) || (listaMLAT[i].TargetIdentification.Length > 0) || (listaMLAT[i].TargetAdress.Length > 0)) // cojemos los paquetes que tienen Target Address y/o Target Identification
                {
                    TargetIdentification = listaMLAT[i].TargetIdentification_decoded;
                    TargetAddress = listaMLAT[i].TargetAdress_decoded;

                    if ((listaNombresUsados.Contains(TargetIdentification) && listaNombresUsados.Contains(TargetAddress)) || (listaNombresUsados.Contains(TargetIdentification)) || (listaNombresUsados.Contains(TargetAddress))) // si Target Address y/o Target Identification estan en la lista de paquetes ya calculados no hacemos nada
                    { }
                    else
                    {
                        int j = i + 1;
                        List<CAT10> ListaPlanesMismoNombre = new List<CAT10>();
                        ListaPlanesMismoNombre.Add(listaMLAT[i]);
                        while (j < listaMLAT.Count)
                        {
                            if (listaMLAT[j].TargetIdentification_decoded == TargetIdentification && listaMLAT[j].TargetIdentification_decoded != "")
                            {
                                ListaPlanesMismoNombre.Add(listaMLAT[j]);
                                listaNombresUsados.Add(TargetIdentification);
                            }

                            else if (listaMLAT[j].TargetAdress_decoded == TargetAddress && listaMLAT[j].TargetAdress_decoded != "")
                            {
                                ListaPlanesMismoNombre.Add(listaMLAT[j]);
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

            BarGraphPlot BGP1 = new BarGraphPlot(listBarsUpdateRate);
            BGP1.Show();

            //List<IndividualBar> listbars1 = listBarsUpdateRate.OrderBy(o => o.AverageTime).ToList();

            // Primero escribimos resultados en DGV del form

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Target Address";
            dataGridView1.Columns[1].Name = "Average Update Rate";

            int n = dataGridView1.Rows.Add("Target Address", "Average Update Rate");

            for(int j = 0; j < listBarsUpdateRate.Count(); j++)
            {
                string UR = listBarsUpdateRate[j].AverageTime.ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dataGridView1.Rows.Add(listBarsUpdateRate[j].TargetAddress, UR);
            }

            // Luego escribimos resultados en el DGV del UpdateRate

            dgv_UpdateRate_fromASTERIXfile.Rows.Clear();
            dgv_UpdateRate_fromASTERIXfile.ColumnCount = 2;
            dgv_UpdateRate_fromASTERIXfile.Columns[0].Name = "Target Address";
            dgv_UpdateRate_fromASTERIXfile.Columns[1].Name = "Average Update Rate";

            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dataRow = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                dgv_UpdateRate_fromASTERIXfile.Rows.Add(dataRow);
            }
        }

        private void pb_ProbabilityofUpdate_ED117_ASTERIXfile_Click(object sender, EventArgs e)
        {
            FilterByAirportZones(listaMLAT);

            List<double> results1 = CalculateProbabilityofUpdate1(listaMLAT_Stand);
            List<double> results2 = CalculateProbabilityofUpdate1(listaMLAT_Stand_T1);
            List<double> results3 = CalculateProbabilityofUpdate1(listaMLAT_Stand_T2);
            List<double> results4 = CalculateProbabilityofUpdate1(listaMLAT_Apron);
            List<double> results5 = CalculateProbabilityofUpdate1(listaMLAT_Apron_T1);
            List<double> results6 = CalculateProbabilityofUpdate1(listaMLAT_Apron_T2);
            List<double> results7 = CalculateProbabilityofUpdate1(listaMLAT_MA);
            List<double> results8 = CalculateProbabilityofUpdate1(listaMLAT_RWY1);
            List<double> results9 = CalculateProbabilityofUpdate1(listaMLAT_RWY2);
            List<double> results10 = CalculateProbabilityofUpdate1(listaMLAT_RWY3);
            List<double> results11 = CalculateProbabilityofUpdate1(listaMLAT_Taxiway);
            List<double> results12 = CalculateProbabilityofUpdate1(listaMLAT_Airborne_2coma5NM);
            List<double> results13 = CalculateProbabilityofUpdate1(listaMLAT_Airborne_5NM);
            List<double> results14 = CalculateProbabilityofUpdate1(listaMLAT);

            //--------------------------------

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Airport Zone";
            dataGridView1.Columns[1].Name = "Received Updates";
            dataGridView1.Columns[2].Name = "Expected Updates";
            dataGridView1.Columns[3].Name = "Probability of Update (%)";
            dataGridView1.Columns[4].Name = "ED - 117 Value (%)";

            DataGridViewCellStyle style = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style.BackColor = Color.LightGray;

            DataGridViewCellStyle style1 = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style1.Font = new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold);



            int n = dataGridView1.Rows.Add("Airport Zone", "Received Updates", "Expected Updates", "Probability of Update (%)", "ED - 117 Value (%)");

            string PU1 = Math.Round(results1[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("STAND", results1[0], results1[1], PU1, "50 %");
            string PU2 = Math.Round(results2[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("STAND T1", results2[0], results2[1], PU2, "-----");
            string PU3 = Math.Round(results3[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("STAND T2", results3[0], results3[1], PU3, "-----");
            string PU4 = Math.Round(results4[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("APRON", results4[0], results4[1], PU4, "70 %");
            string PU5 = Math.Round(results5[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("APRON T1", results5[0], results5[1], PU5, "-----");
            string PU6 = Math.Round(results6[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("APRON T2", results6[0], results6[1], PU6, "------");
            string PU7 = Math.Round(results7[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("MANEUVERING AREA", results7[0], results7[1], PU7, "95 %");
            string PU8 = Math.Round(results8[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("RUNWAY 02 / 20", results8[0], results8[1], PU8, "-----");
            string PU9 = Math.Round(results9[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("RUNWAY 07R / 25L", results9[0], results9[1], PU9, "-----");
            string PU10 = Math.Round(results10[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("RUNWAY 07L / 25R", results10[0], results10[1], PU10, "----");
            string PU11 = Math.Round(results11[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("TAXIWAY", results11[0], results11[1], PU11, "----");
            string PU12 = Math.Round(results12[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("AIRBORNE 0 - 2.5 NM", results12[0], results12[1],PU12, "95 %");
            string PU13 = Math.Round(results13[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("AIRBORNE 2.5 NM - 5 NM", results13[0], results13[1], PU13, "95 %");

            double received_messages = results1[0] + results4[0] + results7[0] + results12[0] + results13[0];
            double expected_messages = results1[1] + results4[1] + results7[1] + results12[1] + results13[1];
            string PU14 = Math.Round((received_messages / expected_messages) * 100, 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("TOTAL",received_messages, expected_messages, PU14 , "-----");

            // Coloreamos los bordes en gris

            dataGridView1.Columns[0].DefaultCellStyle = style;
            dataGridView1.Rows[0].DefaultCellStyle = style;

            // Negrita en las zonas importantes

            dataGridView1.Rows[1].DefaultCellStyle = style1;
            dataGridView1.Rows[4].DefaultCellStyle = style1;
            dataGridView1.Rows[7].DefaultCellStyle = style1;
            dataGridView1.Rows[12].DefaultCellStyle = style1;
            dataGridView1.Rows[13].DefaultCellStyle = style1;
            dataGridView1.Rows[14].DefaultCellStyle = style1;


            // Luego escribimos resultados en el DGV del probability of update

            dgv_ProbabilityofUpdate_fromASTERIXfile.Rows.Clear();
            dgv_ProbabilityofUpdate_fromASTERIXfile.ColumnCount = 5;
            dgv_ProbabilityofUpdate_fromASTERIXfile.Columns[0].Name = "Airport Zone";
            dgv_ProbabilityofUpdate_fromASTERIXfile.Columns[1].Name = "Received Updates";
            dgv_ProbabilityofUpdate_fromASTERIXfile.Columns[2].Name = "Expected Updates";
            dgv_ProbabilityofUpdate_fromASTERIXfile.Columns[3].Name = "Probability of Update (%)";
            dgv_ProbabilityofUpdate_fromASTERIXfile.Columns[4].Name = "ED - 117 Value (%)";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dataRow = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                dgv_ProbabilityofUpdate_fromASTERIXfile.Rows.Add(dataRow);
            }
        }

        private void bt_CalculatePrecissionAccuracy_ED117_ASTERIXfile_Click(object sender, EventArgs e)
        {
            FilterByAirportZones(listaMLAT);

            string[] mychars = { Convert.ToString(""), Convert.ToString(' '), Convert.ToString('\t') };
            string[] properties = comboBox1.Text.Split(mychars, StringSplitOptions.RemoveEmptyEntries);

            double PIC;
            try
            {
                PIC = Convert.ToInt32(properties[0]);
            }
            catch
            {
                // Buscamos todos los PIC
                List<double> listPIC = new List<double>();
                for(int i = 0; i<listaCAT21.Count(); i++)
                {
                    listPIC.Add(listaCAT21[i].PIC);
                }

                listPIC.Sort();
                PIC = Percentile(listPIC, 0.75);
            }

            var results1 = CalculatePrecissionAccuracy(listaMLAT_Stand, listaCAT21_NearAirport, PIC);
            var results2 = CalculatePrecissionAccuracy(listaMLAT_Stand_T1, listaCAT21_NearAirport, PIC);
            var results3 = CalculatePrecissionAccuracy(listaMLAT_Stand_T2, listaCAT21_NearAirport, PIC);
            var results4 = CalculatePrecissionAccuracy(listaMLAT_Apron, listaCAT21_NearAirport, PIC);
            var results5 = CalculatePrecissionAccuracy(listaMLAT_Apron_T1, listaCAT21_NearAirport, PIC);
            var results6 = CalculatePrecissionAccuracy(listaMLAT_Apron_T2, listaCAT21_NearAirport, PIC);
            var results7 = CalculatePrecissionAccuracy(listaMLAT_MA, listaCAT21_NearAirport, PIC);
            var results71 = CalculatePrecissionAccuracy(listaMLAT_MA, listaCAT21_NearAirport, PIC);
            var results8 = CalculatePrecissionAccuracy(listaMLAT_RWY1, listaCAT21_NearAirport, PIC);
            var results9 = CalculatePrecissionAccuracy(listaMLAT_RWY2, listaCAT21_NearAirport, PIC);
            var results10 = CalculatePrecissionAccuracy(listaMLAT_RWY3, listaCAT21_NearAirport, PIC);
            var results11 = CalculatePrecissionAccuracy(listaMLAT_Taxiway, listaCAT21_NearAirport, PIC);
            var results12 = CalculatePrecissionAccuracy(listaMLAT_Airborne_2coma5NM, listaCAT21_NearAirport, PIC);
            var results13 = CalculatePrecissionAccuracy(listaMLAT_Airborne_5NM, listaCAT21_NearAirport, PIC);
            var results14 = CalculatePrecissionAccuracy(listaMLAT, listaCAT21_NearAirport, PIC);

            // Creamos DGV y columnas
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Airport Zone";
            dataGridView1.Columns[1].Name = "95th Percentile (m)";
            dataGridView1.Columns[2].Name = "ED-117 Value (m)";
            dataGridView1.Columns[3].Name = "99th Percentile (m)";
            dataGridView1.Columns[4].Name = "ED-117 Value (m)";
            dataGridView1.Columns[5].Name = "Mean (m)";
            dataGridView1.Columns[6].Name = "STD Deviation (m)";
            dataGridView1.Columns[7].Name = "Samples";

            DataGridViewCellStyle style = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style.BackColor = Color.LightGray;

            DataGridViewCellStyle style1 = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style1.Font = new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold);

            int n = dataGridView1.Rows.Add("Airport Zone", "95th Percentile (m)", "ED-117 Value (m)", "99th Percentile (m)", "ED-117 Value (m)", "Mean (m)", "STD Deviation (m)", "Samples");

            string P951 = Math.Round(Percentile(results1[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P991 = Math.Round(Percentile(results1[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD1 = Math.Round(CalculateStandardDeviation(results1[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG1 = "0";
            if (results1[0].Count() != 0) { AVG1 = Math.Round(results1[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("STAND", P951, "20", P991, "-----", AVG1, STD1, results1[0].Count().ToString());

            string P952 = Math.Round(Percentile(results2[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P992 = Math.Round(Percentile(results2[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD2 = Math.Round(CalculateStandardDeviation(results2[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG2 = "0";
            if (results2[0].Count() != 0) { AVG2 = Math.Round(results2[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("STAND T1", P952, "-----", P992, "-----", AVG2, STD2, results2[0].Count().ToString());

            string P953 = Math.Round(Percentile(results3[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P993 = Math.Round(Percentile(results3[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD3 = Math.Round(CalculateStandardDeviation(results3[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG3 = "0";
            if (results3[0].Count() != 0) { AVG3 = Math.Round(results3[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("STAND T2", P953, "-----", P993, "-----", AVG3, STD3, results3[0].Count().ToString());

            string P954 = Math.Round(Percentile(results4[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P994 = Math.Round(Percentile(results4[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD4 = Math.Round(CalculateStandardDeviation(results4[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG4 = "0";
            if (results4[0].Count() != 0) { AVG4 = Math.Round(results4[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("APRON", P954, "-----", P994, "-----", AVG4, STD4, results4[0].Count().ToString());

            string P955 = Math.Round(Percentile(results5[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P995 = Math.Round(Percentile(results5[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD5 = Math.Round(CalculateStandardDeviation(results5[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG5 = "0";
            if (results5[0].Count() != 0) { AVG5 = Math.Round(results5[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("APRON T1", P955, "-----", P995, "-----", AVG5, STD5, results5[0].Count().ToString());

            string P956 = Math.Round(Percentile(results6[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P996 = Math.Round(Percentile(results6[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD6 = Math.Round(CalculateStandardDeviation(results6[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG6 = "0";
            if (results6[0].Count() != 0) { AVG6 = Math.Round(results6[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("APRON T2", P956, "-----", P996, "-----", AVG6, STD6, results6[0].Count().ToString());

            string P957 = Math.Round(Percentile(results7[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P997 = Math.Round(Percentile(results7[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD7 = Math.Round(CalculateStandardDeviation(results7[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG7 = "0";
            if (results1[0].Count() != 0) { AVG7 = Math.Round(results1[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("MANEUVERING AREA", P957, "7.5 m", P997, "12 m", AVG7, STD7, results7[0].Count().ToString());

            string P958 = Math.Round(Percentile(results8[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P998 = Math.Round(Percentile(results8[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD8 = Math.Round(CalculateStandardDeviation(results8[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG8 = "0";
            if (results8[0].Count() != 0) { AVG8 = Math.Round(results8[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("RUNWAY 02 / 20", P958, "-----", P998, "-----", AVG8, STD8, results8[0].Count().ToString());

            string P959 = Math.Round(Percentile(results9[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P999 = Math.Round(Percentile(results9[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD9 = Math.Round(CalculateStandardDeviation(results9[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG9 = "0";
            if (results9[0].Count() != 0) { AVG9 = Math.Round(results9[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("RUNWAY 07R / 25L", P959, "-----", P999, "-----", AVG9, STD9, results9[0].Count().ToString());

            string P9510 = Math.Round(Percentile(results10[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P9910 = Math.Round(Percentile(results10[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD10 = Math.Round(CalculateStandardDeviation(results10[0]), 3).ToString().ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG10 = "0";
            if (results10[0].Count() != 0) { AVG10 = Math.Round(results10[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("RUNWAY 07L / 25R", P9510, "-----", P9910, "-----", AVG10, STD10, results10[0].Count().ToString());

            string P9511 = Math.Round(Percentile(results11[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P9911 = Math.Round(Percentile(results11[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD11 = Math.Round(CalculateStandardDeviation(results11[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG11 = "0";
            if (results11[0].Count() != 0) { AVG11 = Math.Round(results11[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("TAXYWAY", P9511, "-----", P9911, "-----", AVG11, STD11, results11[0].Count().ToString());

            string P9512 = Math.Round(Percentile(results12[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P9912 = Math.Round(Percentile(results12[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD12 = Math.Round(CalculateStandardDeviation(results12[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG12 = "0";
            if (results12[0].Count() != 0) { AVG12 = Math.Round(results12[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("AIRBORNE 0 - 2.5 NM", P9512, "20 m", P9912, "-----", AVG12, STD12, results12[0].Count().ToString());

            string P9513 = Math.Round(Percentile(results13[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P9913 = Math.Round(Percentile(results13[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD13 = Math.Round(CalculateStandardDeviation(results13[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG13 = "0";
            if (results13[0].Count() != 0) { AVG13 = Math.Round(results13[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("AIRBORNE 2.5 - 5 NM", P9513, "40 m", P9913, "-----", AVG13, STD13, results13[0].Count().ToString());

            // Coloreamos los bordes en gris

            dataGridView1.Columns[0].DefaultCellStyle = style;
            dataGridView1.Rows[0].DefaultCellStyle = style;

            // Negrita en las zonas importantes

            dataGridView1.Rows[1].DefaultCellStyle = style1;
            dataGridView1.Rows[4].DefaultCellStyle = style1;
            dataGridView1.Rows[7].DefaultCellStyle = style1;
            dataGridView1.Rows[12].DefaultCellStyle = style1;
            dataGridView1.Rows[13].DefaultCellStyle = style1;
            dataGridView1.Rows[14].DefaultCellStyle = style1;

            dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Clear();
            dgv_PrecissionAccuracy_fromASTERIXfile.ColumnCount = 8;
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[0].Name = "Airport Zone";
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[1].Name = "95th Percentile (m)";
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[2].Name = "ED-117 Value (m)";
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[3].Name = "99th Percentile (m)";
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[4].Name = "ED-117 Value (m)";
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[5].Name = "Mean (m)";
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[6].Name = "STD Deviation (m)";
            dgv_PrecissionAccuracy_fromASTERIXfile.Columns[7].Name = "Samples";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dataRow = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Add(dataRow);
            }

            // Luego escribimos resultados en el DGV del UpdateRate

            dgv_PrecissionAccuracyError_Stand_fromASTERIXfile.Rows.Clear();
            dgv_PrecissionAccuracyError_Stand_fromASTERIXfile.ColumnCount = 2;
            dgv_PrecissionAccuracyError_Stand_fromASTERIXfile.Columns[0].Name = "X error";
            dgv_PrecissionAccuracyError_Stand_fromASTERIXfile.Columns[1].Name = "Y error";

            n = dgv_PrecissionAccuracyError_Stand_fromASTERIXfile.Rows.Add("X error", "Y error");

            //Stand
            for (int j = 0; j < results1[0].Count(); j++)
            {
                string Xerror = Math.Round(results1[1][j], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string Yerror = Math.Round(results1[2][j], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_PrecissionAccuracyError_Stand_fromASTERIXfile.Rows.Add(Xerror, Yerror);
            }

            dgv_PrecissionAccuracyError_Apron_fromASTERIXfile.Rows.Clear();
            dgv_PrecissionAccuracyError_Apron_fromASTERIXfile.ColumnCount = 2;
            dgv_PrecissionAccuracyError_Apron_fromASTERIXfile.Columns[0].Name = "X error";
            dgv_PrecissionAccuracyError_Apron_fromASTERIXfile.Columns[1].Name = "Y error";

            n = dgv_PrecissionAccuracyError_Apron_fromASTERIXfile.Rows.Add("X error", "Y error");

            //Apron
            for (int j = 0; j < results4[0].Count(); j++)
            {
                string Xerror = Math.Round(results4[1][j], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string Yerror = Math.Round(results4[2][j], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_PrecissionAccuracyError_Apron_fromASTERIXfile.Rows.Add(Xerror, Yerror);
            }

            dgv_PrecissionAccuracyError_MA_fromASTERIXfile.Rows.Clear();
            dgv_PrecissionAccuracyError_MA_fromASTERIXfile.ColumnCount = 2;
            dgv_PrecissionAccuracyError_MA_fromASTERIXfile.Columns[0].Name = "X error";
            dgv_PrecissionAccuracyError_MA_fromASTERIXfile.Columns[1].Name = "Y error";

            n = dgv_PrecissionAccuracyError_MA_fromASTERIXfile.Rows.Add("X error", "Y error");

            //MA
            for (int j = 0; j < results7[0].Count(); j++)
            {
                string Xerror = Math.Round(results7[1][j], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string Yerror = Math.Round(results7[2][j], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_PrecissionAccuracyError_MA_fromASTERIXfile.Rows.Add(Xerror, Yerror);
            }

            dgv_PrecissionAccuracyError_Airborne25_fromASTERIXfile.Rows.Clear();
            dgv_PrecissionAccuracyError_Airborne25_fromASTERIXfile.ColumnCount = 2;
            dgv_PrecissionAccuracyError_Airborne25_fromASTERIXfile.Columns[0].Name = "X error";
            dgv_PrecissionAccuracyError_Airborne25_fromASTERIXfile.Columns[1].Name = "Y error";

            n = dgv_PrecissionAccuracyError_Airborne25_fromASTERIXfile.Rows.Add("X error", "Y error");

            //Airborne 2.5 NM
            for (int j = 0; j < results12[0].Count(); j++)
            {
                string Xerror = Math.Round(results12[1][j], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string Yerror = Math.Round(results12[2][j], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_PrecissionAccuracyError_Airborne25_fromASTERIXfile.Rows.Add(Xerror, Yerror);
            }

            dgv_PrecissionAccuracyError_Airborne5_fromASTERIXfile.Rows.Clear();
            dgv_PrecissionAccuracyError_Airborne5_fromASTERIXfile.ColumnCount = 2;
            dgv_PrecissionAccuracyError_Airborne5_fromASTERIXfile.Columns[0].Name = "X error";
            dgv_PrecissionAccuracyError_Airborne5_fromASTERIXfile.Columns[1].Name = "Y error";

            n = dgv_PrecissionAccuracyError_Airborne5_fromASTERIXfile.Rows.Add("X error", "Y error");

            //Airborne 5 NM
            for (int j = 0; j < results13[0].Count(); j++)
            {
                string Xerror = Math.Round(results13[1][j], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string Yerror = Math.Round(results13[2][j], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_PrecissionAccuracyError_Airborne5_fromASTERIXfile.Rows.Add(Xerror, Yerror);
            }

            dgv_PrecissionAccuracyError_Total_fromASTERIXfile.Rows.Clear();
            dgv_PrecissionAccuracyError_Total_fromASTERIXfile.ColumnCount = 2;
            dgv_PrecissionAccuracyError_Total_fromASTERIXfile.Columns[0].Name = "X error";
            dgv_PrecissionAccuracyError_Total_fromASTERIXfile.Columns[1].Name = "Y error";

            n = dgv_PrecissionAccuracyError_Total_fromASTERIXfile.Rows.Add("X error", "Y error");

            //Total
            for (int j = 0; j < results14[0].Count(); j++)
            {
                string Xerror = Math.Round(results14[1][j], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                string Yerror = Math.Round(results14[2][j], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
                n = dgv_PrecissionAccuracyError_Total_fromASTERIXfile.Rows.Add(Xerror, Yerror);
            }
        }

        private void bt_CalculateProbabilityofMLATDetection_ED117_ASTERIXfile_Click(object sender, EventArgs e)
        {
            FilterByAirportZones(listaMLAT);

            List<double> results1 = CalculatePRobabilityofMLATDetection1(listaMLAT_Stand, 5);
            List<double> results2 = CalculatePRobabilityofMLATDetection1(listaMLAT_Stand_T1, 5);
            List<double> results3 = CalculatePRobabilityofMLATDetection1(listaMLAT_Stand_T2, 5);
            List<double> results4 = CalculatePRobabilityofMLATDetection1(listaMLAT_Apron, 2);
            List<double> results5 = CalculatePRobabilityofMLATDetection1(listaMLAT_Apron_T1, 2);
            List<double> results6 = CalculatePRobabilityofMLATDetection1(listaMLAT_Apron_T2, 2);
            List<double> results7 = CalculatePRobabilityofMLATDetection1(listaMLAT_MA, 2);
            List<double> results8 = CalculatePRobabilityofMLATDetection1(listaMLAT_RWY1, 2);
            List<double> results9 = CalculatePRobabilityofMLATDetection1(listaMLAT_RWY2, 2);
            List<double> results10 = CalculatePRobabilityofMLATDetection1(listaMLAT_RWY3, 2);
            List<double> results11 = CalculatePRobabilityofMLATDetection1(listaMLAT_Taxiway, 2);
            List<double> results12 = CalculatePRobabilityofMLATDetection1(listaMLAT_Airborne_2coma5NM, 1);
            List<double> results13 = CalculatePRobabilityofMLATDetection1(listaMLAT_Airborne_5NM, 1);

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Airport Zone";
            dataGridView1.Columns[1].Name = "Received Updates";
            dataGridView1.Columns[2].Name = "Expected Updates";
            dataGridView1.Columns[3].Name = "Probability of MLAT Detection (%)";
            dataGridView1.Columns[4].Name = "ED - 117 Value (%)";

            DataGridViewCellStyle style = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style.BackColor = Color.LightGray;

            DataGridViewCellStyle style1 = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style1.Font = new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold);

            int n = dataGridView1.Rows.Add("Airport Zone", "Received Updates", "Expected Updates", "Probability of MLAT Detection (%)", "ED - 117 Value (%)");

            string PU1 = Math.Round(results1[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("STAND", results1[0], results1[1], PU1, "-----");
            string PU2 = Math.Round(results2[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("STAND T1", results2[0], results2[1], PU2, "-----");
            string PU3 = Math.Round(results3[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("STAND T2", results3[0], results3[1], PU3, "-----");
            string PU4 = Math.Round(results4[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("APRON", results4[0], results4[1], PU4, "-----");
            string PU5 = Math.Round(results5[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("APRON T1", results5[0], results5[1], PU5, "-----");
            string PU6 = Math.Round(results6[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("APRON T2", results6[0], results6[1], PU6, "------");
            string PU7 = Math.Round(results7[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("MANEUVERING AREA", results7[0], results7[1], PU7, "-----");
            string PU8 = Math.Round(results8[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("RUNWAY 02 / 20", results8[0], results8[1], PU8, "-----");
            string PU9 = Math.Round(results9[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("RUNWAY 07R / 25L", results9[0], results9[1], PU9, "-----");
            string PU10 = Math.Round(results10[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("RUNWAY 07L / 25R", results10[0], results10[1], PU10, "----");
            string PU11 = Math.Round(results11[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("TAXIWAY", results11[0], results11[1], PU11, "----");
            string PU12 = Math.Round(results12[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("AIRBORNE 0 - 2.5 NM", results12[0], results12[1], PU12, "----");
            string PU13 = Math.Round(results13[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("AIRBORNE 2.5 - 5 NM", results13[0], results13[1], PU13, "----");

            double received_messages = results1[0] + results4[0] + results7[0] + results12[0] + results13[0];
            double expected_messages = results1[1] + results4[1] + results7[1] + results12[1] + results13[1];
            string PU14 = Math.Round((received_messages / expected_messages) * 100, 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("TOTAL", received_messages, expected_messages, PU14, "99.9");



            // Coloreamos los bordes en gris

            dataGridView1.Columns[0].DefaultCellStyle = style;
            dataGridView1.Rows[0].DefaultCellStyle = style;

            // Negrita en las zonas importantes

            dataGridView1.Rows[1].DefaultCellStyle = style1;
            dataGridView1.Rows[4].DefaultCellStyle = style1;
            dataGridView1.Rows[7].DefaultCellStyle = style1;
            dataGridView1.Rows[12].DefaultCellStyle = style1;
            dataGridView1.Rows[13].DefaultCellStyle = style1;
            dataGridView1.Rows[14].DefaultCellStyle = style1;

            dgv_ProbabilityofMLATDetection_fromASTERIXfile.Rows.Clear();
            dgv_ProbabilityofMLATDetection_fromASTERIXfile.ColumnCount = 5;
            dgv_ProbabilityofMLATDetection_fromASTERIXfile.Columns[0].Name = "Airport Zone";
            dgv_ProbabilityofMLATDetection_fromASTERIXfile.Columns[1].Name = "Received Updates";
            dgv_ProbabilityofMLATDetection_fromASTERIXfile.Columns[2].Name = "Expected Updates";
            dgv_ProbabilityofMLATDetection_fromASTERIXfile.Columns[3].Name = "Probability of MLAT Detection (%)";
            dgv_ProbabilityofMLATDetection_fromASTERIXfile.Columns[4].Name = "ED - 117 Value (%)";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dataRow = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                dgv_ProbabilityofMLATDetection_fromASTERIXfile.Rows.Add(dataRow);
            }
        }

        private void bt_ProbabilityofIdentification_ED117_ASTERIXfile_Click(object sender, EventArgs e)
        {
            FilterByAirportZones(listaMLAT);

            List<double> results1 = CalculatePRobabilityofIdentification(listaMLAT_Stand);
            List<double> results2 = CalculatePRobabilityofIdentification(listaMLAT_Stand_T1);
            List<double> results3 = CalculatePRobabilityofIdentification(listaMLAT_Stand_T2);
            List<double> results4 = CalculatePRobabilityofIdentification(listaMLAT_Apron);
            List<double> results5 = CalculatePRobabilityofIdentification(listaMLAT_Apron_T1);
            List<double> results6 = CalculatePRobabilityofIdentification(listaMLAT_Apron_T2);
            List<double> results7 = CalculatePRobabilityofIdentification(listaMLAT_MA);
            List<double> results8 = CalculatePRobabilityofIdentification(listaMLAT_RWY1);
            List<double> results9 = CalculatePRobabilityofIdentification(listaMLAT_RWY2);
            List<double> results10 = CalculatePRobabilityofIdentification(listaMLAT_RWY3);
            List<double> results11 = CalculatePRobabilityofIdentification(listaMLAT_Taxiway);
            List<double> results12 = CalculatePRobabilityofIdentification(listaMLAT_Airborne_2coma5NM);
            List<double> results13 = CalculatePRobabilityofIdentification(listaMLAT_Airborne_5NM);

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Airport Zone";
            dataGridView1.Columns[1].Name = "Expected Updates";
            dataGridView1.Columns[2].Name = "Received Updates";
            dataGridView1.Columns[3].Name = "Probability of Identification (%)";
            dataGridView1.Columns[4].Name = "ED - 117 Value (%)";

            int n = dataGridView1.Rows.Add("Airport Zone", "Expected Updates", "Received Updates", "Probability of Identification (%)", "ED - 117 Value (%)");

            string PI1 = Math.Round(results1[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI2 = Math.Round(results2[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI3 = Math.Round(results3[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI4 = Math.Round(results4[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI5 = Math.Round(results5[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI6 = Math.Round(results6[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI7 = Math.Round(results7[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI8 = Math.Round(results8[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI9 = Math.Round(results9[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI10 = Math.Round(results10[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI11 = Math.Round(results11[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI12 = Math.Round(results12[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI13 = Math.Round(results13[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));


            n = dataGridView1.Rows.Add("STAND", results1[0], results1[1], PI1, "-----");
            n = dataGridView1.Rows.Add("STAND T1", results2[0], results2[1], PI2, "-----");
            n = dataGridView1.Rows.Add("STAND T2", results3[0], results3[1], PI3, "-----");
            n = dataGridView1.Rows.Add("APRON", results4[0], results4[1], PI4, "-----");
            n = dataGridView1.Rows.Add("APRON T1", results5[0], results5[1], PI5, "-----");
            n = dataGridView1.Rows.Add("APRON T2", results6[0], results6[1], PI6, "-----");
            n = dataGridView1.Rows.Add("MANEUVERING AREA", results7[0], results7[1], PI7, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 02 / 20", results8[0], results8[1], PI8, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 07R / 25L", results9[0], results9[1], PI9, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 07L / 25R", results10[0], results10[1], PI10, "-----");
            n = dataGridView1.Rows.Add("TAXIWAY", results11[0], results11[1], PI11, "-----");
            n = dataGridView1.Rows.Add("AIRBORNE 0 - 2.5 NM", results12[0], results12[1], PI12, "-----");
            n = dataGridView1.Rows.Add("AIRBORNE 2.5 - 5 NM", results13[0], results13[1], PI13, "-----");

            double received_messages = results1[0] + results4[0] + results7[0] + results12[0] + results13[0];
            double expected_messages = results1[1] + results4[1] + results7[1] + results12[1] + results13[1];
            string PU14 = Math.Round((received_messages / expected_messages) * 100, 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("TOTAL", received_messages, expected_messages, PU14, "99.9");

            DataGridViewCellStyle style = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style.BackColor = Color.LightGray;

            DataGridViewCellStyle style1 = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style1.Font = new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold);

            // Coloreamos los bordes en gris

            dataGridView1.Columns[0].DefaultCellStyle = style;
            dataGridView1.Rows[0].DefaultCellStyle = style;

            // Negrita en las zonas importantes

            dataGridView1.Rows[1].DefaultCellStyle = style1;
            dataGridView1.Rows[4].DefaultCellStyle = style1;
            dataGridView1.Rows[7].DefaultCellStyle = style1;
            dataGridView1.Rows[12].DefaultCellStyle = style1;
            dataGridView1.Rows[13].DefaultCellStyle = style1;
            dataGridView1.Rows[14].DefaultCellStyle = style1;

            dgv_ProbabilityofIdentification_fromASTERIXfile.Rows.Clear();
            dgv_ProbabilityofIdentification_fromASTERIXfile.ColumnCount = 5;
            dgv_ProbabilityofIdentification_fromASTERIXfile.Columns[0].Name = "Airport Zone";
            dgv_ProbabilityofIdentification_fromASTERIXfile.Columns[1].Name = "Expected Updates";
            dgv_ProbabilityofIdentification_fromASTERIXfile.Columns[2].Name = "Received Updates";
            dgv_ProbabilityofIdentification_fromASTERIXfile.Columns[3].Name = "Probability of Identification (%)";
            dgv_ProbabilityofIdentification_fromASTERIXfile.Columns[4].Name = "ED - 117 Value (%)";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dataRow = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                dgv_ProbabilityofIdentification_fromASTERIXfile.Rows.Add(dataRow);
            }
        }

        private void bt_CalculateProbabilityofFalseDetection_Click(object sender, EventArgs e)
        {
            FilterByAirportZones(listaMLAT);

            List<double> results1 = CalculatePRobabilityofFalseDetection(listaMLAT_Stand, 50);
            List<double> results2 = CalculatePRobabilityofFalseDetection(listaMLAT_Stand_T1, 50);
            List<double> results3 = CalculatePRobabilityofFalseDetection(listaMLAT_Stand_T2, 50);
            List<double> results4 = CalculatePRobabilityofFalseDetection(listaMLAT_Apron, 50);
            List<double> results5 = CalculatePRobabilityofFalseDetection(listaMLAT_Apron_T1, 50);
            List<double> results6 = CalculatePRobabilityofFalseDetection(listaMLAT_Apron_T2, 50);
            List<double> results7 = CalculatePRobabilityofFalseDetection(listaMLAT_MA, 50);
            List<double> results8 = CalculatePRobabilityofFalseDetection(listaMLAT_RWY1, 50);
            List<double> results9 = CalculatePRobabilityofFalseDetection(listaMLAT_RWY2, 50);
            List<double> results10 = CalculatePRobabilityofFalseDetection(listaMLAT_RWY3, 50);
            List<double> results11 = CalculatePRobabilityofFalseDetection(listaMLAT_Taxiway, 50);
            List<double> results12 = CalculatePRobabilityofFalseDetection(listaMLAT_Airborne_2coma5NM, 80);
            List<double> results13 = CalculatePRobabilityofFalseDetection(listaMLAT_Airborne_5NM, 160);

            string PI1 = Math.Round(results1[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI2 = Math.Round(results2[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI3 = Math.Round(results3[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI4 = Math.Round(results4[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI5 = Math.Round(results5[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI6 = Math.Round(results6[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI7 = Math.Round(results7[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI8 = Math.Round(results8[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI9 = Math.Round(results9[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI10 = Math.Round(results10[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI11 = Math.Round(results11[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI12 = Math.Round(results12[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI13 = Math.Round(results13[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Airport Zone";
            dataGridView1.Columns[1].Name = "False Detections";
            dataGridView1.Columns[2].Name = "Received Detections";
            dataGridView1.Columns[3].Name = "Probability of False Detection (%)";
            dataGridView1.Columns[4].Name = "ED - 117 Value (%)";

            int n = dataGridView1.Rows.Add("Airport Zone", "Expected Updates", "Received Updates", "Probability of False Detection (%)", "ED - 117 Value (%)");

            n = dataGridView1.Rows.Add("STAND", results1[0], results1[1], PI1, "-----");
            n = dataGridView1.Rows.Add("STAND T1", results2[0], results2[1], PI2, "-----");
            n = dataGridView1.Rows.Add("STAND T2", results3[0], results3[1], PI3, "-----");
            n = dataGridView1.Rows.Add("APRON", results4[0], results4[1], PI4, "-----");
            n = dataGridView1.Rows.Add("APRON T1", results5[0], results5[1], PI5, "-----");
            n = dataGridView1.Rows.Add("APRON T2", results6[0], results6[1], PI6, "-----");
            n = dataGridView1.Rows.Add("MANEUVERING AREA", results7[0], results7[1], PI7, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 02 / 20", results8[0], results8[1], PI8, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 07R / 25L", results9[0], results9[1], PI9, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 07L / 25R", results10[0], results10[1], PI10, "-----");
            n = dataGridView1.Rows.Add("TAXIWAY", results11[0], results11[1], PI11, "-----");
            n = dataGridView1.Rows.Add("AIRBORNE 0 - 2.5 NM", results12[0], results12[1], PI12, "-----");
            n = dataGridView1.Rows.Add("AIRBORNE 2.5 - 5 NM", results13[0], results13[1], PI13, "-----");

            double received_messages = results1[0] + results4[0] + results7[0] + results12[0] + results13[0];
            double expected_messages = results1[1] + results4[1] + results7[1] + results12[1] + results13[1];
            string PI14 = Math.Round((received_messages / expected_messages) * 100, 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));

            n = dataGridView1.Rows.Add("TOTAL", received_messages, expected_messages, PI14, "0.01");

            DataGridViewCellStyle style = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style.BackColor = Color.LightGray;

            DataGridViewCellStyle style1 = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style1.Font = new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold);

            // Coloreamos los bordes en gris

            dataGridView1.Columns[0].DefaultCellStyle = style;
            dataGridView1.Rows[0].DefaultCellStyle = style;

            // Negrita en las zonas importantes

            dataGridView1.Rows[1].DefaultCellStyle = style1;
            dataGridView1.Rows[4].DefaultCellStyle = style1;
            dataGridView1.Rows[7].DefaultCellStyle = style1;
            dataGridView1.Rows[12].DefaultCellStyle = style1;
            dataGridView1.Rows[13].DefaultCellStyle = style1;
            dataGridView1.Rows[14].DefaultCellStyle = style1;

            dgv_ProbabilityofFalseDetection_fromASTERIXfile.Rows.Clear();
            dgv_ProbabilityofFalseDetection_fromASTERIXfile.ColumnCount = 5;
            dgv_ProbabilityofFalseDetection_fromASTERIXfile.Columns[0].Name = "Airport Zone";
            dgv_ProbabilityofFalseDetection_fromASTERIXfile.Columns[1].Name = "False Detections";
            dgv_ProbabilityofFalseDetection_fromASTERIXfile.Columns[2].Name = "Received Detections";
            dgv_ProbabilityofFalseDetection_fromASTERIXfile.Columns[3].Name = "Probability of False Detection (%)";
            dgv_ProbabilityofFalseDetection_fromASTERIXfile.Columns[4].Name = "ED - 117 Value (%)";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dataRow = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                dgv_ProbabilityofFalseDetection_fromASTERIXfile.Rows.Add(dataRow);
            }
        }

        private void bt_ProbabilityofFalseIdentification_ED117_ASTERIXfile_Click(object sender, EventArgs e)
        {
            FilterByAirportZones(listaMLAT);

            List<double> results1 = CalculatePRobabilityofFalseIdentification(listaMLAT_Stand);
            List<double> results2 = CalculatePRobabilityofFalseIdentification(listaMLAT_Stand_T1);
            List<double> results3 = CalculatePRobabilityofFalseIdentification(listaMLAT_Stand_T2);
            List<double> results4 = CalculatePRobabilityofFalseIdentification(listaMLAT_Apron);
            List<double> results5 = CalculatePRobabilityofFalseIdentification(listaMLAT_Apron_T1);
            List<double> results6 = CalculatePRobabilityofFalseIdentification(listaMLAT_Apron_T2);
            List<double> results7 = CalculatePRobabilityofFalseIdentification(listaMLAT_MA);
            List<double> results8 = CalculatePRobabilityofFalseIdentification(listaMLAT_RWY1);
            List<double> results9 = CalculatePRobabilityofFalseIdentification(listaMLAT_RWY2);
            List<double> results10 = CalculatePRobabilityofFalseIdentification(listaMLAT_RWY3);
            List<double> results11 = CalculatePRobabilityofFalseIdentification(listaMLAT_Taxiway);
            List<double> results12 = CalculatePRobabilityofFalseIdentification(listaMLAT_Airborne_2coma5NM);
            List<double> results13 = CalculatePRobabilityofFalseIdentification(listaMLAT_Airborne_5NM);

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Airport Zone";
            dataGridView1.Columns[1].Name = "Number of times PI > 10e-6";
            dataGridView1.Columns[2].Name = "Total 5s intervals";
            dataGridView1.Columns[3].Name = "Probability of False Identification (%)";
            dataGridView1.Columns[4].Name = "ED - 117 Value (%)";

            int n = dataGridView1.Rows.Add("Airport Zone", "Number of times PI > 10e-6", "Total 5s intervals", "Probability of False Identification(%)", "ED - 117 Value (%)");

            string PI1 = Math.Round(results1[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI2 = Math.Round(results2[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI3 = Math.Round(results3[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI4 = Math.Round(results4[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI5 = Math.Round(results5[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI6 = Math.Round(results6[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI7 = Math.Round(results7[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI8 = Math.Round(results8[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI9 = Math.Round(results9[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI10 = Math.Round(results10[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI11 = Math.Round(results11[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI12 = Math.Round(results12[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI13 = Math.Round(results13[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));


            n = dataGridView1.Rows.Add("STAND", results1[0], results1[1], PI1, "-----");
            n = dataGridView1.Rows.Add("STAND T1", results2[0], results2[1], PI2, "-----");
            n = dataGridView1.Rows.Add("STAND T2", results3[0], results3[1], PI3, "-----");
            n = dataGridView1.Rows.Add("APRON", results4[0], results4[1], PI4, "-----");
            n = dataGridView1.Rows.Add("APRON T1", results5[0], results5[1], PI5, "-----");
            n = dataGridView1.Rows.Add("APRON T2", results6[0], results6[1], PI6, "-----");
            n = dataGridView1.Rows.Add("MANEUVERING AREA", results7[0], results7[1], PI7, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 02 / 20", results8[0], results8[1], PI8, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 07R / 25L", results9[0], results9[1], PI9, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 07L / 25R", results10[0], results10[1], PI10, "-----");
            n = dataGridView1.Rows.Add("TAXIWAY", results11[0], results11[1], PI11, "-----");
            n = dataGridView1.Rows.Add("AIRBORNE 0 - 2.5 NM", results12[0], results12[1], PI12, "-----");
            n = dataGridView1.Rows.Add("AIRBORNE 2.5 - 5 NM", results13[0], results13[1], PI13, "-----");

            double received_messages = results1[0] + results4[0] + results7[0] + results12[0] + results13[0];
            double expected_messages = results1[1] + results4[1] + results7[1] + results12[1] + results13[1];
            string PU14 = Math.Round((received_messages / expected_messages) * 100, 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("TOTAL", received_messages, expected_messages, PU14, "-----");

            DataGridViewCellStyle style = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style.BackColor = Color.LightGray;

            DataGridViewCellStyle style1 = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style1.Font = new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold);

            // Coloreamos los bordes en gris

            dataGridView1.Columns[0].DefaultCellStyle = style;
            dataGridView1.Rows[0].DefaultCellStyle = style;

            // Negrita en las zonas importantes

            dataGridView1.Rows[1].DefaultCellStyle = style1;
            dataGridView1.Rows[4].DefaultCellStyle = style1;
            dataGridView1.Rows[7].DefaultCellStyle = style1;
            dataGridView1.Rows[12].DefaultCellStyle = style1;
            dataGridView1.Rows[13].DefaultCellStyle = style1;
            dataGridView1.Rows[14].DefaultCellStyle = style1;

            dgv_ProbabilityofFalseIdentification_fromASTERIXfile.Rows.Clear();
            dgv_ProbabilityofFalseIdentification_fromASTERIXfile.ColumnCount = 5;
            dgv_ProbabilityofFalseIdentification_fromASTERIXfile.Columns[0].Name = "Airport Zone";
            dgv_ProbabilityofFalseIdentification_fromASTERIXfile.Columns[1].Name = "Number of times PI > 10e-6";
            dgv_ProbabilityofFalseIdentification_fromASTERIXfile.Columns[2].Name = "Total 5s intervals";
            dgv_ProbabilityofFalseIdentification_fromASTERIXfile.Columns[3].Name = "Probability of False Identification (%)";
            dgv_ProbabilityofFalseIdentification_fromASTERIXfile.Columns[4].Name = "ED - 117 Value (%)";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dataRow = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                dgv_ProbabilityofFalseIdentification_fromASTERIXfile.Rows.Add(dataRow);
            }
        }

        #endregion

        #region Buttons to calculate ED-117 performances from Calibration Vehicle

        private void bt_CalculateUpdateRate_ED117_CalibrationVehicle_Click(object sender, EventArgs e)
        {
            List<CAT10> lista11 = FilterMLATifCalibrationVehiclePresent(listaMLAT);
            FilterByAirportZones(lista11);

            //FilterCalibrationVehicleByAirportZones(listaMLAT);

            List<double> results1 = CalculateProbabilityofUpdate(listaMLAT_Stand);
            List<double> results2 = CalculateProbabilityofUpdate(listaMLAT_Stand_T1);
            List<double> results3 = CalculateProbabilityofUpdate(listaMLAT_Stand_T2);
            List<double> results4 = CalculateProbabilityofUpdate(listaMLAT_Apron);
            List<double> results5 = CalculateProbabilityofUpdate(listaMLAT_Apron_T1);
            List<double> results6 = CalculateProbabilityofUpdate(listaMLAT_Apron_T2);
            List<double> results7 = CalculateProbabilityofUpdate(listaMLAT_MA);
            List<double> results8 = CalculateProbabilityofUpdate(listaMLAT_RWY1);
            List<double> results9 = CalculateProbabilityofUpdate(listaMLAT_RWY2);
            List<double> results10 = CalculateProbabilityofUpdate(listaMLAT_RWY3);
            List<double> results11 = CalculateProbabilityofUpdate(listaMLAT_Taxiway);
            List<double> results12 = CalculateProbabilityofUpdate(listaMLAT_Airborne_2coma5NM);
            List<double> results13 = CalculateProbabilityofUpdate(listaMLAT_Airborne_5NM);

            //--------------------------------

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Airport Zone";
            dataGridView1.Columns[1].Name = "Received Updates";
            dataGridView1.Columns[2].Name = "Expected Updates";
            dataGridView1.Columns[3].Name = "Probability of Update (%)";
            dataGridView1.Columns[4].Name = "ED - 117 Value (%)";

            DataGridViewCellStyle style = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style.BackColor = Color.LightGray;

            DataGridViewCellStyle style1 = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style1.Font = new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold);



            int n = dataGridView1.Rows.Add("Airport Zone", "Received Updates", "Expected Updates", "Probability of Update (%)", "ED - 117 Value (%)");

            string PU1 = Math.Round(results1[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("STAND", results1[0], results1[1], PU1, "50 %");
            string PU2 = Math.Round(results2[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("STAND T1", results2[0], results2[1], PU2, "-----");
            string PU3 = Math.Round(results3[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("STAND T2", results3[0], results3[1], PU3, "-----");
            string PU4 = Math.Round(results4[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("APRON", results4[0], results4[1], PU4, "70 %");
            string PU5 = Math.Round(results5[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("APRON T1", results5[0], results5[1], PU5, "-----");
            string PU6 = Math.Round(results6[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("APRON T2", results6[0], results6[1], PU6, "------");
            string PU7 = Math.Round(results7[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("MANEUVERING AREA", results7[0], results7[1], PU7, "95 %");
            string PU8 = Math.Round(results8[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("RUNWAY 02 / 20", results8[0], results8[1], PU8, "-----");
            string PU9 = Math.Round(results9[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("RUNWAY 07R / 25L", results9[0], results9[1], PU9, "-----");
            string PU10 = Math.Round(results10[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("RUNWAY 07L / 25R", results10[0], results10[1], PU10, "----");
            string PU11 = Math.Round(results11[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("TAXIWAY", results11[0], results11[1], PU11, "----");
            string PU12 = Math.Round(results12[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("AIRBORNE 0 - 2.5 NM", results12[0], results12[1], PU12, "95 %");
            string PU13 = Math.Round(results13[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("AIRBORNE 2.5 NM - 5 NM", results13[0], results13[1], PU13, "95 %");

            double received_messages = results1[0] + results4[0] + results7[0] + results12[0] + results13[0];
            double expected_messages = results1[1] + results4[1] + results7[1] + results12[1] + results13[1];
            string PU14 = Math.Round((received_messages / expected_messages) * 100, 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("TOTAL", received_messages, expected_messages, PU14, "-----");

            // Coloreamos los bordes en gris

            dataGridView1.Columns[0].DefaultCellStyle = style;
            dataGridView1.Rows[0].DefaultCellStyle = style;

            // Negrita en las zonas importantes

            dataGridView1.Rows[1].DefaultCellStyle = style1;
            dataGridView1.Rows[4].DefaultCellStyle = style1;
            dataGridView1.Rows[7].DefaultCellStyle = style1;
            dataGridView1.Rows[12].DefaultCellStyle = style1;
            dataGridView1.Rows[13].DefaultCellStyle = style1;
            dataGridView1.Rows[14].DefaultCellStyle = style1;

            dgv_ProbabilityofUpdate_CalibrationVehicle.Rows.Clear();
            dgv_ProbabilityofUpdate_CalibrationVehicle.ColumnCount = 5;
            dgv_ProbabilityofUpdate_CalibrationVehicle.Columns[0].Name = "Airport Zone";
            dgv_ProbabilityofUpdate_CalibrationVehicle.Columns[1].Name = "Received Updates";
            dgv_ProbabilityofUpdate_CalibrationVehicle.Columns[2].Name = "Expected Updates";
            dgv_ProbabilityofUpdate_CalibrationVehicle.Columns[3].Name = "Probability of Update (%)";
            dgv_ProbabilityofUpdate_CalibrationVehicle.Columns[4].Name = "ED - 117 Value (%)";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dataRow = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                dgv_ProbabilityofUpdate_CalibrationVehicle.Rows.Add(dataRow);
            }
        }

        private void bt_CalculatePrecissionAccuracy_ED117_CalibrationVehicle_Click(object sender, EventArgs e)
        {
            Mapa.Overlays.Clear();

            List<CAT10> lista11 = FilterMLATifCalibrationVehiclePresent(listaMLAT);
            FilterByAirportZones(lista11);

            //FilterCalibrationVehicleByAirportZones(listaMLAT);

            var results1 = CalculatePrecissionAccuracyCalibrationVehicle1(listaMLAT_Stand, listaCalibrationDataVehicle);
            var results2 = CalculatePrecissionAccuracyCalibrationVehicle1(listaMLAT_Stand_T1, listaCalibrationDataVehicle);
            var results3 = CalculatePrecissionAccuracyCalibrationVehicle1(listaMLAT_Stand_T2, listaCalibrationDataVehicle);
            var results4 = CalculatePrecissionAccuracyCalibrationVehicle1(listaMLAT_Apron, listaCalibrationDataVehicle);
            var results5 = CalculatePrecissionAccuracyCalibrationVehicle1(listaMLAT_Apron_T1, listaCalibrationDataVehicle);
            var results6 = CalculatePrecissionAccuracyCalibrationVehicle1(listaMLAT_Apron_T2, listaCalibrationDataVehicle);
            var results7 = CalculatePrecissionAccuracyCalibrationVehicle1(listaMLAT_MA, listaCalibrationDataVehicle);
            var results8 = CalculatePrecissionAccuracyCalibrationVehicle1(listaMLAT_RWY1, listaCalibrationDataVehicle);
            var results9 = CalculatePrecissionAccuracyCalibrationVehicle1(listaMLAT_RWY2, listaCalibrationDataVehicle);
            var results10 = CalculatePrecissionAccuracyCalibrationVehicle1(listaMLAT_RWY3, listaCalibrationDataVehicle);
            var results11 = CalculatePrecissionAccuracyCalibrationVehicle1(listaMLAT_Taxiway, listaCalibrationDataVehicle);
            var results12 = CalculatePrecissionAccuracyCalibrationVehicle1(listaMLAT_Airborne_2coma5NM, listaCalibrationDataVehicle);
            var results13 = CalculatePrecissionAccuracyCalibrationVehicle1(listaMLAT_Airborne_5NM, listaCalibrationDataVehicle);
            //var results14 = CalculatePrecissionAccuracyCalibrationVehicle1(lista11, listaCalibrationDataVehicle);



            // Creamos DGV y columnas
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Airport Zone";
            dataGridView1.Columns[1].Name = "95th Percentile (m)";
            dataGridView1.Columns[2].Name = "ED-117 Value (m)";
            dataGridView1.Columns[3].Name = "99th Percentile (m)";
            dataGridView1.Columns[4].Name = "ED-117 Value (m)";
            dataGridView1.Columns[5].Name = "Mean (m)";
            dataGridView1.Columns[6].Name = "STD Deviation (m)";
            dataGridView1.Columns[7].Name = "Samples";

            DataGridViewCellStyle style = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style.BackColor = Color.LightGray;

            DataGridViewCellStyle style1 = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style1.Font = new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold);

            int n = dataGridView1.Rows.Add("Airport Zone", "95th Percentile (m)", "ED-117 Value (m)", "99th Percentile (m)", "ED-117 Value (m)", "Mean (m)", "STD Deviation (m)", "Samples");

            string P951 = Math.Round(Percentile(results1[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P991 = Math.Round(Percentile(results1[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD1 = Math.Round(CalculateStandardDeviation(results1[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG1 = "0";
            if (results1[0].Count() != 0) { AVG1 = Math.Round(results1[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("STAND", P951, "20", P991, "-----", AVG1, STD1, results1[0].Count().ToString());

            string P952 = Math.Round(Percentile(results2[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P992 = Math.Round(Percentile(results2[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD2 = Math.Round(CalculateStandardDeviation(results2[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG2 = "0";
            if (results2[0].Count() != 0) { AVG2 = Math.Round(results2[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("STAND T1", P952, "-----", P992, "-----", AVG2, STD2, results2[0].Count().ToString());

            string P953 = Math.Round(Percentile(results3[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P993 = Math.Round(Percentile(results3[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD3 = Math.Round(CalculateStandardDeviation(results3[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG3 = "0";
            if (results3[0].Count() != 0) { AVG3 = Math.Round(results3[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("STAND T2", P953, "-----", P993, "-----", AVG3, STD3, results3[0].Count().ToString());

            string P954 = Math.Round(Percentile(results4[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P994 = Math.Round(Percentile(results4[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD4 = Math.Round(CalculateStandardDeviation(results4[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG4 = "0";
            if (results4[0].Count() != 0) { AVG4 = Math.Round(results4[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("APRON", P954, "-----", P994, "-----", AVG4, STD4, results4[0].Count().ToString());

            string P955 = Math.Round(Percentile(results5[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P995 = Math.Round(Percentile(results5[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD5 = Math.Round(CalculateStandardDeviation(results5[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG5 = "0";
            if (results5[0].Count() != 0) { AVG5 = Math.Round(results5[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("APRON T1", P955, "-----", P995, "-----", AVG5, STD5, results5[0].Count().ToString());

            string P956 = Math.Round(Percentile(results6[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P996 = Math.Round(Percentile(results6[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD6 = Math.Round(CalculateStandardDeviation(results6[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG6 = "0";
            if (results6[0].Count() != 0) { AVG6 = Math.Round(results6[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("APRON T2", P956, "-----", P996, "-----", AVG6, STD6, results6[0].Count().ToString());

            string P957 = Math.Round(Percentile(results7[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P997 = Math.Round(Percentile(results7[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD7 = Math.Round(CalculateStandardDeviation(results7[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG7 = "0";
            if (results7[0].Count() != 0) { AVG7 = Math.Round(results7[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("MANEUVERING AREA", P957, "7.5 m", P997, "12 m", AVG7, STD7, results7[0].Count().ToString());

            string P958 = Math.Round(Percentile(results8[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P998 = Math.Round(Percentile(results8[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD8 = Math.Round(CalculateStandardDeviation(results8[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG8 = "0";
            if (results8[0].Count() != 0) { AVG8 = Math.Round(results8[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("RUNWAY 02 / 20", P958, "-----", P998, "-----", AVG8, STD8, results8[0].Count().ToString());

            string P959 = Math.Round(Percentile(results9[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P999 = Math.Round(Percentile(results9[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD9 = Math.Round(CalculateStandardDeviation(results9[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG9 = "0";
            if (results9[0].Count() != 0) { AVG9 = Math.Round(results9[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("RUNWAY 07R / 25L", P959, "-----", P999, "-----", AVG9, STD9, results9[0].Count().ToString());

            string P9510 = Math.Round(Percentile(results10[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P9910 = Math.Round(Percentile(results10[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD10 = Math.Round(CalculateStandardDeviation(results10[0]), 3).ToString().ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG10 = "0";
            if (results10[0].Count() != 0) { AVG10 = Math.Round(results10[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("RUNWAY 07L / 25R", P9510, "-----", P9910, "-----", AVG10, STD10, results10[0].Count().ToString());

            string P9511 = Math.Round(Percentile(results11[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P9911 = Math.Round(Percentile(results11[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD11 = Math.Round(CalculateStandardDeviation(results11[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG11 = "0";
            if (results11[0].Count() != 0) { AVG11 = Math.Round(results11[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("TAXYWAY", P9511, "-----", P9911, "-----", AVG11, STD11, results11[0].Count().ToString());

            string P9512 = Math.Round(Percentile(results12[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P9912 = Math.Round(Percentile(results12[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD12 = Math.Round(CalculateStandardDeviation(results12[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG12 = "0";
            if (results12[0].Count() != 0) { AVG12 = Math.Round(results12[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("AIRBORNE 0 - 2.5 NM", P9512, "20 m", P9912, "-----", AVG12, STD12, results12[0].Count().ToString());

            string P9513 = Math.Round(Percentile(results13[0], 0.95), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string P9913 = Math.Round(Percentile(results13[0], 0.99), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string STD13 = Math.Round(CalculateStandardDeviation(results13[0]), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string AVG13 = "0";
            if (results13[0].Count() != 0) { AVG13 = Math.Round(results13[0].Average(), 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar(".")); }
            n = dataGridView1.Rows.Add("AIRBORNE 2.5 - 5 NM", P9513, "20 m", P9913, "-----", AVG13, STD13, results13[0].Count().ToString());

            // Coloreamos los bordes en gris

            dataGridView1.Columns[0].DefaultCellStyle = style;
            dataGridView1.Rows[0].DefaultCellStyle = style;

            // Negrita en las zonas importantes

            dataGridView1.Rows[1].DefaultCellStyle = style1;
            dataGridView1.Rows[4].DefaultCellStyle = style1;
            dataGridView1.Rows[7].DefaultCellStyle = style1;
            dataGridView1.Rows[12].DefaultCellStyle = style1;
            dataGridView1.Rows[13].DefaultCellStyle = style1;
            dataGridView1.Rows[14].DefaultCellStyle = style1;

            dgv_PrecissionAccuracy_CalibrationVehicle.Rows.Clear();
            dgv_PrecissionAccuracy_CalibrationVehicle.ColumnCount = 8;
            dgv_PrecissionAccuracy_CalibrationVehicle.Columns[0].Name = "Airport Zone";
            dgv_PrecissionAccuracy_CalibrationVehicle.Columns[1].Name = "95th Percentile (m)";
            dgv_PrecissionAccuracy_CalibrationVehicle.Columns[2].Name = "ED-117 Value (m)";
            dgv_PrecissionAccuracy_CalibrationVehicle.Columns[3].Name = "99th Percentile (m)";
            dgv_PrecissionAccuracy_CalibrationVehicle.Columns[4].Name = "ED-117 Value (m)";
            dgv_PrecissionAccuracy_CalibrationVehicle.Columns[5].Name = "Mean (m)";
            dgv_PrecissionAccuracy_CalibrationVehicle.Columns[6].Name = "STD Deviation (m)";
            dgv_PrecissionAccuracy_CalibrationVehicle.Columns[7].Name = "Samples";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dataRow = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                dgv_PrecissionAccuracy_CalibrationVehicle.Rows.Add(dataRow);
            }
        }

        private void bt_CalculateProbabilityofMLATDetection_ED117_CalibrationVehicle_Click(object sender, EventArgs e)
        {
            List<CAT10> lista11 = FilterMLATifCalibrationVehiclePresent(listaMLAT);
            FilterByAirportZones(lista11);

            //FilterCalibrationVehicleByAirportZones(listaMLAT);

            List<double> results1 = CalculatePRobabilityofMLATDetection_CalibrationVehicle(listaMLAT_Stand, 5);
            List<double> results2 = CalculatePRobabilityofMLATDetection_CalibrationVehicle(listaMLAT_Stand_T1, 5);
            List<double> results3 = CalculatePRobabilityofMLATDetection_CalibrationVehicle(listaMLAT_Stand_T2, 5);
            List<double> results4 = CalculatePRobabilityofMLATDetection_CalibrationVehicle(listaMLAT_Apron, 2);
            List<double> results5 = CalculatePRobabilityofMLATDetection_CalibrationVehicle(listaMLAT_Apron_T1, 2);
            List<double> results6 = CalculatePRobabilityofMLATDetection_CalibrationVehicle(listaMLAT_Apron_T2, 2);
            List<double> results7 = CalculatePRobabilityofMLATDetection_CalibrationVehicle(listaMLAT_MA, 2);
            List<double> results8 = CalculatePRobabilityofMLATDetection_CalibrationVehicle(listaMLAT_RWY1, 2);
            List<double> results9 = CalculatePRobabilityofMLATDetection_CalibrationVehicle(listaMLAT_RWY2, 2);
            List<double> results10 = CalculatePRobabilityofMLATDetection_CalibrationVehicle(listaMLAT_RWY3, 2);
            List<double> results11 = CalculatePRobabilityofMLATDetection_CalibrationVehicle(listaMLAT_Taxiway, 2);
            List<double> results12 = CalculatePRobabilityofMLATDetection_CalibrationVehicle(listaMLAT_Airborne_2coma5NM, 1);
            List<double> results13 = CalculatePRobabilityofMLATDetection_CalibrationVehicle(listaMLAT_Airborne_5NM, 1);

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Airport Zone";
            dataGridView1.Columns[1].Name = "Received Updates";
            dataGridView1.Columns[2].Name = "Expected Updates";
            dataGridView1.Columns[3].Name = "Probability of MLAT Detection (%)";
            dataGridView1.Columns[4].Name = "ED - 117 Value (%)";

            DataGridViewCellStyle style = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style.BackColor = Color.LightGray;

            DataGridViewCellStyle style1 = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style1.Font = new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold);

            int n = dataGridView1.Rows.Add("Airport Zone", "Received Updates", "Expected Updates", "Probability of MLAT Detection (%)", "ED - 117 Value (%)");

            string PU1 = Math.Round(results1[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("STAND", results1[0], results1[1], PU1, "-----");
            string PU2 = Math.Round(results2[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("STAND T1", results2[0], results2[1], PU2, "-----");
            string PU3 = Math.Round(results3[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("STAND T2", results3[0], results3[1], PU3, "-----");
            string PU4 = Math.Round(results4[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("APRON", results4[0], results4[1], PU4, "-----");
            string PU5 = Math.Round(results5[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("APRON T1", results5[0], results5[1], PU5, "-----");
            string PU6 = Math.Round(results6[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("APRON T2", results6[0], results6[1], PU6, "------");
            string PU7 = Math.Round(results7[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("MANEUVERING AREA", results7[0], results7[1], PU7, "-----");
            string PU8 = Math.Round(results8[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("RUNWAY 02 / 20", results8[0], results8[1], PU8, "-----");
            string PU9 = Math.Round(results9[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("RUNWAY 07R / 25L", results9[0], results9[1], PU9, "-----");
            string PU10 = Math.Round(results10[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("RUNWAY 07L / 25R", results10[0], results10[1], PU10, "----");
            string PU11 = Math.Round(results11[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("TAXIWAY", results11[0], results11[1], PU11, "----");
            n = dataGridView1.Rows.Add("TAXIWAY", results11[0], results11[1], PU11, "----");
            string PU12 = Math.Round(results12[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("AIRBORNE 0 - 2.5 NM", results12[0], results12[1], PU12, "----");
            string PU13 = Math.Round(results13[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("AIRBORNE 2.5 - 5 NM", results13[0], results13[1], PU13, "----");

            double received_messages = results1[0] + results4[0] + results7[0] + results12[0] + results13[0];
            double expected_messages = results1[1] + results4[1] + results7[1] + results12[1] + results13[1];
            string PU14 = Math.Round((received_messages / expected_messages) * 100, 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("TOTAL", received_messages, expected_messages, PU14, "99.9");

            // Coloreamos los bordes en gris

            dataGridView1.Columns[0].DefaultCellStyle = style;
            dataGridView1.Rows[0].DefaultCellStyle = style;

            // Negrita en las zonas importantes

            dataGridView1.Rows[1].DefaultCellStyle = style1;
            dataGridView1.Rows[4].DefaultCellStyle = style1;
            dataGridView1.Rows[7].DefaultCellStyle = style1;
            dataGridView1.Rows[13].DefaultCellStyle = style1;
            dataGridView1.Rows[14].DefaultCellStyle = style1;
            dataGridView1.Rows[15].DefaultCellStyle = style1;

            dgv_ProbabilityofMLATDetection_CalibrationVehicle.Rows.Clear();
            dgv_ProbabilityofMLATDetection_CalibrationVehicle.ColumnCount = 5;
            dgv_ProbabilityofMLATDetection_CalibrationVehicle.Columns[0].Name = "Airport Zone";
            dgv_ProbabilityofMLATDetection_CalibrationVehicle.Columns[1].Name = "Received Updates";
            dgv_ProbabilityofMLATDetection_CalibrationVehicle.Columns[2].Name = "Expected Updates";
            dgv_ProbabilityofMLATDetection_CalibrationVehicle.Columns[3].Name = "Probability of MLAT Detection (%)";
            dgv_ProbabilityofMLATDetection_CalibrationVehicle.Columns[4].Name = "ED - 117 Value (%)";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dataRow = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                dgv_ProbabilityofMLATDetection_CalibrationVehicle.Rows.Add(dataRow);
            }
        }

        private void bt_ProbabilityofIdentification_ED117_CalibrationVehicle_Click(object sender, EventArgs e)
        {
            List<CAT10> lista11 = FilterMLATifCalibrationVehiclePresent(listaMLAT);
            FilterByAirportZones(lista11);

            //FilterCalibrationVehicleByAirportZones(listaMLAT);

            List<double> results1 = CalculatePRobabilityofIdentification(listaMLAT_Stand);
            List<double> results2 = CalculatePRobabilityofIdentification(listaMLAT_Stand_T1);
            List<double> results3 = CalculatePRobabilityofIdentification(listaMLAT_Stand_T2);
            List<double> results4 = CalculatePRobabilityofIdentification(listaMLAT_Apron);
            List<double> results5 = CalculatePRobabilityofIdentification(listaMLAT_Apron_T1);
            List<double> results6 = CalculatePRobabilityofIdentification(listaMLAT_Apron_T2);
            List<double> results7 = CalculatePRobabilityofIdentification(listaMLAT_MA);
            List<double> results8 = CalculatePRobabilityofIdentification(listaMLAT_RWY1);
            List<double> results9 = CalculatePRobabilityofIdentification(listaMLAT_RWY2);
            List<double> results10 = CalculatePRobabilityofIdentification(listaMLAT_RWY3);
            List<double> results11 = CalculatePRobabilityofIdentification(listaMLAT_Taxiway);
            List<double> results12 = CalculatePRobabilityofIdentification(listaMLAT_Airborne_2coma5NM);
            List<double> results13 = CalculatePRobabilityofIdentification(listaMLAT_Airborne_5NM);
            List<double> results14 = CalculatePRobabilityofIdentification(listaMLAT);

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Airport Zone";
            dataGridView1.Columns[1].Name = "Expected Updates";
            dataGridView1.Columns[2].Name = "Received Updates";
            dataGridView1.Columns[3].Name = "Probability of Identification (%)";
            dataGridView1.Columns[4].Name = "ED - 117 Value (%)";

            int n = dataGridView1.Rows.Add("Airport Zone", "Expected Updates", "Received Updates", "Probability of Identification (%)", "ED - 117 Value (%)");

            string PI1 = Math.Round(results1[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI2 = Math.Round(results2[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI3 = Math.Round(results3[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI4 = Math.Round(results4[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI5 = Math.Round(results5[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI6 = Math.Round(results6[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI7 = Math.Round(results7[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI8 = Math.Round(results8[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI9 = Math.Round(results9[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI10 = Math.Round(results10[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI11 = Math.Round(results11[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI12 = Math.Round(results12[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI13 = Math.Round(results13[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI14 = Math.Round(results14[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));


            n = dataGridView1.Rows.Add("STAND", results1[0], results1[1], PI1, "-----");
            n = dataGridView1.Rows.Add("STAND T1", results2[0], results2[1], PI2, "-----");
            n = dataGridView1.Rows.Add("STAND T2", results3[0], results3[1], PI3, "-----");
            n = dataGridView1.Rows.Add("APRON", results4[0], results4[1], PI4, "-----");
            n = dataGridView1.Rows.Add("APRON T1", results5[0], results5[1], PI5, "-----");
            n = dataGridView1.Rows.Add("APRON T2", results6[0], results6[1], PI6, "-----");
            n = dataGridView1.Rows.Add("MANEUVERING AREA", results7[0], results7[1], PI7, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 02 / 20", results8[0], results8[1], PI8, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 07R / 25L", results9[0], results9[1], PI9, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 07L / 25R", results10[0], results10[1], PI10, "-----");
            n = dataGridView1.Rows.Add("TAXIWAY", results11[0], results11[1], PI11, "-----");
            n = dataGridView1.Rows.Add("AIRBORNE 0 - 2.5 NM", results12[0], results12[1], PI12, "-----");
            n = dataGridView1.Rows.Add("AIRBORNE 2.5 - 5 NM", results13[0], results13[1], PI13, "-----");

            double received_messages = results1[0] + results4[0] + results7[0] + results12[0] + results13[0];
            double expected_messages = results1[1] + results4[1] + results7[1] + results12[1] + results13[1];
            string PU14 = Math.Round((received_messages / expected_messages) * 100, 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("TOTAL", received_messages, expected_messages, PU14, "99.9");

            DataGridViewCellStyle style = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style.BackColor = Color.LightGray;

            DataGridViewCellStyle style1 = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style1.Font = new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold);

            // Coloreamos los bordes en gris

            dataGridView1.Columns[0].DefaultCellStyle = style;
            dataGridView1.Rows[0].DefaultCellStyle = style;

            // Negrita en las zonas importantes

            dataGridView1.Rows[1].DefaultCellStyle = style1;
            dataGridView1.Rows[4].DefaultCellStyle = style1;
            dataGridView1.Rows[7].DefaultCellStyle = style1;
            dataGridView1.Rows[12].DefaultCellStyle = style1;
            dataGridView1.Rows[13].DefaultCellStyle = style1;
            dataGridView1.Rows[14].DefaultCellStyle = style1;

            dgv_ProbabilityofIdentification_CalibrationVehicle.Rows.Clear();
            dgv_ProbabilityofIdentification_CalibrationVehicle.ColumnCount = 5;
            dgv_ProbabilityofIdentification_CalibrationVehicle.Columns[0].Name = "Airport Zone";
            dgv_ProbabilityofIdentification_CalibrationVehicle.Columns[1].Name = "Expected Updates";
            dgv_ProbabilityofIdentification_CalibrationVehicle.Columns[2].Name = "Received Updates";
            dgv_ProbabilityofIdentification_CalibrationVehicle.Columns[3].Name = "Probability of Identification (%)";
            dgv_ProbabilityofIdentification_CalibrationVehicle.Columns[4].Name = "ED - 117 Value (%)";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dataRow = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                dgv_ProbabilityofIdentification_CalibrationVehicle.Rows.Add(dataRow);
            }
        }

        private void bt_CalculateProbabilityofFalseDetection_CalibrationVehicle_Click(object sender, EventArgs e)
        {
            List<CAT10> lista11 = FilterMLATifCalibrationVehiclePresent(listaMLAT);
            FilterByAirportZones(lista11);

            //FilterCalibrationVehicleByAirportZones(listaMLAT);

            List<double> results1 = CalculatePRobabilityofFalseDetection(listaMLAT_Stand, 50);
            List<double> results2 = CalculatePRobabilityofFalseDetection(listaMLAT_Stand_T1, 50);
            List<double> results3 = CalculatePRobabilityofFalseDetection(listaMLAT_Stand_T2, 50);
            List<double> results4 = CalculatePRobabilityofFalseDetection(listaMLAT_Apron, 50);
            List<double> results5 = CalculatePRobabilityofFalseDetection(listaMLAT_Apron_T1, 50);
            List<double> results6 = CalculatePRobabilityofFalseDetection(listaMLAT_Apron_T2, 50);
            List<double> results7 = CalculatePRobabilityofFalseDetection(listaMLAT_MA, 50);
            List<double> results8 = CalculatePRobabilityofFalseDetection(listaMLAT_RWY1, 50);
            List<double> results9 = CalculatePRobabilityofFalseDetection(listaMLAT_RWY2, 50);
            List<double> results10 = CalculatePRobabilityofFalseDetection(listaMLAT_RWY3, 50);
            List<double> results11 = CalculatePRobabilityofFalseDetection(listaMLAT_Taxiway, 50);
            List<double> results12 = CalculatePRobabilityofFalseDetection(listaMLAT_Airborne_2coma5NM, 80);
            List<double> results13 = CalculatePRobabilityofFalseDetection(listaMLAT_Airborne_5NM, 160);
            List<double> results14 = CalculatePRobabilityofFalseDetection(listaMLAT, 160);

            string PI1 = Math.Round(results1[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI2 = Math.Round(results2[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI3 = Math.Round(results3[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI4 = Math.Round(results4[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI5 = Math.Round(results5[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI6 = Math.Round(results6[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI7 = Math.Round(results7[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI8 = Math.Round(results8[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI9 = Math.Round(results9[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI10 = Math.Round(results10[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI11 = Math.Round(results11[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI12 = Math.Round(results12[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI13 = Math.Round(results13[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Airport Zone";
            dataGridView1.Columns[1].Name = "False Detections";
            dataGridView1.Columns[2].Name = "Received Detections";
            dataGridView1.Columns[3].Name = "Probability of False Detection (%)";
            dataGridView1.Columns[4].Name = "ED - 117 Value (%)";

            int n = dataGridView1.Rows.Add("Airport Zone", "Expected Updates", "Received Updates", "Probability of False Detection (%)", "ED - 117 Value (%)");

            n = dataGridView1.Rows.Add("STAND", results1[0], results1[1], PI1, "-----");
            n = dataGridView1.Rows.Add("STAND T1", results2[0], results2[1], PI2, "-----");
            n = dataGridView1.Rows.Add("STAND T2", results3[0], results3[1], PI3, "-----");
            n = dataGridView1.Rows.Add("APRON", results4[0], results4[1], PI4, "-----");
            n = dataGridView1.Rows.Add("APRON T1", results5[0], results5[1], PI5, "-----");
            n = dataGridView1.Rows.Add("APRON T2", results6[0], results6[1], PI6, "-----");
            n = dataGridView1.Rows.Add("MANEUVERING AREA", results7[0], results7[1], PI7, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 02 / 20", results8[0], results8[1], PI8, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 07R / 25L", results9[0], results9[1], PI9, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 07L / 25R", results10[0], results10[1], PI10, "-----");
            n = dataGridView1.Rows.Add("TAXIWAY", results11[0], results11[1], PI11, "-----");
            n = dataGridView1.Rows.Add("AIRBORNE 0 - 2.5 NM", results12[0], results12[1], PI12, "-----");
            n = dataGridView1.Rows.Add("AIRBORNE 2.5 - 5 NM", results13[0], results13[1], PI13, "-----");

            double received_messages = results1[0] + results4[0] + results7[0] + results12[0] + results13[0];
            double expected_messages = results1[1] + results4[1] + results7[1] + results12[1] + results13[1];
            string PU14 = Math.Round((received_messages / expected_messages) * 100, 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("TOTAL", received_messages, expected_messages, PU14, "-----");

            DataGridViewCellStyle style = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style.BackColor = Color.LightGray;

            DataGridViewCellStyle style1 = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style1.Font = new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold);

            // Coloreamos los bordes en gris

            dataGridView1.Columns[0].DefaultCellStyle = style;
            dataGridView1.Rows[0].DefaultCellStyle = style;

            // Negrita en las zonas importantes

            dataGridView1.Rows[1].DefaultCellStyle = style1;
            dataGridView1.Rows[4].DefaultCellStyle = style1;
            dataGridView1.Rows[7].DefaultCellStyle = style1;
            dataGridView1.Rows[12].DefaultCellStyle = style1;
            dataGridView1.Rows[13].DefaultCellStyle = style1;
            dataGridView1.Rows[14].DefaultCellStyle = style1;

            dgv_ProbabilityofFalseDetection_CalibrationVehicle.Rows.Clear();
            dgv_ProbabilityofFalseDetection_CalibrationVehicle.ColumnCount = 5;
            dgv_ProbabilityofFalseDetection_CalibrationVehicle.Columns[0].Name = "Airport Zone";
            dgv_ProbabilityofFalseDetection_CalibrationVehicle.Columns[1].Name = "False Detections";
            dgv_ProbabilityofFalseDetection_CalibrationVehicle.Columns[2].Name = "Received Detections";
            dgv_ProbabilityofFalseDetection_CalibrationVehicle.Columns[3].Name = "Probability of False Detection (%)";
            dgv_ProbabilityofFalseDetection_CalibrationVehicle.Columns[4].Name = "ED - 117 Value (%)";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dataRow = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                dgv_ProbabilityofFalseDetection_CalibrationVehicle.Rows.Add(dataRow);
            }
        }

        private void bt_ProbabilityofFalseIdentification_ED117_CalibrationVehicle_Click(object sender, EventArgs e)
        {
            List<CAT10> lista11 = FilterMLATifCalibrationVehiclePresent(listaMLAT);
            FilterByAirportZones(lista11);

            List<double> results1 = CalculatePRobabilityofFalseIdentification(listaMLAT_Stand);
            List<double> results2 = CalculatePRobabilityofFalseIdentification(listaMLAT_Stand_T1);
            List<double> results3 = CalculatePRobabilityofFalseIdentification(listaMLAT_Stand_T2);
            List<double> results4 = CalculatePRobabilityofFalseIdentification(listaMLAT_Apron);
            List<double> results5 = CalculatePRobabilityofFalseIdentification(listaMLAT_Apron_T1);
            List<double> results6 = CalculatePRobabilityofFalseIdentification(listaMLAT_Apron_T2);
            List<double> results7 = CalculatePRobabilityofFalseIdentification(listaMLAT_MA);
            List<double> results8 = CalculatePRobabilityofFalseIdentification(listaMLAT_RWY1);
            List<double> results9 = CalculatePRobabilityofFalseIdentification(listaMLAT_RWY2);
            List<double> results10 = CalculatePRobabilityofFalseIdentification(listaMLAT_RWY3);
            List<double> results11 = CalculatePRobabilityofFalseIdentification(listaMLAT_Taxiway);
            List<double> results12 = CalculatePRobabilityofFalseIdentification(listaMLAT_Airborne_2coma5NM);
            List<double> results13 = CalculatePRobabilityofFalseIdentification(listaMLAT_Airborne_5NM);

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Airport Zone";
            dataGridView1.Columns[1].Name = "Total 5s intervals";
            dataGridView1.Columns[2].Name = "Number of times PI > 10e-6";
            dataGridView1.Columns[3].Name = "Probability of False Identification (%)";
            dataGridView1.Columns[4].Name = "ED - 117 Value (%)";

            int n = dataGridView1.Rows.Add("Airport Zone", "Total 5s intervals", "Number of times PI > 10e-6", "Probability of False Identification (%)", "ED - 117 Value (%)");

            string PI1 = Math.Round(results1[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI2 = Math.Round(results2[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI3 = Math.Round(results3[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI4 = Math.Round(results4[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI5 = Math.Round(results5[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI6 = Math.Round(results6[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI7 = Math.Round(results7[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI8 = Math.Round(results8[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI9 = Math.Round(results9[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI10 = Math.Round(results10[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI11 = Math.Round(results11[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI12 = Math.Round(results12[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            string PI13 = Math.Round(results13[2], 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));


            n = dataGridView1.Rows.Add("STAND", results1[0], results1[1], PI1, "-----");
            n = dataGridView1.Rows.Add("STAND T1", results2[0], results2[1], PI2, "-----");
            n = dataGridView1.Rows.Add("STAND T2", results3[0], results3[1], PI3, "-----");
            n = dataGridView1.Rows.Add("APRON", results4[0], results4[1], PI4, "-----");
            n = dataGridView1.Rows.Add("APRON T1", results5[0], results5[1], PI5, "-----");
            n = dataGridView1.Rows.Add("APRON T2", results6[0], results6[1], PI6, "-----");
            n = dataGridView1.Rows.Add("MANEUVERING AREA", results7[0], results7[1], PI7, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 02 / 20", results8[0], results8[1], PI8, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 07R / 25L", results9[0], results9[1], PI9, "-----");
            n = dataGridView1.Rows.Add("RUNWAY 07L / 25R", results10[0], results10[1], PI10, "-----");
            n = dataGridView1.Rows.Add("TAXIWAY", results11[0], results11[1], PI11, "-----");
            n = dataGridView1.Rows.Add("AIRBORNE 0 - 2.5 NM", results12[0], results12[1], PI12, "-----");
            n = dataGridView1.Rows.Add("AIRBORNE 2.5 - 5 NM", results13[0], results13[1], PI13, "-----");

            double received_messages = results1[0] + results4[0] + results7[0] + results12[0] + results13[0];
            double expected_messages = results1[1] + results4[1] + results7[1] + results12[1] + results13[1];
            string PU14 = Math.Round((received_messages / expected_messages) * 100, 3).ToString().Replace(Convert.ToChar(","), Convert.ToChar("."));
            n = dataGridView1.Rows.Add("TOTAL", received_messages, expected_messages, PU14, "-----");

            DataGridViewCellStyle style = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style.BackColor = Color.LightGray;

            DataGridViewCellStyle style1 = new DataGridViewCellStyle(dataGridView1.RowsDefaultCellStyle);
            style1.Font = new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold);

            // Coloreamos los bordes en gris

            dataGridView1.Columns[0].DefaultCellStyle = style;
            dataGridView1.Rows[0].DefaultCellStyle = style;

            // Negrita en las zonas importantes

            dataGridView1.Rows[1].DefaultCellStyle = style1;
            dataGridView1.Rows[4].DefaultCellStyle = style1;
            dataGridView1.Rows[7].DefaultCellStyle = style1;
            dataGridView1.Rows[12].DefaultCellStyle = style1;
            dataGridView1.Rows[13].DefaultCellStyle = style1;
            dataGridView1.Rows[14].DefaultCellStyle = style1;

            dgv_ProbabilityofFalseIdentification_CalibrationVehicle.Rows.Clear();
            dgv_ProbabilityofFalseIdentification_CalibrationVehicle.ColumnCount = 5;
            dgv_ProbabilityofFalseIdentification_CalibrationVehicle.Columns[0].Name = "Airport Zone";
            dgv_ProbabilityofFalseIdentification_CalibrationVehicle.Columns[1].Name = "Total 5s intervals";
            dgv_ProbabilityofFalseIdentification_CalibrationVehicle.Columns[2].Name = "Number of times PI > 10e-6";
            dgv_ProbabilityofFalseIdentification_CalibrationVehicle.Columns[3].Name = "Probability of False Identification (%)";
            dgv_ProbabilityofFalseIdentification_CalibrationVehicle.Columns[4].Name = "ED - 117 Value (%)";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dataRow = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                dgv_ProbabilityofFalseIdentification_CalibrationVehicle.Rows.Add(dataRow);
            }
        }

        #endregion

        #region Buttons to Export performances from ASTERIX File

        private void bt_Export_UpdateRate_ASTERIXfile_Click(object sender, EventArgs e)
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

                hoja_trabajo.Cells[rows + 1, 0 + 1] = "UPDATE RATE:";
                rows = rows + 2;

                for (int i = 0; i < dgv_UpdateRate_fromASTERIXfile.Rows.Count - 2; i++)
                {
                    for (int j = 0; j < dgv_UpdateRate_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_UpdateRate_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }
                rows = rows + 5;

                libros_trabajo.SaveAs(fichero.FileName,
                Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void bt_Export_ProbabilityofUpdate_ASTERIXfile_Click(object sender, EventArgs e)
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

                for (int i = 0; i < dgv_ProbabilityofUpdate_fromASTERIXfile.Rows.Count - 2; i++)
                {
                    for (int j = 0; j < dgv_ProbabilityofUpdate_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_ProbabilityofUpdate_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }
                rows = rows + 5;

                libros_trabajo.SaveAs(fichero.FileName,
                Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void bt_Export_PrecissionAccuracy_ASTERIXfile_Click(object sender, EventArgs e)
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

                hoja_trabajo.Cells[rows + 1, 0 + 1] = "PRECISSION ACCURACY:";
                rows = rows + 2;

                for (int i = 0; i < dgv_PrecissionAccuracy_fromASTERIXfile.Rows.Count - 2; i++)
                {
                    for (int j = 0; j < dgv_PrecissionAccuracy_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_PrecissionAccuracy_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }

                rows = rows + 5;
                int columns = 0;

                hoja_trabajo.Cells[rows + 1, columns + 1] = "Distance Error Stand:";

                for (int i = 0; i < dgv_PrecissionAccuracyError_Stand_fromASTERIXfile.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv_PrecissionAccuracyError_Stand_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows +3 + i, columns + 1 +j] = dgv_PrecissionAccuracyError_Stand_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                }

                columns = columns + 5;

                hoja_trabajo.Cells[rows + 1, columns + 1] = "Distance Error Apron:";

                for (int i = 0; i < dgv_PrecissionAccuracyError_Apron_fromASTERIXfile.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv_PrecissionAccuracyError_Apron_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 3 + i, columns + 1 + j] = dgv_PrecissionAccuracyError_Apron_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                }

                columns = columns + 5;

                hoja_trabajo.Cells[rows + 1, columns + 1] = "Distance Error Maneuvering Area:";

                for (int i = 0; i < dgv_PrecissionAccuracyError_MA_fromASTERIXfile.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv_PrecissionAccuracyError_MA_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 3 + i, columns + 1 + j] = dgv_PrecissionAccuracyError_MA_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                }

                columns = columns + 5;

                hoja_trabajo.Cells[rows + 1, columns + 1] = "Distance Error Airborne 0 - 2.5 NM:";

                for (int i = 0; i < dgv_PrecissionAccuracyError_Airborne25_fromASTERIXfile.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv_PrecissionAccuracyError_Airborne25_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 3 + i, columns + 1 + j] = dgv_PrecissionAccuracyError_Airborne25_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                }

                columns = columns + 5;

                hoja_trabajo.Cells[rows + 1, columns + 1] = "Distance Error Airborne 2.5 - 5 NM:";

                for (int i = 0; i < dgv_PrecissionAccuracyError_Airborne5_fromASTERIXfile.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv_PrecissionAccuracyError_Airborne5_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 3 + i, columns + 1 + j] = dgv_PrecissionAccuracyError_Airborne5_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                }

                columns = columns + 5;

                hoja_trabajo.Cells[rows + 1, columns + 1] = "Distance Error Total:";

                for (int i = 0; i < dgv_PrecissionAccuracyError_Total_fromASTERIXfile.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv_PrecissionAccuracyError_Total_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 3 + i, columns + 1 + j] = dgv_PrecissionAccuracyError_Total_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                }


                libros_trabajo.SaveAs(fichero.FileName,
                Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void bt_Export_ProbabilityofMLATDetection_ASTERIXfile_Click(object sender, EventArgs e)
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

                hoja_trabajo.Cells[rows + 1, 0 + 1] = "PROBABILITY OF MLAT DETECTION:";
                rows = rows + 2;

                for (int i = 0; i < dgv_ProbabilityofMLATDetection_fromASTERIXfile.Rows.Count - 2; i++)
                {
                    for (int j = 0; j < dgv_ProbabilityofMLATDetection_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_ProbabilityofMLATDetection_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }
                rows = rows + 5;

                libros_trabajo.SaveAs(fichero.FileName,
                Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void bt_Export_ProbabilityofIdentification_ASTERIXfile_Click(object sender, EventArgs e)
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

                hoja_trabajo.Cells[rows + 1, 0 + 1] = "PROBABILITY OF IDENTIFICATION:";
                rows = rows + 2;

                for (int i = 0; i < dgv_ProbabilityofIdentification_fromASTERIXfile.Rows.Count - 2; i++)
                {
                    for (int j = 0; j < dgv_ProbabilityofIdentification_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_ProbabilityofIdentification_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }
                rows = rows + 5;

                libros_trabajo.SaveAs(fichero.FileName,
                Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void bt_Export_ProbabilityofFalseDetection_ASTERIXfile_Click(object sender, EventArgs e)
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

                hoja_trabajo.Cells[rows + 1, 0 + 1] = "PROBABILITY OF FALSE DETECTION:";
                rows = rows + 2;

                for (int i = 0; i < dgv_ProbabilityofFalseDetection_fromASTERIXfile.Rows.Count - 2; i++)
                {
                    for (int j = 0; j < dgv_ProbabilityofFalseDetection_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_ProbabilityofFalseDetection_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }
                rows = rows + 5;

                libros_trabajo.SaveAs(fichero.FileName,
                Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void bt_Export_ProbabilityofFalseIdentification_ASTERIXfile_Click(object sender, EventArgs e)
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

                hoja_trabajo.Cells[rows + 1, 0 + 1] = "PROBABILITY OF FALSE IDENTIFICATION:";
                rows = rows + 2;

                for (int i = 0; i < dgv_ProbabilityofFalseIdentification_fromASTERIXfile.Rows.Count - 2; i++)
                {
                    for (int j = 0; j < dgv_ProbabilityofFalseIdentification_fromASTERIXfile.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_ProbabilityofFalseIdentification_fromASTERIXfile.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }
                rows = rows + 5;

                libros_trabajo.SaveAs(fichero.FileName,
                Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        #endregion

        #region Buttons to Export performances from Calibration Vehicle

        private void bt_Export_ProbabilityofUpdate_CalibrationVehicle_Click(object sender, EventArgs e)
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

                for (int i = 0; i < dgv_ProbabilityofUpdate_CalibrationVehicle.Rows.Count - 2; i++)
                {
                    for (int j = 0; j < dgv_ProbabilityofUpdate_CalibrationVehicle.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_ProbabilityofUpdate_CalibrationVehicle.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }
                rows = rows + 5;

                libros_trabajo.SaveAs(fichero.FileName,
                Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void bt_Export_PrecissionAccuracy_CalibrationVehicle_Click(object sender, EventArgs e)
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

                hoja_trabajo.Cells[rows + 1, 0 + 1] = "POSITION ACCURACY:";
                rows = rows + 2;

                for (int i = 0; i < dgv_PrecissionAccuracy_CalibrationVehicle.Rows.Count - 2; i++)
                {
                    for (int j = 0; j < dgv_PrecissionAccuracy_CalibrationVehicle.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_PrecissionAccuracy_CalibrationVehicle.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }
                rows = rows + 5;

                libros_trabajo.SaveAs(fichero.FileName,
                Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void bt_Export_ProbabilityofMLATDetection_CalibrationVehicle_Click(object sender, EventArgs e)
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

                hoja_trabajo.Cells[rows + 1, 0 + 1] = "PROBABILITY OF MLAT DETECTION:";
                rows = rows + 2;

                for (int i = 0; i < dgv_ProbabilityofMLATDetection_CalibrationVehicle.Rows.Count - 2; i++)
                {
                    for (int j = 0; j < dgv_ProbabilityofMLATDetection_CalibrationVehicle.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_ProbabilityofMLATDetection_CalibrationVehicle.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }
                rows = rows + 5;

                libros_trabajo.SaveAs(fichero.FileName,
                Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void bt_Export_ProbabilityofIdentification_CalibrationVehicle_Click(object sender, EventArgs e)
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

                hoja_trabajo.Cells[rows + 1, 0 + 1] = "PROBABILITY OF IDENTIFICATION:";
                rows = rows + 2;

                for (int i = 0; i < dgv_ProbabilityofIdentification_CalibrationVehicle.Rows.Count - 2; i++)
                {
                    for (int j = 0; j < dgv_ProbabilityofIdentification_CalibrationVehicle.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_ProbabilityofIdentification_CalibrationVehicle.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }
                rows = rows + 5;

                libros_trabajo.SaveAs(fichero.FileName,
                Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void bt_Export_ProbabilityofFalseDetection_CalibrationVehicle_Click(object sender, EventArgs e)
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

                hoja_trabajo.Cells[rows + 1, 0 + 1] = "PROBABILITY OF FALSE DETECTION:";
                rows = rows + 2;

                for (int i = 0; i < dgv_ProbabilityofFalseIdentification_CalibrationVehicle.Rows.Count - 2; i++)
                {
                    for (int j = 0; j < dgv_ProbabilityofFalseIdentification_CalibrationVehicle.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_ProbabilityofFalseIdentification_CalibrationVehicle.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }
                rows = rows + 5;

                libros_trabajo.SaveAs(fichero.FileName,
                Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void bt_Export_ProbabilityofFalseIdentification_CalibrationVehicle_Click(object sender, EventArgs e)
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

                hoja_trabajo.Cells[rows + 1, 0 + 1] = "PROBABILITY OF FALSE IDENTIFICATION:";
                rows = rows + 2;

                for (int i = 0; i < dgv_ProbabilityofFalseDetection_CalibrationVehicle.Rows.Count - 2; i++)
                {
                    for (int j = 0; j < dgv_ProbabilityofFalseDetection_CalibrationVehicle.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[rows + 1, j + 1] = dgv_ProbabilityofFalseDetection_CalibrationVehicle.Rows[i].Cells[j].Value.ToString();
                    }
                    rows = rows + 1;
                }
                rows = rows + 5;

                libros_trabajo.SaveAs(fichero.FileName,
                Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }


        #endregion

        #region Functions to calculate ED-117 performances from ASTERIX file

        public List<double> CalculateProbabilityofUpdate(List<CAT10> lista)
        { 
            List<CAT10> listaMLATmessages = new List<CAT10>();
            listaMLATmessages.AddRange(lista);

            // Separamos mensajes por Track Number

            List<double> list_of_TrackNumbers = new List<double>();
            for (int i = 0; i < listaMLATmessages.Count(); i++)
            {
                double tracknumber = listaMLATmessages[i].Tracknumber_value;
                if (list_of_TrackNumbers.Contains(tracknumber) == false) { list_of_TrackNumbers.Add(tracknumber); }
            }

            // Agrupamos los paquetes por Track Number

            List<List<CAT10>> list_of_list_of_planes = new List<List<CAT10>>();
            for (int i = 0; i < list_of_TrackNumbers.Count(); i++)
            {
                List<CAT10> list_of_planes = new List<CAT10>();
                for (int j = 0; j < listaMLATmessages.Count(); j++)
                {
                    if (listaMLATmessages[j].Tracknumber_value == list_of_TrackNumbers[i]) { list_of_planes.Add(listaMLATmessages[j]); }
                }
                list_of_list_of_planes.Add(list_of_planes);
            }

            // Vamos lista por lista calculando los paquetes que deberian llegar y los que nos llegan

            double found_messages = 0;
            double expected_messages = 0;

            for (int i = 0; i < list_of_list_of_planes.Count(); i++)
            {
                List<CAT10> listplanes = list_of_list_of_planes[i];

                if (listplanes.Count() > 1)
                {
                    for (int j = 0; j < listplanes.Count() - 1; j++)
                    {
                        double timedelay = listplanes[j + 1].TimeofDay_seconds - listplanes[j].TimeofDay_seconds;
                        if (timedelay <= 1) { found_messages++; }
                        expected_messages++;
                    }
                }
            }

            double probabilityofupdate;
            if(found_messages == 0 && expected_messages == 0)
            {
                probabilityofupdate = 0;
            }
            else
            {
                probabilityofupdate = found_messages / expected_messages;
            }

            List<double> results = new List<double>() { found_messages, expected_messages, probabilityofupdate * 100 };
            return results;
        }

        public List<double> CalculateProbabilityofUpdate1(List<CAT10> lista)
        {
            List<CAT10> listaMLATmessages = new List<CAT10>();
            listaMLATmessages.AddRange(lista);

            // Separamos mensajes por Track Number

            List<string> list_of_TargetAddress = new List<string>();
            for (int i = 0; i < listaMLATmessages.Count(); i++)
            {
                string tracknumber = listaMLATmessages[i].TargetAdress_decoded;
                if (list_of_TargetAddress.Contains(tracknumber) == false) { list_of_TargetAddress.Add(tracknumber); }
            }

            // Agrupamos los paquetes por Track Number

            List<List<CAT10>> list_of_list_of_planes = new List<List<CAT10>>();
            for (int i = 0; i < list_of_TargetAddress.Count(); i++)
            {
                List<CAT10> list_of_planes = new List<CAT10>();
                for (int j = 0; j < listaMLATmessages.Count(); j++)
                {
                    if (listaMLATmessages[j].TargetAdress_decoded == list_of_TargetAddress[i]) { list_of_planes.Add(listaMLATmessages[j]); }
                }
                list_of_list_of_planes.Add(list_of_planes);
            }

            // Vamos lista por lista calculando los paquetes que deberian llegar y los que nos llegan

            double found_messages = 0;
            double expected_messages = 0;

            for (int i = 0; i < list_of_list_of_planes.Count(); i++)
            {
                List<CAT10> listplanes = list_of_list_of_planes[i];

                if (listplanes.Count() > 1)
                {
                    for (int j = 0; j < listplanes.Count() - 1; j++)
                    {
                        double timedelay = listplanes[j + 1].TimeofDay_seconds - listplanes[j].TimeofDay_seconds;
                        if (timedelay < 30)
                        {
                            if (timedelay <= 1) { found_messages++; }
                            expected_messages++;
                        }
                    }
                }
            }

            double probabilityofupdate;
            if (found_messages == 0 && expected_messages == 0)
            {
                probabilityofupdate = 0;
            }
            else
            {
                probabilityofupdate = found_messages / expected_messages;
            }

            List<double> results = new List<double>() { found_messages, expected_messages, probabilityofupdate * 100 };
            return results;
        }

        public List<List<double>> CalculatePrecissionAccuracy(List<CAT10> list1, List<CAT21> list2, double PIC)
        {
            List<CAT10> listaMLATmessages = new List<CAT10>();
            listaMLATmessages.AddRange(list1);

            List<CAT21> listaCAT21messages = new List<CAT21>();
            listaCAT21messages.AddRange(list2);

            // Filtramos por PIC
            List<CAT21> list3 = new List<CAT21>();
            for (int i = 0; i < listaCAT21messages.Count; i++)
            {
                if (listaCAT21messages[i].PIC >= PIC)
                {
                    list3.Add(listaCAT21messages[i]);
                }
            }
            listaCAT21messages.Clear();
            listaCAT21messages.AddRange(list3);

            // Organizamos loos paquetes ADSB por listas segun su TargetAddress
            // Separamos mensajes por Track Number

            List<string> list_of_TargetAddress = new List<string>();
            for (int i = 0; i < listaCAT21messages.Count(); i++)
            {
                string targetaddress = listaCAT21messages[i].TargetAdress_real;
                if (list_of_TargetAddress.Contains(targetaddress) == false) { list_of_TargetAddress.Add(targetaddress); }
            }

            // Agrupamos los paquetes por Target Address

            List<List<CAT21>> list_of_list_of_planes = new List<List<CAT21>>();
            for (int i = 0; i < list_of_TargetAddress.Count(); i++)
            {
                List<CAT21> list_of_planes = new List<CAT21>();
                for (int j = 0; j < listaCAT21messages.Count(); j++)
                {
                    if (listaCAT21messages[j].TargetAdress_real == list_of_TargetAddress[i]) { list_of_planes.Add(listaCAT21messages[j]); }
                }
                list_of_list_of_planes.Add(list_of_planes);
            }


            List<double> lista_distances = new List<double>();
            List<double> lista_errorhorizontal = new List<double>();
            List<double> lista_errorvertical = new List<double>();

            // Recorremos listaMLAT
            for (int i = 0; i < listaMLATmessages.Count(); i++)
            {
                int index_i = 1000000;
                int index_j = 1000000;
                double distance = 1e8;
                string TargetAddressMLAT = listaMLATmessages[i].TargetAdress_decoded;

                // Buscamos, en la lista de listas CAT21, que lista tiene el mismo Target Address

                List<CAT21> listaavionesCAT21mismonombre = new List<CAT21>();
                bool found = false;
                for (int j = 0; j<list_of_list_of_planes.Count() && found == false; j++)
                {
                    var list = list_of_list_of_planes[j];
                    if(list.First().TargetAdress_real == TargetAddressMLAT)
                    {
                        listaavionesCAT21mismonombre = list;
                        found = true;
                    }
                }

                //Vamos a hacer una lista de objetos donde cada objeto tiene un cat21 y un tiempo
                List<PaqueteADSByTiempo> listaavionesCAT21mismonombre1 = new List<PaqueteADSByTiempo>();
                listaavionesCAT21mismonombre1.Clear();
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

                double timeMLAT = listaMLATmessages[i].timetotal;

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

                // Si hemos encontrado un index anterior y posterior (es decir si los valores iniciales de index anterior y posterior han cambiado)
                if (indexj_anterior != 1000000 && indexj_posterior != 1000000 && Math.Abs(indexj_anterior - indexj_posterior) <= 2)
                {
                    CoordinatesXYZ newCcoordinatesADSB = new CoordinatesXYZ();

                    //Interpolamos para encontrar Lat
                    double x0 = ListaPlanesMismoNombre1[indexj_anterior].time;
                    double x1 = ListaPlanesMismoNombre1[indexj_posterior].time;
                    double x = timeMLAT;

                    double y0 = ListaPlanesMismoNombre1[indexj_anterior].cat21.coordSystemCartesian.Y;
                    double y1 = ListaPlanesMismoNombre1[indexj_posterior].cat21.coordSystemCartesian.Y;

                    if ((x1 - x0) == 0)
                    {
                        newCcoordinatesADSB.Y = (y0 + y1) / 2;
                    }
                    newCcoordinatesADSB.Y = y0 + (x - x0) * (y1 - y0) / (x1 - x0);

                    // Interpolamos para encontrar Lon
                    y0 = ListaPlanesMismoNombre1[indexj_anterior].cat21.coordSystemCartesian.X;
                    y1 = ListaPlanesMismoNombre1[indexj_posterior].cat21.coordSystemCartesian.X;
                    //x = timeMLAT;

                    if ((x1 - x0) == 0)
                    {
                        newCcoordinatesADSB.X = (y0 + y1) / 2;
                    }
                    newCcoordinatesADSB.X = y0 + (x - x0) * (y1 - y0) / (x1 - x0);

                    // Interpolamos para encontrar Alt
                    y0 = ListaPlanesMismoNombre1[indexj_anterior].cat21.coordSystemCartesian.Z;
                    y1 = ListaPlanesMismoNombre1[indexj_posterior].cat21.coordSystemCartesian.Z;
                    //x = timeMLAT;

                    if ((x1 - x0) == 0)
                    {
                        newCcoordinatesADSB.Z = (y0 + y1) / 2;
                    }
                    newCcoordinatesADSB.Z = y0 + (x - x0) * (y1 - y0) / (x1 - x0);

                    // Calculamos distancia entre la newCoordinatesADSB inteprolada y las coordenadas del paquete MLAT de turno

                    // 2. Calculamos distancia

                    double X1 = listaMLATmessages[i].coordSystemCartesian.X;
                    double Y1 = listaMLATmessages[i].coordSystemCartesian.Y;

                    double X2 = newCcoordinatesADSB.X;
                    double Y2 = newCcoordinatesADSB.Y;

                    double distances = Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1));
                    lista_distances.Add(distances);
                    lista_errorhorizontal.Add(X2 - X1);
                    lista_errorvertical.Add(Y2 - Y1);
                }
                else
                {

                }
            }

            List<List<double>> results = new List<List<double>>() { lista_distances, lista_errorhorizontal, lista_errorvertical };
            return results;
        }

        public List<double> CalculatePRobabilityofMLATDetection(List<CAT10> list, double interval)
        {
            List<CAT10> listaMLATmessages = new List<CAT10>();
            listaMLATmessages.AddRange(list);

            // Filtramos paquetes sin info de posicion
            List<CAT10> list1 = new List<CAT10>();
            for (int i = 0; i < listaMLATmessages.Count(); i++)
            {
                if ((listaMLATmessages[i].PositioninCartesianCoordinates.Length > 0 && listaMLATmessages[i].MeasuredPositioninPolarCoordinates.Length > 0) || (listaMLATmessages[i].PositioninCartesianCoordinates.Length > 0) || (listaMLATmessages[i].MeasuredPositioninPolarCoordinates.Length > 0))
                {
                    list1.Add(listaMLATmessages[i]);
                }
            }
            listaMLATmessages.Clear();
            listaMLATmessages.AddRange(list1);

            //// Separamos mensajes por Track Number

            //List<double> list_of_TrackNumbers = new List<double>();
            //for (int i = 0; i < listaMLATmessages.Count(); i++)
            //{
            //    double tracknumber = listaMLATmessages[i].Tracknumber_value;
            //    if (list_of_TrackNumbers.Contains(tracknumber) == false) { list_of_TrackNumbers.Add(tracknumber); }
            //}

            // Separamos mensajes por Target Address

            List<string> list_of_TrackNumbers = new List<string>();
            for (int i = 0; i < listaMLATmessages.Count(); i++)
            {
                string tracknumber = listaMLATmessages[i].TargetAdress_decoded;
                if (list_of_TrackNumbers.Contains(tracknumber) == false) { list_of_TrackNumbers.Add(tracknumber); }
            }

            //// Agrupamos los paquetes por Track Number

            //List<List<CAT10>> list_of_list_of_planes = new List<List<CAT10>>();
            //for (int i = 0; i < list_of_TrackNumbers.Count(); i++)
            //{
            //    List<CAT10> list_of_planes = new List<CAT10>();
            //    for (int j = 0; j < listaMLATmessages.Count(); j++)
            //    {
            //        if (listaMLATmessages[j].Tracknumber_value == list_of_TrackNumbers[i]) { list_of_planes.Add(listaMLATmessages[j]); }
            //    }
            //    list_of_list_of_planes.Add(list_of_planes);
            //}

            // Agrupamos los paquetes por Target Address

            List<List<CAT10>> list_of_list_of_planes = new List<List<CAT10>>();
            for (int i = 0; i < list_of_TrackNumbers.Count(); i++)
            {
                List<CAT10> list_of_planes = new List<CAT10>();
                for (int j = 0; j < listaMLATmessages.Count(); j++)
                {
                    if (listaMLATmessages[j].TargetAdress_decoded == list_of_TrackNumbers[i]) { list_of_planes.Add(listaMLATmessages[j]); }
                }
                list_of_list_of_planes.Add(list_of_planes);
            }

            // Vamos lista por lista calculando los paquetes que deberian llegar y los que nos llegan

            double found_messages = 0;
            double expected_messages = 0;

            for (int i = 0; i < list_of_list_of_planes.Count(); i++)
            {
                List<CAT10> listplanes = list_of_list_of_planes[i];
                
                // Buscamos timepo incial y timepo final de la trayectoria

                double time = listplanes.First().timetotal;
                double time_final = listplanes.Last().timetotal;

                // Buscle que vaya creando una ventana de tiempo de x segundos y vaya aumentando el tiempo incial de esa ventana un segundo a cada iteración

                while(time + interval < time_final)
                {
                    if(time >= 86030)
                    {

                    }

                    // Bucle para buscar cuantos paquetes hay en esa ventana de tiempo
                    List<CAT10> listplanesinterval = new List<CAT10>();
                    listplanesinterval.Clear();

                    for (int j = 0; j < listplanes.Count(); j++)
                    {
                        if(listplanes[j].timetotal>= time && listplanes[j].timetotal < time + interval)
                        {
                            listplanesinterval.Add(listplanes[j]);
                        }
                    }

                    // Ahora buscamos cuantos paquetes hay en esa ventana de tiempo
                    int messages = listplanesinterval.Count();

                    if (messages > 0)
                    {
                        found_messages++;
                    }
                    expected_messages++;

                    time++;
                }
            }

            double probabilityofupdate;
            if (found_messages == 0 && expected_messages == 0)
            {
                probabilityofupdate = 0;
            }
            else
            {
                probabilityofupdate = found_messages / expected_messages;
            }

            List<double> results = new List<double>() { found_messages, expected_messages, probabilityofupdate * 100 };
            return results;
        }

        public List<double> CalculatePRobabilityofMLATDetection1(List<CAT10> list, double interval)
        {
            List<CAT10> listaMLATmessages = new List<CAT10>();
            listaMLATmessages.AddRange(list);

            // Filtramos paquetes sin info de posicion
            List<CAT10> list1 = new List<CAT10>();
            for (int i = 0; i < listaMLATmessages.Count(); i++)
            {
                if ((listaMLATmessages[i].PositioninCartesianCoordinates.Length > 0 && listaMLATmessages[i].MeasuredPositioninPolarCoordinates.Length > 0) || (listaMLATmessages[i].PositioninCartesianCoordinates.Length > 0) || (listaMLATmessages[i].MeasuredPositioninPolarCoordinates.Length > 0))
                {
                    list1.Add(listaMLATmessages[i]);
                }
            }
            listaMLATmessages.Clear();
            listaMLATmessages.AddRange(list1);

            List<string> list_of_TrackNumbers = new List<string>();
            for (int i = 0; i < listaMLATmessages.Count(); i++)
            {
                string tracknumber = listaMLATmessages[i].TargetAdress_decoded;
                if (list_of_TrackNumbers.Contains(tracknumber) == false) { list_of_TrackNumbers.Add(tracknumber); }
            }

            // Agrupamos los paquetes por Target Address

            List<List<CAT10>> list_of_list_of_planes = new List<List<CAT10>>();
            for (int i = 0; i < list_of_TrackNumbers.Count(); i++)
            {
                List<CAT10> list_of_planes = new List<CAT10>();
                for (int j = 0; j < listaMLATmessages.Count(); j++)
                {
                    if (listaMLATmessages[j].TargetAdress_decoded == list_of_TrackNumbers[i]) { list_of_planes.Add(listaMLATmessages[j]); }
                }
                list_of_list_of_planes.Add(list_of_planes);
            }

            // ahora separamos los paquetes por los i ntervalos en los que estan en una zona (para que, una vez salgan de una zona, aunque luego se vuelvan a menter contarlos como 2 trayectorias diferentes)

            List<List<CAT10>> list_of_subzones = new List<List<CAT10>>();
            List<CAT10> list111 = new List<CAT10>();

            for (int j = 0; j < list_of_list_of_planes.Count(); j++)
            {
                List<CAT10> list11 = list_of_list_of_planes[j];

                for (int i = 0; i < list11.Count() - 1; i++)
                {
                    if (list11[i + 1].timetotal - list11[i].timetotal < 20)
                    {
                        list111.Add(list11[i]);
                    }
                    else
                    {
                        list111.Add(list11[i]);
                        list_of_subzones.Add(list111);
                        list111 = new List<CAT10>();
                    }
                }
                if (list11.Count > 0)
                {
                    list111.Add(list11.Last());
                }
                list_of_subzones.Add(list111);
                list111 = new List<CAT10>();
            }

            // Vamos lista por lista calculando los paquetes que deberian llegar y los que nos llegan

            double found_messages = 0;
            double expected_messages = 0;

            for (int i = 0; i < list_of_subzones.Count(); i++)
            {
                if (list_of_subzones[i].Count() > 0)
                {
                    List<CAT10> listplanes = list_of_subzones[i];

                    // Buscamos timepo incial y timepo final de la trayectoria

                    double time = listplanes.First().timetotal;
                    double time_final = listplanes.Last().timetotal;

                    // Buscle que vaya creando una ventana de tiempo de x segundos y vaya aumentando el tiempo incial de esa ventana un segundo a cada iteración

                    while (time + interval < time_final)
                    {
                        // Bucle para buscar cuantos paquetes hay en esa ventana de tiempo
                        List<CAT10> listplanesinterval = new List<CAT10>();
                        listplanesinterval.Clear();

                        for (int j = 0; j < listplanes.Count(); j++)
                        {
                            if (listplanes[j].timetotal >= time && listplanes[j].timetotal < time + interval)
                            {
                                listplanesinterval.Add(listplanes[j]);
                            }
                        }

                        // Ahora buscamos cuantos paquetes hay en esa ventana de tiempo
                        int messages = listplanesinterval.Count();

                        if (messages > 0)
                        {
                            found_messages++;
                        }
                        expected_messages++;

                        time++;
                    }
                }
            }

            double probabilityofupdate;
            if (found_messages == 0 && expected_messages == 0)
            {
                probabilityofupdate = 0;
            }
            else
            {
                probabilityofupdate = found_messages / expected_messages;
            }

            List<double> results = new List<double>() { found_messages, expected_messages, probabilityofupdate * 100 };
            return results;
        }

        public List<double> CalculatePRobabilityofIdentification(List<CAT10> list)
        {
            List<CAT10> listaMLATmessages = new List<CAT10>();
            listaMLATmessages.AddRange(list);

            // Separamos mensajes por Track Number

            List<double> list_of_TrackNumbers = new List<double>();
            for (int i = 0; i < listaMLATmessages.Count(); i++)
            {
                double tracknumber = listaMLATmessages[i].Tracknumber_value;
                if (list_of_TrackNumbers.Contains(tracknumber) == false) { list_of_TrackNumbers.Add(tracknumber); }
            }

            // Agrupamos los paquetes por Track Number

            List<List<CAT10>> list_of_list_of_planes = new List<List<CAT10>>();
            for (int i = 0; i < list_of_TrackNumbers.Count(); i++)
            {
                List<CAT10> list_of_planes = new List<CAT10>();
                for (int j = 0; j < listaMLATmessages.Count(); j++)
                {
                    if (listaMLATmessages[j].Tracknumber_value == list_of_TrackNumbers[i]) { list_of_planes.Add(listaMLATmessages[j]); }
                }
                list_of_list_of_planes.Add(list_of_planes);
            }

            // Vamos lista por lista comprobando cuantos paquetes estan bien y cuantos mal
            double found_messages = 0;
            double expected_messages = 0;

            for (int i = 0; i < list_of_list_of_planes.Count(); i++)
            {
                List<CAT10> listplanes = list_of_list_of_planes[i];

                // Ahora buscamos cuantos Target Address diferentes hay dento de la lista listplanes
                List<string> listaTargetAddress = new List<string>();
                List<double> listaCounters = new List<double>();
                for (int j = 0; j < listplanes.Count(); j++)
                {
                    if (listaTargetAddress.Contains(listplanes[j].TargetAdress_decoded) == false)
                    {
                        listaTargetAddress.Add(listplanes[j].TargetAdress_decoded);
                        int counter = 0;
                        for (int k = 0; k < listplanes.Count(); k++)
                        {
                            if (listplanes[k].TargetAdress_decoded == listplanes[j].TargetAdress_decoded) { counter++; }
                        }
                        listaCounters.Add(counter);
                    }
                }

                if (listaCounters.Count() > 0)
                {
                    found_messages = found_messages + listaCounters.Max();
                    expected_messages = expected_messages + listaCounters.Sum();
                }
            }

            double probabilityofupdate;
            if (found_messages == 0 && expected_messages == 0)
            {
                probabilityofupdate = 0;
            }
            else
            {
                probabilityofupdate = found_messages / expected_messages;
            }

            List<double> results = new List<double>() { found_messages, expected_messages, probabilityofupdate * 100 };
            return results;
        }

        public List<double> CalculatePRobabilityofFalseDetection(List<CAT10> list, double false_detection_distance)
        {
            List<CAT10> listaMLATmessages = new List<CAT10>();
            listaMLATmessages.AddRange(list);

            // Separamos mensajes por Track Number

            //List<double> list_of_TrackNumbers = new List<double>();
            //for (int i = 0; i < listaMLATmessages.Count(); i++)
            //{
            //    double tracknumber = listaMLATmessages[i].Tracknumber_value;
            //    if (list_of_TrackNumbers.Contains(tracknumber) == false) { list_of_TrackNumbers.Add(tracknumber); }
            //}

            //// Agrupamos los paquetes por Track Number

            //List<List<CAT10>> list_of_list_of_planes = new List<List<CAT10>>();
            //for (int i = 0; i < list_of_TrackNumbers.Count(); i++)
            //{
            //    List<CAT10> list_of_planes = new List<CAT10>();
            //    for (int j = 0; j < listaMLATmessages.Count(); j++)
            //    {
            //        if (listaMLATmessages[j].Tracknumber_value == list_of_TrackNumbers[i]) { list_of_planes.Add(listaMLATmessages[j]); }
            //    }
            //    list_of_list_of_planes.Add(list_of_planes);
            //}

            List<string> list_of_TrackNumbers = new List<string>();
            for (int i = 0; i < listaMLATmessages.Count(); i++)
            {
                string tracknumber = listaMLATmessages[i].TargetAdress_decoded;
                if (list_of_TrackNumbers.Contains(tracknumber) == false) { list_of_TrackNumbers.Add(tracknumber); }
            }

            List<List<CAT10>> list_of_list_of_planes = new List<List<CAT10>>();
            for (int i = 0; i < list_of_TrackNumbers.Count(); i++)
            {
                List<CAT10> list_of_planes = new List<CAT10>();
                for (int j = 0; j < listaMLATmessages.Count(); j++)
                {
                    if (listaMLATmessages[j].TargetAdress_decoded == list_of_TrackNumbers[i]) { list_of_planes.Add(listaMLATmessages[j]); }
                }
                list_of_list_of_planes.Add(list_of_planes);
            }

            // recorremos lista por lista y hacemos los cálculos

            double false_detections = 0;
            double total_detections = 0;

            for (int i = 0; i < list_of_list_of_planes.Count(); i++)
            {
                List<CAT10> planeslist = list_of_list_of_planes[i];
                for (int j = 0; j < planeslist.Count() - 1; j++)
                {
                    double timedelay = planeslist[j + 1].timetotal - planeslist[j].timetotal;
                    if (timedelay <= 1)
                    {
                        // Calculamos la dirección en la que se mueve
                        double Vx = planeslist[j].Vx_cartesian;
                        double Vy = planeslist[j].Vy_cartesian;

                        double Ax = planeslist[j].CalculatedAcceleration_X;
                        double Ay = planeslist[j].CalculatedAcceleration_Y;

                        double angle = Math.Atan2(Vy, Vx);

                        // Calculamos la distancia recorrida en 1s
                        double deltaX = Vx * 1 + (Ax * 1 * 1) / 2.0;
                        double deltaY = Vy * 1 + (Ay * 1 * 1) / 2.0;

                        // Calculamos la distancia recorrida en polares

                        double rho = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
                        double theta = (180 / Math.PI) * Math.Atan2(deltaX, deltaY);

                        // Calculamos la nueva posición

                        double[] newcoord = NewCoordinates(new double[] { planeslist[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, planeslist[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS }, rho, theta);
                        CoordinatesWGS84 newcoord1 = new CoordinatesWGS84(newcoord[0] * GeoUtils.DEGS2RADS, newcoord[1] * GeoUtils.DEGS2RADS);

                        // Calculamos la distancia entre esas nuevas coordenadas y las del siguiente mensaje

                        CoordinatesXYZ coordGeocentric = GeoUtils1.change_geodesic2geocentric(newcoord1);
                        CoordinatesXYZ coordSystemCartesian = GeoUtils1.change_geocentric2system_cartesian(coordGeocentric);
                        CoordinatesUVH coordStereographic = GeoUtils1.change_system_cartesian2stereographic(coordSystemCartesian);

                        double U1 = planeslist[j + 1].coordStereographic.U;
                        double V1 = planeslist[j + 1].coordStereographic.V;

                        double U2 = coordStereographic.U;
                        double V2 = coordStereographic.V;

                        double distance = Math.Sqrt((U2 - U1) * (U2 - U1) + (V2 - V1) * (V2 - V1));

                        // Calculamos contadores
                        if (distance > false_detection_distance)
                        {
                            false_detections++;
                        }
                        total_detections++;
                    }
                }
            }

            double probabilityofupdate;
            if (false_detections == 0 && total_detections == 0)
            {
                probabilityofupdate = 0;
            }
            else
            {
                probabilityofupdate = false_detections / total_detections;
            }

            List<double> results = new List<double>() { false_detections, total_detections, probabilityofupdate * 100 };
            return results;
        }

        public List<double> CalculatePRobabilityofFalseIdentification(List<CAT10> list)
        {
            List<CAT10> listaMLATmessages = new List<CAT10>();
            listaMLATmessages.AddRange(list);

            //// Separamos mensajes por Track Number

            //List<double> list_of_TrackNumbers = new List<double>();
            //for (int i = 0; i < listaMLATmessages.Count(); i++)
            //{
            //    double tracknumber = listaMLATmessages[i].Tracknumber_value;
            //    if (list_of_TrackNumbers.Contains(tracknumber) == false) { list_of_TrackNumbers.Add(tracknumber); }
            //}

            //// Agrupamos los paquetes por Track Number

            //List<List<CAT10>> list_of_list_of_planes = new List<List<CAT10>>();
            //for (int i = 0; i < list_of_TrackNumbers.Count(); i++)
            //{
            //    List<CAT10> list_of_planes = new List<CAT10>();
            //    for (int j = 0; j < listaMLATmessages.Count(); j++)
            //    {
            //        if (listaMLATmessages[j].Tracknumber_value == list_of_TrackNumbers[i]) { list_of_planes.Add(listaMLATmessages[j]); }
            //    }
            //    list_of_list_of_planes.Add(list_of_planes);
            //}

            List<string> list_of_TrackNumbers = new List<string>();
            for (int i = 0; i < listaMLATmessages.Count(); i++)
            {
                string tracknumber = listaMLATmessages[i].TargetAdress_decoded;
                if (list_of_TrackNumbers.Contains(tracknumber) == false) { list_of_TrackNumbers.Add(tracknumber); }
            }

            List<List<CAT10>> list_of_list_of_planes = new List<List<CAT10>>();
            for (int i = 0; i < list_of_TrackNumbers.Count(); i++)
            {
                List<CAT10> list_of_planes = new List<CAT10>();
                for (int j = 0; j < listaMLATmessages.Count(); j++)
                {
                    if (listaMLATmessages[j].TargetAdress_decoded == list_of_TrackNumbers[i]) { list_of_planes.Add(listaMLATmessages[j]); }
                }
                list_of_list_of_planes.Add(list_of_planes);
            }

            // Vamos lista por lista comprobando cuantos paquetes estan bien y cuantos mal
            double found_messages = 0;
            double expected_messages = 0;

            for (int i = 0; i < list_of_list_of_planes.Count(); i++)
            {
                List<CAT10> listplanes1 = list_of_list_of_planes[i];

                double errors = 0;
                double expected = 0;

                // Ahora hay que separar la lista listplanes1 en ventanas de 5s
                double time = listplanes1[0].timetotal;
                while (time <= listplanes1.Last().timetotal && time < time + 5)
                {
                    List<CAT10> listplanes = new List<CAT10>();
                    listplanes.Clear();
                    for (int h = 0; h < listplanes1.Count(); h++)
                    {
                        if ((listplanes1[h].timetotal > time) && listplanes1[h].timetotal < (time + 5))
                        {
                        listplanes.Add(listplanes1[h]);
                        }
                    }

                    //--------------------------------------------------------------

                    // Ahora buscamos cuantos Target Address diferentes hay dento de la lista listplanes
                    List<string> listaTargetAddress = new List<string>();
                    List<double> listaCounters = new List<double>();
                    for (int j = 0; j < listplanes.Count(); j++)
                    {
                        if (listaTargetAddress.Contains(listplanes[j].TargetAdress_decoded) == false)
                        {
                            listaTargetAddress.Add(listplanes[j].TargetAdress_decoded);
                            int counter = 0;
                            for (int k = 0; k < listplanes.Count(); k++)
                            {
                                if (listplanes[k].TargetAdress_decoded != listplanes[j].TargetAdress_decoded) { counter++; }
                            }
                            listaCounters.Add(counter);
                        }
                    }
                    if (listaCounters.Count() > 0)
                    {
                        errors = errors + (listaCounters.Max());
                        expected = expected + listplanes1.Count();

                        if(expected > 0)
                        {
                            double prob_error = errors / expected;
                            if(prob_error > 10e6) { found_messages++; }
                            expected_messages++;
                        }
                    }

                    //-------------------------------------------------------------

                    time = time + 5;
                }
            }

            double probabilityofupdate;
            if (found_messages == 0 && expected_messages == 0)
            {
                probabilityofupdate = 0;
            }
            else
            {
                probabilityofupdate = found_messages / expected_messages;
            }

            List<double> results = new List<double>() { found_messages, expected_messages, probabilityofupdate * 100 };
            return results;
        }

        #endregion

        #region Functions to calculate ED-117 performances from Calibration Vehicle

        public List<List<double>> CalculatePrecissionAccuracyCalibrationVehicle(List<CAT10> list, List<MLATCalibrationData> list2)
        {
            GMapOverlay overlay = new GMapOverlay();
            overlay.Clear();

            List<CAT10> listaMLATmessages = new List<CAT10>();
            listaMLATmessages.AddRange(list);

            // Ahora asignamo el valor de tiempo real (si hemos pasado de 23:59:59 a 0:00:00 vamos a tener problemas, hay que especificar que aunque hayamos papsado a tiempo = 0 es un tiwmpomayor que el anterior)
            // Recorremos la lista. si entre un tiempo y otro hay un cambio de +12h es que hemos cambiado de dia

            for (int i = 0; i < listaMLATmessages.Count() - 1; i++)
            {
                if (Math.Abs(listaMLATmessages[i + 1].TimeofDay_seconds - listaMLATmessages[i].TimeofDay_seconds) > 12 * 3600)
                {
                    i = i + 1;
                    while (i < listaMLATmessages.Count())
                    {
                        listaMLATmessages[i].timetotal = listaMLATmessages[i].TimeofDay_seconds + 24 * 3600;
                        i = i + 1;
                    }
                    break;
                }
            }

            List<MLATCalibrationData> listaADSB = new List<MLATCalibrationData>();
            listaADSB.AddRange(list2);

            // Identificamos el Update rate de la listaDGPS:
            List<double> list1 = new List<double>();
            for (int i = 1; i < listaADSB.Count(); i++) { list1.Add(listaADSB[i].timetotal - listaADSB[i - 1].timetotal); }
            double tupdate = list1.Average();
            tupdate = (Math.Ceiling(tupdate * 1e5)) / 1e5;

            GMapOverlay overlay1 = new GMapOverlay();
            double[] coordinatesADSB = new double[2];
            double[] newCoordinatesADSB = new double[2];

            List<List<double>> results = new List<List<double>>();
            List<double> listadistances = new List<double>();
            List<double> listaDeltaX = new List<double>();
            List<double> listaDeltaY = new List<double>();

            for (int i = 0; i < listaMLATmessages.Count(); i++) // recorrem la lista MLAT
            {
                double timeMLAT = listaMLATmessages[i].timetotal;

                int indexj_anterior = 1000000;
                int indexj_posterior = 1000000;
                double distance = 1000000;

                // buacamos paquete Vehiculo de calibracion mas cercano en tiempo por debajo
                for (int j = 0; j < listaADSB.Count(); j++)
                {
                    double timedelay = Math.Abs(timeMLAT - listaADSB[j].timetotal);
                    if (timedelay < 1 && listaADSB[j].timetotal < timeMLAT) { indexj_anterior = j; }
                }

                // buacamos paquete Vehiculo de calibracion mas cercano en tiempo por debajo
                for (int j = listaADSB.Count - 1; j >= 0; j--)
                {
                    double timedelay = Math.Abs(timeMLAT - listaADSB[j].timetotal);
                    if (timedelay < 1 && listaADSB[j].timetotal > timeMLAT) { indexj_posterior = j; }
                }

                if (indexj_anterior != 1000000 && indexj_posterior != 1000000 && indexj_posterior - indexj_anterior <= 1)
                {
                    //double timedistancewith_posterior = listaADSB[indexj_posterior].timetotal - timeMLAT;
                    //double timedistancewith_anterior = timeMLAT - listaADSB[indexj_anterior].timetotal;

                    //if (timedistancewith_posterior + timedistancewith_anterior <= 2)

                    double timedistancewith_posterior = listaADSB[indexj_posterior].timetotal - listaADSB[indexj_anterior].timetotal;

                    if (timedistancewith_posterior <= tupdate)
                    {
                        //Interpolamos para encontrar Lat
                        double x0 = listaADSB[indexj_anterior].timetotal;
                        double x1 = listaADSB[indexj_posterior].timetotal;
                        double x = timeMLAT;

                        double y0 = (listaADSB[indexj_anterior].Lat);
                        double y1 = (listaADSB[indexj_posterior].Lat);

                        if ((x1 - x0) == 0)
                        {
                            newCoordinatesADSB[0] = (y0 + y1) / 2;
                        }
                        newCoordinatesADSB[0] = y0 + (x - x0) * (y1 - y0) / (x1 - x0);

                        //Interpolamos para encontrar Lat
                        x0 = listaADSB[indexj_anterior].timetotal;
                        x1 = listaADSB[indexj_posterior].timetotal;
                        x = timeMLAT;

                        y0 = (listaADSB[indexj_anterior].Lon);
                        y1 = (listaADSB[indexj_posterior].Lon);

                        if ((x1 - x0) == 0)
                        {
                            newCoordinatesADSB[1] = (y0 + y1) / 2;
                        }
                        newCoordinatesADSB[1] = y0 + (x - x0) * (y1 - y0) / (x1 - x0);


                        CoordinatesWGS84 coordGeodesic = new CoordinatesWGS84(newCoordinatesADSB[0]*GeoUtils.DEGS2RADS, newCoordinatesADSB[1]*GeoUtils.DEGS2RADS);
                        CoordinatesXYZ coordGeocentric = GeoUtils1.change_geodesic2geocentric(coordGeodesic);
                        CoordinatesXYZ coordSystemCartesian = GeoUtils1.change_geocentric2system_cartesian(coordGeocentric);
                        CoordinatesUVH newCoordStereographic = GeoUtils1.change_system_cartesian2stereographic(coordSystemCartesian);

                        double U1 = listaMLATmessages[i].coordStereographic.U;
                        double V1 = listaMLATmessages[i].coordStereographic.V;

                        double U2 = newCoordStereographic.U;
                        double V2 = newCoordStereographic.V;

                        double distances = Math.Sqrt((U2 - U1) * (U2 - U1) + (V2 - V1) * (V2 - V1));
                        listadistances.Add(distances);
                        listaDeltaX.Add(U2 - U1);
                        listaDeltaY.Add(V2 - V1);

                        // Ahora añadimos poligonos al mapa.

                        List<PointLatLng> polygonpoints = new List<PointLatLng>() {new PointLatLng(coordGeodesic.Lat * GeoUtils.RADS2DEGS, coordGeodesic.Lon * GeoUtils.RADS2DEGS), new PointLatLng(listaMLATmessages[i].coordGeodesic.Lat*GeoUtils.RADS2DEGS, listaMLATmessages[i].coordGeodesic.Lon*GeoUtils.RADS2DEGS) };
                        GMapPolygon polygon = new GMapPolygon(polygonpoints, "Polygon")
                        {
                            Stroke = new Pen(Color.Red, 2),
                            Fill = new SolidBrush(Color.Red)
                        };
                        overlay.Polygons.Add(polygon);
                    }
                }
            }

            Mapa.Overlays.Clear();
            Mapa.Overlays.Add(overlay);

            List<List<double>> results1 = new List<List<double>>() { listadistances, listaDeltaX, listaDeltaY }; 

            return results1;
        }

        public List<List<double>> CalculatePrecissionAccuracyCalibrationVehicle1(List<CAT10> list, List<MLATCalibrationData> list2)
        {
            GMapOverlay overlay_lines = new GMapOverlay();
            overlay_lines.Clear();
            GMapOverlay overlay_MarkersMLAT = new GMapOverlay();
            overlay_MarkersMLAT.Clear();
            GMapOverlay overlay_MarkersADSB = new GMapOverlay();
            overlay_MarkersADSB.Clear();

            List<CAT10> listaMLATmessages = new List<CAT10>();
            listaMLATmessages.AddRange(list);

            List<MLATCalibrationData> listaADSB = new List<MLATCalibrationData>();
            listaADSB.AddRange(list2);

            // Identificamos el Update rate de la listaDGPS:
            List<double> list1 = new List<double>();
            for (int i = 1; i < listaADSB.Count(); i++) { list1.Add(listaADSB[i].timetotal - listaADSB[i - 1].timetotal); }
            double tupdate = list1.Average();
            tupdate = (Math.Ceiling(tupdate * 1e5)) / 1e5;

            GMapOverlay overlay1 = new GMapOverlay();
            double[] coordinatesADSB = new double[2];
            CoordinatesWGS84 newCoordinatesADSB = new CoordinatesWGS84();

            List<List<double>> results = new List<List<double>>();
            List<double> listadistances = new List<double>();
            List<double> listaDeltaX = new List<double>();
            List<double> listaDeltaY = new List<double>();

            for (int i = 0; i < listaMLATmessages.Count(); i++) // recorrem la lista MLAT
            {
                double timeMLAT = listaMLATmessages[i].timetotal;

                int indexj_anterior = 1000000;
                int indexj_posterior = 1000000;
                double distance = 1000000;

                // buacamos paquete Vehiculo de calibracion mas cercano en tiempo por debajo
                for (int j = 0; j < listaADSB.Count(); j++)
                {
                    double timedelay = Math.Abs(timeMLAT - listaADSB[j].timetotal);
                    if (timedelay <= tupdate && listaADSB[j].timetotal < timeMLAT) { indexj_anterior = j; }
                }

                // buacamos paquete Vehiculo de calibracion mas cercano en tiempo por debajo
                for (int j = listaADSB.Count - 1; j >= 0; j--)
                {
                    double timedelay = Math.Abs(timeMLAT - listaADSB[j].timetotal);
                    if (timedelay <= tupdate && listaADSB[j].timetotal > timeMLAT) { indexj_posterior = j; }
                }

                if (indexj_anterior != 1000000 && indexj_posterior != 1000000 && indexj_posterior - indexj_anterior <=2)
                {
                    //Interpolamos para encontrar Lat
                    double x0 = listaADSB[indexj_anterior].timetotal;
                    double x1 = listaADSB[indexj_posterior].timetotal;
                    double x = timeMLAT;

                    double y0 = (listaADSB[indexj_anterior].coordGeodesic.Lat);
                    double y1 = (listaADSB[indexj_posterior].coordGeodesic.Lat);

                    if ((x1 - x0) == 0)
                    {
                        newCoordinatesADSB.Lat = (y0 + y1) / 2;
                    }
                    newCoordinatesADSB.Lat = y0 + (x - x0) * (y1 - y0) / (x1 - x0);

                    //Interpolamos para encontrar Lon
                    x0 = listaADSB[indexj_anterior].timetotal;
                    x1 = listaADSB[indexj_posterior].timetotal;
                    x = timeMLAT;

                    y0 = (listaADSB[indexj_anterior].coordGeodesic.Lon);
                    y1 = (listaADSB[indexj_posterior].coordGeodesic.Lon);

                    if ((x1 - x0) == 0)
                    {
                        newCoordinatesADSB.Lon = (y0 + y1) / 2;
                    }
                    newCoordinatesADSB.Lon = y0 + (x - x0) * (y1 - y0) / (x1 - x0);

                    //Interpolamos para encontrar Alt
                    x0 = listaADSB[indexj_anterior].timetotal;
                    x1 = listaADSB[indexj_posterior].timetotal;
                    x = timeMLAT;

                    y0 = (listaADSB[indexj_anterior].coordGeodesic.Height);
                    y1 = (listaADSB[indexj_posterior].coordGeodesic.Height);

                    if ((x1 - x0) == 0)
                    {
                        newCoordinatesADSB.Height = (y0 + y1) / 2;
                    }
                    newCoordinatesADSB.Height = y0 + (x - x0) * (y1 - y0) / (x1 - x0);

                    // Ahora convertimos las coordenadas geodesicas a system cartesian
                    var coordGeocentric = GeoUtils1.change_geodesic2geocentric(newCoordinatesADSB);
                    var coordSystemCartesian = GeoUtils1.change_geocentric2system_cartesian(coordGeocentric);


                    double X1 = listaMLATmessages[i].coordSystemCartesian.X;
                    double Y1 = listaMLATmessages[i].coordSystemCartesian.Y;

                    double X2 = coordSystemCartesian.X;
                    double Y2 = coordSystemCartesian.Y;

                    double distances = Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1));
                    listadistances.Add(distances);
                    listaDeltaX.Add(X2 - X1);
                    listaDeltaY.Add(Y2 - Y1);

                    //// Ahora añadimos poligonos al mapa.
                    //CoordinatesXYZ coordGeocentric = GeoUtils1.change_system_cartesian2geocentric(newCoordinatesADSB);
                    //CoordinatesWGS84 coordGeodesic = GeoUtils1.change_geocentric2geodesic(coordGeocentric);
                    //List<PointLatLng> polygonpoints = new List<PointLatLng>() { new PointLatLng(coordGeodesic.Lat * GeoUtils.RADS2DEGS, coordGeodesic.Lon * GeoUtils.RADS2DEGS), new PointLatLng(listaMLATmessages[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listaMLATmessages[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS) };

                    //GMapPolygon polygon = new GMapPolygon(polygonpoints, "Polygon")
                    //{
                    //    Stroke = new Pen(Color.Red, 2),
                    //    Fill = new SolidBrush(Color.Red)
                    //};
                    //overlay_lines.Polygons.Add(polygon);

                    //GMarkerGoogle marker1 = new GMarkerGoogle(new PointLatLng(coordGeodesic.Lat * GeoUtils.RADS2DEGS, coordGeodesic.Lon * GeoUtils.RADS2DEGS), green_circle);
                    //GMarkerGoogle marker2 = new GMarkerGoogle(new PointLatLng(listaMLATmessages[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listaMLATmessages[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS), blue_circle);

                    //marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    //TimeSpan timespan1 = TimeSpan.FromSeconds(x);
                    ////marker1.ToolTipText = timespan1.Hours.ToString() + ":" + timespan1.Minutes.ToString() + ":"  + timespan1.Seconds.ToString();
                    //marker1.ToolTipText = timespan1.TotalSeconds.ToString();

                    //marker2.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    //TimeSpan timespan2 = TimeSpan.FromSeconds(listaMLATmessages[i].timetotal);
                    ////marker2.ToolTipText = timespan2.Hours.ToString() + ":" + timespan2.Minutes.ToString() + ":" + timespan2.Seconds.ToString();
                    //marker2.ToolTipText = timespan2.TotalSeconds.ToString();

                    //overlay_MarkersADSB.Markers.Add(marker1);
                    //overlay_MarkersMLAT.Markers.Add(marker2);
                }
            }

            //Mapa.Overlays.Clear();
            Mapa.Overlays.Add(overlay_lines);
            Mapa.Overlays.Add(overlay_MarkersADSB);
            Mapa.Overlays.Add(overlay_MarkersMLAT);

            List<List<double>> results1 = new List<List<double>>() { listadistances, listaDeltaX, listaDeltaY };

            return results1;
        }

        public List<double> CalculatePRobabilityofMLATDetection_CalibrationVehicle(List<CAT10> list, double interval)
        {
            List<CAT10> listaMLATmessages = new List<CAT10>();
            listaMLATmessages.AddRange(list);

            // Filtramos paquetes sin info de posicion
            List<CAT10> list1 = new List<CAT10>();
            for (int i = 0; i < listaMLATmessages.Count(); i++)
            {
                if ((listaMLATmessages[i].PositioninCartesianCoordinates.Length > 0 && listaMLATmessages[i].MeasuredPositioninPolarCoordinates.Length > 0) || (listaMLATmessages[i].PositioninCartesianCoordinates.Length > 0) || (listaMLATmessages[i].MeasuredPositioninPolarCoordinates.Length > 0))
                {
                    list1.Add(listaMLATmessages[i]);
                }
            }
            listaMLATmessages.Clear();
            listaMLATmessages.AddRange(list1);

            // ahora separamos los paquetes por los i ntervalos en los que estan en una zona (para que, una vez salgan de una zona, aunque luego se vuelvan a menter contarlos como 2 trayectorias diferentes)

            List<List<CAT10>> list_of_subzones = new List<List<CAT10>>();
            List<CAT10> list111 = new List<CAT10>();
            for (int i = 0; i< listaMLATmessages.Count()-1; i++)
            {
                if (listaMLATmessages[i + 1].timetotal - listaMLATmessages[i].timetotal < 20)
                {
                    list111.Add(listaMLATmessages[i]);
                }
                else
                {
                    list111.Add(listaMLATmessages[i]);
                    list_of_subzones.Add(list111);
                    list111 = new List<CAT10>();
                }
            }
            if (listaMLATmessages.Count > 0)
            {
                list111.Add(listaMLATmessages.Last());
            }
            list_of_subzones.Add(list111);


            // Vamos lista por lista calculando los paquetes que deberian llegar y los que nos llegan

            double found_messages = 0;
            double expected_messages = 0;

            for (int i = 0; i < list_of_subzones.Count(); i++)
            {
                if(list_of_subzones[i].Count() > 0)
                {
                    List<CAT10> listplanes = list_of_subzones[i];

                    // Buscamos timepo incial y timepo final de la trayectoria

                    double time = listplanes.First().timetotal;
                    double time_final = listplanes.Last().timetotal;

                    // Buscle que vaya creando una ventana de tiempo de x segundos y vaya aumentando el tiempo incial de esa ventana un segundo a cada iteración

                    while (time + interval < time_final)
                    {
                        // Bucle para buscar cuantos paquetes hay en esa ventana de tiempo
                        List<CAT10> listplanesinterval = new List<CAT10>();
                        listplanesinterval.Clear();

                        for (int j = 0; j < listplanes.Count(); j++)
                        {
                            if (listplanes[j].timetotal >= time && listplanes[j].timetotal < time + interval)
                            {
                                listplanesinterval.Add(listplanes[j]);
                            }
                        }

                        // Ahora buscamos cuantos paquetes hay en esa ventana de tiempo
                        int messages = listplanesinterval.Count();

                        if (messages > 0)
                        {
                            found_messages++;
                        }
                        expected_messages++;

                        time++;
                    }
                }
            }

            double probabilityofupdate;
            if (found_messages == 0 && expected_messages == 0)
            {
                probabilityofupdate = 0;
            }
            else
            {
                probabilityofupdate = found_messages / expected_messages;
            }

            List<double> results = new List<double>() { found_messages, expected_messages, probabilityofupdate * 100 };
            return results;
        }

        public double Percentile(List<double> sequence, double excelPercentile)
        {
            sequence.Sort();
            int N = sequence.Count();
            double n = (N - 1) * excelPercentile + 1;
            if(sequence.Count() == 0) { return 0; }
            else
            {
                // Another method: double n = (N + 1) * excelPercentile;
                if (n == 1d) return sequence[0];
                else if (n == N) return sequence[N - 1];
                else
                {
                    int k = (int)n;
                    double d = n - k;
                    return sequence[k - 1] + d * (sequence[k] - sequence[k - 1]);
                }
            }
        }

        private double CalculateStandardDeviation(IEnumerable<double> values)
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

        #endregion

        #region Classes to calculate ED-117 performances from ASTERIX file

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

        #endregion

        #region Filtering Functions

        public void FilterByAirportZones(List<CAT10> listaMLATmessages1)
        {
            listaMLAT_Stand.Clear();
            listaMLAT_Stand_T1.Clear();
            listaMLAT_Stand_T2.Clear();
            listaMLAT_Apron.Clear();
            listaMLAT_Apron_T1.Clear();
            listaMLAT_Apron_T2.Clear();
            listaMLAT_MA.Clear();
            listaMLAT_Ground.Clear();
            listaMLAT_Airborne.Clear();
            listaMLAT_RWY1.Clear();
            listaMLAT_RWY2.Clear();
            listaMLAT_RWY3.Clear();
            listaMLAT_Taxiway.Clear();
            listaMLAT_Airborne_2coma5NM.Clear();
            listaMLAT_Airborne_5NM.Clear();
            listaMLAT_Airborne_2coma5NM_L.Clear();
            listaMLAT_Airborne_2coma5NM_N.Clear();
            listaMLAT_Airborne_2coma5NM_P.Clear();
            listaMLAT_Airborne_2coma5NM_R.Clear();
            listaMLAT_Airborne_2coma5NM_T.Clear();
            listaMLAT_Airborne_2coma5NM_V.Clear();
            listaMLAT_Airborne_5NM_K.Clear();
            listaMLAT_Airborne_5NM_M.Clear();
            listaMLAT_Airborne_5NM_O.Clear();
            listaMLAT_Airborne_5NM_Q.Clear();
            listaMLAT_Airborne_5NM_S.Clear();
            listaMLAT_Airborne_5NM_U.Clear();

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
                    if(i == 61)
                    {

                    }

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

                    if (j > 0)
                    {
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
                            else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                            {
                                listaMLAT_Apron.Add(listplanes[j]);

                                if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                            }

                            // MA
                            else if (insideI)
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
                            else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                            {
                                listaMLAT_Apron.Add(listplanes[j]);

                                if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                            }

                            // MA
                            else if (insideI)
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
                            else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                            {
                                listaMLAT_Apron.Add(listplanes[j]);

                                if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                            }

                            // MA
                            else if (insideI)
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
                    if(insideJ_start && insideJ_end)
                    {
                        for (int j = 0; j < listplanes.Count(); j++)
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
                            else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                            {
                                listaMLAT_Apron.Add(listplanes[j]);

                                if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                            }

                            // MA
                            else if (insideI)
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
                    }

                    else if (insideJ_start == false && insideJ_end == false)
                    {
                        for (int j = 0; j < listplanes.Count(); j++)
                        {
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
            }
        } // Separamos los paquetes MLAT por zonas del Aeropuerto

        public void FilterByAirportZones1(List<CAT10> listaMLATmessages1)
        {
            listaMLAT_Stand.Clear();
            listaMLAT_Stand_T1.Clear();
            listaMLAT_Stand_T2.Clear();
            listaMLAT_Apron.Clear();
            listaMLAT_Apron_T1.Clear();
            listaMLAT_Apron_T2.Clear();
            listaMLAT_MA.Clear();
            listaMLAT_Ground.Clear();
            listaMLAT_Airborne.Clear();
            listaMLAT_RWY1.Clear();
            listaMLAT_RWY2.Clear();
            listaMLAT_RWY3.Clear();
            listaMLAT_Taxiway.Clear();
            listaMLAT_Airborne_2coma5NM.Clear();
            listaMLAT_Airborne_5NM.Clear();
            listaMLAT_Airborne_2coma5NM_L.Clear();
            listaMLAT_Airborne_2coma5NM_N.Clear();
            listaMLAT_Airborne_2coma5NM_P.Clear();
            listaMLAT_Airborne_2coma5NM_R.Clear();
            listaMLAT_Airborne_2coma5NM_T.Clear();
            listaMLAT_Airborne_2coma5NM_V.Clear();
            listaMLAT_Airborne_5NM_K.Clear();
            listaMLAT_Airborne_5NM_M.Clear();
            listaMLAT_Airborne_5NM_O.Clear();
            listaMLAT_Airborne_5NM_Q.Clear();
            listaMLAT_Airborne_5NM_S.Clear();
            listaMLAT_Airborne_5NM_U.Clear();

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

                if(i == 42)
                {

                }


                //Miramos los casos en que el avion sigue una trayectoria de despegue o aterrizaje (o ninguna de las dos)
                bool insideJ_start = polygonJ.IsInside(new PointLatLng(listplanes.First().coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes.First().coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                bool insideJ_end = polygonJ.IsInside(new PointLatLng(listplanes.Last().coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes.Last().coordGeodesic.Lon * GeoUtils.RADS2DEGS));

                // Si el avion sigue una trayectoria de despegue (empieza dentro de zona aeropuerto y acaba fuera)
                if (insideJ_start == true && insideJ_end == false)
                {
                    // Guardamos los vuelos con ground bit = 1 en lista MA
                    int j = 0;
                    int counter = 0;
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

                        if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) + (insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0)
                     + (insideI ? 1 : 0) + (insideW ? 1 : 0) + (insideX ? 1 : 0) + (insideY ? 1 : 0) == 0)
                        {

                        }

                        if(j == 23)
                        {

                        }

                        // STAND
                        if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) > 0)
                        {
                            listaMLAT_Stand.Add(listplanes[j]);
                            counter++;

                            if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) > 0) { listaMLAT_Stand_T1.Add(listplanes[j]); }
                            else { listaMLAT_Stand_T2.Add(listplanes[j]); }
                        }

                        // APRON
                        else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                        {
                            listaMLAT_Apron.Add(listplanes[j]);
                            counter++;

                            if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                            else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                        }

                        // MA
                        else if (insideI)
                        {
                            listaMLAT_MA.Add(listplanes[j]);
                            counter++;

                            if ((insideW ? 1 : 0) + (insideX ? 1 : 0) + (insideY ? 1 : 0) > 0)
                            {
                                if (insideW) { listaMLAT_RWY1.Add(listplanes[j]); }
                                if (insideX) { listaMLAT_RWY2.Add(listplanes[j]); }
                                if (insideY) { listaMLAT_RWY3.Add(listplanes[j]); }
                            }
                            else { listaMLAT_Taxiway.Add(listplanes[j]); }
                        }
                        j++;

                        if (counter != j)
                        {

                        }
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
                            if (j == 421)
                            {

                            }

                            if (counter == 420)
                            {

                            }

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
                                    counter++;

                                    if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) > 0) { listaMLAT_Stand_T1.Add(listplanes[j]); }
                                    else { listaMLAT_Stand_T2.Add(listplanes[j]); }
                                }

                                // APRON
                                else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                                {
                                    listaMLAT_Apron.Add(listplanes[j]);
                                    counter++;

                                    if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                    else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                                }

                                // MA
                                else if (insideI)
                                {
                                    listaMLAT_MA.Add(listplanes[j]);
                                    counter++;

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
                                    counter++;

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
                                    counter++;

                                    if (insideK) { listaMLAT_Airborne_5NM_K.Add(listplanes[j]); }
                                    if (insideM) { listaMLAT_Airborne_5NM_M.Add(listplanes[j]); }
                                    if (insideO) { listaMLAT_Airborne_5NM_O.Add(listplanes[j]); }
                                    if (insideQ) { listaMLAT_Airborne_5NM_Q.Add(listplanes[j]); }
                                    if (insideS) { listaMLAT_Airborne_5NM_S.Add(listplanes[j]); }
                                    if (insideU) { listaMLAT_Airborne_5NM_U.Add(listplanes[j]); }
                                }
                            }
                            j++;

                            if (counter != j)
                            {

                            }
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
                        if (listplanes[j].GBS == "Transponder Ground bit not set.") { index_j = j; }
                    }

                    // Buscamos en que runway estamos
                    bool inside_RWY1_CambioGBS = polygonW.IsInside(new PointLatLng(listplanes[index_j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[index_j].coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                    bool inside_RWY2_CambioGBS = polygonX.IsInside(new PointLatLng(listplanes[index_j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[index_j].coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                    bool inside_RWY3_CambioGBS = polygonY.IsInside(new PointLatLng(listplanes[index_j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[index_j].coordGeodesic.Lon * GeoUtils.RADS2DEGS));

                    // Buscamos si, antes de estar en las pistas que dice estar, ha pasado por una zona aire de esa pista o ha pasado ppor esa pista de casualidad

                    if (inside_RWY1_CambioGBS == true)
                    {
                        bool bool1 = false;
                        for (int j = 0; j < index_j && bool1 == false; j++)
                        {
                            double[] coordenadas = new double[] { listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

                            bool insideT = polygonT.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                            bool insideV = polygonV.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));

                            if (insideT || insideV)
                            {
                                inside_RWY1_CambioGBS = true;
                                bool1 = true;
                            }
                        }
                        if (bool1 == false) { inside_RWY1_CambioGBS = false; }
                    }

                    else if (inside_RWY2_CambioGBS == true)
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

                    else if (inside_RWY3_CambioGBS == true)
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
                        while (j < listplanes.Count() && polygonW.IsInside(new PointLatLng(listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS)) == false)
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

                            if((insideK ? 1 : 0) + (insideL ? 1 : 0) + (insideM ? 1 : 0) + (insideN ? 1 : 0) + (insideO ? 1 : 0) + (insideP ? 1 : 0) + (insideQ ? 1 : 0) + (insideR ? 1 : 0) + (insideS ? 1 : 0) + (insideT ? 1 : 0) + (insideU ? 1 : 0) + (insideV ? 1 : 0) == 0)
                            {
                            }

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

                            if((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) + (insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) + (insideI ? 1 : 0) + (insideW ? 1 : 0) + (insideX ? 1 : 0) + (insideY ? 1 : 0) == 0)
                            {
                            }

                            // STAND
                            if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) > 0)
                            {
                                listaMLAT_Stand.Add(listplanes[j]);

                                if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) > 0) { listaMLAT_Stand_T1.Add(listplanes[j]); }
                                else { listaMLAT_Stand_T2.Add(listplanes[j]); }
                            }

                            // APRON
                            else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                            {
                                listaMLAT_Apron.Add(listplanes[j]);

                                if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                            }

                            // MA
                            else if (insideI)
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
                            else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                            {
                                listaMLAT_Apron.Add(listplanes[j]);

                                if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                            }

                            // MA
                            else if (insideI)
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
                            else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                            {
                                listaMLAT_Apron.Add(listplanes[j]);

                                if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                            }

                            // MA
                            else if (insideI)
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
                    if (insideJ_start && insideJ_end)
                    {
                        for (int j = 0; j < listplanes.Count(); j++)
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
                            else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                            {
                                listaMLAT_Apron.Add(listplanes[j]);

                                if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                            }

                            // MA
                            else if (insideI)
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
                    }

                    else if (insideJ_start == false && insideJ_end == false)
                    {
                        for (int j = 0; j < listplanes.Count(); j++)
                        {
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

                int ground_planes1 = listaMLAT_Stand.Count() + listaMLAT_Apron.Count() + listaMLAT_MA.Count() + listaMLAT_Airborne_2coma5NM.Count() + listaMLAT_Airborne_5NM.Count();
                if(ground_planes1 != listplanes.Count())
                {

                }
            }
        } // Separamos los paquetes MLAT por zonas del Aeropuerto

        public void FilterbyAirportZones_CalibrationVehicle(List<CAT10> list)
        {
            listaMLAT_Stand.Clear();
            listaMLAT_Stand_T1.Clear();
            listaMLAT_Stand_T2.Clear();
            listaMLAT_Apron.Clear();
            listaMLAT_Apron_T1.Clear();
            listaMLAT_Apron_T2.Clear();
            listaMLAT_MA.Clear();
            listaMLAT_Ground.Clear();
            listaMLAT_Airborne.Clear();
            listaMLAT_RWY1.Clear();
            listaMLAT_RWY2.Clear();
            listaMLAT_RWY3.Clear();
            listaMLAT_Taxiway.Clear();
            listaMLAT_Airborne_2coma5NM.Clear();
            listaMLAT_Airborne_5NM.Clear();
            listaMLAT_Airborne_2coma5NM_L.Clear();
            listaMLAT_Airborne_2coma5NM_N.Clear();
            listaMLAT_Airborne_2coma5NM_P.Clear();
            listaMLAT_Airborne_2coma5NM_R.Clear();
            listaMLAT_Airborne_2coma5NM_T.Clear();
            listaMLAT_Airborne_2coma5NM_V.Clear();
            listaMLAT_Airborne_5NM_K.Clear();
            listaMLAT_Airborne_5NM_M.Clear();
            listaMLAT_Airborne_5NM_O.Clear();
            listaMLAT_Airborne_5NM_Q.Clear();
            listaMLAT_Airborne_5NM_S.Clear();
            listaMLAT_Airborne_5NM_U.Clear();

            List<CAT10> listplanes = new List<CAT10>();
            listplanes.AddRange(list);

            // Buscamos si la pimera posición esta volando o en el suelo
            string GBS_on = "Transponder Ground bit set.";
            string GBS_off = "Transponder Ground bit not set.";

            // Si empezamos en el aire 
            if (listplanes.First().GBS == GBS_off)
            {
                // Buscamos en que indice de la lista pasa el ground bit de 0 a 1;
                int index_j = 0;
                for (int j = 0; j < listplanes.Count(); j++)
                {
                    if (listplanes[j].GBS == "Transponder Ground bit not set.") { index_j = j; }
                }

                // Buscamos en que runway estamos
                bool inside_RWY1_CambioGBS = polygonW.IsInside(new PointLatLng(listplanes[index_j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[index_j].coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                bool inside_RWY2_CambioGBS = polygonX.IsInside(new PointLatLng(listplanes[index_j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[index_j].coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                bool inside_RWY3_CambioGBS = polygonY.IsInside(new PointLatLng(listplanes[index_j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[index_j].coordGeodesic.Lon * GeoUtils.RADS2DEGS));

                // Buscamos si, antes de estar en las pistas que dice estar, ha pasado por una zona aire de esa pista o ha pasado ppor esa pista de casualidad

                if (inside_RWY1_CambioGBS == true)
                {
                    bool bool1 = false;
                    for (int j = 0; j < index_j && bool1 == false; j++)
                    {
                        double[] coordenadas = new double[] { listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

                        bool insideT = polygonT.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                        bool insideV = polygonV.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));

                        if (insideT || insideV)
                        {
                            inside_RWY1_CambioGBS = true;
                            bool1 = true;
                        }
                    }
                    if (bool1 == false) { inside_RWY1_CambioGBS = false; }
                }

                else if (inside_RWY2_CambioGBS == true)
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

                else if (inside_RWY3_CambioGBS == true)
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
                    while (j < listplanes.Count() && polygonW.IsInside(new PointLatLng(listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS)) == false)
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

                        if ((insideK ? 1 : 0) + (insideL ? 1 : 0) + (insideM ? 1 : 0) + (insideN ? 1 : 0) + (insideO ? 1 : 0) + (insideP ? 1 : 0) + (insideQ ? 1 : 0) + (insideR ? 1 : 0) + (insideS ? 1 : 0) + (insideT ? 1 : 0) + (insideU ? 1 : 0) + (insideV ? 1 : 0) == 0)
                        {
                        }

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

                        if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) + (insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) + (insideI ? 1 : 0) + (insideW ? 1 : 0) + (insideX ? 1 : 0) + (insideY ? 1 : 0) == 0)
                        {
                        }

                        // STAND
                        if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) > 0)
                        {
                            listaMLAT_Stand.Add(listplanes[j]);

                            if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) > 0) { listaMLAT_Stand_T1.Add(listplanes[j]); }
                            else { listaMLAT_Stand_T2.Add(listplanes[j]); }
                        }

                        // APRON
                        else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                        {
                            listaMLAT_Apron.Add(listplanes[j]);

                            if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                            else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                        }

                        // MA
                        else if (insideI)
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
                        else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                        {
                            listaMLAT_Apron.Add(listplanes[j]);

                            if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                            else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                        }

                        // MA
                        else if (insideI)
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
                        else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                        {
                            listaMLAT_Apron.Add(listplanes[j]);

                            if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                            else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                        }

                        // MA
                        else if (insideI)
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

            // si empezamos en tierra
            if(listplanes.First().GBS == GBS_on)
            {
                // Guardamos los vuelos con ground bit = 1 en lista MA
                int j = 0;
                int counter = 0;
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

                    if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) + (insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0)
                 + (insideI ? 1 : 0) + (insideW ? 1 : 0) + (insideX ? 1 : 0) + (insideY ? 1 : 0) == 0)
                    {

                    }

                    if (j == 23)
                    {

                    }

                    // STAND
                    if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) > 0)
                    {
                        listaMLAT_Stand.Add(listplanes[j]);
                        counter++;

                        if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) > 0) { listaMLAT_Stand_T1.Add(listplanes[j]); }
                        else { listaMLAT_Stand_T2.Add(listplanes[j]); }
                    }

                    // APRON
                    else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                    {
                        listaMLAT_Apron.Add(listplanes[j]);
                        counter++;

                        if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                        else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                    }

                    // MA
                    else if (insideI)
                    {
                        listaMLAT_MA.Add(listplanes[j]);
                        counter++;

                        if ((insideW ? 1 : 0) + (insideX ? 1 : 0) + (insideY ? 1 : 0) > 0)
                        {
                            if (insideW) { listaMLAT_RWY1.Add(listplanes[j]); }
                            if (insideX) { listaMLAT_RWY2.Add(listplanes[j]); }
                            if (insideY) { listaMLAT_RWY3.Add(listplanes[j]); }
                        }
                        else { listaMLAT_Taxiway.Add(listplanes[j]); }
                    }
                    j++;

                    if (counter != j)
                    {

                    }
                }

                // Si no tienen ground  bit = 1 pero siguen encima de la pista de despegue también los consideramos como que estan en tierra

                // Guardamos en que pista estaba la ultima vez que tenia un ground bit = 1
                bool inside_RWY1_CambioGBS = polygonW.IsInside(new PointLatLng(listplanes[j - 1].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j - 1].coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                bool inside_RWY2_CambioGBS = polygonX.IsInside(new PointLatLng(listplanes[j - 1].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j - 1].coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                bool inside_RWY3_CambioGBS = polygonY.IsInside(new PointLatLng(listplanes[j - 1].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j - 1].coordGeodesic.Lon * GeoUtils.RADS2DEGS));

                if (j < listplanes.Count())
                {
                    // Mientras sigamos en la misma pista del ultimo ground bit set = 1 guardamos los paquetes en lista MA
                    bool is_grounded = true;
                    while (j < listplanes.Count() && is_grounded == true)
                    {
                        if (j == 421)
                        {

                        }

                        if (counter == 420)
                        {

                        }

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
                                counter++;

                                if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) > 0) { listaMLAT_Stand_T1.Add(listplanes[j]); }
                                else { listaMLAT_Stand_T2.Add(listplanes[j]); }
                            }

                            // APRON
                            else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                            {
                                listaMLAT_Apron.Add(listplanes[j]);
                                counter++;

                                if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                            }

                            // MA
                            else if (insideI)
                            {
                                listaMLAT_MA.Add(listplanes[j]);
                                counter++;

                                if ((insideW ? 1 : 0) + (insideX ? 1 : 0) + (insideY ? 1 : 0) > 0)
                                {
                                    if (insideW) { listaMLAT_RWY1.Add(listplanes[j]); }
                                    if (insideX) { listaMLAT_RWY2.Add(listplanes[j]); }
                                    if (insideY) { listaMLAT_RWY3.Add(listplanes[j]); }
                                }
                                else { listaMLAT_Taxiway.Add(listplanes[j]); }
                            }
                        }

                        // Si no estan encima de la pista del ultimo GB = 1 es que han acabado la pista y estan en zona aire -> Salimos del codigo de despegue
                        else
                        {
                            is_grounded = false;
                        }
                        j++;
                    }

                    // empezamos con el codigo de aterrizaje

                    while (j < listplanes.Count())
                    {
                        // Buscamos en que indice de la lista pasa el ground bit de 0 a 1;
                        int index_j = 0;
                        for (int k = j; k < listplanes.Count(); k++)
                        {
                            if (listplanes[k].GBS == "Transponder Ground bit not set.") { index_j = k; }
                        }

                        // Buscamos en que runway estamos
                        inside_RWY1_CambioGBS = polygonW.IsInside(new PointLatLng(listplanes[index_j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[index_j].coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                        inside_RWY2_CambioGBS = polygonX.IsInside(new PointLatLng(listplanes[index_j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[index_j].coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                        inside_RWY3_CambioGBS = polygonY.IsInside(new PointLatLng(listplanes[index_j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[index_j].coordGeodesic.Lon * GeoUtils.RADS2DEGS));

                        // Buscamos si, antes de estar en las pistas que dice estar, ha pasado por una zona aire de esa pista o ha pasado ppor esa pista de casualidad

                        if (inside_RWY1_CambioGBS == true)
                        {
                            bool bool1 = false;
                            for (int k = 0; k < index_j && bool1 == false; k++)
                            {
                                double[] coordenadas = new double[] { listplanes[k].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[k].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

                                bool insideT = polygonT.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));
                                bool insideV = polygonV.IsInside(new PointLatLng(coordenadas[0], coordenadas[1]));

                                if (insideT || insideV)
                                {
                                    inside_RWY1_CambioGBS = true;
                                    bool1 = true;
                                }
                            }
                            if (bool1 == false) { inside_RWY1_CambioGBS = false; }
                        }

                        else if (inside_RWY2_CambioGBS == true)
                        {
                            bool bool1 = false;
                            for (int k = 0; k < index_j && bool1 == false; k++)
                            {
                                double[] coordenadas = new double[] { listplanes[k].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[k].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

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

                        else if (inside_RWY3_CambioGBS == true)
                        {
                            bool bool1 = false;
                            for (int k = 0; k < index_j && bool1 == false; k++)
                            {
                                double[] coordenadas = new double[] { listplanes[k].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[k].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

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
                            while (j < listplanes.Count() && polygonW.IsInside(new PointLatLng(listplanes[j].coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes[j].coordGeodesic.Lon * GeoUtils.RADS2DEGS)) == false)
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

                                if ((insideK ? 1 : 0) + (insideL ? 1 : 0) + (insideM ? 1 : 0) + (insideN ? 1 : 0) + (insideO ? 1 : 0) + (insideP ? 1 : 0) + (insideQ ? 1 : 0) + (insideR ? 1 : 0) + (insideS ? 1 : 0) + (insideT ? 1 : 0) + (insideU ? 1 : 0) + (insideV ? 1 : 0) == 0)
                                {
                                }

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

                                if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) + (insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) + (insideI ? 1 : 0) + (insideW ? 1 : 0) + (insideX ? 1 : 0) + (insideY ? 1 : 0) == 0)
                                {
                                }

                                // STAND
                                if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) + (insideD ? 1 : 0) + (insideE ? 1 : 0) > 0)
                                {
                                    listaMLAT_Stand.Add(listplanes[j]);

                                    if ((insideA ? 1 : 0) + (insideB ? 1 : 0) + (insideC ? 1 : 0) > 0) { listaMLAT_Stand_T1.Add(listplanes[j]); }
                                    else { listaMLAT_Stand_T2.Add(listplanes[j]); }
                                }

                                // APRON
                                else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                                {
                                    listaMLAT_Apron.Add(listplanes[j]);

                                    if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                    else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                                }

                                // MA
                                else if (insideI)
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
                                else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                                {
                                    listaMLAT_Apron.Add(listplanes[j]);

                                    if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                    else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                                }

                                // MA
                                else if (insideI)
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
                                else if ((insideF ? 1 : 0) + (insideG ? 1 : 0) + (insideH ? 1 : 0) > 0)
                                {
                                    listaMLAT_Apron.Add(listplanes[j]);

                                    if (insideH) { listaMLAT_Apron_T1.Add(listplanes[j]); }
                                    else { listaMLAT_Apron_T2.Add(listplanes[j]); }
                                }

                                // MA
                                else if (insideI)
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
                }
            }

        } // Separamos los paquetes MLAT por zonas del Aeropuerto para vehiculo de calibracion

        public void FilterMLATmessages(List<CAT10> listaMLATmessages)
        {
            List<CAT10> list = new List<CAT10>();
            for (int i = 0; i < listaMLATmessages.Count(); i++)
            {
                if (listaMLATmessages[i].TOT == "Aircraft." || listaMLATmessages[i].TOT == "Undetermined") { list.Add(listaMLATmessages[i]); }
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

            List<CAT21> list2 = new List<CAT21>();
            for(int i = 0; i< listaCAT21messages.Count(); i++)
            {
                if (listaCAT21messages[i].VN == "ED102A/DO-260B [Ref. 11].")
                {
                    list2.Add(listaCAT21messages[i]);
                }
            }

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

        public List<CAT10> FilterMLATifCalibrationVehiclePresent(List<CAT10> list)
        {
            List<CAT10> result = new List<CAT10>();

            List<CAT10> listaVehicluloCalibracionTerrestre = new List<CAT10>();
            for (int i = 0; i < list.Count(); i++) { if (list[i].TargetIdentification_decoded == "MLAT01") { listaVehicluloCalibracionTerrestre.Add(list[i]); } }

            List<CAT10> listaVehicluloCalibracionAereo = new List<CAT10>();
            for (int i = 0; i < list.Count(); i++) { if (list[i].TargetIdentification_decoded == "ECKJQ") { listaVehicluloCalibracionAereo.Add(list[i]); } }

            if (listaVehicluloCalibracionTerrestre.Count > 0) { result.Clear(); result.AddRange(listaVehicluloCalibracionTerrestre); }
            else { result.Clear(); result.AddRange(listaVehicluloCalibracionAereo); }

            return result;
        } // Devuelve lista con los paquetes MLAT del vehiculo / aeronave de calibración

        public void SelectAllplanesinsideAirpotZone(List<CAT10> list)
        {
            List<CAT10> list1 = new List<CAT10>();

            for (int i = 0; i < list.Count(); i++)
            {
                double[] coordenadas = new double[] { list[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, list[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS };

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
                     + (insideI ? 1 : 0) /*+ (insideJ ? 1 : 0)*/ + (insideK ? 1 : 0) + (insideL ? 1 : 0) + (insideM ? 1 : 0) + (insideN ? 1 : 0) + (insideO ? 1 : 0) + (insideP ? 1 : 0)
                      + (insideQ ? 1 : 0) + (insideR ? 1 : 0) + (insideS ? 1 : 0) + (insideT ? 1 : 0) + (insideU ? 1 : 0) + (insideV ? 1 : 0) + (insideW ? 1 : 0) + (insideX ? 1 : 0)
                       + (insideY ? 1 : 0) > 0) { list1.Add(list[i]); }
            }

            list.Clear();
            list.AddRange(list1);
        } // Seleccionamos todos los vuelos dentro de alguna de las zonas del aeropuerto y eliminamos el resto

        #endregion

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

        #region Basura

        #endregion

    }
}
