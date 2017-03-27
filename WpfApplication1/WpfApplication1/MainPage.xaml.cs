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
using System.Windows.Media.Animation;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Settings_Click(object sender, RoutedEventArgs e)
        {


            ThicknessAnimation tAnimation = new ThicknessAnimation();
            tAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.5));

            string marginLeft = Content.Margin.Left.ToString();
            if (marginLeft == "0") {
                tAnimation.From = new Thickness(0, 0, 0, 0);
                tAnimation.To = new Thickness(500, 0, 0, 0);
            }
            else{
                tAnimation.From = new Thickness(500, 0, 0, 0);
                tAnimation.To = new Thickness(0, 0, 0, 0);
            }
            
            Storyboard.SetTarget(tAnimation, Content);
            Storyboard.SetTargetProperty(tAnimation, new PropertyPath(FrameworkElement.MarginProperty));
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(tAnimation);
            storyboard.Begin(Content);
            
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Page1 emptySearch = new Page1();
            NavigationService.Navigate(emptySearch);
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
            CubaLibreProfile CBprofile = new CubaLibreProfile();
            NavigationService.Navigate(CBprofile);
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

        private void blueMargaritaButton_Click(object sender, RoutedEventArgs e)
        {
            BlueMargaritaProfile BMprofile = new BlueMargaritaProfile();
            NavigationService.Navigate(BMprofile);
        }

        private void blueMargaritaMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cubaLibre_Click(object sender, RoutedEventArgs e)
        {
            CubaLibreProfile CLprofile = new CubaLibreProfile();
            NavigationService.Navigate(CLprofile);
        }

        private void cubaLibreMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void margarita_Click(object sender, RoutedEventArgs e)
        {
            MargaritaProfile MGprofile = new MargaritaProfile();
            NavigationService.Navigate(MGprofile);
        }

        private void margaritaMenu_Click(object sender, RoutedEventArgs e)
        {


        }

        private void mintMargaritaButton_Click(object sender, RoutedEventArgs e)
        {
            MintMargaritaProfile Mintprofile = new MintMargaritaProfile();
            NavigationService.Navigate(Mintprofile);
        }

        private void mintMargaritaMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mojito_Click(object sender, RoutedEventArgs e)
        {
            MojitoProfile MJprofile = new MojitoProfile();
            NavigationService.Navigate(MJprofile);
        }

        private void mojitoMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tequilaSunrise_Click(object sender, RoutedEventArgs e)
        {
            TequilaSunriseProfile TSprofile = new TequilaSunriseProfile();
            NavigationService.Navigate(TSprofile);
        }

        private void tequilaSunriseMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void whiteRussian_Click(object sender, RoutedEventArgs e)
        {
            WhiteRussianProfile WRprofile = new WhiteRussianProfile();
            NavigationService.Navigate(WRprofile);
        }

        private void whiteRussianMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Random_Click(object sender, RoutedEventArgs e)
        {
            WhiteRussianProfile WRprofile = new WhiteRussianProfile();
            NavigationService.Navigate(WRprofile);
        }

        private void Favorite_Click(object sender, RoutedEventArgs e)
        {
            FavoriteRecipes favoriteRecipes = new FavoriteRecipes();
            NavigationService.Navigate(favoriteRecipes);
        }

        
    }
}
