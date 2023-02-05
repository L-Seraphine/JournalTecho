using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using JournalTecho.View;

namespace JournalTecho.ViewModel
{
    public class SettingsViewModel
    {
        //关闭设置页面命令
        public ICommand CloseSettings { get; set; }
        public ICommand OnSettingsClose { get; set; }
        
        //构造函数
        public SettingsViewModel()
        {
            //关闭窗口
            CloseSettings = new Command((arg)=> {
                Window settings = Settings.GetInstance();
                settings.Visibility = Visibility.Hidden;
            });
        }
    }
}
