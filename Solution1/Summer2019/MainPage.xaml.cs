using Summer2019.ViewModel;
using Summer2019.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Summer2019
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel MainPageViewModel { get; set; }
        public MainPage()
        {
            this.MainPageViewModel = new MainPageViewModel();
            this.InitializeComponent();            
        }

        private void Button_ClickTitle(object sender, RoutedEventArgs e)
        {
            
            TitlePageView titlePageView = new TitlePageView();
        }

        private void Button_ClickArtist(object sender, RoutedEventArgs e)
        {

        }

        private void Button_ClickAlbum(object sender, RoutedEventArgs e)
        {

        }

        private void Button_ClickDuration(object sender, RoutedEventArgs e)
        {

        }
    }
}
