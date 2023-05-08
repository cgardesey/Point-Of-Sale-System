using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sale_System
{
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
            roleTextBox.Clear();
            btnSave.Enabled = false;
        }
        #region Form Properties
        private const int CS_DROPSHADOW = 0x00020000;

        private bool Dragging = false;
        private Point StartPoint = new Point(0, 0);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        #endregion
        private void Role_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.ROLE' table. You can move, or remove it, as needed.
            this.rOLETableAdapter.Fill(this.pOSDataSet.ROLE);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.rOLEBindingSource.AddNew();
                ((DataRowView)rOLEBindingSource.Current)["Role"] = roleTextBox.Text;

                this.Validate();
                this.rOLEBindingSource.EndEdit();
                this.rOLETableAdapter.Update(this.pOSDataSet.ROLE);

                MessageBoxForm messageBox = new MessageBoxForm(roleTextBox + "Role Created");
                messageBox.ShowDialog();

                roleTextBox.Clear();
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
            
        }

        private void roleTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (!(btnSave.Enabled))
            {
                this.Close();
            }
            else if (btnSave.Enabled)
            {
                MessageBoxForm messageBox = new MessageBoxForm("Changes Have Not Been Saved.  Are You Sure You Want To Close? ");
                messageBox.yes = true;
                messageBox.no = true;
                messageBox.ok = false;
                DialogResult result = messageBox.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                    return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(btnSave.Enabled))
            {
                this.Close();
            }
            else if (btnSave.Enabled)
            {
                MessageBoxForm messageBox = new MessageBoxForm("           Changes Have Not Been Saved.         Are You Sure You Want To Close ? ");
                messageBox.yes = true;
                messageBox.no = true;
                messageBox.ok = false;
                DialogResult result = messageBox.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxForm messageBox = new MessageBoxForm("Are Sure You Want To Delete " + roleTextBox.Text);
                messageBox.yes = true;
                messageBox.no = true;
                messageBox.ok = false;
                DialogResult result = messageBox.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.rOLEBindingSource.RemoveCurrent();
                    this.rOLETableAdapter.Update(this.pOSDataSet.ROLE);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dvgSearch.Visible = true;
            label2.Visible = true;
            roleTextBox.Visible = true;
            btnRemove.Visible = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            roleTextBox.Visible = true;
            btnSave.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dvgSearch.Visible = true;
            label2.Visible = true;
            roleTextBox.Visible = true;
            btnRemove.Visible = true;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            roleTextBox.Visible = true;
            btnSave.Visible = true;
            button2.Enabled = false;
        }

        private void dvgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string category = this.dvgSearch.SelectedRows[0].Cells[0].Value.ToString();
            roleTextBox.Text = category;
        }

    }
}
