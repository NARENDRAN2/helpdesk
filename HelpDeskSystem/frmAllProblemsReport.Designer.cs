namespace HelpDeskSystem
{
    partial class frmAllProblemsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllProblemsReport));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAllProblems = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnWordDoc = new System.Windows.Forms.Button();
            this.btnExcelWork = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProblems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 17F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(233, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Problems";
            // 
            // dgvAllProblems
            // 
            this.dgvAllProblems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProblems.Location = new System.Drawing.Point(24, 83);
            this.dgvAllProblems.Name = "dgvAllProblems";
            this.dgvAllProblems.Size = new System.Drawing.Size(613, 239);
            this.dgvAllProblems.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(562, 345);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Teal;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(456, 345);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(91, 27);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnWordDoc
            // 
            this.btnWordDoc.BackColor = System.Drawing.Color.Teal;
            this.btnWordDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWordDoc.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWordDoc.ForeColor = System.Drawing.Color.Black;
            this.btnWordDoc.Location = new System.Drawing.Point(24, 345);
            this.btnWordDoc.Name = "btnWordDoc";
            this.btnWordDoc.Size = new System.Drawing.Size(102, 27);
            this.btnWordDoc.TabIndex = 6;
            this.btnWordDoc.Text = "As Word Doc";
            this.btnWordDoc.UseVisualStyleBackColor = false;
            this.btnWordDoc.Click += new System.EventHandler(this.btnWordDoc_Click);
            // 
            // btnExcelWork
            // 
            this.btnExcelWork.BackColor = System.Drawing.Color.Teal;
            this.btnExcelWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelWork.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelWork.ForeColor = System.Drawing.Color.Black;
            this.btnExcelWork.Location = new System.Drawing.Point(132, 345);
            this.btnExcelWork.Name = "btnExcelWork";
            this.btnExcelWork.Size = new System.Drawing.Size(95, 27);
            this.btnExcelWork.TabIndex = 7;
            this.btnExcelWork.Text = "As Excel WB";
            this.btnExcelWork.UseVisualStyleBackColor = false;
            this.btnExcelWork.Click += new System.EventHandler(this.btnExcelWork_Click);
            // 
            // frmAllProblemsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(649, 411);
            this.Controls.Add(this.btnExcelWork);
            this.Controls.Add(this.btnWordDoc);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvAllProblems);
            this.Controls.Add(this.label1);
            this.Name = "frmAllProblemsReport";
            this.Text = "All Problems Report";
            this.Load += new System.EventHandler(this.frmAllProblemsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProblems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAllProblems;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnWordDoc;
        private System.Windows.Forms.Button btnExcelWork;
    }
}