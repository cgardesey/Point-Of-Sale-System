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
    public partial class Expired : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        public Expired()
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

        #endregion

        private void Expired_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.EXPIREDDRUGVIEW' table. You can move, or remove it, as needed.
            this.eXPIREDDRUGVIEWTableAdapter.FillByExpired(this.pOSDataSet.EXPIREDDRUGVIEW);

        }

        private void eXPIREDDRUGVIEWDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
            con.Open();
            sqlstr = "UPDATE EXPIREDDRUGVIEW SET ExpiryStatus = @ExpiryStatus  where PurchaseID = @PurchaseID";
            cmd = new SqlCommand(sqlstr, con);
            cmd.Parameters.AddWithValue("@ExpiryStatus", Convert.ToBoolean(eXPIREDDRUGVIEWDataGridView.CurrentRow.Cells[3].Value.ToString()));
            cmd.Parameters.AddWithValue("@PurchaseID", Convert.ToInt32(eXPIREDDRUGVIEWDataGridView.CurrentRow.Cells[4].Value.ToString()));
            cmd.ExecuteNonQuery();
            con.Close();

            this.eXPIREDDRUGVIEWTableAdapter.FillByExpired(this.pOSDataSet.EXPIREDDRUGVIEW);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }
    }
}
