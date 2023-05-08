namespace Point_Of_Sale_System
{
    partial class UserLoginDetails
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
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label UsernameLabel;
            System.Windows.Forms.Label PasswordLabel;
            System.Windows.Forms.Label roleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginDetails));
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.ButtonPassView = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.otherNamelabel = new System.Windows.Forms.Label();
            this.roleIDLabel = new System.Windows.Forms.Label();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.lblHash = new System.Windows.Forms.Label();
            this.lblSalt = new System.Windows.Forms.Label();
            this.pOSDataSet = new Point_Of_Sale_System.POSDataSet();
            this.uSERLOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERLOGINTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.USERLOGINTableAdapter();
            this.tableAdapterManager = new Point_Of_Sale_System.POSDataSetTableAdapters.TableAdapterManager();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            employeeIDLabel = new System.Windows.Forms.Label();
            UsernameLabel = new System.Windows.Forms.Label();
            PasswordLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERLOGINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(55, 101);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(41, 18);
            employeeIDLabel.TabIndex = 182;
            employeeIDLabel.Text = "User:";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new System.Drawing.Point(55, 159);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new System.Drawing.Size(75, 18);
            UsernameLabel.TabIndex = 177;
            UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new System.Drawing.Point(55, 188);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new System.Drawing.Size(71, 18);
            PasswordLabel.TabIndex = 178;
            PasswordLabel.Text = "Password:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new System.Drawing.Point(55, 130);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(39, 18);
            roleLabel.TabIndex = 184;
            roleLabel.Text = "Role:";
            // 
            // userTextBox
            // 
            this.userTextBox.BackColor = System.Drawing.Color.White;
            this.userTextBox.Location = new System.Drawing.Point(152, 98);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.ReadOnly = true;
            this.userTextBox.Size = new System.Drawing.Size(262, 23);
            this.userTextBox.TabIndex = 183;
            this.userTextBox.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(6, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 34);
            this.label1.TabIndex = 180;
            this.label1.Text = "User Login Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(421, 268);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(69, 27);
            this.btnOK.TabIndex = 181;
            this.btnOK.Text = "&OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ButtonPassView
            // 
            this.ButtonPassView.BackColor = System.Drawing.Color.White;
            this.ButtonPassView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPassView.BackgroundImage")));
            this.ButtonPassView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonPassView.FlatAppearance.BorderSize = 0;
            this.ButtonPassView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ButtonPassView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonPassView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPassView.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPassView.ForeColor = System.Drawing.Color.White;
            this.ButtonPassView.Location = new System.Drawing.Point(395, 187);
            this.ButtonPassView.Name = "ButtonPassView";
            this.ButtonPassView.Size = new System.Drawing.Size(19, 20);
            this.ButtonPassView.TabIndex = 179;
            this.ButtonPassView.UseVisualStyleBackColor = false;
            this.ButtonPassView.MouseCaptureChanged += new System.EventHandler(this.ButtonPassView_MouseCaptureChanged);
            this.ButtonPassView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPassView_MouseDown);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.White;
            this.UsernameTextBox.Location = new System.Drawing.Point(152, 156);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(262, 23);
            this.UsernameTextBox.TabIndex = 175;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.Location = new System.Drawing.Point(152, 185);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(262, 23);
            this.PasswordTextBox.TabIndex = 176;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // roleTextBox
            // 
            this.roleTextBox.BackColor = System.Drawing.Color.White;
            this.roleTextBox.Location = new System.Drawing.Point(152, 127);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.ReadOnly = true;
            this.roleTextBox.Size = new System.Drawing.Size(262, 23);
            this.roleTextBox.TabIndex = 185;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(108, 62);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(44, 18);
            this.firstNameLabel.TabIndex = 186;
            this.firstNameLabel.Text = "label2";
            this.firstNameLabel.Visible = false;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(158, 62);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(44, 18);
            this.lastNameLabel.TabIndex = 187;
            this.lastNameLabel.Text = "label3";
            this.lastNameLabel.Visible = false;
            // 
            // otherNamelabel
            // 
            this.otherNamelabel.AutoSize = true;
            this.otherNamelabel.Location = new System.Drawing.Point(208, 62);
            this.otherNamelabel.Name = "otherNamelabel";
            this.otherNamelabel.Size = new System.Drawing.Size(44, 18);
            this.otherNamelabel.TabIndex = 188;
            this.otherNamelabel.Text = "label4";
            this.otherNamelabel.Visible = false;
            // 
            // roleIDLabel
            // 
            this.roleIDLabel.AutoSize = true;
            this.roleIDLabel.Location = new System.Drawing.Point(308, 62);
            this.roleIDLabel.Name = "roleIDLabel";
            this.roleIDLabel.Size = new System.Drawing.Size(44, 18);
            this.roleIDLabel.TabIndex = 189;
            this.roleIDLabel.Text = "label4";
            this.roleIDLabel.Visible = false;
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Location = new System.Drawing.Point(258, 62);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(44, 18);
            this.userIDLabel.TabIndex = 190;
            this.userIDLabel.Text = "label4";
            this.userIDLabel.Visible = false;
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(8, 268);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(44, 18);
            this.lblHash.TabIndex = 191;
            this.lblHash.Text = "label4";
            this.lblHash.Visible = false;
            // 
            // lblSalt
            // 
            this.lblSalt.AutoSize = true;
            this.lblSalt.Location = new System.Drawing.Point(8, 240);
            this.lblSalt.Name = "lblSalt";
            this.lblSalt.Size = new System.Drawing.Size(44, 18);
            this.lblSalt.TabIndex = 192;
            this.lblSalt.Text = "label4";
            this.lblSalt.Visible = false;
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERLOGINBindingSource
            // 
            this.uSERLOGINBindingSource.DataMember = "USERLOGIN";
            this.uSERLOGINBindingSource.DataSource = this.pOSDataSet;
            // 
            // uSERLOGINTableAdapter
            // 
            this.uSERLOGINTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.COMPLAINTTableAdapter = null;
            this.tableAdapterManager.CREDITORSTableAdapter = null;
            this.tableAdapterManager.DAMAGEDSTOCKTableAdapter = null;
            this.tableAdapterManager.DEBTORSTableAdapter = null;
            this.tableAdapterManager.OTHERCOMPLAINTTableAdapter = null;
            this.tableAdapterManager.PASSWORDRESETTableAdapter = null;
            this.tableAdapterManager.PRODUCTRETURNTableAdapter = null;
            this.tableAdapterManager.PURCHASERETURNTableAdapter = null;
            this.tableAdapterManager.PURCHASESCARTTableAdapter = null;
            this.tableAdapterManager.PURCHASETableAdapter = null;
            this.tableAdapterManager.ROLETableAdapter = null;
            this.tableAdapterManager.SALESCARTTableAdapter = null;
            this.tableAdapterManager.SALETableAdapter = null;
            this.tableAdapterManager.SETTINGSTableAdapter = null;

            this.tableAdapterManager.STOCKTableAdapter = null;
            this.tableAdapterManager.TITLETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Point_Of_Sale_System.POSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERLOGINTableAdapter = this.uSERLOGINTableAdapter;
            this.tableAdapterManager.USERTableAdapter = null;
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
            this.btnMinimize.Location = new System.Drawing.Point(409, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(55, 27);
            this.btnMinimize.TabIndex = 193;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(440, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 27);
            this.btnExit.TabIndex = 194;
            this.btnExit.Text = "x";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // UserLoginDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(502, 307);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSalt);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.userIDLabel);
            this.Controls.Add(this.roleIDLabel);
            this.Controls.Add(this.otherNamelabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(roleLabel);
            this.Controls.Add(this.roleTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ButtonPassView);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(UsernameLabel);
            this.Controls.Add(PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLoginDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeLoginDetails";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EmployeeLoginDetails_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERLOGINBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Button ButtonPassView;
        internal System.Windows.Forms.TextBox UsernameTextBox;
        internal System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label otherNamelabel;
        private System.Windows.Forms.Label roleIDLabel;
        private System.Windows.Forms.Label userIDLabel;
        private POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource uSERLOGINBindingSource;
        private POSDataSetTableAdapters.USERLOGINTableAdapter uSERLOGINTableAdapter;
        private POSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.Label lblSalt;
        internal System.Windows.Forms.Button btnMinimize;
        internal System.Windows.Forms.Button btnExit;
    }
}