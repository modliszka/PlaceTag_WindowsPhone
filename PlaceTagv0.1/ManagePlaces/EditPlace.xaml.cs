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
using Databases;

namespace PlaceTagv0._1
{
    public partial class EditPlace : PhoneApplicationPage
    {
        public EditPlace()
        {
            InitializeComponent();
        }

        private void appBarSaveButton_Click(object sender, RoutedEventArgs e)
        {
            var id = 1;
            String nam = name.Text;
            String desc = description.Text;
            String cit = city.Text;
            String strt = street.Text;
            String strtNo = streetNumber.Text;
            DatabaseUpdate edit = new DatabaseUpdate();
            if (!String.IsNullOrEmpty(nam) && !String.IsNullOrEmpty(desc))
                edit.UpdatePlace(id, nam, desc,cit,strt,strtNo);
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