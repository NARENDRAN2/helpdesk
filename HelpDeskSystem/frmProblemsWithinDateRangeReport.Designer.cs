namespace HelpDeskSystem
{
    partial class frmProblemsWithinDateRangeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProblemsWithinDateRangeReport));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dgvProblemsInRange = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnExcelWork = new System.Windows.Forms.Button();
            this.btnWordDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblemsInRange)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(75, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(511, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Date :";
            // 
            // dtStart
            // 
            this.dtStart.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtStart.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dtStart.Location = new System.Drawing.Point(217, 81);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 20);
            this.dtStart.TabIndex = 2;
            // 
            // dtEnd
            // 
            this.dtEnd.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtEnd.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dtEnd.Location = new System.Drawing.Point(625, 81);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 20);
            this.dtEnd.TabIndex = 3;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // dgvProblemsInRange
            // 
            this.dgvProblemsInRange.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProblemsInRange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProblemsInRange.Location = new System.Drawing.Point(64, 137);
            this.dgvProblemsInRange.Name = "dgvProblemsInRange";
            this.dgvProblemsInRange.Size = new System.Drawing.Size(789, 239);
            this.dgvProblemsInRange.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.Location = new System.Drawing.Point(778, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 27);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("BankGothic Md BT", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(297, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date Range Problems";
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.Location = new System.Drawing.Point(658, 391);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 27);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExcelWork
            // 
            this.btnExcelWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelWork.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnExcelWork.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnExcelWork.Location = new System.Drawing.Point(186, 391);
            this.btnExcelWork.Name = "btnExcelWork";
            this.btnExcelWork.Size = new System.Drawing.Size(88, 27);
            this.btnExcelWork.TabIndex = 9;
            this.btnExcelWork.Text = "As Excel";
            this.btnExcelWork.UseVisualStyleBackColor = true;
            this.btnExcelWork.Click += new System.EventHandler(this.btnExcelWork_Click);
            // 
            // btnWordDoc
            // 
            this.btnWordDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWordDoc.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnWordDoc.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnWordDoc.Location = new System.Drawing.Point(64, 391);
            this.btnWordDoc.Name = "btnWordDoc";
            this.btnWordDoc.Size = new System.Drawing.Size(88, 27);
            this.btnWordDoc.TabIndex = 8;
            this.btnWordDoc.Text = "As Word";
            this.btnWordDoc.UseVisualStyleBackColor = true;
            this.btnWordDoc.Click += new System.EventHandler(this.btnWordDoc_Click);
            // 
            // frmProblemsWithinDateRangeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(896, 426);
            this.Controls.Add(this.btnExcelWork);
            this.Controls.Add(this.btnWordDoc);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvProblemsInRange);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name = "frmProblemsWithinDateRangeReport";
            this.Text = "Problems Within Date Range Report";
            this.Load += new System.EventHandler(this.frmProblemsWithinDateRangeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblemsInRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DataGridView dgvProblemsInRange;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnExcelWork;
        private System.Windows.Forms.Button btnWordDoc;
    }
}