using MVVMDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace MVVMDemo.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private string textView;
        private string greeting;
        public string TextView { get { return textView; } set { textView = value; NotifyPropertyChanged(); } }
        public string Greeting { get { return greeting; } set { greeting = value; NotifyPropertyChanged(); } }
        public ICommand ValidateUserInputCommand { get; set; }

        public MainViewModel()
        {
            ValidateUserInputCommand = new DelegateCommand(x => ValidateInput());
        }

        private void ValidateInput()
        {
            Greeting = "Hallo " + TextView;
            ConfigModel configModel = new ConfigModel();
            configModel.username = TextView;
        }
    }
}
