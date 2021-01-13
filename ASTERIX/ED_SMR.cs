using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBRERIACLASES;

using DotNetMatrix;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Runtime;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using MultiCAT6.Utils;
using System.Windows.Media;
using ColorConverter = System.Windows.Media.ColorConverter;
using Color = System.Windows.Media.Color;
using Accord.Math;
using Pen = System.Windows.Media.Pen;

namespace ASTERIX
{
    public partial class ED_SMR : Form
    {


        public class Trafico
        {
            public CAT10 traficoSMR;
            public CAT10 traficoMLAT;
            public CAT21 traficoCAT21;
            public double distance;
            public string TargetAddress;

            public Trafico(CAT10 SMR, CAT10 MLAT)
            {
                this.traficoSMR = SMR;
                this.traficoMLAT = MLAT;
            }

            public Trafico(CAT10 SMR, CAT21 CAT21)
            {
                this.traficoSMR = SMR;
                this.traficoCAT21 = CAT21;
            }
        }

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

        // Heading Pistas
        double heading07R;
        double heading25L;
        double heading07L;
        double heading25R;
        double heading02;
        double heading20;

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

        public static List<string> listColors = new List<string>() { "#3F51B5", "#009688", "#FF5722", "#607D8B", "#FF9800", "#9C27B0", "#2196F3", "#EA676C", "#E41A4A", "#5978BB", "#018790", "#0E3441", "#00B0AD", "#721D47", "#EA4833", "#EF937E", "#F37521", "#A12059", "#126881", "#8BC240", "#364D5B", "#C7DC5B", "#0094BC", "#E4126B", "#43B76E", "#7BCFE9", "B71C46" };

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

        // Centro de coordenadas SMR
        double LatSMR = 41 + (17.0 / 60.0) + (44.226 / 3600);
        double LonSMR = 02 + (05.0 / 60.0) + (42.411 / 3600);

        // Centro de coordenadas MLAT
        double LatMLAT = 41 + (17.0 / 60.0) + (49.426 / 3600);
        double LonMLAT = 02 + (04.0 / 60.0) + (42.410 / 3600);

        // Coordenadas ARP
        double LatARP = 41 + (17.0 / 60.0) + (49.426 / 3600);
        double LonARP = 02 + (04.0 / 60.0) + (42.410 / 3600);

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

        List<CAT10> listaCAT10 = new List<CAT10>();
        List<CAT10> listaSMR = new List<CAT10>();
        List<CAT10> listaMLAT = new List<CAT10>();
        List<CAT21> listaCAT21 = new List<CAT21>();
        List<MLATCalibrationData> listaCalibrationDataVehicle = new List<MLATCalibrationData>();

        string GBS_CAT21 = "Ground Bit set.";
        string GBNS_CAT21 = "Ground Bit not set.";

        string GBS_CAT10 = "Transponder Ground bit set.";
        string GBNS_CAT10 = "Transponder Ground bit not set.";

        List<Trayectoria> lista_Trayectorias1 = new List<Trayectoria>();

        public ED_SMR(List<CAT10> listaCAT10, List<CAT21> listaCAT21, List<MLATCalibrationData> listaCalibrationDataVehicle)
        {
            InitializeComponent();

            this.listaCAT10 = listaCAT10;
            this.listaCAT21 = listaCAT21;
            this.listaCalibrationDataVehicle = listaCalibrationDataVehicle;

            CalculateARP_MLAT_SMR_coordinates();

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

            //polygonsOverlay.Clear();
            int opacity = 128;

            polygonJ = new GMapPolygon(polygonJpoints, "PolygonJ")
            {
                //Stroke = new Pen(Color.Red, 2),
                //Fill = new SolidBrush(Color.Red)
            };
            //polygonsOverlay.Polygons.Add(polygonJ);

            polygonA = new GMapPolygon(polygonApoints, "PolygonA")
            {
                //Stroke = new Pen(Color.Magenta, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 255, 0, 255))
            };
            //polygonsOverlay.Polygons.Add(polygonA);

            polygonB = new GMapPolygon(polygonBpoints, "PolygonB")
            {
                //Stroke = new Pen(Color.Magenta, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 255, 0, 255))
            };
            //polygonsOverlay.Polygons.Add(polygonB);

            polygonC = new GMapPolygon(polygonCpoints, "PolygonC")
            {
                //Stroke = new Pen(Color.Magenta, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 255, 0, 255))
            };
            //polygonsOverlay.Polygons.Add(polygonC);

            polygonD = new GMapPolygon(polygonDpoints, "PolygonD")
            {
                //Stroke = new Pen(Color.Magenta, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 255, 0, 255))
            };
            //polygonsOverlay.Polygons.Add(polygonD);

            polygonE = new GMapPolygon(polygonEpoints, "PolygonE")
            {
                //Stroke = new Pen(Color.Magenta, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 255, 0, 255))
            };
            //polygonsOverlay.Polygons.Add(polygonE);

            polygonF = new GMapPolygon(polygonFpoints, "PolygonF")
            {
                //Stroke = new Pen(Color.Yellow, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 255, 255, 102))
            };
            //polygonsOverlay.Polygons.Add(polygonF);

            polygonG = new GMapPolygon(polygonGpoints, "PolygonG")
            {
                //Stroke = new Pen(Color.Yellow, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 255, 255, 102))
            };
            //polygonsOverlay.Polygons.Add(polygonG);

            polygonH = new GMapPolygon(polygonHpoints, "PolygonH")
            {
                //Stroke = new Pen(Color.Yellow, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 255, 255, 102))
            };
            //polygonsOverlay.Polygons.Add(polygonH);

            polygonI = new GMapPolygon(polygonIpoints, "PolygonI")
            {
                //Stroke = new Pen(Color.Green, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 11, 102, 35))
            };
            //polygonsOverlay.Polygons.Add(polygonI);

            polygonK = new GMapPolygon(polygonKpoints, "PolygonK")
            {
                //Stroke = new Pen(Color.Blue, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 0, 0, 255))
            };
            //polygonsOverlay.Polygons.Add(polygonK);

            polygonL = new GMapPolygon(polygonLpoints, "PolygonL")
            {
                //Stroke = new Pen(Color.LightBlue, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 0, 204, 204))
            };
            //polygonsOverlay.Polygons.Add(polygonL);

            polygonM = new GMapPolygon(polygonMpoints, "PolygonM")
            {
                //Stroke = new Pen(Color.Blue, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 0, 0, 255))
            };
            //polygonsOverlay.Polygons.Add(polygonM);

            polygonN = new GMapPolygon(polygonNpoints, "PolygonN")
            {
                //Stroke = new Pen(Color.LightBlue, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 0, 204, 204))
            };
            //polygonsOverlay.Polygons.Add(polygonN);

            polygonO = new GMapPolygon(polygonOpoints, "PolygonO")
            {
                //Stroke = new Pen(Color.Blue, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 0, 0, 255))
            };
            //polygonsOverlay.Polygons.Add(polygonO);

            polygonP = new GMapPolygon(polygonPpoints, "PolygonP")
            {
                //Stroke = new Pen(Color.LightBlue, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 0, 204, 204))
            };
            //polygonsOverlay.Polygons.Add(polygonP);

            polygonQ = new GMapPolygon(polygonQpoints, "PolygonQ")
            {
                //Stroke = new Pen(Color.Blue, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 0, 0, 255))
            };
            //polygonsOverlay.Polygons.Add(polygonQ);

            polygonR = new GMapPolygon(polygonRpoints, "PolygonR")
            {
                //Stroke = new Pen(Color.LightBlue, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 0, 204, 204))
            };
            //polygonsOverlay.Polygons.Add(polygonR);

            polygonS = new GMapPolygon(polygonSpoints, "PolygonS")
            {
                //Stroke = new Pen(Color.Blue, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 0, 0, 255))
            };
            //polygonsOverlay.Polygons.Add(polygonS);

            polygonT = new GMapPolygon(polygonTpoints, "PolygonT")
            {
                //Stroke = new Pen(Color.LightBlue, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 0, 204, 204))
            };
            //polygonsOverlay.Polygons.Add(polygonT);

            polygonU = new GMapPolygon(polygonUpoints, "PolygonU")
            {
                //Stroke = new Pen(Color.Blue, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 0, 0, 255))
            };
            //polygonsOverlay.Polygons.Add(polygonU);

            polygonV = new GMapPolygon(polygonVpoints, "PolygonV")
            {
                //Stroke = new Pen(Color.LightBlue, 2),
                //Fill = new SolidBrush(Color.FromArgb(opacity, 0, 204, 204))
            };
            //polygonsOverlay.Polygons.Add(polygonV);

            polygonW = new GMapPolygon(polygonWpoints, "PolygonW")
            {
                //Stroke = new Pen(Color.White, 2),
                //Fill = new SolidBrush(Color.White)
            };
            //polygonsOverlay.Polygons.Add(polygonW);

            polygonX = new GMapPolygon(polygonXpoints, "PolygonX")
            {
                //Stroke = new Pen(Color.White, 2),
                //Fill = new SolidBrush(Color.White)
            };
            //polygonsOverlay.Polygons.Add(polygonX);

            polygonY = new GMapPolygon(polygonYpoints, "PolygonY")
            {
                //Stroke = new Pen(Color.White, 2),
                //Fill = new SolidBrush(Color.White)
            };
            //polygonsOverlay.Polygons.Add(polygonY);

            //Mapa.Overlays.Add(polygonsOverlay);

            #endregion //  Class variables
        }

        private void ED_SMR_Load(object sender, EventArgs e)
        {

            // Separamos smr y MLAT
            List<CAT10> list1 = new List<CAT10>();
            List<CAT10> list2 = new List<CAT10>();

            for (int i = 0; i < listaCAT10.Count(); i++)
            {
                if (listaCAT10[i].SAC == 0 && listaCAT10[i].SIC == 7) { list1.Add(listaCAT10[i]); }
                if (listaCAT10[i].SAC == 0 && listaCAT10[i].SIC == 107) { list2.Add(listaCAT10[i]); }
            }

            listaSMR.Clear();
            listaMLAT.Clear();
            listaSMR = list1.OrderBy(o => o.timetotal).ToList();
            listaMLAT = list2.OrderBy(o => o.timetotal).ToList();
            listaCAT21 = listaCAT21.OrderBy(o => o.TimeofASTERIXReportTransmission_seconds).ToList();

            // Eliminamos paquetesc de periodic updates est
            FilterCAT10(listaSMR);
            FilterCAT10(listaMLAT);

            List<double> listaTrackNumbers = new List<double>();
            for (int i = 0; i < listaSMR.Count(); i++)
            {
                if (listaTrackNumbers.Contains(listaSMR[i].Tracknumber_value))
                {

                }
                else
                {
                    listaTrackNumbers.Add(listaSMR[i].Tracknumber_value);
                }
            }

            // Calculamos las tryectorias

            //List<List<CAT10>> listaTrayectorias = CalculateTrajectories(listaSMR); // Funcion que calcula las trayectorias a partir de track number y distancia (poco restrictiva)
            //List<List<CAT10>> listaTrayectorias1 = CalculateTrajectories1(listaSMR); // Funcion que calcula las trayectorias a partir de kalman filter
            //List<Trafico> listaTraficos = CalculateTrajectories2(listaSMR, listaMLAT, listaCAT21); // Funcion que calcula el tráfico MLAT, CAT21 equivalente de cada trafico SMR a paritr de la distancia y tiempo
            CalculateTrajectories3(listaSMR, listaMLAT, listaCAT21); // Funcion que calcula tracking de SMR a partir de las trayectorias 

            //// Creamos Mapa

            Mapa.DragButton = MouseButtons.Left;
            Mapa.CanDragMap = true;
            Mapa.MapProvider = GMapProviders.OpenCycleLandscapeMap;
            Mapa.Position = new PointLatLng(41, 2);
            Mapa.MinZoom = 1;
            Mapa.MaxZoom = 30;
            Mapa.Zoom = 8;
            Mapa.AutoScroll = true;

            //// Pintamos los trayectos por Track Number
            //GMapOverlay polygonsoverlay = new GMapOverlay();
            //int j = 0;

            //foreach (List<CAT10> list in hola)
            //{
            //    for (int i = 0; i < list.Count() - 1; i++)
            //    {
            //        SolidColorBrush color;
            //        System.Windows.Media.Color color1;
            //        try
            //        {
            //            color = new SolidColorBrush((Color)ColorConverter.ConvertFromString(listColors[j]));
            //            color1 = Color.FromArgb(color.Color.A, color.Color.R, color.Color.G, color.Color.B);
            //        }
            //        catch
            //        {
            //            color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff0000"));
            //            color1 = Color.FromArgb(color.Color.A, color.Color.R, color.Color.G, color.Color.B);
            //        }

            //        PointLatLng marker1 = new PointLatLng(list[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, list[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS);
            //        PointLatLng marker2 = new PointLatLng(list[i + 1].coordGeodesic.Lat * GeoUtils.RADS2DEGS, list[i + 1].coordGeodesic.Lon * GeoUtils.RADS2DEGS);

            //        List<PointLatLng> listpoints = new List<PointLatLng>() { marker1, marker2 };
            //        GMapPolygon polygon = new GMapPolygon(listpoints, "")
            //        {
            //            Stroke = new System.Drawing.Pen(System.Drawing.Color.FromArgb(color1.A, color1.R, color1.G, color1.B))
            //        };
            //        polygonsoverlay.Polygons.Add(polygon);
            //    }
            //    j++;

            //    if (j == listColors.Count()) { j = 0; }
            //}

            //Mapa.Overlays.Add(polygonsoverlay);

        }

        #region Functions to calculate Performances from ASTERIX file

        public void CalculatreProbabilityofUpdate(List<List<CAT10>> lista)
        {
            double counter_bueno = 0;
            double counter_total = 0;

            foreach (List<CAT10> trayectoria in lista)
            {
                for (int i = 0; i < trayectoria.Count() - 1; i++)
                {
                    double timedelay = trayectoria[i + 1].timetotal - trayectoria[i].timetotal;
                    if (timedelay <= 1.2) { counter_bueno++; }
                    counter_total ++;
                }
            }

            double probability;
            if (counter_total == 0) { probability = 0; }
            else { probability = (counter_bueno / counter_total) * 100; }
        }

        public void CalculateProbabilityofMLATDetection(List<List<CAT10>> lista)
        {
            for(int i = 0; i<lista.Count(); i++)
            {
                // Eliminamos los paquetes sin info de posición

                List<CAT10> list1 = lista[i];
                foreach(CAT10 packet in list1)
                {
                    if((packet.PositioninCartesianCoordinates.Length>0? 1 : 0) + (packet.MeasuredPositioninPolarCoordinates.Length>0? 1 : 0) > 0)
                    {
                        list1.Add(packet);
                    }


                }
            }
        }

        public void CalculatePositionAccuracy_ED116_ASTERIXfile(List<List<CAT10>> lista_de_listas, List<CAT10> listaMLAT1)
        {
            List<CAT10> listaLATMessages = new List<CAT10>();
            listaLATMessages.AddRange(listaMLAT1);

            List<List<CAT10>> list_of_list_SMR = new List<List<CAT10>>();
            list_of_list_SMR.AddRange(lista_de_listas);

            List<double> listaTrackNumbers = new List<double>();
            for (int i = 0; i < listaLATMessages.Count(); i++)
            {
                if (listaTrackNumbers.Contains(listaLATMessages[i].Tracknumber_value))
                {

                }
                else
                {
                    listaTrackNumbers.Add(listaLATMessages[i].Tracknumber_value);
                }
            }

            List<List<CAT10>> list_of_list_MLAT = new List<List<CAT10>>();
            foreach (double tracknumber in listaTrackNumbers)
            {
                List<CAT10> lista = new List<CAT10>();
                for(int i = 0; i< listaLATMessages.Count(); i++)
                {
                    if(listaLATMessages[i].Tracknumber_value == tracknumber)
                    {
                        lista.Add(listaLATMessages[i]);
                    }
                }
                list_of_list_MLAT.Add(lista);
            }

            // una vez orghanizados los datos procedemos a relacionarlos

             
        } // en froceso

        #endregion

        #region Buttons to calculate Performances from ASTERIX file
        private void pb_ProbabilityofUpdate_ED116_ASTERIXfile_Click(object sender, EventArgs e)
        {
            var trayectorias = CalculateTrajectories(listaSMR);
            CalculatreProbabilityofUpdate(trayectorias);
        }

        #endregion

        public List<List<CAT10>> CalculateTrajectories(List<CAT10> lista1SMRMessages)
        {
            List<Trayectoria> listTrajectories = new List<Trayectoria>();
            listTrajectories.Clear();

            List<CAT10> listaSMRMessages = new List<CAT10>();
            listaSMRMessages.AddRange(lista1SMRMessages);

            // Ahora eliminamos traficos SMR sin info de posición
            List<CAT10> list = new List<CAT10>();
            for(int i = 0; i<listaSMRMessages.Count(); i++)
            {
                if (listaSMRMessages[i].MeasuredPositioninPolarCoordinates.Length > 0)
                {
                    list.Add(listaSMRMessages[i]);
                }
            }
            listaSMRMessages.Clear();
            listaSMRMessages.AddRange(list);


            // Primero buscamos el primer y ultimo segundo de la simulacion
            double firstsecond = Math.Floor(listaSMRMessages.First().timetotal);
            double lastsecond = Math.Floor(listaSMRMessages.Last().timetotal);
            double second = firstsecond;
            int index = 0;
            int index_id = 0;

            // Establecemos condiciones iniciales (pimera iteración)

            // Primero hay que hacer que el algoritmo seleccione los vuelos en ese segundo
            List<CAT10> listplanesthissecond = new List<CAT10>();
            double time = Math.Floor(listaSMRMessages[index].timetotal);
            while (index < listaSMRMessages.Count() && time == second)
            {
                time = Math.Floor(listaSMRMessages[index].timetotal);
                listplanesthissecond.Add(listaSMRMessages[index]);
                index++;
            }

            // una vez calculados los paquetes en ese segundo creamos una trayectoria para cada uno
            for(int i = 0; i<listplanesthissecond.Count(); i++)
            {
                Trayectoria trayectoria = new Trayectoria(index_id, listplanesthissecond[i]);
                listTrajectories.Add(trayectoria);
                index_id++;
            }

            // Pasamos al siguiente segundo;
            second++;

            // Empezamos el algorizmo

            while (second < lastsecond)
            {
                // Primero hay que hacer que el algoritmo seleccione los vuelos en ese segundo de la manera más eficiente posible
                listplanesthissecond = new List<CAT10>();
                time = Math.Floor(listaSMRMessages[index].timetotal);
                while (index < listaSMRMessages.Count() && time == second)
                {
                    time = Math.Floor(listaSMRMessages[index].timetotal);
                    listplanesthissecond.Add(listaSMRMessages[index]);
                    index++;
                }

                // Ahora que sabemos contar los paquetes que hay en cada segundo podemos pasar a programar el algoritmo

                // ----------------------------------------------------------------------------------------------------------------------------------------------------------

                // Vamos trayectoria por trayectoria asignandole una nueva posición

                // primero marcamos las trayectoriaas como no actualizadas
                foreach (Trayectoria trajectory in listTrajectories)
                {
                    trajectory.updated = false;
                }

                foreach (Trayectoria trajectory in listTrajectories)
                {
                    if(trajectory.ended == false)
                    {
                        // Buscamos si hay algún paquete con el mismo track number
                        if(listplanesthissecond.Count() > 0)
                        {
                            for (int i = 0; i < listplanesthissecond.Count(); i++)
                            {
                                if (listplanesthissecond[i].Tracknumber_value == trajectory.listaSMR.Last().Tracknumber_value)
                                {
                                    trajectory.listaSMR.Add(listplanesthissecond[i]); // Añadimos el nuevo paquee a la lista
                                    listplanesthissecond.Remove(listplanesthissecond[i]); // Eliminamos el paquete de la lista
                                    trajectory.updated = true; // Marcamos esta lista como actualizada
                                }
                            }
                        }

                        // Si no hemos actualizado el paquete en la ronda anterior pasamos a calcular la siguiente posición con el algoritmo de tracking
                        if(listplanesthissecond.Count() > 0 && trajectory.updated == false)
                        {
                            // calculamos la distancia del ultimo punto de esta trayectoria con los paquetes de listplanesthissecond que hayan sobrado
                            List<double> listadistancias = new List<double>();

                            double U1 = trajectory.listaSMR.Last().coordStereographic.U;
                            double V1 = trajectory.listaSMR.Last().coordStereographic.V;

                            foreach(CAT10 paquete in listplanesthissecond)
                            {
                                double U2 = paquete.coordStereographic.U;
                                double v2 = paquete.coordStereographic.V;
                                listadistancias.Add(Math.Sqrt(Math.Pow(U2 - U1, 2) + Math.Pow(v2 - V1, 2)));
                            }

                            // aplicamos restriccion de distancia antes de añadir
                            if(listadistancias.Min() < 50)
                            {
                                int j = listadistancias.IndexOf(listadistancias.Min());
                                trajectory.listaSMR.Add(listplanesthissecond[j]);
                                listplanesthissecond.Remove(listplanesthissecond[j]);
                                trajectory.updated = true;
                            }
                            else
                            {
                                // Calculamos si hay que acabar esta trayectoria
                                trajectory.time_since_last_update++;
                                if(trajectory.time_since_last_update == 60) { trajectory.ended = true; }
                            }
                        }
                    }
                }

                // si al acabr la iteración todavia hay paquetes en listplanesthissecond que no tienen trayectoria hay que crear una trayectoria nueva para cada paquete (falta hacerlo)
                if (listplanesthissecond.Count() > 0)
                {
                    foreach(CAT10 paquete in listplanesthissecond)
                    {
                        Trayectoria trayectoria = new Trayectoria(index_id, paquete);
                        listTrajectories.Add(trayectoria);
                        index_id++;
                    }
                }

                // Al acabar, bajamos el contador de iteracíones sin actualizar de todas las trayectorias actualizadas a 0, para que el contador solo cuente le numero de iteraciones sin actualizar CONSECUTIVAS
                foreach (Trayectoria trayectoria in listTrajectories) 
                { 
                    if(trayectoria.updated == true)
                    {
                        trayectoria.time_since_last_update = 0;
                    } 
                }

                // Al acabar la iteración hay que setear todas las trayectorias a updtade = false; 

                foreach (Trayectoria trayectoria in listTrajectories) { trayectoria.updated = false; }

                // ----------------------------------------------------------------------------------------------------------------------------------------------------------

                second++;
            }

            // Pasamos las trayectorias a una lista de listas
            List<List<CAT10>> list_of_lists = new List<List<CAT10>>();
            foreach(Trayectoria trayectoria in listTrajectories)
            {
                list_of_lists.Add(trayectoria.listaSMR);
            }

            return list_of_lists;
        }

        public List<List<CAT10>> CalculateTrajectories1(List<CAT10> lista1SMRMessages)
        {
            List<Trayectoria> listTrajectories = new List<Trayectoria>();
            listTrajectories.Clear();

            List<CAT10> listaSMRMessages = new List<CAT10>();
            listaSMRMessages.AddRange(lista1SMRMessages);

            // Ahora eliminamos traficos SMR sin info de posición
            List<CAT10> list = new List<CAT10>();
            for (int i = 0; i < listaSMRMessages.Count(); i++)
            {
                if (listaSMRMessages[i].MeasuredPositioninPolarCoordinates.Length > 0)
                {
                    list.Add(listaSMRMessages[i]);
                }
            }
            listaSMRMessages.Clear();
            listaSMRMessages.AddRange(list);


            // Primero buscamos el primer y ultimo segundo de la simulacion
            double firstsecond = Math.Floor(listaSMRMessages.First().timetotal);
            double lastsecond = Math.Floor(listaSMRMessages.Last().timetotal);
            double second = firstsecond;
            int index = 0;
            int index_id = 0;

            // Establecemos condiciones iniciales (pimera iteración)

            // Primero hay que hacer que el algoritmo seleccione los vuelos en ese segundo
            List<CAT10> listplanesthissecond = new List<CAT10>();
            double time = Math.Floor(listaSMRMessages[index].timetotal);
            while (index < listaSMRMessages.Count() && time == second)
            {
                time = Math.Floor(listaSMRMessages[index].timetotal);
                listplanesthissecond.Add(listaSMRMessages[index]);
                index++;
            }

            // una vez calculados los paquetes en ese segundo creamos una trayectoria para cada uno
            for (int i = 0; i < listplanesthissecond.Count(); i++)
            {
                Trayectoria trayectoria = new Trayectoria(index_id, listplanesthissecond[i]);
                trayectoria.coordGeodesic_SMR = listplanesthissecond[i].coordGeodesic;
                trayectoria.coordStereographic_SMR = listplanesthissecond[i].coordStereographic;
                trayectoria.coordSystemCartesian_SMR = listplanesthissecond[i].coordSystemCartesian;

                listTrajectories.Add(trayectoria);

                Predict(trayectoria);

                index_id++;
            }

            // Pasamos al siguiente segundo;
            second++;

            // Empezamos el algorizmo

            while (second < lastsecond)
            {
                // Primero hay que hacer que el algoritmo seleccione los vuelos en ese segundo de la manera más eficiente posible
                listplanesthissecond = new List<CAT10>();
                time = Math.Floor(listaSMRMessages[index].timetotal);
                while (index < listaSMRMessages.Count() && time == second)
                {
                    time = Math.Floor(listaSMRMessages[index].timetotal);
                    listplanesthissecond.Add(listaSMRMessages[index]);
                    index++;
                }

                // Ahora que sabemos contar los paquetes que hay en cada segundo podemos pasar a programar el algoritmo
                // ----------------------------------------------------------------------------------------------------------------------------------------------------------

                // Vamos trayectoria por trayectoria asignandole una nueva posición

                // primero marcamos las trayectoriaas como no actualizadas
                foreach (Trayectoria trajectory in listTrajectories)
                {
                    trajectory.updated = false;
                }

                foreach (Trayectoria trajectory in listTrajectories)
                {
                    if (trajectory.ended == false)
                    {
                        // Buscamos si hay algún paquete con el mismo track number
                        if (listplanesthissecond.Count() > 0)
                        {
                            for (int i = 0; i < listplanesthissecond.Count(); i++)
                            {
                                if (listplanesthissecond[i].Tracknumber_value == trajectory.listaSMR.Last().Tracknumber_value)
                                {
                                    trajectory.listaSMR.Add(listplanesthissecond[i]); // Añadimos el nuevo paquee a la lista
                                    listplanesthissecond.Remove(listplanesthissecond[i]); // Eliminamos el paquete de la lista

                                    Update(trajectory);
                                    trajectory.updated = true; // Marcamos esta lista como actualizada
                                }
                            }
                        }

                        // Si no hemos actualizado el paquete en la ronda anterior pasamos a calcular la siguiente posición con el algoritmo de tracking
                        if (listplanesthissecond.Count() > 0 && trajectory.updated == false)
                        {
                            // calculamos la distancia del ultimo punto de esta trayectoria con los paquetes de listplanesthissecond que hayan sobrado
                            List<double> listadistancias = new List<double>();

                            //double U1 = trajectory.listaSMR.Last().coordStereographic.U;
                            //double V1 = trajectory.listaSMR.Last().coordStereographic.V;

                            double U1 = trajectory.coordStereographic_SMR.U;
                            double V1 = trajectory.coordStereographic_SMR.V;

                            foreach (CAT10 paquete in listplanesthissecond)
                            {
                                double U2 = paquete.coordStereographic.U;
                                double v2 = paquete.coordStereographic.V;
                                listadistancias.Add(Math.Sqrt(Math.Pow(U2 - U1, 2) + Math.Pow(v2 - V1, 2)));
                            }

                            // aplicamos restriccion de distancia antes de añadir
                            if (listadistancias.Min() < 50)
                            {
                                int j = listadistancias.IndexOf(listadistancias.Min());
                                trajectory.listaSMR.Add(listplanesthissecond[j]);

                                Update(trajectory);

                                listplanesthissecond.Remove(listplanesthissecond[j]);
                                trajectory.updated = true;
                            }
                            else
                            {
                                // Calculamos si hay que acabar esta trayectoria
                                trajectory.time_since_last_update++;
                                if (trajectory.time_since_last_update == 60) { trajectory.ended = true; }
                            }
                        }
                    }
                }

                // si al acabr la iteración todavia hay paquetes en listplanesthissecond que no tienen trayectoria hay que crear una trayectoria nueva para cada paquete (falta hacerlo)
                if (listplanesthissecond.Count() > 0)
                {
                    foreach (CAT10 paquete in listplanesthissecond)
                    {
                        Trayectoria trayectoria = new Trayectoria(index_id, paquete);
                        Update(trayectoria);
                        listTrajectories.Add(trayectoria);
                        index_id++;
                    }
                }

                // Al acabar, bajamos el contador de iteracíones sin actualizar de todas las trayectorias actualizadas a 0, para que el contador solo cuente le numero de iteraciones sin actualizar CONSECUTIVAS
                foreach (Trayectoria trayectoria in listTrajectories)
                {
                    if (trayectoria.updated == true)
                    {
                        trayectoria.time_since_last_update = 0;
                    }
                }

                // Al acabar la iteración hay que setear todas las trayectorias a updtade = false; 

                foreach (Trayectoria trayectoria in listTrajectories) { trayectoria.updated = false; }


                // ----------------------------------------------------------------------------------------------------------------------------------------------------------

                second++;
            }

            // Pasamos las trayectorias a una lista de listas
            List<List<CAT10>> list_of_lists = new List<List<CAT10>>();
            foreach (Trayectoria trayectoria in listTrajectories)
            {
                list_of_lists.Add(trayectoria.listaSMR);
            }

            return list_of_lists;
        }

        public List<Trafico> CalculateTrajectories2(List<CAT10> lista1SMRMessages, List<CAT10> lista1MLATMessages, List<CAT21> lista1CAT21Messages)
        {
            List<Trafico> listaTraficos = new List<Trafico>();

            List<Trayectoria> listTrajectories = new List<Trayectoria>();
            listTrajectories.Clear();

            List<CAT10> listaSMRMessages = new List<CAT10>();
            listaSMRMessages.AddRange(lista1SMRMessages);

            List<CAT10> listaMLATMessages = new List<CAT10>();
            listaMLATMessages.AddRange(lista1MLATMessages);

            List<CAT21> listaCAT21Messages = new List<CAT21>();
            listaCAT21Messages.AddRange(lista1CAT21Messages);

            // Eliminamos los paquetes muy lejos del aeropuerto de bcn (a +10 km ARP)
            listaCAT21Messages = FilterCAT21messagesAwayfromAirport(listaCAT21Messages, 10000);

            int index_SMR = 0;

            foreach (CAT10 smr in listaSMRMessages)
            {
                // Buscamos todos los paquetes CAT21 que estan a 1s de distancia del tiempo SMR
                List<CAT21> listaPacketCAT21 = new List<CAT21>();
                for (int i = 0; i < listaCAT21Messages.Count(); i++)
                {
                    double timedelay = Math.Abs(smr.timetotal - listaCAT21Messages[i].TimeofASTERIXReportTransmission_seconds);
                    if (timedelay <= 1)
                    {
                        listaPacketCAT21.Add(listaCAT21Messages[i]);
                    }
                }

                // Buscamos todos los paquetes MLAT que estan a 1s de distancia del tiempo SMR
                List<CAT10> listaPacketMLAT = new List<CAT10>();
                for (int i = 0; i < listaMLATMessages.Count(); i++)
                {
                    double timedelay = Math.Abs(smr.timetotal - listaMLATMessages[i].timetotal);
                    if (timedelay <= 1)
                    {
                        listaPacketMLAT.Add(listaMLATMessages[i]);
                    }
                }

                // Calculamos la distancia con cada uno de ellos

                List<double> listDistances_CAT21 = new List<double>();
                List<double> listDistances_MLAT = new List<double>();

                double U1 = smr.coordStereographic.U;
                double V1 = smr.coordStereographic.V;

                foreach (CAT21 cat21 in listaPacketCAT21)
                {
                    double U2 = cat21.coordStereographic.U;
                    double V2 = cat21.coordStereographic.V;

                    listDistances_CAT21.Add(Math.Sqrt(Math.Pow(U1 - U2, 2) + Math.Pow(V1 - V2, 2)));
                }

                foreach (CAT10 mlat in listaPacketMLAT)
                {
                    double U2 = mlat.coordStereographic.U;
                    double V2 = mlat.coordStereographic.V;

                    listDistances_MLAT.Add(Math.Sqrt(Math.Pow(U1 - U2, 2) + Math.Pow(V1 - V2, 2)));
                }

                // Una vez calculadas las distancias calculñamos distancia minima y asignamos ese paquete al trafico SMR 
                double distancia_limite = 50;
                if (listDistances_CAT21.Count() > 0 && listDistances_MLAT.Count() > 0)
                {
                    double distance_MLAT_Min = listDistances_MLAT.Min();
                    double distance_CAT21_Min = listDistances_CAT21.Min();

                    if (distance_CAT21_Min < distance_MLAT_Min)
                    {
                        if (listDistances_CAT21.Min() < distancia_limite)
                        {
                            int j1 = listDistances_CAT21.IndexOf(listDistances_CAT21.Min());
                            Trafico trafico1 = new Trafico(smr, listaPacketCAT21[j1]);
                            trafico1.distance = listDistances_CAT21.Min();
                            trafico1.TargetAddress = listaPacketCAT21[j1].TargetAdress_real;
                            listaTraficos.Add(trafico1);
                        }
                    }

                    else if (distance_CAT21_Min > distance_MLAT_Min)
                    {
                        if (listDistances_MLAT.Min() < distancia_limite)
                        {
                            int j1 = listDistances_MLAT.IndexOf(listDistances_MLAT.Min());
                            Trafico trafico1 = new Trafico(smr, listaPacketMLAT[j1]);
                            trafico1.distance = listDistances_MLAT.Min();
                            trafico1.TargetAddress = listaPacketMLAT[j1].TargetAdress_decoded;
                            listaTraficos.Add(trafico1);
                        }
                    }
                }

                else if (listDistances_CAT21.Count() > 0 && listDistances_MLAT.Count() == 0)
                {
                    if (listDistances_CAT21.Min() < distancia_limite)
                    {
                        int j1 = listDistances_CAT21.IndexOf(listDistances_CAT21.Min());
                        Trafico trafico1 = new Trafico(smr, listaPacketCAT21[j1]);
                        trafico1.distance = listDistances_CAT21.Min();
                        trafico1.TargetAddress = listaPacketCAT21[j1].TargetAdress_real;
                        listaTraficos.Add(trafico1);
                    }
                }

                else if (listDistances_CAT21.Count() == 0 && listDistances_MLAT.Count() > 0)
                {
                    if (listDistances_MLAT.Min() < distancia_limite)
                    {
                        int j1 = listDistances_MLAT.IndexOf(listDistances_MLAT.Min());
                        Trafico trafico = new Trafico(smr, listaPacketMLAT[j1]);
                        trafico.distance = listDistances_MLAT.Min();
                        trafico.TargetAddress = listaPacketMLAT[j1].TargetAdress_decoded;
                        listaTraficos.Add(trafico);
                    }
                }
            }

            //// Una vez calculados los traficos los organizamos por listas de listas

            //// primero sacamos lista de target address:

            //List<string> listaTargetAddress = new List<string>();
            //for(int i = 0; i<listaTraficos.Count(); i++)
            //{
            //    string TargetAddress = listaTraficos[i].TargetAddress;
            //    if (listaTargetAddress.Contains(TargetAddress))
            //    {

            //    }
            //    else
            //    {
            //        listaTargetAddress.Add(TargetAddress);
            //    }
            //}
            //List<List<CAT10>> lista_de_listas = new List<List<CAT10>>();
            //foreach(string TA in listaTargetAddress)
            //{
            //    List<CAT10> lista = new List<CAT10>();
            //    for (int i = 0; i < listaTraficos.Count(); i++)
            //    {
            //        if(listaTraficos[i].TargetAddress == TA) { lista.Add(listaTraficos[i].traficoSMR); }
            //    }
            //    lista_de_listas.Add(lista);
            //}

            return listaTraficos;


            //GMapOverlay overlay1 = new GMapOverlay();
            //Mapa.Overlays.Clear();

            //foreach (Trafico trafico in listaTraficos)
            //{
            //    PointLatLng marker = new PointLatLng(trafico.traficoSMR.coordGeodesic.Lat * GeoUtils.RADS2DEGS, trafico.traficoSMR.coordGeodesic.Lon * GeoUtils.RADS2DEGS);
            //    GMarkerGoogle marker1 = new GMarkerGoogle(marker, white_circle);

            //    PointLatLng marker2;
            //    GMarkerGoogle marker3;
            //    if (trafico.traficoCAT21 != null)
            //    {
            //        marker2 = new PointLatLng(trafico.traficoCAT21.coordGeodesic.Lat * GeoUtils.RADS2DEGS, trafico.traficoCAT21.coordGeodesic.Lon * GeoUtils.RADS2DEGS);
            //        marker3 = new GMarkerGoogle(marker2, green_circle);
            //    }
            //    else
            //    {
            //        marker2 = new PointLatLng(trafico.traficoMLAT.coordGeodesic.Lat * GeoUtils.RADS2DEGS, trafico.traficoMLAT.coordGeodesic.Lon * GeoUtils.RADS2DEGS);
            //        marker3 = new GMarkerGoogle(marker2, blue_circle);
            //    }

            //    GMapPolygon polygon = new GMapPolygon(new List<PointLatLng>() { marker, marker2 }, "")
            //    {
            //        Stroke = new System.Drawing.Pen(System.Drawing.Color.Red, 2),
            //        Fill = new SolidBrush(System.Drawing.Color.Red)
            //    };

            //    overlay1.Polygons.Add(polygon);
            //    overlay1.Markers.Add(marker1);
            //    overlay1.Markers.Add(marker3);

            //}

            //Mapa.Overlays.Add(overlay1);
        }

        public void CalculateTrajectories3(List<CAT10> listaSMR_1, List<CAT10> listaMLAT_1, List<CAT21> listaCAT21_1)
        {
            FilterByAirportZones(listaMLAT_1);

            // Primero establecemos las listas

            List<CAT10> listaSMR_Messages = new List<CAT10>();
            listaSMR_Messages.AddRange(listaSMR_1);

            List<CAT10> lista1 = new List<CAT10>();
            lista1.AddRange(listaMLAT_Ground);

            List<CAT21> lista2 = new List<CAT21>();
            lista2.AddRange(listaCAT21_1);

            // Una vez establecidas eliminamos los paquetes MLAT y CAT21 con Ground Bit diferente a 1

            List<CAT10> listaMLAT_Messages = new List<CAT10>();
            listaMLAT_Messages.AddRange(lista1);
            //for (int i = 0; i < lista1.Count(); i++)
            //{
            //    if (lista1[i].GBS == GBS_CAT10)
            //    {
            //        listaMLAT_Messages.Add(lista1[i]);
            //    }
            //}

            List<CAT21> listaCAT21_Messages = new List<CAT21>();
            for (int i = 0; i < lista2.Count(); i++)
            {
                if (lista2[i].GBS == GBS_CAT21)
                {
                    listaCAT21_Messages.Add(lista2[i]);
                }
            }

            // Ahora los agrupamos segun su track number o target address

            List<double> TrackNumbersSMR = new List<double>();
            List<List<CAT10>> listas_SMR = new List<List<CAT10>>();
            for (int i = 0; i < listaSMR_Messages.Count(); i++)
            {
                if (TrackNumbersSMR.Contains(listaSMR_Messages[i].Tracknumber_value))
                {

                }
                else
                {
                    TrackNumbersSMR.Add(listaSMR_Messages[i].Tracknumber_value);

                    List<CAT10> list = new List<CAT10>();
                    foreach (CAT10 smr in listaSMR_Messages)
                    {
                        if (smr.Tracknumber_value == listaSMR_Messages[i].Tracknumber_value)
                        {
                            list.Add(smr);
                        }
                    }
                    listas_SMR.Add(list);
                }
            }

            // Luego eliminamos el tafico en la coordenada 0,0 (torre de control) que muchas trayectorias tienen

            foreach (List<CAT10> listasmr in listas_SMR)
            {
                List<int> lista_paquetes_eliminar = new List<int>();
                for (int i = 0; i < listasmr.Count(); i++)
                {
                    if (Math.Pow(listasmr[i].X_cartesian, 2) + Math.Pow(listasmr[i].Y_cartesian, 2) <= Math.Pow(20, 2))
                    {
                        lista_paquetes_eliminar.Add(i);
                    }
                }
                for (int i = 0; i< lista_paquetes_eliminar.Count(); i++)
                {
                    listasmr.RemoveAt(lista_paquetes_eliminar[i]);
                }
            }

            List<double> TrackNumbers_MLAT = new List<double>();
            List<List<CAT10>> listas_MLAT = new List<List<CAT10>>();
            for (int i = 0; i < listaMLAT_Messages.Count(); i++)
            {
                if (TrackNumbers_MLAT.Contains(listaMLAT_Messages[i].Tracknumber_value))
                {

                }
                else
                {
                    TrackNumbers_MLAT.Add(listaMLAT_Messages[i].Tracknumber_value);
                }
            }

            foreach (double target_address in TrackNumbers_MLAT)
            {
                List<CAT10> list = new List<CAT10>();
                foreach (CAT10 mlat in listaMLAT_Messages)
                {
                    if (mlat.Tracknumber_value == target_address)
                    {
                        list.Add(mlat);
                    }
                }
                listas_MLAT.Add(list);
            }

            // Ahora que lo tenemos organizado pasamos a relacionar las trayectorias SMR con las MLAT
            // -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // Primero calculamos la distancia entre cada configuración de SMR y MLAT y la guardamos en una lista.
            // Para cada lista SMR generamos una lista de distancias nueva
            // Repetimos el proceso para cada lista MLAT

            //List<double> hola = new List<double>();
            List<Trayectoria> listaTrayectorias = new List<Trayectoria>();
            List<int> lista_indices_usados = new List<int>();
            // Ahora hay que relacionar, cada lista MLAT con lu lista SMR con distancia average mas cercana.
            listaTrayectorias.Clear();
            foreach (List<CAT10> lista_1 in listas_MLAT)
            {
                Trayectoria trajectory = new Trayectoria();
                trajectory.lista_MLAT = lista_1;
                listaTrayectorias.Add(trajectory);
            }

            lista_Trayectorias1.Clear();
            foreach (Trayectoria trajectory in listaTrayectorias)
            {

                List<List<CAT10>> lista_de_listas = new List<List<CAT10>>();

                if(trajectory.lista_MLAT.First().TargetAdress_decoded == "34104B")
                {

                }

                // Recorremos la lista MLAT de turno
                for (int i = 0; i<trajectory.lista_MLAT.Count(); i++)
                {

                    List<int> lista_indices1 = new List<int>();
                    // Ahora buscamos cuantas listas SMR empiezan a 1s de distancia de este paquete MLAT Y estan a 
                    for (int j = 0; j<listas_SMR.Count(); j++)
                    {
                        var lista_SMR = listas_SMR[j];
                        if (lista_indices_usados.Contains(j))
                        {
                            if (lista_SMR.First().Tracknumber_value == 2732)
                            {

                            }
                        }

                        else
                        {
                            if (i + lista_SMR.Count() < listaMLAT.Count())
                            {
                                double timedelay = Math.Abs(trajectory.lista_MLAT[i].timetotal - lista_SMR.First().timetotal);
                                if (timedelay <= 8)
                                {
                                    lista_indices1.Add(j);
                                }
                            }
                        }
                    }

                    // Una vez hemos seleccionado los indices que nos interesan hay que eliminar los duplicados
                    var lista_indices = new HashSet<int>(lista_indices1).ToList();

                    if (lista_indices.Count() > 0)
                    {
                        List<int> lista_indices_usados1 = new List<int>();
                        List<List<CAT10>> lista_de_listas1 = new List<List<CAT10>>();

                        // Ahora recorremos esta lista de indices buscando si la distancia average en el intento i es menor a 50.
                        foreach (int index in lista_indices)
                        {
                            List<double> lista_distancias_1 = new List<double>(); // lista de las distancias entre cada paquete SMR y MLAt para un intento
                            var listaSMR = listas_SMR[index];

                            if(listaSMR.First().Tracknumber_value == 2732)
                            {

                            }

                            int j = 0;
                            while (j < listaSMR.Count() && (i+j)<trajectory.lista_MLAT.Count())
                            {

                                double U1 = trajectory.lista_MLAT[i + j].coordStereographic.U;
                                double U2 = listaSMR[j].coordStereographic.U;

                                double V1 = trajectory.lista_MLAT[i + j].coordStereographic.V;
                                double V2 = listaSMR[j].coordStereographic.V;

                                double distancia = Math.Sqrt(Math.Pow(U2 - U1, 2) + Math.Pow(V2 - V1, 2));

                                lista_distancias_1.Add(distancia);

                                j++;
                            }

                            if (lista_distancias_1.Count() > 0)
                            {
                                if (lista_distancias_1.Average() < 80)
                                {
                                    lista_de_listas.Add(listas_SMR[index]);
                                    lista_indices_usados.Add(index);
                                }
                            }
                        }
                    }
                }
                // Una vez hemos seleccionado las listas que nos interesan hay que eliminar los duplicados
                var lista_de_listas_1 = new HashSet<List<CAT10>>(lista_de_listas).ToList();

                // Ahora hay que ordenarlas por tiempo, dando preferencia a las listas SMR que estan mas cerca
                // Primero las ordenamos por tiempo y a ver que sale

                for(int i = 0; i<lista_de_listas_1.Count(); i++)
                {
                    trajectory.listaSMR.AddRange(lista_de_listas_1[i]);
                }
                trajectory.listaSMR.OrderBy(o => o.timetotal).ToList();
            }

            List<string> lista_TA = new List<string>();

            foreach(Trayectoria trajectory in listaTrayectorias)
            {
                if (lista_TA.Contains(trajectory.lista_MLAT.First().TargetAdress_decoded))
                {

                }
                else
                {
                    lista_TA.Add(trajectory.lista_MLAT.First().TargetAdress_decoded);
                }
            }

            foreach(string TA in lista_TA)
            {
                Trayectoria trajectory = new Trayectoria();
                for(int i = 0; i<listaTrayectorias.Count(); i++)
                {
                    if(listaTrayectorias[i].lista_MLAT.First().TargetAdress_decoded == TA)
                    {
                        trajectory.lista_MLAT.AddRange(listaTrayectorias[i].lista_MLAT);
                        trajectory.listaSMR.AddRange(listaTrayectorias[i].listaSMR);
                    }
                }
                trajectory.lista_MLAT.OrderBy(o => o.timetotal);
                trajectory.listaSMR.OrderBy(o => o.timetotal);

                lista_Trayectorias1.Add(trajectory);
            }
        }

        public void Predict(Trayectoria trayectoria)
        {
            // Calculate error covariance     P= A*P*A' + Q    

            var A_T = Accord.Math.Matrix.Transpose(trayectoria.A);
            var a2 = Accord.Math.Matrix.Dot(trayectoria.P, A_T);
            a2 = Accord.Math.Matrix.Dot(trayectoria.A, a2);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    trayectoria.P[i, j] = a2[i, j] + trayectoria.Q[i, j];
                }
            }
        }

        public void Update(Trayectoria trayectoria)
        {
            // Primero calculamos las coordenadas cartesianas del ultimo paquete de la lista SMR de esta trayectoria respecto al radar.
            CoordinatesXYZ coordGeocent = GeoUtils1.change_geodesic2geocentric(trayectoria.listaSMR.Last().coordGeodesic);
            CoordinatesXYZ coordRadarCart = GeoUtils1.change_geocentric2radar_cartesian(new CoordinatesWGS84(LatSMR, LonSMR), coordGeocent);
            trayectoria.deltaX = coordRadarCart.X;
            trayectoria.deltaY = coordRadarCart.Y;

            double[] dist1 = new double[] { trayectoria.deltaX, trayectoria.deltaY };
            var dist = Accord.Math.Matrix.Transpose(dist1);


            // Refer to :Eq.(11), Eq.(12) and Eq.(13) in     S = H*P*H'+R

            var a3 = Accord.Math.Matrix.Dot(trayectoria.P, Accord.Math.Matrix.Transpose(trayectoria.H));
            Double[,] S = new Double[2, 2];
            a3 = Accord.Math.Matrix.Dot(trayectoria.H, a3);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    S[i, j] = a3[i, j] + trayectoria.R[i, j];
                }
            }

            // Calculate the Kalman Gain     K = P * H'* inv(H*P*H'+R)

            var a4 = Accord.Math.Matrix.Dot(Accord.Math.Matrix.Transpose(trayectoria.H), Accord.Math.Matrix.Inverse(S));
            trayectoria.K = Accord.Math.Matrix.Dot(trayectoria.P, a4);

            var a5 = Accord.Math.Matrix.Dot(trayectoria.H, trayectoria.x);
            var a6 = a5;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    a6[i, j] = dist[i,j] - a5[i, j];
                }
            }

            var a7 = Accord.Math.Matrix.Dot(trayectoria.K, a6);

            for (int i = 0; i < 4; i++)
            {
                trayectoria.x[i, 0] = trayectoria.x[i, 0] + a7[i, 0];
            }

            // Con los nuevos valores de x,y calculamos la siguiente posición predecida por el algoritmo en coordenadas WGS 84
            double rho = 0;
            double theta = 0;
            if((trayectoria.x[0, 0]==0? 1 : 0)  + (trayectoria.x[1, 0]==0? 1 : 0) >0)
            {
                rho = Math.Sqrt(Math.Pow(trayectoria.x[0, 0], 2) + Math.Pow(trayectoria.x[1, 0], 2));
                theta = (180 / Math.PI) * Math.Atan2(trayectoria.x[0, 0], trayectoria.x[1, 0]);
            }
             
            var coord_wgs84 = NewCoordinates(trayectoria.listaSMR.Last().coordGeodesic.Lat * GeoUtils.RADS2DEGS, trayectoria.listaSMR.Last().coordGeodesic.Lon * GeoUtils.RADS2DEGS, rho, theta);
            trayectoria.coordGeodesic_SMR = new CoordinatesWGS84(coord_wgs84[0] * GeoUtils.DEGS2RADS, coord_wgs84[1] * GeoUtils.DEGS2RADS);

            // Calculamos coordenadas System Cartesian
            CoordinatesXYZ coordGeocentric = GeoUtils1.change_geodesic2geocentric(trayectoria.coordGeodesic_SMR);
            trayectoria.coordSystemCartesian_SMR = GeoUtils1.change_geocentric2system_cartesian(coordGeocentric);

            // Calculamos coordenadas Stereograficas
            trayectoria.coordStereographic_SMR = GeoUtils1.change_system_cartesian2stereographic(trayectoria.coordSystemCartesian_SMR);

            // Recalculamos la P

            var a8 = Accord.Math.Matrix.Dot(trayectoria.K, trayectoria.H);
            var I = Accord.Math.Matrix.Identity(4);
            var a9 = a8;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a9[i, j] = I[i,j] - a8[i, j];
                }
            }

            trayectoria.P = Accord.Math.Matrix.Dot(a9, trayectoria.P);

        }

        public void FilterCAT10(List<CAT10> list)
        {
            List<CAT10> list1 = new List<CAT10>();
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].MessageType_decodified == "Target Report") { list1.Add(list[i]); }
            }

            List<CAT10> list2 = new List<CAT10>();
            for (int i = 0; i < list1.Count(); i++)
            {
                if (list1[i].TOT == "Aircraft." || list1[i].TOT == "") { list2.Add(list1[i]); }
            }

            list.Clear();
            list.AddRange(list2);
        }

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

                if (distancia < distance) { result.Add(listaCAT21messages[i]); }
            }

            return result;
        } // Calculamos paquetes mas cercanos al aeropuerto

        public void ColorEveryTrackNumberAndPlotMap()
        {
            Mapa.Overlays.Clear();

            // Separamos los paquetes por Tracknumber

            List<double> listaSMRTrackNumbers = new List<double>();
            for (int i = 0; i < listaSMR.Count(); i++)
            {
                double tracknumber = listaSMR[i].Tracknumber_value;

                if (listaSMRTrackNumbers.Contains(tracknumber))
                {

                }
                else
                {
                    listaSMRTrackNumbers.Add(tracknumber);
                }
            }

            List<List<CAT10>> list_of_lists_of_tracknumber = new List<List<CAT10>>();

            foreach (double tracknumber in listaSMRTrackNumbers)
            {
                List<CAT10> list_of_tracknumbers = new List<CAT10>();
                for (int i = 0; i < listaSMR.Count(); i++)
                {
                    if (listaSMR[i].Tracknumber_value == tracknumber && listaSMR[i].TrackNumber.Length > 0)
                    {
                        list_of_tracknumbers.Add(listaSMR[i]);
                    }
                }
                list_of_lists_of_tracknumber.Add(list_of_tracknumbers);
            }

            // Pintamos los trayectos por Track Number
            GMapOverlay polygonsoverlay = new GMapOverlay();
            int j = 0;
            foreach (List<CAT10> list in list_of_lists_of_tracknumber)
            {
                for (int i = 0; i < list.Count() - 1; i++)
                {
                    SolidColorBrush color;
                    System.Windows.Media.Color color1;
                    try
                    {
                        color = new SolidColorBrush((Color)ColorConverter.ConvertFromString(listColors[j]));
                        color1 = Color.FromArgb(color.Color.A, color.Color.R, color.Color.G, color.Color.B);
                    }
                    catch
                    {
                        color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff0000"));
                        color1 = Color.FromArgb(color.Color.A, color.Color.R, color.Color.G, color.Color.B);
                    }

                    PointLatLng marker1 = new PointLatLng(list[i].coordGeodesic.Lat * GeoUtils.RADS2DEGS, list[i].coordGeodesic.Lon * GeoUtils.RADS2DEGS);
                    PointLatLng marker2 = new PointLatLng(list[i + 1].coordGeodesic.Lat * GeoUtils.RADS2DEGS, list[i + 1].coordGeodesic.Lon * GeoUtils.RADS2DEGS);

                    List<PointLatLng> listpoints = new List<PointLatLng>() { marker1, marker2 };
                    GMapPolygon polygon = new GMapPolygon(listpoints, "")
                    {
                        Stroke = new System.Drawing.Pen(System.Drawing.Color.FromArgb(color1.A, color1.R, color1.G, color1.B))
                    };
                    polygonsoverlay.Polygons.Add(polygon);
                }
                j++;

                if (j == listColors.Count()) { j = 0; }
            }

            Mapa.Overlays.Add(polygonsoverlay);
        }

        #region Vincenty's Equations

        public double toRadians(double grados)
        {
            return grados * Math.PI / 180;
        }
        
        public double toDegrees(double radians)
        {
            return radians * 180 / (Math.PI);
        }

        public double[] NewCoordinates(double lat, double lon, double distance, double initialBearing)
        {
            double[] listaCoordenadas = new double[2];


            double φ1 = toRadians(lat);
            double λ1 = toRadians(lon);
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
            } while (Math.Abs(lambda - lambdaP) > 1e-12 && --iterLimit > 0);

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

        #endregion

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
                bool insideJ_start = polygonJ.IsInside(new PointLatLng(listplanes.First().coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes.First().coordGeodesic.Lon * GeoUtils.RADS2DEGS));
                bool insideJ_end = polygonJ.IsInside(new PointLatLng(listplanes.Last().coordGeodesic.Lat * GeoUtils.RADS2DEGS, listplanes.Last().coordGeodesic.Lon * GeoUtils.RADS2DEGS));

                // Si el avion sigue una trayectoria de despegue (empieza dentro de zona aeropuerto y acaba fuera)
                if (insideJ_start == true && insideJ_end == false)
                {
                    if (i == 61)
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
            }
        } // Separamos los paquetes MLAT por zonas del Aeropuerto

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);

            GMapOverlay overlay = new GMapOverlay();
            foreach (CAT10 smr in lista_Trayectorias1[num].listaSMR)
            {
                PointLatLng marker1 = new PointLatLng(smr.coordGeodesic.Lat * GeoUtils.RADS2DEGS, smr.coordGeodesic.Lon * GeoUtils.RADS2DEGS);
                GMarkerGoogle marker = new GMarkerGoogle(marker1, red_circle);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Concat(smr.timetotal.ToString());
                overlay.Markers.Add(marker);
            }

            foreach (CAT10 mlat in lista_Trayectorias1[num].lista_MLAT)
            {
                PointLatLng marker1 = new PointLatLng(mlat.coordGeodesic.Lat * GeoUtils.RADS2DEGS, mlat.coordGeodesic.Lon * GeoUtils.RADS2DEGS);
                GMarkerGoogle marker = new GMarkerGoogle(marker1, blue_circle);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Concat(mlat.timetotal.ToString());
                overlay.Markers.Add(marker);
            }

            Mapa.Overlays.Clear();
            Mapa.Overlays.Add(overlay);
        }
    }
}
