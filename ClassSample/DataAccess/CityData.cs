using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class CityData
    {
        public static List<City> GetCitiesByDeparment(int DeparmentId)
        {
            List<City> list = new List<City>();

            Connection con = new Connection();

            var datatable = con.GetData($"SELECT ID,NombreCiudad FROM Ciudad Where IdDepartamento ={DeparmentId}");

            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                list.Add(new City() { ID = int.Parse(datatable.Rows[i][0].ToString()), Name = datatable.Rows[i][1].ToString() });
            }

            return list;
        }

    }
}
