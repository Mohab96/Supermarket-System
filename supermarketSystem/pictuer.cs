using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;


namespace supermarketSystem
{
    class pictuer : PictureBox
    {
        private int bordersize = 2;
        private Color bordercolor = Color.RoyalBlue;
        private Color bordercolor2 = Color.HotPink;
        private DashStyle borderlinestyle = DashStyle.Solid;
        private DashCap bordercapstyle = DashCap.Flat;
        private float gradientangle = 50F;

        public pictuer()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        public int Bordersize
        {
            get
            {
                return bordersize;
            }
            set
            {
                bordersize = value;
                this.Invalidate();
            }
        }
        public Color Bordercolor
        {
            get
            {
                return bordercolor;

            }
            set
            {
                bordercolor = value;
                this.Invalidate();
            }
        }
        public Color Bordercolor2
        {
            get
            {
                return bordercolor2;

            }
            set
            {
                bordercolor2 = value;
                this.Invalidate();
            }
        }
        public DashStyle Borderlinestyle
        {
            get
            {
                return borderlinestyle;
            }
            set
            {
                borderlinestyle = value;
                this.Invalidate();
            }
        }
        public DashCap Bordcapstyle
        {
            get
            {
                return bordercapstyle;
            }
            set
            {
                bordercapstyle = value;
                this.Invalidate();
            }
        }
        public float GradientAngle
        {
            get
            {
                return gradientangle;
            }
            set
            {
                gradientangle = value;
                this.Invalidate();
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Height);

        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -bordersize, -bordersize);
            var smoothSize = bordersize > 0 ? bordersize * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBorder, bordercolor, bordercolor2, gradientangle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(this.Parent.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, bordersize))
            {

                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderlinestyle;
                penBorder.DashCap = bordercapstyle;
                pathRegion.AddEllipse(rectContourSmooth);
                //Set rounded region 
                this.Region = new Region(pathRegion);
                //Drawing
                graph.DrawEllipse(penSmooth, rectContourSmooth);//Draw contour smoothing
                if (bordersize > 0) //Draw border
                    graph.DrawEllipse(penBorder, rectBorder);
            }




        }
    }
}
