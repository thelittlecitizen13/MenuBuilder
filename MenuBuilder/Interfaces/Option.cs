using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class Option
    {
        public string actionDescriptionOutput { get;  }
        public Action RunAction { get; set; }
        public Option(Action act, string output)
        {
            RunAction = act;
            actionDescriptionOutput = output;
        }
    }
}
