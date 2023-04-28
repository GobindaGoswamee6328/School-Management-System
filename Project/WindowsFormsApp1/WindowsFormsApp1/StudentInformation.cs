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
    public partial class Student_Information : Form
    {
        public Student_Information()
        {
            InitializeComponent();
        }

        private void btnShowUserInfo_Click(object sender, EventArgs e)
        {
            showUserInfo sui = new showUserInfo();
            sui.TopLevel= false; 
            pnlShowInfo.Controls.Add(sui);
            sui.BringToFront();
            sui.Show();
        }

        private void btnShowTeacherInfo_Click(object sender, EventArgs e)
        {
            showTeacherInfo sti = new showTeacherInfo();    
            sti.TopLevel= false;
            pnlShowInfo.Controls.Add(sti);
            sti.BringToFront();
            sti.Show();
        }

        private void btnShowStudentInfo_Click(object sender, EventArgs e)
        {
            showStudentInfo ssi = new showStudentInfo();   
            ssi.TopLevel= false;
            pnlShowInfo.Controls.Add(ssi);
            ssi.BringToFront();
            ssi.Show();
        }
    }
}
