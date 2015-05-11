using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace PlaceTagv0._1.View
{
    public partial class About : PhoneApplicationPage
    {
        public About()
        {
            InitializeComponent();
        }

        private void OnSendEmailClick(object sender, RoutedEventArgs e)
        {
            EmailComposeTask emailComposeTask = new EmailComposeTask();

            emailComposeTask.Subject = "message subject";
            emailComposeTask.Body = "message body";
            emailComposeTask.To = "nikapia@wp.pl";
            emailComposeTask.Cc = "cc@example.com";
            emailComposeTask.Bcc = "bcc@example.com";

            emailComposeTask.Show();
        }
    }
}