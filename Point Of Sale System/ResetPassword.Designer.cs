namespace Point_Of_Sale_System
{
    partial class ResetPassword
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
            System.Windows.Forms.Label Label1;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordHashLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvgSearch = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uSERLOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSet = new Point_Of_Sale_System.POSDataSet();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pASSWORDRESETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ButtonPassView = new System.Windows.Forms.Button();
            this.lblHash = new System.Windows.Forms.Label();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.txtpasswordHash = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.pASSWORDRESETTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.PASSWORDRESETTableAdapter();
            this.uSERLOGINTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.USERLOGINTableAdapter();
            this.tableAdapterManager = new Point_Of_Sale_System.POSDataSetTableAdapters.TableAdapterManager();
            Label1 = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            passwordHashLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERLOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASSWORDRESETBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.Dock = System.Windows.Forms.DockStyle.Top;
            Label1.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            Label1.ForeColor = System.Drawing.Color.Orange;
            Label1.Location = new System.Drawing.Point(0, 0);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(463, 40);
            Label1.TabIndex = 241;
            Label1.Text = " Reset Password";
            Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(51, 29);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(80, 18);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "User Name:";
            // 
            // passwordHashLabel
            // 
            passwordHashLabel.AutoSize = true;
            passwordHashLabel.Location = new System.Drawing.Point(51, 86);
            passwordHashLabel.Name = "passwordHashLabel";
            passwordHashLabel.Size = new System.Drawing.Size(71, 18);
            passwordHashLabel.TabIndex = 2;
            passwordHashLabel.Text = "Password:";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 33);
            this.panel1.TabIndex = 243;
            // 
            // dvgSearch
            // 
            this.dvgSearch.AllowUserToAddRows = false;
            this.dvgSearch.AllowUserToDeleteRows = false;
            this.dvgSearch.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dvgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dvgSearch.DataSource = this.pASSWORDRESETBindingSource;
            this.dvgSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgSearch.Location = new System.Drawing.Point(25, 73);
            this.dvgSearch.MultiSelect = false;
            this.dvgSearch.Name = "dvgSearch";
            this.dvgSearch.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dvgSearch.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.dvgSearch.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dvgSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgSearch.Size = new System.Drawing.Size(134, 252);
            this.dvgSearch.TabIndex = 244;
            this.dvgSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgSearch_CellContentClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.DataSource = this.uSERLOGINBindingSource;
            this.userIDDataGridViewTextBoxColumn.DisplayMember = "UserName";
            this.userIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.userIDDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userIDDataGridViewTextBoxColumn.ToolTipText = "User";
            this.userIDDataGridViewTextBoxColumn.ValueMember = "UserID";
            this.userIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // uSERLOGINBindingSource
            // 
            this.uSERLOGINBindingSource.DataMember = "USERLOGIN";
            this.uSERLOGINBindingSource.DataSource = this.pOSDataSet;
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.statusDataGridViewCheckBoxColumn.Visible = false;
            // 
            // pASSWORDRESETBindingSource
            // 
            this.pASSWORDRESETBindingSource.DataMember = "PASSWORDRESET";
            this.pASSWORDRESETBindingSource.DataSource = this.pOSDataSet;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 252);
            this.panel3.TabIndex = 246;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ButtonPassView);
            this.panel4.Controls.Add(this.lblHash);
            this.panel4.Controls.Add(userNameLabel);
            this.panel4.Controls.Add(this.txtuserName);
            this.panel4.Controls.Add(passwordHashLabel);
            this.panel4.Controls.Add(this.txtpasswordHash);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(159, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 252);
            this.panel4.TabIndex = 247;
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
            this.ButtonPassView.Location = new System.Drawing.Point(232, 108);
            this.ButtonPassView.Name = "ButtonPassView";
            this.ButtonPassView.Size = new System.Drawing.Size(19, 20);
            this.ButtonPassView.TabIndex = 239;
            this.ButtonPassView.UseVisualStyleBackColor = false;
            this.ButtonPassView.MouseCaptureChanged += new System.EventHandler(this.ButtonPassView_MouseCaptureChanged);
            this.ButtonPassView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPassView_MouseDown);
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.ForeColor = System.Drawing.Color.Orange;
            this.lblHash.Location = new System.Drawing.Point(6, 195);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(44, 18);
            this.lblHash.TabIndex = 239;
            this.lblHash.Text = "label1";
            this.lblHash.Visible = false;
            // 
            // txtuserName
            // 
            this.txtuserName.BackColor = System.Drawing.Color.White;
            this.txtuserName.Location = new System.Drawing.Point(54, 50);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.ReadOnly = true;
            this.txtuserName.Size = new System.Drawing.Size(198, 23);
            this.txtuserName.TabIndex = 1;
            // 
            // txtpasswordHash
            // 
            this.txtpasswordHash.BackColor = System.Drawing.Color.White;
            this.txtpasswordHash.Location = new System.Drawing.Point(54, 107);
            this.txtpasswordHash.Name = "txtpasswordHash";
            this.txtpasswordHash.Size = new System.Drawing.Size(198, 23);
            this.txtpasswordHash.TabIndex = 3;
            this.txtpasswordHash.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 47);
            this.panel2.TabIndex = 245;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(329, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 36);
            this.btnReset.TabIndex = 233;
            this.btnReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.btnReset, "Reset");
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(437, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 27);
            this.button1.TabIndex = 248;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.button1, "Close");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pASSWORDRESETBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(40, 156);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(100, 23);
            this.userIDTextBox.TabIndex = 240;
            // 
            // pASSWORDRESETTableAdapter
            // 
            this.pASSWORDRESETTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.CREDITORSVIEWTableAdapter = null;
            this.tableAdapterManager.DAMAGEDSTOCKTableAdapter = null;
            this.tableAdapterManager.DEBTORSTableAdapter = null;
            this.tableAdapterManager.DEBTORSVIEWTableAdapter = null;

            this.tableAdapterManager.OTHERCOMPLAINTTableAdapter = null;
            this.tableAdapterManager.PASSWORDRESETTableAdapter = this.pASSWORDRESETTableAdapter;
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
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(463, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dvgSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(Label1);
            this.Controls.Add(this.userIDTextBox);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERLOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASSWORDRESETBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dvgSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button btnReset;
        private POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource pASSWORDRESETBindingSource;
        private POSDataSetTableAdapters.PASSWORDRESETTableAdapter pASSWORDRESETTableAdapter;
        private System.Windows.Forms.BindingSource uSERLOGINBindingSource;
        private POSDataSetTableAdapters.USERLOGINTableAdapter uSERLOGINTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.TextBox txtpasswordHash;
        private POSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblHash;
        internal System.Windows.Forms.Button ButtonPassView;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}