using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Canvas
    {
        public ITool CurrentTool { get; set; }

        public Canvas(ITool currentTool)
        {
            CurrentTool = currentTool;
        }

        public void Click()
        {
            CurrentTool.Click();
        }
    }
}
