using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sale_System
{
    public partial class AddPurchase : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        static decimal cost = 0;

        public AddPurchase(string userName)
        {
            InitializeComponent();
            userNameLabel.Text = userName;

            

            employeeID();
            creditor();
            dateLabel.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
    
            clear();
            totalPurchaseTextBox.Text = "0.00";
            balanceTextBox.Text = "0.00";
            AmtPaidTextBox.Text = "0.00";            
            //btnRemove.Enabled = false;
            btnAddtoCart.Enabled = false;
            btnBuy.Enabled = false;
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
            quantityBoughtNumericUpDown.Value = 0;
            purchasePriceTextBox.Clear();
            productExpiryDateDateTimePicker.Value = DateTime.Now;
            //expiredStatusCheckBox.Checked = false;
        }
        private void qtyPrice()
        {
            if (quantityBoughtNumericUpDown.Value == 0)
            {
                btnAddtoCart.Enabled = false;
                purchasePriceTextBox.Text = "00.00";
            }
            else if (quantityBoughtNumericUpDown.Value != 0)
            {
                try
                {
                    double qty = Convert.ToDouble(quantityBoughtNumericUpDown.Value);
                    double unitPrice = Convert.ToDouble(unitPriceTextBox.Text);

                    double qtyPrice = qty * unitPrice;

                    purchasePriceTextBox.Text = qtyPrice.ToString("#,0.00");
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
                sqlstr = "Select QuantityAvailable from STOCK where ProductID ='" + pURCHASEDataGridView.CurrentRow.Cells[3].Value + "'";
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
            this.pURCHASEBindingSource.AddNew();
            ((DataRowView)pURCHASEBindingSource.Current)["purchasesCatID"] = GlobalFunction.cartNo;
            ((DataRowView)pURCHASEBindingSource.Current)["ProductID"] = Convert.ToInt32(productIDTextBox.Text);
            ((DataRowView)pURCHASEBindingSource.Current)["QuantityPurchased"] = Convert.ToInt32(quantityBoughtNumericUpDown.Value);
            ((DataRowView)pURCHASEBindingSource.Current)["PurchasePrice"] = Convert.ToDecimal(purchasePriceTextBox.Text);
            ((DataRowView)pURCHASEBindingSource.Current)["PurchaseDate"] = Convert.ToDateTime(dateLabel.Text);
            ((DataRowView)pURCHASEBindingSource.Current)["UserID"] = Convert.ToInt32(userIDTextBox.Text);
            if (productExpiryDateDateTimePicker.Visible == true)
            {
                ((DataRowView)pURCHASEBindingSource.Current)["ExpiryDate"] = Convert.ToDateTime(productExpiryDateDateTimePicker.Text);
            }
            else
            {
                ((DataRowView)pURCHASEBindingSource.Current)["ExpiryDate"] = DBNull.Value;
            }
            ((DataRowView)pURCHASEBindingSource.Current)["QuantityRemaining"] = Convert.ToInt32(quantityBoughtNumericUpDown.Value);

            clear();

            //CALCULATE TOTAL IN DATAGRIDVIEW COLUMN 3
            cost = 0;
            for (int i = 0; i < pURCHASEDataGridView.Rows.Count; i++)
            {
                cost += Convert.ToDecimal(pURCHASEDataGridView.Rows[i].Cells[2].Value);         
            }

            totalPurchaseTextBox.Text = cost.ToString("#,0.00");
            AmtPaidTextBox.Text = Convert.ToDecimal(AmtPaidTextBox.Text).ToString();
            balanceTextBox.Text = (cost - Convert.ToDecimal(AmtPaidTextBox.Text)).ToString();
           
            btnBuy.Enabled = true;

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
        private void purchase()
        {
            try
            {
                for (int i = 0; i < pURCHASEDataGridView.Rows.Count; i++)
                {
                    con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                    con.Open();
                    sqlstr = "Insert into PURCHASE values (@ProductID, @QuantityPurchased, @PurchasePrice, @PurchaseDate, @UserID, @purchasesCatID, @ExpiryDate, @ExpiryStatus, @QuantityRemaining, @Acknowledged)";

                    cmd = new SqlCommand(sqlstr, con);

                    cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(pURCHASEDataGridView.Rows[i].Cells[3].Value.ToString()));                   
                    cmd.Parameters.AddWithValue("@QuantityPurchased", Convert.ToInt32(pURCHASEDataGridView.Rows[i].Cells[1].Value.ToString()));
                    cmd.Parameters.AddWithValue("@PurchasePrice", Convert.ToDecimal(pURCHASEDataGridView.Rows[i].Cells[2].Value.ToString()));
                    cmd.Parameters.AddWithValue("@PurchaseDate", Convert.ToDateTime(pURCHASEDataGridView.Rows[i].Cells[5].Value.ToString()));
                    cmd.Parameters.AddWithValue("@UserID", (pURCHASEDataGridView.Rows[i].Cells[6].Value.ToString()));
                    cmd.Parameters.AddWithValue("@purchasesCatID", (pURCHASEDataGridView.Rows[i].Cells[4].Value.ToString()));
                    if (pURCHASEDataGridView.Rows[i].Cells[7].Value == DBNull.Value)
                    {                        
                        cmd.Parameters.AddWithValue("@ExpiryDate", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ExpiryDate", Convert.ToDateTime(pURCHASEDataGridView.Rows[i].Cells[7].Value.ToString()));
                    }
                   
                    cmd.Parameters.AddWithValue("@ExpiryStatus", false);
                    cmd.Parameters.AddWithValue("@QuantityRemaining", Convert.ToInt32(pURCHASEDataGridView.Rows[i].Cells[9].Value.ToString()));
                    cmd.Parameters.AddWithValue("@Acknowledged", false);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBoxForm messageBox = new MessageBoxForm("Transaction Successful!");
                messageBox.ShowDialog();

                //CLEAR DATAGRIDVIEW                
                //for (int i = 0; i < pURCHASEDataGridView.RowCount; i++)
                //{
                //    pURCHASEDataGridView.Rows.Remove(pURCHASEDataGridView.Rows[0]);
                //}
                int max = pURCHASEDataGridView.Rows.Count;
                for (int i = 0; i < max - 1; i++)
                {
                    pURCHASEDataGridView.Rows.Remove(pURCHASEDataGridView.Rows[0]);
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
            Invoice invoice = new Invoice(userNameLabel.Text, lblCartNo.Text, totalPurchaseTextBox.Text, AmtPaidTextBox.Text, balanceTextBox.Text, dateLabel.Text);           
            invoice.ShowDialog();
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (pURCHASEDataGridView.Rows.Count != 0)
            {
                cost = 0;
                for (int i = 0; i < pURCHASEDataGridView.Rows.Count; i++)
                {
                    cost += Convert.ToDecimal(pURCHASEDataGridView.Rows[i].Cells[2].Value);
                }
                totalPurchaseTextBox.Text = cost.ToString("#,0.00");
            }
            try
            {
                productID();
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "UPDATE STOCK SET QuantityAvailable = @QuantityAvailable  where ProductID = @ProductID";
                cmd = new SqlCommand(sqlstr, con);
                cmd.Parameters.AddWithValue("@QuantityAvailable", Convert.ToInt32(label12.Text) - Convert.ToInt32(pURCHASEDataGridView.CurrentRow.Cells[1].Value.ToString()));
                cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(pURCHASEDataGridView.CurrentRow.Cells[3].Value.ToString()));
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox2 = new MessageBoxForm(ex.Message);
                messageBox2.ShowDialog();
            }
            this.pURCHASEBindingSource.RemoveCurrent();
            this.sTOCKTableAdapter.Fill(this.pOSDataSet.STOCK);
        }
        private void creditor()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                SqlDataAdapter sqlstr = new SqlDataAdapter("SELECT CreditorId, Name From CREDITORS", con);
                DataSet ds = new DataSet();
                sqlstr.Fill(ds);
                CreditorComboBox.DataSource = ds.Tables[0];
                CreditorComboBox.DisplayMember = "Name";
                CreditorComboBox.ValueMember = "CreditorId";
                DataRow Drw;
                Drw = ds.Tables[0].NewRow();
                Drw.ItemArray = new object[] { 0, "            --Select--       " };
                ds.Tables[0].Rows.InsertAt(Drw, 0);
                CreditorComboBox.SelectedIndex = 0;
                CreditorComboBox.BindingContext = this.BindingContext;
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
                if (CreditorComboBox.SelectedIndex == 0)
                {
                    MessageBoxForm messageBox = new MessageBoxForm("Select Supplier");
                    messageBox.ShowDialog();
                }

                else
                {
                    con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                    con.Open();
                    sqlstr = "Insert into PURCHASESCART values (@purchasesCatID, @CreditorId, @AmountPaid, @TotalAmount, @Date)";

                    cmd = new SqlCommand(sqlstr, con);

                    cmd.Parameters.AddWithValue("@purchasesCatID", lblCartNo.Text);
                    if (CreditorComboBox.SelectedIndex == 0)
                    {
                        cmd.Parameters.AddWithValue("@CreditorId", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@CreditorId", Convert.ToInt32(CreditorIDtextBox.Text));
                    }
                    cmd.Parameters.AddWithValue("@AmountPaid", Convert.ToDecimal(AmtPaidTextBox.Text));
                    cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToDecimal(totalPurchaseTextBox.Text));
                    cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dateLabel.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();

                    purchase();

                    GlobalFunction.cartNo = RandomString(5, true);
                    lblCartNo.Text = GlobalFunction.cartNo.ToString();
                    btnBuy.Enabled = false;
                    //btnRemove.Enabled = false;

                    this.pURCHASESCARTTableAdapter.Fill(this.pOSDataSet.PURCHASESCART);
                    // TODO: This line of code loads data into the 'pOSDataSet.CREDITORS' table. You can move, or remove it, as needed.
                    this.cREDITORSTableAdapter.Fill(this.pOSDataSet.CREDITORS);
                    // TODO: This line of code loads data into the 'pOSDataSet.STOCK' table. You can move, or remove it, as needed.
                    this.sTOCKTableAdapter.Fill(this.pOSDataSet.STOCK);
                    for (int i = 0; i < pURCHASEDataGridView.Rows.Count ; i++)
                    {
                        pURCHASEDataGridView.Rows.RemoveAt(0);
                    }

                    totalPurchaseTextBox.Text = "0.00";
                    balanceTextBox.Text = "0.00";
                    AmtPaidTextBox.Text = "0.00";
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
            for (int i = 0; i < pURCHASEDataGridView.Rows.Count; i++)
            {
                cost += Convert.ToDecimal(pURCHASEDataGridView.Rows[i].Cells[2].Value);
            }
            totalPurchaseTextBox.Text = cost.ToString("#,0.00");
            btnBuy.Enabled = true;
            
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (quantityBoughtNumericUpDown.Value == 0)
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter Quantity ");
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
                    cmd.Parameters.AddWithValue("@QuantityAvailable", Convert.ToInt32(label12.Text) + Convert.ToInt32(pURCHASEDataGridView.CurrentRow.Cells[1].Value.ToString()));
                    cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(pURCHASEDataGridView.CurrentRow.Cells[3].Value.ToString()));
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
        private void quantitySoldTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!(btnBuy.Enabled))
            {
                this.Close();
            }
            else if (btnBuy.Enabled)
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
            if (!(btnBuy.Enabled))
            {
                this.Close();
            }
            else if (btnBuy.Enabled)
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
            quantityBoughtNumericUpDown.Value = 0;
            purchasePriceTextBox.Clear();
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
        private void AmtReceivedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AmtPaidTextBox.Text.Trim() != "")
            {
                try
                {
                    totalPurchaseTextBox.Text = cost.ToString("#,0.00");
                    AmtPaidTextBox.Text = Convert.ToDecimal(AmtPaidTextBox.Text).ToString();
                    balanceTextBox.Text = (cost - Convert.ToDecimal(AmtPaidTextBox.Text)).ToString();
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
                AddCreditor addCreditor = new AddCreditor();
                addCreditor.ShowDialog();
                creditor();
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
            quantityBoughtNumericUpDown.Value = 0;
            
        }

        private void AddPurchase_Load(object sender, EventArgs e)
        {
            
        }

        private void CreditorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CreditorComboBox.SelectedItem != null)
            {
                DataRowView drv = CreditorComboBox.SelectedItem as DataRowView;
                CreditorIDtextBox.Text = drv.Row["CreditorId"].ToString();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void expiredStatusCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            //if (txtSearch.Text == "")
            //{
            //    txtSearch.Text = "             Search Drug";
            //}
        }

        private void hasExpiryDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (hasExpiryDateCheckBox.Checked)
            {
                PanelExpiryDate.Visible = true;
            }
            else
            {
                PanelExpiryDate.Visible = false;
            }
        }

        private void hasExpiryDateCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPurchase_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void AddPurchase_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.SALESCART' table. You can move, or remove it, as needed.
            this.pURCHASESCARTTableAdapter.Fill(this.pOSDataSet.PURCHASESCART);
            // TODO: This line of code loads data into the 'pOSDataSet.DEBTORS' table. You can move, or remove it, as needed.
            this.cREDITORSTableAdapter.Fill(this.pOSDataSet.CREDITORS);
            // TODO: This line of code loads data into the 'pOSDataSet.USERLOGIN' table. You can move, or remove it, as needed.
            //this.uSERLOGINTableAdapter.Fill(this.pOSDataSet.USERLOGIN);
            // TODO: This line of code loads data into the 'pOSDataSet.USER' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'pOSDataSet.STOCK' table. You can move, or remove it, as needed.
            this.sTOCKTableAdapter.Fill(this.pOSDataSet.STOCK);
        }
    }
}