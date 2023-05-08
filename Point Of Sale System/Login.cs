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
    public partial class Login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        public Login()
        {
            InitializeComponent();
            AutoComplete();
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
        private void Login_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Orange, ButtonBorderStyle.Solid);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        #endregion
        private void userID()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select UserID FROM USERLOGIN WHERE UserName = '" + UsernameTextBox.Text + "'";
                cmd = new SqlCommand(sqlstr, con);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    userIDLabel.Text = dr["UserID"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void resetPassword()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Insert into PASSWORDRESET values (@UserID, @Status)";
                cmd = new SqlCommand(sqlstr, con);

                cmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(userIDLabel.Text));
                cmd.Parameters.AddWithValue("@Status", statusCheckBox.CheckState);
                cmd.ExecuteNonQuery();

                MessageBoxForm messageBox = new MessageBoxForm(" Contact Administrator for New Password ");
                messageBox.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void logIn()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select  PasswordHash, PasswordSalt from USERLOGIN where UserName ='" + UsernameTextBox.Text + "'";
                cmd = new SqlCommand(sqlstr, con);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    lblSalt.Text = dr["PasswordSalt"].ToString();
                    lblHash.Text = dr["PasswordHash"].ToString();                    
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void AutoComplete()
        {
            UsernameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            UsernameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select Username from USERLOGIN";
                cmd = new SqlCommand(sqlstr, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string username = dr["UserName"].ToString();
                    col.Add(username);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
            UsernameTextBox.AutoCompleteCustomSource = col;

        }
        private void ClearData()
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
        }
        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = MD5.Create();  //or use SHA1.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm("Enter UserName!");
                messageBox.ShowDialog();
            }
            else if (PasswordTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm("Enter Password!");
                messageBox.ShowDialog();
            }
            else if (UsernameTextBox.Text + PasswordTextBox != "")
            {
                logIn();
                string hash = GetHashString(PasswordTextBox.Text);
                lblNewHash.Text = hash;
                if (lblHash.Text == lblNewHash.Text)
                {
                    MainInterface mainInterface = new MainInterface(UsernameTextBox.Text);
                    mainInterface.Show();
                    ClearData();
                    this.Close();
                }
                else if (lblHash.Text != lblNewHash.Text)
                {
                    MessageBoxForm messageBox = new MessageBoxForm("Username Or Password is Incorrect!");
                    messageBox.ShowDialog();
                }


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

        private void lblForgotPass_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            userID();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblForgotPass_Click_1(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text != "")
            {
                resetPassword();
            }
            else if (UsernameTextBox.Text == "")
            {
                MessageBoxForm messageBox = new MessageBoxForm("Please Enter Username!");
                messageBox.ShowDialog();
            }
        }
    }
}
