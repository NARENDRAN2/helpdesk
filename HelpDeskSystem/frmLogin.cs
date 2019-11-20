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
    public partial class frmLogin : Form
    {
        SqlConnection dbConn;
        string connectionString;
        Login login = new Login();
        Staff staff = new Staff();
        public string loggedStaff; //will be used to confirm staff when logging a problem        
        public frmLogin()
        {         
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"H:\\MODULES\\ONT2000\\Help Desk Project\\HelpDeskSystem\\HelpDeskSystem\\Info@ITDB.mdf\"; Integrated Security = True";
            dbConn = new SqlConnection(connectionString);

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            
            if (cmbLoginAs.SelectedIndex == 0)
            {
                lblEnterProb.Visible = true;
                lblProceed.Visible = false;
                loginContainer.Panel2.Enabled = false;
                lblInvalidLogin.Visible = false;
            }
            else if (cmbLoginAs.SelectedIndex == 1)
            {
                loginContainer.Panel2.Enabled = true;
                lblEnterProb.Visible = false;
                lblUsername.Text = "Staff ID";
                lblPassword.Text = "Staff Username";
                lblProceed.Text = "Proceed as staff";
                lblProceed.Visible = true;
                txtUsername.Focus();
                lblInvalidLogin.Visible = false;
            }
            else if(cmbLoginAs.SelectedIndex == 2)
            {
                loginContainer.Panel2.Enabled = true;
                lblEnterProb.Visible = false;
                lblProceed.Text = "Proceed as admin";
                lblUsername.Text = "Username";
                lblPassword.Text = "Password";
                lblProceed.Visible = true;
                txtUsername.Focus();
                lblInvalidLogin.Visible = false;
            }
            
                
        }

        private void lblEnterProb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmEnterAProblem problemForm = new frmEnterAProblem();
            problemForm.ShowDialog();
        }

        private void lblProceed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblProceed.Text == "Proceed as admin")
            {
                if (login.GetAdminLogin(txtUsername.Text, txtPassword.Text).Rows.Count == 1)
                {
                    frmAdminAuth adminAuthorized = new frmAdminAuth();
                    this.Hide();
                    adminAuthorized.ShowDialog();                
                }
                else
                {                    
                    lblInvalidLogin.Visible = true;
                }
            }
            else if(lblProceed.Text == "Proceed as staff")
            {
                if(staff.GetStaffLogin(txtUsername.Text, txtPassword.Text).Rows.Count == 1) //For Staff, username is StaffID and password is StaffUsername
                {
                    loggedStaff = txtUsername.Text; // will be used to verify staff in logging problems
                    frmStaffAuth staffAuthorized = new frmStaffAuth(loggedStaff);
                    this.Hide();
                    staffAuthorized.ShowDialog();
                }
                else
                {
                    lblInvalidLogin.Visible = true;
                }
            }

        }
    }
}
