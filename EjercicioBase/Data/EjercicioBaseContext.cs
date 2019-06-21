using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EjercicioBase.Models;

    public class EjercicioBaseContext : DbContext
    {
        public EjercicioBaseContext (DbContextOptions<EjercicioBaseContext> options)
            : base(options)
        {
        }

        public DbSet<EjercicioBase.Models.Categoria> Categoria { get; set; }
    }
