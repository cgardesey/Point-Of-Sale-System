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
    public partial class EditDebtor : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        public EditDebtor()
        {
            InitializeComponent();
            txtSearch.Focus();
            clearData();
            GlobalFunction.cartNo = RandomString(5, true);
            dateLabel.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
        }

        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            int ch;
            for (int i = 0; i < size;)
            {
                ch = Convert.ToInt32(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
                i++;
            }
            if (lowerCase)
                if (lowerCase)
                    return builder.ToString().ToLower();
            return builder.ToString();
        }
        private void clearData()
        {
            nameTextBox.Clear();
            phoneNumberTextBox.Clear();
            addressTextBox.Clear();
        }
        private void update()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "UPDATE DEBTORS SET Name = @Name, PhoneNumber = @PhoneNumber, Address = @Address  where DebtorId =  '" + Convert.ToInt32(dEBTORSVIEWDataGridView.CurrentRow.Cells[0].Value.ToString()) + "'";
                cmd = new SqlCommand(sqlstr, con);
                cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                if (addressTextBox.Text == "")
                {
                    cmd.Parameters.AddWithValue("@PhoneNumber", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumberTextBox.Text);
                }
                if (addressTextBox.Text == "")
                {
                    cmd.Parameters.AddWithValue("@Address", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Address", addressTextBox.Text);
                }

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBoxForm messageBox = new MessageBoxForm("Details Successfully Updated!");
                messageBox.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                string searchstring = txtSearch.Text;
                dEBTORSVIEWBindingSource.Filter = "Name LIKE '%" + searchstring + "%'";
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void dEBTORSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dEBTORSVIEWBindingSource.EndEdit();
            this.dEBTORSVIEWTableAdapter.Update(this.pOSDataSet.DEBTORSVIEW);

        }

        private void EditDebtor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.DEBTORSVIEW' table. You can move, or remove it, as needed.
            this.dEBTORSVIEWTableAdapter.Fill(this.pOSDataSet.DEBTORSVIEW);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            MessageBoxForm messageBox = new MessageBoxForm(" Are You Sure You Want To Close? ");
            messageBox.yes = true;
            messageBox.no = true;
            messageBox.ok = false;
            DialogResult result = messageBox.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            if (dEBTORSVIEWDataGridView.RowCount > 0)
            {
                try
                {
                    if (amtPaidTextBox.Text != "")
                    {
                        con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                        con.Open();
                        sqlstr = "Insert into SALESCART values (@salesCatID, @DebtorId, @AmountReceived, @TotalAmount, @Date)";
                        cmd = new SqlCommand(sqlstr, con);
                        cmd.Parameters.AddWithValue("@salesCatID", RandomString(5, true).ToString());
                        cmd.Parameters.AddWithValue("@DebtorId", Convert.ToInt32(dEBTORSVIEWDataGridView.CurrentRow.Cells[0].Value.ToString()));
                        cmd.Parameters.AddWithValue("@AmountReceived", Convert.ToDecimal(amtPaidTextBox.Text));
                        cmd.Parameters.AddWithValue("@TotalAmount", 0);
                        cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dateLabel.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    update();

                    //int focus = dEBTORSVIEWDataGridView.CurrentRow.Index; 
                    this.dEBTORSVIEWTableAdapter.Fill(this.pOSDataSet.DEBTORSVIEW);
                    //dEBTORSVIEWDataGridView.Rows[focus].Selected = true;
                }
                catch (Exception ex)
                {
                    MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                    messageBox.ShowDialog();
                }
            }

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxForm messageBox = new MessageBoxForm("Are Sure You Want To Delete " + nameTextBox.Text);
                messageBox.yes = true;
                messageBox.no = true;
                messageBox.ok = false;
                DialogResult result = messageBox.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.dEBTORSVIEWBindingSource.RemoveCurrent();
                    this.dEBTORSVIEWTableAdapter.Update(this.pOSDataSet.DEBTORSVIEW);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salePriceTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtSearch_Click_2(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            //if (txtSearch.Text == "")
            //{
            //    txtSearch.Text = "              Search Debtor";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dEBTORSVIEWDataGridView.Rows.Count != 0)
            {
                MessageBoxForm messageBox = new MessageBoxForm("Are Sure You Want To Delete " + nameTextBox.Text);
                messageBox.yes = true;
                messageBox.no = true;
                messageBox.ok = false;
                DialogResult result = messageBox.ShowDialog();
                if (result == DialogResult.Yes)
                {

                    try
                    {
                        this.dEBTORSVIEWBindingSource.RemoveCurrent();
                        this.dEBTORSVIEWTableAdapter.Update(this.pOSDataSet.DEBTORSVIEW);
                    }
                    catch (Exception)
                    {
                        MessageBoxForm messageBoxForm = new MessageBoxForm("You Cannot Delete a Debtor You Have Sold Drugs To");
                        messageBoxForm.ShowDialog();
                        this.dEBTORSVIEWTableAdapter.Fill(this.pOSDataSet.DEBTORSVIEW);
                        return;
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
        }
    }
}
