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
        }

        private void Place_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/ManagePlaces/GetPlace.xaml", UriKind.Relative));
        }

        private void newPlaceBarButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/ManagePlaces/AddPlace.xaml", UriKind.Relative));
        }

        private void deletePlaceBarButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/ManagePlaces/DeletePlace.xaml", UriKind.Relative));
        }
    }
}