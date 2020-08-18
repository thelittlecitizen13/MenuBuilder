using System;
using System.Collections.Generic;
using System.Text;


namespace MenuBuilder
{
    interface IMenu
    {
        public StringBuilder MenuDisplay { get; set; }
        public string MenuName { get;}
        public string MainOutput { get; }

        void ShowMenu();
    }
}
