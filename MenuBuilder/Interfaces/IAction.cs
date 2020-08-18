using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public interface IAction
    {
        string actionDescriptionOutput { get;  }
        void Action();
    }
}
