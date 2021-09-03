using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.data.model;

namespace WebApplication1.ViewModels
{
    public class CarsListViewModal
    {
        public IEnumerable<Car> getAllCars { get; set; }
        public string curCategori { get; set; }
    }
}
