﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Threading.Tasks;
using System.Windows;

namespace Calendar
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        void startApp(Object sender, EventArgs e)
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            MainWindow window = new MainWindow(month, year);
            window.Show();
        }
    }
}
