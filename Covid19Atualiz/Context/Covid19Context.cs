using Covid19Atualiz.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Atualiz.Context
{
    public class Covid19Context : DbContext
    {
        public Covid19Context()
        {

        }

        public Covid19Context(DbContextOptions<Covid19Context> options) : base(options)
        {
        }

        public virtual DbSet<Paciente> paciente { get; set; }
        public virtual DbSet<Login> login { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                        .AddJsonFile("appsettings.json")
                                        .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("ProdutoDataBase"));
            }
        }
    }
}

