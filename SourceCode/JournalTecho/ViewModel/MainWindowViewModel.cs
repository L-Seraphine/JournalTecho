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
        //打开首页页面
        public ICommand Main { get; set; }
        //打开日历页面
        public ICommand Calendar { get; set; }
        //打开日记页面
        public ICommand Diary { get; set; }
        //打开点子页面
        public ICommand Idea { get; set; }
        //打开时间轴页面
        public ICommand TimeLine { get; set; }

        //构造函数
        public MainWindowViewModel(Frame mainframe)
        {
            //命令打开窗体
            OpenSetting = new Command((arg)=> {
                Window settings = Settings.GetInstance();   //获取设置页面
                settings.Show();    //显示设置页面
            });

            //打开首页
            Main = new Command((arg) => {
                MainPage mainPage = MainPage.GetMainPage();     //获取首页
                mainframe.Navigate(mainPage);   //导航到首页
            });

            //打开日历
            Calendar = new Command((arg)=> {
                CalendarPage calendarPage = CalendarPage.GetCalendarPage();     //获取日历页面
                mainframe.Navigate(calendarPage);   //导航到日历页面
            });

            //打开日记
            Diary = new Command((arg)=> {
                DiaryPage diaryPage = DiaryPage.GetDiaryPage();     //获取日记页面
                mainframe.Navigate(diaryPage);   //导航到日记页面
            });

            //打开点子
            Idea = new Command((arg) => {
                MessageBox.Show("开发中");
            });

            //打开时间轴
            TimeLine = new Command((arg) => {
                MessageBox.Show("开发中");
            });

        }
        
    }
}
