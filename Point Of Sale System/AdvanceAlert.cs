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
    public partial class AdvanceAlert : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string sqlstr;
        SqlDataReader dr;
        public AdvanceAlert()
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

        private void tHRESHOLDALERTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.thresholdAlertBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pOSDataSet);

        }


        private void AdvanceAlert_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.ThresholdAlert' table. You can move, or remove it, as needed.
            this.thresholdAlertTableAdapter.Fill(this.pOSDataSet.ThresholdAlert);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //this.Validate();
                //this.thresholdAlertBindingSource.EndEdit();
                //this.thresholdAlertTableAdapter.Update(this.pOSDataSet.ThresholdAlert);
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Update ThresholdAlert Set Threshold = @Threshold";
                cmd = new SqlCommand(sqlstr, con);
                cmd.Parameters.AddWithValue("@Threshold", thresholdNumericUpDown.Text);
                cmd.ExecuteNonQuery();
                MessageBoxForm messageBoxForm = new MessageBoxForm("Threshold Successfully Set!");
                messageBoxForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBoxForm = new MessageBoxForm(ex.Message);
                messageBoxForm.ShowDialog();
            }
        }

        private void AdvanceAlert_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void AdvanceAlert_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void AdvanceAlert_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }
    }
}
