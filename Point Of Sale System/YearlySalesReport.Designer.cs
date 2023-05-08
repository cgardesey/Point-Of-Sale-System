namespace Point_Of_Sale_System
{
    partial class YearlySalesReport
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
            System.Windows.Forms.Label label2;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GetYearlySales1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.POSDataSet1 = new Point_Of_Sale_System.POSDataSet1();
            this.panel9 = new System.Windows.Forms.Panel();
            this.getSalesYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.GetYearlySales1TableAdapter = new Point_Of_Sale_System.POSDataSet1TableAdapters.GetYearlySales1TableAdapter();
            this.getSalesYearTableAdapter = new Point_Of_Sale_System.POSDataSet1TableAdapters.GetSalesYearTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FromComboBox = new System.Windows.Forms.ComboBox();
            this.ToComboBox = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnExit = new System.Windows.Forms.Button();
            Label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GetYearlySales1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSalesYearBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.BackColor = System.Drawing.Color.Orange;
            Label1.Dock = System.Windows.Forms.DockStyle.Top;
            Label1.Font = new System.Drawing.Font("Trebuchet MS", 17F);
            Label1.ForeColor = System.Drawing.Color.Orange;
            Label1.Location = new System.Drawing.Point(0, 0);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(741, 1);
            Label1.TabIndex = 172;
            Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.White;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Font = new System.Drawing.Font("Trebuchet MS", 17F);
            label2.ForeColor = System.Drawing.Color.Orange;
            label2.Location = new System.Drawing.Point(1, 1);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(739, 48);
            label2.TabIndex = 186;
            label2.Text = "Yearly Sales Report";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // GetYearlySales1BindingSource
            // 
            this.GetYearlySales1BindingSource.DataMember = "GetYearlySales1";
            this.GetYearlySales1BindingSource.DataSource = this.POSDataSet1;
            // 
            // POSDataSet1
            // 
            this.POSDataSet1.DataSetName = "POSDataSet1";
            this.POSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Orange;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(1, 569);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(739, 1);
            this.panel9.TabIndex = 176;
            // 
            // getSalesYearBindingSource
            // 
            this.getSalesYearBindingSource.DataMember = "GetSalesYear";
            this.getSalesYearBindingSource.DataSource = this.POSDataSet1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Orange;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(740, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 569);
            this.panel8.TabIndex = 175;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Orange;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 569);
            this.panel7.TabIndex = 174;
            // 
            // GetYearlySales1TableAdapter
            // 
            this.GetYearlySales1TableAdapter.ClearBeforeFill = true;
            // 
            // getSalesYearTableAdapter
            // 
            this.getSalesYearTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.FromComboBox);
            this.panel4.Controls.Add(this.ToComboBox);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(1, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(739, 52);
            this.panel4.TabIndex = 187;
            // 
            // FromComboBox
            // 
            this.FromComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.getSalesYearBindingSource, "Year", true));
            this.FromComboBox.DataSource = this.getSalesYearBindingSource;
            this.FromComboBox.DisplayMember = "Year";
            this.FromComboBox.FormattingEnabled = true;
            this.FromComboBox.Location = new System.Drawing.Point(193, 16);
            this.FromComboBox.Name = "FromComboBox";
            this.FromComboBox.Size = new System.Drawing.Size(121, 21);
            this.FromComboBox.TabIndex = 171;
            this.FromComboBox.ValueMember = "Year";
            // 
            // ToComboBox
            // 
            this.ToComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.getSalesYearBindingSource, "Year", true));
            this.ToComboBox.DataSource = this.getSalesYearBindingSource;
            this.ToComboBox.DisplayMember = "Year";
            this.ToComboBox.FormattingEnabled = true;
            this.ToComboBox.Location = new System.Drawing.Point(396, 16);
            this.ToComboBox.Name = "ToComboBox";
            this.ToComboBox.Size = new System.Drawing.Size(121, 21);
            this.ToComboBox.TabIndex = 170;
            this.ToComboBox.ValueMember = "Year";
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 58);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(61, 501);
            this.panel6.TabIndex = 169;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.GetYearlySales1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Point_Of_Sale_System.YearlySalesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(739, 468);
            this.reportViewer1.TabIndex = 190;
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
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(704, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 27);
            this.btnExit.TabIndex = 308;
            this.btnExit.Text = "x";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // YearlySalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 570);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(label2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YearlySalesReport";
            this.Text = "YearlySalesReport";
            this.Load += new System.EventHandler(this.YearlySalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetYearlySales1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSalesYearBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.BindingSource GetYearlySales1BindingSource;
        private POSDataSet1 POSDataSet1;
        private POSDataSet1TableAdapters.GetYearlySales1TableAdapter GetYearlySales1TableAdapter;
        private System.Windows.Forms.BindingSource getSalesYearBindingSource;
        private POSDataSet1TableAdapters.GetSalesYearTableAdapter getSalesYearTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox FromComboBox;
        private System.Windows.Forms.ComboBox ToComboBox;
        private System.Windows.Forms.Panel panel6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        internal System.Windows.Forms.Button btnExit;
    }
}