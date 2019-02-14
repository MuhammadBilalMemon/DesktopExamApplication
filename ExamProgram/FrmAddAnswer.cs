using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamProgram
{
    public partial class FrmAddAnswer : Form
    {
        public FrmAddAnswer()
        {
            InitializeComponent();
        }

        public string Question { set; get; }
        public Int32 CourseID { set; get; }
        public Int32 QuestionID { set; get; }
        bool bit = false;

        DataTable dtCourse = new DataTable();
        DataTable dtQuestion = new DataTable();
        DataTable dtAnsOpt = new DataTable();
        void GetCourse()
        {
            dtCourse = DBHandler.GetTableDataSimple("Proc_CourseDataWithID", CommandType.StoredProcedure);
            DataRow defaulRow = dtCourse.NewRow();
            defaulRow["CourseName"] = "--- Select ---";
            defaulRow["CourseID"] = 0;
            dtCourse.Rows.InsertAt(defaulRow, 0);
            cmbCourseName.DisplayMember = "CourseName";
            cmbCourseName.ValueMember = "CourseID";
            cmbCourseName.DataSource = dtCourse;
        }
        void GetQuestion()
        {
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@CourseID", cmbCourseName.SelectedValue);
            dtQuestion = DBHandler.GetTableData("Proc_QuestionWithCourseID", CommandType.StoredProcedure, Param);
            cmdSelectQue.DisplayMember = "Question";
            cmdSelectQue.ValueMember = "QuestionID";
            cmdSelectQue.DataSource = dtQuestion;
        }
        void InertAnswer()
        {
            if (rdoTrue.Checked == true)
            {
                bit = true;
            }
            else if (rdoFalse.Checked == true)
            {
                bit = false;
            }
            SqlParameter[] Param = new SqlParameter[4];
            Param[0] = new SqlParameter("@AnswerName ", txtAnswer.Text.ToString());
            Param[1] = new SqlParameter("@isCorrect ", bit);
            Param[2] = new SqlParameter("@CourseID ", CourseID);
            Param[3] = new SqlParameter("@QuestionID ", QuestionID);
            DBHandler.InsertData("Proc_AddAnswer", CommandType.StoredProcedure, Param);
        }

        void GetAnswerOption(int Cid, int Qid)
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@CourseID", Cid);
            Param[1] = new SqlParameter("@QuestionID", Qid);
            dtAnsOpt = DBHandler.GetTableData("Proc_GetAnswerOptions", CommandType.StoredProcedure, Param);
            dgvAnswer.DataSource = dtAnsOpt;
        }

        private void FrmAddAnswer_Load(object sender, EventArgs e)
        {
            GetCourse();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (cmbCourseName.SelectedText == "--- Select ---")
            //{
            if (!(String.IsNullOrEmpty(txtAnswer.Text)))
            {
                if (rdoTrue.Checked != false || rdoFalse.Checked != false)
                {
                    InertAnswer();
                    MessageBox.Show("Enter Answer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAnswer.Clear();
                    rdoTrue.Checked = false;
                    rdoFalse.Checked = false;
                    GetAnswerOption(CourseID, QuestionID);
                    //GetCourse();
                    //GetQuestion();
                }
                else
                {
                    MessageBox.Show("Select Answers is Correct or Not", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter Answer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //}
            //else
            //{
            //    MessageBox.Show("Select Any Course frist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void cmbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetQuestion();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GetCourse();
            GetQuestion();
            GetAnswerOption(0,0);
            txtAnswer.Text = "";
            rdoFalse.Checked = false;
            rdoTrue.Checked = false;
        }

        private void cmdSelectQue_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuestionID = Convert.ToInt32(cmdSelectQue.SelectedValue);
            CourseID = Convert.ToInt32(cmbCourseName.SelectedValue);
            GetAnswerOption(CourseID, QuestionID);
        }
    }
}
