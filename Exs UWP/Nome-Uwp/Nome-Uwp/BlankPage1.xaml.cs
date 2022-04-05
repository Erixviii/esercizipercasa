using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=234238

namespace Nome_Uwp
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }

        private async void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            /* La parola chiave async trasforma un metodo in un metodo asincrono, 
             * che consente di usare la parola chiave await nel relativo corpo.
            Quando la parola chiave await viene applicata, interrompe il metodo di chiamata 
            e restituisce il controllo al chiamante fino al completamento dell'attività attesa.
            await può essere usato solo all'interno di un metodo asincrono.*/
            MessageDialog mes = new MessageDialog("arrivederci", "saluti");
            await mes.ShowAsync();
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
