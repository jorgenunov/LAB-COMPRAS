using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Primeira.Models
{
    public class LabComrpasBdContext : DbContext
    {

        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Conta> Contas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection =
            @"Server=(localdb)\mssqllocaldb;Database=DA2_2018_LABCOMPRAS;
            Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connection);
        }

    }
}
