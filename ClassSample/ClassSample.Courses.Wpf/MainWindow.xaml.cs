using ClassSample.Courses.Wpf.UserControls;
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

namespace ClassSample.Courses.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ucDeparment deparment = new ucDeparment();
            stkMain.Children.Clear();
            stkMain.Children.Add(deparment);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            ucCtity city = new ucCtity();
            stkMain.Children.Clear();
            stkMain.Children.Add(city);
        }
    }
}
