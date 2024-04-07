using MMMM_Gui.Models;
using MMMM_Gui.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace MMMM_Gui.Views
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// using code from:
    /// https://github.com/TacticDevGit/Record-Book-App-WPF-MVVM/tree/main/Record%20Book%20MVVM
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserList.Items.Filter = FilterMethod;
        }

        private bool FilterMethod(object obj)
        {
            var user = (User)obj;

            return user.Name.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase);
        }
    }
}
