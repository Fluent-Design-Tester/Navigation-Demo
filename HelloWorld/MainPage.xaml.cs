using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.ApplicationModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWorld
{
    public sealed partial class MainPage : Windows.UI.Xaml.Controls.Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NavigationView_Loaded(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Students));
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                // if you have setting page, load here. 
            }
            else
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;

                switch (item.Tag.ToString())
                {
                    case "students":
                        sender.Header = "Students / Enrollments";
                        ContentFrame.Navigate(typeof(Students));
                        break;
                    case "gradings":
                        sender.Header = "Gradings";
                        ContentFrame.Navigate(typeof(Gradings));
                        break;
                    case "reports":
                        sender.Header = "Statistics and Reports";
                        ContentFrame.Navigate(typeof(Reports));
                        break;
                    case "print":
                        sender.Header = "Print";
                        ContentFrame.Navigate(typeof(Print));
                        break;
                    case "users":
                        sender.Header = "Users";
                        ContentFrame.Navigate(typeof(Users));
                        break;
                }
            }
        }
    }
}
