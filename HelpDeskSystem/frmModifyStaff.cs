using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDeskSystem
{
    public partial class frmModifyStaff : Form
    {
        Staff staff = new Staff();
        public frmModifyStaff()
        {
            InitializeComponent();
        }

        private void frmModifyStaff_Load(object sender, EventArgs e)
        {
            dgvStaff.DataSource = staff.GetStaff();
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminAuth admin = new frmAdminAuth();
            admin.ShowDialog();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            bool success;
            try
            {
                staff.InsertStaff(txtStaffID.Text,txtSurname.Text,txtFirstName.Text,txtStaffRole.Text,txtStaffUsername.Text);
                success = true;
            }
            catch (System.Exception)
            {
                success = false;
                MessageBox.Show("Error, staff was not added. Make sure you Staff ID doesn't exist already.", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (success == true)
            {
                dgvStaff.DataSource = staff.GetStaff();
                MessageBox.Show("Staff added successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult res = MessageBox.Show("Would you like to add another staff ?", "Another Category ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    txtStaffID.Clear();
                    txtSurname.Clear();
                    txtFirstName.Clear();
                    txtStaffRole.Clear();
                    txtStaffUsername.Clear();
                    txtStaffID.Focus();
                }
                else
                    if (res == DialogResult.No)
                {
                    frmAdminAuth admin = new frmAdminAuth();
                    this.Hide();
                    admin.ShowDialog();
                }
            }
        }

        private void lblClearFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtStaffID.Clear();
            txtSurname.Clear();
            txtFirstName.Clear();
            txtStaffRole.Clear();
            txtStaffUsername.Clear();
            txtStaffID.Focus();
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            bool success = false;
            try
            {
                DialogResult confirm = MessageBox.Show("You are about to delete a staff, confirm ?", "Are you sure ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (confirm == DialogResult.OK)
                {
                    //DELETE multiple selected Staff
                    foreach (DataGridViewRow row in dgvStaff.SelectedRows)
                    {                      
                        staff.DeleteStaff(row.Cells["StaffID"].Value.ToString());
                    }
                    success = true;
                }
                else
                    if (confirm == DialogResult.Cancel)
                {
                    this.Dispose();
                    this.Hide();
                    frmModifyStaff reload = new frmModifyStaff();
                    reload.ShowDialog();
                }
            }
            catch (System.Exception)
            {
                success = false;
                MessageBox.Show("Error, staff was not deleted. Make sure you selected the staff first.", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (success == true)
            {
                dgvStaff.DataSource = staff.GetStaff();

                MessageBox.Show("Staff deleted successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult res = MessageBox.Show("Would you like to delete another staff ?", "Another Category ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    txtStaffID.Clear();
                    txtSurname.Clear();
                    txtFirstName.Clear();
                    txtStaffRole.Clear();
                    txtStaffUsername.Clear();
                    txtStaffID.Focus();
                }
                else
                    if (res == DialogResult.No)
                {
                    frmAdminAuth admin = new frmAdminAuth();
                    this.Hide();
                    admin.ShowDialog();
                }
            }
        }
    }
}
