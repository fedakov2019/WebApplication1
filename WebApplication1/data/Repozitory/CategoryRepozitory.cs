using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.data.inerfaces;
using WebApplication1.data.model;

namespace WebApplication1.data.Repozitory
{
    public class CategoryRepozitory : ICarsCategori
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepozitory(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        public IEnumerable<Categori> Allcategoris => appDBContent.Categori;
    }
}
