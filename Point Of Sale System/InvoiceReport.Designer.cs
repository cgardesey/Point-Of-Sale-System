namespace Point_Of_Sale_System
{
    partial class InvoiceReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCartNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SETTINGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.POSDataSet = new Point_Of_Sale_System.POSDataSet();
            this.SALESVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SETTINGSTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.SETTINGSTableAdapter();
            this.SALESVIEWTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.SALESVIEWTableAdapter();
            this.sALESCARTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sALESCARTTableAdapter = new Point_Of_Sale_System.POSDataSetTableAdapters.SALESCARTTableAdapter();
            Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SETTINGSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SALESVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESCARTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.BackColor = System.Drawing.Color.White;
            Label1.Dock = System.Windows.Forms.DockStyle.Top;
            Label1.Font = new System.Drawing.Font("Trebuchet MS", 17F);
            Label1.ForeColor = System.Drawing.Color.Black;
            Label1.Location = new System.Drawing.Point(1, 1);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(388, 48);
            Label1.TabIndex = 175;
            Label1.Text = "Invoice";
            Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            Label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove);
            Label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 691);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(389, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 691);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 692);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 1);
            this.panel4.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 1);
            this.panel1.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(362, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 27);
            this.btnExit.TabIndex = 315;
            this.btnExit.Text = "x";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lblCartNo
            // 
            this.lblCartNo.AutoSize = true;
            this.lblCartNo.Location = new System.Drawing.Point(-171, 22);
            this.lblCartNo.Name = "lblCartNo";
            this.lblCartNo.Size = new System.Drawing.Size(35, 13);
            this.lblCartNo.TabIndex = 313;
            this.lblCartNo.Text = "label4";
            this.lblCartNo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 316;
            this.label2.Text = "label4";
            this.label2.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SETTINGSBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SALESVIEWBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.sALESCARTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Point_Of_Sale_System.InvoiceRepoprt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(388, 643);
            this.reportViewer1.TabIndex = 317;
            // 
            // SETTINGSBindingSource
            // 
            this.SETTINGSBindingSource.DataMember = "SETTINGS";
            this.SETTINGSBindingSource.DataSource = this.POSDataSet;
            // 
            // POSDataSet
            // 
            this.POSDataSet.DataSetName = "POSDataSet";
            this.POSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SALESVIEWBindingSource
            // 
            this.SALESVIEWBindingSource.DataMember = "SALESVIEW";
            this.SALESVIEWBindingSource.DataSource = this.POSDataSet;
            // 
            // SETTINGSTableAdapter
            // 
            this.SETTINGSTableAdapter.ClearBeforeFill = true;
            // 
            // SALESVIEWTableAdapter
            // 
            this.SALESVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // sALESCARTBindingSource
            // 
            this.sALESCARTBindingSource.DataMember = "SALESCART";
            this.sALESCARTBindingSource.DataSource = this.POSDataSet;
            // 
            // sALESCARTTableAdapter
            // 
            this.sALESCARTTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 693);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCartNo);
            this.Controls.Add(Label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoiceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceReport";
            this.Load += new System.EventHandler(this.InvoiceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SETTINGSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SALESVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESCARTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource SETTINGSBindingSource;
        private POSDataSet POSDataSet;
        private System.Windows.Forms.BindingSource SALESVIEWBindingSource;
        private POSDataSetTableAdapters.SETTINGSTableAdapter SETTINGSTableAdapter;
        private POSDataSetTableAdapters.SALESVIEWTableAdapter SALESVIEWTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCartNo;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sALESCARTBindingSource;
        private POSDataSetTableAdapters.SALESCARTTableAdapter sALESCARTTableAdapter;
    }
}