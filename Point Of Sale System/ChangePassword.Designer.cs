namespace Point_Of_Sale_System
{
    partial class ChangePassword
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
            System.Windows.Forms.Label UsernameLabel;
            System.Windows.Forms.Label Label1;
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnViewPass2 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.NewPassTextBox = new System.Windows.Forms.TextBox();
            this.btnViewPass3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmPassTextBox = new System.Windows.Forms.TextBox();
            this.btnViewPass1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OldPassTextBox = new System.Windows.Forms.TextBox();
            this.lblHash = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblOldPass = new System.Windows.Forms.Label();
            UsernameLabel = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new System.Drawing.Point(100, 145);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new System.Drawing.Size(75, 18);
            UsernameLabel.TabIndex = 164;
            UsernameLabel.Text = "Username:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            Label1.ForeColor = System.Drawing.Color.Orange;
            Label1.Location = new System.Drawing.Point(4, 5);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(222, 35);
            Label1.TabIndex = 161;
            Label1.Text = "Change Password";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.White;
            this.UsernameTextBox.Location = new System.Drawing.Point(103, 166);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ReadOnly = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(248, 23);
            this.UsernameTextBox.TabIndex = 162;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(430, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 27);
            this.button1.TabIndex = 178;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ToolTip1.SetToolTip(this.button1, "Close");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewPass2
            // 
            this.btnViewPass2.BackColor = System.Drawing.Color.White;
            this.btnViewPass2.BackgroundImage = global::Point_Of_Sale_System.Properties.Resources.passwordblack;
            this.btnViewPass2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewPass2.FlatAppearance.BorderSize = 0;
            this.btnViewPass2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnViewPass2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnViewPass2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPass2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPass2.ForeColor = System.Drawing.Color.White;
            this.btnViewPass2.Location = new System.Drawing.Point(331, 267);
            this.btnViewPass2.Name = "btnViewPass2";
            this.btnViewPass2.Size = new System.Drawing.Size(19, 20);
            this.btnViewPass2.TabIndex = 170;
            this.btnViewPass2.UseVisualStyleBackColor = false;
            this.btnViewPass2.MouseCaptureChanged += new System.EventHandler(this.btnViewPass2_MouseCaptureChanged);
            this.btnViewPass2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnViewPass2_MouseDown);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(100, 244);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(103, 18);
            this.Label2.TabIndex = 168;
            this.Label2.Text = "New Password:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Orange;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(150, 364);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(138, 37);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "&Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // NewPassTextBox
            // 
            this.NewPassTextBox.Location = new System.Drawing.Point(103, 265);
            this.NewPassTextBox.Name = "NewPassTextBox";
            this.NewPassTextBox.Size = new System.Drawing.Size(248, 23);
            this.NewPassTextBox.TabIndex = 1;
            this.NewPassTextBox.UseSystemPasswordChar = true;
            // 
            // btnViewPass3
            // 
            this.btnViewPass3.BackColor = System.Drawing.Color.White;
            this.btnViewPass3.BackgroundImage = global::Point_Of_Sale_System.Properties.Resources.passwordblack;
            this.btnViewPass3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewPass3.FlatAppearance.BorderSize = 0;
            this.btnViewPass3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnViewPass3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnViewPass3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPass3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPass3.ForeColor = System.Drawing.Color.White;
            this.btnViewPass3.Location = new System.Drawing.Point(332, 322);
            this.btnViewPass3.Name = "btnViewPass3";
            this.btnViewPass3.Size = new System.Drawing.Size(19, 20);
            this.btnViewPass3.TabIndex = 173;
            this.btnViewPass3.UseVisualStyleBackColor = false;
            this.btnViewPass3.MouseCaptureChanged += new System.EventHandler(this.btnViewPass3_MouseCaptureChanged);
            this.btnViewPass3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnViewPass3_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 172;
            this.label3.Text = "Confirm Password:";
            // 
            // confirmPassTextBox
            // 
            this.confirmPassTextBox.Location = new System.Drawing.Point(103, 320);
            this.confirmPassTextBox.Name = "confirmPassTextBox";
            this.confirmPassTextBox.Size = new System.Drawing.Size(248, 23);
            this.confirmPassTextBox.TabIndex = 2;
            this.confirmPassTextBox.UseSystemPasswordChar = true;
            this.confirmPassTextBox.TextChanged += new System.EventHandler(this.confirmPassTextBox_TextChanged);
            // 
            // btnViewPass1
            // 
            this.btnViewPass1.BackColor = System.Drawing.Color.White;
            this.btnViewPass1.BackgroundImage = global::Point_Of_Sale_System.Properties.Resources.passwordblack;
            this.btnViewPass1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewPass1.FlatAppearance.BorderSize = 0;
            this.btnViewPass1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnViewPass1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnViewPass1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPass1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPass1.ForeColor = System.Drawing.Color.White;
            this.btnViewPass1.Location = new System.Drawing.Point(330, 216);
            this.btnViewPass1.Name = "btnViewPass1";
            this.btnViewPass1.Size = new System.Drawing.Size(19, 20);
            this.btnViewPass1.TabIndex = 176;
            this.btnViewPass1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 175;
            this.label4.Text = "Old Password:";
            // 
            // OldPassTextBox
            // 
            this.OldPassTextBox.Location = new System.Drawing.Point(102, 214);
            this.OldPassTextBox.Name = "OldPassTextBox";
            this.OldPassTextBox.Size = new System.Drawing.Size(248, 23);
            this.OldPassTextBox.TabIndex = 0;
            this.OldPassTextBox.UseSystemPasswordChar = true;
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(7, 457);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(44, 18);
            this.lblHash.TabIndex = 177;
            this.lblHash.Text = "label5";
            this.lblHash.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(7, 426);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(44, 18);
            this.lblPassword.TabIndex = 179;
            this.lblPassword.Text = "label5";
            this.lblPassword.Visible = false;
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Location = new System.Drawing.Point(12, 408);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(44, 18);
            this.lblOldPass.TabIndex = 180;
            this.lblOldPass.Text = "label5";
            this.lblOldPass.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(456, 484);
            this.Controls.Add(this.lblOldPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.btnViewPass1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OldPassTextBox);
            this.Controls.Add(this.btnViewPass3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmPassTextBox);
            this.Controls.Add(UsernameLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(Label1);
            this.Controls.Add(this.btnViewPass2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.NewPassTextBox);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangePassword";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ChangePassword_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePassword_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangePassword_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangePassword_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox UsernameTextBox;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.Button btnViewPass2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnChangePassword;
        internal System.Windows.Forms.TextBox NewPassTextBox;
        internal System.Windows.Forms.Button btnViewPass3;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox confirmPassTextBox;
        internal System.Windows.Forms.Button btnViewPass1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox OldPassTextBox;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblOldPass;
    }
}