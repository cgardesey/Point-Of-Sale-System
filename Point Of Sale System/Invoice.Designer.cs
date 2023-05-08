namespace Point_Of_Sale_System
{
    partial class Invoice
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label salePriceLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label contactNumberLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label amtOwedLabel;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label amtPaidLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.sETTINGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSet = new Point_Of_Sale_System.POSDataSet();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCartNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShopName = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sALEDataGridView = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitySoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALESVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAmtPaid = new System.Windows.Forms.Label();
            this.lblAmtOwed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sALESVIEWTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.SALESVIEWTableAdapter();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.sETTINGSTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.SETTINGSTableAdapter();
            this.tableAdapterManager = new Point_Of_Sale_System.POSDataSetTableAdapters.TableAdapterManager();
            titleLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            salePriceLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            contactNumberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            amtOwedLabel = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            amtPaidLabel = new System.Windows.Forms.Label();
            this.aboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sETTINGSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sALEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESVIEWBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = System.Drawing.Color.Transparent;
            titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            titleLabel.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            titleLabel.ForeColor = System.Drawing.Color.Black;
            titleLabel.Location = new System.Drawing.Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(300, 10);
            titleLabel.TabIndex = 235;
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(116, 61);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(30, 16);
            label5.TabIndex = 279;
            label5.Text = "GHC";
            // 
            // salePriceLabel
            // 
            salePriceLabel.AutoSize = true;
            salePriceLabel.Location = new System.Drawing.Point(15, 59);
            salePriceLabel.Name = "salePriceLabel";
            salePriceLabel.Size = new System.Drawing.Size(104, 18);
            salePriceLabel.TabIndex = 278;
            salePriceLabel.Text = "Total   Amount:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(24, 69);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(63, 18);
            addressLabel.TabIndex = 280;
            addressLabel.Text = "Address:";
            addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // contactNumberLabel
            // 
            contactNumberLabel.AutoSize = true;
            contactNumberLabel.Location = new System.Drawing.Point(24, 112);
            contactNumberLabel.Name = "contactNumberLabel";
            contactNumberLabel.Size = new System.Drawing.Size(63, 18);
            contactNumberLabel.TabIndex = 282;
            contactNumberLabel.Text = "Contact:";
            contactNumberLabel.Click += new System.EventHandler(this.contactNumberLabel_Click);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(24, 155);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 18);
            emailLabel.TabIndex = 284;
            emailLabel.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(116, 37);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(30, 16);
            label7.TabIndex = 284;
            label7.Text = "GHC";
            // 
            // amtOwedLabel
            // 
            amtOwedLabel.AutoSize = true;
            amtOwedLabel.Location = new System.Drawing.Point(15, 37);
            amtOwedLabel.Name = "amtOwedLabel";
            amtOwedLabel.Size = new System.Drawing.Size(103, 18);
            amtOwedLabel.TabIndex = 283;
            amtOwedLabel.Text = "Amount Owed:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.ForeColor = System.Drawing.Color.Black;
            label10.Location = new System.Drawing.Point(117, 14);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(30, 16);
            label10.TabIndex = 287;
            label10.Text = "GHC";
            // 
            // amtPaidLabel
            // 
            amtPaidLabel.AutoSize = true;
            amtPaidLabel.Location = new System.Drawing.Point(15, 12);
            amtPaidLabel.Name = "amtPaidLabel";
            amtPaidLabel.Size = new System.Drawing.Size(101, 18);
            amtPaidLabel.TabIndex = 286;
            amtPaidLabel.Text = "Amount   Paid:";
            // 
            // aboutPanel
            // 
            this.aboutPanel.BackColor = System.Drawing.Color.Transparent;
            this.aboutPanel.Controls.Add(this.btnExit);
            this.aboutPanel.Controls.Add(addressLabel);
            this.aboutPanel.Controls.Add(this.lblAddress);
            this.aboutPanel.Controls.Add(contactNumberLabel);
            this.aboutPanel.Controls.Add(this.lblContactNumber);
            this.aboutPanel.Controls.Add(emailLabel);
            this.aboutPanel.Controls.Add(this.lblEmail);
            this.aboutPanel.Controls.Add(this.label4);
            this.aboutPanel.Controls.Add(this.lblCartNo);
            this.aboutPanel.Controls.Add(this.label2);
            this.aboutPanel.Controls.Add(this.lblShopName);
            this.aboutPanel.Controls.Add(this.dateLabel);
            this.aboutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutPanel.ForeColor = System.Drawing.Color.Black;
            this.aboutPanel.Location = new System.Drawing.Point(0, 10);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(300, 247);
            this.aboutPanel.TabIndex = 236;
            this.aboutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.aboutPanel_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Orange;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(264, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 27);
            this.btnExit.TabIndex = 307;
            this.btnExit.Text = "x";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sETTINGSBindingSource, "Address", true));
            this.lblAddress.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(94, 69);
            this.lblAddress.MaximumSize = new System.Drawing.Size(190, 36);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(40, 18);
            this.lblAddress.TabIndex = 281;
            this.lblAddress.Text = "label6";
            // 
            // sETTINGSBindingSource
            // 
            this.sETTINGSBindingSource.DataMember = "SETTINGS";
            this.sETTINGSBindingSource.DataSource = this.pOSDataSet;
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sETTINGSBindingSource, "ContactNumber", true));
            this.lblContactNumber.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(94, 112);
            this.lblContactNumber.MaximumSize = new System.Drawing.Size(190, 36);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(40, 18);
            this.lblContactNumber.TabIndex = 283;
            this.lblContactNumber.Text = "label6";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sETTINGSBindingSource, "Email", true));
            this.lblEmail.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(94, 155);
            this.lblEmail.MaximumSize = new System.Drawing.Size(190, 36);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(40, 18);
            this.lblEmail.TabIndex = 285;
            this.lblEmail.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 280;
            this.label4.Text = "CartNo:";
            // 
            // lblCartNo
            // 
            this.lblCartNo.AutoSize = true;
            this.lblCartNo.Location = new System.Drawing.Point(153, 217);
            this.lblCartNo.Name = "lblCartNo";
            this.lblCartNo.Size = new System.Drawing.Size(56, 18);
            this.lblCartNo.TabIndex = 278;
            this.lblCartNo.Text = "CartNo.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 18);
            this.label2.TabIndex = 277;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "------------";
            // 
            // lblShopName
            // 
            this.lblShopName.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopName.Location = new System.Drawing.Point(0, 33);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(297, 29);
            this.lblShopName.TabIndex = 3;
            this.lblShopName.Text = "Shop Name";
            this.lblShopName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblShopName.Click += new System.EventHandler(this.lblShopName_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(134, 193);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 18);
            this.dateLabel.TabIndex = 276;
            this.dateLabel.Text = "Date";
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.lblSalePrice.Location = new System.Drawing.Point(141, 59);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(70, 18);
            this.lblSalePrice.TabIndex = 281;
            this.lblSalePrice.Text = "Total Cost";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(196, 129);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(94, 33);
            this.btnPrint.TabIndex = 280;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 18);
            this.label1.TabIndex = 282;
            this.label1.Text = "Thanks for Shopping With Us";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.sALEDataGridView);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 349);
            this.panel1.TabIndex = 283;
            // 
            // sALEDataGridView
            // 
            this.sALEDataGridView.AllowUserToAddRows = false;
            this.sALEDataGridView.AllowUserToDeleteRows = false;
            this.sALEDataGridView.AutoGenerateColumns = false;
            this.sALEDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.sALEDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.sALEDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sALEDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sALEDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sALEDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sALEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sALEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.quantitySoldDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn});
            this.sALEDataGridView.DataSource = this.sALESVIEWBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sALEDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.sALEDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sALEDataGridView.GridColor = System.Drawing.Color.White;
            this.sALEDataGridView.Location = new System.Drawing.Point(10, 0);
            this.sALEDataGridView.MultiSelect = false;
            this.sALEDataGridView.Name = "sALEDataGridView";
            this.sALEDataGridView.ReadOnly = true;
            this.sALEDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sALEDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.sALEDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.sALEDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.sALEDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sALEDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sALEDataGridView.Size = new System.Drawing.Size(280, 349);
            this.sALEDataGridView.TabIndex = 268;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Drug";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.ToolTipText = "Drug";
            this.productNameDataGridViewTextBoxColumn.Width = 140;
            // 
            // quantitySoldDataGridViewTextBoxColumn
            // 
            this.quantitySoldDataGridViewTextBoxColumn.DataPropertyName = "QuantitySold";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.quantitySoldDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantitySoldDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.quantitySoldDataGridViewTextBoxColumn.Name = "quantitySoldDataGridViewTextBoxColumn";
            this.quantitySoldDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantitySoldDataGridViewTextBoxColumn.ToolTipText = "Quantity";
            this.quantitySoldDataGridViewTextBoxColumn.Width = 50;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salePriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            this.salePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.salePriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.salePriceDataGridViewTextBoxColumn.ToolTipText = "Price";
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            this.saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // sALESVIEWBindingSource
            // 
            this.sALESVIEWBindingSource.DataMember = "SALESVIEW";
            this.sALESVIEWBindingSource.DataSource = this.pOSDataSet;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(290, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 349);
            this.panel3.TabIndex = 269;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 349);
            this.panel4.TabIndex = 270;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblAmtPaid);
            this.panel2.Controls.Add(label10);
            this.panel2.Controls.Add(amtPaidLabel);
            this.panel2.Controls.Add(this.lblAmtOwed);
            this.panel2.Controls.Add(label7);
            this.panel2.Controls.Add(amtOwedLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.lblSalePrice);
            this.panel2.Controls.Add(label5);
            this.panel2.Controls.Add(salePriceLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 171);
            this.panel2.TabIndex = 284;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblAmtPaid
            // 
            this.lblAmtPaid.AutoSize = true;
            this.lblAmtPaid.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.lblAmtPaid.Location = new System.Drawing.Point(141, 10);
            this.lblAmtPaid.Name = "lblAmtPaid";
            this.lblAmtPaid.Size = new System.Drawing.Size(70, 18);
            this.lblAmtPaid.TabIndex = 288;
            this.lblAmtPaid.Text = "Total Cost";
            // 
            // lblAmtOwed
            // 
            this.lblAmtOwed.AutoSize = true;
            this.lblAmtOwed.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.lblAmtOwed.Location = new System.Drawing.Point(141, 35);
            this.lblAmtOwed.Name = "lblAmtOwed";
            this.lblAmtOwed.Size = new System.Drawing.Size(70, 18);
            this.lblAmtOwed.TabIndex = 285;
            this.lblAmtOwed.Text = "Total Cost";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 18);
            this.label3.TabIndex = 278;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "------------";
            // 
            // sALESVIEWTableAdapter
            // 
            this.sALESVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // printForm1
            // 
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // sETTINGSTableAdapter
            // 
            this.sETTINGSTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SETTINGSTableAdapter = this.sETTINGSTableAdapter;

            this.tableAdapterManager.STOCKTableAdapter = null;
            this.tableAdapterManager.TITLETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Point_Of_Sale_System.POSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERLOGINTableAdapter = null;
            this.tableAdapterManager.USERTableAdapter = null;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aboutPanel);
            this.Controls.Add(titleLabel);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.aboutPanel.ResumeLayout(false);
            this.aboutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sETTINGSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sALEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESVIEWBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.Label lblShopName;
        internal System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView sALEDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lblCartNo;
        public System.Windows.Forms.Label label2;
        private POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource sALESVIEWBindingSource;
        private POSDataSetTableAdapters.SALESVIEWTableAdapter sALESVIEWTableAdapter;
        public System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.BindingSource sETTINGSBindingSource;
        private POSDataSetTableAdapters.SETTINGSTableAdapter sETTINGSTableAdapter;
        private POSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAmtPaid;
        private System.Windows.Forms.Label lblAmtOwed;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitySoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
    }
}