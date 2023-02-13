using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Animation;
using CefSharp.Wpf;
using JournalTecho.View;
using Markdig;

namespace JournalTecho.ViewModel
{
    public class DiaryPageViewModel
    {
        //文件渲染位置
        public static string fileLocation { get; set; }
        //渲染命令
        public ICommand RenderText { get; set; }
        //输入框控件
        private static RichTextBox textBox;
        //渲染框控件
        private static ChromiumWebBrowser chromiumWebBrowser;
        //构造函数
        public DiaryPageViewModel(RichTextBox TextBox, ChromiumWebBrowser ChromiumWebBrowser)
        {
            textBox = TextBox;
            chromiumWebBrowser = ChromiumWebBrowser;
        }
        //渲染页面
        public static void RenderPage()
        {
            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            fileLocation = "D:\\Work Space\\Project\\JournalTecho\\SourceCode\\JournalTecho\\Data\\Test.html";
            File.WriteAllText(fileLocation, Markdown.ToHtml(StringFromRichTextBox(textBox), pipeline));
            chromiumWebBrowser.Address = fileLocation;
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
