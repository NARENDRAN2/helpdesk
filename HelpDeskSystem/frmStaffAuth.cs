using System;
using System.Windows.Forms;

namespace HelpDeskSystem
{
    public partial class frmStaffAuth : Form
    {
        EnterProblem probs = new EnterProblem();
        LoggedProblem logProb = new LoggedProblem();
              
        string assignedStaff; //verifies if staff is logging a problem that was assigned to them
        string currentStaff;
        public frmStaffAuth(string loggedStaffID)
        {
            currentStaff = loggedStaffID;
            InitializeComponent();
        }

        private void frmStaffAuth_Load(object sender, EventArgs e)
        {
            dgvProblems.DataSource = probs.GetWaitingProblems();
            txtDateLog.Text = DateTime.Now.ToLongDateString();       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProblems.Rows[e.RowIndex];
                txtProblemID.Text = row.Cells["ProblemID"].Value.ToString();
                assignedStaff = row.Cells["StaffID"].Value.ToString(); //retrieves staffID from problem to verify if staff is logging a problem assigned to them
            }
        }

        private void btnAddLog_Click(object sender, EventArgs e)
        {
            bool success;
            
            if (assignedStaff == currentStaff) //checks if the staff is logging a problem that was assigned to them
            {
                logProb.UpdateProblemLog(int.Parse(txtProblemID.Text), DateTime.Parse(txtDateLog.Text), currentStaff, txtProblemComment.Text);
                probs.UpdateProblem(int.Parse(txtProblemID.Text), currentStaff, cmbChangeStatus.SelectedText);
                success = true;

                if (success == true)
                {
                    dgvProblems.DataSource = probs.GetWaitingProblems();
                    MessageBox.Show("Problem logged successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult res = MessageBox.Show("Would you like to log another problem ?", "Allocate Problem ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        cmbChangeStatus.ResetText();
                        txtProblemID.Clear();
                        txtProblemComment.Clear();
                    }
                    else
                        if (res == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, Problem was not logged. You can only log a problem that was assigned to you - your staff ID.", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                success = false;                
            }

     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
    }
}
