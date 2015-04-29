namespace Teko.StrategySample.Notificators
{
    /// <summary>
    /// Represents the "Strategy" in the pattern.
    /// </summary>
    public abstract class UserNotifitcationStrategyBase
    {
        public abstract void Notify(string message);
    }
}
