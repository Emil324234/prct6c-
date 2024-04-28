using Microsoft.Win32;
using prct6.Model;
using prct6.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace prct6.ViewModel
{
    internal class MainVM : BindingHelper
    {
        MainWindow mainWindow = new MainWindow();

        private BindableCommand _save;
        public BindableCommand SaveImageCommand
        {
            get
            {
                return _save ??
                    (_save = new BindableCommand(_ => SaveImageForDay()));
            }
        }

        private BindableCommand _remove;
        public BindableCommand RemoveImageCommand
        {
            get
            {
                return _remove ??
                    (_remove = new BindableCommand(_=> RemoveImageFromDay()));
            }
        }
        public MainVM() { }

        public void RemoveImageFromDay()
        {
            string path = "path.json";
            if (File.Exists(path))
            {
                List<Character> charjson = JsonSaver.DeserializeObject<List<Character>>(path);

                foreach (var item in charjson)
                {
                    if (item.DateChoice == (DateTime)mainWindow.calend.SelectedDate)
                    {
                        var forDelete = JsonSaver.DeserializeObject<List<Character>>(path);
                        forDelete.Clear();
                        JsonSaver.SerializeObject(forDelete);
                    }
                }
            }
        }

        public void SaveImageForDay()
        {
            string jsonContent = "path.json";
            if (!string.IsNullOrEmpty(jsonContent))
            {
                if(!File.Exists(jsonContent))
                {
                    File.Create(jsonContent);
                }
                var jsonData = JsonSaver.SerializeObject(jsonContent);
            } 
        }
    }
}
