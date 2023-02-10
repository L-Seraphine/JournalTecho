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
    /// MainPage.xaml 的交互逻辑
    /// </summary>
    public partial class MainPage : Page
    {
        private static MainPage instance = null;
        public MainPage()
        {
            InitializeComponent();
        }
        public static MainPage GetMainPage()
        {
            if (instance == null)
            {
                instance = new MainPage();
            }
            return instance;
        }
    }
}
