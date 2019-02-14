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
    public partial class frmAddQuestion : Form
    {
        SqlConnection _conn = ClassSqlConnection.Connection();
        public frmAddQuestion()
        {
            InitializeComponent();
        }
        public int QuestionID { set; get; }

        DataTable dtCourse = new DataTable();
        DataTable dtQuestion = new DataTable();

        void GetCourseData()
        {
            dtCourse = DBHandler.GetTableDataSimple("Proc_CourseDataWithID", CommandType.StoredProcedure);
            DataRow defaulRow = dtCourse.NewRow();
            //defaulRow["CourseName"] = "Select";
            //defaulRow["CourseID"] = 0;
            //dtCourse.Rows.InsertAt(defaulRow, 0);
            cmbCourseName.DisplayMember = "CourseName";
            cmbCourseName.ValueMember = "CourseID";
            cmbCourseName.DataSource = dtCourse;
        }

        void InsertQuestion()
        {
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Question", txtQuestion.Text);
            Param[1] = new SqlParameter("@CourseID", cmbCourseName.SelectedValue);//CourseID will Come Here
            DBHandler.InsertData("Proc_InsertQuestion", CommandType.StoredProcedure, Param);
        }

        void LoadQuestion()
        {
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@CourseID", cmbCourseName.SelectedValue);
            dtQuestion = DBHandler.GetTableData("Proc_GetQuestionWithCurseID", CommandType.StoredProcedure, Param);
            dgvSeeQuestion.DataSource = dtQuestion;
        }

        void UpdateQuestion()
        {
            //Proc_UpdateQuestion
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Question", txtQuestion.Text);
            Param[1] = new SqlParameter("@QuestionID", QuestionID);
            DBHandler.InsertData("Proc_UpdateQuestion", CommandType.StoredProcedure, Param);
        }

        private void frmAddQuestion_Load(object sender, EventArgs e)
        {
            GetCourseData();
        }

        void refresh()
        {
            GetCourseData();
            txtQuestion.Text = "";
            dgvSeeQuestion.Refresh();
            cmbCourseName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            refresh();
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    DataGridViewSelectedRowCollection dgvc = dgvSeeQuestion.SelectedRows;
        //    if (dgvc.Count > 0)
        //    {
        //        FrmAddAnswer _frm = new FrmAddAnswer();
        //        _frm.Question = dgvSeeQuestion.CurrentRow.Cells["dgvQuestion"].Value.ToString();
        //        _frm.QuestionID = QuestionID;
        //        _frm.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select the Question from grid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text != string.Empty || cmbCourseName.SelectedText == "Select")
            {
                if (QuestionID == 0)
                {
                    InsertQuestion();
                    MessageBox.Show("New Record Inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadQuestion();
                    txtQuestion.Clear();
                }
                else
                {
                    UpdateQuestion();
                    MessageBox.Show("New Record Update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadQuestion();
                    txtQuestion.Clear();
                }
            }
            else
            {
                MessageBox.Show("Enter Question", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadQuestion();
        }

        private void dgvSeeQuestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dg = (DataGridView)sender;
            DataGridView dg = sender as DataGridView;
            if (dg.CurrentRow != null)
            {
                txtQuestion.Text = dgvSeeQuestion.CurrentRow.Cells["dgvQuestion"].Value.ToString();
                QuestionID = Convert.ToInt32(dgvSeeQuestion.CurrentRow.Cells["dgvQuestionID"].Value.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
