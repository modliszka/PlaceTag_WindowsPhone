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
    public partial class DeletePlace : PhoneApplicationPage
    {
        public DeletePlace()
        {
            InitializeComponent();
        }


        private void appBarOkButton_Click(object sender, EventArgs e)
        {
            // Get a handle for the to-do item bound to the button.
            PlaceDetails placeForDelete = App.ViewModel.SelectedPlace;
            App.ViewModel.DeletePlace(placeForDelete);
            

            // Put the focus back to the main page.
            //this.Focus();

            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void appBarCancelButton_Click(object sender, EventArgs e)
        {
            // Return to the main page.
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}