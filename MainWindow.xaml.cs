﻿using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calendar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public CalendarPagexaml calendarPage = new CalendarPagexaml();
        public MainWindow()
        {
            InitializeComponent();

            Content = calendarPage;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            string filePath = JSON.FilePath;

            JSON.Serialize(DateNote.days, filePath);
        }
    }
}
