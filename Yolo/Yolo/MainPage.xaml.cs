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
using Yolo.ViewModels;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Yolo
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        public string FirstName
        {
            get { return this.FirstName; }
            set
            {
                this.FirstName = value;
            }
        }

        public string LastName
        {
            get { return this.LastName; }
            set
            {
                this.LastName = value;
            }
        }

        public string Email
        {
            get { return this.Email; }
            set
            {
                this.Email = value;
            }
        }

        private string Info;

        private void Button_Click(Object sender, RoutedEventArgs e)
        {
            var dc = DataContext as MainViewModel;
            dc.TextYolo = "test";
            
        }
    }
}
