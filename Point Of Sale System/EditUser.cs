using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sale_System
{
    public partial class EditUser : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string sqlstr;
        SqlDataReader dr;
        public EditUser()
        {
            InitializeComponent();
            //role();
            //title();
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
        private void EditUser_Paint(object sender, PaintEventArgs e)
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

        private void browseImage()
        {
            this.openFileDialog1
                .Title = "Select Image";
            openFileDialog1.Filter = "All Files|*.*|Bitamps|*.bmp|GIFs|*.gif|JPEGs|*.jpg";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picturePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                picturePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                picturePictureBox.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        private void clearData()
        {
            //employeeIDTextBox.Clear();
            firstNameTextBox.Clear();
            otherNameTextBox.Clear();
            lastNameTextBox.Clear();
            genderComboBox.Text = null;
            phoneNumberTextBox.Clear();
            addressTextBox.Clear();
            statusCheckBox.Checked = false;
            picturePictureBox.Image = null;
            dateOfBirthDateTimePicker.Value = DateTime.Now;
            dateOfEmploymentDateTimePicker.Value = DateTime.Now;
        }
        private void role()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                SqlDataAdapter sqlstr = new SqlDataAdapter("SELECT RoleID, Role From ROLE", con);
                DataSet ds = new DataSet();
                sqlstr.Fill(ds);
                roleIDComboBox.DataSource = ds.Tables[0];
                roleIDComboBox.DisplayMember = "Role";
                roleIDComboBox.ValueMember = "RoleID";
                roleIDComboBox.BindingContext = this.BindingContext;
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void title()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                SqlDataAdapter sqlstr = new SqlDataAdapter("SELECT TitleID, Title From TITLE", con);
                DataSet ds = new DataSet();
                sqlstr.Fill(ds);
                titleIDComboBox.DataSource = ds.Tables[0];
                titleIDComboBox.DisplayMember = "Title";
                titleIDComboBox.ValueMember = "TitleID";
                titleIDComboBox.BindingContext = this.BindingContext;
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void picture()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                SqlDataAdapter sqlstr = new SqlDataAdapter("SELECT Picture from [USER] where UserID = '" + phoneNumberTextBox.Text + "'", con);

                DataSet ds = new DataSet();
                sqlstr.Fill(ds, "Picture");
                int count = ds.Tables["Picture"].Rows.Count;

                if (ds.Tables["Picture"].Rows[count - 1]["Picture"] != System.DBNull.Value)
                {
                    byte[] data = (byte[])(ds.Tables["Picture"].Rows[count - 1]["Picture"]);

                    MemoryStream ms = new MemoryStream(data);
                    picturePictureBox.Image = Image.FromStream(ms);
                    picturePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    picturePictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                }
                else if (ds.Tables["Picture"].Rows[count - 1]["Picture"] == System.DBNull.Value)
                {
                    MessageBoxForm messageBox = new MessageBoxForm("The Selected Employee Has No Picture");
                    messageBox.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void update()
        {
            MemoryStream ms = new MemoryStream();
            picturePictureBox.Image.Save(ms, picturePictureBox.Image.RawFormat);
            byte[] data = ms.GetBuffer();

            try
            {               
                this.Validate();
                this.uSERBindingSource.EndEdit();
                this.uSERTableAdapter.Update(this.pOSDataSet.USER);

                this.rOLETableAdapter.Fill(this.pOSDataSet.ROLE);
                this.tITLETableAdapter.Fill(this.pOSDataSet.TITLE);
                this.uSERTableAdapter.Fill(this.pOSDataSet.USER);

                MessageBoxForm messageBox = new MessageBoxForm(" Details Successfully Updated! ");
                messageBox.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void checkExisting()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
            con.Open();
            sqlstr = "SELECT PhoneNumber from USER where PhoneNumber = '" + phoneNumberTextBox.Text + "'";
            cmd = new SqlCommand(sqlstr, con);

            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBoxForm messageBox = new MessageBoxForm("Employee Already Exist");
                messageBox.ShowDialog();
            }
            dr.Close();
            con.Close();
        }
        private void dvgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //picture();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter.Fill(this.pOSDataSet.ROLE);
            // TODO: This line of code loads data into the 'pOSDataSet.TITLE' table. You can move, or remove it, as needed.
            this.tITLETableAdapter.Fill(this.pOSDataSet.TITLE);
            // TODO: This line of code loads data into the 'pOSDataSet.TITLE' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.pOSDataSet.USER);
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchstring = txtSearch.Text;
                uSERBindingSource.Filter = "FIRSTNAME LIKE '%" + searchstring + "%' OR LASTNAME LIKE '%" + searchstring + "%'";

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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            browseImage();
            btnSaveDetails.Enabled = true;
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            update();
            btnSaveDetails.Enabled = false;
        }

        private void titleIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
        }

        private void roleIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
        }

        private void otherNameTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
        }

        private void dateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
        }

        private void dateOfEmploymentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSaveDetails.Enabled = true;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
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

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            picturePictureBox.Image = null;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
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

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            //if (txtSearch.Text == "")
            //{
            //    txtSearch.Text = "           Search First Name or Last Name";
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                MessageBoxForm messageBox = new MessageBoxForm("Are Sure You Want To Delete " + firstNameTextBox.Text + lastNameTextBox.Text);
                messageBox.yes = true;
                messageBox.no = true;
                messageBox.ok = false;
                DialogResult result = messageBox.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.uSERBindingSource.RemoveCurrent();
                    this.uSERTableAdapter.Update(this.pOSDataSet.USER);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBoxForm = new MessageBoxForm("You Cannot Delete a Drug You Have Made Sale(s) for");
                messageBoxForm.Show();
            }
        }
    }

}
