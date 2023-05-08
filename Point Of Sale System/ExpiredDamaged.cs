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
    public partial class ExpiredDamaged : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        public ExpiredDamaged()
        {
            InitializeComponent();
            threshold();
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

        #endregion

        private void threshold()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select Threshold FROM ThresholdAlert";
                cmd = new SqlCommand(sqlstr, con);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblThreshold.Text = dr["Threshold"].ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void ExpiredDamaged_Load(object sender, EventArgs e)
        {
            this.eXPIREDDRUGVIEWTableAdapter.FillByExpiry(this.pOSDataSet.EXPIREDDRUGVIEW, DateTime.Now.AddDays(Convert.ToInt32(lblThreshold.Text)).ToString());
        }

        private void eXPIREDDRUGVIEWDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void eXPIREDDRUGVIEWDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
            con.Open();
            sqlstr = "UPDATE EXPIREDDRUGVIEW SET Acknowledged = @Acknowledged  where PurchaseID = @PurchaseID";
            cmd = new SqlCommand(sqlstr, con);
            cmd.Parameters.AddWithValue("@Acknowledged", Convert.ToBoolean(eXPIREDDRUGVIEWDataGridView.CurrentRow.Cells[3].Value.ToString()));
            cmd.Parameters.AddWithValue("@PurchaseID", Convert.ToInt32(eXPIREDDRUGVIEWDataGridView.CurrentRow.Cells[4].Value.ToString()));
            cmd.ExecuteNonQuery();
            con.Close();

            this.eXPIREDDRUGVIEWTableAdapter.FillByExpiry(this.pOSDataSet.EXPIREDDRUGVIEW, DateTime.Now.AddDays(Convert.ToInt32(lblThreshold.Text)).ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExpiredDamaged_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void ExpiredDamaged_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void ExpiredDamaged_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }
    }
}
