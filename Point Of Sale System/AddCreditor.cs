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
    public partial class AddCreditor : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string sqlstr;
        public AddCreditor()
        {
            InitializeComponent();
            CreditorTextBox.Focus();
            clearData();
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
        #endregion
        private void clearData()
        {
            CreditorTextBox.Clear();
            ContactTextBox.Clear();
            AddressTextBox.Clear();
        }
        private void save()
        {
            if (CreditorTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter Creditor ");
                messageBox.ShowDialog();
            }

            else if (ContactTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter Contact ");
                messageBox.ShowDialog();
            }
            else if (AddressTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter Address ");
                messageBox.ShowDialog();
            }

            else
            {
                try
                {

                    con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                    con.Open();
                    sqlstr = "Insert into CREDITORS values (@Name, @PhoneNumber, @Address)";
                    cmd = new SqlCommand(sqlstr, con);

                    cmd.Parameters.AddWithValue("@Name", CreditorTextBox.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", ContactTextBox.Text);
                    cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text);

                    cmd.ExecuteNonQuery();

                    MessageBoxForm messageBox = new MessageBoxForm(" Details successfully saved! ");
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            
        }

        private void productNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void quantityAvailableLabel_Click(object sender, EventArgs e)
        {

        }

        private void ContactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void unitSellingPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveDetails_Click_1(object sender, EventArgs e)
        {
            save();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
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

        private void titleLabel_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
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

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
