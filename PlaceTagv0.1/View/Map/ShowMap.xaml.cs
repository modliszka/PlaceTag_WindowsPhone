using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Maps.Controls;
using Microsoft.Phone.Maps;
using System.Windows.Shapes;
using System.Windows.Media;
using PlaceTagv0._1.Resources;
using System.Device.Location; // Provides the GeoCoordinate class.
using Windows.Devices.Geolocation; //Provides the Geocoordinate class.
using PlaceTagv0._1.View.Map; 

namespace PlaceTagv0._1.View
{
    public partial class ShowMap : PhoneApplicationPage
    {
        const int MIN_ZOOM_LEVEL = 1;
        const int MAX_ZOOM_LEVEL = 20;
        const int MIN_ZOOMLEVEL_FOR_LANDMARKS = 16;

        // Constructor.
        public ShowMap()
        {

            InitializeComponent();


            Microsoft.Phone.Maps.Controls.Map MyMap = new Microsoft.Phone.Maps.Controls.Map();
            //MyMap.Center = new GeoCoordinate(52, 32);
            //MyMap.ZoomLevel = 16;
            MyMap.LandmarksEnabled = true;
            MyMap.PedestrianFeaturesEnabled = true;
            MyMap.CartographicMode = MapCartographicMode.Terrain;
            ContentPanel.Children.Add(MyMap);


            // Create the localized ApplicationBar.
            BuildLocalizedApplicationBar();

            //ShowMyLocationOnTheMap();
        }

        // Placeholder code to contain the ApplicationID and AuthenticationToken
        // that must be obtained online from the Windows Phone Dev Center
        // before publishing an app that uses the Map control.
        private void MyMap_Loaded(object sender, RoutedEventArgs e)
        {
            MapsSettings.ApplicationContext.ApplicationId = "<applicationid>";
            MapsSettings.ApplicationContext.AuthenticationToken = "<authenticationtoken>";
        }


        void ZoomIn(object sender, EventArgs e)
        {
            if (MyMap.ZoomLevel < MAX_ZOOM_LEVEL)
            {
                MyMap.ZoomLevel++;
            }
        }

        void ZoomOut(object sender, EventArgs e)
        {
            if (MyMap.ZoomLevel > MIN_ZOOM_LEVEL)
            {
                MyMap.ZoomLevel--;
            }
        }


        // Create the localized ApplicationBar.
        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();
            ApplicationBar.Opacity = 0.5;

            // Create buttons with localized strings from AppResources.
            // Zoom In button.
            var appBarButton = new ApplicationBarIconButton(new Uri("/Images/zoomin.png", UriKind.Relative));
            appBarButton.Text = AppResources.AppBarZoomInButtonText;
            appBarButton.Click += ZoomIn;
            ApplicationBar.Buttons.Add(appBarButton);
            // Zoom Out button.
            var appBarButtonZoomOut = new ApplicationBarIconButton(new Uri("/Images/zoomout.png", UriKind.Relative));
            appBarButtonZoomOut.Text = AppResources.AppBarZoomOutButtonText;
            appBarButtonZoomOut.Click += ZoomOut;
            ApplicationBar.Buttons.Add(appBarButtonZoomOut);
        }
    }
}