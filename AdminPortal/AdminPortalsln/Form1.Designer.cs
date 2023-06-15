namespace AdminPortalsln
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnadduser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnUpdateSalary = new System.Windows.Forms.Button();
            this.btnUpdateGrade = new System.Windows.Forms.Button();
            this.btnMonitorRecords = new System.Windows.Forms.Button();
            this.btnNoticeAndPolicy = new System.Windows.Forms.Button();
            this.btnUpdateUserInfo = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 623);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnUpdateUserInfo);
            this.panel2.Controls.Add(this.btnNoticeAndPolicy);
            this.panel2.Controls.Add(this.btnMonitorRecords);
            this.panel2.Controls.Add(this.btnUpdateGrade);
            this.panel2.Controls.Add(this.btnUpdateSalary);
            this.panel2.Controls.Add(this.btnRemoveUser);
            this.panel2.Controls.Add(this.btnadduser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 623);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(233, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 623);
            this.panel3.TabIndex = 1;
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.Peru;
            this.btnadduser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadduser.Location = new System.Drawing.Point(21, 32);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(175, 51);
            this.btnadduser.TabIndex = 0;
            this.btnadduser.Text = "Add User";
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.Color.Peru;
            this.btnRemoveUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.Location = new System.Drawing.Point(21, 104);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(175, 51);
            this.btnRemoveUser.TabIndex = 1;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnUpdateSalary
            // 
            this.btnUpdateSalary.BackColor = System.Drawing.Color.Peru;
            this.btnUpdateSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSalary.Location = new System.Drawing.Point(21, 176);
            this.btnUpdateSalary.Name = "btnUpdateSalary";
            this.btnUpdateSalary.Size = new System.Drawing.Size(175, 51);
            this.btnUpdateSalary.TabIndex = 2;
            this.btnUpdateSalary.Text = "Update Salary";
            this.btnUpdateSalary.UseVisualStyleBackColor = false;
            this.btnUpdateSalary.Click += new System.EventHandler(this.btnUpdateSalary_Click);
            // 
            // btnUpdateGrade
            // 
            this.btnUpdateGrade.BackColor = System.Drawing.Color.Peru;
            this.btnUpdateGrade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGrade.Location = new System.Drawing.Point(21, 248);
            this.btnUpdateGrade.Name = "btnUpdateGrade";
            this.btnUpdateGrade.Size = new System.Drawing.Size(175, 51);
            this.btnUpdateGrade.TabIndex = 3;
            this.btnUpdateGrade.Text = "Update Grade";
            this.btnUpdateGrade.UseVisualStyleBackColor = false;
            this.btnUpdateGrade.Click += new System.EventHandler(this.btnUpdateGrade_Click);
            // 
            // btnMonitorRecords
            // 
            this.btnMonitorRecords.BackColor = System.Drawing.Color.Peru;
            this.btnMonitorRecords.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitorRecords.Location = new System.Drawing.Point(21, 320);
            this.btnMonitorRecords.Name = "btnMonitorRecords";
            this.btnMonitorRecords.Size = new System.Drawing.Size(175, 51);
            this.btnMonitorRecords.TabIndex = 4;
            this.btnMonitorRecords.Text = "Monitor Records";
            this.btnMonitorRecords.UseVisualStyleBackColor = false;
            this.btnMonitorRecords.Click += new System.EventHandler(this.btnMonitorRecords_Click);
            // 
            // btnNoticeAndPolicy
            // 
            this.btnNoticeAndPolicy.BackColor = System.Drawing.Color.Peru;
            this.btnNoticeAndPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoticeAndPolicy.Location = new System.Drawing.Point(21, 392);
            this.btnNoticeAndPolicy.Name = "btnNoticeAndPolicy";
            this.btnNoticeAndPolicy.Size = new System.Drawing.Size(175, 51);
            this.btnNoticeAndPolicy.TabIndex = 5;
            this.btnNoticeAndPolicy.Text = "Notice and Policy";
            this.btnNoticeAndPolicy.UseVisualStyleBackColor = false;
            this.btnNoticeAndPolicy.Click += new System.EventHandler(this.btnNoticeAndPolicy_Click);
            // 
            // btnUpdateUserInfo
            // 
            this.btnUpdateUserInfo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdateUserInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUserInfo.Location = new System.Drawing.Point(21, 464);
            this.btnUpdateUserInfo.Name = "btnUpdateUserInfo";
            this.btnUpdateUserInfo.Size = new System.Drawing.Size(175, 51);
            this.btnUpdateUserInfo.TabIndex = 6;
            this.btnUpdateUserInfo.Text = "Update User Info";
            this.btnUpdateUserInfo.UseVisualStyleBackColor = false;
            this.btnUpdateUserInfo.Click += new System.EventHandler(this.btnUpdateUserInfo_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(21, 536);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(175, 51);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 623);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Admin Portal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpdateUserInfo;
        private System.Windows.Forms.Button btnNoticeAndPolicy;
        private System.Windows.Forms.Button btnMonitorRecords;
        private System.Windows.Forms.Button btnUpdateGrade;
        private System.Windows.Forms.Button btnUpdateSalary;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnadduser;
    }
}

