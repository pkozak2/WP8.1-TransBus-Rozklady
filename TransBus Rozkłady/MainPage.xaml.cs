﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace TransBus_Rozkłady
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;


            
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
        /// <summary>
        /// Metody uruchamiające widoki dla danego rozkładu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NcKrkView(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WidokRozkladu), "Niepołomice-Kraków");
        }
        private void NcChoView(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WidokRozkladu), "Niepołomice-Chobot");
        }
        private void KrkChoView(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WidokRozkladu), "Kraków-Chobot");
        }
        private void ChoKrkView(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WidokRozkladu), "Chobot-Kraków");
        }
        /// <summary>
        /// Metoda uruchamiająca widok z danymi aplikacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oAplikacjiView(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(oAplikacji));
        }
        /// <summary>
        /// Metoda uruchamiająca widok z opcją zgłoszenia nowego rozkładu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zglosView(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ZglosRozklad));
        }
        /// <summary>
        /// Metoda uruchamiająca widok z danymi dotyczącymi wyjątków w kursowaniu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nieKursujeView(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(nieKursuje));
        }

        
    }
}
