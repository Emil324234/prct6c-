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

namespace prct6.View
{
    /// <summary>
    /// Логика взаимодействия для CharacterControl.xaml
    /// </summary>
    public partial class CharacterControl : UserControl
    {
        public string CharacterName { get; set; }
        public BitmapImage CharacterImage { get; set; } = new BitmapImage(new Uri("C:\\Users\\My\\Downloads\\мигель.png", UriKind.Absolute));
        public CharacterControl()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
