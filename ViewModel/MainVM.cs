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
        public MainVM() { }

        public void RemoveImageFromDay()
        {
            
        }

        public void SaveImageForDay()
        {
            
        }
    }
}
