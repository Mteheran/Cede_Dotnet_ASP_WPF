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
using System.Windows.Shapes;

namespace ClassSample.Wpf.Views
{
    /// <summary>
    /// Interaction logic for View2.xaml
    /// </summary>
    public partial class View2 : Window
    {
        public View2(bool ShowCloseButton)
        {
            InitializeComponent();        

            btnClose.Visibility = ShowCloseButton ? Visibility.Visible : Visibility.Collapsed;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
