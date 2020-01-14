namespace Graphical_Programming_Language_Application
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_appname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_StartPosX = new System.Windows.Forms.Label();
            this.lbl_StartPosY = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_cursorx = new System.Windows.Forms.Label();
            this.lbl_cursory = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_canvasx = new System.Windows.Forms.Label();
            this.lbl_canvasy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showcolorbox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_pen = new System.Windows.Forms.Button();
            this.btn_polygon = new System.Windows.Forms.Button();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_elipse = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.rtxt_console = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_consolerun = new System.Windows.Forms.Button();
            this.btn_console1clear = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.drawareapanel = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtxt_history = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtxt_errors = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showcolorbox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawareapanel)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_appname);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 33);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(786, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_appname
            // 
            this.lbl_appname.AutoSize = true;
            this.lbl_appname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_appname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_appname.Location = new System.Drawing.Point(252, 8);
            this.lbl_appname.Name = "lbl_appname";
            this.lbl_appname.Size = new System.Drawing.Size(375, 20);
            this.lbl_appname.TabIndex = 2;
            this.lbl_appname.Text = "Graphical Programming Language Application";
            this.lbl_appname.Click += new System.EventHandler(this.lbl_appname_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Controls.Add(this.showcolorbox);
            this.panel2.Location = new System.Drawing.Point(-1, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 51);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_StartPosX);
            this.groupBox3.Controls.Add(this.lbl_StartPosY);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(230, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 37);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Start Position";
            // 
            // lbl_StartPosX
            // 
            this.lbl_StartPosX.AutoSize = true;
            this.lbl_StartPosX.ForeColor = System.Drawing.Color.White;
            this.lbl_StartPosX.Location = new System.Drawing.Point(20, 16);
            this.lbl_StartPosX.Name = "lbl_StartPosX";
            this.lbl_StartPosX.Size = new System.Drawing.Size(25, 13);
            this.lbl_StartPosX.TabIndex = 9;
            this.lbl_StartPosX.Text = "000";
            // 
            // lbl_StartPosY
            // 
            this.lbl_StartPosY.AutoSize = true;
            this.lbl_StartPosY.ForeColor = System.Drawing.Color.White;
            this.lbl_StartPosY.Location = new System.Drawing.Point(61, 16);
            this.lbl_StartPosY.Name = "lbl_StartPosY";
            this.lbl_StartPosY.Size = new System.Drawing.Size(25, 13);
            this.lbl_StartPosY.TabIndex = 10;
            this.lbl_StartPosY.Text = "000";
            this.lbl_StartPosY.Click += new System.EventHandler(this.lbl_StartPosY_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(4, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "X:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(47, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Y:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_cursorx);
            this.groupBox2.Controls.Add(this.lbl_cursory);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(326, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 37);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cursor Position";
            // 
            // lbl_cursorx
            // 
            this.lbl_cursorx.AutoSize = true;
            this.lbl_cursorx.ForeColor = System.Drawing.Color.White;
            this.lbl_cursorx.Location = new System.Drawing.Point(20, 16);
            this.lbl_cursorx.Name = "lbl_cursorx";
            this.lbl_cursorx.Size = new System.Drawing.Size(25, 13);
            this.lbl_cursorx.TabIndex = 9;
            this.lbl_cursorx.Text = "000";
            // 
            // lbl_cursory
            // 
            this.lbl_cursory.AutoSize = true;
            this.lbl_cursory.ForeColor = System.Drawing.Color.White;
            this.lbl_cursory.Location = new System.Drawing.Point(62, 16);
            this.lbl_cursory.Name = "lbl_cursory";
            this.lbl_cursory.Size = new System.Drawing.Size(25, 13);
            this.lbl_cursory.TabIndex = 10;
            this.lbl_cursory.Text = "000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(4, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(48, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Y:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_canvasx);
            this.groupBox1.Controls.Add(this.lbl_canvasy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(434, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 37);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canvas Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "X:";
            // 
            // lbl_canvasx
            // 
            this.lbl_canvasx.AutoSize = true;
            this.lbl_canvasx.ForeColor = System.Drawing.Color.White;
            this.lbl_canvasx.Location = new System.Drawing.Point(20, 15);
            this.lbl_canvasx.Name = "lbl_canvasx";
            this.lbl_canvasx.Size = new System.Drawing.Size(25, 13);
            this.lbl_canvasx.TabIndex = 9;
            this.lbl_canvasx.Text = "000";
            this.lbl_canvasx.Click += new System.EventHandler(this.lbl_canvasx_Click);
            // 
            // lbl_canvasy
            // 
            this.lbl_canvasy.AutoSize = true;
            this.lbl_canvasy.ForeColor = System.Drawing.Color.White;
            this.lbl_canvasy.Location = new System.Drawing.Point(62, 15);
            this.lbl_canvasy.Name = "lbl_canvasy";
            this.lbl_canvasy.Size = new System.Drawing.Size(25, 13);
            this.lbl_canvasy.TabIndex = 10;
            this.lbl_canvasy.Text = "000";
            this.lbl_canvasy.Click += new System.EventHandler(this.lbl_canvasy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(48, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color :";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(864, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.openTextToolStripMenuItem});
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // openTextToolStripMenuItem
            // 
            this.openTextToolStripMenuItem.Name = "openTextToolStripMenuItem";
            this.openTextToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openTextToolStripMenuItem.Text = "Open Text";
            this.openTextToolStripMenuItem.Click += new System.EventHandler(this.openTextToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem,
            this.saveTextToolStripMenuItem});
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // saveTextToolStripMenuItem
            // 
            this.saveTextToolStripMenuItem.Name = "saveTextToolStripMenuItem";
            this.saveTextToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveTextToolStripMenuItem.Text = "Save Text";
            this.saveTextToolStripMenuItem.Click += new System.EventHandler(this.saveTextToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // showcolorbox
            // 
            this.showcolorbox.BackColor = System.Drawing.Color.Black;
            this.showcolorbox.Location = new System.Drawing.Point(58, 28);
            this.showcolorbox.Name = "showcolorbox";
            this.showcolorbox.Size = new System.Drawing.Size(21, 21);
            this.showcolorbox.TabIndex = 1;
            this.showcolorbox.TabStop = false;
            this.showcolorbox.Click += new System.EventHandler(this.showcolorbox_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_pen);
            this.panel3.Controls.Add(this.btn_polygon);
            this.panel3.Controls.Add(this.btn_triangle);
            this.panel3.Controls.Add(this.btn_elipse);
            this.panel3.Controls.Add(this.btn_square);
            this.panel3.Controls.Add(this.btn_Rectangle);
            this.panel3.Location = new System.Drawing.Point(812, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(44, 357);
            this.panel3.TabIndex = 3;
            // 
            // btn_pen
            // 
            this.btn_pen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pen.BackgroundImage")));
            this.btn_pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pen.Location = new System.Drawing.Point(3, 2);
            this.btn_pen.Name = "btn_pen";
            this.btn_pen.Size = new System.Drawing.Size(41, 46);
            this.btn_pen.TabIndex = 7;
            this.btn_pen.UseVisualStyleBackColor = true;
            this.btn_pen.Click += new System.EventHandler(this.btn_pen_Click);
            // 
            // btn_polygon
            // 
            this.btn_polygon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_polygon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_polygon.BackgroundImage")));
            this.btn_polygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_polygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_polygon.Location = new System.Drawing.Point(3, 309);
            this.btn_polygon.Name = "btn_polygon";
            this.btn_polygon.Size = new System.Drawing.Size(38, 45);
            this.btn_polygon.TabIndex = 6;
            this.btn_polygon.UseVisualStyleBackColor = true;
            this.btn_polygon.Click += new System.EventHandler(this.btn_polygon_Click);
            // 
            // btn_triangle
            // 
            this.btn_triangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_triangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_triangle.BackgroundImage")));
            this.btn_triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_triangle.Location = new System.Drawing.Point(3, 238);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(38, 47);
            this.btn_triangle.TabIndex = 5;
            this.btn_triangle.UseVisualStyleBackColor = true;
            this.btn_triangle.Click += new System.EventHandler(this.btn_triangle_Click);
            // 
            // btn_elipse
            // 
            this.btn_elipse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_elipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_elipse.BackgroundImage")));
            this.btn_elipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elipse.Location = new System.Drawing.Point(3, 162);
            this.btn_elipse.Name = "btn_elipse";
            this.btn_elipse.Size = new System.Drawing.Size(38, 62);
            this.btn_elipse.TabIndex = 4;
            this.btn_elipse.UseVisualStyleBackColor = true;
            this.btn_elipse.Click += new System.EventHandler(this.btn_elipse_Click);
            // 
            // btn_square
            // 
            this.btn_square.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_square.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_square.BackgroundImage")));
            this.btn_square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_square.Location = new System.Drawing.Point(0, 107);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(41, 49);
            this.btn_square.TabIndex = 3;
            this.btn_square.UseVisualStyleBackColor = true;
            this.btn_square.Click += new System.EventHandler(this.btn_square_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Rectangle.BackgroundImage")));
            this.btn_Rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Rectangle.Location = new System.Drawing.Point(3, 54);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(38, 47);
            this.btn_Rectangle.TabIndex = 2;
            this.btn_Rectangle.UseVisualStyleBackColor = true;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // rtxt_console
            // 
            this.rtxt_console.BackColor = System.Drawing.Color.LightYellow;
            this.rtxt_console.ForeColor = System.Drawing.Color.DarkRed;
            this.rtxt_console.Location = new System.Drawing.Point(3, 85);
            this.rtxt_console.Name = "rtxt_console";
            this.rtxt_console.Size = new System.Drawing.Size(224, 142);
            this.rtxt_console.TabIndex = 1;
            this.rtxt_console.Text = "";
            this.rtxt_console.TextChanged += new System.EventHandler(this.rtxt_console_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(84, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_consolerun
            // 
            this.btn_consolerun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_consolerun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consolerun.Location = new System.Drawing.Point(3, 233);
            this.btn_consolerun.Name = "btn_consolerun";
            this.btn_consolerun.Size = new System.Drawing.Size(75, 60);
            this.btn_consolerun.TabIndex = 4;
            this.btn_consolerun.Text = "Run";
            this.btn_consolerun.UseVisualStyleBackColor = false;
            this.btn_consolerun.Click += new System.EventHandler(this.btn_consolerun_Click);
            // 
            // btn_console1clear
            // 
            this.btn_console1clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_console1clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_console1clear.Location = new System.Drawing.Point(157, 233);
            this.btn_console1clear.Name = "btn_console1clear";
            this.btn_console1clear.Size = new System.Drawing.Size(70, 60);
            this.btn_console1clear.TabIndex = 3;
            this.btn_console1clear.Text = "Clear";
            this.btn_console1clear.UseVisualStyleBackColor = false;
            this.btn_console1clear.Click += new System.EventHandler(this.btn_console1clear_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.drawareapanel);
            this.panel5.Location = new System.Drawing.Point(229, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(577, 375);
            this.panel5.TabIndex = 5;
            // 
            // drawareapanel
            // 
            this.drawareapanel.BackColor = System.Drawing.Color.White;
            this.drawareapanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawareapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawareapanel.Location = new System.Drawing.Point(0, 0);
            this.drawareapanel.Name = "drawareapanel";
            this.drawareapanel.Size = new System.Drawing.Size(577, 375);
            this.drawareapanel.TabIndex = 0;
            this.drawareapanel.TabStop = false;
            this.drawareapanel.Paint += new System.Windows.Forms.PaintEventHandler(this.draw);
            this.drawareapanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawareapanel_MouseClick);
            this.drawareapanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawareapanel_MouseDown);
            this.drawareapanel.MouseLeave += new System.EventHandler(this.drawareapanel_MouseLeave);
            this.drawareapanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawareapanel_MouseMove);
            this.drawareapanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawareapanel_MouseUp);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.rtxt_history);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(220, 135);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "History";
            // 
            // rtxt_history
            // 
            this.rtxt_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtxt_history.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtxt_history.Location = new System.Drawing.Point(3, 3);
            this.rtxt_history.Name = "rtxt_history";
            this.rtxt_history.ReadOnly = true;
            this.rtxt_history.Size = new System.Drawing.Size(174, 118);
            this.rtxt_history.TabIndex = 1;
            this.rtxt_history.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 299);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(228, 161);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage4.Controls.Add(this.rtxt_errors);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(220, 135);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Errors";
            // 
            // rtxt_errors
            // 
            this.rtxt_errors.BackColor = System.Drawing.Color.LightYellow;
            this.rtxt_errors.ForeColor = System.Drawing.Color.DarkRed;
            this.rtxt_errors.Location = new System.Drawing.Point(2, 3);
            this.rtxt_errors.Name = "rtxt_errors";
            this.rtxt_errors.ReadOnly = true;
            this.rtxt_errors.Size = new System.Drawing.Size(215, 129);
            this.rtxt_errors.TabIndex = 2;
            this.rtxt_errors.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(865, 472);
            this.Controls.Add(this.btn_consolerun);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rtxt_console);
            this.Controls.Add(this.btn_console1clear);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphical Application";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showcolorbox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawareapanel)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Label lbl_appname;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox drawareapanel;
        private System.Windows.Forms.PictureBox showcolorbox;
        private System.Windows.Forms.Button btn_polygon;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.Button btn_elipse;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btn_console1clear;
        private System.Windows.Forms.Button btn_pen;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTextToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_consolerun;
        private System.Windows.Forms.RichTextBox rtxt_console;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_canvasy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_canvasx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_cursorx;
        private System.Windows.Forms.Label lbl_cursory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_StartPosX;
        private System.Windows.Forms.Label lbl_StartPosY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtxt_history;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox rtxt_errors;
    }
}

