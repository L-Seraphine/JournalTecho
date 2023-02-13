using System;   
using System.Collections.Generic;
using System.Configuration;
using System.Windows;

namespace JournalTecho.ViewModel
{
    //配置文件公告类，抽象类，无法实例化
    public class Config
    {
        //配置文件实例
        public static Configuration config = null;
        //类似于单例，节约CPU时间
        public static void Singleton()
        {
            if (config == null)
            {
                //读取配置文件
                config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            }
        }
        //写入配置文件
        public static bool WriteConfigFile(string key,string value)
        {
            Singleton();
            config.AppSettings.Settings[key].Value = value; //写入值
            config.Save(ConfigurationSaveMode.Modified);    //保存值
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");    //更新内存中的配置文件内容
            return true;
        }
        //读取配置文件
        public static object ReadConfigFile(string key)
        {
            Singleton();
            //返回对应的键值
            return config.AppSettings.Settings[key].Value;
        }
    }
}
