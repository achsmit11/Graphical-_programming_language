namespace Graphical_Programming_Language_Application
{
    partial class Console
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clearconsole = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_console = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_clearconsole);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 30);
            this.panel1.TabIndex = 0;
            // 
            // btn_clearconsole
            // 
            this.btn_clearconsole.Location = new System.Drawing.Point(8, 5);
            this.btn_clearconsole.Name = "btn_clearconsole";
            this.btn_clearconsole.Size = new System.Drawing.Size(75, 23);
            this.btn_clearconsole.TabIndex = 0;
            this.btn_clearconsole.Text = "Clear";
            this.btn_clearconsole.UseVisualStyleBackColor = true;
            this.btn_clearconsole.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txt_console);
            this.panel2.Location = new System.Drawing.Point(-2, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 192);
            this.panel2.TabIndex = 1;
            // 
            // txt_console
            // 
            this.txt_console.BackColor = System.Drawing.Color.Black;
            this.txt_console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_console.ForeColor = System.Drawing.Color.White;
            this.txt_console.Location = new System.Drawing.Point(0, 0);
            this.txt_console.Multiline = true;
            this.txt_console.Name = "txt_console";
            this.txt_console.Size = new System.Drawing.Size(219, 192);
            this.txt_console.TabIndex = 0;
            this.txt_console.TextChanged += new System.EventHandler(this.txt_console_TextChanged);
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(216, 228);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Console";
            this.Text = "Console";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clearconsole;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_console;
    }
}