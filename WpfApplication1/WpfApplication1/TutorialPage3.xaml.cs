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
using System.Timers;
using System.Diagnostics;
using System.Windows.Media.Animation;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for TutorialPage2.xaml
    /// </summary>
    public partial class TutorialPage3 : Page
    {
        Timer ClickTimer = new Timer();
        private int ClickCounter;

        public TutorialPage3()
        {
            ClickTimer = new Timer(300);
            ClickTimer.Elapsed += new ElapsedEventHandler(EvaluateClicks);
            InitializeComponent();
        }

        private void blueMargaritaButton_Click(object sender, RoutedEventArgs e)
        {
            BlueMargaritaProfile profile = new BlueMargaritaProfile();
            NavigationService.Navigate(profile);
        }

        private void grapeMargaritaButton_Click(object sender, RoutedEventArgs e)
        {
            GrapeMargaritaProfile profile = new GrapeMargaritaProfile();
            NavigationService.Navigate(profile);
        }


        private void margarita_Click(object sender, RoutedEventArgs e)
        {
            MargaritaProfile profile = new MargaritaProfile();
            NavigationService.Navigate(profile);
        }

        private void mintMargaritaButton_Click(object sender, RoutedEventArgs e)
        {
            MintMargaritaProfile profile = new MintMargaritaProfile();
            NavigationService.Navigate(profile);
        }

        private void mojito_Click(object sender, RoutedEventArgs e)
        {
            MojitoProfile profile = new MojitoProfile();
            NavigationService.Navigate(profile);
        }

        private void tequilaSunrise_Click(object sender, RoutedEventArgs e)
        {
            TequilaSunriseProfile profile = new TequilaSunriseProfile();
            NavigationService.Navigate(profile);
        }

        private void whiteRussian_Click(object sender, RoutedEventArgs e)
        {
            WhiteRussianProfile profile = new WhiteRussianProfile();
            NavigationService.Navigate(profile);
        }


        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainPage main = new MainPage();
            NavigationService.Navigate(main);
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage main = new MainPage();
            NavigationService.Navigate(main);
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

        private void drink5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ClickTimer.Stop();
            ClickCounter++;
            ClickTimer.Start();
        }

        private void Favorite_Double()
        {
            DoubleAnimation fadeIn_Out = new DoubleAnimation();
            fadeIn_Out.From = 0;
            fadeIn_Out.To = 0.85;
            fadeIn_Out.Duration = new Duration(TimeSpan.FromSeconds(1.0));
            fadeIn_Out.AutoReverse = true;

            Storyboard.SetTarget(fadeIn_Out, Fave_CBlibre);
            Storyboard.SetTargetProperty(fadeIn_Out, new PropertyPath(FrameworkElement.OpacityProperty));
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(fadeIn_Out);
            storyboard.Begin(Fave_CBlibre);

        }
        private void EvaluateClicks(object source, ElapsedEventArgs e)
        {
            ClickTimer.Stop();
            // Evaluate ClickCounter here

            if (ClickCounter == 1)
            {
                Trace.Write("you single Clicked");
                this.Dispatcher.Invoke(() =>
                {
                    CubaLibreProfile CBprofile = new CubaLibreProfile();
                    NavigationService.Navigate(CBprofile);
                });

                ClickCounter = 0;
            }
            if (ClickCounter >= 2)
            {
                ClickCounter = 0;
                Trace.Write("you double Clicked");
                this.Dispatcher.Invoke(() =>
                {
                    Favorite_Double();
                });

            }
        }

    }

}
