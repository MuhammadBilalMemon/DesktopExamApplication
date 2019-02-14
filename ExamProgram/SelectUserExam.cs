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
    public partial class SelectUserExam : Form
    {
        public SelectUserExam()
        {
            InitializeComponent();
        }
        DataTable dtStudent = new DataTable();
        DataTable dtCourse = new DataTable();
        string DateTime;
        string UserID = "0";
        string CourseID = "0";
        public void GetStudents()
        {
            dtStudent = DBHandler.GetTableDataSimple("Select UserID, UserName From Userinformation", CommandType.Text);
            //listBoxUserExam.DataSource = dtUser;
            listBoxUserExam.DisplayMember = "UserName";
            listBoxUserExam.ValueMember = "UserID";
            for (int i = 0; i < dtStudent.Rows.Count; i++)
            {
                listBoxUserExam.Items.Add(dtStudent.Rows[i]["UserName"]);
            }
        }
        public void GetCourse()
        {
            dtCourse = DBHandler.GetTableDataSimple("Select CourseID,CourseName From Course", CommandType.Text);
            listBoxCourse.ValueMember = "CourseName";
            listBoxSelectedCourse.DisplayMember = "CourseID";
            for (int i = 0; i < dtCourse.Rows.Count; i++)
            {
                listBoxCourse.Items.Add(dtCourse.Rows[i]["CourseName"]);
            }
        }
        public void Save()
        {
            for (int i = 0; i < ListBoxUserSelectedForExam.Items.Count; i++)
            {
                for (int o = 0; o < dtStudent.Rows.Count; o++)
                {
                    //string selectedname = ListBoxUserSelectedForExam.Items[i].ToString();
                    //string allname = dtStudent.Rows[o]["UserName"].ToString();
                    if (ListBoxUserSelectedForExam.Items[i].ToString() == dtStudent.Rows[o]["UserName"].ToString())
                    {
                        UserID = dtStudent.Rows[o]["UserID"].ToString();

                        for (int p = 0; p < listBoxSelectedCourse.Items.Count; p++)
                        {
                            for (int b = 0; b < dtCourse.Rows.Count; b++)
                            {
                                //string SelectedSubjects = listBoxSelectedCourse.Items[p].ToString();
                                //string Allsubject = dtCourse.Rows[b]["CourseName"].ToString();

                                if (listBoxSelectedCourse.Items[p].ToString() == dtCourse.Rows[b]["CourseName"].ToString())
                                {
                                    CourseID = dtCourse.Rows[b]["CourseID"].ToString();
                                    if (ListBoxUserSelectedForExam.Items.Count > 0 && listBoxSelectedCourse.Items.Count > 0)
                                    {
                                        DateTime = dateTimePiker.Value.ToString();
                                        SqlParameter[] Param = new SqlParameter[3];
                                        Param[0] = new SqlParameter("@UserID", UserID);
                                        Param[1] = new SqlParameter("@CourseID", CourseID);
                                        Param[2] = new SqlParameter("@ExamDateTime", DateTime);
                                        DBHandler.InsertData("Proc_UserExam", CommandType.StoredProcedure, Param);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Record Has Been Inserted", "Messege", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBoxCourse.Items.Clear();
            listBoxSelectedCourse.Items.Clear();
            listBoxUserExam.Items.Clear();
            ListBoxUserSelectedForExam.Items.Clear();
            GetStudents();
            GetCourse();
            dtCourse.Clear();
            dtStudent.Clear();
        }

        private void SelectUserExam_Load(object sender, EventArgs e)
        {
            GetStudents();
            GetCourse();
        }

        private void btnAddUsersForUser_Click(object sender, EventArgs e)
        {
            foreach (var items in listBoxUserExam.SelectedItems)
            {
                ListBoxUserSelectedForExam.Items.Add(items);
            }
            foreach (var items in ListBoxUserSelectedForExam.Items)
            {
                listBoxUserExam.Items.Remove(items);
            }
        }

        private void btnRemoveUsersForUser_Click(object sender, EventArgs e)
        {
            foreach (var items in ListBoxUserSelectedForExam.SelectedItems)
            {
                listBoxUserExam.Items.Add(items);
            }
            foreach (var items in listBoxUserExam.Items)
            {
                ListBoxUserSelectedForExam.Items.Remove(items);
            }

        }

        private void btnAddCourseForCourse_Click(object sender, EventArgs e)
        {
            foreach (var items in listBoxCourse.SelectedItems)
            {
                listBoxSelectedCourse.Items.Add(items);
            }
            foreach (var items in listBoxSelectedCourse.Items)
            {
                listBoxCourse.Items.Remove(items);
            }
        }

        private void btnCourseRemoveForCourse_Click(object sender, EventArgs e)
        {
            foreach (var items in listBoxSelectedCourse.SelectedItems)
            {
                listBoxCourse.Items.Add(items);
            }
            foreach (var items in listBoxCourse.Items)
            {
                listBoxSelectedCourse.Items.Remove(items);
            }
        }

        private void dateTimePiker_ValueChanged(object sender, EventArgs e)
        {
            DateTime = Convert.ToString(dateTimePiker.Value);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
//DBHandler.InsertData("", CommandType.StoredProcedure,, ClassSqlConnection.Connection());
//for (int i = 0; i < ListBoxUserSelectedForExam.Items.Count; i++)
//{
//    for (int o = 0; o < dtStudent.Rows.Count; o++)
//    {
//        string a = ListBoxUserSelectedForExam.Items[i].ToString();
//        string b = dtStudent.Rows[o][o].ToString();

//        int UserID = Convert.ToInt32(dtStudent.Rows[o][0].ToString());

//        for (int C = 0; C < listBoxSelectedCourse.Items.Count; C++)
//        {
//            for (int R = 0; R < dtCourse.Rows.Count; R++)
//            {
//                if (listBoxSelectedCourse.Items[C].ToString() == dtCourse.Rows[R][1].ToString())
//                {
//                    int CourseID = Convert.ToInt32(dtCourse.Rows[R][0].ToString());

//                    if (ListBoxUserSelectedForExam.Items.Count > 0 && listBoxSelectedCourse.Items.Count > 0)
//                    {
//                        DateTime = dateTimePiker.Value.ToString();
//                        UserID = Convert.ToInt32(dtStudent.Rows[o][0].ToString());
//                        CourseID = Convert.ToInt32(dtCourse.Rows[R][0].ToString());
//                    }
//                    else
//                    {
//                        listBoxCourse.Items.Clear();
//                        listBoxSelectedCourse.Items.Clear();
//                        listBoxUserExam.Items.Clear();
//                        ListBoxUserSelectedForExam.Items.Clear();
//                        GetStudents();
//                        GetCourse();
//                        dtStudent.Clear();
//                        dtCourse.Clear();
//                    }
//                }
//            }
//        }
//    }
//}