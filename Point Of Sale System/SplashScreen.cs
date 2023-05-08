using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sale_System
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Start();
            timer2.Enabled = true;
            timer2.Start();
            label4.Text = "       .    .    .    .      ";     
        }

        #region Form Properties
        private const int CS_DROPSHADOW = 0x00020000;

        private bool Dragging = false;
        private Point StartPoint = new Point(0, 0);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void SplashScreen_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void SplashScreen_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);      
        }

        private void SplashScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void SplashScreen_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(20);
            if (progressBar1.Value <= 40)
            {
                label5.Text = " connecting to server ... ";
            }
            else if (progressBar1.Value >= 80)
            {
                label5.Text = " loading ... ";

                timer1.Stop();
                timer2.Stop();
                this.Hide();

                Login login = new Login();
                login.Show();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //ARRAY TO LOOP THROUGH TEXT
            char[] chars = label4.Text.ToCharArray();
            char[] newChar = new char[chars.Length];

            int k = 0;
            for (int j = 0; j < chars.Length; j++)
            {
                if (j + 1 < chars.Length)
                    newChar[j + 1] = chars[j];
                else
                {
                    newChar[k] = chars[j];
                    k++;
                }
            }
            label4.Text = new string(newChar);       
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
