using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.data.inerfaces;
using WebApplication1.data.model;

namespace WebApplication1.data.Repozitor
{
    public class CarRepozitory : IAllCars

    {
        private readonly AppDBContent appDBContent;
        public CarRepozitory(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Car> Cars => appDBContent.Car.Include(d=> d.Categori);

        public IEnumerable<Car> GetfavCars  => appDBContent.Car.Where(c=>c.isfavorit).Include(d => d.Categori);

        public Car getobjectcar(int id) => appDBContent.Car.FirstOrDefault(d => d.id==id);
        
    }
}
