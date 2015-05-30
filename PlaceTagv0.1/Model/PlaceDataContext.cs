using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceTagv0._1.Model
{
    public class PlaceDataContext : DataContext
    {
        /*public static string DBConnectionString = @"isostore:/Databases.sdf";
        public PlaceDataContext(string DBConnectionString)
            : base(DBConnectionString)
        {
            if (false == this.DatabaseExists())
                this.CreateDatabase();
        }*/

         // Pass the connection string to the base class.
        public PlaceDataContext(string connectionString)
            : base(connectionString)
        { }

        public Table<PlaceDetails> Places;
    }
}

[Table]
public class PlaceDetails : INotifyPropertyChanged, INotifyPropertyChanging
{
    private int _placeId;

    [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
    public int PlaceId
    {
        get { return _placeId; }
        set
        {
            if (_placeId != value)
            {
                NotifyPropertyChanging("PlaceId");
                _placeId = value;
                NotifyPropertyChanged("PlaceId");
            }
        }
    }


    private string _placeName;
    [Column]
    public string PlaceName
    {
        get { return _placeName; }
        set
        {
            if (_placeName != value)
            {
                NotifyPropertyChanging("PlaceName");
                _placeName = value;
                NotifyPropertyChanged("PlaceName");
            }
        }
    }

    [Column]
    public int lat { get; set; }
    [Column]
    public int lon { get; set; }

    private string _placeCity;
    [Column]
    public string PlaceCity
    {
        get { return _placeCity; }
        set
        {
            if (_placeCity != value)
            {
                NotifyPropertyChanging("PlaceCity");
                _placeCity = value;
                NotifyPropertyChanged("PlaceCity");
            }
        }
    }


    private string _placeStreet;
    [Column]
    public string PlaceStreet
    {
        get { return _placeStreet; }
        set
        {
            if (_placeStreet != value)
            {
                NotifyPropertyChanging("PlaceStreet");
                _placeStreet = value;
                NotifyPropertyChanged("PlaceStreet");
            }
        }
    }


    private string _placeStreetNumber;
    [Column]
    public string PlaceStreetNumber
    {
        get { return _placeStreetNumber; }
        set
        {
            if (_placeStreetNumber != value)
            {
                NotifyPropertyChanging("PlaceStreetNumber");
                _placeStreetNumber = value;
                NotifyPropertyChanged("PlaceStreetNumber");
            }
        }
    }


    private string _placeDescription;
    [Column]
    public string PlaceDescription
    {
        get { return _placeDescription; }
        set
        {
            if (_placeDescription != value)
            {
                NotifyPropertyChanging("PlaceDescription");
                _placeDescription = value;
                NotifyPropertyChanged("PlaceDescription");
            }
        }
    }

    //The Binary version column, with the [Column(IsVersion = true)] attribute, significantly improves table update performance.
    // Version column aids update performance.
    [Column(IsVersion = true)]
    private Binary _version;

    #region INotifyPropertyChanged Members

    public event PropertyChangedEventHandler PropertyChanged;

    // Used to notify that a property changed
    private void NotifyPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region INotifyPropertyChanging Members

    public event PropertyChangingEventHandler PropertyChanging;

    // Used to notify that a property is about to change
    private void NotifyPropertyChanging(string propertyName)
    {
        if (PropertyChanging != null)
        {
            PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
        }
    }

    #endregion
}

