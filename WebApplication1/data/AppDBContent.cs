using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.data.model;

namespace WebApplication1.data
{
    public class AppDBContent:DbContext
    {public AppDBContent(DbContextOptions<AppDBContent> options): base(options)
        {

        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Categori> Categori { get; set; }
    }
}
