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
    public partial class AllPlaces : PhoneApplicationPage
    {
        public AllPlaces()
        {
            InitializeComponent();
        }

        private void Place_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ManagePlaces/GetPlace.xaml", UriKind.Relative));
        }


    }
}