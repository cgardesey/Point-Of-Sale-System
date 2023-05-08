namespace Point_Of_Sale_System
{
    partial class AddStock
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
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label quantityAvailableLabel;
            System.Windows.Forms.Label unitSellingPriceLabel;
            System.Windows.Forms.Label unitCostPriceLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label minStockLevelLabel;
            System.Windows.Forms.Label label14;
            this.btnSaveDetails = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.quantityAvailableTextBox = new System.Windows.Forms.TextBox();
            this.unitSellingPriceTextBox = new System.Windows.Forms.TextBox();
            this.unitCostPriceTextBox = new System.Windows.Forms.TextBox();
            this.categoryIDTextBox = new System.Windows.Forms.TextBox();
            this.pOSDataSet = new Point_Of_Sale_System.POSDataSet();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTOCKTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.STOCKTableAdapter();
            this.tableAdapterManager = new Point_Of_Sale_System.POSDataSetTableAdapters.TableAdapterManager();
            this.minStockLevelTextBox = new System.Windows.Forms.TextBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.HasExpirycheckBox = new System.Windows.Forms.CheckBox();
            titleLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            quantityAvailableLabel = new System.Windows.Forms.Label();
            unitSellingPriceLabel = new System.Windows.Forms.Label();
            unitCostPriceLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            minStockLevelLabel = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            titleLabel.BackColor = System.Drawing.Color.Indigo;
            titleLabel.Font = new System.Drawing.Font("Trebuchet MS", 17F);
            titleLabel.ForeColor = System.Drawing.Color.DarkOrange;
            titleLabel.Location = new System.Drawing.Point(4, 2);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(450, 37);
            titleLabel.TabIndex = 209;
            titleLabel.Text = "Add Drug Details";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseMove);
            titleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseUp);
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(56, 90);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(42, 18);
            productNameLabel.TabIndex = 212;
            productNameLabel.Text = "Drug:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(56, 128);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(69, 18);
            categoryIDLabel.TabIndex = 214;
            categoryIDLabel.Text = "Category:";
            // 
            // quantityAvailableLabel
            // 
            quantityAvailableLabel.AutoSize = true;
            quantityAvailableLabel.Location = new System.Drawing.Point(56, 170);
            quantityAvailableLabel.Name = "quantityAvailableLabel";
            quantityAvailableLabel.Size = new System.Drawing.Size(127, 18);
            quantityAvailableLabel.TabIndex = 216;
            quantityAvailableLabel.Text = "Quantity Available:";
            // 
            // unitSellingPriceLabel
            // 
            unitSellingPriceLabel.AutoSize = true;
            unitSellingPriceLabel.Location = new System.Drawing.Point(56, 210);
            unitSellingPriceLabel.Name = "unitSellingPriceLabel";
            unitSellingPriceLabel.Size = new System.Drawing.Size(119, 18);
            unitSellingPriceLabel.TabIndex = 218;
            unitSellingPriceLabel.Text = "Unit Selling Price:";
            // 
            // unitCostPriceLabel
            // 
            unitCostPriceLabel.AutoSize = true;
            unitCostPriceLabel.Location = new System.Drawing.Point(56, 250);
            unitCostPriceLabel.Name = "unitCostPriceLabel";
            unitCostPriceLabel.Size = new System.Drawing.Size(107, 18);
            unitCostPriceLabel.TabIndex = 220;
            unitCostPriceLabel.Text = "Unit Cost Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(227, 210);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(30, 16);
            label5.TabIndex = 298;
            label5.Text = "GHC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(227, 250);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 16);
            label1.TabIndex = 299;
            label1.Text = "GHC";
            // 
            // minStockLevelLabel
            // 
            minStockLevelLabel.AutoSize = true;
            minStockLevelLabel.Location = new System.Drawing.Point(56, 291);
            minStockLevelLabel.Name = "minStockLevelLabel";
            minStockLevelLabel.Size = new System.Drawing.Size(112, 18);
            minStockLevelLabel.TabIndex = 300;
            minStockLevelLabel.Text = "Min Stock Level:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(56, 327);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(112, 18);
            label14.TabIndex = 316;
            label14.Text = "Has Expiry Date:";
            // 
            // btnSaveDetails
            // 
            this.btnSaveDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveDetails.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSaveDetails.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSaveDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnSaveDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSaveDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDetails.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDetails.ForeColor = System.Drawing.Color.White;
            this.btnSaveDetails.Location = new System.Drawing.Point(298, 397);
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(123, 36);
            this.btnSaveDetails.TabIndex = 211;
            this.btnSaveDetails.Text = "&Save Details";
            this.toolTip1.SetToolTip(this.btnSaveDetails, "Save Details");
            this.btnSaveDetails.UseVisualStyleBackColor = false;
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(418, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 27);
            this.button1.TabIndex = 302;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.button1, "Close");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(225, 87);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(168, 23);
            this.productNameTextBox.TabIndex = 213;
            // 
            // categoryIDComboBox
            // 
            this.categoryIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryIDComboBox.FormattingEnabled = true;
            this.categoryIDComboBox.Location = new System.Drawing.Point(225, 125);
            this.categoryIDComboBox.Name = "categoryIDComboBox";
            this.categoryIDComboBox.Size = new System.Drawing.Size(168, 26);
            this.categoryIDComboBox.TabIndex = 215;
            this.categoryIDComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryIDComboBox_SelectedIndexChanged);
            // 
            // quantityAvailableTextBox
            // 
            this.quantityAvailableTextBox.Location = new System.Drawing.Point(225, 167);
            this.quantityAvailableTextBox.Name = "quantityAvailableTextBox";
            this.quantityAvailableTextBox.Size = new System.Drawing.Size(168, 23);
            this.quantityAvailableTextBox.TabIndex = 217;
            // 
            // unitSellingPriceTextBox
            // 
            this.unitSellingPriceTextBox.Location = new System.Drawing.Point(225, 207);
            this.unitSellingPriceTextBox.Name = "unitSellingPriceTextBox";
            this.unitSellingPriceTextBox.Size = new System.Drawing.Size(168, 23);
            this.unitSellingPriceTextBox.TabIndex = 219;
            this.unitSellingPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // unitCostPriceTextBox
            // 
            this.unitCostPriceTextBox.Location = new System.Drawing.Point(225, 247);
            this.unitCostPriceTextBox.Name = "unitCostPriceTextBox";
            this.unitCostPriceTextBox.Size = new System.Drawing.Size(168, 23);
            this.unitCostPriceTextBox.TabIndex = 221;
            this.unitCostPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // categoryIDTextBox
            // 
            this.categoryIDTextBox.Location = new System.Drawing.Point(252, 125);
            this.categoryIDTextBox.Name = "categoryIDTextBox";
            this.categoryIDTextBox.Size = new System.Drawing.Size(118, 23);
            this.categoryIDTextBox.TabIndex = 222;
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTOCKBindingSource
            // 
            this.sTOCKBindingSource.DataMember = "STOCK";
            this.sTOCKBindingSource.DataSource = this.pOSDataSet;
            // 
            // sTOCKTableAdapter
            // 
            this.sTOCKTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.STOCKTableAdapter = this.sTOCKTableAdapter;
            this.tableAdapterManager.ThresholdAlertTableAdapter = null;
            this.tableAdapterManager.TITLETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Point_Of_Sale_System.POSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERLOGINTableAdapter = null;
            this.tableAdapterManager.USERTableAdapter = null;
            // 
            // minStockLevelTextBox
            // 
            this.minStockLevelTextBox.Location = new System.Drawing.Point(225, 288);
            this.minStockLevelTextBox.Name = "minStockLevelTextBox";
            this.minStockLevelTextBox.Size = new System.Drawing.Size(168, 23);
            this.minStockLevelTextBox.TabIndex = 301;
            this.minStockLevelTextBox.TextChanged += new System.EventHandler(this.minStockLevelTextBox_TextChanged);
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
            this.btnMinimize.Location = new System.Drawing.Point(378, 13);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 27);
            this.btnMinimize.TabIndex = 315;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // HasExpirycheckBox
            // 
            this.HasExpirycheckBox.AutoSize = true;
            this.HasExpirycheckBox.Location = new System.Drawing.Point(225, 331);
            this.HasExpirycheckBox.Name = "HasExpirycheckBox";
            this.HasExpirycheckBox.Size = new System.Drawing.Size(15, 14);
            this.HasExpirycheckBox.TabIndex = 317;
            this.HasExpirycheckBox.UseVisualStyleBackColor = true;
            this.HasExpirycheckBox.CheckedChanged += new System.EventHandler(this.HasExpirycheckBox_CheckedChanged);
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(455, 467);
            this.ControlBox = false;
            this.Controls.Add(label14);
            this.Controls.Add(this.HasExpirycheckBox);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.button1);
            this.Controls.Add(minStockLevelLabel);
            this.Controls.Add(this.minStockLevelTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(label5);
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
            this.Controls.Add(this.btnSaveDetails);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.categoryIDTextBox);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddStock_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Stock_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSaveDetails;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.ComboBox categoryIDComboBox;
        private System.Windows.Forms.TextBox quantityAvailableTextBox;
        private System.Windows.Forms.TextBox unitSellingPriceTextBox;
        private System.Windows.Forms.TextBox unitCostPriceTextBox;
        private System.Windows.Forms.TextBox categoryIDTextBox;
        private POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private POSDataSetTableAdapters.STOCKTableAdapter sTOCKTableAdapter;
        private POSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox minStockLevelTextBox;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.CheckBox HasExpirycheckBox;
    }
}