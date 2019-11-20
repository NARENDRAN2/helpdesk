namespace HelpDeskSystem
{
    partial class frmSpecificCategoryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpecificCategoryReport));
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSpecificCategory = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnExcelWork = new System.Windows.Forms.Button();
            this.btnWordDoc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecificCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Yellow;
            this.btnExit.Location = new System.Drawing.Point(644, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 27);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategory.Font = new System.Drawing.Font("Poor Richard", 12F);
            this.cmbCategory.ForeColor = System.Drawing.Color.Yellow;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(271, 59);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(199, 27);
            this.cmbCategory.TabIndex = 9;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(36, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Category : ";
            // 
            // dgvSpecificCategory
            // 
            this.dgvSpecificCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpecificCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecificCategory.GridColor = System.Drawing.Color.Gold;
            this.dgvSpecificCategory.Location = new System.Drawing.Point(39, 113);
            this.dgvSpecificCategory.Name = "dgvSpecificCategory";
            this.dgvSpecificCategory.Size = new System.Drawing.Size(693, 215);
            this.dgvSpecificCategory.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrint.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.Yellow;
            this.btnPrint.Location = new System.Drawing.Point(533, 343);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 27);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExcelWork
            // 
            this.btnExcelWork.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcelWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelWork.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnExcelWork.ForeColor = System.Drawing.Color.Yellow;
            this.btnExcelWork.Location = new System.Drawing.Point(150, 343);
            this.btnExcelWork.Name = "btnExcelWork";
            this.btnExcelWork.Size = new System.Drawing.Size(88, 27);
            this.btnExcelWork.TabIndex = 13;
            this.btnExcelWork.Text = "As Excel";
            this.btnExcelWork.UseVisualStyleBackColor = false;
            this.btnExcelWork.Click += new System.EventHandler(this.btnExcelWork_Click);
            // 
            // btnWordDoc
            // 
            this.btnWordDoc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWordDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWordDoc.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnWordDoc.ForeColor = System.Drawing.Color.Yellow;
            this.btnWordDoc.Location = new System.Drawing.Point(39, 343);
            this.btnWordDoc.Name = "btnWordDoc";
            this.btnWordDoc.Size = new System.Drawing.Size(88, 27);
            this.btnWordDoc.TabIndex = 12;
            this.btnWordDoc.Text = "As Word";
            this.btnWordDoc.UseVisualStyleBackColor = false;
            this.btnWordDoc.Click += new System.EventHandler(this.btnWordDoc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("BankGothic Md BT", 15F);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(190, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Problems For Specific Category";
            // 
            // frmSpecificCategoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExcelWork);
            this.Controls.Add(this.btnWordDoc);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSpecificCategory);
            this.Name = "frmSpecificCategoryReport";
            this.Text = "Specific Category Report";
            this.Load += new System.EventHandler(this.frmSpecificCategoryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecificCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSpecificCategory;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnExcelWork;
        private System.Windows.Forms.Button btnWordDoc;
        private System.Windows.Forms.Label label3;
    }
}