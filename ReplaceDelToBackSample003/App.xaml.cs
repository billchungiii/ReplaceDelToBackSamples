using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ReplaceDelToBackSample003
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            EventManager.RegisterClassHandler(typeof(TextBox), TextBox.PreviewKeyDownEvent , new KeyEventHandler(OnPreviewKeyDown));
            base.OnStartup(e);
        }

        private void OnPreviewKeyDown(object sender, KeyEventArgs e)
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
