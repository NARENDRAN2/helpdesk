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
    public partial class frmEnterAProblem : Form
    {
        Category cat = new Category();
        EnterProblem problem = new EnterProblem();
        public frmEnterAProblem()
        {
            InitializeComponent();
        }

        private void frmEnterAProblem_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = cat.GetCategory();
            cmbCategory.DisplayMember = "CategoryDescription";
            cmbCategory.ValueMember = "CategoryID";

            txtDate.Text= DateTime.Now.ToLongDateString();

            foreach (string drive in Environment.GetLogicalDrives())
                lstLogicDrives.Items.Add(drive);
        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProblem_Click(object sender, EventArgs e)
        {
            bool success;
            try
            {
                problem.InsertProblem(int.Parse(cmbPriority.Text), txtProblem.Text, DateTime.Parse(txtDate.Text), cmbCategory.SelectedValue.ToString(), lstLogicDrives.SelectedItem.ToString());
                success = true;
            }
            catch(System.Exception)
            {
                success = false;
                MessageBox.Show("Error, problem was not added. Make sure you entered every input", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (success == true)
            {
                MessageBox.Show("Problem added successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult res = MessageBox.Show("Would you like to enter another problem ?", "Another Problem ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                {
                    cmbCategory.ResetText();
                    txtProblem.Clear();
                    cmbPriority.ResetText();
                    lstLogicDrives.ResetText();
                }
                else
                    if(res == DialogResult.No)
                {
                    Application.Exit();
                }
            }

        }
    }
}
