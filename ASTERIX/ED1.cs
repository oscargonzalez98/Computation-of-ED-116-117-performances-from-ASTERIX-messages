using Clases;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using LIBRERIACLASES;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

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

        List<CAT21> listaCAT21_Apron = new List<CAT21>();
        List<CAT21> listaCAT21_Stand = new List<CAT21>();
        List<CAT21> listaCAT21_MA = new List<CAT21>();
        List<CAT21> listaCAT21_Airborne = new List<CAT21>();

        List<CAT10> listaMLAT = new List<CAT10>();
        List<CAT10> listaSMR = new List<CAT10>();

        List<CAT10> listaMLATmodeS = new List<CAT10>();

        List<CAT10> listaMLAT_Stand = new List<CAT10>();
        List<CAT10> listaMLAT_Apron = new List<CAT10>();
        List<CAT10> listaMLAT_MA = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne = new List<CAT10>();

        List<CAT10> listaMLAT_Airborne_2coma5NM = new List<CAT10>();
        List<CAT10> listaMLAT_Airborne_5NM = new List<CAT10>();

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

        // CoordenadasSMR
        double LatSMR = 41.295618;
        double LonSMR = 2.095114;

        // Coordenadas MLAT
        double LatMLAT = 41.297063;
        double LonMLAT = 2.078447;

        // Lista Bar Chart UpdateRate
        public List<IndividualBar> listBarsUpdateRate = new List<IndividualBar>();

        List<double> listaLimitAverageValue_Apron = new List<double>();
        List<double> listaProbabilityUpdate_Apron = new List<double>();
        List<double> listaProbabilityUpdate_Stand = new List<double>();
        List<double> listaProbabilityUpdate_MA = new List<double>();
        List<double> listaProbabilityUpdate_Airborne = new List<double>();

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

            //// Update Rate: based on the squitter rate of Mode S transponders) (hay que hacer una lista solo con paquetes de Transponder mode S

           i = 0;
            while (i < listaMLAT.Count)
            {
                if (listaMLAT[i].TYP == "Mode S multilateration." && listaMLAT[i].MessageType_decodified!= "Periodic Status Message" && listaMLAT[i].MessageType_decodified != "Start of Update Cycle" && listaMLAT[i].TOT=="Aircraft.")
                {
                    listaMLATmodeS.Add(listaMLAT[i]);
                }
                i = i + 1;
            }

            //listaMLATmodeS = listaMLAT;

            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // Probability of Update: Separamos la listaMLATmodeS en 4 listas según la posición del paquete en el mapa

            // Creamos las superficies con las coordenadas anteriores
            var polygonA = new GMapPolygon(polygonApoints, "PolygonA")
            {
                Stroke = new Pen(Color.Magenta, 2),
                Fill = new SolidBrush(Color.Magenta)
            };

            var polygonB = new GMapPolygon(polygonBpoints, "PolygonB")
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

            var polygonI = new GMapPolygon(polygonIpoints, "PolygonI")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Green)
            };

            var polygonJ = new GMapPolygon(polygonJpoints, "PolygonJ")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Red)
            };

            var polygonK = new GMapPolygon(polygonKpoints, "PolygonK")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Red)
            };

            var polygonL = new GMapPolygon(polygonLpoints, "PolygonL")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Red)
            };

            var polygonM = new GMapPolygon(polygonMpoints, "PolygonM")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Red)
            };

            var polygonN = new GMapPolygon(polygonNpoints, "PolygonN")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Red)
            };

            var polygonO = new GMapPolygon(polygonOpoints, "PolygonO")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Red)
            };

            var polygonP = new GMapPolygon(polygonPpoints, "PolygonP")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Red)
            };

            var polygonQ = new GMapPolygon(polygonQpoints, "PolygonQ")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Red)
            };

            var polygonR = new GMapPolygon(polygonRpoints, "PolygonR")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Red)
            };

            var polygonS = new GMapPolygon(polygonSpoints, "PolygonS")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Red)
            };

            var polygonT = new GMapPolygon(polygonTpoints, "PolygonT")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Red)
            };

            var polygonU = new GMapPolygon(polygonUpoints, "PolygonU")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Red)
            };

            var polygonV = new GMapPolygon(polygonVpoints, "PolygonV")
            {
                Stroke = new Pen(Color.Green, 2),
                Fill = new SolidBrush(Color.Red)
            };


            // Separamos los paquetes MLAT según su zona del aeropuerto

            List<double> listavelocidades = new List<double>();

            i = 0;
            while(i<listaMLATmodeS.Count)
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

                    // Separtamos los paquetes según su zona del aeropuerto, diferenciando los que estan volando y los que no
                    double Vthreshold = 250;
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
                        // si va a una velocidad "baja"
                        if (listaMLATmodeS[i].GroundSpeed * (1852 * 3600 / 1000) < Vthreshold)
                        {
                            listaMLAT_MA.Add(listaMLATmodeS[i]);
                        }

                        else // si va a una velocidad alta
                        {
                            listaMLAT_Airborne.Add(listaMLATmodeS[i]);

                            if (insideL) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                            if (insideN) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                            if (insideP) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                            if (insideR) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                            if (insideT) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                            if (insideV) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                        }
                    }
                    else if(insideI==false && insideJ == true) // fuera de Apron, Stand, MA pero dentro de Zona aeropuerto
                    {
                        if (listaMLATmodeS[i].GroundSpeed * (1852 * 3600 / 1000) > Vthreshold)
                        {
                            listaMLAT_Airborne.Add(listaMLATmodeS[i]);

                            if (insideL) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                            if (insideN) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                            if (insideP) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                            if (insideR) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                            if (insideT) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                            if (insideV) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                        }
                    }
                    else // fuera de la zona aeropuerto
                    {
                        if(listaMLATmodeS[i].GroundSpeed * (1852 * 3600 / 1000) > 110)
                        {
                            listaMLAT_Airborne.Add(listaMLATmodeS[i]);

                            if (insideK) { listaMLAT_Airborne_5NM.Add(listaMLATmodeS[i]); }
                            if (insideM) { listaMLAT_Airborne_5NM.Add(listaMLATmodeS[i]); }
                            if (insideO) { listaMLAT_Airborne_5NM.Add(listaMLATmodeS[i]); }
                            if (insideQ) { listaMLAT_Airborne_5NM.Add(listaMLATmodeS[i]); }
                            if (insideS) { listaMLAT_Airborne_5NM.Add(listaMLATmodeS[i]); }
                            if (insideU) { listaMLAT_Airborne_5NM.Add(listaMLATmodeS[i]); }

                            if (insideL) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                            if (insideN) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                            if (insideP) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                            if (insideR) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                            if (insideT) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                            if (insideV) { listaMLAT_Airborne_2coma5NM.Add(listaMLATmodeS[i]); }
                        }
                    }
                    i = i + 1;
                }
            }

            //////----------------------------------------------------------------------- Ploteamos en el mapa

            // creamos un overlay solo para el load
            GMapOverlay overlayLoad = new GMapOverlay();
            overlayLoad.Clear();

            Mapa.DragButton = MouseButtons.Left;
            Mapa.CanDragMap = true;
            Mapa.MapProvider = GMapProviders.GoogleMap;
            Mapa.Position = new PointLatLng(LatMLAT, LonMLAT);
            Mapa.MinZoom = 1;
            Mapa.MaxZoom = 30;
            Mapa.Zoom = 8;
            Mapa.AutoScroll = true;


            //GMapOverlay overlaySTAND = PlotListadePaquetesenOverlay(listaMLAT_Stand, blue_plane);
            //Mapa.Overlays.Add(overlaySTAND);

            //GMapOverlay overlayAPRON = PlotListadePaquetesenOverlay(listaMLAT_Apron, green_plane);
            //Mapa.Overlays.Add(overlayAPRON);

            GMapOverlay overlayMA = PlotListadePaquetesenOverlay(listaMLAT_MA, red_plane);
            Mapa.Overlays.Add(overlayMA);

            GMapOverlay overlayAIRBORNE25 = PlotListadePaquetesenOverlay(listaMLAT_Airborne_2coma5NM, white_plane);
            Mapa.Overlays.Add(overlayAIRBORNE25);

            GMapOverlay overlayAIRBORNE5 = PlotListadePaquetesenOverlay(listaMLAT_Airborne_5NM, blue_plane);
            Mapa.Overlays.Add(overlayAIRBORNE5);

            //GMapOverlay overlayAIRBORNE = PlotListadePaquetesenOverlay(listaMLAT_Airborne, green_plane);
            //Mapa.Overlays.Add(overlayAIRBORNE);


        }



        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void bt_CalculateUpdateRate_Click(object sender, EventArgs e)
        {
            List<string> listaNombresUsados = new List<string>();
            List<List<CAT10>> listadelistasdeavionesconmismonombre = new List<List<CAT10>>();
            List<double> listaAvgDelay = new List<double>();

            pb_UpdateRate.Maximum = listaMLATmodeS.Count;
            pb_UpdateRate.Value = 0;

            int i= 0;
            while(i<listaMLATmodeS.Count)
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
                        int j = i+1;
                        List<CAT10> ListaPlanesMismoNombre = new List<CAT10>();
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
                            if (Math.Abs(ListaPlanesMismoNombre[k + 1].TimeofDay_seconds - ListaPlanesMismoNombre[k].TimeofDay_seconds)<30) // si entre un report y otro hay +10s de diferencia asumimos que el vehiculo ha dejado de emitir y por tanto no cuenta como tiempo entre mensaje y mensaje
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
                pb_UpdateRate.Value = i;
            }
        }

        private void pb_ProbabilityofUpdate_Click(object sender, EventArgs e)
        {

            // Apron

            double AverafeDelayApron = CalculateProbabilityofUpdate(listaMLAT_Apron);

            // Stand

            double AverafeDelayStand = CalculateProbabilityofUpdate(listaMLAT_Stand);

            // MA

            double AverafeDelayMA = CalculateProbabilityofUpdate(listaMLAT_MA);

            // Airborne

            double AverafeDelayAirborne_2coma5NM = CalculateProbabilityofUpdate(listaMLAT_Airborne_2coma5NM);
            double AverafeDelayAirborne_5NM = CalculateProbabilityofUpdate(listaMLAT_Airborne_5NM);
        }

        private void bt_PrecissionAccuracy_Click(object sender, EventArgs e)
        {
            // Stand

            double contadordecasos = 0;
            double contadordebuenos = 0;

            // Recorremos lista ADSB y buscamos cual es el paquete MLAt que tienen mas cerca en tiempo, comparamos sus posiciones, diistancia entre ellos etc... y actualizamos el contador segun los resultados

            int i = 0;
            while(i<listaMLAT_Stand.Count())
            {
                string TargetIdentificationMLAT;
                string TargetAddressMLAT;

                string TargetIdentificationCAT21;
                string TargetAddressCAT21;

                double timeMLAT = listaMLAT_Stand[i].TimeofDay_seconds;
                double diferenciadetiempo = 10e5; // le asignamos un valor muy alto para si lo vemos saber que no se ha modificado

                if ((listaMLAT_Stand[i].TargetIdentification_decoded.Length > 0 && listaMLAT_Stand[i].TargetAdress_decoded.Length > 0) || (listaMLAT_Stand[i].TargetIdentification_decoded.Length > 0) || (listaMLAT_Stand[i].TargetAdress_decoded.Length > 0))// cojemos los paquetes que tienen Target Address y/o Target Identification
                {
                    TargetIdentificationMLAT = listaMLAT_Stand[i].TargetIdentification_decoded;
                    TargetAddressMLAT = listaMLAT_Stand[i].TargetAdress_decoded;

                    int indexj = 1000000;

                    //Buscamos el MLAT mas cercano en lista general
                    int j = 0;
                    while(j<listaCAT21.Count())
                    {
                        //Nos aseguramos de que tengan Target Identification Target Address o las dos
                        if ((listaCAT21[j].TargetIdentification.Length > 0 && listaCAT21[j].TargetAdress_real.Length > 0) || (listaCAT21[j].TargetIdentification.Length > 0) || (listaCAT21[j].TargetAdress_real.Length > 0))
                        {
                            TargetIdentificationCAT21 = listaCAT21[j].TargetIdentification_decoded;
                            TargetAddressCAT21 = listaCAT21[j].TargetAdress_real;

                            double timeCAT21 = listaCAT21[j].TimeofASTERIXReportTransmission_seconds;
                            // si tienen el mismo nombre
                            if (((TargetIdentificationCAT21 == TargetIdentificationMLAT && TargetAddressCAT21 == TargetAddressMLAT)) || TargetIdentificationCAT21 == TargetIdentificationMLAT|| TargetAddressCAT21 == TargetAddressMLAT)
                            {
                                // si hemos encontrado paquete con mismo nombre y mas cerca en el tiempo (y es una diferencia de tiempo razonable, en este caso de 30s max) substituimos la diferencia de tiempo anterior por la nueva
                                if (Math.Abs(timeCAT21 - timeMLAT) < diferenciadetiempo && Math.Abs(timeCAT21 - timeMLAT) < 5) 
                                { 
                                    diferenciadetiempo = timeMLAT - timeCAT21;
                                    indexj = j;
                                }
                            }
                        }
                        j = j + 1;
                    }

                    // una vez recorrida toda la listaMLAT tenemos la diferencia de tiempo mas pequeña entre el paquete CAT21 de turno y su correspondiente

                    if(indexj!=1000000)
                    {
                        // Ahora nos aseguramos que el paquete mlat tiene info de posición y interpolamos para calcular posiciones
                        double[] coordenadasMLAT = new double[2];

                        if ((listaMLAT_Stand[i].MeasuredPositioninPolarCoordinates.Length > 0 && listaMLAT_Stand[i].PositioninCartesianCoordinates.Length > 0) || (listaMLAT_Stand[i].MeasuredPositioninPolarCoordinates.Length > 0) || (listaMLAT_Stand[i].PositioninCartesianCoordinates.Length > 0)) // si tenemos info de las coordenadas MLAT
                        {
                            if (listaMLAT_Stand[i].MeasuredPositioninPolarCoordinates.Length > 0) // si tenemos coordenadas polares
                            {
                                coordenadasMLAT = NewCoordinatesMLAT(listaMLAT_Stand[i].Rho, listaMLAT_Stand[i].Theta);
                            }

                            else // si no tenemos coordenadas polares pero si coordenadas cartesianas
                            {
                                double rho = Math.Sqrt((listaMLAT_Stand[i].X_cartesian) * (listaMLAT_Stand[i].X_cartesian) + (listaMLAT_Stand[i].Y_cartesian) * (listaMLAT_Stand[i].Y_cartesian));
                                double theta = (180 / Math.PI) * Math.Atan2(listaMLAT_Stand[i].X_cartesian, listaMLAT_Stand[i].Y_cartesian);

                                coordenadasMLAT = NewCoordinatesMLAT(rho, theta);
                            }

                            double[] coordenadasCAT21 = new double[2];
                            if (listaCAT21[indexj].PositioninWGS_HRcoordinates.Length > 0)
                            {
                                coordenadasCAT21[0] = listaCAT21[indexj].latWGS84_HR;
                                coordenadasCAT21[1] = listaCAT21[indexj].lonWGS84_HR;
                            }
                            else
                            {
                                coordenadasCAT21[0] = listaCAT21[indexj].latWGS84;
                                coordenadasCAT21[1] = listaCAT21[indexj].lonWGS84;
                            }

                            // Ahora nos aseguramos de que los paquetes a comparar tienen info de velocidad

                            if (listaMLAT_Apron[i].GroundSpeed > 0 && listaCAT21[indexj].GroundSpeed > 0)
                            {
                                double speedMLAT = listaMLAT_Stand[i].GroundSpeed;
                                double headingMLAT = listaMLAT_Stand[i].TrackAngle;
                                double speedCAT21 = listaCAT21[indexj].GroundSpeed;
                                double headingCAT21 = listaCAT21[indexj].TrackAngle;

                                double distanciaentrecoordenadas=0;

                                // Interpolamos para sacar la posicion 

                                if (diferenciadetiempo > 0 && diferenciadetiempo!=10e5)
                                {
                                    // calculamos nuevas coordenadas con tiempos comparables
                                    double[] newCoordinatesCAT21 = NewCoordinatesMLAT(Math.Abs((speedMLAT - speedCAT21) * diferenciadetiempo) * 1851.9984, headingCAT21);

                                    // Calculamos diferencia entre esas coordenadas y las MLAT
                                    distanciaentrecoordenadas = CalculateDistanceBetweenCoordinates(newCoordinatesCAT21, coordenadasMLAT);
                                }

                                else if (diferenciadetiempo < 0)
                                {
                                    // calculamos nuevas coordenadas con tiempos comparables
                                    double[] newCoordinatesCAT21 = NewCoordinatesMLAT(Math.Abs((speedMLAT - speedCAT21) * diferenciadetiempo) * 1851.9984, headingCAT21+180);

                                    // Calculamos diferencia entre esas coordenadas y las MLAT
                                    distanciaentrecoordenadas = CalculateDistanceBetweenCoordinates(newCoordinatesCAT21, coordenadasMLAT);
                                }

                                // Una vez calculada la distancia actualizamos contadores

                            }
                        }
                    }
                }
                i = i + 1;
            }
        }


        private void bt_ShowResultsUpdateRate_Click(object sender, EventArgs e)
        {
            BarChartGraphUpdateRate barchart1 = new BarChartGraphUpdateRate(listBarsUpdateRate);
            barchart1.Show();

            BarPlotUpdateRate1 barplot1 = new BarPlotUpdateRate1(listBarsUpdateRate);
            barplot1.Show();
        }

        private void bt_ShowResultsProbabilityofUpdate_Click(object sender, EventArgs e)
        {
            PlotProbabilityofUpdate lchart1 = new PlotProbabilityofUpdate(listaLimitAverageValue_Apron, listaProbabilityUpdate_Apron, listaProbabilityUpdate_Stand, listaProbabilityUpdate_MA, listaProbabilityUpdate_Airborne);
            lchart1.Show();
        }



        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

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
            var α1 = Math.Atan2(cosU2*Math.Sin(L), cosU1*sinU2 - sinU1 * cosU2*Math.Cos(L));
            var α2 = Math.Atan2(cosU1 * Math.Sin(L), -1*sinU1 * cosU2 + cosU1 * sinU2 * Math.Cos(L));

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

        public GMapOverlay PlotListadePaquetesenOverlay(List<CAT10> listaMLATmodeS, Bitmap blue_plane)
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
                        marker = new GMarkerGoogle(new PointLatLng(coordenadas[0], coordenadas[1]), blue_pushback);
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

        public double CalculateProbabilityofUpdate(List<CAT10> listaMLAT_Apron)
        {
            pb_ProbUpdate.Value = 0;
            pb_ProbUpdate.Maximum = listaMLAT_Apron.Count() + listaMLAT_Stand.Count() + listaMLAT_MA.Count() + listaMLAT_Airborne.Count();

            // Apron

            List<string> listaNombresUsados_Apron = new List<string>();
            List<List<CAT10>> listadelistasdeavionesconmismonombre_Apron = new List<List<CAT10>>();
            List<double> listaAvgDelay_Apron = new List<double>();

            //pb_UpdateRate.Maximum = listaMLATmodeS.Count;
            //pb_UpdateRate.Value = 0;

            int i = 0;
            while (i < listaMLAT_Apron.Count)
            {
                string TargetIdentification;
                string TargetAddress;

                if ((listaMLAT_Apron[i].TargetIdentification.Length > 0 && listaMLAT_Apron[i].TargetAdress.Length > 0) || (listaMLAT_Apron[i].TargetIdentification.Length > 0) || (listaMLAT_Apron[i].TargetAdress.Length > 0)) // cojemos los paquetes que tienen Target Address y/o Target Identification
                {
                    TargetIdentification = listaMLAT_Apron[i].TargetIdentification_decoded;
                    TargetAddress = listaMLAT_Apron[i].TargetAdress_decoded;

                    if ((listaNombresUsados_Apron.Contains(TargetIdentification) && listaNombresUsados_Apron.Contains(TargetAddress)) || (listaNombresUsados_Apron.Contains(TargetIdentification)) || (listaNombresUsados_Apron.Contains(TargetAddress))) // si Target Address y/o Target Identification estan en la lista de paquetes ya calculados no hacemos nada
                    { }
                    else
                    {
                        int j = i;
                        List<CAT10> ListaPlanesMismoNombre = new List<CAT10>();
                        while (j < listaMLAT_Apron.Count)
                        {
                            if (listaMLAT_Apron[j].TargetIdentification_decoded == TargetIdentification && listaMLAT_Apron[j].TargetIdentification_decoded != "")
                            {
                                ListaPlanesMismoNombre.Add(listaMLAT_Apron[j]);
                            }

                            else if (listaMLAT_Apron[j].TargetAdress_decoded == TargetAddress && listaMLAT_Apron[j].TargetAdress_decoded != "")
                            {
                                ListaPlanesMismoNombre.Add(listaMLAT_Apron[j]);
                            }
                            j = j + 1;
                        }

                        listadelistasdeavionesconmismonombre_Apron.Add(ListaPlanesMismoNombre);
                        if (listaMLAT_Apron[i].TargetIdentification.Length > 0) { listaNombresUsados_Apron.Add(TargetIdentification); }
                        else if (listaMLAT_Apron[i].TargetAdress.Length > 0) { listaNombresUsados_Apron.Add(TargetAddress); }


                        int k = 0;
                        double AvgSeconds = 0;

                        if (ListaPlanesMismoNombre.Count() > 1)
                        {
                            double counterSteps = 0;
                            double counterTrue = 0;

                            while (k < ListaPlanesMismoNombre.Count - 1)
                            {
                                if (Math.Abs(ListaPlanesMismoNombre[k + 1].TimeofDay_seconds - ListaPlanesMismoNombre[k].TimeofDay_seconds) < 30)
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
                pb_ProbUpdate.Value = pb_ProbUpdate.Value + 1;
                //pb_UpdateRate.Value = i;
            }

            return listaAvgDelay_Apron.Average() * 100;
        }
    }
}
