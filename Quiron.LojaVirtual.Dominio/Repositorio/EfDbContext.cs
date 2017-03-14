﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuider)
      {
          modelBuider.Conventions.Remove<PluralizingTableNameConvention>();
          modelBuider.Entity<Produto>().ToTable("Produtos");
      }

    }

}
