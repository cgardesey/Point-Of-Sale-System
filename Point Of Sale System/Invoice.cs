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
    public partial class Invoice : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        public Invoice(string userName, string cartNo, string salePrice, string amtPaid, string amtOwed, string date)
        {
            InitializeComponent();

            lblCartNo.Text = cartNo;
            lblAmtPaid.Text = amtPaid;
            lblAmtOwed.Text = amtOwed;
            lblSalePrice.Text = salePrice;
            dateLabel.Text = date;
            about();
        }
        private void about()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select Address, ShopName, ContactNumber, Email from SETTINGS";
                cmd = new SqlCommand(sqlstr, con);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string address, shopName, contactNumber, email;

                    address = dr["Address"].ToString();
                    lblAddress.Text = address;

                    shopName = dr["ShopName"].ToString();
                    lblShopName.Text = shopName;

                    contactNumber = dr["ContactNumber"].ToString();
                    lblContactNumber.Text = contactNumber;

                    email = dr["Email"].ToString();
                    lblEmail.Text = email;
                }
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        public bool EnforceConstraints { get; set; }
        private void Invoice_Load(object sender, EventArgs e)
        {
            pOSDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'pOSDataSet.SETTINGS' table. You can move, or remove it, as needed.
            this.sETTINGSTableAdapter.Fill(this.pOSDataSet.SETTINGS);
            // TODO: This line of code loads data into the 'pOSDataSet.SETTINGS' table. You can move, or remove it, as needed.
            this.sETTINGSTableAdapter.Fill(this.pOSDataSet.SETTINGS);
            // TODO: This line of code loads data into the 'pOSDataSet.SALESVIEW' table. You can move, or remove it, as needed.
            this.sALESVIEWTableAdapter.FillByCartNo(this.pOSDataSet.SALESVIEW, lblCartNo.Text, "Sub Total:");
            //decimal cost = 0;
            //for (int i = 0; i < sALEDataGridView.Rows.Count; i++)
            //{
            //    cost += Convert.ToDecimal(sALEDataGridView.Rows[i].Cells[2].Value);
            //}
            //lblSalePrice.Text = cost.ToString("#,0.00");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = false;
            btnExit.Visible = false;
            printForm1.Print();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contactNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void lblShopName_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
