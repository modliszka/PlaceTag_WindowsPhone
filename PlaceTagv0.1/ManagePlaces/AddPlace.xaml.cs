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
            /*String nam = name.Text;
            String desc = description.Text;
            String cit = city.Text;
            String strt = street.Text;
            String strtNo = streetNumber.Text;
            DatabaseAdd add = new DatabaseAdd();
            if (!String.IsNullOrEmpty(nam) && !String.IsNullOrEmpty(desc))
                add.AddPlace(nam, desc,cit,strt,strtNo);*/

            // Confirm there is some text in the text box.
            if (newPlaceNameTextBox.Text.Length > 0)
            {
                // Create a new to-do item.
                PlaceDetails newPlaceItem = new PlaceDetails
                {
                    PlaceName = newPlaceNameTextBox.Text,
                    //Category = (ToDoCategory)categoriesListPicker.SelectedItem
                };

                // Add the item to the ViewModel.
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