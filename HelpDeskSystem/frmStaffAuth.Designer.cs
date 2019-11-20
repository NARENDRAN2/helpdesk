namespace HelpDeskSystem
{
    partial class frmStaffAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffAuth));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProblemID = new System.Windows.Forms.TextBox();
            this.txtProblemComment = new System.Windows.Forms.RichTextBox();
            this.cmbChangeStatus = new System.Windows.Forms.ComboBox();
            this.dgvProblems = new System.Windows.Forms.DataGridView();
            this.btnAddLog = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDateLog = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(275, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello , Add a problem log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Problem ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comment :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(12, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Change Status :";
            // 
            // txtProblemID
            // 
            this.txtProblemID.BackColor = System.Drawing.SystemColors.Control;
            this.txtProblemID.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.txtProblemID.ForeColor = System.Drawing.Color.Red;
            this.txtProblemID.Location = new System.Drawing.Point(163, 101);
            this.txtProblemID.Name = "txtProblemID";
            this.txtProblemID.Size = new System.Drawing.Size(166, 24);
            this.txtProblemID.TabIndex = 4;
            // 
            // txtProblemComment
            // 
            this.txtProblemComment.BackColor = System.Drawing.SystemColors.Control;
            this.txtProblemComment.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.txtProblemComment.ForeColor = System.Drawing.Color.Red;
            this.txtProblemComment.Location = new System.Drawing.Point(163, 174);
            this.txtProblemComment.Name = "txtProblemComment";
            this.txtProblemComment.Size = new System.Drawing.Size(166, 96);
            this.txtProblemComment.TabIndex = 5;
            this.txtProblemComment.Text = "";
            // 
            // cmbChangeStatus
            // 
            this.cmbChangeStatus.BackColor = System.Drawing.SystemColors.Control;
            this.cmbChangeStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbChangeStatus.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.cmbChangeStatus.ForeColor = System.Drawing.Color.Red;
            this.cmbChangeStatus.FormattingEnabled = true;
            this.cmbChangeStatus.Items.AddRange(new object[] {
            "Waiting",
            "Solved"});
            this.cmbChangeStatus.Location = new System.Drawing.Point(163, 295);
            this.cmbChangeStatus.Name = "cmbChangeStatus";
            this.cmbChangeStatus.Size = new System.Drawing.Size(166, 26);
            this.cmbChangeStatus.TabIndex = 6;
            // 
            // dgvProblems
            // 
            this.dgvProblems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProblems.Location = new System.Drawing.Point(353, 86);
            this.dgvProblems.Name = "dgvProblems";
            this.dgvProblems.Size = new System.Drawing.Size(524, 230);
            this.dgvProblems.TabIndex = 7;
            this.dgvProblems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAddLog
            // 
            this.btnAddLog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLog.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddLog.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.btnAddLog.Location = new System.Drawing.Point(552, 337);
            this.btnAddLog.Name = "btnAddLog";
            this.btnAddLog.Size = new System.Drawing.Size(117, 37);
            this.btnAddLog.TabIndex = 8;
            this.btnAddLog.Text = "Add Log";
            this.btnAddLog.UseVisualStyleBackColor = false;
            this.btnAddLog.Click += new System.EventHandler(this.btnAddLog_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(12, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date :";
            // 
            // txtDateLog
            // 
            this.txtDateLog.BackColor = System.Drawing.SystemColors.Control;
            this.txtDateLog.Enabled = false;
            this.txtDateLog.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.txtDateLog.ForeColor = System.Drawing.Color.Red;
            this.txtDateLog.Location = new System.Drawing.Point(163, 393);
            this.txtDateLog.Name = "txtDateLog";
            this.txtDateLog.Size = new System.Drawing.Size(166, 24);
            this.txtDateLog.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.button1.Location = new System.Drawing.Point(813, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("BankGothic Md BT", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(350, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Select Problem :";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.btnLogout.Location = new System.Drawing.Point(704, 411);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 26);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmStaffAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(889, 444);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDateLog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddLog);
            this.Controls.Add(this.dgvProblems);
            this.Controls.Add(this.cmbChangeStatus);
            this.Controls.Add(this.txtProblemComment);
            this.Controls.Add(this.txtProblemID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "frmStaffAuth";
            this.Text = "Add Problem Log";
            this.Load += new System.EventHandler(this.frmStaffAuth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProblemID;
        private System.Windows.Forms.RichTextBox txtProblemComment;
        private System.Windows.Forms.ComboBox cmbChangeStatus;
        private System.Windows.Forms.DataGridView dgvProblems;
        private System.Windows.Forms.Button btnAddLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDateLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogout;
    }
}