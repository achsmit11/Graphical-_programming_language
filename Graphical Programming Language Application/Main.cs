using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphical_Programming_Language_Application
{
    public partial class Main : Form
    {
        private bool mousedown;
        private Point lastlocation;
        
        int texturestyle = 0;

        int selectshape = 0;

        /// <summary>
        /// for system color dialog box
        /// </summary>
        Color paintcolor = Color.Black;

        Graphics g;
        Pen p;
        Brush bb;
        int x, y = 0;
        int x1,y1,x2,y2 = 0;


        public Main()
        {
            InitializeComponent();
            g = drawareapanel.CreateGraphics();
            p = new Pen(showcolorbox.BackColor);

            int x_canvas = drawareapanel.Width / 2;
            int y_canvas = drawareapanel.Height / 2;
            lbl_StartPosX.Text = x_canvas.ToString();
            lbl_StartPosY.Text = y_canvas.ToString();
            lbl_canvasx.Text = x_canvas.ToString();
            lbl_canvasy.Text = y_canvas.ToString();

            
            bb = new HatchBrush(HatchStyle.Vertical, Color.Red, Color.FromArgb(255, 128, 255, 255));
            g.FillEllipse(bb, 0, 0, 100, 60);


        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// to minimize the windows form from miniize button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        

        

        
        /// <summary>
        /// to show the color dialog box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void draw(object sender, PaintEventArgs e)
        {
            

        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            lastlocation = e.Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                this.Location = new Point(
                    (this.Location.X - lastlocation.X) + e.X, (this.Location.Y - lastlocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;

        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            drawareapanel.Refresh();
            this.drawareapanel.BackgroundImage = null;
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        bool start;

        private void drawareapanel_MouseDown(object sender, MouseEventArgs e)
        {
            start = true;
            x1 = e.X;
            y1 = e.Y;
        }

        private void drawareapanel_MouseLeave(object sender, EventArgs e)
        {
            start = false;
            x = 0;
            y = 0;
            

        }
        
        private void drawareapanel_MouseMove(object sender, MouseEventArgs e)
        {
            
            lbl_cursorx.Text = e.X.ToString();
            lbl_cursory.Text = e.Y.ToString();
            if (start)
            {
                if (selectshape == 1)
                {
                    if (x > 0 && y > 00)
                    {
                        g.DrawLine(p, x, y, e.X, e.Y);
                    }

                    x = e.X;
                    y = e.Y;
                }
                else if (selectshape == 2)
                {
                    //g.DrawRectangle(p, Math.Min(e.X,x1), Math.Min(e.Y, y1),Math.Abs(e.X-x1), Math.Abs(e.Y - y1));

                    //if (x>0 && y>0)
                    //{
                    //    g.DrawRectangle(p, x1, y1, x3, y3);
                    //}

                    //Invalidate();
                    if (x > 0 && y > 00)
                    {

                        g.FillRectangle(new SolidBrush(paintcolor), x1, y1, e.X - x1, e.Y - y1);
                    }

                    x = e.X;
                    y = e.Y;
                }
                else if (selectshape == 4)
                {

                    
                    if (x > 0 && y > 00)
                    {
                        g.FillEllipse(new SolidBrush(paintcolor),e.X, e.Y, 40, 50);
                    }
                    

                    x = e.X;
                    y = e.Y;
                }

                
            }
        }

        private void drawareapanel_MouseUp(object sender, MouseEventArgs e)
        {
            start = false;
            x = 0;
            y = 0;
            
            x2 = e.X;
            y2 = e.Y;


        }

        private void showcolorbox_Click(object sender, EventArgs e)
        {
            texturestyle = 0;
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            paintcolor = c.Color;

            showcolorbox.BackColor = paintcolor;
            p.Color = c.Color;

            //------------------
            
            //-----------------
            //HatchBrush hBrush = new HatchBrush(HatchStyle.Horizontal, Color.Red, Color.FromArgb(255, 128, 255, 255));
            //hBrush.HatchStyle = showtexturebox.BackColor;
            
            //------------------
        }

        private void txt_console1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_console1clear_Click(object sender, EventArgs e)
        {
            rtxt_console.Text = "";
            Graphics g1 = drawareapanel.CreateGraphics();
            g1.Clear(drawareapanel.BackColor);
            rtxt_errors.Text = "";
            rtxt_history.Text = "";
        }

        

        private void btn_square_Click(object sender, EventArgs e)
        {
            selectshape = 3;
        }

        private void btn_elipse_Click(object sender, EventArgs e)
        {
            selectshape =4;
        }

        private void btn_triangle_Click(object sender, EventArgs e)
        {
            selectshape = 5;
        }

        private void btn_polygon_Click(object sender, EventArgs e)
        {
            selectshape = 6;
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            selectshape = 2;
        }

        private void btn_pen_Click(object sender, EventArgs e)
        {
            selectshape = 1;
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "PNG Files|*.png|JPEG Files|*.jpeg|Bitmap|*.bmp";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                drawareapanel.BackgroundImage = (Image)Image.FromFile(o.FileName).Clone();
                drawareapanel.BackgroundImageLayout = ImageLayout.Zoom;
            }
            MessageBox.Show("open");
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Bitmap bmp = new Bitmap(drawareapanel.Width, drawareapanel.Height);
            ////Graphics g = Graphics.FromImage(bmp);
            ////Rectangle rect = drawareapanel.RectangleToScreen(drawareapanel.ClientRectangle);
            ////g.CopyFromScreen(rect.Location, Point.Empty, drawareapanel.Size);
            ////g.Dispose();

            //SaveFileDialog s = new SaveFileDialog();
            //s.Filter = "PNG Files|*.png|JPEG Files|*.jpeg|Bitmap|*.bmp";
            //if (s.ShowDialog() == DialogResult.OK)
            //{

            //    if (s.FileName.Contains(".jpg"))
            //    {
            //        bmp.Save(s.FileName, ImageFormat.Jpeg);
            //    }
            //    else if (s.FileName.Contains(".png"))
            //    {
            //        bmp.Save(s.FileName, ImageFormat.Png);
            //    }
            //    else if (s.FileName.Contains(".bmp"))
            //    {
            //        bmp.Save(s.FileName, ImageFormat.Bmp);
            //    }
            //}

            //----------------------------
            SaveFileDialog sfdlg = new SaveFileDialog();
            sfdlg.Title = "Save Dialog";
            sfdlg.Filter = "Bitmap Images (*.bmp)|*.bmp|All files(*.*)|*.*";
            if (sfdlg.ShowDialog(this) == DialogResult.OK)
            {
                using (Bitmap bmp = new Bitmap(drawareapanel.Width, drawareapanel.Height))
                {

                    //drawareapanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    drawareapanel.Image = new Bitmap(drawareapanel.Width, drawareapanel.Height);
                    drawareapanel.Image.Save(sfdlg.FileName);
                    bmp.Save(sfdlg.FileName);
                    MessageBox.Show("Saved Successfully.....");

                }
            }
            //-----------
            //rtxt_console.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
            //-----------------------------
        }

        private void openTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                rtxt_console.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
                this.Text = op.FileName;
            }

        }


        private void showtexturebox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please click on Texture Tab.");
        }

        private void saveTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                rtxt_console.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
                this.Text = sv.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                rtxt_console.SaveFile(sv.FileName,RichTextBoxStreamType.PlainText);
                this.Text = sv.FileName;
            }
        }

        

        private void lbl_canvasx_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_canvasy_Click(object sender, EventArgs e)
        {

        }


        private void texture5_Click(object sender, EventArgs e)
        {
            texturestyle = 5;
            bb = new HatchBrush(HatchStyle.Vertical, Color.Red, Color.Yellow);
            //showtexturebox.BackgroundImage = texture5.BackgroundImage;
        }

        private void texture4_Click(object sender, EventArgs e)
        {
            texturestyle = 4;
            bb = new HatchBrush(HatchStyle.Horizontal, Color.Red, Color.Yellow);
          //  showtexturebox.BackgroundImage = texture4.BackgroundImage;
        }

        private void texture3_Click(object sender, EventArgs e)
        {
            bb = new HatchBrush(HatchStyle.ForwardDiagonal, Color.Red, Color.Yellow);
            texturestyle = 3;
           // showtexturebox.BackgroundImage = texture3.BackgroundImage;
        }

        private void texture2_Click(object sender, EventArgs e)
        {
            bb = new HatchBrush(HatchStyle.DiagonalCross, Color.Red, Color.Yellow);
            texturestyle = 2;
            //showtexturebox.BackgroundImage = texture2.BackgroundImage;
        }

        private void texture1_Click(object sender, EventArgs e)
        {
            texturestyle = 1;
            bb = new HatchBrush(HatchStyle.Cross, Color.Red, Color.Yellow);
           // showtexturebox.BackgroundImage = texture1.BackgroundImage;
        }

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //==============================================================================================================
        //======================-----=====----======================DECLARING =========================---------- *  *  * * * * ** * 
        public int _size1, _size2, _size3, _size4, _size5, _size6, _size7, _size8, _size9, _size10, _size11, _size12;

        private void lbl_StartPosY_Click(object sender, EventArgs e)
        {

        }

        private void lbl_appname_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void drawareapanel_MouseClick(object sender, MouseEventArgs e)
        {
            lbl_StartPosX.Text = (e.X).ToString();
            lbl_StartPosY.Text = (e.Y).ToString();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// declaring variable for triangle
        /// </summary>
        public int xi1, yi1, xi2, yi2, xii1, yii1, xii2, yii2, xiii1, yiii1, xiii2, yiii2;
        /// <summary>
        /// declaring variable for repeat number
        /// </summary>
        public int _repeatNo;
        private void btn_consolerun_Click(object sender, EventArgs e)
        {

            Regex regex1 = new Regex(@"drawto (.*[\d])([,])(.*[\d]) line (.*[\d])([,])(.*[\d])");
            Regex regex2 = new Regex(@"drawto (.*[\d])([,])(.*[\d]) rectangle (.*[\d])([,])(.*[\d])");
            Regex regex3 = new Regex(@"drawto (.*[\d])([,])(.*[\d]) circle (.*[\d])");
            Regex regex4 = new Regex(@"drawto (.*[\d])([,])(.*[\d]) triangle (.*[\d])([,])(.*[\d])([,])(.*[\d])");
            Regex regex5 = new Regex(@"drawto (.*[\d])([,])(.*[\d]) polygon point2 (.*[\d])([,])(.*[\d]) point3 (.*[\d])([,])(.*[\d]) point4 (.*[\d])([,])(.*[\d]) point5 (.*[\d])([,])(.*[\d])");
            //------------------------------------------------------------------------------------------1,3,4,6,7,9,10,12,13,15,16,18
            

            Regex regexClear = new Regex(@"clear board");
            Regex regexMT = new Regex(@"moveto (.*[\d])([,])(.*[\d])");
            
            Regex regexR = new Regex(@"rectangle (.*[\d])([,])(.*[\d])");
            Regex regexC = new Regex(@"circle (.*[\d])");
            Regex regexT = new Regex(@"triangle (.*[\d])([,])(.*[\d])([,])(.*[\d])");

            Regex regexRepeat = new Regex(@"repeat (.*[\d])");

            Regex regexIfelse = new Regex(@"if drawto x= (.*[\d]) >= 0 or y= (.*[\d]) >= 0 ");
            //if drawto x= 9 >= 0 or y= 19 >= 0
            //----------------------------------------------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------------------------------------------
            Match match1 = regex1.Match(rtxt_console.Text.ToLower());
            Match match2 = regex2.Match(rtxt_console.Text.ToLower());
            Match match3 = regex3.Match(rtxt_console.Text.ToLower());
            Match match4 = regex4.Match(rtxt_console.Text.ToLower());
            Match match5 = regex5.Match(rtxt_console.Text.ToLower());

            Match matchClear = regexClear.Match(rtxt_console.Text.ToLower());
            Match matchMT = regexMT.Match(rtxt_console.Text.ToLower());

            Match matchR = regexR.Match(rtxt_console.Text.ToLower());
            Match matchC = regexC.Match(rtxt_console.Text.ToLower());
            Match matchT = regexT.Match(rtxt_console.Text.ToLower());

            Match matchRepeat = regexRepeat.Match(rtxt_console.Text.ToLower());

            Match matchIfelse = regexIfelse.Match(rtxt_console.Text.ToLower());
            //============================== DRAWING LINE =========================================
            if (match1.Success)
            {
                try
                {
                    g = drawareapanel.CreateGraphics();
                    _size1 = int.Parse(match1.Groups[1].Value);
                    _size2 = int.Parse(match1.Groups[3].Value);
                    _size3 = int.Parse(match1.Groups[4].Value);
                    _size4 = int.Parse(match1.Groups[6].Value);
                    
                    
                    ShapeFactory shapeFactory = new ShapeFactory();
                    Shape c = shapeFactory.GetShape("line");
                    c.set(texturestyle, bb, paintcolor, _size1, _size2, _size3, _size4);
                    c.draw(g);
                }
                catch (Exception ex)
                {
                    rtxt_errors.AppendText(ex.Message + Environment.NewLine);
                    //MessageBox.Show(ex.Message);
                }

            }
            //=============================== RECTANGLE with DrawTo ====================================================
            else if (match2.Success)
            {
                try
                {
                    g = drawareapanel.CreateGraphics();
                    _size1 = int.Parse(match2.Groups[1].Value);
                    _size2 = int.Parse(match2.Groups[3].Value);
                    _size3 = int.Parse(match2.Groups[4].Value);
                    _size4 = int.Parse(match2.Groups[6].Value);

                    
                
                    ShapeFactory shapeFactory = new ShapeFactory();
                    Shape c = shapeFactory.GetShape("rectangle"); 
                    
                    c.set(texturestyle, bb, paintcolor, _size1, _size2, _size3, _size4);
                    c.draw(g);

                }
                catch (Exception ex)
                {
                    rtxt_errors.AppendText(ex.Message + Environment.NewLine);
                    //MessageBox.Show(ex.Message);
                }
            }

            //=================================== RECTANGLE ==============================================================
            else if (matchR.Success)
            {
                try
                {
                    g = drawareapanel.CreateGraphics();
                    _size1 = int.Parse(lbl_StartPosX.Text);
                    _size2 = int.Parse(lbl_StartPosY.Text);
                    _size3 = int.Parse(matchR.Groups[1].Value);
                    _size4 = int.Parse(matchR.Groups[3].Value);
                    
                    ShapeFactory shapeFactory = new ShapeFactory();
                    Shape c = shapeFactory.GetShape("rectangle"); 
                    c.set(texturestyle, bb, paintcolor, _size1, _size2, _size3, _size4);

                    c.draw(g);
                }
                catch (Exception ex)
                {
                    rtxt_errors.AppendText(ex.Message + Environment.NewLine);
                }
            }
            
            //================================== CIRCLE with Drawto ======================================
            else if (match3.Success)
            {
                try
                {
                    g = drawareapanel.CreateGraphics();
                    _size1 = int.Parse(match3.Groups[1].Value);
                    _size2 = int.Parse(match3.Groups[3].Value);
                    _size3 = int.Parse(match3.Groups[4].Value);
                
                    ShapeFactory shapeFactory = new ShapeFactory();
                    Shape c = shapeFactory.GetShape("circle"); 
                    c.set(texturestyle, bb, paintcolor, _size1, _size2, _size3 * 2, _size3 * 2);
                    c.draw(g);
                }
                catch (Exception ex)
                {
                    rtxt_errors.AppendText(ex.Message + Environment.NewLine);
                }
            }

            //=========================================== Circle =======================================================
            else if (matchC.Success)
            {
                try
                {
                    g = drawareapanel.CreateGraphics();
                    _size1 = int.Parse(lbl_StartPosX.Text);
                    _size2 = int.Parse(lbl_StartPosY.Text);
                    _size3 = int.Parse(matchC.Groups[1].Value);


                    ShapeFactory shapeFactory = new ShapeFactory();
                    Shape c = shapeFactory.GetShape("circle"); 
                    c.set(texturestyle, bb, paintcolor, _size1, _size2, _size3 * 2, _size3 * 2);
                    //c.draw(set);
                    c.draw(g);
                }
                catch (Exception ex)
                {
                    rtxt_errors.AppendText(ex.Message + Environment.NewLine);
                    // MessageBox.Show(ex.Message);
                }
            }

            //====================================================================================================

            //==================================== TRIANGLE with DrawTo ===================================================
            else if (match4.Success)
            {
                try
                {
                    g = drawareapanel.CreateGraphics();
                    _size1 = int.Parse(match4.Groups[1].Value);
                    _size2 = int.Parse(match4.Groups[3].Value);

                    _size3 = int.Parse(match4.Groups[4].Value);
                    _size4 = int.Parse(match4.Groups[6].Value);
                    _size5 = int.Parse(match4.Groups[8].Value);


                    xi1 = _size1;
                    yi1 = _size2;
                    xi2 = Math.Abs(_size3);
                    yi2 = _size2;

                    xii1 = _size1;
                    yii1 = _size2;
                    xii2 = _size1;
                    yii2 = Math.Abs(_size4);

                    xiii1 = Math.Abs(_size3);
                    yiii1 = _size2;
                    xiii2 = _size1;
                    yiii2 = Math.Abs(_size4);

                    ShapeFactory shapeFactory = new ShapeFactory();
                    Shape c = shapeFactory.GetShape("triangle");
                    c.set(texturestyle, bb, paintcolor, xi1,yi1,xi2,yi2,xii1,yii1,xii2,yii2,xiii1,yiii1,xiii2,yiii2);
                    //=============================== 
                    c.draw(g);
                }
                catch (Exception ex)
                {
                    rtxt_errors.AppendText(ex.Message + Environment.NewLine);
                }
            }

            //==================================================== Triangle =====================================================
            else if (matchT.Success)
            {
                try
                {
                    g = drawareapanel.CreateGraphics();
                    _size1 = int.Parse(lbl_StartPosX.Text);
                    _size2 = int.Parse(lbl_StartPosY.Text);

                    _size3 = int.Parse(matchT.Groups[1].Value);
                    _size4 = int.Parse(matchT.Groups[3].Value);
                    _size5 = int.Parse(matchT.Groups[5].Value);


                    xi1 = _size1;
                    yi1 = _size2;
                    xi2 = Math.Abs(_size3);
                    yi2 = _size2;

                    xii1 = _size1;
                    yii1 = _size2;
                    xii2 = _size1;
                    yii2 = Math.Abs(_size4);

                    xiii1 = Math.Abs(_size3);
                    yiii1 = _size2;
                    xiii2 = _size1;
                    yiii2 = Math.Abs(_size4);

                    ShapeFactory shapeFactory = new ShapeFactory();
                    Shape c = shapeFactory.GetShape("triangle"); //new rectangles();
                    c.set(texturestyle, bb, paintcolor, xi1, yi1, xi2, yi2, xii1, yii1, xii2, yii2, xiii1, yiii1, xiii2, yiii2);
                    c.draw(g);
                }
                catch (Exception ex)
                {
                    rtxt_errors.AppendText(ex.Message + Environment.NewLine);
                }
            }

            //================================================= POLYGON ==============================================================

            if (match5.Success)
            {
                try
                {
                    //1,3,4,6,7,9,10,12,13,15,16,18
                    g = drawareapanel.CreateGraphics();
                    _size1 = int.Parse(match5.Groups[1].Value);
                    _size2 = int.Parse(match5.Groups[3].Value);
                    _size3 = int.Parse(match5.Groups[4].Value);
                    _size4 = int.Parse(match5.Groups[6].Value);
                    _size5 = int.Parse(match5.Groups[7].Value);
                    _size6 = int.Parse(match5.Groups[9].Value);
                    _size7 = int.Parse(match5.Groups[10].Value);
                    _size8 = int.Parse(match5.Groups[12].Value);
                    _size9 = int.Parse(match5.Groups[13].Value);
                    _size10 = int.Parse(match5.Groups[15].Value);
                    
                    ShapeFactory shapeFactory = new ShapeFactory();
                    Shape c = shapeFactory.GetShape("polygon");
                    c.set(texturestyle, bb, paintcolor, _size1, _size2, _size3, _size4, _size5, _size6, _size7, _size8, _size9, _size10);
                    c.draw(g);
                }
                catch (Exception ex)
                {
                    rtxt_errors.AppendText(ex.Message + Environment.NewLine);
                    //MessageBox.Show(ex.Message);
                }

            }

            //================================================ CLEAR BOARD ====================================================================

            else if(matchClear.Success)
            {
                drawareapanel.Refresh();
                this.drawareapanel.BackgroundImage = null;
            }

            //================================================= MOVETO ==========================================================
            else if (matchMT.Success)
            {
                try
                {
                    _size1 = int.Parse(matchMT.Groups[1].Value);
                    _size2 = int.Parse(matchMT.Groups[3].Value);

                    lbl_StartPosX.Text = _size1.ToString();
                    lbl_StartPosY.Text = _size2.ToString();
                }
                catch (Exception ex)
                {
                    rtxt_errors.AppendText(ex.Message + Environment.NewLine);
                    //MessageBox.Show(ex.Message);
                }

            }

            //======================================================== REPEAT ====================================================
            else if(matchRepeat.Success)
            {
                try
                {
                    _repeatNo = int.Parse(matchRepeat.Groups[1].Value);

                    //=================================================== Repeat Shapes ====================================

                    //Regex regexRepCircle = new Regex(@"circle radius (.*[\d]) by radius (.*[\d]) end");
                    Regex regexRepCircle = new Regex(@"circle radius (.*[\d]) by (.*[\d]) end");
                    //repeat 4 circle radius 30 by 20 end
                    Regex regexRepRectangle = new Regex(@"rectangle width (.*[\d]) height (.*[\d]) by width (.*[\d]) height (.*[\d]) end");
                    //repeat 4 rectangle width 90 height 120 by width 20 height 20


                    Match matchRepCircle = regexRepCircle.Match(rtxt_console.Text.ToLower());
                    Match matchRepRectangle = regexRepRectangle.Match(rtxt_console.Text.ToLower());

                    //================================================== Repeat Circle ================================================
                    if (matchRepCircle.Success)
                    {

                        int _repeatAdd = 0;
                        int _repeatAddConstant;
                        _size1 = int.Parse(lbl_StartPosX.Text);
                        _size2 = int.Parse(lbl_StartPosY.Text);
                        _size3 = int.Parse(matchRepCircle.Groups[1].Value);
                        _repeatAdd = int.Parse(matchRepCircle.Groups[2].Value);
                        _repeatAddConstant = int.Parse(matchRepCircle.Groups[2].Value);
                        
                        ShapeFactory shapeFactory = new ShapeFactory();
                        Shape c = shapeFactory.GetShape("circle");

                        for (int i = 0; i < _repeatNo; i++)
                        {

                            c.set(texturestyle, bb, paintcolor, _size1, _size2, (_size3 + _repeatAdd), (_size3 + _repeatAdd));
                            c.draw(g);
                            _size1 = _size1 - (_repeatAddConstant / 2);
                            _size2 = _size2 - (_repeatAddConstant / 2);
                            _repeatAdd = _repeatAdd + _repeatAddConstant;

                            //_repeatAdd = _repeatAdd + _repeatAdd;

                        }
                    }

                    //=================================================== Repeat Rectangle ==============================================
                    else if (matchRepRectangle.Success)
                    {
                        try
                        {
                            int _repeatAddWidth = 0;
                            int _repeatAddConstantWidth;
                            int _repeatAddHeight = 0;
                            int _repeatAddConstantHeight;
                            //g = drawareapanel.CreateGraphics();
                            _size1 = int.Parse(lbl_StartPosX.Text);
                            _size2 = int.Parse(lbl_StartPosY.Text);
                            _size3 = int.Parse(matchRepRectangle.Groups[1].Value);
                            _size4 = int.Parse(matchRepRectangle.Groups[2].Value);

                            _repeatAddWidth = int.Parse(matchRepRectangle.Groups[3].Value);
                            _repeatAddConstantWidth = int.Parse(matchRepRectangle.Groups[3].Value);

                            _repeatAddHeight = int.Parse(matchRepRectangle.Groups[4].Value);
                            _repeatAddConstantHeight = int.Parse(matchRepRectangle.Groups[4].Value);

                            ShapeFactory shapeFactory = new ShapeFactory();
                            Shape c = shapeFactory.GetShape("rectangle");

                            for (int i = 0; i < _repeatNo; i++)
                            {
                                c.set(texturestyle, bb, paintcolor, _size1, _size2, _size3 + _repeatAddWidth, _size4 + _repeatAddHeight);
                                c.draw(g);
                                _size1 = _size1 - (_repeatAddConstantWidth / 2);
                                _size2 = _size2 - (_repeatAddConstantHeight / 2);
                                _repeatAddWidth = _repeatAddWidth + _repeatAddConstantWidth;
                                _repeatAddHeight = _repeatAddHeight + _repeatAddConstantHeight;
                            }
                            
                            
                        }
                        catch (Exception ex)
                        {
                            rtxt_errors.AppendText(ex.Message + Environment.NewLine);
                            //MessageBox.Show(ex.Message);
                        }

                    }

              //=============================================== IF ELSE ==================================================

                    else if (matchIfelse.Success)
                    {
                        try
                        {
                            int checkX, checkY;
                            //g = drawareapanel.CreateGraphics();
                            checkX = int.Parse(matchIfelse.Groups[1].Value);
                            checkY = int.Parse(matchIfelse.Groups[2].Value);
                            lbl_StartPosX.Text = checkX.ToString();
                            lbl_StartPosY.Text = checkY.ToString();
                            _size1 = checkX;
                            _size2 = checkY;
                            if (checkX > 0 && checkY > 0)
                            {
                                
                                //===============
                                Regex regexIfelseCircle = new Regex(@"draw circle (.*[\d])");
                                Match matchIfelseCircle = regexIfelseCircle.Match(rtxt_console.Text.ToLower());

                                Regex regexIfelseRectangle = new Regex(@"draw rectangle (.*[\d])([,])(.*[\d])");
                                Match matchIfelseRectangle = regexIfelseRectangle.Match(rtxt_console.Text.ToLower());
                                //if drawto x= 9 >= 0 or y= 19 >= 0 draw circle 90
                                //draw circle 90
                                //draw rectangle 90,70
                                if (matchIfelseCircle.Success)
                                {

                                    try
                                    {
                                        _size3 = int.Parse(matchIfelseCircle.Groups[1].Value);

                                        ShapeFactory shapeFactory = new ShapeFactory();
                                        Shape c = shapeFactory.GetShape("circle");
                                        c.set(texturestyle, bb, paintcolor, _size1, _size2, _size3 * 2, _size3 * 2);
                                        c.draw(g);
                                    }
                                    catch (Exception ex)
                                    {
                                        rtxt_errors.AppendText(ex.Message + Environment.NewLine);
                                        // MessageBox.Show(ex.Message);
                                    }


                                }
                                else if (matchIfelseRectangle.Success)
                                {
                                    try
                                    {
                                        _size3 = int.Parse(matchIfelseRectangle.Groups[1].Value);
                                        _size4 = int.Parse(matchIfelseRectangle.Groups[3].Value);

                                        ShapeFactory shapeFactory = new ShapeFactory();
                                        Shape c = shapeFactory.GetShape("rectangle");
                                        c.set(texturestyle, bb, paintcolor, _size1, _size2, _size3, _size4);

                                        c.draw(g);
                                    }
                                    catch (Exception ex)
                                    {
                                        rtxt_errors.AppendText(ex.Message + Environment.NewLine);
                                    }

                                }

                            }
                            else
                            {
                                if (checkX < 0)
                                {
                                    MessageBox.Show("Drawto X= " + checkX + " cannot be less than zero(0)");
                                }
                                else
                                {
                                    MessageBox.Show("Drawto Y= " + checkY + " cannot be less than zero(0)");

                                }
                            }

                            

                        }
                        catch (Exception ex)
                        {
                            rtxt_errors.AppendText(ex.Message + Environment.NewLine);
                            //MessageBox.Show(ex.Message);
                        }

                    }

                }
                catch (Exception ex)
                {

                    rtxt_errors.AppendText(ex.Message + Environment.NewLine);
                }
            }




            //=================================================== HISTORY RECORDING ===============================================
            rtxt_history.AppendText(rtxt_console.Text + Environment.NewLine);
            //=================================================== ***************** ==============================================
        }

        private void rtxt_console_TextChanged(object sender, EventArgs e)
        {
            Regex regex_scan_drawto = new Regex(@"drawto (.*[\d])([,])(.*[\d])");
            Match match_scan_drawto = regex_scan_drawto.Match(rtxt_console.Text.ToLower());
            if (match_scan_drawto.Success)
            {
                try
                {
                    _size1 = int.Parse(match_scan_drawto.Groups[1].Value);
                    _size2 = int.Parse(match_scan_drawto.Groups[3].Value);
                    lbl_StartPosX.Text = _size1.ToString();
                    lbl_StartPosY.Text = _size2.ToString();
                }
                catch (Exception)
                {
                    //rtxt_errors.AppendText(ex.Message + Environment.NewLine);

                }
            }
        }

        
        
        

        private void consoleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Console c = new Console();
            c.Show();
        }
    }
}
