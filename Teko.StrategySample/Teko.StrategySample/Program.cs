using System;
using Teko.StrategySample.Notificators;

namespace Teko.StrategySample
{
    /// <summary>
    /// Strategy Pattern:
    /// Define a family of algorithms, encapsulate each one, and make them interchangeable. 
    /// Strategy lets the algorithm vary independently from clients that use it. 
    /// Frequency of use: medium high
    /// </summary>
    class Program
    {
        static void Main()
        {
            var notificator = CreateUserNotificator();

            NotifyUsingStrategyOne(notificator);
            Console.ReadLine();

            NotifyUsingStrategyTwo(notificator);
            Console.ReadLine();

            NotifyUsingAnotherContext();
            Console.ReadLine();
        }

        private static UserNotificator CreateUserNotificator()
        {
            // instantiate a "Context"
            var notificator = new UserNotificator();

            // The context encapsulates common functions which are decopled from the strategy
            notificator.AddNotification("Hello");
            notificator.AddNotification("World");
            notificator.AddNotification("123");
            return notificator;
        }

        private static void NotifyUsingStrategyOne(UserNotificator notificator)
        {
            // Strategy - Concrete Strategy 1
            // We want to run the notifications based on the strategy 1
            UserNotifitcationStrategyBase strategy1 = new ConsoleNotificator();
            notificator.SetStrategy(strategy1);

            // Call the method which will use the strategy
            notificator.ShowNotifications();
        }

        private static void NotifyUsingStrategyTwo(UserNotificator notificator)
        {
            // Strategy - Concrete Strategy 1
            // We can change the strategy on runtime to switch the algorithm 
            // and then run the actions again on the same state/data
            UserNotifitcationStrategyBase strategy2 = new MessageBoxNotificator();
            notificator.SetStrategy(strategy2);

            // Call the method which will use the strategy
            notificator.ShowNotifications();
        }

        private static void NotifyUsingAnotherContext()
        {
            var notificator = new GenericUserNotificator<ConsoleRedNotificator>();
            notificator.Notify("Generics are cool!");
        }
    }
}
