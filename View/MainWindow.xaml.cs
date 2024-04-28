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
using prct6.View;
using prct6.ViewModel;

namespace prct6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainVM();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animOpacity = new DoubleAnimation();
            animOpacity.From = calend.Opacity;
            animOpacity.To = 0;
            animOpacity.Duration = TimeSpan.FromSeconds(3);

            calend.BeginAnimation(OpacityProperty, animOpacity);

            calend.Visibility = Visibility.Hidden;
            PageFrame.Content = new CharactersPage();
        }
    }
}
