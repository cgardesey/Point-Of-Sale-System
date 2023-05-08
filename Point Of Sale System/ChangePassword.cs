using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sale_System
{
    public partial class ChangePassword : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        public ChangePassword(string userName)
        {
            InitializeComponent();
            UsernameTextBox.Text = userName;
            oldPassword();
            OldPassTextBox.Focus();
            btnChangePassword.Enabled = false;
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
        private void ChangePassword_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void ChangePassword_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void ChangePassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void ChangePassword_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        #endregion

        #region View Password
        private void btnViewPass1_MouseCaptureChanged(object sender, EventArgs e)
        {
            OldPassTextBox.UseSystemPasswordChar = true;
            btnViewPass1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.passwordblack));
            btnViewPass1.BackColor = Color.White;
        }

        private void btnViewPass1_MouseDown(object sender, MouseEventArgs e)
        {
            OldPassTextBox.UseSystemPasswordChar = false;
            btnViewPass1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.passwordviewer));
            btnViewPass1.BackColor = Color.Black;
        }

        private void btnViewPass2_MouseCaptureChanged(object sender, EventArgs e)
        {
            NewPassTextBox.UseSystemPasswordChar = true;
            btnViewPass2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.passwordblack));
            btnViewPass2.BackColor = Color.White;
        }

        private void btnViewPass2_MouseDown(object sender, MouseEventArgs e)
        {
            NewPassTextBox.UseSystemPasswordChar = false;
            btnViewPass1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.passwordviewer));
            btnViewPass1.BackColor = Color.Black;
        }

        private void btnViewPass3_MouseCaptureChanged(object sender, EventArgs e)
        {
            confirmPassTextBox.UseSystemPasswordChar = true;
            btnViewPass3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.passwordblack));
            btnViewPass3.BackColor = Color.White;
        }

        private void btnViewPass3_MouseDown(object sender, MouseEventArgs e)
        {
            confirmPassTextBox.UseSystemPasswordChar = false;
            btnViewPass3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.passwordviewer));
            btnViewPass3.BackColor = Color.Black;
        }
        #endregion

        //PASSWORD HASH ARRAY
        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = MD5.Create();  //or use SHA1.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        //PASSWORD HASH STRING
        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
        private void changePassword()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select Username from USERLOGIN where Username ='" + UsernameTextBox.Text + "'";
                cmd = new SqlCommand(sqlstr, con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                    con.Open();
                    sqlstr = "Update USERLOGIN Set UserName = @UserName, PasswordHash = @PasswordHash Where UserName = @UserName ";
                    cmd = new SqlCommand(sqlstr, con);

                    cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                    cmd.Parameters.AddWithValue("@PasswordHash", lblHash.Text);

                    cmd.ExecuteNonQuery();

                    MessageBoxForm messageBox = new MessageBoxForm("Password Successfully Changed!");
                    messageBox.ShowDialog();

                    this.Close();
                    Login login = new Login();
                    login.Show();
                    con.Close();
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void oldPassword()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select  PasswordHash from USERLOGIN where UserName ='" + UsernameTextBox.Text + "'";
                cmd = new SqlCommand(sqlstr, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblOldPass.Text = dr["PasswordHash"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string oldHash = GetHashString(OldPassTextBox.Text);
            lblPassword.Text = oldHash;
            
            if (OldPassTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm("Please Enter Old Password!");
                messageBox.ShowDialog();
            }
            else if (NewPassTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm("Please Enter New Password!");
                messageBox.ShowDialog();
            }
            else if (confirmPassTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm("Please Confirm New Password!");
                messageBox.ShowDialog();
            }
            else if (lblOldPass.Text != lblPassword.Text)
            {
                MessageBoxForm messageBox = new MessageBoxForm("Old Password is Incorrect!");
                messageBox.ShowDialog();
            }
            else if (confirmPassTextBox.Text != NewPassTextBox.Text)
            {
                MessageBoxForm messageBox = new MessageBoxForm("Passwords Do Not Macth!");
                messageBox.ShowDialog();
            }
            else 
            {
                string hash = GetHashString(NewPassTextBox.Text);
                lblHash.Text = hash;
                changePassword();
                btnChangePassword.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (!(btnChangePassword.Enabled))
            {
                this.Close();
                MainInterface mainInterface = new MainInterface(UsernameTextBox.Text);
                mainInterface.Show();
            }
            else if (btnChangePassword.Enabled)
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

        private void confirmPassTextBox_TextChanged(object sender, EventArgs e)
        {
            btnChangePassword.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(btnChangePassword.Enabled))
            {
                this.Close();
            }
            else if (btnChangePassword.Enabled)
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


        
    }
}
