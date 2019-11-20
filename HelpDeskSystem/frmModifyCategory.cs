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
    public partial class frmModifyCategory : Form
    {
        Category cat = new Category();
        public frmModifyCategory()
        {
            InitializeComponent();
        }

        private void frmModifyCategory_Load(object sender, EventArgs e)
        {
            dgvCategory.DataSource = cat.GetCategory();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminAuth admin = new frmAdminAuth();        
            admin.ShowDialog();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            bool success;
            try
            {
                cat.InsertCategory(txtCategoryID.Text, txtCatDescr.Text);
                success = true;
            }
            catch (System.Exception)
            {
                success = false;
                MessageBox.Show("Error, category was not added. Make sure you entered every input correctly.", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (success == true)
            {
                dgvCategory.DataSource = cat.GetCategory();
                MessageBox.Show("Category added successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult res = MessageBox.Show("Would you like to add another category ?", "Another Category ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    txtCategoryID.Clear();
                    txtCatDescr.Clear();
                    txtCategoryID.Focus();
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

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            bool success = false;
            try
            {
                DialogResult confirm = MessageBox.Show("You are about to delete a category, confirm ?", "Are you sure ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (confirm == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvCategory.SelectedRows)
                    {
                        cat.DeleteCategory(row.Cells["CategoryID"].Value.ToString(), row.Cells["CategoryDescription"].Value.ToString());
                        //staff.DeleteStaff(row.Cells["StaffID"].Value.ToString());
                    }
                    success = true;
                }
                else
                    if (confirm == DialogResult.Cancel)
                {
                    this.Dispose();
                    this.Hide();
                    frmModifyCategory reload = new frmModifyCategory();
                    reload.ShowDialog();
                }
            }
            catch (System.Exception)
            {
                success = false;
                MessageBox.Show("Error, category was not deleted. Make sure you selected the category first.", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (success == true)
            {
                dgvCategory.DataSource = cat.GetCategory();
                
                MessageBox.Show("Category deleted successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult res = MessageBox.Show("Would you like to delete another category ?", "Another Category ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                    {
                        txtCategoryID.Clear();
                        txtCatDescr.Clear();
                        txtCategoryID.Focus();
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
            txtCategoryID.Clear();
            txtCatDescr.Clear();
            txtCategoryID.Focus();
        }
    }
}
