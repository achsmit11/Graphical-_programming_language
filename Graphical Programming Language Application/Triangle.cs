using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphical_Programming_Language_Application
{
    class Triangle : Shape
    {
        int xi1, yi1, xi2, yi2, xii1, yii1, xii2, yii2, xiii1, yiii1, xiii2, yiii2;
        Color c1;
        int texturestyle;
        Brush bb;
        public override void draw(Graphics g)
        {
            Pen p = new Pen(c1, 5);

            //----------------------------------------------------------------------------------------------------------------------
            g.DrawLine(p, xi1, yi1, xi2, yi2);
            g.DrawLine(p, xii1, yii1, xii2, yii2);
            g.DrawLine(p, xiii1, yiii1, xiii2, yiii2);
            //---------------------------------------------------------------------------------------------------------------------

            
        }
        /// <summary>
        /// geting value of coordinates to draw triangle
        /// </summary>
        /// <param name="texturestyle"></param>
        /// <param name="bb"></param>
        /// <param name="c1"></param>
        /// <param name="list"></param>
        public override void set(int texturestyle, Brush bb, Color c1, params int[] list)
        {
            //_size1, _size2, xi1,yi1,xi2,yi2,xii1,yii1,xii2,yii2,xiii1,yiii1,xiii2,yiii2
            this.texturestyle = texturestyle;
            this.bb = bb;
            this.c1 = c1;
            
            this.xi1    = list[0];
            this.yi1    = list[1];
            this.xi2    = list[2];
            this.yi2    = list[3];

            this.xii1   = list[4];
            this.yii1   = list[5];
            this.xii2   = list[6];
            this.yii2   = list[7];

            this.xiii1  = list[8];
            this.yiii1  = list[9];
            this.xiii2  = list[10];
            this.yiii2  = list[11];
        }
    }
}
