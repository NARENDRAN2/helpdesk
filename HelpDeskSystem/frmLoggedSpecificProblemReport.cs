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
    public partial class frmLoggedSpecificProblemReport : Form
    {
        LoggedProblem logProb = new LoggedProblem();
        EnterProblem probs = new EnterProblem();
        public frmLoggedSpecificProblemReport()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmLoggedSpecificProblemReport_Load(object sender, EventArgs e)
        {
            cmbProblemID.DataSource = probs.GetAllProblems();
            cmbProblemID.DisplayMember = "Comment";
            cmbProblemID.ValueMember = "ProblemID";
        }

        private void cmbProblemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dgvSpecificProblem.DataSource = logProb.GetLoggedProblems(int.Parse(cmbProblemID.SelectedValue.ToString()));
        }

        private void btnExcelWork_Click(object sender, EventArgs e)
        {

        }

        private void btnWordDoc_Click(object sender, EventArgs e)
        {

        }
    }
}
