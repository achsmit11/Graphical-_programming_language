using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphical_Programming_Language_Application
{
    class Polygon : Shape
    {
        int size1, size2, size3, size4, size5, size6, size7, size8, size9, size10;
        Color c1;
        int texturestyle;
        Brush bb;
        public override void draw(Graphics g)
        {
            Pen p = new Pen(c1, 5);
            Point[] points = { new Point(size1, size2), new Point(size3, size4), new Point(size5, size6), new Point(size7, size8), new Point(size9, size10) };

            if (texturestyle == 0)
            {
                g.DrawPolygon(p, points);
            }
            else
            {
                g.FillPolygon(bb, points);
            }
        }

        public override void set(int texturestyle, Brush bb, Color c1, params int[] list)
        {
            this.texturestyle = texturestyle;
            this.bb = bb;
            this.c1 = c1;
            this.size1 = list[0];
            this.size2 = list[1];
            this.size3 = list[2];
            this.size4 = list[3];
            this.size5 = list[4];
            this.size6 = list[5];
            this.size7 = list[6];
            this.size8 = list[7];
            this.size9 = list[8];
            this.size10 = list[9];
            
        }
    }
}
