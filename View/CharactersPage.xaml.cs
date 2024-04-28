
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


            CharacterControl first = new CharacterControl();
            first.CharacterName = "Судия Гундир";
            first.CharacterImage = new BitmapImage(new Uri("\\Images\\Судия Гундир.jpg", UriKind.Relative));


            CharacterControl second = new CharacterControl();
            second.CharacterName = "Вордт";
            second.CharacterImage = new BitmapImage(new Uri("\\Images\\Вордт.jpg", UriKind.Relative));

            CharacterControl third = new CharacterControl();
            third.CharacterName = "Чародей";
            third.CharacterImage = new BitmapImage(new Uri("\\Images\\Чародей.jpg", UriKind.Relative));

            CharacterControl fourth = new CharacterControl();
            fourth.CharacterName = "Хранители Бездны";
            fourth.CharacterImage = new BitmapImage(new Uri("\\Images\\Хранители Бездны.jpg", UriKind.Relative));

            CharacterControl fifth = new CharacterControl();
            fifth.CharacterName = "Священники";
            fifth.CharacterImage = new BitmapImage(new Uri("\\Images\\Священники.jpg", UriKind.Relative));

            CharacterControl sixth = new CharacterControl();
            sixth.CharacterName = "Скелет";
            sixth.CharacterImage = new BitmapImage(new Uri("\\Images\\Скелет.jpg", UriKind.Relative));

            CharacterControl seventh = new CharacterControl();
            seventh.CharacterName = "Гаэль послабее";
            seventh.CharacterImage = new BitmapImage(new Uri("\\Images\\Гаэль послабее.jpg", UriKind.Relative));

            CharacterControl eighth = new CharacterControl();
            eighth.CharacterName = "Сестра Фриде";
            eighth.CharacterImage = new BitmapImage(new Uri("\\Images\\Сестра Фриде.jpg", UriKind.Relative));

            CharacterControl ninth = new CharacterControl();
            ninth.CharacterName = "Охотник";
            ninth.CharacterImage = new BitmapImage(new Uri("\\Images\\Охотник.jpg", UriKind.Relative));

            CharacterControl tenth = new CharacterControl();
            tenth.CharacterName = "Безымянный Король";
            tenth.CharacterImage = new BitmapImage(new Uri("\\Images\\Безымянный король.jpg", UriKind.Relative));

            CharacterControl eleventh = new CharacterControl();
            eleventh.CharacterName = "Старый Король";
            eleventh.CharacterImage = new BitmapImage(new Uri("\\Images\\Старый Король.jpg", UriKind.Relative));

            CharacterControl twelth = new CharacterControl();
            twelth.CharacterName = "Йорм";
            twelth.CharacterImage = new BitmapImage(new Uri("\\Images\\Йорм.jpg", UriKind.Relative));

            CharacterControl thirteenth = new CharacterControl();
            thirteenth.CharacterName = "Виверна";
            thirteenth.CharacterImage = new BitmapImage(new Uri("\\Images\\Виверна.jpg", UriKind.Relative));

            CharacterControl fourteenth= new CharacterControl();
            fourteenth.CharacterName = "БК и Виверна";
            fourteenth.CharacterImage = new BitmapImage(new Uri("\\Images\\БК и Виверна.jpg", UriKind.Relative));

            CharacterControl fifteenth = new CharacterControl();
            fifteenth.CharacterName = "Братья";
            fifteenth.CharacterImage = new BitmapImage(new Uri("\\Images\\Братья.jpg", UriKind.Relative));

            CharacterControl sixteenth = new CharacterControl();
            sixteenth.CharacterName = "Гаэль";
            sixteenth.CharacterImage = new BitmapImage(new Uri("\\Images\\Гаэль.jpg", UriKind.Relative));

            CharacterControl seventeenth= new CharacterControl();
            seventeenth.CharacterName = "Гвин";
            seventeenth.CharacterImage = new BitmapImage(new Uri("\\Images\\Гвин.jpg", UriKind.Relative));

            CharacterControl eighteenth = new CharacterControl();
            eighteenth.CharacterName = "Гвиндолин";
            eighteenth.CharacterImage = new BitmapImage(new Uri("\\Images\\Гвиндолин.jpg", UriKind.Relative));

            CharacterControl ninteenth = new CharacterControl();
            ninteenth.CharacterName = "Девушка";
            ninteenth.CharacterImage = new BitmapImage(new Uri("\\Images\\Девушка.jpg", UriKind.Relative));

            CharacterControl twenty = new CharacterControl();
            twenty.CharacterName = "Душа Пепла";
            twenty.CharacterImage = new BitmapImage(new Uri("\\Images\\Душа Пепла.jpg", UriKind.Relative));

            CharacterControl twentyfirst = new CharacterControl();
            twentyfirst.CharacterName = "Копье Церкви";
            twentyfirst.CharacterImage = new BitmapImage(new Uri("\\Images\\Копье Церкви.jpg", UriKind.Relative));

            CharacterControl twentysecond = new CharacterControl();
            twentysecond.CharacterName = "Мидир";
            twentysecond.CharacterImage = new BitmapImage(new Uri("\\Images\\Мидир.jpg", UriKind.Relative));

            CharacterControl twentythird = new CharacterControl();
            twentythird.CharacterName = "Обжора";
            twentythird.CharacterImage = new BitmapImage(new Uri("\\Images\\Обжора.jpg", UriKind.Relative));

            CharacterControl twentyfourth = new CharacterControl();
            twentyfourth.CharacterName = "Отец Манус";
            twentyfourth.CharacterImage = new BitmapImage(new Uri("\\Images\\Отец Манус.jpg", UriKind.Relative));

            CharacterControl twentyfifth = new CharacterControl();
            twentyfifth.CharacterName = "Спаммер";
            twentyfifth.CharacterImage = new BitmapImage(new Uri("\\Images\\Спаммер.jpg", UriKind.Relative));

            CharacterControl twentysixth = new CharacterControl();
            twentysixth.CharacterName = "Танцовщица";
            twentysixth.CharacterImage = new BitmapImage(new Uri("\\Images\\Танцовщица.jpg", UriKind.Relative));

            CharacterControl twentyseventh = new CharacterControl();
            twentyseventh.CharacterName = "Доспехи Драконоборца";
            twentyseventh.CharacterImage = new BitmapImage(new Uri("\\Images\\Доспехи Драконоборца.jpg", UriKind.Relative));

            CharacterControl twentyeighth = new CharacterControl();
            twentyeighth.CharacterName = "Понтифик";
            twentyeighth.CharacterImage = new BitmapImage(new Uri("\\Images\\Понтифик.jpg", UriKind.Relative));

            CharacterControl twentyninth = new CharacterControl();
            twentyninth.CharacterName = "Чемпион Гундир";
            twentyninth.CharacterImage = new BitmapImage(new Uri("\\Images\\Чемпион Гундир.jpg", UriKind.Relative));



            List<CharacterControl> characters = new List<CharacterControl>() { first };
            imgs.ItemsSource = characters;

        }
    }
}