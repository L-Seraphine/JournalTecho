using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using JournalTecho.View;

namespace JournalTecho.ViewModel
{
    public class MainWindowViewModel
    {
        //设置命令属性
        public ICommand OpenSetting { get; set; }
        //构造函数
        public MainWindowViewModel()
        {
            //命令打开窗体
            OpenSetting = new Command((arg)=> {
                Window settings = Settings.GetInstance();
                settings.Show();
            });
        }
        
    }
}
