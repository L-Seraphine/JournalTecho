using JournalTecho.ViewModel;
using Markdig;
using Markdig.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JournalTecho.View
{
    /// <summary>
    /// DiaryPage.xaml 的交互逻辑
    /// </summary>
    public partial class DiaryPage : Page
    {
        private static DiaryPage instance = null;
        private DiaryPage()
        {
            InitializeComponent();
            this.DataContext = new DiaryPageViewModel(TextBox,Browser);    //连接对应的viewmodel
        }
        public static DiaryPage GetDiaryPage()
        {
            if (instance == null)
            {
                instance = new DiaryPage();
            }
            return instance;
        }

        private void RenderPage(object sender, TextChangedEventArgs e)
        {
            DiaryPageViewModel.RenderPage();
        }
    }
}
