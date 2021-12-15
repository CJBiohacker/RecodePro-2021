using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TripScript.Models;

namespace TripScript.Data
{
    public class TripScriptContext : DbContext
    {
        public TripScriptContext(DbContextOptions<TripScriptContext> Options) : base(Options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Viagem> Viagens { get; set; }

    }
}