using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moldovan_Andrei.Models;

namespace Moldovan_Andrei.Data
{
    public class Moldovan_AndreiContext : DbContext
    {
        public Moldovan_AndreiContext (DbContextOptions<Moldovan_AndreiContext> options)
            : base(options)
        {
        }

        public DbSet<Moldovan_Andrei.Models.Book> Book { get; set; } = default!;

        public DbSet<Moldovan_Andrei.Models.Publisher> Publisher { get; set; }

        public DbSet<Moldovan_Andrei.Models.Author> Author { get; set; }
    }
}
