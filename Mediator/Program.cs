using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Mediator.Standard_Mediator;
using Mediator.Observer_Mediator;

namespace Mediator
{
    class Program
    {
        // --Standard_Mediator
        // Mediator: DialogBox
        // ConcreteMediator: ArticleDialogBox
        // Colleague: UIControl
        // ConcreteColleague1: ListBox
        // ConcreteColleague2: TextBox
        // ConcreteColleague3: Button

        //--Observer_Mediator
        // Subject: UIControl
        // ConcreteSubject1: ListBox
        // ConcreteSubject2: TextBox
        // ConcreteSubject3: Button
        // Observer: IEventHandler
        // Obj: ArticleDialogBox
        // ConcreteObserver: (Anonymous observer)

        static void Main(string[] args)
        {
            var articleDialogBox = new ArticleDialogBox();
            articleDialogBox.SimulateUserSelection();
        }
    }
}
