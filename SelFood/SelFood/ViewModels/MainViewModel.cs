using SelFood.Models;
using SelFood.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Text;

namespace SelFood.ViewModels
{
    public class MainViewModel
    {

        #region Properties
        public ObservableCollection<Menu> MyMenu
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            LoadMenu();
        }
        #endregion

        #region Methods
        private void LoadMenu()
        {
            MyMenu = new ObservableCollection<Menu>
            {
                new Menu
                {
                    Icon = "ic_settings",
                    PageName = "Login",
                    Title = "My Profile"
                },
                new Menu
                {
                    Icon = "ic_fastfood",
                    PageName = "Ingredientes",
                    Title = "Ingredientes"
                },
                new Menu
                {
                    Icon = "ic_exit_to_app",
                    PageName = "Login",
                    Title = "Cerrar Sesión"
                }
            };

        }
        #endregion
    }
}
