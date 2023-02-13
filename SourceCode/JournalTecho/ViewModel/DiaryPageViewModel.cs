using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using CefSharp.Wpf;
using JournalTecho.View;
using Markdig;

namespace JournalTecho.ViewModel
{
    public class DiaryPageViewModel
    {
        //文件渲染位置
        public static string FileLocation { get; set; }
        //选择文件夹命令
        public ICommand SelectFolder { get; set; }
        //输入框控件
        private static RichTextBox textBox;
        //渲染框控件
        private static ChromiumWebBrowser chromiumWebBrowser;
        //构造函数
        public DiaryPageViewModel(RichTextBox TextBox, ChromiumWebBrowser ChromiumWebBrowser)
        {
            textBox = TextBox;
            chromiumWebBrowser = ChromiumWebBrowser;
            //打开文件夹命令
            SelectFolder = new Command((arg) => {

            });
        }
        //渲染页面
        public static void RenderPage()
        {
            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            FileLocation = "D:\\Work Space\\Project\\JournalTecho\\SourceCode\\JournalTecho\\Data\\Test.html";
            File.WriteAllText(FileLocation, Markdown.ToHtml(StringFromRichTextBox(textBox), pipeline));
            chromiumWebBrowser.Address = FileLocation;
        }
        //获取RichTextBox中的内容
        static string StringFromRichTextBox(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(
                rtb.Document.ContentStart,
                rtb.Document.ContentEnd
            );
            return textRange.Text;
        }
    }
}
