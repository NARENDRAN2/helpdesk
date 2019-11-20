namespace HelpDeskSystem
{
    partial class frmSpecificMachineIDReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpecificMachineIDReport));
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSpecificMachine = new System.Windows.Forms.DataGridView();
            this.txtMachineID = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnExcelWork = new System.Windows.Forms.Button();
            this.btnWordDoc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecificMachine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.DeepPink;
            this.btnExit.Location = new System.Drawing.Point(604, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 27);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepPink;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Machine ID :";
            // 
            // dgvSpecificMachine
            // 
            this.dgvSpecificMachine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpecificMachine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecificMachine.Location = new System.Drawing.Point(25, 109);
            this.dgvSpecificMachine.Name = "dgvSpecificMachine";
            this.dgvSpecificMachine.Size = new System.Drawing.Size(654, 207);
            this.dgvSpecificMachine.TabIndex = 7;
            // 
            // txtMachineID
            // 
            this.txtMachineID.Font = new System.Drawing.Font("Poor Richard", 12F);
            this.txtMachineID.Location = new System.Drawing.Point(222, 61);
            this.txtMachineID.Name = "txtMachineID";
            this.txtMachineID.Size = new System.Drawing.Size(197, 26);
            this.txtMachineID.TabIndex = 10;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Black;
            this.btnView.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnView.ForeColor = System.Drawing.Color.DeepPink;
            this.btnView.Location = new System.Drawing.Point(478, 62);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(134, 27);
            this.btnView.TabIndex = 11;
            this.btnView.Text = "View Problems";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.DeepPink;
            this.btnPrint.Location = new System.Drawing.Point(496, 339);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 27);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // btnExcelWork
            // 
            this.btnExcelWork.BackColor = System.Drawing.Color.Black;
            this.btnExcelWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelWork.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnExcelWork.ForeColor = System.Drawing.Color.DeepPink;
            this.btnExcelWork.Location = new System.Drawing.Point(119, 339);
            this.btnExcelWork.Name = "btnExcelWork";
            this.btnExcelWork.Size = new System.Drawing.Size(88, 27);
            this.btnExcelWork.TabIndex = 14;
            this.btnExcelWork.Text = "As Excel";
            this.btnExcelWork.UseVisualStyleBackColor = false;
            this.btnExcelWork.Click += new System.EventHandler(this.btnExcelWork_Click);
            // 
            // btnWordDoc
            // 
            this.btnWordDoc.BackColor = System.Drawing.Color.Black;
            this.btnWordDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWordDoc.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnWordDoc.ForeColor = System.Drawing.Color.DeepPink;
            this.btnWordDoc.Location = new System.Drawing.Point(25, 339);
            this.btnWordDoc.Name = "btnWordDoc";
            this.btnWordDoc.Size = new System.Drawing.Size(88, 27);
            this.btnWordDoc.TabIndex = 13;
            this.btnWordDoc.Text = "As Word";
            this.btnWordDoc.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(141, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Problems For Specific MachineID";
            // 
            // frmSpecificMachineIDReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(705, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcelWork);
            this.Controls.Add(this.btnWordDoc);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtMachineID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSpecificMachine);
            this.Name = "frmSpecificMachineIDReport";
            this.Text = "Specific Machine ID Report";
            this.Load += new System.EventHandler(this.frmSpecificMachineIDReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecificMachine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSpecificMachine;
        private System.Windows.Forms.TextBox txtMachineID;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnExcelWork;
        private System.Windows.Forms.Button btnWordDoc;
        private System.Windows.Forms.Label label2;
    }
}