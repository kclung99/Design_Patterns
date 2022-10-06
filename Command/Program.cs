using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Standard_Commands;
using Command.Composite_Commands;
using Command.Undoable_Commands;

namespace Command
{
    class Program
    {
        // --Standard_Commands:
        // Invoker: Button
        // Command: ICommand
        // ConcreteCommand1: TransferMoneyCommmand
        // Reciever: CustomerService

        // --Composite_Commands:
        // ConcreteCommand2: AddCustomerCommand
        // ConcreteCommand: CompositeCommand

        // --Undoable_Commands:
        // UndoableCommand: IUndoableCommand
        // ConcreteUndoableCommand: ResizeCommand
        // Reciever: ImageService
        // ConcreteCommand: UndoCommand
        // Caretaker: History

        static void Main(string[] args)
        {
            // Std Command
            var service = new CustomerService();
            var transferMoneyCommand = new TransferMoneyCommand(service);
            var button1 = new Button(transferMoneyCommand);
            button1.Click();

            // Composite Command
            var addCustomerCommand = new AddCustomerCommand(service);
            var compositeCommand = new CompositeCommand();
            compositeCommand.AddCommand(transferMoneyCommand);
            compositeCommand.AddCommand(addCustomerCommand);
            var button2 = new Button(compositeCommand);
            button2.Click();

            // Undoable Command
            var imageService = new ImageService();
            var history = new History();
            var resizeCommand = new ResizeCommand(imageService, history, 50);
            resizeCommand.Execute();

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();

        }
    }
}
