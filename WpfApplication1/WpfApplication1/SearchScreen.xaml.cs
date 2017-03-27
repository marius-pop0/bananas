﻿using System;
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
    /// Interaction logic for SearchScreen.xaml
    /// </summary>
    public partial class SearchScreen : Page
    {
        public SearchScreen()
        {
            InitializeComponent();
        }

        private void Margarita_Click(object sender, RoutedEventArgs e)
        {
            MargaritaProfile profile = new MargaritaProfile();
            NavigationService.Navigate(profile);
        }

        private void BlueMargarita_Click(object sender, RoutedEventArgs e)
        {
            BlueMargaritaProfile profile = new BlueMargaritaProfile();
            NavigationService.Navigate(profile);
        }

        private void Catalina_Click(object sender, RoutedEventArgs e)
        {
            CatalinaMargaritaProfile profile = new CatalinaMargaritaProfile();
            NavigationService.Navigate(profile);
        }

        private void Mint_Click(object sender, RoutedEventArgs e)
        {
            MintMargaritaProfile profile = new MintMargaritaProfile();
            NavigationService.Navigate(profile);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainPage main = new MainPage();
            NavigationService.Navigate(main);
        }
    }
}
