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
    public partial class MainInterface : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        public MainInterface(string userName)
        {
            InitializeComponent();
            UsernameLabel.Text = userName;
            roleID();
            role();
            settings();
            timer1.Start();
            passwordReset();
            stockLevel();           
            threshold();
            aboutToExpire();
           
        }
        public string userName
        {
            get { return UsernameLabel.Text; }
            set { UsernameLabel.Text = value; }
        }
        private void settings()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select ShopName from SETTINGS";
                cmd = new SqlCommand(sqlstr, con);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label2.Text = dr["ShopName"].ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void stockLevel()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select * from STOCK where QuantityAvailable <= MinStockLevel";
                cmd = new SqlCommand(sqlstr, con);

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    btnStockLevel.Visible = true;

                    timer2.Tick += new EventHandler(timer2_Tick);
                }


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void Expired()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "SELECT * FROM EXPIREDDRUGVIEW WHERE  ExpiryDate <= GETDATE() AND QuantityRemaining > 0 AND ExpiryStatus = 0";
                cmd = new SqlCommand(sqlstr, con);

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Expired expired = new Expired();
                    expired.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void aboutToExpire()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "SELECT * FROM EXPIREDDRUGVIEW WHERE ExpiryDate <= @dateAdvance AND ExpiryDate > GETDATE() AND QuantityRemaining > 0";
                cmd = new SqlCommand(sqlstr, con);
                cmd.Parameters.AddWithValue("@dateAdvance", DateTime.Now.AddDays(Convert.ToInt32(lblThreshold.Text)).ToString());
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    //timer1.Stop();
                    //timer2.Stop();
                    btnExpiredDrug.Visible = true;
                    btnExpiredDrug.BackColor = btnExpiredDrug.BackColor = Color.Red;
                    con.Close();

                    con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                    con.Open();
                    sqlstr = "SELECT * FROM EXPIREDDRUGVIEW WHERE ExpiryDate <= @dateAdvance AND ExpiryDate > GETDATE() AND QuantityRemaining > 0 AND Acknowledged = 0";
                    cmd = new SqlCommand(sqlstr, con);
                    cmd.Parameters.AddWithValue("@dateAdvance", DateTime.Now.AddDays(Convert.ToInt32(lblThreshold.Text)).ToString());
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        btnExpiredDrug.Visible = true;
                        timer2.Tick += new EventHandler(timer2_Tick);
                        //timer1.Start();                      
                    }
                    con.Close();
                }
                else
                {
                    btnExpiredDrug.Visible = false;
                    con.Close();
                }               
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void passwordReset()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select * from PASSWORDRESET where Status = 1";
                cmd = new SqlCommand(sqlstr, con);

                dr = cmd.ExecuteReader();
                if (dr.HasRows && label1.Text == "1")
                {
                    btnResetPassword.Visible = true;

                    timer2.Tick += new EventHandler(timer2_Tick);
                }
                else
                {
                    //btnResetPassword.Visible = false;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void roleID()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select RoleID FROM USERLOGIN WHERE UserName = '" + UsernameLabel.Text + "'";
                cmd = new SqlCommand(sqlstr, con);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label1.Text = dr["RoleID"].ToString();
                }
                if (label1.Text != "1")
                {
                    btnResetPassword.Visible = false;
                    btnUsers.Enabled = false;
                    btnSettings.Enabled = false;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }
        private void role()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select Role FROM Role WHERE RoleID = '" + label1.Text + "'";
                cmd = new SqlCommand(sqlstr, con);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblRole.Text = dr["Role"].ToString();
                }                

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void threshold()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True");
                con.Open();
                sqlstr = "Select Threshold FROM ThresholdAlert";
                cmd = new SqlCommand(sqlstr, con);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblThreshold.Text = dr["Threshold"].ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBoxForm messageBox = new MessageBoxForm(" Are You Sure You Want To Exit? ");
            messageBox.yes = true;
            messageBox.no = true;
            messageBox.ok = false;
            DialogResult result = messageBox.ShowDialog();
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {
            pnlUserOptions.Visible = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangePassword changePassword = new ChangePassword(UsernameLabel.Text);
            changePassword.ShowDialog();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
           
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Close();
            Stock stock = new Stock(UsernameLabel.Text);
            stock.ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Inventory inventory = new Inventory(UsernameLabel.Text);
            //inventory.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.Close();
            Sales sales = new Sales(UsernameLabel.Text);
            sales.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReoprts_Click(object sender, EventArgs e)
        {
           
        }

        private void MainInterface_Click(object sender, EventArgs e)
        {
            pnlUserOptions.Visible = false;
        }

        private void btnStockLevel_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btnResetPassword.BackColor == Color.Gold)
            {
                btnResetPassword.BackColor = Color.Red;
            }
            else
                btnResetPassword.BackColor = Color.Gold;


            if (btnStockLevel.BackColor == Color.Gold)
            {
                btnStockLevel.BackColor = Color.Red;
            }
            else
                btnStockLevel.BackColor = Color.Gold;


            if (btnExpiredDrug.BackColor == Color.Gold)
            {
                btnExpiredDrug.BackColor = Color.Red;
            }
            else
            {
                btnExpiredDrug.BackColor = Color.Gold;
            }
        }

        private void btnUsers_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Users users = new Users(UsernameLabel.Text);
            users.ShowDialog();
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.ShowDialog();
            settings();
            aboutToExpire();
        }

        private void btnStockLevel_Click_1(object sender, EventArgs e)
        {
            StockLevel stockLevel = new StockLevel(UsernameLabel.Text);
            stockLevel.ShowDialog();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword();
            resetPassword.ShowDialog();
            passwordReset();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (btnResetPassword.BackColor == Color.Gold)
            {
                btnResetPassword.BackColor = Color.Red;
            }
            else
            {
                btnResetPassword.BackColor = Color.Gold;
            }
              

            if (btnStockLevel.BackColor == Color.Gold)
            {
                btnStockLevel.BackColor = Color.Red;
            }
            else
            {
                btnStockLevel.BackColor = Color.Gold;
            }

            if (btnExpiredDrug.BackColor == Color.Gold)
            {
                btnExpiredDrug.BackColor = Color.Red;
            }
            else
            {
                btnExpiredDrug.BackColor = Color.Gold;
            }
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Purchases purchases = new Purchases(UsernameLabel.Text);
            purchases.ShowDialog();
        }

        private void btnDebtors_Click(object sender, EventArgs e)
        {
            this.Close();
            Debtors debtors = new Debtors(UsernameLabel.Text);
            debtors.ShowDialog();
        }

        private void btnCreditors_Click(object sender, EventArgs e)
        {
            this.Close();
            Creditors creditors = new Creditors(UsernameLabel.Text);
            creditors.ShowDialog();
        }

        private void btnExpiredDrug_Click(object sender, EventArgs e)
        {
            ExpiredDamaged expiredDamaged = new ExpiredDamaged();
            expiredDamaged.ShowDialog();
            aboutToExpire();           
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Stock stock = new Stock(UsernameLabel.Text);
            stock.ShowDialog();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {

        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            Expired();
        }
    }
}
