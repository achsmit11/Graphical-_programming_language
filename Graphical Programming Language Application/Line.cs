using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphical_Programming_Language_Application
{
    class Line : Shape
    {
        /// <summary>
        /// geting value for drawing line
        /// </summary>
        int x, y, size, size1;
        Color c1;
        int texturestyle;
        Brush bb;
        public override void draw(Graphics g)
        {
            Pen p = new Pen(c1, 5);
            if (texturestyle == 0)
            {
                g.DrawLine(p, x, y, size, size1);
            }
            else
            {
                g.DrawLine(p, x, y, size, size1);
            }
            
            
            
            
        }


        /// <summary>
        /// geting value to draw line
        /// 
        /// </summary>
        /// <param name="texturestyle"></param>
        /// texture for the design pattern 
        /// <param name="bb"></param>
        /// <param name="c1"></param>
        /// <param name="list"></param>
        public override void set(int texturestyle, Brush bb, Color c1, params int[] list)
        {
            this.texturestyle = texturestyle;
            this.bb = bb;
            this.c1 = c1;
            this.x = list[0];
            this.y = list[1];
            this.size = list[2];
            this.size1 = list[3];
        }
    }
}
