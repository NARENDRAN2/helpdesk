namespace HelpDeskSystem
{
    partial class frmReOpenProblem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReOpenProblem));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReOpenProblems = new System.Windows.Forms.DataGridView();
            this.btnReOpen = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReOpenProblems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(290, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Re-Open Problems";
            // 
            // dgvReOpenProblems
            // 
            this.dgvReOpenProblems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReOpenProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReOpenProblems.Location = new System.Drawing.Point(29, 73);
            this.dgvReOpenProblems.Name = "dgvReOpenProblems";
            this.dgvReOpenProblems.Size = new System.Drawing.Size(729, 245);
            this.dgvReOpenProblems.TabIndex = 1;
            // 
            // btnReOpen
            // 
            this.btnReOpen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReOpen.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnReOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReOpen.Location = new System.Drawing.Point(330, 338);
            this.btnReOpen.Name = "btnReOpen";
            this.btnReOpen.Size = new System.Drawing.Size(133, 33);
            this.btnReOpen.TabIndex = 2;
            this.btnReOpen.Text = "Re-Open";
            this.btnReOpen.UseVisualStyleBackColor = false;
            this.btnReOpen.Click += new System.EventHandler(this.btnReOpen_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("BankGothic Md BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(703, 365);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 27);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmReOpenProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(787, 395);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReOpen);
            this.Controls.Add(this.dgvReOpenProblems);
            this.Controls.Add(this.label1);
            this.Name = "frmReOpenProblem";
            this.Text = "Re-Open Problem";
            this.Load += new System.EventHandler(this.frmReOpenProblem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReOpenProblems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReOpenProblems;
        private System.Windows.Forms.Button btnReOpen;
        private System.Windows.Forms.Button btnBack;
    }
}