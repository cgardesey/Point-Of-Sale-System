using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sale_System
{
    public partial class Purchases : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        public Purchases(string userName)
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


        private void btnNewSale_Click(object sender, EventArgs e)
        {
            AddPurchase addSale = new AddPurchase(labelUserName.Text);
            addSale.ShowDialog();
        }

        private void btnProductReturns_Click(object sender, EventArgs e)
        {
            PurchaseReturn productReturn = new PurchaseReturn(labelUserName.Text);
            productReturn.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainInterface mainInteface = new MainInterface(labelUserName.Text);
            mainInteface.Show();
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            PurchasesReport purchasesReport = new PurchasesReport();
            purchasesReport.ShowDialog();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewPurchasesReturns_Click(object sender, EventArgs e)
        {
            PurchasesReturnReport purchasesReturnReport = new PurchasesReturnReport();
            purchasesReturnReport.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
