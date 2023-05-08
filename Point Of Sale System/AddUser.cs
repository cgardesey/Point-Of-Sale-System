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
    public partial class AddUser : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string sqlstr;
        SqlDataReader dr;
        public AddUser()
        {
            InitializeComponent();
            role();
            title();
            clearData();
            firstNameTextBox.Focus();
            //btnSaveDetails.Enabled = false;
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
        private void AddUser_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }


        private void AddUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void AddUser_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void AddUser_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
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

        private void Label1_Move(object sender, EventArgs e)
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
            titleIDComboBox.Text = null;
            roleComboBox.Text = null;
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
                roleComboBox.DataSource = ds.Tables[0];
                roleComboBox.DisplayMember = "Role";
                roleComboBox.ValueMember = "RoleID";
                roleComboBox.BindingContext = this.BindingContext;
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
        private void save()
        {
            if (firstNameTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter First Name ");
                messageBox.ShowDialog();
            }
            else if (lastNameTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter Last Name ");
                messageBox.ShowDialog();
            }
            else if (genderComboBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Select Gender ");
                messageBox.ShowDialog();
            }
            else if (roleComboBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Select Role ");
                messageBox.ShowDialog();
            }
            else if (phoneNumberTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter Phone Number ");
                messageBox.ShowDialog();
            }
            else if ((firstNameTextBox.Text + lastNameTextBox.Text + genderComboBox.Text + roleComboBox.Text + phoneNumberTextBox.Text) != "")
            {
                    MemoryStream ms = new MemoryStream();
                if (picturePictureBox.Image != null)
                {
                    picturePictureBox.Image.Save(ms, picturePictureBox.Image.RawFormat);
                }
                    
                    byte[] data = ms.GetBuffer();

                try
                {
                    this.uSERBindingSource.AddNew();
                    ((DataRowView)uSERBindingSource.Current)["TitleID"] = Convert.ToInt32(titleIDTextBox.Text);
                    ((DataRowView)uSERBindingSource.Current)["RoleID"] = Convert.ToInt32(roleIDTextBox.Text);
                    ((DataRowView)uSERBindingSource.Current)["FirstName"] = firstNameTextBox.Text;
                    ((DataRowView)uSERBindingSource.Current)["LastName"] = lastNameTextBox.Text;
                    ((DataRowView)uSERBindingSource.Current)["OtherName"] = otherNameTextBox.Text;
                    ((DataRowView)uSERBindingSource.Current)["Gender"] = genderComboBox.Text;
                    ((DataRowView)uSERBindingSource.Current)["DateOfBirth"] = dateOfBirthDateTimePicker.Text;
                    ((DataRowView)uSERBindingSource.Current)["DateOfEmployment"] = dateOfBirthDateTimePicker.Text;
                    ((DataRowView)uSERBindingSource.Current)["PhoneNumber"] = phoneNumberTextBox.Text;
                    ((DataRowView)uSERBindingSource.Current)["Address"] = addressTextBox.Text;
                    ((DataRowView)uSERBindingSource.Current)["Picture"] = data;
                    
                    ((DataRowView)uSERBindingSource.Current)["Status"] = statusCheckBox.CheckState;

                    this.Validate();
                    this.uSERBindingSource.EndEdit();
                    this.uSERTableAdapter.Update(this.pOSDataSet.USER);

                    MessageBoxForm messageBox = new MessageBoxForm(" User Successfully Created! ");
                    messageBox.ShowDialog();
                    userID();
                    userLoginDetails();
                    clearData();
                    //btnSaveDetails.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                    messageBox.ShowDialog();
                }
            }
        }
        private void checkExisting()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
            con.Open();
            sqlstr = "SELECT PhoneNumber from [USER] where PhoneNumber = '" + phoneNumberTextBox.Text + "'";
            cmd = new SqlCommand(sqlstr, con);

            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBoxForm messageBox = new MessageBoxForm("User with " + phoneNumberTextBox.Text + " Already Exist");
                messageBox.ShowDialog();
            }
            dr.Close();
            con.Close();
        }
        private void userLoginDetails()
        {
            UserLoginDetails userLogin = new UserLoginDetails(firstNameTextBox.Text, lastNameTextBox.Text, otherNameTextBox.Text, roleComboBox.Text, roleIDTextBox.Text, userIDTextBox.Text);
            userLogin.ShowDialog();            
        }
        private void userID()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select UserID from [USER] where PhoneNumber = '" + phoneNumberTextBox.Text + "'";
                cmd = new SqlCommand(sqlstr, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    userIDTextBox.Text = dr["UserID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
                dr.Close();
                con.Close();
            }
        }

        private void titleIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (titleIDComboBox.SelectedItem != null)
            {
                DataRowView drv = titleIDComboBox.SelectedItem as DataRowView;
                titleIDTextBox.Text = drv.Row["TitleID"].ToString();
            }
        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleComboBox.SelectedItem != null)
            {
                DataRowView drv = roleComboBox.SelectedItem as DataRowView;
               roleIDTextBox.Text = drv.Row["RoleID"].ToString();
            }
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            //checkExisting();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            browseImage();
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            save();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void AddUser_Load(object sender, EventArgs e)
        {

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

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
