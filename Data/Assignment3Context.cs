using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment3.Models;

namespace Assignment3.Data
{
    public class Assignment3Context : DbContext
    {
        public Assignment3Context (DbContextOptions<Assignment3Context> options)
            : base(options)
        {
        }

        public DbSet<Assignment3.Models.Movies> Movies { get; set; } = default!;
    }
}
