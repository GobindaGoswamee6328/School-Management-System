using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPortalsln
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            AddUser user = new AddUser();
            user.TopLevel = false;
            panel3.Controls.Add(user);
            user.BringToFront();
            user.Show();

        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            RemoveUser rs = new RemoveUser();
            rs.TopLevel = false;
            panel3.Controls.Add(rs);
            rs.BringToFront();
            rs.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var d = MessageBox.Show("Are you sure to logout this panel ?","Warning",MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            UpdateSalary us = new UpdateSalary();
            us.TopLevel = false;
            panel3.Controls.Add(us);
            us.BringToFront();
            us.Show();
        }

        private void btnUpdateGrade_Click(object sender, EventArgs e)
        {
            UpdateGrade ug = new UpdateGrade();
            ug.TopLevel= false;
            panel3.Controls.Add(ug);
            ug.BringToFront();
            ug.Show();
        }

        private void btnMonitorRecords_Click(object sender, EventArgs e)
        {
            MonitorRecord mr = new MonitorRecord();
            mr.TopLevel = false;
            panel3.Controls.Add(mr);
            mr.BringToFront();
            mr.Show();
        }

        private void btnUpdateUserInfo_Click(object sender, EventArgs e)
        {
            UpdateUserInfo usi = new UpdateUserInfo();
            usi.TopLevel = false;
            panel3.Controls.Add(usi);
            usi.BringToFront();
            usi.Show();
        }

        private void btnNoticeAndPolicy_Click(object sender, EventArgs e)
        {
            NoticeAndPolicy np = new NoticeAndPolicy();
            np.TopLevel = false;
            panel3.Controls.Add(np);
            np.BringToFront();
            np.Show();
        }
    }
}
