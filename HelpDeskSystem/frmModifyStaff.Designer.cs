namespace HelpDeskSystem
{
    partial class frmModifyStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifyStaff));
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStaffRole = new System.Windows.Forms.TextBox();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStaffUsername = new System.Windows.Forms.TextBox();
            this.lblClearFields = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvStaff.Location = new System.Drawing.Point(370, 76);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(499, 240);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Staff ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Surname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Staff Role :";
            // 
            // txtStaffID
            // 
            this.txtStaffID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtStaffID.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.txtStaffID.ForeColor = System.Drawing.Color.Lime;
            this.txtStaffID.Location = new System.Drawing.Point(181, 89);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(143, 24);
            this.txtStaffID.TabIndex = 8;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSurname.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.txtSurname.ForeColor = System.Drawing.Color.Lime;
            this.txtSurname.Location = new System.Drawing.Point(181, 145);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(143, 24);
            this.txtSurname.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFirstName.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.txtFirstName.ForeColor = System.Drawing.Color.Lime;
            this.txtFirstName.Location = new System.Drawing.Point(181, 201);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(143, 24);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtStaffRole
            // 
            this.txtStaffRole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtStaffRole.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.txtStaffRole.ForeColor = System.Drawing.Color.Lime;
            this.txtStaffRole.Location = new System.Drawing.Point(181, 247);
            this.txtStaffRole.Name = "txtStaffRole";
            this.txtStaffRole.Size = new System.Drawing.Size(143, 24);
            this.txtStaffRole.TabIndex = 11;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStaff.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAddStaff.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Location = new System.Drawing.Point(12, 369);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(145, 45);
            this.btnAddStaff.TabIndex = 12;
            this.btnAddStaff.Text = "Add New Staff";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStaff.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteStaff.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.btnDeleteStaff.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStaff.Location = new System.Drawing.Point(210, 369);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(174, 45);
            this.btnDeleteStaff.TabIndex = 13;
            this.btnDeleteStaff.Text = "Delete Selected Staff";
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("BankGothic Md BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(314, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Modify Staff";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnBack.Location = new System.Drawing.Point(779, 385);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 39);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Staff Username :";
            // 
            // txtStaffUsername
            // 
            this.txtStaffUsername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtStaffUsername.Font = new System.Drawing.Font("Poor Richard", 11.25F);
            this.txtStaffUsername.ForeColor = System.Drawing.Color.Lime;
            this.txtStaffUsername.Location = new System.Drawing.Point(181, 292);
            this.txtStaffUsername.Name = "txtStaffUsername";
            this.txtStaffUsername.Size = new System.Drawing.Size(143, 24);
            this.txtStaffUsername.TabIndex = 17;
            // 
            // lblClearFields
            // 
            this.lblClearFields.ActiveLinkColor = System.Drawing.Color.White;
            this.lblClearFields.AutoSize = true;
            this.lblClearFields.BackColor = System.Drawing.Color.Transparent;
            this.lblClearFields.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearFields.LinkColor = System.Drawing.Color.Lime;
            this.lblClearFields.Location = new System.Drawing.Point(566, 328);
            this.lblClearFields.Name = "lblClearFields";
            this.lblClearFields.Size = new System.Drawing.Size(124, 14);
            this.lblClearFields.TabIndex = 18;
            this.lblClearFields.TabStop = true;
            this.lblClearFields.Text = "Clear all fields";
            this.lblClearFields.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblClearFields_LinkClicked);
            // 
            // frmModifyStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(881, 436);
            this.Controls.Add(this.lblClearFields);
            this.Controls.Add(this.txtStaffUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.txtStaffRole);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvStaff);
            this.Name = "frmModifyStaff";
            this.Text = "Modify Staff";
            this.Load += new System.EventHandler(this.frmModifyStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStaffRole;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStaffUsername;
        private System.Windows.Forms.LinkLabel lblClearFields;
    }
}