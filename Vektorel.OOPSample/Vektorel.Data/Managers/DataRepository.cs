using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.Data.Concretes;

namespace Vektorel.Data.Managers
{
    public delegate void CountyUpdated(City city);
    public static class DataRepository
    {
        static DataRepository()
        {
            Cities = new BindingList<City>();
        }

        public static event CountyUpdated OnCountyUpdated;

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
            OnCountyUpdated?.Invoke(city);
        }

        public static void UpdateCountyCapacity(City city, County county, double capacity)
        {
            var exactCounty = city.Counties.FirstOrDefault(c => c.Id == county.Id);
            if (exactCounty is null)
            {
                return;
            }

            exactCounty.Capacity = capacity;
            if (OnCountyUpdated is not null)
            {
                OnCountyUpdated.Invoke(city);
            }
        }

        public static void UpdateCountyPopulation(City city, County county, uint population)
        {
            var exactCounty = city.Counties.FirstOrDefault(c => c.Id == county.Id);
            if (exactCounty is null)
            {
                return;
            }

            exactCounty.Population = population;

            //yukarıdaki kullanım ile aynı
            OnCountyUpdated?.Invoke(city);
        }
        public static BindingList<City> Cities { get; }
    }
}
