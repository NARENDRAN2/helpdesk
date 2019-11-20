namespace HelpDeskSystem
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLoginAs = new System.Windows.Forms.ComboBox();
            this.loginContainer = new System.Windows.Forms.SplitContainer();
            this.lblEnterProb = new System.Windows.Forms.LinkLabel();
            this.lblInvalidLogin = new System.Windows.Forms.Label();
            this.lblProceed = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginContainer)).BeginInit();
            this.loginContainer.Panel1.SuspendLayout();
            this.loginContainer.Panel2.SuspendLayout();
            this.loginContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(121, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To IT HelpDesk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label2.Location = new System.Drawing.Point(33, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login as: ";
            // 
            // cmbLoginAs
            // 
            this.cmbLoginAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbLoginAs.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.cmbLoginAs.FormattingEnabled = true;
            this.cmbLoginAs.Items.AddRange(new object[] {
            "User (Student)",
            "Staff",
            "Administrator"});
            this.cmbLoginAs.Location = new System.Drawing.Point(36, 84);
            this.cmbLoginAs.Name = "cmbLoginAs";
            this.cmbLoginAs.Size = new System.Drawing.Size(171, 26);
            this.cmbLoginAs.TabIndex = 2;
            this.cmbLoginAs.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // loginContainer
            // 
            this.loginContainer.BackColor = System.Drawing.Color.Transparent;
            this.loginContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginContainer.ForeColor = System.Drawing.SystemColors.Control;
            this.loginContainer.Location = new System.Drawing.Point(12, 114);
            this.loginContainer.Name = "loginContainer";
            // 
            // loginContainer.Panel1
            // 
            this.loginContainer.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.loginContainer.Panel1.Controls.Add(this.lblEnterProb);
            this.loginContainer.Panel1.Controls.Add(this.cmbLoginAs);
            this.loginContainer.Panel1.Controls.Add(this.label2);
            // 
            // loginContainer.Panel2
            // 
            this.loginContainer.Panel2.Controls.Add(this.lblInvalidLogin);
            this.loginContainer.Panel2.Controls.Add(this.lblProceed);
            this.loginContainer.Panel2.Controls.Add(this.txtPassword);
            this.loginContainer.Panel2.Controls.Add(this.txtUsername);
            this.loginContainer.Panel2.Controls.Add(this.lblPassword);
            this.loginContainer.Panel2.Controls.Add(this.lblUsername);
            this.loginContainer.Panel2.Enabled = false;
            this.loginContainer.Size = new System.Drawing.Size(506, 207);
            this.loginContainer.SplitterDistance = 247;
            this.loginContainer.TabIndex = 3;
            // 
            // lblEnterProb
            // 
            this.lblEnterProb.ActiveLinkColor = System.Drawing.Color.Lime;
            this.lblEnterProb.AutoSize = true;
            this.lblEnterProb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEnterProb.Font = new System.Drawing.Font("BankGothic Md BT", 10F);
            this.lblEnterProb.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEnterProb.LinkColor = System.Drawing.Color.Transparent;
            this.lblEnterProb.Location = new System.Drawing.Point(33, 163);
            this.lblEnterProb.Name = "lblEnterProb";
            this.lblEnterProb.Size = new System.Drawing.Size(166, 14);
            this.lblEnterProb.TabIndex = 3;
            this.lblEnterProb.TabStop = true;
            this.lblEnterProb.Text = "Enter your problem";
            this.lblEnterProb.Visible = false;
            this.lblEnterProb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEnterProb_LinkClicked);
            // 
            // lblInvalidLogin
            // 
            this.lblInvalidLogin.AutoSize = true;
            this.lblInvalidLogin.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.lblInvalidLogin.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidLogin.Location = new System.Drawing.Point(64, 14);
            this.lblInvalidLogin.Name = "lblInvalidLogin";
            this.lblInvalidLogin.Size = new System.Drawing.Size(125, 17);
            this.lblInvalidLogin.TabIndex = 5;
            this.lblInvalidLogin.Text = "Invalid Login";
            this.lblInvalidLogin.Visible = false;
            // 
            // lblProceed
            // 
            this.lblProceed.ActiveLinkColor = System.Drawing.Color.Lime;
            this.lblProceed.AutoSize = true;
            this.lblProceed.Font = new System.Drawing.Font("BankGothic Md BT", 10F);
            this.lblProceed.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProceed.LinkColor = System.Drawing.Color.Transparent;
            this.lblProceed.Location = new System.Drawing.Point(36, 175);
            this.lblProceed.Name = "lblProceed";
            this.lblProceed.Size = new System.Drawing.Size(73, 14);
            this.lblProceed.TabIndex = 4;
            this.lblProceed.TabStop = true;
            this.lblProceed.Text = "Proceed";
            this.lblProceed.Visible = false;
            this.lblProceed.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblProceed_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.txtPassword.Location = new System.Drawing.Point(38, 132);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(170, 24);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.txtUsername.Location = new System.Drawing.Point(38, 62);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(170, 24);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.lblPassword.Location = new System.Drawing.Point(35, 112);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(108, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.lblUsername.Location = new System.Drawing.Point(36, 42);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(107, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username :";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 348);
            this.Controls.Add(this.loginContainer);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginContainer.Panel1.ResumeLayout(false);
            this.loginContainer.Panel1.PerformLayout();
            this.loginContainer.Panel2.ResumeLayout(false);
            this.loginContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginContainer)).EndInit();
            this.loginContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLoginAs;
        private System.Windows.Forms.SplitContainer loginContainer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.LinkLabel lblEnterProb;
        private System.Windows.Forms.LinkLabel lblProceed;
        private System.Windows.Forms.Label lblInvalidLogin;
    }
}

