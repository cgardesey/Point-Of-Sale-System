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
    public partial class AddSale : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        static decimal cost = 0;
        static int qtySold, qtyRemainig;

        public AddSale(string userName)
        {
            InitializeComponent();
            userNameLabel.Text = userName;
            

            employeeID();
            debtor();
            dateLabel.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
    
            clear();
            totalSaleTextBox.Text = "0.00";
            balanceTextBox.Text = "0.00";
            AmtReceivedTextBox.Text = "0.00";            
            //btnRemove.Enabled = false;
            btnAddtoCart.Enabled = false;
            btnSell.Enabled = false;
            GlobalFunction.cartNo = RandomString(5, true);
            lblCartNo.Text = GlobalFunction.cartNo.ToString();
            roleID();
            role();
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

        private void AddSale_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void AddSale_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }
        private void AddSale_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void AddSale_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
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
        private void clear()
        {
            unitPriceTextBox.Clear();
            quantitySoldNumericUpDown.Value = 0;
            salePriceTextBox.Clear();
        }
        private void qtyPrice()
        {
            if (quantitySoldNumericUpDown.Value == 0)
            {
                btnAddtoCart.Enabled = false;
                salePriceTextBox.Text = "00.00";
            }
            else if (quantitySoldNumericUpDown.Value != 0)
            {
                try
                {
                    double qty = Convert.ToDouble(quantitySoldNumericUpDown.Value);
                    double unitPrice = Convert.ToDouble(unitPriceTextBox.Text);

                    double qtyPrice = qty * unitPrice;

                    salePriceTextBox.Text = qtyPrice.ToString("#,0.00");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }

        }
        private void productID()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select QuantityAvailable from STOCK where ProductID ='" + sALEDataGridView.CurrentRow.Cells[3].Value + "'";
                cmd = new SqlCommand(sqlstr, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label12.Text = dr["QuantityAvailable"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void addToCart()
        {
            this.sALEBindingSource.AddNew();
            ((DataRowView)sALEBindingSource.Current)["salesCatID"] = GlobalFunction.cartNo;
            ((DataRowView)sALEBindingSource.Current)["ProductID"] = Convert.ToInt32(productIDTextBox.Text);
            ((DataRowView)sALEBindingSource.Current)["QuantitySold"] = Convert.ToInt32(quantitySoldNumericUpDown.Value);
            ((DataRowView)sALEBindingSource.Current)["SalePrice"] = Convert.ToDecimal(salePriceTextBox.Text);
            ((DataRowView)sALEBindingSource.Current)["SaleDate"] = Convert.ToDateTime(dateLabel.Text);
            ((DataRowView)sALEBindingSource.Current)["UserID"] = Convert.ToInt32(userIDTextBox.Text);
           
            clear();

            //CALCULATE TOTAL IN DATAGRIDVIEW COLUMN 3
            cost = 0;
            for (int i = 0; i < sALEDataGridView.Rows.Count; i++)
            {
                cost += Convert.ToDecimal(sALEDataGridView.Rows[i].Cells[2].Value);         
            }

            totalSaleTextBox.Text = cost.ToString("#,0.00");
            //AmtReceivedTextBox.Text = Convert.ToDecimal(AmtReceivedTextBox.Text).ToString("#,0.00");
            balanceTextBox.Text = (cost - Convert.ToDecimal(AmtReceivedTextBox.Text)).ToString();
           
            btnSell.Enabled = true;

            btnRemove.Enabled = true;
            //btnGrandTotal.Enabled = true;
        }
        private void role()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select Role FROM Role WHERE RoleID = '" + label8.Text + "'";
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
                    label8.Text = dr["RoleID"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void sell()
        {

            try
            {
                //this.Validate();
                //this.sALEBindingSource.EndEdit();
                //this.sALETableAdapter.Update(this.pOSDataSet.SALE);

                for (int i = 0; i < sALEDataGridView.Rows.Count; i++)
                {
                    con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                    con.Open();
                    sqlstr = "Insert into SALE values (@ProductID, @QuantitySold, @SalePrice, @SaleDate, @UserID, @salesCatID)";

                    cmd = new SqlCommand(sqlstr, con);

                    cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(sALEDataGridView.Rows[i].Cells[3].Value.ToString()));
                    cmd.Parameters.AddWithValue("@QuantitySold", Convert.ToInt32(sALEDataGridView.Rows[i].Cells[1].Value.ToString()));
                    cmd.Parameters.AddWithValue("@SalePrice", Convert.ToDecimal(sALEDataGridView.Rows[i].Cells[2].Value.ToString()));
                    cmd.Parameters.AddWithValue("@SaleDate", Convert.ToDateTime(sALEDataGridView.Rows[i].Cells[5].Value.ToString()));
                    cmd.Parameters.AddWithValue("@UserID", (sALEDataGridView.Rows[i].Cells[6].Value.ToString()));
                    cmd.Parameters.AddWithValue("@salesCatID", (sALEDataGridView.Rows[i].Cells[4].Value.ToString()));                   
                    cmd.ExecuteNonQuery();
                    con.Close();



                    //con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                    //con.Open();
                    //SqlDataAdapter dataAdpater = new SqlDataAdapter("SELECT ProductID, QuantityRemaining From PURCHASE where ProductID = '" + Convert.ToInt32(sALEDataGridView.Rows[i].Cells[3].Value.ToString()) + "' order by ExpiryDate ", con);
                    // dataAdpater.UpdateCommand = new SqlCommand( "UPDATE Categories SET CategoryName = @CategoryName " + "WHERE CategoryID = @CategoryID", con);
                    //DataSet ds = new DataSet();
                    //dataAdpater.Fill(ds);
                    //var e = new List<string>();
                    //(x=>x.)

                    DataView dv = pOSDataSet.PURCHASE.DefaultView;
                    //   Sort data
                    dv.Sort = "ExpiryDate";


                    qtySold = Convert.ToInt32(sALEDataGridView.Rows[i].Cells[1].Value.ToString());
                    foreach (DataRowView dr in dv)
                    {
                        if (Convert.ToInt32(dr["ProductID"]) == Convert.ToInt32(sALEDataGridView.Rows[i].Cells[3].Value.ToString()))
                        {
                            qtyRemainig = Convert.ToInt32(dr["QuantityRemaining"]);
                            //MessageBox.Show(dr["QuantityRemaining"].ToString()); 
                            if (qtyRemainig == 0)
                            {
                                continue;
                            }
                            else if (qtyRemainig > qtySold)
                            {
                                dr["QuantityRemaining"] = qtyRemainig - qtySold;
                                break;
                            }
                            else
                            {
                                dr["QuantityRemaining"] = 0;
                                qtySold -= qtyRemainig;
                            }
                        }                                             
                    }
                    this.Validate();
                    this.pURCHASEBindingSource.EndEdit();
                    pURCHASETableAdapter.Update(pOSDataSet.PURCHASE);
                }

                //CLEAR DATAGRIDVIEW
                //for (int i = 0; i < sALEDataGridView.RowCount; i++)
                //{
                //    sALEDataGridView.Rows.Remove(sALEDataGridView.Rows[0]);
                //}
                int max = sALEDataGridView.Rows.Count;
                for (int i = 0; i < max - 1; i++)
                {
                    sALEDataGridView.Rows.Remove(sALEDataGridView.Rows[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void invoice()
        {
            InvoiceReport invoiceReport = new InvoiceReport(lblCartNo.Text);
            invoiceReport.ShowDialog();
        }
        
        //CART NO. GENERATOR
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            int ch;
            for (int i = 0; i < size; )
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = Convert.ToString(System.DateTime.Now);
        }
        private void AddSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.PURCHASE' table. You can move, or remove it, as needed.
            this.pURCHASETableAdapter.Fill(this.pOSDataSet.PURCHASE);
            // TODO: This line of code loads data into the 'pOSDataSet.SALESCART' table. You can move, or remove it, as needed.
            this.sALESCARTTableAdapter.Fill(this.pOSDataSet.SALESCART);
            // TODO: This line of code loads data into the 'pOSDataSet.DEBTORS' table. You can move, or remove it, as needed.
            this.dEBTORSTableAdapter.Fill(this.pOSDataSet.DEBTORS);
            // TODO: This line of code loads data into the 'pOSDataSet.USERLOGIN' table. You can move, or remove it, as needed.
            //this.uSERLOGINTableAdapter.Fill(this.pOSDataSet.USERLOGIN);
            // TODO: This line of code loads data into the 'pOSDataSet.USER' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'pOSDataSet.STOCK' table. You can move, or remove it, as needed.
            this.sTOCKTableAdapter.Fill(this.pOSDataSet.STOCK);
       }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (sALEDataGridView.Rows.Count != 0)
            {              
                cost = 0;
                for (int i = 0; i < sALEDataGridView.Rows.Count; i++)
                {
                    cost += Convert.ToDecimal(sALEDataGridView.Rows[i].Cells[2].Value);
                }
                totalSaleTextBox.Text = cost.ToString("#,0.00");
                try
                {
                    productID();
                    con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                    con.Open();
                    sqlstr = "UPDATE STOCK SET QuantityAvailable = @QuantityAvailable  where ProductID = @ProductID";
                    cmd = new SqlCommand(sqlstr, con);
                    cmd.Parameters.AddWithValue("@QuantityAvailable", Convert.ToInt32(label12.Text) + Convert.ToInt32(sALEDataGridView.CurrentRow.Cells[1].Value.ToString()));
                    cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(sALEDataGridView.CurrentRow.Cells[3].Value.ToString()));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBoxForm messageBox2 = new MessageBoxForm(ex.Message);
                    messageBox2.ShowDialog();
                }
                this.sALEBindingSource.RemoveCurrent();
                this.sTOCKTableAdapter.Fill(this.pOSDataSet.STOCK);
            }
        }
        private void debtor()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                SqlDataAdapter sqlstr = new SqlDataAdapter("SELECT DebtorId, Name From DEBTORS", con);
                DataSet ds = new DataSet();
                sqlstr.Fill(ds);
                DebtorComboBox.DataSource = ds.Tables[0];
                DebtorComboBox.DisplayMember = "Name";
                DebtorComboBox.ValueMember = "DebtorId";
                DataRow Drw;
                Drw = ds.Tables[0].NewRow();
                Drw.ItemArray = new object[] { 0, "               None          " };
                ds.Tables[0].Rows.InsertAt(Drw, 0);
                DebtorComboBox.SelectedIndex = 0;
                DebtorComboBox.BindingContext = this.BindingContext;
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(balanceTextBox.Text) != 0 && DebtorComboBox.SelectedIndex == 0)
                {
                    MessageBoxForm messageBox = new MessageBoxForm("Select Debtor");
                    messageBox.ShowDialog();
                }
                else
                {
                    con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                    con.Open();
                    sqlstr = "Insert into SALESCART values (@salesCatID, @DebtorId, @AmountReceived, @TotalAmount, @Date)";

                    cmd = new SqlCommand(sqlstr, con);

                    cmd.Parameters.AddWithValue("@salesCatID", lblCartNo.Text);
                    if (DebtorComboBox.SelectedIndex == 0)
                    {
                        cmd.Parameters.AddWithValue("@DebtorId", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@DebtorId", Convert.ToInt32(DebtorIDtextBox.Text));
                    }
                    cmd.Parameters.AddWithValue("@AmountReceived", Convert.ToDecimal(AmtReceivedTextBox.Text));
                    cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToDecimal(totalSaleTextBox.Text));
                    cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dateLabel.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();

                    sell();
                    invoice();

                    GlobalFunction.cartNo = RandomString(5, true);
                    lblCartNo.Text = GlobalFunction.cartNo.ToString();
                    btnSell.Enabled = false;
                    //btnRemove.Enabled = false;


                    this.sALESCARTTableAdapter.Fill(this.pOSDataSet.SALESCART);
                    this.dEBTORSTableAdapter.Fill(this.pOSDataSet.DEBTORS);
                    this.sTOCKTableAdapter.Fill(this.pOSDataSet.STOCK);

                    totalSaleTextBox.Text = "0.00";
                    balanceTextBox.Text = "0.00";
                    AmtReceivedTextBox.Text = "0.00";
                }



            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }


        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            decimal cost = 0;
            for (int i = 0; i < sALEDataGridView.Rows.Count; i++)
            {
                cost += Convert.ToDecimal(sALEDataGridView.Rows[i].Cells[2].Value);
            }
            totalSaleTextBox.Text = cost.ToString("#,0.00");
            btnSell.Enabled = true;
            
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (quantitySoldNumericUpDown.Value == 0)
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter Quantity ");
                messageBox.ShowDialog();
            }
            else
            {
                int qtySold = Convert.ToInt32(quantitySoldNumericUpDown.Value);
                int qtyAva = Convert.ToInt32(quantityAvailableTextBox.Text);
                if (qtySold > qtyAva)
                {
                    MessageBoxForm messageBox = new MessageBoxForm("You Cannot Sell More Than the Quantity in Stock");
                    messageBox.ShowDialog();
                }
                else
                {
                    addToCart();
                    try
                    {
                        productID();
                        con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                        con.Open();
                        sqlstr = "UPDATE STOCK SET QuantityAvailable = @QuantityAvailable  where ProductID = @ProductID";
                        cmd = new SqlCommand(sqlstr, con);
                        cmd.Parameters.AddWithValue("@QuantityAvailable", Convert.ToInt32(label12.Text) - Convert.ToInt32(sALEDataGridView.CurrentRow.Cells[1].Value.ToString()));
                        cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(sALEDataGridView.CurrentRow.Cells[3].Value.ToString()));
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBoxForm messageBox2 = new MessageBoxForm(ex.Message);
                        messageBox2.ShowDialog();
                    }
                    this.sTOCKTableAdapter.Fill(this.pOSDataSet.STOCK);

                }                    
            }           
        }
        private void quantitySoldTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!(btnSell.Enabled))
            {
                this.Close();
            }
            else if (btnSell.Enabled)
            {
                MessageBoxForm messageBox = new MessageBoxForm("   Changes Have Not Been Saved.     Are You Sure You Want To Close? ");
                messageBox.yes = true;
                messageBox.no = true;
                messageBox.ok = false;
                DialogResult result = messageBox.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(btnSell.Enabled))
            {
                this.Close();
            }
            else if (btnSell.Enabled)
            {
                MessageBoxForm messageBox = new MessageBoxForm("           Changes Have Not Been Saved.         Are You Sure You Want To Close ? ");
                messageBox.yes = true;
                messageBox.no = true;
                messageBox.ok = false;
                DialogResult result = messageBox.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            quantitySoldNumericUpDown.Value = 0;
            salePriceTextBox.Clear();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                string searchstring = txtSearch.Text;
                sTOCKBindingSource.Filter = "PRODUCTNAME LIKE '%" + searchstring + "%'";
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }
        private void unitPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void salePriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void sALEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void salePriceTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void DebtorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DebtorComboBox.SelectedItem != null)
            {
                DataRowView drv = DebtorComboBox.SelectedItem as DataRowView;
                DebtorIDtextBox.Text = drv.Row["DebtorId"].ToString();
            }
        }
        private void AmtReceivedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AmtReceivedTextBox.Text.Trim() != "")
            {
                try
                {
                    totalSaleTextBox.Text = cost.ToString("#,0.00");
                    //AmtReceivedTextBox.Text = Convert.ToDecimal(AmtReceivedTextBox.Text).ToString("#,0.00");
                    balanceTextBox.Text = (cost - Convert.ToDecimal(AmtReceivedTextBox.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBoxForm messageBoxForm = new MessageBoxForm(ex.Message);
                    messageBoxForm.ShowDialog();
                }
            }
            
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                AddDebtor addDebtor = new AddDebtor();
                addDebtor.ShowDialog();
                debtor();
                checkBox1.Checked = false;
            }
        }
        private void quantitySoldNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            qtyPrice();
            btnAddtoCart.Enabled = true;
        }
        private void productTextBox_TextChanged(object sender, EventArgs e)
        {
            quantitySoldNumericUpDown.Value = 0;
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            //if (txtSearch.Text == "")
            //{
            //    txtSearch.Text = "             Search Drug";
            //}
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void balanceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}