using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using T2008M_UWP.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T2008M_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Click_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            var item1 = new MenuItem() { Name = "Home", MenuPage = "home",Icon= "\ue80f" };
            var item2 = new MenuItem() { Name = "Person Infomation", MenuPage = "pi" ,Icon="\uE946" };
            var item3 = new MenuItem() { Name = "Mail",MenuPage="p2", Icon = "\uE715"};
            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selectedItem = (MenuItem)Menu.SelectedItem;
            switch (selectedItem.MenuPage)
            {
                case "home": MainFrame.Navigate(typeof(Pages.Home)); break;
                case "pi": MainFrame.Navigate(typeof(Pages.PersonInfomation)); break;
                case "p2": MainFrame.Navigate(typeof(Pages.Mail)); break;
            }
        }
    }
}
