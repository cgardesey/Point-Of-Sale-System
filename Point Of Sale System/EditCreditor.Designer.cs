namespace Point_Of_Sale_System
{
    partial class EditCreditor
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label balanceLabel;
            System.Windows.Forms.Label lblAmtPaid;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSaveDetails = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.cREDITORSVIEWDataGridView = new System.Windows.Forms.DataGridView();
            this.creditorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREDITORSVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSet = new Point_Of_Sale_System.POSDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cREDITORSVIEWTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.CREDITORSVIEWTableAdapter();
            this.tableAdapterManager = new Point_Of_Sale_System.POSDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.amtPaidTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            Label1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            balanceLabel = new System.Windows.Forms.Label();
            lblAmtPaid = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITORSVIEWDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITORSVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            Label1.Font = new System.Drawing.Font("Trebuchet MS", 17F);
            Label1.ForeColor = System.Drawing.Color.Orange;
            Label1.Location = new System.Drawing.Point(19, 14);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(399, 28);
            Label1.TabIndex = 229;
            Label1.Text = "  Edit Supplier Details";
            Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = System.Drawing.Color.White;
            nameLabel.Location = new System.Drawing.Point(58, 118);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(48, 13);
            nameLabel.TabIndex = 234;
            nameLabel.Text = "Supplier:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.ForeColor = System.Drawing.Color.White;
            phoneNumberLabel.Location = new System.Drawing.Point(58, 167);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(47, 13);
            phoneNumberLabel.TabIndex = 236;
            phoneNumberLabel.Text = "Contact:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.ForeColor = System.Drawing.Color.White;
            addressLabel.Location = new System.Drawing.Point(58, 216);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 238;
            addressLabel.Text = "Address:";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.ForeColor = System.Drawing.Color.White;
            balanceLabel.Location = new System.Drawing.Point(58, 265);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new System.Drawing.Size(49, 13);
            balanceLabel.TabIndex = 240;
            balanceLabel.Text = "Balance:";
            // 
            // lblAmtPaid
            // 
            lblAmtPaid.AutoSize = true;
            lblAmtPaid.ForeColor = System.Drawing.Color.White;
            lblAmtPaid.Location = new System.Drawing.Point(58, 314);
            lblAmtPaid.Name = "lblAmtPaid";
            lblAmtPaid.Size = new System.Drawing.Size(70, 13);
            lblAmtPaid.TabIndex = 319;
            lblAmtPaid.Text = "Amount Paid:";
            lblAmtPaid.Click += new System.EventHandler(this.lblAmtPaid_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(163, 311);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(30, 16);
            label5.TabIndex = 318;
            label5.Text = "GHC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(162, 262);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 16);
            label2.TabIndex = 320;
            label2.Text = "GHC";
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
            this.btnSaveDetails.Location = new System.Drawing.Point(233, 421);
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(127, 37);
            this.btnSaveDetails.TabIndex = 230;
            this.btnSaveDetails.Text = "&Save Details";
            this.btnSaveDetails.UseVisualStyleBackColor = false;
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPanel.BackColor = System.Drawing.Color.Indigo;
            this.SearchPanel.Controls.Add(this.cREDITORSVIEWDataGridView);
            this.SearchPanel.Controls.Add(this.panel3);
            this.SearchPanel.Location = new System.Drawing.Point(393, 21);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(284, 437);
            this.SearchPanel.TabIndex = 228;
            // 
            // cREDITORSVIEWDataGridView
            // 
            this.cREDITORSVIEWDataGridView.AllowUserToAddRows = false;
            this.cREDITORSVIEWDataGridView.AllowUserToDeleteRows = false;
            this.cREDITORSVIEWDataGridView.AllowUserToResizeColumns = false;
            this.cREDITORSVIEWDataGridView.AllowUserToResizeRows = false;
            this.cREDITORSVIEWDataGridView.AutoGenerateColumns = false;
            this.cREDITORSVIEWDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cREDITORSVIEWDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cREDITORSVIEWDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cREDITORSVIEWDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cREDITORSVIEWDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.creditorIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.cREDITORSVIEWDataGridView.DataSource = this.cREDITORSVIEWBindingSource;
            this.cREDITORSVIEWDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cREDITORSVIEWDataGridView.Location = new System.Drawing.Point(0, 93);
            this.cREDITORSVIEWDataGridView.Name = "cREDITORSVIEWDataGridView";
            this.cREDITORSVIEWDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cREDITORSVIEWDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.cREDITORSVIEWDataGridView.Size = new System.Drawing.Size(284, 344);
            this.cREDITORSVIEWDataGridView.TabIndex = 129;
            // 
            // creditorIdDataGridViewTextBoxColumn
            // 
            this.creditorIdDataGridViewTextBoxColumn.DataPropertyName = "CreditorId";
            this.creditorIdDataGridViewTextBoxColumn.HeaderText = "CreditorId";
            this.creditorIdDataGridViewTextBoxColumn.Name = "creditorIdDataGridViewTextBoxColumn";
            this.creditorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // cREDITORSVIEWBindingSource
            // 
            this.cREDITORSVIEWBindingSource.DataMember = "CREDITORSVIEW";
            this.cREDITORSVIEWBindingSource.DataSource = this.pOSDataSet;
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 93);
            this.panel3.TabIndex = 129;
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
            this.btnMinimize.Location = new System.Drawing.Point(219, -6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 27);
            this.btnMinimize.TabIndex = 171;
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
            this.btnExit.Location = new System.Drawing.Point(254, -6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 27);
            this.btnExit.TabIndex = 172;
            this.btnExit.Text = "x";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(37, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(208, 20);
            this.txtSearch.TabIndex = 127;
            this.txtSearch.Text = "            Search Supplier";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click_1);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.MouseLeave += new System.EventHandler(this.txtSearch_MouseLeave);
            // 
            // cREDITORSVIEWTableAdapter
            // 
            this.cREDITORSVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.COMPLAINTTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.USERTableAdapter = null;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cREDITORSVIEWBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(160, 114);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 26);
            this.nameTextBox.TabIndex = 235;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cREDITORSVIEWBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(160, 162);
            this.phoneNumberTextBox.Multiline = true;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(168, 26);
            this.phoneNumberTextBox.TabIndex = 237;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cREDITORSVIEWBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(160, 210);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(168, 26);
            this.addressTextBox.TabIndex = 239;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cREDITORSVIEWBindingSource, "Balance", true));
            this.balanceTextBox.Location = new System.Drawing.Point(160, 258);
            this.balanceTextBox.Multiline = true;
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(168, 26);
            this.balanceTextBox.TabIndex = 241;
            this.balanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amtPaidTextBox
            // 
            this.amtPaidTextBox.BackColor = System.Drawing.Color.White;
            this.amtPaidTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtPaidTextBox.Location = new System.Drawing.Point(160, 306);
            this.amtPaidTextBox.Name = "amtPaidTextBox";
            this.amtPaidTextBox.Size = new System.Drawing.Size(168, 26);
            this.amtPaidTextBox.TabIndex = 317;
            this.amtPaidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(230, 62);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(35, 13);
            this.dateLabel.TabIndex = 329;
            this.dateLabel.Text = "label2";
            this.dateLabel.Visible = false;
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
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
            this.button1.Location = new System.Drawing.Point(51, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 330;
            this.button1.Text = "&Remove Creditor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditCreditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(710, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(label2);
            this.Controls.Add(lblAmtPaid);
            this.Controls.Add(label5);
            this.Controls.Add(this.amtPaidTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(balanceLabel);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.btnSaveDetails);
            this.Controls.Add(Label1);
            this.Controls.Add(this.SearchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCreditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCreditor";
            this.Load += new System.EventHandler(this.EditCreditor_Load);
            this.SearchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cREDITORSVIEWDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITORSVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnSaveDetails;
        internal System.Windows.Forms.Panel SearchPanel;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Button btnMinimize;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView cREDITORSVIEWDataGridView;
        private POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource cREDITORSVIEWBindingSource;
        private POSDataSetTableAdapters.CREDITORSVIEWTableAdapter cREDITORSVIEWTableAdapter;
        private POSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox amtPaidTextBox;
        private System.Windows.Forms.Label dateLabel;
        internal System.Windows.Forms.Button button1;
    }
}