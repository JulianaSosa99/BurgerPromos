using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrePrueba.Models;

    public class PrePruebaContext : DbContext
    {
        public PrePruebaContext (DbContextOptions<PrePruebaContext> options)
            : base(options)
        {
        }

        public DbSet<PrePrueba.Models.Burger> Burger { get; set; } = default!;
    }
