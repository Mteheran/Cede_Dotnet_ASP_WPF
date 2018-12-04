using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample.Courses.Wpf.UserControls
{
    public class ucCityModel : INotifyPropertyChanged
    {
        public Deparment _selectedDeparment { get; set; }

        public Deparment SelectedDeparment
        {
            get { return _selectedDeparment; }
            set
            {
                _selectedDeparment = value;
                OnPropertyChanged("SelectedDeparment");
                Cities = DataAccess.CityData.GetCitiesByDeparment(_selectedDeparment.ID);
            }
        }

        public List<Deparment> _deparments { get; set; }

        public List<Deparment> Deparments
        {
            get { return _deparments; }
            set
            {
                _deparments = value;
                OnPropertyChanged("Deparments");
            }
        }

        public List<City> _cities { get; set; }

        public List<City> Cities
        {
            get { return _cities; }
            set
            {
                _cities = value;
                OnPropertyChanged("Cities");
            }
        }


        public OrderMode _selectedOrdeMode { get; set; }

        public OrderMode SelectedOrderMode
        {
            get { return _selectedOrdeMode; }
            set
            {
                _selectedOrdeMode = value;
                OnPropertyChanged("SelectedOrderMode");

                if (Deparments != null)
                {
                    if (SelectedOrderMode.Name == "Ascendente")
                    {
                        Deparments = Deparments.OrderBy(p => p.Name).ToList();
                    }
                    else
                    {
                        Deparments = Deparments.OrderByDescending(p => p.Name).ToList();
                    }

                    OnPropertyChanged("Deparments");
                }
                
            }
        }

        public List<OrderMode> _OrderModes { get; set; }

        public List<OrderMode> OrderModes
        {
            get { return _OrderModes; }
            set
            {
                _OrderModes = value;
                OnPropertyChanged("OrderModes");
            }
        }

        public ucCityModel()
        {
            Deparments = DataAccess.DeparmentData.GetDeparments();
            List<OrderMode> orderModes = new List<OrderMode>();
            orderModes.Add(new OrderMode() { Name="Ascendente" } );
            orderModes.Add(new OrderMode() { Name = "Descendente" });
            OrderModes = orderModes;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
