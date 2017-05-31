using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Question
    {

        public int id { get; set; }
        public String question { get; set; }
        public String type { get; set; }
        public List<Answer> answers { get; set; }
        public Question()
        {
            answers = new List<Answer>();
        }
    }
}
