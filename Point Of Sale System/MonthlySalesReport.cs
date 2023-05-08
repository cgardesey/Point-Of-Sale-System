using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Point_Of_Sale_System
{
    public partial class MonthlySalesReport : Form
    {
        public MonthlySalesReport()
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

        private void Stock_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }
        #endregion

        private void MonthlySalesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'POSDataSet1.GetSalesYear' table. You can move, or remove it, as needed.
            this.getSalesYearTableAdapter.Fill(this.POSDataSet1.GetSalesYear);
            using (POSEntities db = new POSEntities())
            {
                try
                {
                    GetMonthlySalesBindingSource.DataSource = db.GetMonthlySales(Convert.ToInt32(YearcomboBox.SelectedValue.ToString())).ToList();

                }
                catch (Exception)
                {

                    MessageBoxForm MessageBoxForm = new MessageBoxForm("No Sales Have been made");
                }
           }

            this.reportViewer1.RefreshReport();
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
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
    }
}
