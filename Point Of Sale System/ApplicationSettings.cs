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
    public partial class ApplicationSettings : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string sqlstr;
        SqlDataReader dr;
        public ApplicationSettings()
        {
            InitializeComponent();
            loadSettings();
            btnSave.Enabled = false;
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
        private void Settings_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
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
        private void loadSettings()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = ("SELECT Address, ShopName, ContactNumber, Email, Website, Location FROM SETTINGS");
                cmd = new SqlCommand(sqlstr, con);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    addressTextBox.Text = dr["Address"].ToString();
                    shopNameTextBox.Text = dr["ShopName"].ToString();
                    contactNumberTextBox.Text = dr["ContactNumber"].ToString();
                    emailTextBox.Text = dr["Email"].ToString();
                    websiteTextBox.Text = dr["Website"].ToString();
                    websiteTextBox.Text = dr["Location"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void updateSettings()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Update SETTINGS Set Address = @Address, ShopName = @ShopName, ContactNumber = @ContactNumber, Email = @Email, Website = @Website, Location = @Location";
                cmd = new SqlCommand(sqlstr, con);

                cmd.Parameters.AddWithValue("@Address", addressTextBox.Text);
                cmd.Parameters.AddWithValue("@ShopName", shopNameTextBox.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", contactNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@Website", websiteTextBox.Text);
                cmd.Parameters.AddWithValue("@Location", LocationTextBox.Text);

                cmd.ExecuteNonQuery();

                MessageBoxForm messageBox = new MessageBoxForm("Application Settings Successfully Updated!");
                messageBox.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateSettings();
            btnSave.Enabled = false;
        }

        private void shopNameTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void contactNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void websiteTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(btnSave.Enabled))
            {
                this.Close();
            }
            else if (btnSave.Enabled)
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
