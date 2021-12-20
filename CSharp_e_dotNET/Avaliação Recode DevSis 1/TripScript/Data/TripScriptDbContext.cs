using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TripScript.Models;

namespace TripScript.Data
{
    public class TripScriptDbContext : DbContext
    {
        public TripScriptDbContext(DbContextOptions<TripScriptDbContext> Options) : base(Options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Viagem> Viagens { get; set; }
    }
}