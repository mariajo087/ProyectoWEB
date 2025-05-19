using Microsoft.EntityFrameworkCore;

using ProyectoWEB.Models;
using System.Collections.Generic;

namespace ProyectoWEB.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Prestamo> Prestamo { get; set; }
    }
}


