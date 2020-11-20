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

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace ASTERIX
{
    public partial class MLATCalibrationVehicle: Form
    {
        List<MLATCalibrationData> listaMLATCalibrationVehicle = new List<MLATCalibrationData>();
        Bitmap green_pushback = (Bitmap)Image.FromFile("img/Pushbacks/bushback_green_small.png");
        public MLATCalibrationVehicle(List<MLATCalibrationData> listaMLATCalibrationVehicle)
        {
            InitializeComponent();
            this.listaMLATCalibrationVehicle = listaMLATCalibrationVehicle;
            
        }
        private void MLATCalibrationVehicle_Load(object sender, EventArgs e)
        {
            for(int i = 0; i<listaMLATCalibrationVehicle.Count; i++)
            {
                int n = dataGridView1.Rows.Add();

                if (listaMLATCalibrationVehicle[i].Code == 1e10) { dataGridView1.Rows[n].Cells[0].Value = "IGNORE"; } else { dataGridView1.Rows[n].Cells[0].Value = listaMLATCalibrationVehicle[i].Code.ToString(); }
                dataGridView1.Rows[n].Cells[1].Value = listaMLATCalibrationVehicle[i].Lat.ToString();
                dataGridView1.Rows[n].Cells[2].Value = listaMLATCalibrationVehicle[i].Lon.ToString();
                if (listaMLATCalibrationVehicle[i].Alt == 1e10) { dataGridView1.Rows[n].Cells[3].Value = "IGNORE"; } else { dataGridView1.Rows[n].Cells[3].Value = listaMLATCalibrationVehicle[i].Alt.ToString(); }
                if (listaMLATCalibrationVehicle[i].Day == 1e10) { dataGridView1.Rows[n].Cells[4].Value = "IGNORE"; } else { dataGridView1.Rows[n].Cells[4].Value = listaMLATCalibrationVehicle[i].Day.ToString() +"/"+ listaMLATCalibrationVehicle[i].Month.ToString() +"/"+ listaMLATCalibrationVehicle[i].Year.ToString(); }
                if (listaMLATCalibrationVehicle[i].Hour == 1e10) { dataGridView1.Rows[n].Cells[5].Value = "IGNORE"; } else { dataGridView1.Rows[n].Cells[5].Value = listaMLATCalibrationVehicle[i].Hour.ToString() + ":" + listaMLATCalibrationVehicle[i].Min.ToString() + ":" + listaMLATCalibrationVehicle[i].Sec.ToString(); }
            }

            Mapa.DragButton = MouseButtons.Left;
            Mapa.CanDragMap = true;
            Mapa.MapProvider = GMapProviders.GoogleMap;
            Mapa.Position = new PointLatLng(41.282576, 2.074278);
            Mapa.MinZoom = 6;
            Mapa.MaxZoom = 24;
            Mapa.Zoom = 14;
            Mapa.AutoScroll = true;

            GMapOverlay overlayLoad = new GMapOverlay();

            for(int i=0; i<listaMLATCalibrationVehicle.Count(); i++)
            {
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(listaMLATCalibrationVehicle[i].Lat, listaMLATCalibrationVehicle[i].Lon), green_pushback);
                marker.ToolTipText = listaMLATCalibrationVehicle[i].Hour.ToString() + " : " + listaMLATCalibrationVehicle[i].Min.ToString() + " : " + listaMLATCalibrationVehicle[i].Sec.ToString();

                overlayLoad.Markers.Add(marker);
            }

            Mapa.Overlays.Add(overlayLoad);
        }
    }
}
