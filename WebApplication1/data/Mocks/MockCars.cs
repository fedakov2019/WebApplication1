using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.data.inerfaces;
using WebApplication1.data.model;

namespace WebApplication1.data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategori _categori = new MockCategorj();
        public IEnumerable<Car> Cars {

            get
            {
                return new List<Car>
                {
                    new Car{name="tesla",avialable=2,img="https://cdn.motor1.com/images/mgl/Jlr4J/s1/tesla-model-3.jpg",shortdesc="",longdesc="",price=45000,isfavorit=true,Categori=_categori.Allcategoris.First()},
                    
                };
            }
        }
        public IEnumerable<Car> GetfavCars { get; set; }

        public Car getobjectcar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
