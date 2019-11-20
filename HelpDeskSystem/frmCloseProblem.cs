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
    public partial class frmCloseProblem : Form
    {
        LoggedProblem logProb = new LoggedProblem();
        EnterProblem prob = new EnterProblem();       
        string date;
        public frmCloseProblem()
        {
            InitializeComponent();
        }

        private void frmCloseProblem_Load(object sender, EventArgs e)
        {        
            date = DateTime.Now.ToLongDateString();
            dgvSolvedProblems.DataSource = prob.GetSolvedProblems();
        }

        private void cmbSolvedProblems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminAuth admin = new frmAdminAuth();
            admin.ShowDialog();
        }

        private void dgvSolvedProblems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnCloseAllProblems_Click(object sender, EventArgs e)
        {
            bool success = false;
            try
            {
                DialogResult confirm = MessageBox.Show("You are about to close all problems, confirm ?", "Are you sure ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (confirm == DialogResult.OK)
                {
                    prob.UpdateProblemsForCloseAllProblems(DateTime.Parse(date));
                    logProb.UpdateLoggedProblemsForCloseAllProblems(DateTime.Parse(date));
                    success = true;
                }
                else
                    if (confirm == DialogResult.Cancel)
                {
                    this.Dispose();
                    this.Hide();
                    frmCloseProblem reload = new frmCloseProblem();
                    reload.ShowDialog();
                }
            }
            catch (System.Exception x)
            {
                MessageBox.Show(x.Message);
                success = false;
                MessageBox.Show("Error, problems were not closed.", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (success == true)
            {
                dgvSolvedProblems.DataSource = prob.GetAllProblems();

                MessageBox.Show("Problems closed successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAdminAuth admin = new frmAdminAuth();
                this.Hide();
                admin.ShowDialog();
            }
        }

        private void btnCloseSelectedProblem_Click(object sender, EventArgs e)
        {
            bool success = false;
            try
            {
                DialogResult confirm = MessageBox.Show("You are about to close the selected problem(s), confirm ?", "Are you sure ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (confirm == DialogResult.OK)
                {
                    //close multiple selected problems
                    foreach (DataGridViewRow row in dgvSolvedProblems.SelectedRows)
                    {
                        prob.UpdateProblemForCloseSelectedProblem(int.Parse(row.Cells["ProblemID"].Value.ToString()), DateTime.Parse(row.Cells["Date"].Value.ToString()));
                        logProb.UpdateLoggedProblemForCloseSelectedProblem(int.Parse(row.Cells["ProblemID"].Value.ToString()), DateTime.Parse(row.Cells["Date"].Value.ToString()));
                    }
                    success = true;
                }
                else
                    if (confirm == DialogResult.Cancel)
                {
                    this.Dispose();
                    this.Hide();
                    frmCloseProblem reload = new frmCloseProblem();
                    reload.ShowDialog();
                }
            }
            catch (System.Exception x)
            {
                MessageBox.Show(x.Message);
                success = false;
                MessageBox.Show("Error, problem(s) was not closed.", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (success == true)
            {
                dgvSolvedProblems.DataSource = prob.GetAllProblems();

                MessageBox.Show("Problem(s) closed successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult res = MessageBox.Show("Would you like to close other problem(s) ?", "Another Category ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    
                    date = DateTime.Now.ToLongDateString();
                    dgvSolvedProblems.DataSource = prob.GetSolvedProblems();
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
