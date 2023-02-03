using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace JournalTecho.SourceFile.Controls
{
    /// <summary>
    /// GeneralControls.xaml 的交互逻辑
    /// </summary>
    public partial class GeneralControls : UserControl
    {
        public static DependencyProperty TitlesProperty =
            DependencyProperty.Register("Titles", typeof(string), typeof(GeneralControls), new PropertyMetadata("hhhhhh"));

        [BindableAttribute(true)]
        public string Titles
        {
            get { return (string)GetValue(TitlesProperty); }
            set { SetValue(TitlesProperty, value); }
        }
        public static string GetTitles(DependencyObject obj)
        {
            return (string)obj.GetValue(TitlesProperty);
        }

        public static void SetTitles(DependencyObject obj, string value)
        {
            obj.SetValue(TitlesProperty, value);
        }

        public GeneralControls()
        {
            InitializeComponent();
        }
    }
}
