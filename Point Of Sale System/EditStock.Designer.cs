namespace Point_Of_Sale_System
{
    partial class EditStock
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
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label quantityAvailableLabel;
            System.Windows.Forms.Label unitSellingPriceLabel;
            System.Windows.Forms.Label unitCostPriceLabel;
            System.Windows.Forms.Label minStockLevelLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.dvgSearch = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitSellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSet = new Point_Of_Sale_System.POSDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.sTOCKTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.STOCKTableAdapter();
            this.tableAdapterManager = new Point_Of_Sale_System.POSDataSetTableAdapters.TableAdapterManager();
            this.cATEGORYTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.CATEGORYTableAdapter();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantityAvailableTextBox = new System.Windows.Forms.TextBox();
            this.unitSellingPriceTextBox = new System.Windows.Forms.TextBox();
            this.unitCostPriceTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSaveDetails = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.minStockLevelTextBox = new System.Windows.Forms.TextBox();
            Label1 = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            quantityAvailableLabel = new System.Windows.Forms.Label();
            unitSellingPriceLabel = new System.Windows.Forms.Label();
            unitCostPriceLabel = new System.Windows.Forms.Label();
            minStockLevelLabel = new System.Windows.Forms.Label();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            Label1.Font = new System.Drawing.Font("Trebuchet MS", 17F);
            Label1.ForeColor = System.Drawing.Color.Orange;
            Label1.Location = new System.Drawing.Point(2, 3);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(586, 28);
            Label1.TabIndex = 143;
            Label1.Text = "                         Edit Drug Details";
            Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            Label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove);
            Label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseUp);
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(38, 130);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(42, 18);
            productNameLabel.TabIndex = 144;
            productNameLabel.Text = "Drug:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(38, 159);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(86, 18);
            categoryIDLabel.TabIndex = 146;
            categoryIDLabel.Text = "Category ID:";
            // 
            // quantityAvailableLabel
            // 
            quantityAvailableLabel.AutoSize = true;
            quantityAvailableLabel.Location = new System.Drawing.Point(38, 191);
            quantityAvailableLabel.Name = "quantityAvailableLabel";
            quantityAvailableLabel.Size = new System.Drawing.Size(127, 18);
            quantityAvailableLabel.TabIndex = 148;
            quantityAvailableLabel.Text = "Quantity Available:";
            // 
            // unitSellingPriceLabel
            // 
            unitSellingPriceLabel.AutoSize = true;
            unitSellingPriceLabel.Location = new System.Drawing.Point(38, 249);
            unitSellingPriceLabel.Name = "unitSellingPriceLabel";
            unitSellingPriceLabel.Size = new System.Drawing.Size(119, 18);
            unitSellingPriceLabel.TabIndex = 150;
            unitSellingPriceLabel.Text = "Unit Selling Price:";
            // 
            // unitCostPriceLabel
            // 
            unitCostPriceLabel.AutoSize = true;
            unitCostPriceLabel.Location = new System.Drawing.Point(38, 220);
            unitCostPriceLabel.Name = "unitCostPriceLabel";
            unitCostPriceLabel.Size = new System.Drawing.Size(107, 18);
            unitCostPriceLabel.TabIndex = 152;
            unitCostPriceLabel.Text = "Unit Cost Price:";
            // 
            // minStockLevelLabel
            // 
            minStockLevelLabel.AutoSize = true;
            minStockLevelLabel.Location = new System.Drawing.Point(38, 278);
            minStockLevelLabel.Name = "minStockLevelLabel";
            minStockLevelLabel.Size = new System.Drawing.Size(112, 18);
            minStockLevelLabel.TabIndex = 198;
            minStockLevelLabel.Text = "Min Stock Level:";
            // 
            // SearchPanel
            // 
            this.SearchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPanel.BackColor = System.Drawing.Color.Indigo;
            this.SearchPanel.Controls.Add(this.dvgSearch);
            this.SearchPanel.Controls.Add(this.panel3);
            this.SearchPanel.Location = new System.Drawing.Point(403, 4);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(259, 437);
            this.SearchPanel.TabIndex = 138;
            // 
            // dvgSearch
            // 
            this.dvgSearch.AllowUserToAddRows = false;
            this.dvgSearch.AllowUserToDeleteRows = false;
            this.dvgSearch.AllowUserToResizeColumns = false;
            this.dvgSearch.AllowUserToResizeRows = false;
            this.dvgSearch.AutoGenerateColumns = false;
            this.dvgSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.productNameDataGridViewTextBoxColumn,
            this.quantityAvailableDataGridViewTextBoxColumn,
            this.unitSellingPriceDataGridViewTextBoxColumn});
            this.dvgSearch.DataSource = this.sTOCKBindingSource;
            this.dvgSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgSearch.Location = new System.Drawing.Point(0, 93);
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
            this.dvgSearch.Size = new System.Drawing.Size(259, 344);
            this.dvgSearch.TabIndex = 131;
            this.dvgSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgSearch_CellContentClick);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Drug";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.ToolTipText = "Drug";
            // 
            // quantityAvailableDataGridViewTextBoxColumn
            // 
            this.quantityAvailableDataGridViewTextBoxColumn.DataPropertyName = "QuantityAvailable";
            this.quantityAvailableDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityAvailableDataGridViewTextBoxColumn.Name = "quantityAvailableDataGridViewTextBoxColumn";
            this.quantityAvailableDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityAvailableDataGridViewTextBoxColumn.ToolTipText = "Quantity";
            this.quantityAvailableDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitSellingPriceDataGridViewTextBoxColumn
            // 
            this.unitSellingPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitSellingPrice";
            this.unitSellingPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.unitSellingPriceDataGridViewTextBoxColumn.Name = "unitSellingPriceDataGridViewTextBoxColumn";
            this.unitSellingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitSellingPriceDataGridViewTextBoxColumn.ToolTipText = "Price";
            this.unitSellingPriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTOCKBindingSource
            // 
            this.sTOCKBindingSource.DataMember = "STOCK";
            this.sTOCKBindingSource.DataSource = this.pOSDataSet;
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 93);
            this.panel3.TabIndex = 129;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(38, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 23);
            this.txtSearch.TabIndex = 127;
            this.txtSearch.Text = "               Search Drug";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.MouseLeave += new System.EventHandler(this.txtSearch_MouseLeave);
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
            this.btnMinimize.Location = new System.Drawing.Point(618, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 27);
            this.btnMinimize.TabIndex = 320;
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
            this.btnExit.Location = new System.Drawing.Point(658, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 27);
            this.btnExit.TabIndex = 321;
            this.btnExit.Text = "x";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // sTOCKTableAdapter
            // 
            this.sTOCKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORYTableAdapter = this.cATEGORYTableAdapter;
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
            this.tableAdapterManager.STOCKTableAdapter = this.sTOCKTableAdapter;
            this.tableAdapterManager.ThresholdAlertTableAdapter = null;
            this.tableAdapterManager.TITLETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Point_Of_Sale_System.POSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERLOGINTableAdapter = null;
            this.tableAdapterManager.USERTableAdapter = null;
            // 
            // cATEGORYTableAdapter
            // 
            this.cATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTOCKBindingSource, "ProductName", true));
            this.productNameTextBox.Enabled = false;
            this.productNameTextBox.Location = new System.Drawing.Point(173, 127);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(188, 23);
            this.productNameTextBox.TabIndex = 145;
            this.productNameTextBox.TextChanged += new System.EventHandler(this.productNameTextBox_TextChanged);
            // 
            // categoryIDComboBox
            // 
            this.categoryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sTOCKBindingSource, "CategoryID", true));
            this.categoryIDComboBox.DataSource = this.cATEGORYBindingSource;
            this.categoryIDComboBox.DisplayMember = "Category";
            this.categoryIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryIDComboBox.FormattingEnabled = true;
            this.categoryIDComboBox.Location = new System.Drawing.Point(173, 156);
            this.categoryIDComboBox.Name = "categoryIDComboBox";
            this.categoryIDComboBox.Size = new System.Drawing.Size(188, 26);
            this.categoryIDComboBox.TabIndex = 147;
            this.categoryIDComboBox.ValueMember = "CategoryID";
            this.categoryIDComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryIDComboBox_SelectedIndexChanged);
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
            this.cATEGORYBindingSource.DataSource = this.pOSDataSet;
            // 
            // quantityAvailableTextBox
            // 
            this.quantityAvailableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTOCKBindingSource, "QuantityAvailable", true));
            this.quantityAvailableTextBox.Enabled = false;
            this.quantityAvailableTextBox.Location = new System.Drawing.Point(173, 188);
            this.quantityAvailableTextBox.Name = "quantityAvailableTextBox";
            this.quantityAvailableTextBox.Size = new System.Drawing.Size(188, 23);
            this.quantityAvailableTextBox.TabIndex = 149;
            this.quantityAvailableTextBox.TextChanged += new System.EventHandler(this.quantityAvailableTextBox_TextChanged);
            // 
            // unitSellingPriceTextBox
            // 
            this.unitSellingPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTOCKBindingSource, "UnitSellingPrice", true));
            this.unitSellingPriceTextBox.Location = new System.Drawing.Point(173, 246);
            this.unitSellingPriceTextBox.Name = "unitSellingPriceTextBox";
            this.unitSellingPriceTextBox.Size = new System.Drawing.Size(188, 23);
            this.unitSellingPriceTextBox.TabIndex = 151;
            this.unitSellingPriceTextBox.TextChanged += new System.EventHandler(this.unitSellingPriceTextBox_TextChanged);
            // 
            // unitCostPriceTextBox
            // 
            this.unitCostPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTOCKBindingSource, "UnitCostPrice", true));
            this.unitCostPriceTextBox.Location = new System.Drawing.Point(173, 217);
            this.unitCostPriceTextBox.Name = "unitCostPriceTextBox";
            this.unitCostPriceTextBox.Size = new System.Drawing.Size(188, 23);
            this.unitCostPriceTextBox.TabIndex = 153;
            this.unitCostPriceTextBox.TextChanged += new System.EventHandler(this.unitCostPriceTextBox_TextChanged);
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
            this.btnSaveDetails.Location = new System.Drawing.Point(245, 399);
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(127, 37);
            this.btnSaveDetails.TabIndex = 198;
            this.btnSaveDetails.Text = "&Save Details";
            this.toolTip1.SetToolTip(this.btnSaveDetails, "Save Details");
            this.btnSaveDetails.UseVisualStyleBackColor = false;
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(97, 399);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(127, 37);
            this.btnRemove.TabIndex = 201;
            this.btnRemove.Text = "&Remove Product";
            this.toolTip1.SetToolTip(this.btnRemove, "Remove Product");
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // minStockLevelTextBox
            // 
            this.minStockLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTOCKBindingSource, "MinStockLevel", true));
            this.minStockLevelTextBox.Location = new System.Drawing.Point(173, 275);
            this.minStockLevelTextBox.Name = "minStockLevelTextBox";
            this.minStockLevelTextBox.Size = new System.Drawing.Size(188, 23);
            this.minStockLevelTextBox.TabIndex = 199;
            this.minStockLevelTextBox.TextChanged += new System.EventHandler(this.minStockLevelTextBox_TextChanged);
            // 
            // EditStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(698, 465);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(minStockLevelLabel);
            this.Controls.Add(this.minStockLevelTextBox);
            this.Controls.Add(this.btnSaveDetails);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(this.categoryIDComboBox);
            this.Controls.Add(quantityAvailableLabel);
            this.Controls.Add(this.quantityAvailableTextBox);
            this.Controls.Add(unitSellingPriceLabel);
            this.Controls.Add(this.unitSellingPriceTextBox);
            this.Controls.Add(unitCostPriceLabel);
            this.Controls.Add(this.unitCostPriceTextBox);
            this.Controls.Add(Label1);
            this.Controls.Add(this.SearchPanel);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditStock";
            this.Load += new System.EventHandler(this.EditStock_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EditStock_Paint);
            this.SearchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.DataGridView dvgSearch;
        internal System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private POSDataSetTableAdapters.STOCKTableAdapter sTOCKTableAdapter;
        private POSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.ComboBox categoryIDComboBox;
        private System.Windows.Forms.TextBox quantityAvailableTextBox;
        private System.Windows.Forms.TextBox unitSellingPriceTextBox;
        private System.Windows.Forms.TextBox unitCostPriceTextBox;
        private POSDataSetTableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Button btnSaveDetails;
        private System.Windows.Forms.TextBox minStockLevelTextBox;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.Button btnMinimize;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitSellingPriceDataGridViewTextBoxColumn;
    }
}