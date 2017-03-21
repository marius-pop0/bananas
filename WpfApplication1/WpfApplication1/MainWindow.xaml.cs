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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            SettingsMenu page1 = new SettingsMenu();
            this.Content = page1;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SearchScreen page2 = new SearchScreen();
            this.Content = page2;
        }

        private void whiteRussianFave_Click(object sender, RoutedEventArgs e)
        {
            WhiteRussianProfile page1 = new WhiteRussianProfile();
            this.Content = page1;
        }
    
        private void tequilaSunriseFave_Click(object sender, RoutedEventArgs e)
        {
            TequilaSunriseProfile page1 = new TequilaSunriseProfile();
            this.Content = page1;
        }

        private void mojitoFave_Click(object sender, RoutedEventArgs e)
        {
            MojitoProfile page1 = new MojitoProfile();
            this.Content = page1;
        }

        private void cubaLibreFave_Click(object sender, RoutedEventArgs e)
        {
            CubaLibreProfile page1 = new CubaLibreProfile();
            this.Content = page1;
        }
        private void margaritaFave_Click(object sender, RoutedEventArgs e)
        {
            MargaritaProfile page1 = new MargaritaProfile();
            this.Content = page1;
        }

        private void vodkaCat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rumCat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void whiskyCat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tequilaCat_Click(object sender, RoutedEventArgs e)
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

        private void cubaLibre_Click(object sender, RoutedEventArgs e)
        {
            CubaLibreProfile page1 = new CubaLibreProfile();
            this.Content = page1;
        }

        private void cubaLibreMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void margarita_Click(object sender, RoutedEventArgs e)
        {
            MargaritaProfile page1 = new MargaritaProfile();
            this.Content = page1;
        }

        private void margaritaMenu_Click(object sender, RoutedEventArgs e)
        {


        }

        private void mojito_Click(object sender, RoutedEventArgs e)
        {
            MojitoProfile page1 = new MojitoProfile();
            this.Content = page1;
        }

        private void mojitoMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tequilaSunrise_Click(object sender, RoutedEventArgs e)
        {
            TequilaSunriseProfile page1 = new TequilaSunriseProfile();
            this.Content = page1;
        }

        private void tequilaSunriseMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void whiteRussian_Click(object sender, RoutedEventArgs e)
        {
            WhiteRussianProfile page1 = new WhiteRussianProfile();
            this.Content = page1;
        }

        private void whiteRussianMenu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
