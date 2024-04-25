using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace prct6c_
{
    public partial class ViewModel : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<CalendarDay> calendarDays;

        public ObservableCollection<CalendarDay> CalendarDays
        {
            get { return calendarDays; }
            set
            {
                calendarDays = value;
                OnPropertyChanged("CalendarDays");
            }
        }

        public ViewModel()
        {
            InitializeComponent();
            InitializeCalendar();
        }

        private void InitializeCalendar()
        {
            CalendarDays = new ObservableCollection<CalendarDay>();
            // Здесь можно добавить логику для заполнения календаря начальными данными
        }

        public void AddImageToDay(CalendarDay selectedDay, Image image)
        {
            selectedDay.Image = image;
        }

        public void RemoveImageFromDay(CalendarDay selectedDay)
        {
            selectedDay.Image = null;
        }

        public void SaveImageForDay(CalendarDay selectedDay)
        {
            // Здесь можно добавить логику для сохранения изображения для выбранного дня
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class CalendarDay
    {
        public Image Image { get; set; }
        // Здесь можно добавить дополнительные поля для дня календаря
    }
}
