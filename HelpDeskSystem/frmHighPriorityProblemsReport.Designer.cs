namespace HelpDeskSystem
{
    partial class frmHighPriorityProblemsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHighPriorityProblemsReport));
            this.dgvHighPriProblems = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnExcelWork = new System.Windows.Forms.Button();
            this.btnWordDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighPriProblems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHighPriProblems
            // 
            this.dgvHighPriProblems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHighPriProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHighPriProblems.Location = new System.Drawing.Point(51, 73);
            this.dgvHighPriProblems.Name = "dgvHighPriProblems";
            this.dgvHighPriProblems.Size = new System.Drawing.Size(709, 253);
            this.dgvHighPriProblems.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 15F);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(269, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "High Priority Problems";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnExit.Location = new System.Drawing.Point(672, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 27);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnPrint.Location = new System.Drawing.Point(566, 344);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 27);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExcelWork
            // 
            this.btnExcelWork.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExcelWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelWork.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnExcelWork.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnExcelWork.Location = new System.Drawing.Point(164, 344);
            this.btnExcelWork.Name = "btnExcelWork";
            this.btnExcelWork.Size = new System.Drawing.Size(88, 27);
            this.btnExcelWork.TabIndex = 9;
            this.btnExcelWork.Text = "As Excel";
            this.btnExcelWork.UseVisualStyleBackColor = false;
            this.btnExcelWork.Click += new System.EventHandler(this.btnExcelWork_Click);
            // 
            // btnWordDoc
            // 
            this.btnWordDoc.BackColor = System.Drawing.Color.OrangeRed;
            this.btnWordDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWordDoc.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnWordDoc.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnWordDoc.Location = new System.Drawing.Point(51, 344);
            this.btnWordDoc.Name = "btnWordDoc";
            this.btnWordDoc.Size = new System.Drawing.Size(88, 27);
            this.btnWordDoc.TabIndex = 8;
            this.btnWordDoc.Text = "As Word";
            this.btnWordDoc.UseVisualStyleBackColor = false;
            // 
            // frmHighPriorityProblemsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(791, 379);
            this.Controls.Add(this.btnExcelWork);
            this.Controls.Add(this.btnWordDoc);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHighPriProblems);
            this.Name = "frmHighPriorityProblemsReport";
            this.Text = "High Priority Problems Report";
            this.Load += new System.EventHandler(this.frmHighPriorityProblemsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighPriProblems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHighPriProblems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnExcelWork;
        private System.Windows.Forms.Button btnWordDoc;
    }
}