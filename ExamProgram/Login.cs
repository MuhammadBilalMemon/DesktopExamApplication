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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection _conn = ClassSqlConnection.Connection();
        //FormWindowState frmstate = new FormWindowState();
        
        private void Refresh()
        {
            txtUserName.Text = "";
            txtUserPassword.Text = "";
            lblUserNameStatus.Text = "";
            lblUserPasswordStatus.Text = "";
        }

        private void btnCencal_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                lblUserNameStatus.Visible = true;
                lblUserNameStatus.Text = "Enter Your UserName";
            }
            else
            {
                lblUserNameStatus.Visible = false;
            }
        }

        private void txtUserPassword_Leave(object sender, EventArgs e)
        {
            if (txtUserPassword.Text == "")
            {
                lblUserPasswordStatus.Visible = true;
                lblUserPasswordStatus.Text = "Enter Your Password";
            }
            else
            {
                lblUserPasswordStatus.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Query = "Select * From Userinformation Where UserName = '@UserName' and UserPassword = '@UserPassword'";
            Query = Query.Replace("@UserName", txtUserName.Text);
            //Query = Query.Replace("@UserPassword",txtUserPassword.Text);
            Query = Query.Replace("@UserPassword", MyUtility.PasswordReverse(txtUserPassword.Text));
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(Query, _conn);
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                String UserType = "";
                if (dt.Rows[0]["UserTypeID"].ToString() == "1")
                {
                    UserType = "Administrator";
                }
                else if (dt.Rows[0]["UserTypeID"].ToString() == "2")
                {
                    UserType = "Student";
                }
                FrmMain Main = new FrmMain();
                UserInformation.UserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                UserInformation.UserName = dt.Rows[0]["UserName"].ToString();
                UserInformation.UserLastName = dt.Rows[0]["LastName"].ToString();
                UserInformation.UserEmail = dt.Rows[0]["Email"].ToString();
                Main.UserType = UserType.ToString();
                Main.UserTypeID = Convert.ToInt32(dt.Rows[0]["UserTypeID"]);
                Main.UserName = dt.Rows[0]["FristName"] + " " + dt.Rows[0]["LastName"].ToString();
                Main.ShowDialog();
                this.Close();
                //this.Hide();
                //Visible = false;
                Refresh();
            }
            else
            {
                MessageBox.Show("User not found! Please try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
