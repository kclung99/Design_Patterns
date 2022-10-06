using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    // Facade: NotificationService
    class Program
    {
        static void Main(string[] args)
        {
            var notificationService = new NotificationService();
            notificationService.Send("This is a message", "KC");
        }
    }
}
