using eksam.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace eksam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Windows.Threading.DispatcherTimer _bannerTimer;
        private int _iterator;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModelCategory();
            _bannerTimer = new System.Windows.Threading.DispatcherTimer();
            _bannerTimer.Interval = TimeSpan.FromSeconds(3);
            _bannerTimer.Tick += BannerTimer_Tick;
            _bannerTimer.Start();

            _iterator = 0;
        }

        private void BannerTimer_Tick(object sender, EventArgs e)
        {
            _iterator++;
            if (_iterator < 7)
            {
                BannerSlider(_iterator);
            }
            else 
            {
                _iterator = 1;
                BannerSlider(_iterator);
            }

        }

        private void BannerSlider(int iter)
        {
            switch (iter)
            {
                case 1:
                    banner1.IsChecked = true;
                    bannerImage.Source = new BitmapImage(new Uri(@"/Resources/Banner/banner1.jpg", UriKind.Relative));
                    break;
                case 2:
                    banner2.IsChecked = true;
                    bannerImage.Source = new BitmapImage(new Uri(@"/Resources/Banner/banner2.jpg", UriKind.Relative));
                    break;
                case 3:
                    banner3.IsChecked = true;
                    bannerImage.Source = new BitmapImage(new Uri(@"/Resources/Banner/banner3.jpg", UriKind.Relative));
                    break;
                case 4:
                    banner4.IsChecked = true;
                    bannerImage.Source = new BitmapImage(new Uri(@"/Resources/Banner/banner4.jpg", UriKind.Relative));
                    break;
                case 5:
                    banner5.IsChecked = true;
                    bannerImage.Source = new BitmapImage(new Uri(@"/Resources/Banner/banner5.jpg", UriKind.Relative));
                    break;
                case 6:
                    banner6.IsChecked = true;
                    bannerImage.Source = new BitmapImage(new Uri(@"/Resources/Banner/banner6.jpg", UriKind.Relative));
                    break;
            }

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(banner1.IsChecked == true) { bannerImage.Source = new BitmapImage(new Uri(@"/Resources/Banner/banner1.jpg", UriKind.Relative)); }
            else if(banner2.IsChecked == true) { bannerImage.Source = new BitmapImage(new Uri(@"/Resources/Banner/banner2.jpg", UriKind.Relative)); }
            else if(banner3.IsChecked == true) { bannerImage.Source = new BitmapImage(new Uri(@"/Resources/Banner/banner3.jpg", UriKind.Relative)); }
            else if(banner4.IsChecked == true) { bannerImage.Source = new BitmapImage(new Uri(@"/Resources/Banner/banner4.jpg", UriKind.Relative)); }
            else if(banner5.IsChecked == true) { bannerImage.Source = new BitmapImage(new Uri(@"/Resources/Banner/banner5.jpg", UriKind.Relative)); }
            else if(banner6.IsChecked == true) { bannerImage.Source = new BitmapImage(new Uri(@"/Resources/Banner/banner6.jpg", UriKind.Relative)); }
        }
    }
}
