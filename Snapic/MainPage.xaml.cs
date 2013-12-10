using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Snapic.Resources;
using System.Diagnostics; //For debugging purposes
using Microsoft.Devices;
using System.IO;
using System.IO.IsolatedStorage;
using Microsoft.Xna.Framework.Media;

namespace Snapic
{
    public partial class MainPage : PhoneApplicationPage
    {

        PhotoCamera cam;
        MediaLibrary libeary = new MediaLibrary();

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainPage_Loaded); 
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (PhotoCamera.IsCameraTypeSupported(CameraType.FrontFacing))
                cam = new Microsoft.Devices.PhotoCamera(CameraType.FrontFacing);

            else
                cam = new Microsoft.Devices.PhotoCamera(CameraType.Primary);


            cam.CaptureCompleted += new EventHandler<CameraOperationCompletedEventArgs>(cam_CaptureCompleted);

            System.Diagnostics.Debug.WriteLine(cam.Resolution);
            viewFinderBrush.SetSource(cam);

            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            cam.Dispose();

            cam.CaptureCompleted -= cam_CaptureCompleted;

            base.OnNavigatedFrom(e);
        }

        void cam_CaptureCompleted(object sender, Microsoft.Devices.CameraOperationCompletedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("CAPTURED IMAGE!");
        }

        private void Save_Click()
        {

        }

        //Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}