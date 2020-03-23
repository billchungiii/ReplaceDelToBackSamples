using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ReplaceDelToBackSample001
{
    public class MyTextBox : TextBox
    {
        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                var backKey = new KeyEventArgs(Keyboard.PrimaryDevice, Keyboard.PrimaryDevice.ActiveSource, 0, Key.Back);
                backKey.RoutedEvent = Keyboard.KeyDownEvent;
                InputManager.Current.ProcessInput(backKey);
            }
        }
    }
}
