using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.data.model;

namespace WebApplication1.data
{
    public class DBObject
    {
        public static void Initial(AppDBContent content)
        {
            
            
            if (!content.Categori.Any())
                content.Categori.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(

                    new Car
                    {
                        name = "tesla",
                        avialable = 2,
                        img = "https://cdn.motor1.com/images/mgl/Jlr4J/s1/tesla-model-3.jpg",
                        shortdesc = "",
                        longdesc = "",
                        price = 45000,
                        isfavorit = true,
                        Categori = Categories["Электромобили"]
                    } 
                                 );


            }
            content.SaveChanges();
        }
        private static Dictionary<string, Categori> category;
        public static Dictionary<string,Categori> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Categori[] {
                    new Categori{namecategori="Электромобили", desc="Современный вид транспорта"},
                    new Categori{namecategori="Класические автомобили", desc="Автомобили с бензиновым двигателем"}

                    };
                    category = new Dictionary<string, Categori>();
                    foreach (Categori li in list)
                        category.Add(li.namecategori, li);
                }
                return category;
            }

        }


    }
}
