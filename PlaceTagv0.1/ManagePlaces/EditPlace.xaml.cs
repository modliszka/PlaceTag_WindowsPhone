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
    public partial class EditPlace : PhoneApplicationPage
    {
        public EditPlace()
        {
            InitializeComponent();

            // Set the page DataContext property to the ViewModel.
            this.DataContext = App.ViewModel;
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            App.ViewModel.SaveChangesToDB();
        }

        private void appBarSaveButton_Click(object sender, EventArgs e)
        {            
            if (name.Text.Length > 0)
            {
                PlaceDetails editedPlace = App.ViewModel.SelectedPlace;
                editedPlace.PlaceName = name.Text;
                editedPlace.PlaceCity = city.Text;
                editedPlace.PlaceStreet = street.Text;
                editedPlace.PlaceStreetNumber = streetNumber.Text;
                editedPlace.PlaceDescription = description.Text;
                

                // Edit the item in the ViewModel.
                App.ViewModel.EditPlace(editedPlace);

                // Return to the main page.
                if (NavigationService.CanGoBack)
                {
                    NavigationService.GoBack();
                }
            }

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