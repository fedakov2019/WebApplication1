using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.data.model
{
    public class Car
    {
        public int id { set; get; }
        public string name { set; get; }
        public string shortdesc { set; get; }
        public string longdesc { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool isfavorit { set; get; }
        public int avialable { set; get; }
        public int categoryid { set; get; }
        public virtual Categori Categori{ set; get; }
    }
}
