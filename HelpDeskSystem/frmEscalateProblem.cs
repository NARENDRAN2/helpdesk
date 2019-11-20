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
    public partial class frmEscalateProblem : Form
    {
        EnterProblem probs = new EnterProblem();
        string problemID;
        public frmEscalateProblem()
        {
            InitializeComponent();
        }

        private void frmEscalateProblem_Load(object sender, EventArgs e)
        {
            problemID = "";
            dgvEscalateProblem.DataSource = probs.GetOpenProblems();
            
        }

        private void btnEscalate_Click(object sender, EventArgs e)
        {
            bool success = false;
            try
            {
                DialogResult confirm = MessageBox.Show("You are about to escalate a problem, confirm ?", "Are you sure ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (confirm == DialogResult.OK)
                {
                    probs.UpdateEscalatedProblem(int.Parse(problemID), cmbEscalate.SelectedText);                    
                    success = true;
                }
                else
                    if (confirm == DialogResult.Cancel)
                {
                    this.Dispose();
                    this.Hide();
                    frmEscalateProblem reload = new frmEscalateProblem();
                    reload.ShowDialog();
                }
            }
            catch (System.Exception)
            {
                success = false;
                MessageBox.Show("Error, problem was not escalated. Make sure you selected the problem first.", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (success == true)
            {
                dgvEscalateProblem.DataSource = probs.GetClosedProblems();

                MessageBox.Show("Problem escalated successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult res = MessageBox.Show("Would you like to escalate another problem ?", "Another Problem ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Hide();
                    frmEscalateProblem reload = new frmEscalateProblem();
                    reload.ShowDialog();
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

        private void dgvEscalateProblem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvEscalateProblem.Rows[e.RowIndex];
                problemID = row.Cells["ProblemID"].Value.ToString();
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdminAuth admin = new frmAdminAuth();
            this.Hide();
            admin.ShowDialog();
        }
    }
}
