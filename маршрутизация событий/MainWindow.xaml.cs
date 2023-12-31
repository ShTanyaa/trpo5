﻿using System;
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
using маршрутизация_событий.Pages;

namespace маршрутизация_событий
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private Page[] pages = new Page[]
        {
        new RoutingPage(),
        new AttacheEventsPage(),
        new TextBoxPage(),
        new ValidationInputPage()
        };
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combo.SelectedIndex == 0)
            {
                Frame.Navigate(pages[0]);
            }
            if (combo.SelectedIndex == 1)
            {
                Frame.Navigate(pages[1]);
            }
            if (combo.SelectedIndex == 2)
            {
                Frame.Navigate(pages[2]);
            }
            if (combo.SelectedIndex == 3)
            {
                Frame.Navigate(pages[3]);
            }
        }
    }
}
