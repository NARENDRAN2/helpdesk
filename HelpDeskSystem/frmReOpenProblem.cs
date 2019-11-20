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
    public partial class frmReOpenProblem : Form
    {
        EnterProblem probs = new EnterProblem();
        public frmReOpenProblem()
        {
            InitializeComponent();
        }

        private void frmReOpenProblem_Load(object sender, EventArgs e)
        {
            dgvReOpenProblems.DataSource = probs.GetClosedProblems();
        }

        private void btnReOpen_Click(object sender, EventArgs e)
        {
            bool success = false;
            try
            {
                DialogResult confirm = MessageBox.Show("You are about to re-open a problem, confirm ?", "Are you sure ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (confirm == DialogResult.OK)
                {
                    //re-open multiple selected problems
                    foreach (DataGridViewRow row in dgvReOpenProblems.SelectedRows)
                    {
                        probs.UpdateProblem(int.Parse(row.Cells["ProblemID"].Value.ToString()), row.Cells["StaffID"].Value.ToString(), "Re-opened");
                    }
                    success = true;
                }
                else
                    if (confirm == DialogResult.Cancel)
                {
                    this.Dispose();
                    this.Hide();
                    frmReOpenProblem reload = new frmReOpenProblem();
                    reload.ShowDialog();
                }
            }
            catch (System.Exception)
            {
                success = false;
                MessageBox.Show("Error, problem was not re-opened. Make sure you selected the problem first.", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (success == true)
            {
                dgvReOpenProblems.DataSource = probs.GetClosedProblems();
                
                MessageBox.Show("Problem re-opened successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult res = MessageBox.Show("Would you like to re-open another problem ?", "Another Problem ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Hide();
                    frmReOpenProblem reload = new frmReOpenProblem();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdminAuth admin = new frmAdminAuth();
            this.Hide();
            admin.ShowDialog();
        }
    }
}
