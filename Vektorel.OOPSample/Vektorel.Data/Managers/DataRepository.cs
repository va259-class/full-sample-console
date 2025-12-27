using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.Data.Concretes;

namespace Vektorel.Data.Managers
{
    public static class DataRepository
    {
        static DataRepository()
        {
            Cities = new BindingList<City>();
        }

        public static bool AddCity(string name)
        {
            var existing = Cities.FirstOrDefault(c => string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase));
            if (existing is not null)
            {
                return false;                
            }

            var c = new City();
            c.Name = name;

            Cities.Add(c);

            return true;
        }

        public static void AddCounty(City city, string name)
        {
            var county = new County();
            county.Name = name;
            city.Counties.Add(county);
        }
        public static BindingList<City> Cities {  get; }
    }
}
