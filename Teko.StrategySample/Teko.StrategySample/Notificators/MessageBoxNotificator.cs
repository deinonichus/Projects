using System.Windows.Forms;

namespace Teko.StrategySample.Notificators
{
    /// <summary>
    /// Represents a concrete strategy.
    /// Shows a messagebox.
    /// </summary>
    public class MessageBoxNotificator : UserNotifitcationStrategyBase
    {
        public override void Notify(string message)
        {
            MessageBox.Show(message);
        }
    }
}
