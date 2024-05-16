using Microsoft.EntityFrameworkCore;

namespace PruebaNet8_BlazorServer_AndresCueva.Models
{
    public class EmpleadoContext : DbContext
    {
        public DbSet<EmpleadosDTO> Empleados { get; set;}
        public DbSet<DepartamentosDTO> Dpto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-FTFNV0M\\MSSQLSERVER2014;Initial Catalog=blazortest;User ID=sa;Password=DiosEsMiGuia2024;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            //base.OnConfiguring(optionsBuilder);

        }
        //public EmpleadoContext(DbContextOptions<EmpleadoContext> options)
        //  : base(options)
        //{

        //}

    }
}
