using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utazasok.Model
{
    internal class FlightContext :DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Populacio> populaciok { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "HP-PAVILON-15-L";
            builder.InitialCatalog = "utazasok";
            builder.Authentication = SqlAuthenticationMethod.SqlPassword;
            builder.UserID = @"laci";
            builder.Password = "Laci1234";
            optionsBuilder.UseSqlServer(builder.ConnectionString);
        }
    }
}
