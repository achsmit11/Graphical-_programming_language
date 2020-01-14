using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphical_Programming_Language_Application
{
    public partial class Console : Form
    {
        public Console()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_console.Text = "";
        }

        //public double x, y, h, w, r;



        private void txt_console_TextChanged(object sender, EventArgs e)
        {
            //------------rectangle-------------- -
            Regex rect_regex = new Regex(@"rectangle ([\d])([,])([\d])");
            Regex circle_regex = new Regex(@"circle ([\d])");

            Match match = rect_regex.Match(txt_console.Text);
            Match match1 = circle_regex.Match(txt_console.Text);
            if (match.Success)
            {

                //h = double.Parse(match.Groups[1].Value);
                //w = double.Parse(match.Groups[3].Value);
                //Shapefactory shapefactory = new Shapefactory();
                //Shape c = Shapefactory.GetShape("rectangle");
                //c.draw(10,20, 20, 20);

                //-------------------------------------------------------------------------------------

                //-----------------------------------------------------------------------------------------

                MessageBox.Show("this is successfull pattern rectangle");

            }
            




        }
    }


    //------------------------------------------------------
    

}
