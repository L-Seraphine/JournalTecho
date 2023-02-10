using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using JournalTecho.View;

namespace JournalTecho.ViewModel
{
    public class MainWindowViewModel
    {
        //打开设置窗口
        public ICommand OpenSetting { get; set; }
        //打开日历页面
        public ICommand Calendar { get; set; }
        //打开首页页面
        public ICommand Main { get; set; }

        //构造函数
        public MainWindowViewModel(Frame mainframe)
        {
            //命令打开窗体
            OpenSetting = new Command((arg)=> {
                Window settings = Settings.GetInstance();   //获取设置页面
                settings.Show();    //显示设置页面
            });

            //打开日历
            Calendar = new Command((arg)=> {
                CalendarPage calendarPage = CalendarPage.GetCalendarPage();     //获取日历页面
                mainframe.Navigate(calendarPage);   //导航到日历页面
            });

            //打开首页
            Main = new Command((arg) => {
                MainPage mainPage = MainPage.GetMainPage();     //获取首页
                mainframe.Navigate(mainPage);   //导航到首页
            });
        }
        
    }
}
