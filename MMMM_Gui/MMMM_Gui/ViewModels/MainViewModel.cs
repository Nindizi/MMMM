﻿using MMMM_Gui.Commands;
using MMMM_Gui.Models;
using MMMM_Gui.Views;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace MMMM_Gui.ViewModels
{
    /// <summary>
    /// View model for main window
    /// </summary>
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel() { 
            Users = UserManager.GetUsers();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            var mainWindow = obj as Window;

            AddUser addUserWin = new AddUser();
            addUserWin.Owner = mainWindow;
            addUserWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addUserWin.Show();
        }
    }
}
