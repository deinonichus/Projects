using System;

namespace Teko.StrategySample.Notificators
{
    /// <summary>
    /// Represents a concrete strategy.
    /// Writes text to the console.
    /// </summary>
    public class ConsoleNotificator : UserNotifitcationStrategyBase
    {
        public override void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
