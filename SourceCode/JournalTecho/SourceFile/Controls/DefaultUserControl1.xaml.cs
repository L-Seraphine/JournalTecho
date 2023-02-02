using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace JournalTecho.SourceFile.Controls
{
    /// <summary>
    /// DefaultUserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class DefaultUserControl1 : UserControl
    {
        //【注册自定义属性】
        //标题属性（默认值：标题）
        public static DependencyProperty TitlesProperty =
            DependencyProperty.Register("Titles", typeof(string), typeof(DefaultUserControl1), new PropertyMetadata("标题"));
        //标题字体大小属性（默认值：12）
        public static DependencyProperty TitleFontSizeProperty =
            DependencyProperty.Register("TitleFontSize", typeof(string), typeof(DefaultUserControl1), new PropertyMetadata("12"));
        //内容属性（默认值：内容）
        public static DependencyProperty TextsProperty =
            DependencyProperty.Register("Texts", typeof(string), typeof(DefaultUserControl1), new PropertyMetadata("内容"));

        //【定义自定义属性】
        [BindableAttribute(true)]
        public string Titles
        {
            get { return (string)GetValue(TitlesProperty); }
            set { SetValue(TitlesProperty, value); }
        }
        public string Texts
        {
            get { return (string)GetValue(TextsProperty); }
            set { SetValue(TextsProperty, value); }
        }
        public string TitleFontSize
        {
            get { return (string)GetValue(TitleFontSizeProperty); }
            set { SetValue(TitleFontSizeProperty, value); }
        }

        //【构造函数】
        public DefaultUserControl1()
        {
            InitializeComponent();
        }

    }
}
