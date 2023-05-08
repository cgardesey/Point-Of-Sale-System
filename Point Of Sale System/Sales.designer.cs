namespace Point_Of_Sale_System
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.btnNewSale = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnProductReturns = new System.Windows.Forms.Button();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSalesReturnsReport = new System.Windows.Forms.Button();
            this.btnMonthlySalesChart = new System.Windows.Forms.Button();
            this.btnYearlySalesChart = new System.Windows.Forms.Button();
            this.panelEmp = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            Label1 = new System.Windows.Forms.Label();
            this.panelEmp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            Label1.ForeColor = System.Drawing.Color.Orange;
            Label1.Location = new System.Drawing.Point(81, 100);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(76, 35);
            Label1.TabIndex = 125;
            Label1.Text = "Sales";
            // 
            // btnNewSale
            // 
            this.btnNewSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewSale.BackColor = System.Drawing.Color.Transparent;
            this.btnNewSale.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnNewSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnNewSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnNewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSale.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSale.ForeColor = System.Drawing.Color.White;
            this.btnNewSale.Location = new System.Drawing.Point(0, 157);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(292, 55);
            this.btnNewSale.TabIndex = 163;
            this.btnNewSale.Text = "         New Sale";
            this.btnNewSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnNewSale, "New Sale");
            this.btnNewSale.UseVisualStyleBackColor = false;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // btnProductReturns
            // 
            this.btnProductReturns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProductReturns.BackColor = System.Drawing.Color.Transparent;
            this.btnProductReturns.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnProductReturns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnProductReturns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnProductReturns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductReturns.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductReturns.ForeColor = System.Drawing.Color.White;
            this.btnProductReturns.Location = new System.Drawing.Point(0, 218);
            this.btnProductReturns.Name = "btnProductReturns";
            this.btnProductReturns.Size = new System.Drawing.Size(292, 55);
            this.btnProductReturns.TabIndex = 166;
            this.btnProductReturns.Text = "         Return Inward";
            this.btnProductReturns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnProductReturns, "Return Inward");
            this.btnProductReturns.UseVisualStyleBackColor = false;
            this.btnProductReturns.Click += new System.EventHandler(this.btnProductReturns_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewSales.BackColor = System.Drawing.Color.Transparent;
            this.btnViewSales.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnViewSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnViewSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnViewSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSales.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSales.ForeColor = System.Drawing.Color.White;
            this.btnViewSales.Location = new System.Drawing.Point(3, 279);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(292, 55);
            this.btnViewSales.TabIndex = 164;
            this.btnViewSales.Text = "         Sales Report";
            this.btnViewSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnViewSales, "Sales Report");
            this.btnViewSales.UseVisualStyleBackColor = false;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
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
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Location = new System.Drawing.Point(841, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 27);
            this.btnMinimize.TabIndex = 171;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.btnMinimize, "Minimize");
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
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(871, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 27);
            this.btnExit.TabIndex = 172;
            this.btnExit.Text = "x";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolTip1.SetToolTip(this.btnExit, "Exit");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSalesReturnsReport
            // 
            this.btnSalesReturnsReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalesReturnsReport.BackColor = System.Drawing.Color.Transparent;
            this.btnSalesReturnsReport.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnSalesReturnsReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnSalesReturnsReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnSalesReturnsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReturnsReport.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReturnsReport.ForeColor = System.Drawing.Color.White;
            this.btnSalesReturnsReport.Location = new System.Drawing.Point(1, 340);
            this.btnSalesReturnsReport.Name = "btnSalesReturnsReport";
            this.btnSalesReturnsReport.Size = new System.Drawing.Size(292, 55);
            this.btnSalesReturnsReport.TabIndex = 173;
            this.btnSalesReturnsReport.Text = "         Return Inwards Report";
            this.btnSalesReturnsReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnSalesReturnsReport, "Return Inwards Report");
            this.btnSalesReturnsReport.UseVisualStyleBackColor = false;
            this.btnSalesReturnsReport.Click += new System.EventHandler(this.btnSalesReturnsReport_Click);
            // 
            // btnMonthlySalesChart
            // 
            this.btnMonthlySalesChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMonthlySalesChart.BackColor = System.Drawing.Color.Transparent;
            this.btnMonthlySalesChart.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnMonthlySalesChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnMonthlySalesChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnMonthlySalesChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlySalesChart.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlySalesChart.ForeColor = System.Drawing.Color.White;
            this.btnMonthlySalesChart.Location = new System.Drawing.Point(0, 401);
            this.btnMonthlySalesChart.Name = "btnMonthlySalesChart";
            this.btnMonthlySalesChart.Size = new System.Drawing.Size(292, 55);
            this.btnMonthlySalesChart.TabIndex = 174;
            this.btnMonthlySalesChart.Text = "         Monthly Sales Chart  Report";
            this.btnMonthlySalesChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnMonthlySalesChart, "Monthly Sales Chart  Report");
            this.btnMonthlySalesChart.UseVisualStyleBackColor = false;
            this.btnMonthlySalesChart.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnYearlySalesChart
            // 
            this.btnYearlySalesChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYearlySalesChart.BackColor = System.Drawing.Color.Transparent;
            this.btnYearlySalesChart.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnYearlySalesChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnYearlySalesChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnYearlySalesChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearlySalesChart.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearlySalesChart.ForeColor = System.Drawing.Color.White;
            this.btnYearlySalesChart.Location = new System.Drawing.Point(-3, 464);
            this.btnYearlySalesChart.Name = "btnYearlySalesChart";
            this.btnYearlySalesChart.Size = new System.Drawing.Size(292, 55);
            this.btnYearlySalesChart.TabIndex = 175;
            this.btnYearlySalesChart.Text = "          Yearly Sales Chart  Report";
            this.btnYearlySalesChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnYearlySalesChart, "Yearly Sales Chart Report");
            this.btnYearlySalesChart.UseVisualStyleBackColor = false;
            this.btnYearlySalesChart.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelEmp
            // 
            this.panelEmp.BackColor = System.Drawing.Color.Indigo;
            this.panelEmp.Controls.Add(this.btnYearlySalesChart);
            this.panelEmp.Controls.Add(this.btnMonthlySalesChart);
            this.panelEmp.Controls.Add(this.btnSalesReturnsReport);
            this.panelEmp.Controls.Add(this.label2);
            this.panelEmp.Controls.Add(this.roleLabel);
            this.panelEmp.Controls.Add(this.btnProductReturns);
            this.panelEmp.Controls.Add(this.labelUserName);
            this.panelEmp.Controls.Add(this.btnBack);
            this.panelEmp.Controls.Add(Label1);
            this.panelEmp.Controls.Add(this.btnViewSales);
            this.panelEmp.Controls.Add(this.btnNewSale);
            this.panelEmp.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEmp.Location = new System.Drawing.Point(0, 0);
            this.panelEmp.Name = "panelEmp";
            this.panelEmp.Size = new System.Drawing.Size(292, 550);
            this.panelEmp.TabIndex = 138;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(194, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 168;
            this.label2.Text = "Username";
            this.label2.Visible = false;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.ForeColor = System.Drawing.Color.Orange;
            this.roleLabel.Location = new System.Drawing.Point(8, 31);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(70, 18);
            this.roleLabel.TabIndex = 167;
            this.roleLabel.Text = "Username";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(6, 8);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(76, 20);
            this.labelUserName.TabIndex = 166;
            this.labelUserName.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Point_Of_Sale_System.Properties.Resources.jp_01;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(292, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 550);
            this.panel1.TabIndex = 139;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 97);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 43);
            this.btnBack.TabIndex = 165;
            this.toolTip1.SetToolTip(this.btnBack, "Back");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelEmp);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sales";
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelEmp.ResumeLayout(false);
            this.panelEmp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Button btnProductReturns;
        private System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnViewSales;
        internal System.Windows.Forms.Panel panelEmp;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnMinimize;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnSalesReturnsReport;
        internal System.Windows.Forms.Button btnYearlySalesChart;
        internal System.Windows.Forms.Button btnMonthlySalesChart;
        private System.Windows.Forms.Panel panel1;
    }
}