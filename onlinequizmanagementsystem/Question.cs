using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlinequizmanagementsystem
{
    internal class Question
    {
        public int QuestionId { get; set; }
        public string QuestionSet { get; set; }
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }
        public List<Option> Options { get; set; }
        public string SelectedOption { get; set; } 

        public Question()
        {
            Options = new List<Option>();
        }
    }

    public class Option
    {
        public string OptionChar { get; set; }
        public string OptionText { get; set; }
    }
}

