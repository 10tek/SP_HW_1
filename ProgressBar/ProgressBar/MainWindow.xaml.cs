﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ProgressBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int num = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            num = 0;
            pb1.Value = 0;
            pb2.Value = 0;
            pb3.Value = 0;
            pb4.Value = 0;
        }

        private void WindowMouseMove(object sender, MouseEventArgs e)
        {
            if (num <= 100)
            {
                pb1.Value = num++;
            }
            else if (num <= 200)
            {
                pb2.Value = num++ - 100;
            }
            else if(num <= 300)
            {
                pb4.Value = num++ - 200;
            }
            else
            {
                pb3.Value = num++ - 300;
            }
            Thread.Sleep(20);
        }
    }
}
