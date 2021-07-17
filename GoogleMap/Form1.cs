using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMap
{
    public partial class GoogleMap : Form
    {
        public GoogleMap()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Right;//for moving mouse for clicking right button
            map.MapProvider = GMapProviders.GoogleMap;// we can also use any kind of map like bingmap 
            double latitude = Convert.ToDouble(txtLatitude.Text);
            double longitude = Convert.ToDouble(txtLongitude.Text);
            map.Position = new PointLatLng(latitude,longitude);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;//current zoom level
        }
    }
}
