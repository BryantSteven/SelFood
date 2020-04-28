using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;
using SelFood.Services;


namespace SelFood.Models
{
    public class Menu
    {

        NavigationService navigationService;
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }

        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(Navigate);
            }
        }
        void Navigate()
        {
            throw new NotImplementedException();
        }

    }
}