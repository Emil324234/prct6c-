using prct6.Model;
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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prct6.View
{
    /// <summary>
    /// Логика взаимодействия для CharactersPage.xaml
    /// </summary>
    public partial class CharactersPage : Page //страница для меню выбора персонажей
    {
        public CharactersPage()
        {
            InitializeComponent();

            //это пример, его можно будет удалить
            CharacterControl first = new CharacterControl();
            first.CharacterName = "Мигель Рохо";
            first.CharacterImage = new BitmapImage(new Uri("\\Images\\мигель.png", UriKind.Relative));

            //так остальные персонажи. надо будет создать папку images и вставить туда картинки, чтобы оттуда брать изображения
            //внос персонажей в список после создания всех

            List<CharacterControl> characters = new List<CharacterControl>() { first}; 
            imgs.ItemsSource = characters;

        }
    }
}
