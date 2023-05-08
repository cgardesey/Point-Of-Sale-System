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
    public partial class Debtors : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        public Debtors(string userName)
        {
            InitializeComponent();
            labelUserName.Text = userName;
            roleID();
            role();
        }

        private void role()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select Role FROM Role WHERE RoleID = '" + label2.Text + "'";
                cmd = new SqlCommand(sqlstr, con);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    roleLabel.Text = dr["Role"].ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void roleID()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select RoleID FROM USERLOGIN WHERE UserName = '" + labelUserName.Text + "'";
                cmd = new SqlCommand(sqlstr, con);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label2.Text = dr["RoleID"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            AddDebtor addDebtor = new AddDebtor();
            addDebtor.ShowDialog();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            EditDebtor editDebtor = new EditDebtor();
            editDebtor.ShowDialog();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            DebtorsReport debtorsReport = new DebtorsReport();
            debtorsReport.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelEmp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainInterface mainInteface = new MainInterface(labelUserName.Text);
            mainInteface.Show();
        }
    }
}
