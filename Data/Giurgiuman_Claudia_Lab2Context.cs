using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Giurgiuman_Claudia_Lab2.Models;

namespace Giurgiuman_Claudia_Lab2.Data
{
    public class Giurgiuman_Claudia_Lab2Context : DbContext
    {
        public Giurgiuman_Claudia_Lab2Context (DbContextOptions<Giurgiuman_Claudia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Giurgiuman_Claudia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Giurgiuman_Claudia_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Giurgiuman_Claudia_Lab2.Models.Category> Category { get; set; }
    }
}
