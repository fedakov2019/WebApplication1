using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.data.model;

namespace WebApplication1.data.inerfaces
{
    public interface ICarsCategori
    {
        IEnumerable<Categori> Allcategoris { get; }
    }
}
