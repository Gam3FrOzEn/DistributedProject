using Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class HotDogDBContext : DbContext
    {
        public DbSet<HotDog> HotDogs { get; set; } // s DBSet se otbelqzva i suzdava tablicata
        public DbSet<Client> Clients { get; set; } // purvoto e modela, vtoroto e imeto na tablicata
        public DbSet<Sale> Sales { get; set; }
        
    }
}
