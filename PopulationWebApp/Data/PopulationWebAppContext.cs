using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PopulationWebApp.Models;

namespace PopulationWebApp.Data
{
    public class PopulationWebAppContext : DbContext
    {
        public PopulationWebAppContext (DbContextOptions<PopulationWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<PopulationWebApp.Models.City> City { get; set; }
    }
}
