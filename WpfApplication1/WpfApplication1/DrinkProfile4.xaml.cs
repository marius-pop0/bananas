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
    public partial class DrinkProfile4 : Page
    {
        int intRate = 0;
        int intCount = 1;
        int Rate = 0;
        public DrinkProfile4()
        {
            InitializeComponent();
            LoadImages();
        }

        private void LoadImages()
        {
            for (int i = 1; i <= 5; i++)
            {
                Image img = new Image();
                img.Name = "imgRate" + i;
                img.Stretch = Stretch.UniformToFill;
                img.Height = 45;
                img.Width = 45;
                img.Source = new BitmapImage(new Uri(@"C:\Users\Francisco Garcia\Desktop\WpfApplication1\WpfApplication1\Images\EmptyStar.png", UriKind.Absolute));
                img.MouseEnter += imgRateMinus_MouseEnter;
                pnlMinus.Children.Add(img);

                Image img1 = new Image();
                img1.Name = "imgRate" + i + i;
                img1.Stretch = Stretch.UniformToFill;
                img1.Height = 45;
                img1.Width = 45;
                img1.Visibility = Visibility.Hidden;
                img1.Source = new BitmapImage(new Uri(@"C:\Users\Francisco Garcia\Desktop\WpfApplication1\WpfApplication1\Images\FullStar.png", UriKind.Absolute));
                img1.MouseEnter += imgRatePlus_MouseEnter;
                img1.MouseLeave += imgRatePlus_MouseLeave;
                img1.MouseLeftButtonUp += imgRatePlus_MouseLeftButtonUp;
                pnlPlus.Children.Add(img1);
            }
        }

        private void imgRateMinus_MouseEnter(object sender, MouseEventArgs e)
        {
            GetData(sender, Visibility.Visible, Visibility.Hidden);
        }

        private void imgRatePlus_MouseEnter(object sender, MouseEventArgs e)
        {
            GetData(sender, Visibility.Visible, Visibility.Hidden);
        }

        private void imgRatePlus_MouseLeave(object sender, MouseEventArgs e)
        {
            GetData(sender, Visibility.Hidden, Visibility.Visible);
        }

        private void gdRating_MouseLeave(object sender, MouseEventArgs e)
        {
            SetImage(Rate, Visibility.Visible, Visibility.Hidden);
        }

        private void GetData(object sender, Visibility imgYellowVisibility, Visibility imgGrayVisibility)
        {
            GetRating(sender as Image);
            SetImage(intRate, imgYellowVisibility, imgGrayVisibility);
        }

        private void SetImage(int intRate, Visibility imgYellowVisibility, Visibility imgGrayVisibility)
        {
            foreach (Image imgItem in pnlPlus.Children.OfType<Image>())
            {
                if (intCount <= intRate)
                    imgItem.Visibility = imgYellowVisibility;
                else
                    imgItem.Visibility = imgGrayVisibility;
                intCount++;
            }
            intCount = 1;
        }

        private void imgRatePlus_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            GetRating(sender as Image);
            Rate = intRate;
            //lblRating.Text = intRate.ToString();
        }

        private void GetRating(Image Img)
        {
            string strImgName = Img.Name;
            intRate = Convert.ToInt32(strImgName.Substring(strImgName.Length - 1, 1));
        }






        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

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
