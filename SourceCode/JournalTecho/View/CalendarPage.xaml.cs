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
    /// 单例页面
    /// </summary>
    public partial class CalendarPage : Page
    {
        private static CalendarPage instance = null;
        private CalendarPage()
        {
            InitializeComponent();
        }
        public static CalendarPage GetCalendarPage()
        {
            if (instance == null)
            {
                instance = new CalendarPage();
            }
            return instance;
        }
    }
}
