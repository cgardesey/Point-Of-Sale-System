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
    public partial class ResetPassword : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        public ResetPassword()
        {
            InitializeComponent();
            txtuserName.Text = "";
            txtpasswordHash.Text = "";
            btnReset.Enabled = false;            
        }
        private void userName()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select UserName from USERLOGIN where UserID ='" + userIDTextBox.Text + "'";
                cmd = new SqlCommand(sqlstr, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string userName = dr["UserName"].ToString();
                    txtuserName.Text = userName;
                }
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }

        }
        private void updatePass()
        {
            try
            {
                sqlstr = "Update PASSWORDRESET Set Status = 0  Where UserID = @UserID ";
                cmd = new SqlCommand(sqlstr, con);

                cmd.Parameters.AddWithValue("@UserID", userIDTextBox.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
            
        }
        private void update()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Update USERLOGIN Set UserName = @UserName, PasswordHash = @PasswordHash Where UserName = @UserName ";
                cmd = new SqlCommand(sqlstr, con);

                cmd.Parameters.AddWithValue("@Username", txtuserName.Text);
                cmd.Parameters.AddWithValue("@PasswordHash", lblHash.Text);

                cmd.ExecuteNonQuery();

                updatePass();
                MessageBoxForm messageBox = new MessageBoxForm(txtuserName.Text + " Password Reseted");
                messageBox.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }

        }
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
        public bool EnforceConstraints { get; set; }
        private void ResetPassword_Load(object sender, EventArgs e)
        {
            txtuserName.Text = "";
            txtpasswordHash.Text = "";
            pOSDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'pOSDataSet.USERLOGIN' table. You can move, or remove it, as needed.
            this.uSERLOGINTableAdapter.Fill(this.pOSDataSet.USERLOGIN);
            // TODO: This line of code loads data into the 'pOSDataSet.PASSWORDRESET' table. You can move, or remove it, as needed.
            this.pASSWORDRESETTableAdapter.FillByUserID(this.pOSDataSet.PASSWORDRESET);

        }

        private void dvgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userName();
            string password = generatePassword(6);
            txtpasswordHash.Text = password;
            btnReset.Enabled = true;
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            string password = generatePassword(6);
            txtpasswordHash.Text = password;
            btnReset.Enabled = true;
        }

        private void ButtonPassView_MouseCaptureChanged(object sender, EventArgs e)
        {
            txtpasswordHash.UseSystemPasswordChar = true;
            ButtonPassView.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.passwordblack));
            ButtonPassView.BackColor = Color.White;
        }

        private void ButtonPassView_MouseDown(object sender, MouseEventArgs e)
        {
            txtpasswordHash.UseSystemPasswordChar = false;
            ButtonPassView.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.passwordviewer));
            ButtonPassView.BackColor = Color.Black;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string hash = GetHashString(txtpasswordHash.Text);
            lblHash.Text = hash;
            update();
            txtuserName.Clear();
            txtpasswordHash.Clear();
            btnReset.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!(btnReset.Enabled))
            {
                this.Close();
            }
            else if (btnReset.Enabled)
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
                else
                    return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(btnReset.Enabled))
            {
                this.Close();
            }
            else if (btnReset.Enabled)
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
                else
                    return;
            }
        }

    }
}
