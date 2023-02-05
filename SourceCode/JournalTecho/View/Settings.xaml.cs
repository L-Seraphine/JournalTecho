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
using System.Windows.Shapes;
using JournalTecho.ViewModel;

namespace JournalTecho.View
{
    /// <summary>
    /// Settings.xaml 的交互逻辑
    /// </summary>
    public partial class Settings : Window
    {
        //设置页面单例模式
        private static Settings instance = null;
        private Settings()
        {
            InitializeComponent();
            this.DataContext = new SettingsViewModel();
        }
        public static Settings GetInstance()
        {
            if(instance == null)
            {
                instance = new Settings();
            }
            return instance;
        }
    }
}
