﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                //new System.Globalization.CultureInfo("uk");
                new System.Globalization.CultureInfo("de-DE");
        }
    }
}
