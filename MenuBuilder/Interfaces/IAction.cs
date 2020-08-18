using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    interface IAction
    {
        string Output { get;  }
        void Action();
    }
}
