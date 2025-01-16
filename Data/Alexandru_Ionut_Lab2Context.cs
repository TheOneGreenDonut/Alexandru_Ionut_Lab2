using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Alexandru_Ionut_Lab2.Models;

namespace Alexandru_Ionut_Lab2.Data
{
    public class Alexandru_Ionut_Lab2Context : DbContext
    {
        public Alexandru_Ionut_Lab2Context (DbContextOptions<Alexandru_Ionut_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } = default!;
        public DbSet<Publisher> Publisher { get; set; } = default!;
    }
}
