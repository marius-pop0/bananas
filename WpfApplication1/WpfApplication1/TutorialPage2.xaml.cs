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
    public partial class TutorialPage2 : Page
    {
        public TutorialPage2()
        {
            
            InitializeComponent();
        }

        private void grapeMargaritaButton_Click(object sender, RoutedEventArgs e)
        {
            GrapeMargaritaProfile profile = new GrapeMargaritaProfile();
            NavigationService.Navigate(profile);
        }
  
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainPage main = new MainPage();
            NavigationService.Navigate(main);
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            TutorialPage3 next = new TutorialPage3();
            NavigationService.Navigate(next);
        }

    }

}
