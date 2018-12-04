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

namespace ClassSample.Courses.Wpf.UserControls
{
    /// <summary>
    /// Interaction logic for ucDeparment.xaml
    /// </summary>
    public partial class ucDeparment : UserControl
    {
        ucDeparmentModel deparmentModel { get; set; } = new ucDeparmentModel();

        public ucDeparment()
        {
            InitializeComponent();

            this.DataContext = deparmentModel;
        }
    }
}
