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
    public partial class PurchaseReturn : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        public PurchaseReturn(string userName)
        {
            InitializeComponent();
            userNameLabel.Text = userName;
            //quantitySoldTextBox.Text = "";
            employeeID();         
            roleID();
            role();
            complaint();
            //btnReturn.Enabled = false;
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
        private void product()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select ProductName from STOCK where ProductID ='" + productIDTextBox.Text + "'";
                cmd = new SqlCommand(sqlstr, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string product = dr["ProductName"].ToString();
                    productNameTextBox.Text = product;
                }
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }

        }
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
                Drw.ItemArray = new object[] { 0, "               None          " };
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

        private void productID()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select QuantityAvailable, UnitCostPrice from STOCK where ProductID ='" + pURCHASEDataGridView.CurrentRow.Cells[6].Value + "'";
                cmd = new SqlCommand(sqlstr, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblQuantityAvailable.Text = dr["QuantityAvailable"].ToString();
                    lblUnitCostPrice.Text = dr["UnitCostPrice"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void purchasecart()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select AmountPaid, Balance, TotalAmount from PURCHASESCART where [purchasesCatID] ='" + pURCHASEDataGridView.CurrentRow.Cells[8].Value + "'";
                cmd = new SqlCommand(sqlstr, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblAmtPaid.Text = dr["AmountPaid"].ToString();
                    lblBalance.Text = dr["Balance"].ToString();
                    lblTotalAmt.Text = dr["TotalAmount"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void load()
        {
            // TODO: This line of code loads data into the 'pOSDataSet.OTHERCOMPLAINT' table. You can move, or remove it, as needed.
            //this.oTHERCOMPLAINTTableAdapter.Fill(this.pOSDataSet.OTHERCOMPLAINT);
            pOSDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'pOSDataSet.COMPLAINT' table. You can move, or remove it, as needed.
            this.cOMPLAINTTableAdapter.Fill(this.pOSDataSet.COMPLAINT);
            // TODO: This line of code loads data into the 'pOSDataSet.PRODUCTRETURN' table. You can move, or remove it, as needed.
            this.pURCHASERETURNTableAdapter.Fill(this.pOSDataSet.PURCHASERETURN);
            // TODO: This line of code loads data into the 'pOSDataSet.USERLOGIN' table. You can move, or remove it, as needed.
            this.uSERLOGINTableAdapter.Fill(this.pOSDataSet.USERLOGIN);
            // TODO: This line of code loads data into the 'pOSDataSet.STOCK' table. You can move, or remove it, as needed.
            this.sTOCKTableAdapter.Fill(this.pOSDataSet.STOCK);
            // TODO: This line of code loads data into the 'pOSDataSet.SALE' table. You can move, or remove it, as needed.
            this.pURCHASETableAdapter.Fill(this.pOSDataSet.PURCHASE);
            // TODO: This line of code loads data into the 'pOSDataSet.PRODUCTRETURN' table. You can move, or remove it, as needed.
            //this.pRODUCTRETURNTableAdapter.Fill(this.pOSDataSet.PRODUCTRETURN);
            //productNameTextBox.Text = "";
            //quantitySoldTextBox.Text = "";
            clearData();
        }
        public bool EnforceConstraints { get; set; }
        private void pRODUCTRETURNBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.pRODUCTRETURNBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.pOSDataSet);

        }
        private void ProductReturn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.PURCHASERETURN' table. You can move, or remove it, as needed.
            this.pURCHASERETURNTableAdapter.Fill(this.pOSDataSet.PURCHASERETURN);
            // TODO: This line of code loads data into the 'pOSDataSet.PURCHASE' table. You can move, or remove it, as needed.
            this.pURCHASETableAdapter.Fill(this.pOSDataSet.PURCHASE);
            // TODO: This line of code loads data into the 'pOSDataSet.OTHERCOMPLAINT' table. You can move, or remove it, as needed.
            //this.oTHERCOMPLAINTTableAdapter.Fill(this.pOSDataSet.OTHERCOMPLAINT);
            pOSDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'pOSDataSet.COMPLAINT' table. You can move, or remove it, as needed.
            this.cOMPLAINTTableAdapter.Fill(this.pOSDataSet.COMPLAINT);
            // TODO: This line of code loads data into the 'pOSDataSet.PRODUCTRETURN' table. You can move, or remove it, as needed.
            this.pRODUCTRETURNTableAdapter.Fill(this.pOSDataSet.PRODUCTRETURN);
            // TODO: This line of code loads data into the 'pOSDataSet.USERLOGIN' table. You can move, or remove it, as needed.
            this.uSERLOGINTableAdapter.Fill(this.pOSDataSet.USERLOGIN);
            // TODO: This line of code loads data into the 'pOSDataSet.STOCK' table. You can move, or remove it, as needed.
            this.sTOCKTableAdapter.Fill(this.pOSDataSet.STOCK);           
        }

        private void cartNoTextBox_TextChanged(object sender, EventArgs e)
        {
             string searchstring = cartNoTextBox.Text;
            pURCHASEBindingSource.Filter = "purchasesCatID LIKE '%" + searchstring + "%'";

        }

        private void sALEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = Convert.ToString(System.DateTime.Now);
        }

        private void complaintComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (complaintComboBox.SelectedItem != null)
            {
                DataRowView drv = complaintComboBox.SelectedItem as DataRowView;
                complaintComboBox.Text = drv.Row["ComplaintID"].ToString();
            }
            btnReturn.Enabled = true;
        }

        private void save()
        {
            if (QtyReturnednumericUpDown.Value == 0)
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter Quantity Returned ");
                messageBox.ShowDialog();
            }

            else if (Convert.ToInt32(QtyReturnednumericUpDown.Value) > Convert.ToInt32(quantitySoldTextBox.Text))
            {
                MessageBoxForm messageBox = new MessageBoxForm("You Cannot return More Than the Quantity Bought");
                messageBox.ShowDialog();
                return;
            }

            else
            {
                try
                {
                   
                    if (otherComplaintTextBox != null)
                    {
                        otherComplaint();
                        otherComplaintID();
                    }

                    con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                    con.Open();
                    sqlstr = "Insert into PURCHASERETURN values (@ProductID, @QuantityReturned, @DateOfReturn, @OtherComplaintID,  @ComplaintID, @UserID)";
                    cmd = new SqlCommand(sqlstr, con);

                    cmd.Parameters.AddWithValue("@ProductID", productIDTextBox.Text);
                    cmd.Parameters.AddWithValue("@QuantityReturned", QtyReturnednumericUpDown.Text);
                    cmd.Parameters.AddWithValue("@DateOfReturn", dateLabel.Text);
                    if (otherComplaintTextBox == null)
                    {
                        cmd.Parameters.AddWithValue("@OtherComplaintID", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@OtherComplaintID", Convert.ToInt32(complaintIDTextBox.Text));
                    }
                    if (complaintComboBox.SelectedIndex == 0)
                    {
                        cmd.Parameters.AddWithValue("@ComplaintID", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ComplaintID", Convert.ToInt32(complaintIDTextBox.Text));
                    }                   
                    cmd.Parameters.AddWithValue("@UserID", userIDTextBox.Text);

                    cmd.ExecuteNonQuery();

                    MessageBoxForm messageBox = new MessageBoxForm(productNameTextBox.Text + " Successfully Returned!");
                    messageBox.ShowDialog();

                    con.Close();
                    //clearData();
                }
                catch (Exception ex)
                {
                    MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                    messageBox.ShowDialog();
                }
            }
            productID();
            purchasecart();



            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "UPDATE PURCHASESCART SET AmountPaid = @AmountPaid,  Balance = @Balance, TotalAmount = @TotalAmount  where purchasesCatID = '" + pURCHASEDataGridView.CurrentRow.Cells[8].Value.ToString() + "'";

                cmd = new SqlCommand(sqlstr, con);
                cmd.Parameters.AddWithValue("@AmountPaid", Convert.ToDecimal(lblUnitCostPrice.Text.ToString()) * (Convert.ToInt32(pURCHASEDataGridView.CurrentRow.Cells[1].Value.ToString())));
                cmd.Parameters.AddWithValue("@Balance", Convert.ToDecimal(lblTotalAmt.Text.ToString()) - 2 * Convert.ToDecimal(lblUnitCostPrice.Text) * (Convert.ToInt32(pURCHASEDataGridView.CurrentRow.Cells[1].Value.ToString())));
                cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToDecimal(lblTotalAmt.Text.ToString()) - Convert.ToDecimal(lblUnitCostPrice.Text) * (Convert.ToInt32(pURCHASEDataGridView.CurrentRow.Cells[1].Value.ToString())));

                cmd.ExecuteNonQuery();
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
                sqlstr = "UPDATE STOCK SET QuantityAvailable = @QuantityAvailable  where ProductID = @ProductID";
                cmd = new SqlCommand(sqlstr, con);
                cmd.Parameters.AddWithValue("@QuantityAvailable", Convert.ToInt32(lblQuantityAvailable.Text) - Convert.ToInt32(QtyReturnednumericUpDown.Text));
                cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(pURCHASEDataGridView.CurrentRow.Cells[6].Value.ToString()));
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
                sqlstr = "Insert into PURCHASE values (@ProductID, @QuantityPurchased, @PurchasePrice,  @PurchaseDate, @UserID, @purchasesCatID)";
                cmd = new SqlCommand(sqlstr, con);

                cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(productIDTextBox.Text.ToString()));
                cmd.Parameters.AddWithValue("@QuantityPurchased", -1 * Convert.ToInt32(QtyReturnednumericUpDown.Value));
                cmd.Parameters.AddWithValue("@PurchasePrice", -1 * Convert.ToDecimal(lblUnitCostPrice.Text) * ((Convert.ToInt32(pURCHASEDataGridView.CurrentRow.Cells[1].Value.ToString()) - Convert.ToDecimal(QtyReturnednumericUpDown.Text))));
                cmd.Parameters.AddWithValue("@PurchaseDate", Convert.ToDateTime(dateLabel.Text));
                cmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(userIDTextBox.Text));
                cmd.Parameters.AddWithValue("@purchasesCatID", pURCHASEDataGridView.CurrentRow.Cells[8].Value.ToString());
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }

            load();
        }

        private void clearData()
        {
            //productIDTextBox.Clear();
            complaintComboBox.SelectedIndex = 0;
            QtyReturnednumericUpDown.Value = 0;
            otherComplaintIDTextBox.Clear();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            save();           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click_1(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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

        private void otherComplaintTextBox_TextChanged(object sender, EventArgs e)
        {
            otherComplaint();
            otherComplaintID();
        }

        private void productIDTextBox_TextChanged(object sender, EventArgs e)
        {
            product();
        }

        private void quantitySoldTextBox_TextChanged(object sender, EventArgs e)
        {

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

        private void otherComplaintTextBox_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {
            clearData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
