using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btninformation_Click(object sender, EventArgs e)
        {
            Student_Information si = new Student_Information();
            si.TopLevel= false;
            panel3.Controls.Add(si);
            si.BringToFront();
            si.Show();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowHome sh = new ShowHome();   
            sh.TopLevel= false;
            panel3.Controls.Add(sh);
            sh.BringToFront();
            sh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           ShowStudentPolicy ssp = new ShowStudentPolicy();
           ssp.TopLevel= false;
           panel3.Controls.Add(ssp);
           ssp.BringToFront();
           ssp.Show();
        }

        private void btnViewNotice_Click(object sender, EventArgs e)
        {
            ShowNoticeBoard snb = new ShowNoticeBoard();
            snb.TopLevel= false;
            panel3.Controls.Add(snb);
            snb.BringToFront();
            snb.Show();
        }

        private void btnViewAttendence_Click(object sender, EventArgs e)
        {
            ShowAttendence sa = new ShowAttendence();
            sa.TopLevel= false;
            panel3.Controls.Add(sa);
            sa.BringToFront();
            sa.Show();
        }

        private void btnEnrollCourses_Click(object sender, EventArgs e)
        {
            ShowEnrollCourses sec = new ShowEnrollCourses();
            sec.TopLevel= false;
            panel3.Controls.Add(sec);
            sec.BringToFront();
            sec.Show();
        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            ShowResult sr = new ShowResult();
            sr.TopLevel= false;
            panel3.Controls.Add(sr);
            sr.BringToFront();
            sr.Show();
        }
    }
}
