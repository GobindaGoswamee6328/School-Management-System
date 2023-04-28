namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewResult = new System.Windows.Forms.Button();
            this.btnEnrollCourses = new System.Windows.Forms.Button();
            this.btnViewAttendence = new System.Windows.Forms.Button();
            this.btnViewNotice = new System.Windows.Forms.Button();
            this.btnViewPolicy = new System.Windows.Forms.Button();
            this.btninformation = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 499);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(243, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 499);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(115)))));
            this.panel2.Controls.Add(this.btnViewResult);
            this.panel2.Controls.Add(this.btnEnrollCourses);
            this.panel2.Controls.Add(this.btnViewAttendence);
            this.panel2.Controls.Add(this.btnViewNotice);
            this.panel2.Controls.Add(this.btnViewPolicy);
            this.panel2.Controls.Add(this.btninformation);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 499);
            this.panel2.TabIndex = 0;
            // 
            // btnViewResult
            // 
            this.btnViewResult.BackColor = System.Drawing.Color.Purple;
            this.btnViewResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewResult.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnViewResult.Image = ((System.Drawing.Image)(resources.GetObject("btnViewResult.Image")));
            this.btnViewResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewResult.Location = new System.Drawing.Point(12, 269);
            this.btnViewResult.Name = "btnViewResult";
            this.btnViewResult.Size = new System.Drawing.Size(201, 51);
            this.btnViewResult.TabIndex = 8;
            this.btnViewResult.Text = "         View Result";
            this.btnViewResult.UseVisualStyleBackColor = false;
            this.btnViewResult.Click += new System.EventHandler(this.btnViewResult_Click);
            // 
            // btnEnrollCourses
            // 
            this.btnEnrollCourses.BackColor = System.Drawing.Color.Purple;
            this.btnEnrollCourses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnrollCourses.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrollCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnrollCourses.Image = ((System.Drawing.Image)(resources.GetObject("btnEnrollCourses.Image")));
            this.btnEnrollCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnrollCourses.Location = new System.Drawing.Point(12, 212);
            this.btnEnrollCourses.Name = "btnEnrollCourses";
            this.btnEnrollCourses.Size = new System.Drawing.Size(201, 51);
            this.btnEnrollCourses.TabIndex = 7;
            this.btnEnrollCourses.Text = "          Enroll Courses";
            this.btnEnrollCourses.UseVisualStyleBackColor = false;
            this.btnEnrollCourses.Click += new System.EventHandler(this.btnEnrollCourses_Click);
            // 
            // btnViewAttendence
            // 
            this.btnViewAttendence.BackColor = System.Drawing.Color.Purple;
            this.btnViewAttendence.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewAttendence.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAttendence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnViewAttendence.Image = ((System.Drawing.Image)(resources.GetObject("btnViewAttendence.Image")));
            this.btnViewAttendence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAttendence.Location = new System.Drawing.Point(12, 155);
            this.btnViewAttendence.Name = "btnViewAttendence";
            this.btnViewAttendence.Size = new System.Drawing.Size(201, 51);
            this.btnViewAttendence.TabIndex = 6;
            this.btnViewAttendence.Text = "          View Attendence";
            this.btnViewAttendence.UseVisualStyleBackColor = false;
            this.btnViewAttendence.Click += new System.EventHandler(this.btnViewAttendence_Click);
            // 
            // btnViewNotice
            // 
            this.btnViewNotice.BackColor = System.Drawing.Color.Purple;
            this.btnViewNotice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewNotice.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnViewNotice.Image = ((System.Drawing.Image)(resources.GetObject("btnViewNotice.Image")));
            this.btnViewNotice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewNotice.Location = new System.Drawing.Point(12, 331);
            this.btnViewNotice.Name = "btnViewNotice";
            this.btnViewNotice.Size = new System.Drawing.Size(201, 51);
            this.btnViewNotice.TabIndex = 5;
            this.btnViewNotice.Text = "       View Notice";
            this.btnViewNotice.UseVisualStyleBackColor = false;
            this.btnViewNotice.Click += new System.EventHandler(this.btnViewNotice_Click);
            // 
            // btnViewPolicy
            // 
            this.btnViewPolicy.BackColor = System.Drawing.Color.Purple;
            this.btnViewPolicy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewPolicy.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPolicy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnViewPolicy.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPolicy.Image")));
            this.btnViewPolicy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPolicy.Location = new System.Drawing.Point(12, 388);
            this.btnViewPolicy.Name = "btnViewPolicy";
            this.btnViewPolicy.Size = new System.Drawing.Size(201, 51);
            this.btnViewPolicy.TabIndex = 4;
            this.btnViewPolicy.Text = "     View Policy";
            this.btnViewPolicy.UseVisualStyleBackColor = false;
            this.btnViewPolicy.Click += new System.EventHandler(this.button1_Click);
            // 
            // btninformation
            // 
            this.btninformation.BackColor = System.Drawing.Color.Purple;
            this.btninformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btninformation.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btninformation.Image = ((System.Drawing.Image)(resources.GetObject("btninformation.Image")));
            this.btninformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninformation.Location = new System.Drawing.Point(12, 98);
            this.btninformation.Name = "btninformation";
            this.btninformation.Size = new System.Drawing.Size(201, 51);
            this.btninformation.TabIndex = 3;
            this.btninformation.Text = "       Information";
            this.btninformation.UseVisualStyleBackColor = false;
            this.btninformation.Click += new System.EventHandler(this.btninformation_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(12, 445);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(201, 51);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Purple;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 41);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(201, 51);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 499);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Student Portal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btninformation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnViewPolicy;
        private System.Windows.Forms.Button btnViewNotice;
        private System.Windows.Forms.Button btnViewAttendence;
        private System.Windows.Forms.Button btnEnrollCourses;
        private System.Windows.Forms.Button btnViewResult;
    }
}

