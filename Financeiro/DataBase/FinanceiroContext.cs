using Financeiro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Financeiro.DataBase
{
    [DbConfigurationType(typeof(Configuration))]
    public class FinanceiroContext : DbContext
    {
        public DbSet<ControleFinanceiro> ControlesFinanceiros { get; set; }
        public DbSet<CadastroUsuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ControleFinanceiro>().HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }
    }

    internal class Configuration : DbConfiguration
    {
        public Configuration()
        {
            SetMigrationSqlGenerator("Npgsql", () => new SqlGenerator());
        }
    }

}