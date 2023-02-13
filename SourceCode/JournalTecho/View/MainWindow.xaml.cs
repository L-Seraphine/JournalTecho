using System.Windows;
using System.Windows.Controls;
using JournalTecho.View;
using JournalTecho.ViewModel;

namespace JournalTecho
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel.MainWindowViewModel(MainWindowNav);
            FirstRadioButton.IsChecked = true;
            Config.Singleton();
        }
    }
}
