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

// Directive for the ViewModel.
using PlaceTagv0._1.ViewModel;

namespace PlaceTagv0._1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the page DataContext property to the ViewModel.
            this.DataContext = App.ViewModel;
        }

        private void place_Click(object sender, EventArgs e)
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

            /*
             // Cast the parameter as a button.
            var button = sender as Button;

            if (button != null)
            {
                // Get a handle for the to-do item bound to the button.
                ToDoItem toDoForDelete = button.DataContext as ToDoItem;

                App.ViewModel.DeleteToDoItem(toDoForDelete);
            }

            // Put the focus back to the main page.
            this.Focus();
             */

        }
        
        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            // Save changes to the database.
            App.ViewModel.SaveChangesToDB();
        }

    }
}