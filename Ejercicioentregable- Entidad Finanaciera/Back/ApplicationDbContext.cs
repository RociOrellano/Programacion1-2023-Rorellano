using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Back
{
    public class ApplicationDbContext : DbContext 

    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cuenta_Bancaria> CuentasBancarias { get; set; }
        public DbSet<Tarjeta_de_Crédito> TarjetasDeCredito { get; set; }
        public DbSet<Transacciones> Transacciones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ROCIORELLANO;database=BdEntidadFinanciera;trusted_connection=true;encrypt=False");
        }
    }
}
