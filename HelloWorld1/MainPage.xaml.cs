using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using Windows.ApplicationModel.Resources.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x410
//      questo codice è sotto licenza GPL 
namespace HelloWorld1
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static ResourceMap resourceMap = ResourceManager.Current.MainResourceMap.GetSubtree("Resources");
        private static ResourceContext resourceContext = ResourceContext.GetForCurrentView();
        public MainPage()
        {
            this.InitializeComponent();
            numeronesoft.Text = resourceMap.GetValue("numeronesoft", resourceContext).ValueAsString;
            inseriscinome.Text = resourceMap.GetValue("inseriscinome", resourceContext).ValueAsString;
            gpl.Text = resourceMap.GetValue("gplpower", resourceContext).ValueAsString;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            ciaogpl.Text = resourceMap.GetValue("ciao", resourceContext).ValueAsString + " " + Nome.Text + " " + resourceMap.GetValue("festafinita", resourceContext).ValueAsString;
            Ok.IsEnabled = false;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
