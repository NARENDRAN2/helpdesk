namespace HelpDeskSystem
{
    partial class frmAdminAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminAuth));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allocateStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProblemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allProblemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProblemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waitingProblemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solvedProblemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLOSEDPROBLEMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highProirityProblemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problemsWithinDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specificStaffMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specificMachineIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specificCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problemLogReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problemLogForSpecificProblemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvOpenProblems = new System.Windows.Forms.DataGridView();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.txtProblemID = new System.Windows.Forms.TextBox();
            this.txtAllocateDate = new System.Windows.Forms.TextBox();
            this.txtProblem = new System.Windows.Forms.RichTextBox();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.reOpenProblemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalateProblemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenProblems)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("BankGothic Md BT", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allocateStaffToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.problemLogReportsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1164, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allocateStaffToolStripMenuItem
            // 
            this.allocateStaffToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.allocateStaffToolStripMenuItem.Enabled = false;
            this.allocateStaffToolStripMenuItem.Name = "allocateStaffToolStripMenuItem";
            this.allocateStaffToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.allocateStaffToolStripMenuItem.Text = "Allocate Staff";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.problemToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.categoryToolStripMenuItem});
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.modifyToolStripMenuItem.Text = "Modify ";
            // 
            // problemToolStripMenuItem
            // 
            this.problemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeProblemToolStripMenuItem,
            this.closeProblemToolStripMenuItem1,
            this.reOpenProblemsToolStripMenuItem,
            this.escalateProblemsToolStripMenuItem});
            this.problemToolStripMenuItem.Name = "problemToolStripMenuItem";
            this.problemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.problemToolStripMenuItem.Text = "Problem";
            // 
            // closeProblemToolStripMenuItem
            // 
            this.closeProblemToolStripMenuItem.Name = "closeProblemToolStripMenuItem";
            this.closeProblemToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.closeProblemToolStripMenuItem.Text = "transfer problem";
            this.closeProblemToolStripMenuItem.Click += new System.EventHandler(this.closeProblemToolStripMenuItem_Click);
            // 
            // closeProblemToolStripMenuItem1
            // 
            this.closeProblemToolStripMenuItem1.Name = "closeProblemToolStripMenuItem1";
            this.closeProblemToolStripMenuItem1.Size = new System.Drawing.Size(226, 22);
            this.closeProblemToolStripMenuItem1.Text = "Close problem";
            this.closeProblemToolStripMenuItem1.Click += new System.EventHandler(this.closeProblemToolStripMenuItem1_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.ToolTipText = "Add or Delete Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.ToolTipText = "Add or Delete Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allProblemsToolStripMenuItem,
            this.openProblemsToolStripMenuItem,
            this.waitingProblemsToolStripMenuItem,
            this.solvedProblemsToolStripMenuItem,
            this.cLOSEDPROBLEMSToolStripMenuItem,
            this.highProirityProblemsToolStripMenuItem,
            this.problemsWithinDateRangeToolStripMenuItem,
            this.specificStaffMemberToolStripMenuItem,
            this.specificMachineIDToolStripMenuItem,
            this.specificCategoryToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.reportsToolStripMenuItem.Text = "Problem Reports";
            // 
            // allProblemsToolStripMenuItem
            // 
            this.allProblemsToolStripMenuItem.Name = "allProblemsToolStripMenuItem";
            this.allProblemsToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.allProblemsToolStripMenuItem.Text = "all problems";
            this.allProblemsToolStripMenuItem.Click += new System.EventHandler(this.allProblemsToolStripMenuItem_Click);
            // 
            // openProblemsToolStripMenuItem
            // 
            this.openProblemsToolStripMenuItem.Name = "openProblemsToolStripMenuItem";
            this.openProblemsToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.openProblemsToolStripMenuItem.Text = "open problems";
            this.openProblemsToolStripMenuItem.Click += new System.EventHandler(this.openProblemsToolStripMenuItem_Click);
            // 
            // waitingProblemsToolStripMenuItem
            // 
            this.waitingProblemsToolStripMenuItem.Name = "waitingProblemsToolStripMenuItem";
            this.waitingProblemsToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.waitingProblemsToolStripMenuItem.Text = "waiting problems";
            this.waitingProblemsToolStripMenuItem.Click += new System.EventHandler(this.waitingProblemsToolStripMenuItem_Click);
            // 
            // solvedProblemsToolStripMenuItem
            // 
            this.solvedProblemsToolStripMenuItem.Name = "solvedProblemsToolStripMenuItem";
            this.solvedProblemsToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.solvedProblemsToolStripMenuItem.Text = "Solved Problems";
            this.solvedProblemsToolStripMenuItem.Click += new System.EventHandler(this.solvedProblemsToolStripMenuItem_Click);
            // 
            // cLOSEDPROBLEMSToolStripMenuItem
            // 
            this.cLOSEDPROBLEMSToolStripMenuItem.Name = "cLOSEDPROBLEMSToolStripMenuItem";
            this.cLOSEDPROBLEMSToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.cLOSEDPROBLEMSToolStripMenuItem.Text = "Closed Problems";
            this.cLOSEDPROBLEMSToolStripMenuItem.Click += new System.EventHandler(this.cLOSEDPROBLEMSToolStripMenuItem_Click);
            // 
            // highProirityProblemsToolStripMenuItem
            // 
            this.highProirityProblemsToolStripMenuItem.Name = "highProirityProblemsToolStripMenuItem";
            this.highProirityProblemsToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.highProirityProblemsToolStripMenuItem.Text = "High Priority Problems";
            this.highProirityProblemsToolStripMenuItem.Click += new System.EventHandler(this.highProirityProblemsToolStripMenuItem_Click);
            // 
            // problemsWithinDateRangeToolStripMenuItem
            // 
            this.problemsWithinDateRangeToolStripMenuItem.Name = "problemsWithinDateRangeToolStripMenuItem";
            this.problemsWithinDateRangeToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.problemsWithinDateRangeToolStripMenuItem.Text = "Problems within date range";
            this.problemsWithinDateRangeToolStripMenuItem.Click += new System.EventHandler(this.problemsWithinDateRangeToolStripMenuItem_Click);
            // 
            // specificStaffMemberToolStripMenuItem
            // 
            this.specificStaffMemberToolStripMenuItem.Name = "specificStaffMemberToolStripMenuItem";
            this.specificStaffMemberToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.specificStaffMemberToolStripMenuItem.Text = "For Specific Staff Member";
            this.specificStaffMemberToolStripMenuItem.Click += new System.EventHandler(this.specificStaffMemberToolStripMenuItem_Click);
            // 
            // specificMachineIDToolStripMenuItem
            // 
            this.specificMachineIDToolStripMenuItem.Name = "specificMachineIDToolStripMenuItem";
            this.specificMachineIDToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.specificMachineIDToolStripMenuItem.Text = "For Specific Machine ID";
            this.specificMachineIDToolStripMenuItem.Click += new System.EventHandler(this.specificMachineIDToolStripMenuItem_Click);
            // 
            // specificCategoryToolStripMenuItem
            // 
            this.specificCategoryToolStripMenuItem.Name = "specificCategoryToolStripMenuItem";
            this.specificCategoryToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.specificCategoryToolStripMenuItem.Text = "For Specific Category";
            this.specificCategoryToolStripMenuItem.Click += new System.EventHandler(this.specificCategoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // problemLogReportsToolStripMenuItem
            // 
            this.problemLogReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.problemLogForSpecificProblemToolStripMenuItem1});
            this.problemLogReportsToolStripMenuItem.Name = "problemLogReportsToolStripMenuItem";
            this.problemLogReportsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.problemLogReportsToolStripMenuItem.Text = "Problem Log Reports";
            // 
            // problemLogForSpecificProblemToolStripMenuItem1
            // 
            this.problemLogForSpecificProblemToolStripMenuItem1.Name = "problemLogForSpecificProblemToolStripMenuItem1";
            this.problemLogForSpecificProblemToolStripMenuItem1.Size = new System.Drawing.Size(347, 22);
            this.problemLogForSpecificProblemToolStripMenuItem1.Text = "Problem Log For Specific Problem";
            this.problemLogForSpecificProblemToolStripMenuItem1.Click += new System.EventHandler(this.problemLogForSpecificProblemToolStripMenuItem1_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(691, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Problem ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label3.Location = new System.Drawing.Point(23, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Problem :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label4.Location = new System.Drawing.Point(23, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Staff :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label5.Location = new System.Drawing.Point(23, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date :";
            // 
            // dgvOpenProblems
            // 
            this.dgvOpenProblems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOpenProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpenProblems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvOpenProblems.Location = new System.Drawing.Point(387, 100);
            this.dgvOpenProblems.Name = "dgvOpenProblems";
            this.dgvOpenProblems.Size = new System.Drawing.Size(749, 291);
            this.dgvOpenProblems.TabIndex = 6;
            this.dgvOpenProblems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOpenProblems_CellContentClick);
            // 
            // btnAllocate
            // 
            this.btnAllocate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAllocate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllocate.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.btnAllocate.Location = new System.Drawing.Point(673, 421);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(127, 33);
            this.btnAllocate.TabIndex = 7;
            this.btnAllocate.Text = "Allocate";
            this.btnAllocate.UseVisualStyleBackColor = false;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // txtProblemID
            // 
            this.txtProblemID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtProblemID.Enabled = false;
            this.txtProblemID.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.txtProblemID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProblemID.Location = new System.Drawing.Point(149, 106);
            this.txtProblemID.Name = "txtProblemID";
            this.txtProblemID.Size = new System.Drawing.Size(174, 24);
            this.txtProblemID.TabIndex = 8;
            // 
            // txtAllocateDate
            // 
            this.txtAllocateDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAllocateDate.Enabled = false;
            this.txtAllocateDate.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.txtAllocateDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAllocateDate.Location = new System.Drawing.Point(149, 445);
            this.txtAllocateDate.Name = "txtAllocateDate";
            this.txtAllocateDate.Size = new System.Drawing.Size(174, 24);
            this.txtAllocateDate.TabIndex = 9;
            // 
            // txtProblem
            // 
            this.txtProblem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtProblem.Enabled = false;
            this.txtProblem.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.txtProblem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProblem.Location = new System.Drawing.Point(149, 176);
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(174, 101);
            this.txtProblem.TabIndex = 10;
            this.txtProblem.Text = "";
            // 
            // cmbStaff
            // 
            this.cmbStaff.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbStaff.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.cmbStaff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(149, 309);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(174, 26);
            this.cmbStaff.TabIndex = 11;
            // 
            // reOpenProblemsToolStripMenuItem
            // 
            this.reOpenProblemsToolStripMenuItem.Name = "reOpenProblemsToolStripMenuItem";
            this.reOpenProblemsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.reOpenProblemsToolStripMenuItem.Text = "Re-Open Problems";
            this.reOpenProblemsToolStripMenuItem.Click += new System.EventHandler(this.reOpenProblemsToolStripMenuItem_Click);
            // 
            // escalateProblemsToolStripMenuItem
            // 
            this.escalateProblemsToolStripMenuItem.Name = "escalateProblemsToolStripMenuItem";
            this.escalateProblemsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.escalateProblemsToolStripMenuItem.Text = "Escalate Problems";
            this.escalateProblemsToolStripMenuItem.Click += new System.EventHandler(this.escalateProblemsToolStripMenuItem_Click);
            // 
            // frmAdminAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1164, 485);
            this.Controls.Add(this.cmbStaff);
            this.Controls.Add(this.txtProblem);
            this.Controls.Add(this.txtAllocateDate);
            this.Controls.Add(this.txtProblemID);
            this.Controls.Add(this.btnAllocate);
            this.Controls.Add(this.dgvOpenProblems);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdminAuth";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdminAuth_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenProblems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allocateStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProblemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvOpenProblems;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.TextBox txtProblemID;
        private System.Windows.Forms.TextBox txtAllocateDate;
        private System.Windows.Forms.RichTextBox txtProblem;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProblemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allProblemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProblemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waitingProblemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solvedProblemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLOSEDPROBLEMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highProirityProblemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problemsWithinDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specificStaffMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specificMachineIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specificCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problemLogReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problemLogForSpecificProblemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reOpenProblemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalateProblemsToolStripMenuItem;
    }
}