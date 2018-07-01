using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_new
{
    public class Question
    {
        public string question;
        public List<string> answers;

        public Question(string q, List<string> a)
        {
            question = q;
            answers = a;
        }
    }

}
