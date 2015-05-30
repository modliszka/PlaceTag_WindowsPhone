using PlaceTagv0._1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceTagv0._1.ViewModel
{
    public class PlaceViewModel : INotifyPropertyChanged
    {
        // LINQ to SQL data context for the local database.
        private PlaceDataContext placeDB;

        // Class constructor, create the data context object.
        public PlaceViewModel(string placeDBConnectionString) {
            placeDB = new PlaceDataContext(placeDBConnectionString);
        }

        // All places.
        private ObservableCollection<PlaceDetails> _allPlaces;
        public ObservableCollection<PlaceDetails> AllPlaces
        {
            get { return _allPlaces; }
            set {
                _allPlaces = value;
                NotifyPropertyChanged("AllPlaces");
            }
        }

        private PlaceDetails _selectedPlace;
        public PlaceDetails SelectedPlace
        {
            get { return _selectedPlace; }
            set
            {
                _selectedPlace = value;
                NotifyPropertyChanged("SelectedPlace");
            }
        }

        // Query database and load the collections and list used by the pivot pages.
        public void LoadCollectionsFromDatabase()
        {
            // Specify the query for all places in the database.
            var placesInDB = from PlaceDetails place in placeDB.Places
                                select place;

            // Query the database and load all places.
            AllPlaces = new ObservableCollection<PlaceDetails>(placesInDB);
        }

        // Add a place to the database and collections.
        public void AddPlace(PlaceDetails newPlace)
        {
            // Add a place to the data context.
            placeDB.Places.InsertOnSubmit(newPlace);

            // Save changes to the database.
            SaveChangesToDB();

            // Add a place to the "all" observable collection.
            AllPlaces.Add(newPlace);
        }

        // Add a to-do item to the database and collections.
        public void EditPlace(PlaceDetails editedPlace)
        {
            // Add a to-do item to the data context.
            var place = placeDB.Places.Where(p => p.PlaceId == SelectedPlace.PlaceId).FirstOrDefault();

            place.PlaceName = editedPlace.PlaceName;
            place.PlaceCity = editedPlace.PlaceCity;
            place.PlaceStreet = editedPlace.PlaceStreet;
            place.PlaceStreetNumber = editedPlace.PlaceStreetNumber;
            place.PlaceDescription = editedPlace.PlaceDescription;

            // Save changes to the database.
            SaveChangesToDB();
        }

        // Remove a to-do task item from the database and collections.
        public void DeletePlace(PlaceDetails placeForDelete)
        {
            // Remove a place from the "all" observable collection.
            AllPlaces.Remove(placeForDelete);
            // Remove the to-do item from the data context.
            placeDB.Places.DeleteOnSubmit(placeForDelete);

            // Save changes to the database.
            SaveChangesToDB();
        }


        // Write changes in the data context to the database.
        public void SaveChangesToDB() {
            placeDB.SubmitChanges();
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        // Used to notify the app that a property has changed.
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
