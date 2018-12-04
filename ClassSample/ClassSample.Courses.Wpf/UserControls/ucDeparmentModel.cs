using DataAccess.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClassSample.Courses.Wpf.UserControls
{
    public class ucDeparmentModel : INotifyPropertyChanged
    {
        private List<Deparment> _deparments { get; set; }

        public List<Deparment> Deparments
        {
            get { return _deparments; }
            set
            {
                _deparments = value;
                OnPropertyChanged("Deparments");
            }
        }

        public ucDeparmentModel()
        {
            Deparments = DataAccess.DeparmentData.GetDeparments();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
