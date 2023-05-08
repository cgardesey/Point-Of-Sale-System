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
    public partial class UserLoginDetails : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string sqlstr;
        SqlDataReader dr;
    
        public UserLoginDetails(string firstName, string lastName, string otherName, string role, string roleID, string userID)
        {
            InitializeComponent();
            firstNameLabel.Text = firstName;
            lastNameLabel.Text = lastName;
            otherNamelabel.Text = otherName;
            roleIDLabel.Text = roleID;
            userIDLabel.Text = userID;

            userTextBox.Text = firstName + " " + otherName + " " + lastName;
            roleTextBox.Text = role;

            UsernameTextBox.Text = firstNameLabel.Text.Substring(0, 1).ToLower() + lastNameLabel.Text.ToLower();
            string password = generatePassword(6);
            PasswordTextBox.Text = password;

            string salt = passwordSalt(10);
            lblSalt.Text = salt;

            string hash = GetHashString(PasswordTextBox.Text);
            lblHash.Text = hash;
            
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
        private void EmployeeLoginDetails_Paint(object sender, PaintEventArgs e)
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

        //GENERATE RANDOM STRING FOR PASSWORD
        public static string generatePassword(int maxSize)
        {
            char[] chars = new char[62];
            chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder stringBuilder = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                stringBuilder.Append(chars[b % (chars.Length)]);
            }
            return stringBuilder.ToString();
        }
        //RANDOM STRING FOR PASSWORD SALT
        public static string passwordSalt(int maxSize)
        {
            char[] chars = new char[62];
            chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder stringBuilder = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                stringBuilder.Append(chars[b % (chars.Length)]);
            }
            return stringBuilder.ToString();
        }
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
        public void userLogin()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "SELECT UserName from [USERLOGIN] where UserName = '" + UsernameTextBox.Text + "'";
                cmd = new SqlCommand(sqlstr, con);

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBoxForm messageBox = new MessageBoxForm(UsernameTextBox.Text + " Already Exist");
                    messageBox.ShowDialog();
                }
                else if (!dr.HasRows)
                {                  
                    try
                    {
                        this.uSERLOGINBindingSource.AddNew();
                        ((DataRowView)uSERLOGINBindingSource.Current)["UserName"] = UsernameTextBox.Text;
                        ((DataRowView)uSERLOGINBindingSource.Current)["PasswordHash"] = lblHash.Text;
                        ((DataRowView)uSERLOGINBindingSource.Current)["RoleID"] = roleIDLabel.Text;
                        ((DataRowView)uSERLOGINBindingSource.Current)["UserID"] = userIDLabel.Text;
                        ((DataRowView)uSERLOGINBindingSource.Current)["PasswordSalt"] = lblSalt.Text;

                        this.Validate();
                        this.uSERLOGINBindingSource.EndEdit();
                        this.uSERLOGINTableAdapter.Update(this.pOSDataSet.USERLOGIN);


                        DialogResult result;
                    
                        MessageBoxForm messageBox = new MessageBoxForm("Username and Password Successfully Created!");
                        result = messageBox.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                        messageBox.ShowDialog();
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
           
        }
        private void ButtonPassView_MouseCaptureChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
            ButtonPassView.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.passwordblack));
            ButtonPassView.BackColor = Color.White;
        }

        private void ButtonPassView_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = false;
            ButtonPassView.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.passwordviewer));
            ButtonPassView.BackColor = Color.Black;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            userLogin();
            //this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
                       
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            lblHash.Text = GetHashString(PasswordTextBox.Text);
        }
    }
}
