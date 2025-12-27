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
        public static BindingList<City> Cities {  get; }
    }
}
