using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgram
{
    class MyUtility
    {
        public static string PasswordReverse(string txt)
        {
            string Value = "";
            for (int i = txt.Count() - 1; i >= 0; i--)
            {
                Value += txt[i];
            }
            return Value;
        }
    }
}
