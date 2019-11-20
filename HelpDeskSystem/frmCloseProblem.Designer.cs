namespace HelpDeskSystem
{
    partial class frmCloseProblem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCloseProblem));
            this.dgvSolvedProblems = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseSelectedProblem = new System.Windows.Forms.Button();
            this.btnCloseAllProblems = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolvedProblems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSolvedProblems
            // 
            this.dgvSolvedProblems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolvedProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolvedProblems.Location = new System.Drawing.Point(23, 103);
            this.dgvSolvedProblems.Name = "dgvSolvedProblems";
            this.dgvSolvedProblems.Size = new System.Drawing.Size(766, 219);
            this.dgvSolvedProblems.TabIndex = 0;
            this.dgvSolvedProblems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolvedProblems_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 15F);
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(304, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Close a problem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "SOLVED PROBLEMS :";
            // 
            // btnCloseSelectedProblem
            // 
            this.btnCloseSelectedProblem.BackColor = System.Drawing.Color.Turquoise;
            this.btnCloseSelectedProblem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseSelectedProblem.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.btnCloseSelectedProblem.ForeColor = System.Drawing.Color.Black;
            this.btnCloseSelectedProblem.Location = new System.Drawing.Point(64, 347);
            this.btnCloseSelectedProblem.Name = "btnCloseSelectedProblem";
            this.btnCloseSelectedProblem.Size = new System.Drawing.Size(185, 45);
            this.btnCloseSelectedProblem.TabIndex = 8;
            this.btnCloseSelectedProblem.Text = "CLOSE SELECTED PROBLEM";
            this.btnCloseSelectedProblem.UseVisualStyleBackColor = false;
            this.btnCloseSelectedProblem.Click += new System.EventHandler(this.btnCloseSelectedProblem_Click);
            // 
            // btnCloseAllProblems
            // 
            this.btnCloseAllProblems.BackColor = System.Drawing.Color.Turquoise;
            this.btnCloseAllProblems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseAllProblems.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.btnCloseAllProblems.ForeColor = System.Drawing.Color.Black;
            this.btnCloseAllProblems.Location = new System.Drawing.Point(386, 347);
            this.btnCloseAllProblems.Name = "btnCloseAllProblems";
            this.btnCloseAllProblems.Size = new System.Drawing.Size(145, 45);
            this.btnCloseAllProblems.TabIndex = 9;
            this.btnCloseAllProblems.Text = "CLOSE ALL PROBLEMS";
            this.btnCloseAllProblems.UseVisualStyleBackColor = false;
            this.btnCloseAllProblems.Click += new System.EventHandler(this.btnCloseAllProblems_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Turquoise;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(716, 382);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 27);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmCloseProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(828, 421);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCloseAllProblems);
            this.Controls.Add(this.btnCloseSelectedProblem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSolvedProblems);
            this.Name = "frmCloseProblem";
            this.Text = "Close a problem";
            this.Load += new System.EventHandler(this.frmCloseProblem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolvedProblems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolvedProblems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseSelectedProblem;
        private System.Windows.Forms.Button btnCloseAllProblems;
        private System.Windows.Forms.Button btnBack;
    }
}