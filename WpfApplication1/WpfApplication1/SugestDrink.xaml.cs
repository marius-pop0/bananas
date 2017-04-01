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
    /// Interaction logic for SugestDrink.xaml
    /// </summary>
    public partial class SugestDrink : Page
    {
        public SugestDrink()
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
            TequilaCategory tequilaCategory = new TequilaCategory();
            NavigationService.Navigate(tequilaCategory);
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

        private void Add_a_Photo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBlock_GotFocus;
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
