using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgram.Images
{
    class ClassSqlConnection
    {
        public static SqlConnection Connection()
        {
            SqlConnection _Conn = new SqlConnection("Server=bilal; initial Catalog=ExamProgram;User id=sa;pwd=bilal;");
            return _Conn;
        }
    }
}
