using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HelpDeskSystem
{
    public partial class frmAdminAuth : Form
    {
        EnterProblem problems = new EnterProblem();
        LoggedProblem logProblem = new LoggedProblem();
        Staff staff = new Staff();
        public frmAdminAuth()
        {
            InitializeComponent();
        }

        private void frmAdminAuth_Load(object sender, EventArgs e)
        {
            dgvOpenProblems.DataSource = problems.GetOpenProblems();

            cmbStaff.DataSource = staff.GetStaff();
            cmbStaff.DisplayMember = "StaffRole";
            cmbStaff.ValueMember = "StaffID";

            txtAllocateDate.Text = DateTime.Now.ToLongDateString();

            menuStrip1.Cursor = Cursors.Hand;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void dgvOpenProblems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvOpenProblems.Rows[e.RowIndex];
                txtProblemID.Text = row.Cells["ProblemID"].Value.ToString();
                txtProblem.Text = row.Cells["Comment"].Value.ToString();

            }
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifyStaff modSt = new frmModifyStaff();
            this.Hide();
            modSt.ShowDialog();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifyCategory modCat = new HelpDeskSystem.frmModifyCategory();
            this.Hide();
            modCat.ShowDialog();
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            bool success;
            try
            {     
                //logProblem.InsertProblemLog(DateTime.Parse(txtAllocateDate.Text), cmbStaff.SelectedValue.ToString(), "Initial Allocated Staff ID");//The INSERT statement conflicted with the FOREIGN KEY constraint...
                problems.UpdateProblem(int.Parse(txtProblemID.Text) ,cmbStaff.SelectedValue.ToString(), "Waiting");
                success = true;
            }
            catch (System.Exception)
            {
       
                success = false;
                MessageBox.Show("Error, Problem was not allocated. Check any input errors and Try again.", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (success == true)
            {
                dgvOpenProblems.DataSource = problems.GetOpenProblems();
                MessageBox.Show("Problem allocated successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult res = MessageBox.Show("Would you like to allocate another problem ?", "Allocate Problem ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    cmbStaff.ResetText();
                    txtProblem.Clear();
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

        private void solvedProblemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSolvedProblemsReport solved = new frmSolvedProblemsReport();
            solved.ShowDialog();
        }

        private void closeProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransferProblem trans = new frmTransferProblem();
            trans.ShowDialog();
        }

        private void closeProblemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCloseProblem close = new frmCloseProblem();
            close.ShowDialog();
        }

        private void allProblemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllProblemsReport all = new frmAllProblemsReport();
            all.ShowDialog();
        }

        private void openProblemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpenProblemsReport open = new frmOpenProblemsReport();
            open.ShowDialog();
        }

        private void waitingProblemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWaitingProblemsReport wait = new frmWaitingProblemsReport();
            wait.ShowDialog();
        }

        private void cLOSEDPROBLEMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClosedProblemsReport closed = new frmClosedProblemsReport();
            closed.ShowDialog();
        }

        private void highProirityProblemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHighPriorityProblemsReport highP = new frmHighPriorityProblemsReport();
            highP.ShowDialog();
        }

        private void problemsWithinDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProblemsWithinDateRangeReport range = new frmProblemsWithinDateRangeReport();
            range.ShowDialog();
        }

        private void problemLogForSpecificProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void specificStaffMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSpecificStaffReport staff = new frmSpecificStaffReport();
            staff.ShowDialog();
        }

        private void specificMachineIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSpecificMachineIDReport mach = new frmSpecificMachineIDReport();
            mach.ShowDialog();
        }

        private void specificCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSpecificCategoryReport cat = new frmSpecificCategoryReport();
            cat.ShowDialog();
        }

        private void problemLogForSpecificProblemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLoggedSpecificProblemReport logged = new frmLoggedSpecificProblemReport();
            logged.ShowDialog();
        }

        private void asWORDDOCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            



        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void reOpenProblemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReOpenProblem reopen = new frmReOpenProblem();
            reopen.ShowDialog();
        }

        private void escalateProblemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEscalateProblem escalate = new frmEscalateProblem();
            escalate.ShowDialog();
        }
    }
}
