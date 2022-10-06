using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    // Context: Conavas
    // State: ITool
    // ConcreteState1: TextBox
    // ConcreteState2: SelectionTool

    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas(new TextBox());
            canvas.Click();
        }
    }
}
