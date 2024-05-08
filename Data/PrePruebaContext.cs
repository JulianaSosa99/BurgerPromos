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
        public DbSet<PrePrueba.Models.Promo> Promo { get; set; } = default!; //clase de contexto representa a la base de datos
    //aca se añade a la nueva tabla

}
//hola