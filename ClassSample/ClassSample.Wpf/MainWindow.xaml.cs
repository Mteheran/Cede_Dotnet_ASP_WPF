using ClassSample.Wpf.Views;
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

namespace ClassSample.Wpf
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

        private void BtnValidate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtField1.Text))
            {
                MessageBox.Show("El campo 1 es requerido");

                return;
            }
        }

        private void BtnShowView_Click(object sender, RoutedEventArgs e)
        {
            switch (((ComboBoxItem)cbViews.SelectedItem).Tag)
            {
                case "View1":
                    View1 view1 = new View1();
                    view1.Show();
                    break;
                case "View2":
                    View2 view2 = new View2(false);
                    view2.Show();
                    break;
                case "View3":
                    View3 view3 = new View3();
                    view3.Show();
                    break;
                case "ucDemo":
                case "ucDemo2":
                    MessageBox.Show("Los user controls no pueden salir en ventanas");
                    break;
            }
        }

        private void AddView_Click(object sender, RoutedEventArgs e)
        {
            switch (((ComboBoxItem)cbViews.SelectedItem).Tag)
            {
                case "View1":    
                case "View2":
                case "View3":
                    MessageBox.Show("Las ventanas no se pueden adjuntar");
                    break;

                case "ucDemo":
                    ucDemo ucDemo = new ucDemo();
                    stkContent.Children.Clear();
                    stkContent.Children.Add(ucDemo);
                    break;

                case "ucDemo2":
                    ucDemo2 ucDemo2 = new ucDemo2();
                    stkContent.Children.Clear();
                    stkContent.Children.Add(ucDemo2);
                    break;
            }
        }
    }
}
