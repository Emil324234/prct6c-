using Microsoft.Win32;
using prct6.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prct6.ViewModel
{
    internal class MainVM : BindingHelper
    {
        JsonSaver json = new JsonSaver();

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

        private void RemoveImageFromDay()
        {
            throw new NotImplementedException();
        }

        public MainVM() { }

        public void RemoveImageFromDay(string jsonFilePath, string targetDate)
        {
            
        }

        public void SaveImageForDay()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string jsonContent = json.LoadJsonData();

                if(!string.IsNullOrEmpty(jsonContent))
                {
                    var jsonData = JsonSaver.SerializeObject(jsonContent);
                }
            }
        }
    }
}
