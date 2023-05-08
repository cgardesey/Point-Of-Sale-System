namespace Point_Of_Sale_System
{
    partial class ExpiredDamaged
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.eXPIREDDRUGVIEWDataGridView = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acknowledged = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PurchaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPIREDDRUGVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSet = new Point_Of_Sale_System.POSDataSet();
            this.tableAdapterManager = new Point_Of_Sale_System.POSDataSetTableAdapters.TableAdapterManager();
            this.eXPIREDDRUGVIEWTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.EXPIREDDRUGVIEWTableAdapter();
            this.lblThreshold = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eXPIREDDRUGVIEWDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPIREDDRUGVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.Dock = System.Windows.Forms.DockStyle.Top;
            Label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.Orange;
            Label1.Location = new System.Drawing.Point(1, 1);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(554, 49);
            Label1.TabIndex = 156;
            Label1.Text = "The following drugs will soon expire!";
            Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 1);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 508);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(555, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 508);
            this.panel4.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(519, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 27);
            this.btnClose.TabIndex = 157;
            this.btnClose.Text = "x";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // eXPIREDDRUGVIEWDataGridView
            // 
            this.eXPIREDDRUGVIEWDataGridView.AllowUserToAddRows = false;
            this.eXPIREDDRUGVIEWDataGridView.AllowUserToDeleteRows = false;
            this.eXPIREDDRUGVIEWDataGridView.AllowUserToResizeColumns = false;
            this.eXPIREDDRUGVIEWDataGridView.AllowUserToResizeRows = false;
            this.eXPIREDDRUGVIEWDataGridView.AutoGenerateColumns = false;
            this.eXPIREDDRUGVIEWDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eXPIREDDRUGVIEWDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eXPIREDDRUGVIEWDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.eXPIREDDRUGVIEWDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eXPIREDDRUGVIEWDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn,
            this.QuantityRemaining,
            this.Acknowledged,
            this.PurchaseID});
            this.eXPIREDDRUGVIEWDataGridView.DataSource = this.eXPIREDDRUGVIEWBindingSource;
            this.eXPIREDDRUGVIEWDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eXPIREDDRUGVIEWDataGridView.Location = new System.Drawing.Point(1, 50);
            this.eXPIREDDRUGVIEWDataGridView.Name = "eXPIREDDRUGVIEWDataGridView";
            this.eXPIREDDRUGVIEWDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.eXPIREDDRUGVIEWDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.eXPIREDDRUGVIEWDataGridView.Size = new System.Drawing.Size(554, 459);
            this.eXPIREDDRUGVIEWDataGridView.TabIndex = 240;
            this.eXPIREDDRUGVIEWDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.eXPIREDDRUGVIEWDataGridView_CellEndEdit);
            this.eXPIREDDRUGVIEWDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.eXPIREDDRUGVIEWDataGridView_CellValueChanged);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Drug";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "Expiry Date";
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            this.expiryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // QuantityRemaining
            // 
            this.QuantityRemaining.DataPropertyName = "QuantityRemaining";
            this.QuantityRemaining.HeaderText = "Quantity Remaining";
            this.QuantityRemaining.Name = "QuantityRemaining";
            this.QuantityRemaining.ReadOnly = true;
            // 
            // Acknowledged
            // 
            this.Acknowledged.DataPropertyName = "Acknowledged";
            this.Acknowledged.HeaderText = "Acknowledged";
            this.Acknowledged.Name = "Acknowledged";
            // 
            // PurchaseID
            // 
            this.PurchaseID.DataPropertyName = "PurchaseID";
            this.PurchaseID.HeaderText = "PurchaseID";
            this.PurchaseID.Name = "PurchaseID";
            this.PurchaseID.Visible = false;
            // 
            // eXPIREDDRUGVIEWBindingSource
            // 
            this.eXPIREDDRUGVIEWBindingSource.DataMember = "EXPIREDDRUGVIEW";
            this.eXPIREDDRUGVIEWBindingSource.DataSource = this.pOSDataSet;
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // eXPIREDDRUGVIEWTableAdapter
            // 
            this.eXPIREDDRUGVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(235, 298);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(35, 13);
            this.lblThreshold.TabIndex = 241;
            this.lblThreshold.Text = "label2";
            this.lblThreshold.Visible = false;
            // 
            // ExpiredDamaged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 510);
            this.Controls.Add(this.eXPIREDDRUGVIEWDataGridView);
            this.Controls.Add(this.lblThreshold);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(Label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpiredDamaged";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpiredDamaged";
            this.Load += new System.EventHandler(this.ExpiredDamaged_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExpiredDamaged_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExpiredDamaged_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ExpiredDamaged_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.eXPIREDDRUGVIEWDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPIREDDRUGVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private POSDataSet pOSDataSet;
        private POSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView eXPIREDDRUGVIEWDataGridView;
        private System.Windows.Forms.BindingSource eXPIREDDRUGVIEWBindingSource;
        private POSDataSetTableAdapters.EXPIREDDRUGVIEWTableAdapter eXPIREDDRUGVIEWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityRemaining;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Acknowledged;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseID;
        private System.Windows.Forms.Label lblThreshold;
    }
}