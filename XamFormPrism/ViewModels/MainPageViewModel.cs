using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XamFormPrism.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _message= "Welcome to Prism for Xamarin Forms application";
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public MainPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
           
        }
    }
}
