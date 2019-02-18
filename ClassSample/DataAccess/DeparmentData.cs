using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DeparmentData
    {
        public static List<Deparment> GetDeparments()
        {
            List<Deparment> list = new List<Deparment>();

            Connection con = new Connection();

            var datatable = con.GetData("SELECT ID,NombreDepartamento FROM Departamento");

            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                list.Add(new Deparment() { ID =int.Parse(datatable.Rows[i][0].ToString()),  Name = datatable.Rows[i][1].ToString() });
            }

            return list;
        }

        public static Deparment GetDeparmentByID(int Id)
        {
            var deparment = new Deparment();

            Connection con = new Connection();

            var datatable = con.GetData($"SELECT ID,NombreDepartamento FROM Departamento WHERE ID={Id}");

            deparment = new Deparment() { ID = int.Parse(datatable.Rows[0][0].ToString()), Name = datatable.Rows[0][1].ToString() };
      
            return deparment;
        }

        public static bool UpdateDeparment(Deparment deparment)
        {
            string query = $@"
                            UPDATE departamento
                            SET Nombredepartamento = '{deparment.Name}'
                            WHERE ID = {deparment.ID}
                                ";


            Connection con = new Connection();

            return con.Execute(query);
        }    
    }
}
