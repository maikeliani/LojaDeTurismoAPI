using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LojaDeTurismoAPI.Models;

namespace LojaDeTurismoAPI.Data
{
    public class LojaDeTurismoAPIContext : DbContext
    {
        public LojaDeTurismoAPIContext (DbContextOptions<LojaDeTurismoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<LojaDeTurismoAPI.Models.City> City { get; set; } = default!;

        public DbSet<LojaDeTurismoAPI.Models.Address>? Address { get; set; }

        public DbSet<LojaDeTurismoAPI.Models.Client>? Client { get; set; }

        public DbSet<LojaDeTurismoAPI.Models.Ticket>? Ticket { get; set; }
    }
}
