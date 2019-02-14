using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgram
{
    class ClassSqlConnection
    {
        public static SqlConnection Connection()
        {
            SqlConnection _Conn = new SqlConnection(@"Server=.\SqlExpress; initial Catalog=ExamProgram;User id=sa;pwd=bilal;");
            return _Conn;
        }
    }
    class DBHandler
    {
        public static Int32 InsertData(string _CmdText, CommandType _CmdType, SqlParameter[] _Param)
        {
            int Result = 0;
            SqlCommand _Cmd = new SqlCommand();
            _Cmd.Connection = ClassSqlConnection.Connection();
            _Cmd.CommandText = _CmdText;
            _Cmd.CommandType = _CmdType;
            if (_Param != null)
            {
                if (_Param.Count() > 0)
                {
                    _Cmd.Parameters.AddRange(_Param);
                }
            }
            _Cmd.Connection.Open();
            Result = _Cmd.ExecuteNonQuery();
            _Cmd.Connection.Close();
            return Result;
        }

        public static DataTable GetTableData(string _CmdText, CommandType _CmdType, SqlParameter[] _Param)
        {
            DataTable dt = new DataTable();
            SqlCommand _Cmd = new SqlCommand();
            _Cmd.Connection = ClassSqlConnection.Connection();
            _Cmd.Connection.Open();
            _Cmd.CommandType = _CmdType;
            _Cmd.CommandText = _CmdText;
            if (_Param != null)
            {
                if (_Param.Count() > 0)
                {
                    _Cmd.Parameters.AddRange(_Param);
                }
            }
            SqlDataAdapter adpt = new SqlDataAdapter(_Cmd);
            adpt.Fill(dt);
            _Cmd.Connection.Close();
            return dt;
        }

        public static DataTable GetTableDataSimple(string _CmdText, CommandType _CmdType)
        {
            DataTable dt = new DataTable();
            SqlCommand _Cmd = new SqlCommand();
            _Cmd.Connection = ClassSqlConnection.Connection();
            _Cmd.CommandType = _CmdType;
            _Cmd.CommandText = _CmdText;
            SqlDataAdapter adpt = new SqlDataAdapter(_Cmd);
            adpt.Fill(dt);
            return dt;
        }
    }
}
