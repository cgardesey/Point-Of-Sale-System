using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sale_System
{
    public partial class EditStock : Form
    {
        public EditStock()
        {
            InitializeComponent();
            txtSearch.Focus();
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
        private void EditStock_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void Label1_MouseUp(object sender, MouseEventArgs e)
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
        }
        private void update()
        {
            try
            {
                this.Validate();
                this.sTOCKBindingSource.EndEdit();
                this.sTOCKTableAdapter.Update(this.pOSDataSet.STOCK);

                MessageBoxForm messageBox = new MessageBoxForm("Details Successfully Updated!");
                messageBox.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void EditStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter.Fill(this.pOSDataSet.CATEGORY);
            // TODO: This line of code loads data into the 'pOSDataSet.STOCK' table. You can move, or remove it, as needed.
            this.sTOCKTableAdapter.Fill(this.pOSDataSet.STOCK);

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

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            update();
            btnSaveDetails.Enabled = false;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "                      Search Drug";
            }
        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
        }

        private void categoryIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
        }

        private void quantityAvailableTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
        }

        private void unitSellingPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
        }

        private void unitCostPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
        }

        private void minStockLevelTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(btnSaveDetails.Enabled))
            {
                this.Close();
            }
            else if (btnSaveDetails.Enabled)
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dvgSearch.Rows.Count != 0)
            {
                MessageBoxForm messageBox = new MessageBoxForm("Are Sure You Want To Delete " + productNameTextBox.Text);
                messageBox.yes = true;
                messageBox.no = true;
                messageBox.ok = false;
                DialogResult result = messageBox.ShowDialog();
                if (result == DialogResult.Yes)
                {

                    try
                    {
                        this.sTOCKBindingSource.RemoveCurrent();
                        this.sTOCKTableAdapter.Update(this.pOSDataSet.STOCK);
                    }
                    catch (Exception)
                    {
                        MessageBoxForm messageBoxForm = new MessageBoxForm("You Cannot Delete a Drug You Have Made Sale(s) for");
                        messageBoxForm.ShowDialog();
                        // TODO: This line of code loads data into the 'pOSDataSet.CATEGORY' table. You can move, or remove it, as needed.
                        this.cATEGORYTableAdapter.Fill(this.pOSDataSet.CATEGORY);
                        // TODO: This line of code loads data into the 'pOSDataSet.STOCK' table. You can move, or remove it, as needed.
                        this.sTOCKTableAdapter.Fill(this.pOSDataSet.STOCK);
                        return;
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }                                    
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Text = "";
           
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

        private void txtSearch_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            //if (txtSearch.Text == "")
            //{
            //    txtSearch.Text = "                      Search Drug";
            //}
        }

        private void dvgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
