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
    public partial class SalesReport2 : Form
    {
        public SalesReport2()
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
        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
        #endregion

        public bool EnforceConstraints { get; set; }
        private void SalesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'POSDataSet.SALESSUMMARY' table. You can move, or remove it, as needed.
            this.sALESSUMMARYTableAdapter.Fill(this.POSDataSet.SALESSUMMARY);            
            POSDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'POSDataSet.SALESVIEW' table. You can move, or remove it, as needed.
            this.SALESVIEWTableAdapter.Fill(this.POSDataSet.SALESVIEW);

            this.reportViewer1.RefreshReport();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string searchString = txtSearch.Text;
                //SALESVIEWBindingSource.Filter = "salesCatID LIKE '%" + searchString + "%'";
                sALESSUMMARYBindingSource.Filter = "salesCatID LIKE '%" + searchString + "%'";
                SALESVIEWBindingSource.Filter = "salesCatID LIKE '%" + searchString + "%' OR ProductName LIKE '%" + searchString + "%'";
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            fromDateTimePicker.Value = DateTime.Today;
            toDateTimePicker.Value = DateTime.Today;
            this.SALESVIEWTableAdapter.FillByDate(this.POSDataSet.SALESVIEW, fromDateTimePicker.Value.ToString(), toDateTimePicker.Value.ToString());
            this.reportViewer1.RefreshReport();
            this.sALESSUMMARYTableAdapter.FillByDate(this.POSDataSet.SALESSUMMARY, fromDateTimePicker.Value.ToString(), toDateTimePicker.Value.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.SALESVIEWTableAdapter.FillByDate(this.POSDataSet.SALESVIEW, fromDateTimePicker.Value.ToString(), toDateTimePicker.Value.ToString());
            this.reportViewer1.RefreshReport();
            this.sALESSUMMARYTableAdapter.FillByDate(this.POSDataSet.SALESSUMMARY, fromDateTimePicker.Value.ToString(), toDateTimePicker.Value.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_MouseDown_1(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void Label1_MouseUp_1(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
    }
}
