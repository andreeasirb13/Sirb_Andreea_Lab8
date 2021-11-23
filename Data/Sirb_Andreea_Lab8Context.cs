using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sirb_Andreea_Lab8.Models;

namespace Sirb_Andreea_Lab8.Data
{
    public class Sirb_Andreea_Lab8Context : DbContext
    {
        public Sirb_Andreea_Lab8Context (DbContextOptions<Sirb_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Sirb_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Sirb_Andreea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Sirb_Andreea_Lab8.Models.Category> Category { get; set; }
    }
}
