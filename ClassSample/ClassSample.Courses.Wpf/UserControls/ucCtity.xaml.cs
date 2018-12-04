using DataAccess.Models;
using System.Windows.Controls;

namespace ClassSample.Courses.Wpf.UserControls
{
    /// <summary>
    /// Interaction logic for ucCtity.xaml
    /// </summary>
    public partial class ucCtity : UserControl
    {
        ucCityModel cityModel { get; set; } = new ucCityModel();

        public ucCtity()
        {
            InitializeComponent();

            this.DataContext = cityModel;
        }
    }
}
