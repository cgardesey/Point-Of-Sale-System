namespace Point_Of_Sale_System
{
    partial class Expired
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pOSDataSet = new Point_Of_Sale_System.POSDataSet();
            this.eXPIREDDRUGVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPIREDDRUGVIEWTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.EXPIREDDRUGVIEWTableAdapter();
            this.tableAdapterManager = new Point_Of_Sale_System.POSDataSetTableAdapters.TableAdapterManager();
            this.PurchaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QuantityRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPIREDDRUGVIEWDataGridView = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPIREDDRUGVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPIREDDRUGVIEWDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.Dock = System.Windows.Forms.DockStyle.Top;
            Label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.Red;
            Label1.Location = new System.Drawing.Point(0, 0);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(554, 49);
            Label1.TabIndex = 157;
            Label1.Text = "The following drugs have expired!!  Please remove them from stock.";
            Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            Label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove);
            Label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 1);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(555, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 509);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 509);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(1, 509);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(554, 1);
            this.panel4.TabIndex = 3;
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXPIREDDRUGVIEWBindingSource
            // 
            this.eXPIREDDRUGVIEWBindingSource.DataMember = "EXPIREDDRUGVIEW";
            this.eXPIREDDRUGVIEWBindingSource.DataSource = this.pOSDataSet;
            // 
            // eXPIREDDRUGVIEWTableAdapter
            // 
            this.eXPIREDDRUGVIEWTableAdapter.ClearBeforeFill = true;
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
            // PurchaseID
            // 
            this.PurchaseID.DataPropertyName = "PurchaseID";
            this.PurchaseID.HeaderText = "PurchaseID";
            this.PurchaseID.Name = "PurchaseID";
            this.PurchaseID.Visible = false;
            // 
            // ExpiryStatus
            // 
            this.ExpiryStatus.DataPropertyName = "ExpiryStatus";
            this.ExpiryStatus.HeaderText = "Removed";
            this.ExpiryStatus.Name = "ExpiryStatus";
            // 
            // QuantityRemaining
            // 
            this.QuantityRemaining.DataPropertyName = "QuantityRemaining";
            this.QuantityRemaining.HeaderText = "Quantity Remaining";
            this.QuantityRemaining.Name = "QuantityRemaining";
            this.QuantityRemaining.ReadOnly = true;
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "Expiry Date";
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            this.expiryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Drug";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eXPIREDDRUGVIEWDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.eXPIREDDRUGVIEWDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eXPIREDDRUGVIEWDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn,
            this.QuantityRemaining,
            this.ExpiryStatus,
            this.PurchaseID});
            this.eXPIREDDRUGVIEWDataGridView.DataSource = this.eXPIREDDRUGVIEWBindingSource;
            this.eXPIREDDRUGVIEWDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eXPIREDDRUGVIEWDataGridView.Location = new System.Drawing.Point(1, 51);
            this.eXPIREDDRUGVIEWDataGridView.Name = "eXPIREDDRUGVIEWDataGridView";
            this.eXPIREDDRUGVIEWDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.eXPIREDDRUGVIEWDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.eXPIREDDRUGVIEWDataGridView.Size = new System.Drawing.Size(554, 458);
            this.eXPIREDDRUGVIEWDataGridView.TabIndex = 241;
            this.eXPIREDDRUGVIEWDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.eXPIREDDRUGVIEWDataGridView_CellEndEdit);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(Label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(554, 50);
            this.panel5.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(518, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 159;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Expired
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 510);
            this.Controls.Add(this.eXPIREDDRUGVIEWDataGridView);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Expired";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expired";
            this.Load += new System.EventHandler(this.Expired_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPIREDDRUGVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPIREDDRUGVIEWDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource eXPIREDDRUGVIEWBindingSource;
        private POSDataSetTableAdapters.EXPIREDDRUGVIEWTableAdapter eXPIREDDRUGVIEWTableAdapter;
        private POSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExpiryStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView eXPIREDDRUGVIEWDataGridView;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Button button1;
    }
}