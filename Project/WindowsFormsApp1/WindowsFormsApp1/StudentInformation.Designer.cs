namespace WindowsFormsApp1
{
    partial class Student_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Information));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowUserInfo = new System.Windows.Forms.Button();
            this.btnShowTeacherInfo = new System.Windows.Forms.Button();
            this.btnShowStudentInfo = new System.Windows.Forms.Button();
            this.pnlShowInfo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.pnlShowInfo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 497);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnShowStudentInfo);
            this.panel2.Controls.Add(this.btnShowTeacherInfo);
            this.panel2.Controls.Add(this.btnShowUserInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 497);
            this.panel2.TabIndex = 0;
            // 
            // btnShowUserInfo
            // 
            this.btnShowUserInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnShowUserInfo.Image")));
            this.btnShowUserInfo.Location = new System.Drawing.Point(12, 12);
            this.btnShowUserInfo.Name = "btnShowUserInfo";
            this.btnShowUserInfo.Size = new System.Drawing.Size(161, 148);
            this.btnShowUserInfo.TabIndex = 0;
            this.btnShowUserInfo.Text = "User Info";
            this.btnShowUserInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowUserInfo.UseVisualStyleBackColor = true;
            this.btnShowUserInfo.Click += new System.EventHandler(this.btnShowUserInfo_Click);
            // 
            // btnShowTeacherInfo
            // 
            this.btnShowTeacherInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTeacherInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnShowTeacherInfo.Image")));
            this.btnShowTeacherInfo.Location = new System.Drawing.Point(12, 176);
            this.btnShowTeacherInfo.Name = "btnShowTeacherInfo";
            this.btnShowTeacherInfo.Size = new System.Drawing.Size(161, 148);
            this.btnShowTeacherInfo.TabIndex = 1;
            this.btnShowTeacherInfo.Text = "Teacher Info";
            this.btnShowTeacherInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowTeacherInfo.UseVisualStyleBackColor = true;
            this.btnShowTeacherInfo.Click += new System.EventHandler(this.btnShowTeacherInfo_Click);
            // 
            // btnShowStudentInfo
            // 
            this.btnShowStudentInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStudentInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnShowStudentInfo.Image")));
            this.btnShowStudentInfo.Location = new System.Drawing.Point(12, 337);
            this.btnShowStudentInfo.Name = "btnShowStudentInfo";
            this.btnShowStudentInfo.Size = new System.Drawing.Size(161, 148);
            this.btnShowStudentInfo.TabIndex = 2;
            this.btnShowStudentInfo.Text = "Student Info";
            this.btnShowStudentInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowStudentInfo.UseVisualStyleBackColor = true;
            this.btnShowStudentInfo.Click += new System.EventHandler(this.btnShowStudentInfo_Click);
            // 
            // pnlShowInfo
            // 
            this.pnlShowInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShowInfo.Location = new System.Drawing.Point(200, 0);
            this.pnlShowInfo.Name = "pnlShowInfo";
            this.pnlShowInfo.Size = new System.Drawing.Size(515, 497);
            this.pnlShowInfo.TabIndex = 1;
            // 
            // Student_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 497);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Student_Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnShowTeacherInfo;
        private System.Windows.Forms.Button btnShowUserInfo;
        private System.Windows.Forms.Button btnShowStudentInfo;
        private System.Windows.Forms.Panel pnlShowInfo;
    }
}