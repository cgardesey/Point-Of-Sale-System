namespace Point_Of_Sale_System
{
    partial class MainInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UsernameLabel = new System.Windows.Forms.Button();
            this.pnlUserOptions = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnStockLevel = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCreditors = new System.Windows.Forms.Button();
            this.btnDebtors = new System.Windows.Forms.Button();
            this.btnPurchases = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnExpiredDrug = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.thresholdAlertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thresholdAlertTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.ThresholdAlertTableAdapter();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.pnlUserOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdAlertBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UsernameLabel.FlatAppearance.BorderSize = 0;
            this.UsernameLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.UsernameLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.UsernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsernameLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(1081, 71);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(140, 27);
            this.UsernameLabel.TabIndex = 177;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.UsernameLabel, "User");
            this.UsernameLabel.UseVisualStyleBackColor = false;
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // pnlUserOptions
            // 
            this.pnlUserOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserOptions.BackColor = System.Drawing.Color.White;
            this.pnlUserOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserOptions.Controls.Add(this.btnLogOut);
            this.pnlUserOptions.Controls.Add(this.btnChangePassword);
            this.pnlUserOptions.Location = new System.Drawing.Point(1028, 127);
            this.pnlUserOptions.Name = "pnlUserOptions";
            this.pnlUserOptions.Size = new System.Drawing.Size(193, 80);
            this.pnlUserOptions.TabIndex = 167;
            this.pnlUserOptions.Visible = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogOut.Location = new System.Drawing.Point(2, 41);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(189, 35);
            this.btnLogOut.TabIndex = 95;
            this.btnLogOut.Text = "   Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnLogOut, "Log Out");
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.DimGray;
            this.btnChangePassword.Location = new System.Drawing.Point(2, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(188, 35);
            this.btnChangePassword.TabIndex = 94;
            this.btnChangePassword.Text = "   Change Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnChangePassword, "Change Password");
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1316, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 27);
            this.btnExit.TabIndex = 168;
            this.btnExit.Text = "x";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolTip1.SetToolTip(this.btnExit, "Exit");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStockLevel
            // 
            this.btnStockLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStockLevel.BackColor = System.Drawing.Color.Gold;
            this.btnStockLevel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStockLevel.FlatAppearance.BorderSize = 0;
            this.btnStockLevel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnStockLevel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnStockLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockLevel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockLevel.ForeColor = System.Drawing.Color.White;
            this.btnStockLevel.Location = new System.Drawing.Point(963, 445);
            this.btnStockLevel.Name = "btnStockLevel";
            this.btnStockLevel.Size = new System.Drawing.Size(365, 35);
            this.btnStockLevel.TabIndex = 191;
            this.btnStockLevel.Text = "STOCK LEVEL";
            this.toolTip1.SetToolTip(this.btnStockLevel, "Low Stock Level");
            this.btnStockLevel.UseVisualStyleBackColor = false;
            this.btnStockLevel.Visible = false;
            this.btnStockLevel.Click += new System.EventHandler(this.btnStockLevel_Click_1);
            // 
            // btnNotifications
            // 
            this.btnNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotifications.BackColor = System.Drawing.Color.Gold;
            this.btnNotifications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnNotifications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnNotifications.ForeColor = System.Drawing.Color.White;
            this.btnNotifications.Location = new System.Drawing.Point(962, 401);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(368, 151);
            this.btnNotifications.TabIndex = 187;
            this.btnNotifications.Text = " Notifications";
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnNotifications, "Notifications");
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetPassword.BackColor = System.Drawing.Color.Gold;
            this.btnResetPassword.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnResetPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(963, 404);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(365, 35);
            this.btnResetPassword.TabIndex = 192;
            this.btnResetPassword.Text = "RESET PASSWORD";
            this.toolTip1.SetToolTip(this.btnResetPassword, "Reset Password");
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Visible = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1286, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 27);
            this.btnMinimize.TabIndex = 308;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // btnCreditors
            // 
            this.btnCreditors.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnCreditors.BackgroundImage = global::Point_Of_Sale_System.Properties.Resources.creditors_01;
            this.btnCreditors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCreditors.FlatAppearance.BorderSize = 0;
            this.btnCreditors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditors.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnCreditors.ForeColor = System.Drawing.Color.White;
            this.btnCreditors.Location = new System.Drawing.Point(224, 403);
            this.btnCreditors.Name = "btnCreditors";
            this.btnCreditors.Size = new System.Drawing.Size(175, 151);
            this.btnCreditors.TabIndex = 310;
            this.btnCreditors.Text = "Creditors  (Suppliers)";
            this.btnCreditors.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolTip1.SetToolTip(this.btnCreditors, "Suppliers");
            this.btnCreditors.UseVisualStyleBackColor = false;
            this.btnCreditors.Click += new System.EventHandler(this.btnCreditors_Click);
            // 
            // btnDebtors
            // 
            this.btnDebtors.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDebtors.BackgroundImage = global::Point_Of_Sale_System.Properties.Resources.debtor_01;
            this.btnDebtors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDebtors.FlatAppearance.BorderSize = 0;
            this.btnDebtors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebtors.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnDebtors.ForeColor = System.Drawing.Color.White;
            this.btnDebtors.Location = new System.Drawing.Point(31, 402);
            this.btnDebtors.Name = "btnDebtors";
            this.btnDebtors.Size = new System.Drawing.Size(175, 151);
            this.btnDebtors.TabIndex = 309;
            this.btnDebtors.Text = "Debtors";
            this.btnDebtors.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolTip1.SetToolTip(this.btnDebtors, "Debtors");
            this.btnDebtors.UseVisualStyleBackColor = false;
            this.btnDebtors.Click += new System.EventHandler(this.btnDebtors_Click);
            // 
            // btnPurchases
            // 
            this.btnPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPurchases.BackColor = System.Drawing.Color.Peru;
            this.btnPurchases.BackgroundImage = global::Point_Of_Sale_System.Properties.Resources.purchase_icon_01;
            this.btnPurchases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPurchases.FlatAppearance.BorderSize = 0;
            this.btnPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchases.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnPurchases.ForeColor = System.Drawing.Color.White;
            this.btnPurchases.Location = new System.Drawing.Point(766, 233);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Size = new System.Drawing.Size(368, 151);
            this.btnPurchases.TabIndex = 183;
            this.btnPurchases.Text = "Purchases";
            this.btnPurchases.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolTip1.SetToolTip(this.btnPurchases, "Purchases");
            this.btnPurchases.UseVisualStyleBackColor = false;
            this.btnPurchases.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSales.BackgroundImage = global::Point_Of_Sale_System.Properties.Resources.sales_01;
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Location = new System.Drawing.Point(419, 233);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(325, 320);
            this.btnSales.TabIndex = 170;
            this.btnSales.Text = "  Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolTip1.SetToolTip(this.btnSales, "Sales");
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Turquoise;
            this.btnSettings.BackgroundImage = global::Point_Of_Sale_System.Properties.Resources.Settin;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(766, 401);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(175, 151);
            this.btnSettings.TabIndex = 188;
            this.btnSettings.Text = "  Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolTip1.SetToolTip(this.btnSettings, "Settings");
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click_1);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Crimson;
            this.btnUsers.BackgroundImage = global::Point_Of_Sale_System.Properties.Resources.users;
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(31, 233);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(368, 151);
            this.btnUsers.TabIndex = 186;
            this.btnUsers.Text = "  Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolTip1.SetToolTip(this.btnUsers, "Users");
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click_1);
            // 
            // btnExpiredDrug
            // 
            this.btnExpiredDrug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpiredDrug.BackColor = System.Drawing.Color.Gold;
            this.btnExpiredDrug.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExpiredDrug.FlatAppearance.BorderSize = 0;
            this.btnExpiredDrug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnExpiredDrug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExpiredDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpiredDrug.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpiredDrug.ForeColor = System.Drawing.Color.White;
            this.btnExpiredDrug.Location = new System.Drawing.Point(962, 486);
            this.btnExpiredDrug.Name = "btnExpiredDrug";
            this.btnExpiredDrug.Size = new System.Drawing.Size(368, 35);
            this.btnExpiredDrug.TabIndex = 311;
            this.btnExpiredDrug.Text = "EXPIRED DRUG";
            this.toolTip1.SetToolTip(this.btnExpiredDrug, "EXPIRED DRUG");
            this.btnExpiredDrug.UseMnemonic = false;
            this.btnExpiredDrug.UseVisualStyleBackColor = false;
            this.btnExpiredDrug.Visible = false;
            this.btnExpiredDrug.Click += new System.EventHandler(this.btnExpiredDrug_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.BackgroundImage = global::Point_Of_Sale_System.Properties.Resources.stock;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1153, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 151);
            this.button1.TabIndex = 312;
            this.button1.Text = " Stock";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolTip1.SetToolTip(this.button1, " Stock");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(459, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 49);
            this.label2.TabIndex = 178;
            this.label2.Text = "Shop Name";
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRole.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.Orange;
            this.lblRole.Location = new System.Drawing.Point(1132, 106);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(40, 18);
            this.lblRole.TabIndex = 181;
            this.lblRole.Text = "ROLE";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(465, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 189;
            this.label1.Text = "id";
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // thresholdAlertBindingSource
            // 
            this.thresholdAlertBindingSource.DataMember = "ThresholdAlert";
            // 
            // thresholdAlertTableAdapter
            // 
            this.thresholdAlertTableAdapter.ClearBeforeFill = true;
            // 
            // lblThreshold
            // 
            this.lblThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblThreshold.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreshold.ForeColor = System.Drawing.Color.Orange;
            this.lblThreshold.Location = new System.Drawing.Point(169, 299);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(70, 18);
            this.lblThreshold.TabIndex = 313;
            this.lblThreshold.Text = "Threshold";
            this.lblThreshold.Visible = false;
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1354, 633);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.lblThreshold);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExpiredDrug);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnCreditors);
            this.Controls.Add(this.btnStockLevel);
            this.Controls.Add(this.btnDebtors);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnPurchases);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnNotifications);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.pnlUserOptions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainInterface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.Click += new System.EventHandler(this.MainInterface_Click);
            this.pnlUserOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thresholdAlertBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button UsernameLabel;
        internal System.Windows.Forms.Panel pnlUserOptions;
        internal System.Windows.Forms.Button btnLogOut;
        internal System.Windows.Forms.Button btnChangePassword;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Button btnStockLevel;
        internal System.Windows.Forms.Button btnSettings;
        internal System.Windows.Forms.Button btnNotifications;
        internal System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Timer timer2;
        internal System.Windows.Forms.Button btnPurchases;
        internal System.Windows.Forms.Button btnMinimize;
        internal System.Windows.Forms.Button btnDebtors;
        internal System.Windows.Forms.Button btnCreditors;
        internal System.Windows.Forms.Button btnExpiredDrug;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource thresholdAlertBindingSource;
        private POSDataSetTableAdapters.ThresholdAlertTableAdapter thresholdAlertTableAdapter;
        private System.Windows.Forms.Label lblThreshold;
    }
}