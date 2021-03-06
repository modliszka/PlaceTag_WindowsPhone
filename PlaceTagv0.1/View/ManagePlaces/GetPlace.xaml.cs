﻿using System;
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
    public partial class GetPlace : PhoneApplicationPage
    {
        public GetPlace()
        {
            InitializeComponent();
            this.DataContext = App.ViewModel;
        }

        private void newPlaceBarButton_Click(object sender, EventArgs e) //routedEventArgs - roznica?
        {
            NavigationService.Navigate(new Uri("/View/ManagePlaces/EditPlace.xaml", UriKind.Relative));
        }

        private void deletePlaceBarButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/ManagePlaces/DeletePlace.xaml", UriKind.Relative));
        }

        private void showPlaceBarButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Map/ShowMap.xaml", UriKind.Relative));
        }

        private void backBarButton_Click(object sender, EventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}