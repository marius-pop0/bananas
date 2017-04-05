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
using System.Windows.Media.Animation;
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

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            var error_count = 0;

            if (string.IsNullOrEmpty(Drink_name.Text))
            {
                Drink_name_error.Text = "Please Enter a Drink Name Before Sumbitting";
                error_count--;
            }
            else {
                Drink_name_error.Text = "";
                error_count++;
            }
            if (string.IsNullOrEmpty(Drink_Recipe.Text)) {
                Drink_Recipe_error.Text = "Please Enter at Least One Recipe Step for the Drink Before Sumbitting";
                error_count--;
            }
            else
            {
                Drink_Recipe_error.Text = "";
                error_count++;
            }
            if (string.IsNullOrEmpty(Ingredient_Name.Text)) {
                Drink_Ingredient_error.Text = "Please Enter at Least One Ingredient for the Drink Before Sumbitting";
                error_count--;
            }
            else
            {
                Drink_Ingredient_error.Text = "";
                error_count++;
            }
            if (!string.IsNullOrEmpty(Ingredient_Name.Text))
            {
                if (string.IsNullOrEmpty(Ingredient_Quantity.Text)) {
                    Drink_Ingredient_error.Text = "Please Enter the Quntity for the First Ingredient Before Sumbitting";
                    error_count--;
                }
                else
                {
                    Drink_Ingredient_error.Text = "";
                    error_count++;
                }
            }
            
            if (string.IsNullOrEmpty(Drink_description.Text))
            {
                Drink_Description_error.Text = "Please Enter a Description for the Drink Before Sumbitting";
                error_count--;
            }
            else
            {
                Drink_Description_error.Text = "";
                error_count++;
            }
            if (Drink_Cat.SelectedIndex < 0)
            {
                Drink_Cat_error.Text = "Please Select a Category for the Drink Before Sumbitting";
                error_count--;
                Drink_Cat_error.Opacity = 1;
            }
            else
            {
                Drink_Cat_error.Text = "";
                Drink_Cat_error.Opacity = 0;
                error_count++;
            }

            if (error_count == 6)
            {
                Submit_Screen.Text = "Thank You for Submitting!";
                Submit_Screen.FontSize = 45;
                Submit_Screen.Foreground = new SolidColorBrush(Colors.White);
                Panel.SetZIndex(Submit_Screen, 99);
                DoubleAnimation fadeIn = new DoubleAnimation();
                fadeIn.From = 0;
                fadeIn.To = 0.98;
                fadeIn.Duration = new Duration(TimeSpan.FromSeconds(3.0));
                fadeIn.Completed += new EventHandler(back_main);

                Storyboard.SetTarget(fadeIn, Submit_Screen);
                Storyboard.SetTargetProperty(fadeIn, new PropertyPath(FrameworkElement.OpacityProperty));
                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(fadeIn);
                storyboard.Begin(Submit_Screen);
            }
            else {
                Submit_Screen.Text = "Error\nPlease Fix the Errors Before Submitting";
                Submit_Screen.FontSize = 35;
                Submit_Screen.Foreground = new SolidColorBrush(Colors.Red);
                Panel.SetZIndex(Submit_Screen, 99);
                DoubleAnimation fadeIn = new DoubleAnimation();
                fadeIn.From = 0;
                fadeIn.To = 0.98;
                fadeIn.Duration = new Duration(TimeSpan.FromSeconds(3.0));
                fadeIn.AutoReverse = true;
                fadeIn.Completed += new EventHandler(arrange);

                Storyboard.SetTarget(fadeIn, Submit_Screen);
                Storyboard.SetTargetProperty(fadeIn, new PropertyPath(FrameworkElement.OpacityProperty));
                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(fadeIn);
                storyboard.Begin(Submit_Screen);
                
            }

        }
        private void back_main(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            NavigationService.Navigate(mp);
            //Maybe Better to just go Back?
            //NavigationService.GoBack();
        }
        private void arrange(object sender, EventArgs e)
        {
            Panel.SetZIndex(Submit_Screen, 0);
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
