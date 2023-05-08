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
    public partial class YearlySalesReport : Form
    {
        public YearlySalesReport()
        {
            InitializeComponent();
        }

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

        private void YearlySalesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'POSDataSet1.GetSalesYear' table. You can move, or remove it, as needed.
            this.getSalesYearTableAdapter.Fill(this.POSDataSet1.GetSalesYear);
            using (POSEntities db = new POSEntities())
            {
                 try
                {
                    GetYearlySales1BindingSource.DataSource = db.GetYearlySales1(Convert.ToInt32(FromComboBox.SelectedValue), Convert.ToInt32(ToComboBox.SelectedValue)).ToList();

                }
                catch (Exception)
                {

                    MessageBoxForm MessageBoxForm = new MessageBoxForm("No Sales Have been made");
                }
            }

            this.reportViewer1.RefreshReport();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
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
