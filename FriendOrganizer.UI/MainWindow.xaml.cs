using FriendOrganizer.UI.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace FriendOrganizer.UI
{
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _viewModel.Load();
        }

        private void btn_saveButton(object sender, RoutedEventArgs e)
        {
            /*
            if (_viewModel.result == MessageBoxResult.Yes)
            {
                BindingExpression binding = fnEdit.GetBindingExpression(TextBox.TextProperty);
                binding.UpdateSource();
                binding = lnEdit.GetBindingExpression(TextBox.TextProperty);
                binding.UpdateSource();
                binding = emailEdit.GetBindingExpression(TextBox.TextProperty);
                binding.UpdateSource();

            }
            */
        }

        private void btn_addButton(object sender, RoutedEventArgs e)
        {
        }

        private void btn_deleteButton(object sender, RoutedEventArgs e)
        {
        }
    }
}