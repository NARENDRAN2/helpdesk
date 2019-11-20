namespace HelpDeskSystem
{
    partial class frmLoggedSpecificProblemReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoggedSpecificProblemReport));
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbProblemID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSpecificProblem = new System.Windows.Forms.DataGridView();
            this.btnExcelWork = new System.Windows.Forms.Button();
            this.btnWordDoc = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecificProblem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SpringGreen;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Location = new System.Drawing.Point(590, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 27);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbProblemID
            // 
            this.cmbProblemID.BackColor = System.Drawing.Color.MidnightBlue;
            this.cmbProblemID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProblemID.Font = new System.Drawing.Font("Poor Richard", 12F);
            this.cmbProblemID.ForeColor = System.Drawing.Color.SpringGreen;
            this.cmbProblemID.FormattingEnabled = true;
            this.cmbProblemID.Location = new System.Drawing.Point(285, 68);
            this.cmbProblemID.Name = "cmbProblemID";
            this.cmbProblemID.Size = new System.Drawing.Size(199, 27);
            this.cmbProblemID.TabIndex = 9;
            this.cmbProblemID.SelectedIndexChanged += new System.EventHandler(this.cmbProblemID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SpringGreen;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(42, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Problem ID : ";
            // 
            // dgvSpecificProblem
            // 
            this.dgvSpecificProblem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpecificProblem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecificProblem.Location = new System.Drawing.Point(45, 133);
            this.dgvSpecificProblem.Name = "dgvSpecificProblem";
            this.dgvSpecificProblem.Size = new System.Drawing.Size(633, 191);
            this.dgvSpecificProblem.TabIndex = 7;
            // 
            // btnExcelWork
            // 
            this.btnExcelWork.BackColor = System.Drawing.Color.SpringGreen;
            this.btnExcelWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelWork.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnExcelWork.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExcelWork.Location = new System.Drawing.Point(147, 354);
            this.btnExcelWork.Name = "btnExcelWork";
            this.btnExcelWork.Size = new System.Drawing.Size(88, 27);
            this.btnExcelWork.TabIndex = 12;
            this.btnExcelWork.Text = "As Excel WB";
            this.btnExcelWork.UseVisualStyleBackColor = false;
            this.btnExcelWork.Click += new System.EventHandler(this.btnExcelWork_Click);
            // 
            // btnWordDoc
            // 
            this.btnWordDoc.BackColor = System.Drawing.Color.SpringGreen;
            this.btnWordDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWordDoc.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnWordDoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnWordDoc.Location = new System.Drawing.Point(39, 354);
            this.btnWordDoc.Name = "btnWordDoc";
            this.btnWordDoc.Size = new System.Drawing.Size(88, 27);
            this.btnWordDoc.TabIndex = 11;
            this.btnWordDoc.Text = "As Word Doc";
            this.btnWordDoc.UseVisualStyleBackColor = false;
            this.btnWordDoc.Click += new System.EventHandler(this.btnWordDoc_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SpringGreen;
            this.btnPrint.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPrint.Location = new System.Drawing.Point(490, 355);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 27);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SpringGreen;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 15F);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(125, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Logged Problems For Specific Problem";
            // 
            // frmLoggedSpecificProblemReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(709, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExcelWork);
            this.Controls.Add(this.btnWordDoc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbProblemID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSpecificProblem);
            this.Name = "frmLoggedSpecificProblemReport";
            this.Text = "Logged Specific Problem Report";
            this.Load += new System.EventHandler(this.frmLoggedSpecificProblemReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecificProblem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbProblemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSpecificProblem;
        private System.Windows.Forms.Button btnExcelWork;
        private System.Windows.Forms.Button btnWordDoc;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
    }
}