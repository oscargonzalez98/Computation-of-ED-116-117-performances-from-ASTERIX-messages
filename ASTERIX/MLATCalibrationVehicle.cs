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

                if (listaMLATCalibrationVehicle[i].cosa0 == 0) { dataGridView1.Rows[n].Cells[0].Value = "IGNORE"; } else { dataGridView1.Rows[n].Cells[0].Value = listaMLATCalibrationVehicle[i].cosa0.ToString(); }
                dataGridView1.Rows[n].Cells[1].Value = listaMLATCalibrationVehicle[i].cosa1.ToString();
                dataGridView1.Rows[n].Cells[2].Value = listaMLATCalibrationVehicle[i].cosa2.ToString();
                if (listaMLATCalibrationVehicle[i].cosa3 == 0) { dataGridView1.Rows[n].Cells[3].Value = "IGNORE"; } else { dataGridView1.Rows[n].Cells[3].Value = listaMLATCalibrationVehicle[i].cosa3.ToString(); }
                if (listaMLATCalibrationVehicle[i].cosa4 == 0) { dataGridView1.Rows[n].Cells[4].Value = "IGNORE"; } else { dataGridView1.Rows[n].Cells[4].Value = listaMLATCalibrationVehicle[i].cosa4.ToString() +"/"+ listaMLATCalibrationVehicle[i].cosa5.ToString() +"/"+ listaMLATCalibrationVehicle[i].cosa6.ToString(); }
                if (listaMLATCalibrationVehicle[i].cosa7 == 0) { dataGridView1.Rows[n].Cells[5].Value = "IGNORE"; } else { dataGridView1.Rows[n].Cells[5].Value = listaMLATCalibrationVehicle[i].cosa7.ToString() + ":" + listaMLATCalibrationVehicle[i].cosa8.ToString() + ":" + listaMLATCalibrationVehicle[i].cosa9.ToString(); }
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
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(listaMLATCalibrationVehicle[i].cosa1, listaMLATCalibrationVehicle[i].cosa2), green_pushback);
                overlayLoad.Markers.Add(marker);
            }

            Mapa.Overlays.Add(overlayLoad);
        }
    }
}
