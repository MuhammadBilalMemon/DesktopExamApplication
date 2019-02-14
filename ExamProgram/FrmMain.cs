using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamProgram
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public string UserName { set; get; }
        public string UserType { set; get; }
        public int UserTypeID { set; get; }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserInformation frmUserinfo = new FrmUserInformation();
            frmUserinfo.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Welcome " + UserName + " [" + UserType + "]";
            if (UserTypeID == 1)
            {
                studentToolStripMenuItem.Visible = true;
                administratorToolStripMenuItem.Visible = true;
            }
            else if (UserTypeID == 2)
            {
                studentToolStripMenuItem.Visible = true;
                administratorToolStripMenuItem.Visible = false;
            }

        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddQuestion _FrmAddQuestion = new frmAddQuestion();
            _FrmAddQuestion.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAddAnswer _frmAddAnswer = new FrmAddAnswer();
            _frmAddAnswer.ShowDialog();
        }

        private void userExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectUserExam frm = new SelectUserExam();
            frm.ShowDialog();
        }
    }
}
