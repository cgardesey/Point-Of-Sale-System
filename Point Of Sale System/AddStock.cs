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
    public partial class AddStock : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string sqlstr;
        public AddStock()
        {
            InitializeComponent();
            category();
            productNameTextBox.Focus();
            clearData();
            btnSaveDetails.Enabled = false;
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

        private void Stock_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void titleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void titleLabel_MouseUp(object sender, MouseEventArgs e)
        {
                Dragging = false;
        }
        #endregion
        private void clearData()
        {
            productNameTextBox.Clear();
            categoryIDComboBox.Text = null;
            quantityAvailableTextBox.Clear();
            unitSellingPriceTextBox.Clear();
            unitCostPriceTextBox.Clear();
            minStockLevelTextBox.Clear();
        }
        private void save()
        {
            if (productNameTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter Drug Name ");
                messageBox.ShowDialog();
            }
            else if (quantityAvailableTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter Quantity Available ");
                messageBox.ShowDialog();
            }
            else if (unitSellingPriceTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter Unit Selling Price ");
                messageBox.ShowDialog();
            }
            else if (unitCostPriceTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter Unit Cost Price ");    
                messageBox.ShowDialog();
            }
            else if (minStockLevelTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter Mininimum Stock Level ");
                messageBox.ShowDialog();
            }
            else
            {
                try
                {

                    con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                    con.Open();
                    sqlstr = "Insert into STOCK values (@ProductName, @CategoryID, @QuantityAvailable, @UnitSellingPrice, @UnitCostPrice, @MinStockLevel, @HasExpiryDate)";
                    cmd = new SqlCommand(sqlstr, con);

                    cmd.Parameters.AddWithValue("@ProductName", productNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(categoryIDTextBox.Text));
                    cmd.Parameters.AddWithValue("@QuantityAvailable", quantityAvailableTextBox.Text);
                    cmd.Parameters.AddWithValue("@UnitSellingPrice", unitSellingPriceTextBox.Text);
                    cmd.Parameters.AddWithValue("@UnitCostPrice", unitCostPriceTextBox.Text);
                    cmd.Parameters.AddWithValue("@MinStockLevel", Convert.ToInt32(minStockLevelTextBox.Text));
                    cmd.Parameters.AddWithValue("@HasExpiryDate", HasExpirycheckBox.CheckState);
                    cmd.ExecuteNonQuery();

                    MessageBoxForm messageBox = new MessageBoxForm(" Product  Successfully Saved! ");
                    messageBox.ShowDialog();

                    con.Close();
                    clearData();
                }
                catch (Exception ex)
                {
                    MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                    messageBox.ShowDialog();
                }
            }
        }
        private void category()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                SqlDataAdapter sqlstr = new SqlDataAdapter("SELECT CategoryID, Category From CATEGORY", con);
                DataSet ds = new DataSet();
                sqlstr.Fill(ds);
                categoryIDComboBox.DataSource = ds.Tables[0];
                categoryIDComboBox.DisplayMember = "Category";
                categoryIDComboBox.ValueMember = "CategoryID";
                categoryIDComboBox.BindingContext = this.BindingContext;
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void categoryIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryIDComboBox.SelectedItem != null)
            {
                DataRowView drv = categoryIDComboBox.SelectedItem as DataRowView;
                categoryIDTextBox.Text = drv.Row["CategoryID"].ToString();
            }
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            save();
            btnSaveDetails.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!(btnSaveDetails.Enabled))
            {
                this.Close();
            }
            else if (btnSaveDetails.Enabled)
            {
                MessageBoxForm messageBox = new MessageBoxForm("Changes Have Not Been Saved.  Are You Sure You Want To Close? ");
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
        }

        private void sTOCKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTOCKBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pOSDataSet);

        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.STOCK' table. You can move, or remove it, as needed.
            this.sTOCKTableAdapter.Fill(this.pOSDataSet.STOCK);
            HasExpirycheckBox.Checked = true;
        }

        private void minStockLevelTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HasExpirycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            //{
            //    AddDebtor addDebtor = new AddDebtor();
            //    addDebtor.ShowDialog();
            //    debtor();
            //    checkBox1.Checked = false;
            //}
        }
    }
}


