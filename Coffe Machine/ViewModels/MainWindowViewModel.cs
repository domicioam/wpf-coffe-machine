using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coffe_Machine.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty<string>(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            Title = "COFFE MACHINE 3500";
        }
    }
}
