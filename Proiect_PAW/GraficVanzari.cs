using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class GraficVanzari : Form
    {

        int nrobs;
        float[] x, y;

    

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle zonaClient = e.ClipRectangle;

            Brush fundal = new SolidBrush(Color.White); 
            g.FillRectangle(fundal, zonaClient);

            zonaClient.X += 20;
            zonaClient.Y += 20;
            zonaClient.Height -= 40;
            zonaClient.Width -= 40;

            Pen creionRosu = new Pen(Color.Red, 2); 
            g.DrawRectangle(creionRosu, zonaClient);

            int i;
            int vl = zonaClient.Left;
            int vb = zonaClient.Bottom;
            int vr = zonaClient.Right;
            int vt = zonaClient.Top;

            float rap_dist_lat = 0.2f, max;

            SolidBrush[] pensule = new SolidBrush[] {
                   new SolidBrush(Color.Pink),
                   new SolidBrush(Color.RoyalBlue),
                   new SolidBrush(Color.Moccasin),
                   new SolidBrush(Color.LightCoral),
                   new SolidBrush(Color.LawnGreen),
                   new SolidBrush(Color.LightBlue)
                   };
            Pen[] creioane = new Pen[]
            {
                new Pen(Color.Red),
                new Pen(Color.Green),
                new Pen(Color.Yellow),
                new Pen(Color.Cyan),
                new Pen(Color.Fuchsia),
                new Pen(Color.Magenta)
            };


            SolidBrush pnsCrt;
            Pen penCrt;

            int lat = (vr - vl) / (int)((nrobs + 1) * rap_dist_lat + nrobs);

            int dist = (int)(lat * rap_dist_lat);

            for (max = y[0], i = 1; i < nrobs; i++)
                if (max < y[i]) max = y[i];

            penCrt = creioane[0];
            pnsCrt = pensule[0];

            g.DrawLine(penCrt, vl, vt, vl, vb);
            g.DrawLine(penCrt, vl, vb, vr, vb);

            penCrt = creioane[1];
            for (i = 0; i < nrobs; i++)
            {
                pnsCrt = pensule[i % 6]; 
                PointF pnt = new PointF(vl + dist + i * (lat + dist), vb - y[i] * (vb - vt) / max);
                SizeF sz = new SizeF(lat, y[i] * (vb - vt) / max);
                g.FillRectangle(pnsCrt, new RectangleF(pnt, sz));
                textBox1.Text += "\r\n(" + Math.Round(pnt.X, 2) + ", " + Math.Round(pnt.Y, 2) + ")-->" +
                    Math.Round(sz.Width, 2) + ", " + Math.Round(sz.Height, 2);
                string den = x[i].ToString();
                g.DrawString(den, Font, pnsCrt, vl + dist + lat / 2 + i * (lat + dist), vb + 5);
            }

            textBox1.Text += "\r\n";
        }

        private void panel2_Resize_1(object sender, EventArgs e)
        {

        }

        public GraficVanzari()
        {
            InitializeComponent();
            nrobs = 12;
            x = new float[] { 1f, 2f, 3f, 4f, 5f, 6f, 7f, 8f, 9f, 10f, 11f, 12f };
            y = new float[] { 456780f, 468020f, 597310f, 278320f, 967560f, 564380f, 947230f, 887510f, 190000f, 675590f, 129970f, 339860f};
            
            this.ResizeRedraw = true;
        }
    }
}
