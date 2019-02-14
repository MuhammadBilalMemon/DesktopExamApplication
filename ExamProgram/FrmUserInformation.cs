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
    public partial class FrmUserInformation : Form
    {
        SqlConnection _conn = ClassSqlConnection.Connection();
        public FrmUserInformation()
        {
            InitializeComponent();
        }

        private void FrmUserInformation_Load(object sender, EventArgs e)
        {
            GetUserType();
            refresh();
        }

        void GetUserType()
        {
            DBHandler.GetTableDataSimple("Proc_GetUserType", CommandType.StoredProcedure);
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter("Proc_GetUserType", _conn);
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cmbUserType.DataSource = dt;
                cmbUserType.DisplayMember = "UserType";
                cmbUserType.ValueMember = "UserTypeID";
            }
        }

        void refresh()
        {
            txtFristName.Focus();
            txtFristName.Text = "FristName";
            txtLastName.Text = "LastName";
            txtUserName.Text = "UserName";
            txtPassword.Text = "Password";
            txtEmail.Text = "Example@abc.com";
            txtRollNo.Text = "RollNo";
            lblFristName.Text = "";
            lblLastName.Text = "";
            lblUserName.Text = "";
            lblPassword.Text = "";
            lblEmail.Text = "";
            lblFristName.Visible = false;
            lblLastName.Visible = false;
            lblEmail.Visible = false;
            lblUserName.Visible = false;
            lblPassword.Visible = false;
            lblRollNo.Visible = false;
            cmbUserType.SelectedValue = "0";
            GetUserType();
        }

        void AddUserInformation()
        {
            SqlParameter[] Param = new SqlParameter[7];
            Param[0] = new SqlParameter("@FristName", txtFristName.Text);
            Param[1] = new SqlParameter("@LastName", txtLastName.Text);
            Param[2] = new SqlParameter("@Email", txtEmail.Text);
            Param[3] = new SqlParameter("@UserName", txtUserName.Text);
            Param[4] = new SqlParameter("@UserPassword", MyUtility.PasswordReverse(txtPassword.Text));
            Param[5] = new SqlParameter("@RollNo", txtRollNo.Text);
            Param[6] = new SqlParameter("@UserTypeID", cmbUserType.SelectedValue);
            DBHandler.InsertData("Proc_Userinformation", CommandType.StoredProcedure, Param);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtFristName.Text == "FristName")
            {
                lblFristName.Text = "Enter FristName";
                lblFristName.Visible = true;
            }
            if (txtLastName.Text == "LastName")
            {
                lblLastName.Text = "Enter LastName";
                lblLastName.Visible = true;
            }
            if (txtEmail.Text == "Example@abc.com")
            {
                lblEmail.Text = "Enter Email";
                lblEmail.Visible = true;
            }
            if (txtUserName.Text == "UserName")
            {
                lblUserName.Text = "Enter UserName";
                lblUserName.Visible = true;
            }
            if (txtPassword.Text == "Password")
            {
                lblPassword.Text = "Enter Password";
                lblPassword.Visible = true;
            }
            if (txtRollNo.Text == "RollNo")
            {
                lblRollNo.Text = "Enter RollNo";
                lblRollNo.Visible = true;
            }
            else if ((txtFristName.Text != "FristName" && txtFristName.Text != string.Empty) && (txtLastName.Text != "LastName" && txtLastName.Text != string.Empty) && (txtEmail.Text != "Example@abc.com" && txtEmail.Text != string.Empty) && (txtUserName.Text != "UserName" && txtUserName.Text != string.Empty) && (txtPassword.Text != "Password" && txtPassword.Text != string.Empty) && (txtRollNo.Text != "Password" && txtRollNo.Text != string.Empty))
            {
                lblFristName.Visible = false;
                lblLastName.Visible = false;
                lblEmail.Visible = false;
                lblUserName.Visible = false;
                lblPassword.Visible = false;
                lblRollNo.Visible = false;

                AddUserInformation();
                MessageBox.Show("Your Record Has Been Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        private void txtFristName_Leave(object sender, EventArgs e)
        {
            if (txtFristName.Text == string.Empty)
            {
                txtFristName.Text = "FristName";
                lblFristName.Visible = true;
                lblFristName.Text = "Enter FristName";
            }
            else
            {
                lblFristName.Visible = false;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == string.Empty)
            {
                txtLastName.Text = "LastName";
                lblLastName.Visible = true;
                lblLastName.Text = "Enter LastName";
            }
            else
            {
                lblLastName.Visible = false;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                txtEmail.Text = "Example@abc.com";
                lblEmail.Visible = true;
                lblEmail.Text = "Enter Email Like [Example@abc.com]";
            }
            else
            {
                lblEmail.Visible = false;
            }
            if (txtEmail.Text.Contains("@gmail.com") == true || txtEmail.Text.Contains("@hotmail.com") == true || txtEmail.Text.Contains("@yahoo.com") == true || txtEmail.Text.Contains("@outlook.com") == true)
            {
                lblEmail.Text = "You Are Missing @";
            }
        }

        private void txtRollNo_Leave(object sender, EventArgs e)
        {
            if (txtRollNo.Text == string.Empty)
            {
                txtRollNo.Text = "RollNo";
                lblRollNo.Visible = true;
                lblRollNo.Text = "Enter RollNo";
            }
            else
            {
                lblRollNo.Visible = false;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtRollNo.Text == string.Empty)
            {
                txtUserName.Text = "UserName";
                lblUserName.Visible = true;
                lblUserName.Text = "Enter UserName";
            }
            else
            {
                lblUserName.Visible = false;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = "Password";
                lblPassword.Visible = true;
                lblPassword.Text = "Enter Password";
            }
            else
            {
                lblPassword.Visible = false;
            }
        }
    }
}
