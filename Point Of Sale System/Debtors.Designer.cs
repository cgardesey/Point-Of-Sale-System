namespace Point_Of_Sale_System
{
    partial class Debtors
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
            System.Windows.Forms.Label Label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Debtors));
            this.panelEmp = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.btnEditDebtor = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewDebtor = new System.Windows.Forms.Button();
            this.btnNewDebtor = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            Label1.Size = new System.Drawing.Size(98, 35);
            Label1.TabIndex = 125;
            Label1.Text = "Debtor";
            // 
            // panelEmp
            // 
            this.panelEmp.BackColor = System.Drawing.Color.Indigo;
            this.panelEmp.Controls.Add(this.label2);
            this.panelEmp.Controls.Add(this.roleLabel);
            this.panelEmp.Controls.Add(this.btnEditDebtor);
            this.panelEmp.Controls.Add(this.labelUserName);
            this.panelEmp.Controls.Add(this.btnBack);
            this.panelEmp.Controls.Add(Label1);
            this.panelEmp.Controls.Add(this.btnViewDebtor);
            this.panelEmp.Controls.Add(this.btnNewDebtor);
            this.panelEmp.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEmp.Location = new System.Drawing.Point(0, 0);
            this.panelEmp.Name = "panelEmp";
            this.panelEmp.Size = new System.Drawing.Size(292, 550);
            this.panelEmp.TabIndex = 138;
            this.panelEmp.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEmp_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(7, 60);
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
            this.roleLabel.Location = new System.Drawing.Point(6, 32);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(70, 18);
            this.roleLabel.TabIndex = 167;
            this.roleLabel.Text = "Username";
            // 
            // btnEditDebtor
            // 
            this.btnEditDebtor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditDebtor.BackColor = System.Drawing.Color.Transparent;
            this.btnEditDebtor.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnEditDebtor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnEditDebtor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnEditDebtor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDebtor.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDebtor.ForeColor = System.Drawing.Color.White;
            this.btnEditDebtor.Location = new System.Drawing.Point(0, 251);
            this.btnEditDebtor.Name = "btnEditDebtor";
            this.btnEditDebtor.Size = new System.Drawing.Size(292, 55);
            this.btnEditDebtor.TabIndex = 166;
            this.btnEditDebtor.Text = "         Edit Debtor";
            this.btnEditDebtor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDebtor.UseVisualStyleBackColor = false;
            this.btnEditDebtor.Click += new System.EventHandler(this.btnEditProduct_Click);
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
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 100);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 43);
            this.btnBack.TabIndex = 165;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewDebtor
            // 
            this.btnViewDebtor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewDebtor.BackColor = System.Drawing.Color.Transparent;
            this.btnViewDebtor.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnViewDebtor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnViewDebtor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnViewDebtor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDebtor.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDebtor.ForeColor = System.Drawing.Color.White;
            this.btnViewDebtor.Location = new System.Drawing.Point(0, 312);
            this.btnViewDebtor.Name = "btnViewDebtor";
            this.btnViewDebtor.Size = new System.Drawing.Size(292, 55);
            this.btnViewDebtor.TabIndex = 164;
            this.btnViewDebtor.Text = "         Debtors Report";
            this.btnViewDebtor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDebtor.UseVisualStyleBackColor = false;
            this.btnViewDebtor.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnNewDebtor
            // 
            this.btnNewDebtor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewDebtor.BackColor = System.Drawing.Color.Transparent;
            this.btnNewDebtor.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnNewDebtor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnNewDebtor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnNewDebtor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDebtor.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDebtor.ForeColor = System.Drawing.Color.White;
            this.btnNewDebtor.Location = new System.Drawing.Point(0, 190);
            this.btnNewDebtor.Name = "btnNewDebtor";
            this.btnNewDebtor.Size = new System.Drawing.Size(292, 55);
            this.btnNewDebtor.TabIndex = 163;
            this.btnNewDebtor.Text = "         New Debtor";
            this.btnNewDebtor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewDebtor.UseVisualStyleBackColor = false;
            this.btnNewDebtor.Click += new System.EventHandler(this.btnNewProduct_Click);
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
            this.btnMinimize.Location = new System.Drawing.Point(841, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 27);
            this.btnMinimize.TabIndex = 171;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
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
            this.btnExit.Location = new System.Drawing.Point(871, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 27);
            this.btnExit.TabIndex = 172;
            this.btnExit.Text = "x";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // Debtors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelEmp);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Debtors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debtors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelEmp.ResumeLayout(false);
            this.panelEmp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panelEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label roleLabel;
        internal System.Windows.Forms.Button btnEditDebtor;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnViewDebtor;
        internal System.Windows.Forms.Button btnNewDebtor;
        internal System.Windows.Forms.Button btnMinimize;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
    }
}