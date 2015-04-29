using System;

namespace Teko.StrategySample.Notificators
{
    /// <summary>
    /// Represents a concrete strategy.
    /// Writes red text to the console.
    /// </summary>
    public class ConsoleRedNotificator : UserNotifitcationStrategyBase
    {
        public override void Notify(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
