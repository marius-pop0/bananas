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

        private void vodkaCat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SearchScreen page2 = new SearchScreen();
            this.Content = page2;
        }

        private void Fave1_Click(object sender, RoutedEventArgs e)
        {
            
        }
    
        private void Fave2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Fave3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Fave4_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Fave5_Click(object sender, RoutedEventArgs e)
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

        private void drink1_Click(object sender, RoutedEventArgs e)
        {
            DrinkProfile2 page1 = new DrinkProfile2();
            this.Content = page1;
        }

        private void drink1Menu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void drink2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void drink2Menu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void drink3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void drink3Menu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void drink4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void drink4Menu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void drink5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void drink5Menu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
