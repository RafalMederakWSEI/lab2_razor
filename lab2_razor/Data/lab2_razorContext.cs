using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab2_razor.Pages.Models;

namespace lab2_razor.Data
{
    public class lab2_razorContext : DbContext
    {
        public lab2_razorContext (DbContextOptions<lab2_razorContext> options)
            : base(options)
        {
        }

        public DbSet<lab2_razor.Pages.Models.Post> Post { get; set; } = default!;
    }
}
