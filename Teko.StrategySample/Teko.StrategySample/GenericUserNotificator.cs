using System;
using Teko.StrategySample.Notificators;

namespace Teko.StrategySample
{
    /// <summary>
    /// Another Context class to demonstrate that we can reuse the strategies/algorithms
    /// because they are decoupled from the usage.
    /// </summary>
    /// <typeparam name="TStrategy">The type of the strategy.</typeparam>
    public class GenericUserNotificator<TStrategy>
       where TStrategy : UserNotifitcationStrategyBase
    {
        public void Notify(string message)
        {
            var strategyInstance = (UserNotifitcationStrategyBase)Activator.CreateInstance<TStrategy>();
            strategyInstance.Notify(message);
        }
    }
}
