using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace prct6c_.Model
{
    internal class Character 
    {
        public string Name { get; set; }
        public BitmapImage ImageChoice { get; set; }
        public DateTime DateChoice { get; set; }

        public Character(string name, BitmapImage image, DateTime date)
        {
            Name = name;
            ImageChoice = image;
            DateChoice = date;
        }
    }
}