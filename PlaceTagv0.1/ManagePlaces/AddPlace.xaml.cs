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
using Databases;

namespace PlaceTagv0._1
{
    public partial class AddPlace : PhoneApplicationPage
    {
        public AddPlace()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String nam = name.Text;
            String desc = description.Text;
            String cit = city.Text;
            String strt = street.Text;
            String strtNo = streetNumber.Text;
            DatabaseAdd add = new DatabaseAdd();
            if (!String.IsNullOrEmpty(nam) && !String.IsNullOrEmpty(desc))
                add.AddPlace(nam, desc,cit,strt,strtNo);
        }
    }
}