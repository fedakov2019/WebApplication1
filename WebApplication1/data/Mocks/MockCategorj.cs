using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.data.inerfaces;
using WebApplication1.data.model;

namespace WebApplication1.data.Mocks
{
    public class MockCategorj : ICarsCategori
    {
        public IEnumerable<Categori> Allcategoris
        {
get
            {
                return new List<Categori>
                {
                    new Categori{namecategori="Электромобили", desc="Современный вид транспорта"},
                    new Categori{namecategori="Класические автомобили", desc="Автомобили с бензиновым двигателем"}
                };
            }
        }
    }
}
