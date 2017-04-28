using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
    public sealed partial class PacketManage : Page
    {
        public PacketManage()
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

        private void Packet_Manage_Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void NextPacketButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DropPacketButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OkayButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
