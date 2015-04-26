using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PlaceTagv0._1.Resources;

namespace PlaceTagv0._1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ManagePlaces/AddPlace.xaml", UriKind.Relative));
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ManagePlaces/AllPlaces.xaml", UriKind.Relative));
        }
    }
}