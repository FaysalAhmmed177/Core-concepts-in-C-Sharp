using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UMS.Models;

namespace UMS.Data
{
    public class UMSContext : DbContext
    {
        public UMSContext (DbContextOptions<UMSContext> options)
            : base(options)
        {
        }

        public DbSet<UMS.Models.Student> Student { get; set; }
    }
}
