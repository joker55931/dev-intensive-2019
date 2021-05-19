using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6._1
{
    public partial class Form1 : Form
    {
        Pen circlePen = new Pen(Color.Red, 2);
        Pen ff = new Pen(Color.DarkBlue,2);
        Point pointx = new Point(100, 250);
        Point pointy = new Point(400, 250);
        Point pointx1 = new Point(250, 100);
        Point pointy1 = new Point(250, 400);
        Point pointx2 = new Point(138, 365);
        Point pointy2 = new Point(355, 142);
        SolidBrush active  = new SolidBrush(Color.Green);
        SolidBrush colornew = new SolidBrush(Color.Black);
        SolidBrush colorIN = new SolidBrush(Color.White);
        Region regionBigEllipseResult;
        Region regionsmallEllipse;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Лабораторная работа №6";
        }

        private void Paint_Paint(object sender, PaintEventArgs e)
        {

        }

        

            public void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Rectangle ellipse_big = new Rectangle(175,175,150,150);
            Rectangle ellipse_small = new Rectangle(250, 213, 75, 75);
            Rectangle rect = new Rectangle(250, 175, 75, 75);
            Rectangle defill1 = new Rectangle(175,175,75,150);
            Rectangle defill2 = new Rectangle(175, 250, 150, 75);



            ff.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            gr.DrawRectangle(ff, rect);

            GraphicsPath ell_big = new GraphicsPath();
            ell_big.AddEllipse(ellipse_big);
            GraphicsPath ell_small = new GraphicsPath();
            ell_small.AddEllipse(ellipse_small);
            GraphicsPath rect_1 = new GraphicsPath();
            rect_1.AddRectangle(rect);

            Region regionBigEllipse = new Region(ell_big);
            regionsmallEllipse = new Region(ell_small);
            Region regionRect = new Region(rect_1);

            regionBigEllipseResult = new Region(ell_big);

            //треугольник
            Point point1 = new Point(250, 250);
            Point point2 = new Point(325, 250);
            Point point3 = new Point(325, 175);
            Point[] points = { point1, point2, point3 };

            GraphicsPath ppp = new GraphicsPath();
            ppp.AddPolygon(points);
            Region Polygone = new Region();


            Point point4 = new Point(250, 250);
            Point point5 = new Point(250, 175);
            Point point6 = new Point(325, 175);
            Point[] points1 = { point4, point5, point6 };

            GraphicsPath ppp1 = new GraphicsPath();
            ppp1.AddPolygon(points1);
            Region Polygone1 = new Region();

            regionBigEllipseResult.Exclude(regionsmallEllipse);
            regionBigEllipseResult.Exclude(defill2);
            regionBigEllipseResult.Exclude(defill1);
            regionBigEllipseResult.Exclude(ppp);
            //regionBigEllipseResult.Union(regionRect);

            regionsmallEllipse.Union(regionBigEllipseResult);
            regionsmallEllipse.Exclude(defill2);
            regionsmallEllipse.Exclude(ppp1);
            //gr.DrawPolygon(ff, points);

            

            //gr.DrawEllipse(circlePen,x,y,ww,hh);
            //gr.DrawEllipse(circlePen, x+75, y+38, ww/2, hh/2);


            gr.DrawRectangle(ff, rect);
            gr.DrawEllipse(circlePen, ellipse_big);
            gr.DrawEllipse(circlePen, ellipse_small);

            gr.DrawLine(circlePen,pointx,pointy);
            gr.DrawLine(circlePen, pointx1, pointy1);
            gr.DrawLine(circlePen, pointx2, pointy2);
            //gr.DrawRectangle(ff, defill1);
            //gr.DrawRectangle(ff, defill2);
            gr.FillRegion(active, regionBigEllipseResult);
            gr.FillRegion(active, regionsmallEllipse);
            //gr.DrawPolygon(Pens.Gray, points1);
        }

        private void Color_Change_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
           // dlg.Color = colorDialog2.Color;
            dlg.ShowHelp = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                
                
                active.Color = dlg.Color;
                
                colornew.Color = dlg.Color;
            }
        }

        private void Color_in_Click(object sender, EventArgs e)
        {
            ColorDialog dlg2 = new ColorDialog();
            dlg2.FullOpen = true;
            // dlg.Color = colorDialog2.Color;
            dlg2.ShowHelp = true;
            if (dlg2.ShowDialog() == DialogResult.OK)
            {


                colorIN.Color = dlg2.Color;
            }
        }

        public void Form1_MouseMove(object sender, MouseEventArgs e)
          {
            int X = e.X;
            int Y = e.Y;
            Brush old  =  active;

            if (regionBigEllipseResult.IsVisible(X,Y) || (regionsmallEllipse.IsVisible(X,Y)))
            {
                active.Color = colorIN.Color;
            }
            else
            {
                active.Color = colornew.Color;
            }
                Invalidate();
                
            

           }

    }
           

}
