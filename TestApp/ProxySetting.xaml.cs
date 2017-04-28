using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace TestApp
{
    public sealed partial class ProxySetting : Page
    {
        public ProxySetting()
        {
            this.InitializeComponent();
        }

        private void BackRadioButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HamburgerRadioButton_Click(object sender, RoutedEventArgs e)
        {
            SplitView.IsPaneOpen = !SplitView.IsPaneOpen;
        }

        private void HomeRadioButton_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(MainPage));
        }

        private void ProxySettingsRadioButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Proxy_Setting_Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
