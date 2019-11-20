namespace HelpDeskSystem
{
    partial class frmVerifyStaffLogging
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblStaffUsername = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.txtUsername.Location = new System.Drawing.Point(153, 70);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(170, 24);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.UseSystemPasswordChar = true;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.txtStaffID.Location = new System.Drawing.Point(153, 19);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(170, 24);
            this.txtStaffID.TabIndex = 4;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.lblStaffID.Location = new System.Drawing.Point(12, 23);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(95, 17);
            this.lblStaffID.TabIndex = 6;
            this.lblStaffID.Text = "Staff ID :";
            // 
            // lblStaffUsername
            // 
            this.lblStaffUsername.AutoSize = true;
            this.lblStaffUsername.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.lblStaffUsername.Location = new System.Drawing.Point(12, 77);
            this.lblStaffUsername.Name = "lblStaffUsername";
            this.lblStaffUsername.Size = new System.Drawing.Size(107, 17);
            this.lblStaffUsername.TabIndex = 7;
            this.lblStaffUsername.Text = "Username :";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(122, 131);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // frmVerifyStaffLogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 177);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblStaffUsername);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtStaffID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerifyStaffLogging";
            this.Text = "frmVerifyStaffLogging";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblStaffUsername;
        private System.Windows.Forms.Button btnConfirm;
    }
}