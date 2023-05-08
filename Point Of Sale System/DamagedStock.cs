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
    public partial class DamagedStock : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;

        private void clearData()
        {
            //employeeIDTextBox.Clear();
            complaintComboBox.Text = null;
            otherComplaintTextBox.Clear();
            QtyReturnednumericUpDown.Text = null;
        }
        public DamagedStock(string userName, string Expired)
        {
            InitializeComponent();
            userNameLabel.Text = userName;
            employeeID();
            roleID();
            role();
            complaint();
            dateLabel.Text = Convert.ToString(System.DateTime.Now);
            lblExpired.Text = Expired;
        }

        private void role()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select Role FROM Role WHERE RoleID = '" + label3.Text + "'";
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
                sqlstr = "Select RoleID FROM USERLOGIN WHERE UserName = '" + userNameLabel.Text + "'";
                cmd = new SqlCommand(sqlstr, con);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label3.Text = dr["RoleID"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void otherComplaint()
        {
            try
            {
                this.oTHERCOMPLAINTBindingSource.AddNew();
                ((DataRowView)oTHERCOMPLAINTBindingSource.Current)["OtherComplaint"] = otherComplaintTextBox.Text;

                this.Validate();
                this.oTHERCOMPLAINTBindingSource.EndEdit();
                this.oTHERCOMPLAINTTableAdapter.Update(this.pOSDataSet.OTHERCOMPLAINT);
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void otherComplaintID()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select OtherComplaintID from OTHERCOMPLAINT where OtherComplaint ='" + otherComplaintTextBox.Text + "'";
                cmd = new SqlCommand(sqlstr, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string otherComplaintID = dr["OtherComplaintID"].ToString();
                    otherComplaintIDTextBox.Text = otherComplaintID;
                }
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
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

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        #endregion     
        private void complaint()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                SqlDataAdapter sqlstr = new SqlDataAdapter("SELECT ComplaintID, Complaint From COMPLAINT", con);
                DataSet ds = new DataSet();
                sqlstr.Fill(ds);
                complaintComboBox.DataSource = ds.Tables[0];
                complaintComboBox.DisplayMember = "Complaint";
                complaintComboBox.ValueMember = "ComplaintID";
                DataRow Drw;
                Drw = ds.Tables[0].NewRow();
                Drw.ItemArray = new object[] { 0, "            --Select--       " };
                ds.Tables[0].Rows.InsertAt(Drw, 0);
                complaintComboBox.SelectedIndex = 0;
                complaintComboBox.BindingContext = this.BindingContext;
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void employeeID()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select UserID from USERLOGIN where UserName ='" + userNameLabel.Text + "'";
                cmd = new SqlCommand(sqlstr, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string userID = dr["UserID"].ToString();
                    userIDTextBox.Text = userID;
                }
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }

        }
        private void sTOCKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTOCKBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pOSDataSet);

        }

        private void DamagedStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.DAMAGEDSTOCK' table. You can move, or remove it, as needed.
            this.dAMAGEDSTOCKTableAdapter.Fill(this.pOSDataSet.DAMAGEDSTOCK);
            // TODO: This line of code loads data into the 'pOSDataSet.STOCK' table. You can move, or remove it, as needed.
            this.sTOCKTableAdapter.Fill(this.pOSDataSet.STOCK);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = Convert.ToString(System.DateTime.Now);
        }

        private void otherComplaintTextBox_TextChanged(object sender, EventArgs e)
        {
            otherComplaint();
            otherComplaintID();
        }
        private void btnSaveDetails_Click(object sender, EventArgs e)
        {

            
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
           
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            {
                if (QtyReturnednumericUpDown.Value == 0)
                {
                    MessageBoxForm messageBox = new MessageBoxForm(" Enter Quantity Damaged ");
                    messageBox.ShowDialog();
                }
                else if (Convert.ToInt32(QtyReturnednumericUpDown.Value) > Convert.ToInt32(quantityAvailableTextBox.Text))
                {
                    MessageBoxForm messageBox = new MessageBoxForm("You Cannot remove More Than the Quantity in Stock");
                    messageBox.ShowDialog();
                    return;
                }                

                else
                {
                    if (otherComplaintTextBox.Text != "")
                    {
                        otherComplaint();
                        otherComplaintID();
                    }


                    try
                    {
                        con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                        con.Open();
                        sqlstr = "UPDATE STOCK SET QuantityAvailable = @QuantityAvailable  where ProductID = @ProductID";
                        cmd = new SqlCommand(sqlstr, con);
                        cmd.Parameters.AddWithValue("@QuantityAvailable", Convert.ToInt32(quantityAvailableTextBox.Text) - Convert.ToInt32(QtyReturnednumericUpDown.Text));
                        cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(sTOCKDataGridView.CurrentRow.Cells[1].Value.ToString()));
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBoxForm messageBox2 = new MessageBoxForm(ex.Message);
                        messageBox2.ShowDialog();
                    }

                    try
                    {
                        con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                        con.Open();
                        sqlstr = "Insert into DAMAGEDSTOCK values (@ProductID, @Quantity, @Date, @OtherComplaintID, @ComplaintID, @UserID)";

                        cmd = new SqlCommand(sqlstr, con);                      
                        cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(productIDTextBox.Text));
                        cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(QtyReturnednumericUpDown.Text));
                        cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dateLabel.Text));
                        if (otherComplaintIDTextBox.Text == "")
                        {
                            cmd.Parameters.AddWithValue("@OtherComplaintID", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@OtherComplaintID", Convert.ToInt32(otherComplaintIDTextBox.Text));
                        }
                        if (complaintComboBox.SelectedText == "")
                        {
                            cmd.Parameters.AddWithValue("@ComplaintID", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ComplaintID", Convert.ToInt32(complaintComboBox.SelectedValue.ToString()));
                        }
                        cmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(userIDTextBox.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();

                            try
                            {
                                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                                con.Open();
                                sqlstr = "UPDATE PURCHASE SET ExpiryStatus = @ExpiryStatus  where PurchaseID = @PurchaseID";
                                cmd = new SqlCommand(sqlstr, con);
                                cmd.Parameters.AddWithValue("@ExpiryStatus", true);
                                cmd.Parameters.AddWithValue("@PurchaseID", Convert.ToInt32(sTOCKDataGridView.CurrentRow.Cells[1].Value.ToString()));
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBoxForm messageBox2 = new MessageBoxForm(ex.Message);
                                messageBox2.ShowDialog();
                            }

                        MessageBoxForm messageBoxForm = new MessageBoxForm("Drug(s) Successfully Cleared! Please remove them from Stock");
                        messageBoxForm.ShowDialog();
                        clearData();

                    }
                    catch (Exception ex)
                    {
                        MessageBoxForm messageBoxForm = new MessageBoxForm(ex.Message);
                        messageBoxForm.ShowDialog();
                    }                
                }
            }
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {            
            try
            {
                string searchstring = txtSearch.Text;
                sTOCKBindingSource.Filter = "ProductName LIKE '%" + searchstring + "%'";
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            //if (txtSearch.Text == "")
            //{
            //    txtSearch.Text = "           Search Drug";
            //}
        }
    }
}
