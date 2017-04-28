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
    public sealed partial class ARP_Option : Page
    {
        public ARP_Option()
        {
            this.InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void SubButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void AttackButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void StopButton_Click(object sender, RoutedEventArgs e)
        {

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

        private void ARP_Option_Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
