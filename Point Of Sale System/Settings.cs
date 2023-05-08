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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
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
        private void Settings_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        #endregion
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAppSettings_Click(object sender, EventArgs e)
        {
            ApplicationSettings applicationSettings = new ApplicationSettings();
            applicationSettings.ShowDialog();
        }

        private void btnCatSettings_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.ShowDialog();
        }

        private void btnComplaint_Click(object sender, EventArgs e)
        {
            Complaint complaint = new Complaint();
            complaint.ShowDialog();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.ShowDialog();
        }

        private void btnAppSettings_MouseHover(object sender, EventArgs e)
        {
            btnAppSettings.FlatAppearance.BorderColor = Color.White;
        }

        private void btnCatSettings_MouseHover(object sender, EventArgs e)
        {
            btnCatSettings.FlatAppearance.BorderColor = Color.White;
        }

        private void btnComplaint_MouseHover(object sender, EventArgs e)
        {
            btnComplaint.FlatAppearance.BorderColor = Color.White;
        }

        private void btnRole_MouseHover(object sender, EventArgs e)
        {
            //btnRole.FlatAppearance.BorderColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ApplicationSettings applicationSettings = new ApplicationSettings();
            applicationSettings.ShowDialog();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Complaint complaint = new Complaint();
            complaint.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdvanceAlert advanceAlert = new AdvanceAlert();
            advanceAlert.ShowDialog();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            AdvanceAlert advanceAlert = new AdvanceAlert();
            advanceAlert.ShowDialog();
        }
    }
}
