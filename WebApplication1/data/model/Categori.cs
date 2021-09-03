using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.data.model
{
    public class Categori
    {
        public int id { set; get; }
        public string  namecategori { set; get; }
        public string desc { set; get; }
        public List<Car> cars { set; get; }
    }
}
