using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 빈 페이지 항목 템플릿에 대한 설명은 https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x412에 나와 있습니다.

namespace TestApp
{
    /// <summary>
    /// 자체적으로 사용하거나 프레임 내에서 탐색할 수 있는 빈 페이지입니다.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
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

        private void PacketManageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PacketManage));
        }

        private void ProxyOptionButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ProxySetting));

        }

        private void ProxyStartButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ArpSpoofingOptionButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ARP_Option));
        }

        private void ScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {

        }
        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
