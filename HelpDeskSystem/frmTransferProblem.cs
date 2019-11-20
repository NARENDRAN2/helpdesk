using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HelpDeskSystem
{
    public partial class frmTransferProblem : Form
    {
     
        LoggedProblem logProb = new LoggedProblem();
        EnterProblem probs = new EnterProblem();
        Staff staff = new Staff();
        public frmTransferProblem()
        {
            InitializeComponent();
        }

        private void frmTransferProblem_Load(object sender, EventArgs e)
        {
            cmbToStaffID.DataSource = staff.GetStaffToTransfer();
            cmbToStaffID.DisplayMember = "Fullname";
            cmbToStaffID.ValueMember = "StaffID";

            dgvProblemLogs.DataSource = probs.GetWaitingProblems();
        }

        private void dgvProblemLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProblemLogs.Rows[e.RowIndex];
                txtProblemID.Text = row.Cells["ProblemID"].Value.ToString();
                txtFromStaffID.Text = row.Cells["StaffID"].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdminAuth admin = new frmAdminAuth();
            this.Hide();
            admin.ShowDialog();
        }

        private void cmbProblemID_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            bool success;
            try
            {
                logProb.UpdateProblemLog(int.Parse(txtProblemID.Text), DateTime.Now, cmbToStaffID.SelectedValue.ToString(), "Transfered to Staff");
                probs.UpdateTransferedStaff(int.Parse(txtProblemID.Text), cmbToStaffID.SelectedValue.ToString());
                //problem.InsertProblem(int.Parse(cmbPriority.Text), txtProblem.Text, DateTime.Parse(txtDate.Text), cmbCategory.SelectedValue.ToString(), lstLogicDrives.SelectedItem.ToString());
                success = true;
            }
            catch (System.Exception)
            {
                success = false;
                MessageBox.Show("Error, problem was not transfered. Make sure you selected the problem first.", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (success == true)
            {
                MessageBox.Show("Problem transfered successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult res = MessageBox.Show("Would you like to transfer another problem ?", "Another Problem ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Hide();
                    frmTransferProblem reload = new frmTransferProblem();
                    reload.ShowDialog();
                }
                else
                    if (res == DialogResult.No)
                {
                    this.Hide();
                    frmAdminAuth reload = new frmAdminAuth();
                    reload.ShowDialog();
                }
            }
        }
    }
}
