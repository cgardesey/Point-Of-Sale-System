namespace Point_Of_Sale_System
{
    partial class EditUser
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
            System.Windows.Forms.Label titleIDLabel;
            System.Windows.Forms.Label roleIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label otherNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label dateOfEmploymentLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.dvgSearch = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSet = new Point_Of_Sale_System.POSDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSaveDetails = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tITLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Point_Of_Sale_System.POSDataSetTableAdapters.TableAdapterManager();
            this.uSERTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.USERTableAdapter();
            this.titleIDComboBox = new System.Windows.Forms.ComboBox();
            this.tITLEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roleIDComboBox = new System.Windows.Forms.ComboBox();
            this.rOLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.otherNameTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfEmploymentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.tITLETableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.TITLETableAdapter();
            this.rOLETableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.ROLETableAdapter();
            Label1 = new System.Windows.Forms.Label();
            titleIDLabel = new System.Windows.Forms.Label();
            roleIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            otherNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            dateOfEmploymentLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tITLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tITLEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.Font = new System.Drawing.Font("Trebuchet MS", 17F);
            Label1.ForeColor = System.Drawing.Color.Orange;
            Label1.Location = new System.Drawing.Point(3, 5);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(1048, 40);
            Label1.TabIndex = 141;
            Label1.Text = "  Edit User";
            Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            Label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove);
            Label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseUp);
            // 
            // titleIDLabel
            // 
            titleIDLabel.AutoSize = true;
            titleIDLabel.Location = new System.Drawing.Point(45, 74);
            titleIDLabel.Name = "titleIDLabel";
            titleIDLabel.Size = new System.Drawing.Size(41, 18);
            titleIDLabel.TabIndex = 197;
            titleIDLabel.Text = "Title:";
            // 
            // roleIDLabel
            // 
            roleIDLabel.AutoSize = true;
            roleIDLabel.Location = new System.Drawing.Point(45, 106);
            roleIDLabel.Name = "roleIDLabel";
            roleIDLabel.Size = new System.Drawing.Size(39, 18);
            roleIDLabel.TabIndex = 199;
            roleIDLabel.Text = "Role:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(45, 138);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(80, 18);
            firstNameLabel.TabIndex = 201;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(45, 167);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(78, 18);
            lastNameLabel.TabIndex = 203;
            lastNameLabel.Text = "Last Name:";
            // 
            // otherNameLabel
            // 
            otherNameLabel.AutoSize = true;
            otherNameLabel.Location = new System.Drawing.Point(45, 196);
            otherNameLabel.Name = "otherNameLabel";
            otherNameLabel.Size = new System.Drawing.Size(104, 18);
            otherNameLabel.TabIndex = 205;
            otherNameLabel.Text = "Other Name(s):";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(45, 225);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(59, 18);
            genderLabel.TabIndex = 207;
            genderLabel.Text = "Gender:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(45, 258);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(96, 18);
            dateOfBirthLabel.TabIndex = 209;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // dateOfEmploymentLabel
            // 
            dateOfEmploymentLabel.AutoSize = true;
            dateOfEmploymentLabel.Location = new System.Drawing.Point(45, 287);
            dateOfEmploymentLabel.Name = "dateOfEmploymentLabel";
            dateOfEmploymentLabel.Size = new System.Drawing.Size(143, 18);
            dateOfEmploymentLabel.TabIndex = 211;
            dateOfEmploymentLabel.Text = "Date Of Employment:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(45, 315);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(105, 18);
            phoneNumberLabel.TabIndex = 213;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(45, 344);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(63, 18);
            addressLabel.TabIndex = 215;
            addressLabel.Text = "Address:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(45, 431);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(53, 18);
            statusLabel.TabIndex = 219;
            statusLabel.Text = "Status:";
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Indigo;
            this.SearchPanel.Controls.Add(this.dvgSearch);
            this.SearchPanel.Controls.Add(this.panel3);
            this.SearchPanel.Location = new System.Drawing.Point(669, 4);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(364, 560);
            this.SearchPanel.TabIndex = 137;
            // 
            // dvgSearch
            // 
            this.dvgSearch.AllowUserToAddRows = false;
            this.dvgSearch.AllowUserToDeleteRows = false;
            this.dvgSearch.AllowUserToResizeColumns = false;
            this.dvgSearch.AllowUserToResizeRows = false;
            this.dvgSearch.AutoGenerateColumns = false;
            this.dvgSearch.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.otherNameDataGridViewTextBoxColumn});
            this.dvgSearch.DataSource = this.uSERBindingSource;
            this.dvgSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgSearch.Location = new System.Drawing.Point(0, 125);
            this.dvgSearch.MultiSelect = false;
            this.dvgSearch.Name = "dvgSearch";
            this.dvgSearch.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgSearch.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dvgSearch.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgSearch.Size = new System.Drawing.Size(364, 435);
            this.dvgSearch.TabIndex = 131;
            this.dvgSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgSearch_CellContentClick);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.ToolTipText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.ToolTipText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // otherNameDataGridViewTextBoxColumn
            // 
            this.otherNameDataGridViewTextBoxColumn.DataPropertyName = "OtherName";
            this.otherNameDataGridViewTextBoxColumn.HeaderText = "Other Name";
            this.otherNameDataGridViewTextBoxColumn.Name = "otherNameDataGridViewTextBoxColumn";
            this.otherNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.otherNameDataGridViewTextBoxColumn.ToolTipText = "Other Name";
            this.otherNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER";
            this.uSERBindingSource.DataSource = this.pOSDataSet;
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 125);
            this.panel3.TabIndex = 129;
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
            this.btnExit.Location = new System.Drawing.Point(338, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 27);
            this.btnExit.TabIndex = 317;
            this.btnExit.Text = "x";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
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
            this.btnMinimize.Location = new System.Drawing.Point(300, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 27);
            this.btnMinimize.TabIndex = 316;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(36, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(293, 23);
            this.txtSearch.TabIndex = 127;
            this.txtSearch.Text = "           Search First Name or Last Name";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.MouseLeave += new System.EventHandler(this.txtSearch_MouseLeave);
            // 
            // btnSaveDetails
            // 
            this.btnSaveDetails.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSaveDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDetails.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSaveDetails.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSaveDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnSaveDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSaveDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDetails.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDetails.ForeColor = System.Drawing.Color.White;
            this.btnSaveDetails.Location = new System.Drawing.Point(517, 527);
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(127, 37);
            this.btnSaveDetails.TabIndex = 197;
            this.btnSaveDetails.Text = "&Save Details";
            this.toolTip1.SetToolTip(this.btnSaveDetails, "Save Details");
            this.btnSaveDetails.UseVisualStyleBackColor = false;
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBrowse.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(449, 249);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(170, 37);
            this.btnBrowse.TabIndex = 196;
            this.btnBrowse.Text = "&Browse Image";
            this.toolTip1.SetToolTip(this.btnBrowse, "Browse Image");
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnRemoveImage.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRemoveImage.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnRemoveImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnRemoveImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveImage.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveImage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveImage.Location = new System.Drawing.Point(449, 292);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(170, 37);
            this.btnRemoveImage.TabIndex = 222;
            this.btnRemoveImage.Text = "&Remove Image";
            this.btnRemoveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnRemoveImage, "Remove Image");
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(352, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 223;
            this.button1.Text = "&Remove User";
            this.toolTip1.SetToolTip(this.button1, "Remove User");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tITLEBindingSource
            // 
            this.tITLEBindingSource.DataMember = "TITLE";
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
            this.tableAdapterManager.ThresholdAlertTableAdapter = null;
            this.tableAdapterManager.TITLETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Point_Of_Sale_System.POSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERLOGINTableAdapter = null;
            this.tableAdapterManager.USERTableAdapter = this.uSERTableAdapter;
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // titleIDComboBox
            // 
            this.titleIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uSERBindingSource, "TitleID", true));
            this.titleIDComboBox.DataSource = this.tITLEBindingSource1;
            this.titleIDComboBox.DisplayMember = "Title";
            this.titleIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleIDComboBox.FormattingEnabled = true;
            this.titleIDComboBox.Location = new System.Drawing.Point(194, 71);
            this.titleIDComboBox.Name = "titleIDComboBox";
            this.titleIDComboBox.Size = new System.Drawing.Size(219, 26);
            this.titleIDComboBox.TabIndex = 198;
            this.titleIDComboBox.ValueMember = "TitleID";
            this.titleIDComboBox.SelectedIndexChanged += new System.EventHandler(this.titleIDComboBox_SelectedIndexChanged);
            // 
            // tITLEBindingSource1
            // 
            this.tITLEBindingSource1.DataMember = "TITLE";
            this.tITLEBindingSource1.DataSource = this.pOSDataSet;
            // 
            // roleIDComboBox
            // 
            this.roleIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uSERBindingSource, "RoleID", true));
            this.roleIDComboBox.DataSource = this.rOLEBindingSource;
            this.roleIDComboBox.DisplayMember = "Role";
            this.roleIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleIDComboBox.FormattingEnabled = true;
            this.roleIDComboBox.Location = new System.Drawing.Point(194, 103);
            this.roleIDComboBox.Name = "roleIDComboBox";
            this.roleIDComboBox.Size = new System.Drawing.Size(219, 26);
            this.roleIDComboBox.TabIndex = 200;
            this.roleIDComboBox.ValueMember = "RoleID";
            this.roleIDComboBox.SelectedIndexChanged += new System.EventHandler(this.roleIDComboBox_SelectedIndexChanged);
            // 
            // rOLEBindingSource
            // 
            this.rOLEBindingSource.DataMember = "ROLE";
            this.rOLEBindingSource.DataSource = this.pOSDataSet;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(194, 135);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(219, 23);
            this.firstNameTextBox.TabIndex = 202;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(194, 164);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(219, 23);
            this.lastNameTextBox.TabIndex = 204;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // otherNameTextBox
            // 
            this.otherNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERBindingSource, "OtherName", true));
            this.otherNameTextBox.Location = new System.Drawing.Point(194, 193);
            this.otherNameTextBox.Name = "otherNameTextBox";
            this.otherNameTextBox.Size = new System.Drawing.Size(219, 23);
            this.otherNameTextBox.TabIndex = 206;
            this.otherNameTextBox.TextChanged += new System.EventHandler(this.otherNameTextBox_TextChanged);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERBindingSource, "Gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(194, 222);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(219, 26);
            this.genderComboBox.TabIndex = 208;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.genderComboBox_SelectedIndexChanged);
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.uSERBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(194, 254);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(219, 23);
            this.dateOfBirthDateTimePicker.TabIndex = 210;
            this.dateOfBirthDateTimePicker.ValueChanged += new System.EventHandler(this.dateOfBirthDateTimePicker_ValueChanged);
            // 
            // dateOfEmploymentDateTimePicker
            // 
            this.dateOfEmploymentDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.uSERBindingSource, "DateOfEmployment", true));
            this.dateOfEmploymentDateTimePicker.Location = new System.Drawing.Point(194, 283);
            this.dateOfEmploymentDateTimePicker.Name = "dateOfEmploymentDateTimePicker";
            this.dateOfEmploymentDateTimePicker.Size = new System.Drawing.Size(219, 23);
            this.dateOfEmploymentDateTimePicker.TabIndex = 212;
            this.dateOfEmploymentDateTimePicker.ValueChanged += new System.EventHandler(this.dateOfEmploymentDateTimePicker_ValueChanged);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(194, 312);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(219, 23);
            this.phoneNumberTextBox.TabIndex = 214;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(194, 341);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(219, 79);
            this.addressTextBox.TabIndex = 216;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePictureBox.BackgroundImage")));
            this.picturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.uSERBindingSource, "Picture", true));
            this.picturePictureBox.Location = new System.Drawing.Point(451, 70);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(168, 178);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePictureBox.TabIndex = 218;
            this.picturePictureBox.TabStop = false;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.uSERBindingSource, "Status", true));
            this.statusCheckBox.Location = new System.Drawing.Point(194, 430);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(68, 22);
            this.statusCheckBox.TabIndex = 220;
            this.statusCheckBox.Text = "Active";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // tITLETableAdapter
            // 
            this.tITLETableAdapter.ClearBeforeFill = true;
            // 
            // rOLETableAdapter
            // 
            this.rOLETableAdapter.ClearBeforeFill = true;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1054, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(titleIDLabel);
            this.Controls.Add(this.titleIDComboBox);
            this.Controls.Add(roleIDLabel);
            this.Controls.Add(this.roleIDComboBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(otherNameLabel);
            this.Controls.Add(this.otherNameTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(dateOfEmploymentLabel);
            this.Controls.Add(this.dateOfEmploymentDateTimePicker);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusCheckBox);
            this.Controls.Add(this.btnSaveDetails);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(Label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EditUser_Paint);
            this.SearchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tITLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tITLEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.DataGridView dvgSearch;
        internal System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Button btnSaveDetails;
        internal System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.BindingSource tITLEBindingSource;
        private POSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private POSDataSetTableAdapters.USERTableAdapter uSERTableAdapter;
        private POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        private System.Windows.Forms.ComboBox titleIDComboBox;
        private System.Windows.Forms.ComboBox roleIDComboBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox otherNameTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateOfEmploymentDateTimePicker;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.BindingSource tITLEBindingSource1;
        private POSDataSetTableAdapters.TITLETableAdapter tITLETableAdapter;
        private System.Windows.Forms.BindingSource rOLEBindingSource;
        private POSDataSetTableAdapters.ROLETableAdapter rOLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherNameDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button btnRemoveImage;
        internal System.Windows.Forms.Button btnMinimize;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button button1;
    }
}