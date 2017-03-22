using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for DrinkProfile2.xaml
    /// </summary>
    public partial class CubaLibreProfile : Page
    {
        int intRate = 0;
        int intCount = 1;
        int Rate = 0;
        public CubaLibreProfile()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }

        private void whiteRussianFave_Click(object sender, RoutedEventArgs e)
        {
            WhiteRussianProfile WRprofile = new WhiteRussianProfile();
            NavigationService.Navigate(WRprofile);
        }

        private void tequilaSunriseFave_Click(object sender, RoutedEventArgs e)
        {
            TequilaSunriseProfile TSprofile = new TequilaSunriseProfile();
            NavigationService.Navigate(TSprofile);
        }

        private void mojitoFave_Click(object sender, RoutedEventArgs e)
        {
            MojitoProfile MJprofile = new MojitoProfile();
            NavigationService.Navigate(MJprofile);
        }

        private void cubaLibreFave_Click(object sender, RoutedEventArgs e)
        {
            //dont do anything since we are already on the cuba libre page
        }
        private void margaritaFave_Click(object sender, RoutedEventArgs e)
        {
            MargaritaProfile MGprofile = new MargaritaProfile();
            NavigationService.Navigate(MGprofile);
        }

        private void vodkaCat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rumCat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tequilaCat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void whiskyCat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void liqueurCat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void brandyCat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ginCat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cognacCat_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
