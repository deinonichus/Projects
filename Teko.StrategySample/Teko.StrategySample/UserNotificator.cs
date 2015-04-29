using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Teko.StrategySample.Notificators;

namespace Teko.StrategySample
{
    /// <summary>
    /// This class represents the "Context".
    /// It handles common logic and calls the algorithms.
    /// </summary>
    public class UserNotificator
    {
        private UserNotifitcationStrategyBase strategy;
        private readonly ICollection<string> notifications = new Collection<string>();

        /// <summary>
        /// Sets the strategy to be used.
        /// You can switch the strategy on runtime.
        /// <remarks>You have to set a strategy before you call ShowNotifications.</remarks>
        /// </summary>
        /// <param name="strategy">The strategy.</param>
        public void SetStrategy(UserNotifitcationStrategyBase strategy)
        {
            this.strategy = strategy;
        }

        public void AddNotification(string notification)
        {
            Trace.WriteLine("Add notification");
            notifications.Add(notification);
            Trace.WriteLine("Notification added");
        }

        /// <summary>
        /// Shows the notifications.
        /// You have to set a strategy with SetStrategy before you can call this method.
        /// </summary>
        /// <exception cref="System.InvalidOperationException">You have to set a strategy first!</exception>
        public void ShowNotifications()
        {
            if (strategy == null)
            {
                throw new InvalidOperationException("You have to set a strategy first!");
            }

            Trace.WriteLine("Show notification using " + strategy.GetType().Name);
            foreach (var notification in notifications)
            {
                strategy.Notify(notification);
            }
            Trace.WriteLine("All notifications showed!");
        }
    }
}
