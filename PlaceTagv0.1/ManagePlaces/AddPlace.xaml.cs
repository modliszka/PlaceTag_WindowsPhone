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
    public partial class AddPlace : PhoneApplicationPage
    {
        public AddPlace()
        {
            InitializeComponent();

            // Set the page DataContext property to the ViewModel.
            this.DataContext = App.ViewModel;
        }

        private void appBarAddButton_Click(object sender, EventArgs e)
        {
            // Confirm there is some text in the text box.
            if (newPlaceNameTextBox.Text.Length > 0)
            {
                // Create a new place.
                PlaceDetails newPlaceItem = new PlaceDetails
                {
                    PlaceName = newPlaceNameTextBox.Text,
                    PlaceCity = city.Text,
                    PlaceStreet = street.Text,
                    PlaceStreetNumber = streetNumber.Text,
                    PlaceDescription = description.Text
                    //Category = (ToDoCategory)categoriesListPicker.SelectedItem
                };

                // Add the place to the ViewModel.
                App.ViewModel.AddPlace(newPlaceItem);

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